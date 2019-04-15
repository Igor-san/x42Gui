using NBitcoin;
using System;
using System.Windows.Forms;
using x42Gui.Classes;

namespace x42Gui.Forms
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();

        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            SaveOptions();
            Close();
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            numericUpDownMinTxFee.Value = Common.CurrentSettings.MinTxFee.ToDecimal(MoneyUnit.BTC);

            radioButtonStratis.Checked = Common.CurrentSettings.IsStratis;

            radioButtonMainnet.Checked = Common.CurrentSettings.Mainnet;
            radioButtonTestnet.Checked = !radioButtonMainnet.Checked;

            textBoxMainApiUrl.Text = Common.CurrentSettings.MainApiUrl;
            textBoxTestApiUrl.Text = Common.CurrentSettings.TestApiUrl;

        }

        private void SaveOptions()
        {
            Common.CurrentSettings.MinTxFee = Money.FromUnit(numericUpDownMinTxFee.Value, MoneyUnit.BTC);

            Common.CurrentSettings.IsStratis = radioButtonStratis.Checked;

            Common.CurrentSettings.MainApiUrl = textBoxMainApiUrl.Text.Trim();

            Common.CurrentSettings.TestApiUrl = textBoxTestApiUrl.Text.Trim();

            Common.CurrentSettings.Mainnet = radioButtonMainnet.Checked;

            Common.CurrentSettings.Save();
        }

        private void buttonFromX42_Click(object sender, EventArgs e)
        {
            radioButtonX42.Checked = true;
            numericUpDownMinTxFee.Value = 0;
            textBoxMainApiUrl.Text = "http://localhost:42220/api/";
            textBoxTestApiUrl.Text = "http://localhost:42221/api/";
        }

        private void buttonFromStratis_Click(object sender, EventArgs e)
        {
            radioButtonStratis.Checked = true;
            numericUpDownMinTxFee.Value = 0.0001M;
            textBoxMainApiUrl.Text = "http://localhost:37221/api/";
            textBoxTestApiUrl.Text = "http://localhost:38221/api/";
        }
    }
}
