using System;
using System.Windows.Forms;

namespace x42Gui.Forms
{
    public partial class PasswordForm : Form
    {
        public string Password
        {
            get { return textBoxPassword.Text.Trim(); }
        }

        public PasswordForm()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
