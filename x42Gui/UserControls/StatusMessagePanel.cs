using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyProject.UserControls
{
    /// <summary>
    /// Тип информационного сообщения.
    /// </summary>
    public enum MessagesTypes
    {
        Info, //Просто информация, подключились, на сервере столько-то ордеров, новых ордеров нет. Может не отображаться, если задано
        Attention, //Важная информация, например, новый ордер
        Warning, //Внимание!
        Error, //Ошибка
        Success, //Порядок
        Normal,//Обычный текст без выделения
    }

    public partial class StatusMessagePanel : UserControl
    {
        private int _PanelBottomHeight;

        public delegate void EventHandler(Object sender, EventArgs e);


        bool _IsCollapsed;
        /// <summary>
        /// Свернуть или развернуть окно сообщений
        /// </summary>
        public bool IsCollapsed
        {
            get
            {
                return _IsCollapsed;
            }
            set
            {
                if (value != _IsCollapsed)
                    SetCollapsed(value);
            }
        }
        public StatusMessagePanel()
        {
            InitializeComponent();

            _PanelBottomHeight = this.Height;
            buttonCollapseStatusBar.Tag = 1;
        }

        /// <summary>
        /// Очистка окна сообщения
        /// </summary>
        public void StatusClear()
        {
            textBoxMessages.Clear();
        }
        /// <summary>
        /// Вывод сообщения в окно
        /// </summary>
        /// <param name="text">текст сообщения</param>
        public void StatusMessage(string text)
        {
            StatusMessage(text, MessagesTypes.Normal, true);
        }

        /// <summary>
        /// Выводим сообщение в окно лога
        /// </summary>
        /// <param name="text">сообщение</param>
        /// <param name="inStart">true- сообщение в начало лога,false -в конец</param>

        public void StatusMessage(string text, bool inStart)
        {
            StatusMessage(text, MessagesTypes.Normal, inStart);
        }

        /// <summary>
        /// Выводим сообщение в окно лога. Последнее в начало
        /// </summary>
        /// <param name="msg">сообщение</param>
        /// <param name="type">Тип сообщения: Важно,Ошибка,Предупреждение</param>
        public void StatusMessage(string msg, MessagesTypes type)
        {
            StatusMessage(msg, type, true);
        }

        /// <summary>
        /// Исправить выделение цветом при записи в начало файла!
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="type"></param>
        /// <param name="inStart"></param>
        public void StatusMessage(string msg, MessagesTypes type, bool inStart)
        {
            try
            {
                BeginInvoke(new Action(() => //из потоков
                {
                if (textBoxMessages == null || textBoxMessages.IsDisposed) return;

                if (inStart) textBoxMessages.Select(0, 0);

                System.Drawing.FontStyle newFontStyle;
                string symbol = "";
                switch (type)
                {
                    case MessagesTypes.Info:
                        symbol = "";
                        break;
                    case MessagesTypes.Attention:
                        symbol = "! "; //Важная инфа к вниманию
                        newFontStyle = FontStyle.Bold;
                        textBoxMessages.SelectionFont = new Font(
                                textBoxMessages.Font.FontFamily,
                                textBoxMessages.Font.Size,
                                newFontStyle
                             );
                        textBoxMessages.SelectionColor = Color.Green;
                        textBoxMessages.SelectedText = symbol;
                        break;

                    case MessagesTypes.Warning:
                        symbol = "!! "; //Предупреждение
                        newFontStyle = FontStyle.Bold;
                        textBoxMessages.SelectionFont = new Font(
                                textBoxMessages.Font.FontFamily,
                                textBoxMessages.Font.Size,
                                newFontStyle
                             );

                        textBoxMessages.SelectionColor = Color.LightPink;
                        textBoxMessages.SelectedText = symbol;
                        break;
                    case MessagesTypes.Error:
                        symbol = "!!! "; // Ошибка
                        newFontStyle = FontStyle.Bold;
                        textBoxMessages.SelectionFont = new Font(
                               textBoxMessages.Font.FontFamily,
                               textBoxMessages.Font.Size,
                               newFontStyle
                            );
                        textBoxMessages.SelectionColor = Color.Red;
                        textBoxMessages.SelectedText = symbol;

                            if (IsCollapsed) //если свернуто то подсветим
                            {
                                panelTop.BackColor = Color.Red;
                            }
                            break;
                }

                newFontStyle = FontStyle.Regular;
                textBoxMessages.SelectionFont = new Font(
                        textBoxMessages.Font.FontFamily,
                        textBoxMessages.Font.Size,
                        newFontStyle
                     );

                if (type != MessagesTypes.Normal) //Для нормального не отображаем время и не выделяем
                {
                    string time = DateTime.Now.ToString();
                    textBoxMessages.SelectionColor = Color.Blue; //выбираем цвет отображения
                    textBoxMessages.SelectedText = time + ": "; //задаем выделения текста и выводим его
                }

                textBoxMessages.SelectionColor = Color.Black;

                textBoxMessages.SelectedText = (msg + Environment.NewLine);
                }
             ));
            }
            catch 
            {

            }
        }

        private void logClearButton_Click(object sender, EventArgs e)
        {
            textBoxMessages.Clear();
        }

        private void buttonCollapseStatusBar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(buttonCollapseStatusBar.Tag) == 1) //Развернут, надо свернуть
            {
                SetCollapsed(true);
            }
            else //надо развернуть
            {
                SetCollapsed(false);
            }

        }


        /// <summary>
        /// Свернуть или развернуть окно
        /// </summary>
        /// <param name="collapse"></param>
        internal void SetCollapsed(bool collapse)
        {
            if (collapse) //Свернуть
            {
                if (Convert.ToInt16(buttonCollapseStatusBar.Tag) != 1) return; //уже свернут
                this.Height = panelTop.Height;
                buttonCollapseStatusBar.Image = imageList1.Images["ExpandIcon"];
                buttonCollapseStatusBar.Tag = 0;
                toolTip1.SetToolTip(this.buttonCollapseStatusBar, "Развернуть окно сообщений");

                this._IsCollapsed = true;
            }
            else
            {
                panelTop.BackColor= SystemColors.Control; //сбросим цвет
                if (Convert.ToInt16(buttonCollapseStatusBar.Tag) == 1) return; //Развернут
                this.Height = _PanelBottomHeight;
                buttonCollapseStatusBar.Image = imageList1.Images["CollapseIcon"];
                toolTip1.SetToolTip(this.buttonCollapseStatusBar, "Свернуть окно сообщений");
                buttonCollapseStatusBar.Tag = 1;
                this._IsCollapsed = false;
            }
            this.Parent.Refresh(); //чтобы не оставалось следов от панели panelBottom
        }


    }
}
