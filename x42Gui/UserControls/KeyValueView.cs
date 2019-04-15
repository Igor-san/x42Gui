using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace x42Gui.UserControls
{
    public partial class KeyValueView : UserControl
    {
        [Description("Шрифт ключа"), Category("Appearance")]
        public Font KeyFont
        {
            get { return labelKey.Font; }
            set { labelKey.Font = value; }
        }

        [Description("Шрифт значения"), Category("Appearance")]
        public Font ValueFont
        {
            get { return labelValue.Font; }
            set { labelValue.Font = value; }
        }

        public KeyValueView()
        {
            InitializeComponent();
        }

        public void SetKey(string key)
        {
            labelKey.Text = key;
        }
        public void SetValue(string value)
        {
            labelValue.Text = value;
        }

        public void SetKeyValue(string key, string value)
        {
            labelKey.Text = key;
            labelValue.Text = value;

        }

    }
}
