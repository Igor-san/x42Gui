namespace MyProject.UserControls
{
    partial class StatusMessagePanel
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatusMessagePanel));
            this.panelStatusMessage = new System.Windows.Forms.Panel();
            this.textBoxMessages = new System.Windows.Forms.RichTextBox();
            this.bottomLeftPanel = new System.Windows.Forms.Panel();
            this.logClearButton = new System.Windows.Forms.Button();
            this.buttonCollapseStatusBar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelStatusMessage.SuspendLayout();
            this.bottomLeftPanel.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelStatusMessage
            // 
            this.panelStatusMessage.Controls.Add(this.textBoxMessages);
            this.panelStatusMessage.Controls.Add(this.bottomLeftPanel);
            this.panelStatusMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStatusMessage.Location = new System.Drawing.Point(0, 12);
            this.panelStatusMessage.Name = "panelStatusMessage";
            this.panelStatusMessage.Size = new System.Drawing.Size(676, 77);
            this.panelStatusMessage.TabIndex = 30;
            // 
            // textBoxMessages
            // 
            this.textBoxMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMessages.Location = new System.Drawing.Point(15, 0);
            this.textBoxMessages.Name = "textBoxMessages";
            this.textBoxMessages.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.textBoxMessages.Size = new System.Drawing.Size(661, 77);
            this.textBoxMessages.TabIndex = 37;
            this.textBoxMessages.Text = "";
            // 
            // bottomLeftPanel
            // 
            this.bottomLeftPanel.Controls.Add(this.logClearButton);
            this.bottomLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.bottomLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.bottomLeftPanel.Name = "bottomLeftPanel";
            this.bottomLeftPanel.Size = new System.Drawing.Size(15, 77);
            this.bottomLeftPanel.TabIndex = 13;
            // 
            // logClearButton
            // 
            this.logClearButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.logClearButton.FlatAppearance.BorderSize = 0;
            this.logClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logClearButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.logClearButton.Location = new System.Drawing.Point(0, 0);
            this.logClearButton.Name = "logClearButton";
            this.logClearButton.Size = new System.Drawing.Size(15, 21);
            this.logClearButton.TabIndex = 0;
            this.logClearButton.Text = "x";
            this.logClearButton.UseVisualStyleBackColor = true;
            this.logClearButton.Click += new System.EventHandler(this.logClearButton_Click);
            // 
            // buttonCollapseStatusBar
            // 
            this.buttonCollapseStatusBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonCollapseStatusBar.FlatAppearance.BorderSize = 0;
            this.buttonCollapseStatusBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCollapseStatusBar.ImageIndex = 0;
            this.buttonCollapseStatusBar.ImageList = this.imageList1;
            this.buttonCollapseStatusBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCollapseStatusBar.Location = new System.Drawing.Point(0, 0);
            this.buttonCollapseStatusBar.Name = "buttonCollapseStatusBar";
            this.buttonCollapseStatusBar.Size = new System.Drawing.Size(15, 12);
            this.buttonCollapseStatusBar.TabIndex = 10;
            this.buttonCollapseStatusBar.TabStop = false;
            this.buttonCollapseStatusBar.Tag = "1";
            this.buttonCollapseStatusBar.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonCollapseStatusBar.UseVisualStyleBackColor = true;
            this.buttonCollapseStatusBar.Click += new System.EventHandler(this.buttonCollapseStatusBar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "CollapseIcon");
            this.imageList1.Images.SetKeyName(1, "ExpandIcon");
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.Control;
            this.panelTop.Controls.Add(this.buttonCollapseStatusBar);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(676, 12);
            this.panelTop.TabIndex = 31;
            // 
            // StatusMessagePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelStatusMessage);
            this.Controls.Add(this.panelTop);
            this.Name = "StatusMessagePanel";
            this.Size = new System.Drawing.Size(676, 89);
            this.panelStatusMessage.ResumeLayout(false);
            this.bottomLeftPanel.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelStatusMessage;
        private System.Windows.Forms.Panel bottomLeftPanel;
        private System.Windows.Forms.Button logClearButton;
        private System.Windows.Forms.Button buttonCollapseStatusBar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RichTextBox textBoxMessages;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panelTop;
    }
}
