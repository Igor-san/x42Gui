using x42Gui.Models;
using NBitcoin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace x42Gui.Classes
{
    public class SpendableTransactions
    {
        public override string ToString()
            => $"TxId:{TxId}, Index:{TxId}, Index: {Amount}, Confirmations: {Confirmations}";


        public SpendableTransactions()
        {

        }

        public SpendableTransactions(SpendableTransactionModel item)
        {
            this.TxId = item.Id;
            this.Index = item.Index;

            this.Title = $"{TxId}:{Index}";
            this.Address = item.Address;
            this.Time = item.CreationTime.DateTime;
            this.Amount = item.Amount;
            this.Confirmations = item.Confirmations;

            this.IsChange = item.IsChange;
        }

        public uint256 TxId { get; set; }
        public int Index { get; set; }
        public bool IsChange { get; set; }
        public bool Checked { get; set; }
        public string Title { get; set; }
        public string Address;

        public DateTime Time { get; set; }

        public Money Amount { get; set; }

        public int Confirmations;

        static internal (int, Money) SelectedAmount
        {
            get
            {
                int count = Wallets.SelectMany(x => x.Accounts).SelectMany(x => x.Addresses).SelectMany(x => x.SpendableTransactionsForAddress).Where(x => x.Checked).Count();
                Money amount = Wallets.SelectMany(x => x.Accounts).SelectMany(x => x.Addresses).SelectMany(x => x.SpendableTransactionsForAddress).Where(x => x.Checked).Select(_ => _.Amount).Sum();
                return (count, amount);
            }
        }

        static internal List<Wallet> Wallets = new List<Wallet>();

        /// <summary>
        /// Очистить все
        /// </summary>
        internal static void ClearAll()
        {
            Wallets.Clear();
        }

    }

    public class Wallet
    {
        public Wallet(string name)
        {
            this.Title = name;
            this.Accounts = new List<Account>();
            this.Amount = Money.Zero;
        }

        public string Title { get; set; }

        public List<Account> Accounts { get; private set; }

        public Money Amount { get; set; }

        public DateTime Time { get; set; }

        public int Confirmations { get; set; }

        /// <summary>
        /// Для определения что отметили более 1 аккаунта
        /// </summary>
        public int AccountChecked
        {
            get
            {
                return Accounts.Count(_ => _.Checked != CheckState.Unchecked);
            }
        }

        public CheckState Checked
        {
            get
            {
                //Accounts может и не быть
                if (Accounts.Count() == 0)
                {
                    return CheckState.Unchecked;
                }
                if (Accounts.Count(_ => _.Checked == CheckState.Indeterminate) > 0)
                {
                    return CheckState.Indeterminate; //хотя бы один отмечен Indeterminate 
                }
                int check = Accounts.Count(_ => _.Checked == CheckState.Checked);
                if (check > 0 && check == Accounts.Count())
                {
                    return CheckState.Checked;
                }
                int uncheck = Accounts.Count(_ => _.Checked == CheckState.Unchecked);
                if (uncheck > 0 && uncheck == Accounts.Count())
                {
                    return CheckState.Unchecked;
                }

                return CheckState.Indeterminate;
            }
        }

        public IEnumerable<SpendableTransactions> SelectedTransactions
        {
            get
            {
                return Accounts.SelectMany(x => x.SelectedTransactions);
            }
        }
    }

    public class Account
    {

        public CheckState Checked
        {
            get
            {
                //Адресов может и не быть
                if (Addresses.Count() == 0)
                {
                    return CheckState.Unchecked;
                }

                if (Addresses.Count(_ => _.Checked == CheckState.Indeterminate) > 0)
                {
                    return CheckState.Indeterminate; //хотя бы один отмечен Indeterminate 
                }
                int check = Addresses.Count(_ => _.Checked == CheckState.Checked);
                if (check > 0 && check == Addresses.Count())
                {
                    return CheckState.Checked;
                }
                int uncheck = Addresses.Count(_ => _.Checked == CheckState.Unchecked);
                if (uncheck > 0 && uncheck == Addresses.Count())
                {
                    return CheckState.Unchecked;
                }

                return CheckState.Indeterminate;

            }
        }

        public Account(string name)
        {
            this.Title = name;
            this.Addresses = new List<Address>();
            Amount = Money.Zero;
        }

        public string Title { get; }

        public List<Address> Addresses { get; set; }

        public Money Amount { get; set; }

        public DateTime Time;

        public int Confirmations;

        public IEnumerable<SpendableTransactions> SelectedTransactions
        {
            get
            {
                return Addresses.SelectMany(x => x.SelectedTransactions);
            }
        }
        /// <summary>
        /// Распределим транзакции по адресам и добавим это в аккаунт
        /// </summary>
        /// <param name="spendableTransactions"></param>
        internal void AddSpendableTransactions(List<SpendableTransactionModel> spendableTransactions)
        {
            foreach (var item in spendableTransactions)
            {
                int index = this.Addresses.FindIndex(x => x.Title == item.Address);
                SpendableTransactions st = new SpendableTransactions(item);
                if (index >= 0)
                {
                    this.Addresses[index].SpendableTransactionsForAddress.Add(st);
                    this.Addresses[index].Amount += st.Amount;
                }
                else
                {
                    Address address = new Address(st);
                    this.Addresses.Add(address);
                }

                this.Amount += item.Amount;
            }
        }

    }

    public class Address
    {
        //теоретически адрес может принадлежать разным кошелькам (но не аккаунтам в одном адресе)
        public Address(SpendableTransactions st)
        {
            this.Title = st.Address;
            this.Amount = st.Amount;
            this.SpendableTransactionsForAddress = new List<SpendableTransactions>();
            this.SpendableTransactionsForAddress.Add(st);
        }

        public string Title { get; }

        public List<SpendableTransactions> SpendableTransactionsForAddress { get; set; }

        public Money Amount { get; set; }

        public CheckState Checked
        {
            get
            {
                int count = SpendableTransactionsForAddress.Count(_ => _.Checked);

                if (count == 0)
                    return CheckState.Unchecked;
                else if (count == SpendableTransactionsForAddress.Count)
                    return CheckState.Checked;
                else
                    return CheckState.Indeterminate;
            }
        }

        public DateTime Time;
        public int Confirmations;

        public IEnumerable<SpendableTransactions> SelectedTransactions
        {
            get
            {
                return SpendableTransactionsForAddress.Where(x => x.Checked);
            }
        }
    }
}
