using System;
using System.Windows.Forms;

namespace x42Gui.Forms
{
    public partial class CoinControlForm : Form
    {
        public CoinControlForm()
        {
            InitializeComponent();
            spendableTransactionsView1.OkButtonClick += new EventHandler(OkButtonClick);
            spendableTransactionsView1.CancelButtonClick += new EventHandler(CancelButtonClick);
            spendableTransactionsView1.SelectionChanged += new EventHandler(SelectionChanged);
        }

        public void OkButtonClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
        public void CancelButtonClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        public void SelectionChanged(object sender, EventArgs e)
        {
            ;
        }

        private void CoinControlForm_Load(object sender, EventArgs e)
        {
            spendableTransactionsView1.GetSpendableTransactions();
        }
    }
}
