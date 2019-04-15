using System;
using System.Windows.Forms;

namespace x42Gui.Forms
{
    public partial class MessageForm : Form
    {
        public MessageForm()
        {
            InitializeComponent();
        }

        public DialogResult Show(string messageText,string title)
        {
            Text = String.IsNullOrEmpty(title) ? Application.ProductName : title;
            label1.Text = messageText;
            return (ShowDialog());
        }

        public string InputBox(string prompt, string title = "", string defaultResponse = "", int xpos = 0, int ypos = 0)
        {
            label1.Text = prompt;
            textBox1.Text = defaultResponse;
            Text = String.IsNullOrEmpty(title) ? Application.ProductName : title;

            if (xpos != 0) Left = xpos;
            if (ypos != 0) Top = ypos;

            var resultCode = ShowDialog();
            if (resultCode == DialogResult.OK)
            {
                if (String.IsNullOrEmpty(textBox1.Text))
                {
                    return defaultResponse;
                }
                return textBox1.Text;
            }

            return String.Empty;
        }
    }
}
