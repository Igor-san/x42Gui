namespace x42Gui
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshNetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonSpendableTransactions = new System.Windows.Forms.Button();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonOverview = new System.Windows.Forms.Button();
            this.buttonRecieve = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageOverview = new System.Windows.Forms.TabPage();
            this.overviewPage1 = new x42Gui.UserControls.OverviewPage();
            this.tabPageRecieve = new System.Windows.Forms.TabPage();
            this.receiveView1 = new x42Gui.UserControls.ReceiveView();
            this.tabPageSend = new System.Windows.Forms.TabPage();
            this.sendView1 = new x42Gui.UserControls.SendView();
            this.tabPageSpendableTransactions = new System.Windows.Forms.TabPage();
            this.spendableTransactionsView1 = new x42Gui.UserControls.SpendablTransactionsView();
            this.tabPageHistory = new System.Windows.Forms.TabPage();
            this.historyView1 = new x42Gui.UserControls.HistoryView();
            this.statusMessagePanel = new MyProject.UserControls.StatusMessagePanel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tabPageOverview.SuspendLayout();
            this.tabPageRecieve.SuspendLayout();
            this.tabPageSend.SuspendLayout();
            this.tabPageSpendableTransactions.SuspendLayout();
            this.tabPageHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 425);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(928, 3);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "overview.png");
            this.imageList1.Images.SetKeyName(1, "receive.png");
            this.imageList1.Images.SetKeyName(2, "send.png");
            this.imageList1.Images.SetKeyName(3, "address-book.png");
            this.imageList1.Images.SetKeyName(4, "tx_input.png");
            this.imageList1.Images.SetKeyName(5, "folder_history16.png");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(928, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.refreshNetToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // refreshNetToolStripMenuItem
            // 
            this.refreshNetToolStripMenuItem.Name = "refreshNetToolStripMenuItem";
            this.refreshNetToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.refreshNetToolStripMenuItem.Text = "Refresh Net";
            this.refreshNetToolStripMenuItem.ToolTipText = "обновить список кошельков и аккаунтов";
            this.refreshNetToolStripMenuItem.Click += new System.EventHandler(this.RefreshNetToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // buttonSpendableTransactions
            // 
            this.buttonSpendableTransactions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSpendableTransactions.ImageKey = "tx_input.png";
            this.buttonSpendableTransactions.ImageList = this.imageList1;
            this.buttonSpendableTransactions.Location = new System.Drawing.Point(25, 152);
            this.buttonSpendableTransactions.Margin = new System.Windows.Forms.Padding(25, 5, 15, 5);
            this.buttonSpendableTransactions.Name = "buttonSpendableTransactions";
            this.buttonSpendableTransactions.Size = new System.Drawing.Size(150, 36);
            this.buttonSpendableTransactions.TabIndex = 3;
            this.buttonSpendableTransactions.Text = "Spendable";
            this.toolTip1.SetToolTip(this.buttonSpendableTransactions, "непотраченные входы");
            this.buttonSpendableTransactions.UseVisualStyleBackColor = true;
            this.buttonSpendableTransactions.Click += new System.EventHandler(this.buttonSpendablTransactions_Click);
            // 
            // buttonHistory
            // 
            this.buttonHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHistory.ImageKey = "folder_history16.png";
            this.buttonHistory.ImageList = this.imageList1;
            this.buttonHistory.Location = new System.Drawing.Point(25, 198);
            this.buttonHistory.Margin = new System.Windows.Forms.Padding(25, 5, 15, 5);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(150, 36);
            this.buttonHistory.TabIndex = 6;
            this.buttonHistory.Text = "History";
            this.toolTip1.SetToolTip(this.buttonHistory, "история транзакций");
            this.buttonHistory.UseVisualStyleBackColor = true;
            this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "tick");
            this.imageListSmall.Images.SetKeyName(1, "ball");
            // 
            // imageListLarge
            // 
            this.imageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLarge.ImageStream")));
            this.imageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListLarge.Images.SetKeyName(0, "entire_network");
            this.imageListLarge.Images.SetKeyName(1, "scheduled_tasks");
            this.imageListLarge.Images.SetKeyName(2, "search");
            this.imageListLarge.Images.SetKeyName(3, "workgroup");
            this.imageListLarge.Images.SetKeyName(4, "write_document");
            this.imageListLarge.Images.SetKeyName(5, "tick");
            this.imageListLarge.Images.SetKeyName(6, "ball");
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 24);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.flowLayoutPanel1);
            this.splitContainerMain.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.tabControlMain);
            this.splitContainerMain.Size = new System.Drawing.Size(928, 401);
            this.splitContainerMain.SplitterDistance = 201;
            this.splitContainerMain.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonOverview);
            this.flowLayoutPanel1.Controls.Add(this.buttonRecieve);
            this.flowLayoutPanel1.Controls.Add(this.buttonSend);
            this.flowLayoutPanel1.Controls.Add(this.buttonSpendableTransactions);
            this.flowLayoutPanel1.Controls.Add(this.buttonHistory);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 85);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(25, 5, 3, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(201, 316);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonOverview
            // 
            this.buttonOverview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOverview.ImageKey = "overview.png";
            this.buttonOverview.ImageList = this.imageList1;
            this.buttonOverview.Location = new System.Drawing.Point(25, 15);
            this.buttonOverview.Margin = new System.Windows.Forms.Padding(25, 15, 15, 5);
            this.buttonOverview.Name = "buttonOverview";
            this.buttonOverview.Size = new System.Drawing.Size(150, 35);
            this.buttonOverview.TabIndex = 0;
            this.buttonOverview.Text = "Overview";
            this.buttonOverview.UseVisualStyleBackColor = true;
            this.buttonOverview.Click += new System.EventHandler(this.buttonOverview_Click);
            // 
            // buttonRecieve
            // 
            this.buttonRecieve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRecieve.ImageKey = "receive.png";
            this.buttonRecieve.ImageList = this.imageList1;
            this.buttonRecieve.Location = new System.Drawing.Point(25, 60);
            this.buttonRecieve.Margin = new System.Windows.Forms.Padding(25, 5, 15, 5);
            this.buttonRecieve.Name = "buttonRecieve";
            this.buttonRecieve.Size = new System.Drawing.Size(150, 36);
            this.buttonRecieve.TabIndex = 1;
            this.buttonRecieve.Text = "Recieve";
            this.buttonRecieve.UseVisualStyleBackColor = true;
            this.buttonRecieve.Click += new System.EventHandler(this.buttonRecieve_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSend.ImageKey = "send.png";
            this.buttonSend.ImageList = this.imageList1;
            this.buttonSend.Location = new System.Drawing.Point(25, 106);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(25, 5, 15, 5);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(150, 36);
            this.buttonSend.TabIndex = 2;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageOverview);
            this.tabControlMain.Controls.Add(this.tabPageRecieve);
            this.tabControlMain.Controls.Add(this.tabPageSend);
            this.tabControlMain.Controls.Add(this.tabPageSpendableTransactions);
            this.tabControlMain.Controls.Add(this.tabPageHistory);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(723, 401);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageOverview
            // 
            this.tabPageOverview.Controls.Add(this.overviewPage1);
            this.tabPageOverview.Location = new System.Drawing.Point(4, 22);
            this.tabPageOverview.Name = "tabPageOverview";
            this.tabPageOverview.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOverview.Size = new System.Drawing.Size(715, 375);
            this.tabPageOverview.TabIndex = 0;
            this.tabPageOverview.Text = "Overview";
            this.tabPageOverview.UseVisualStyleBackColor = true;
            // 
            // overviewPage1
            // 
            this.overviewPage1.BackColor = System.Drawing.SystemColors.Control;
            this.overviewPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overviewPage1.Location = new System.Drawing.Point(3, 3);
            this.overviewPage1.Name = "overviewPage1";
            this.overviewPage1.Size = new System.Drawing.Size(709, 369);
            this.overviewPage1.TabIndex = 0;
            // 
            // tabPageRecieve
            // 
            this.tabPageRecieve.Controls.Add(this.receiveView1);
            this.tabPageRecieve.Location = new System.Drawing.Point(4, 22);
            this.tabPageRecieve.Name = "tabPageRecieve";
            this.tabPageRecieve.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRecieve.Size = new System.Drawing.Size(715, 375);
            this.tabPageRecieve.TabIndex = 1;
            this.tabPageRecieve.Text = "Recieve";
            this.tabPageRecieve.UseVisualStyleBackColor = true;
            // 
            // receiveView1
            // 
            this.receiveView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.receiveView1.Location = new System.Drawing.Point(3, 3);
            this.receiveView1.Name = "receiveView1";
            this.receiveView1.Size = new System.Drawing.Size(709, 369);
            this.receiveView1.TabIndex = 0;
            // 
            // tabPageSend
            // 
            this.tabPageSend.Controls.Add(this.sendView1);
            this.tabPageSend.Location = new System.Drawing.Point(4, 22);
            this.tabPageSend.Name = "tabPageSend";
            this.tabPageSend.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSend.Size = new System.Drawing.Size(715, 375);
            this.tabPageSend.TabIndex = 2;
            this.tabPageSend.Text = "Send";
            this.tabPageSend.UseVisualStyleBackColor = true;
            // 
            // sendView1
            // 
            this.sendView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sendView1.Location = new System.Drawing.Point(3, 3);
            this.sendView1.Name = "sendView1";
            this.sendView1.Size = new System.Drawing.Size(709, 369);
            this.sendView1.TabIndex = 0;
            // 
            // tabPageSpendableTransactions
            // 
            this.tabPageSpendableTransactions.Controls.Add(this.spendableTransactionsView1);
            this.tabPageSpendableTransactions.Location = new System.Drawing.Point(4, 22);
            this.tabPageSpendableTransactions.Name = "tabPageSpendableTransactions";
            this.tabPageSpendableTransactions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSpendableTransactions.Size = new System.Drawing.Size(715, 375);
            this.tabPageSpendableTransactions.TabIndex = 3;
            this.tabPageSpendableTransactions.Text = "SpendableTransactions";
            this.tabPageSpendableTransactions.UseVisualStyleBackColor = true;
            // 
            // spendableTransactionsView1
            // 
            this.spendableTransactionsView1.CommandPanelVisible = false;
            this.spendableTransactionsView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spendableTransactionsView1.Location = new System.Drawing.Point(3, 3);
            this.spendableTransactionsView1.Name = "spendableTransactionsView1";
            this.spendableTransactionsView1.Size = new System.Drawing.Size(709, 369);
            this.spendableTransactionsView1.TabIndex = 0;
            // 
            // tabPageHistory
            // 
            this.tabPageHistory.Controls.Add(this.historyView1);
            this.tabPageHistory.Location = new System.Drawing.Point(4, 22);
            this.tabPageHistory.Name = "tabPageHistory";
            this.tabPageHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHistory.Size = new System.Drawing.Size(715, 375);
            this.tabPageHistory.TabIndex = 5;
            this.tabPageHistory.Text = "History";
            this.tabPageHistory.UseVisualStyleBackColor = true;
            // 
            // historyView1
            // 
            this.historyView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyView1.Location = new System.Drawing.Point(3, 3);
            this.historyView1.Name = "historyView1";
            this.historyView1.Size = new System.Drawing.Size(709, 369);
            this.historyView1.TabIndex = 0;
            // 
            // statusMessagePanel
            // 
            this.statusMessagePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusMessagePanel.IsCollapsed = false;
            this.statusMessagePanel.Location = new System.Drawing.Point(0, 428);
            this.statusMessagePanel.Name = "statusMessagePanel";
            this.statusMessagePanel.Size = new System.Drawing.Size(928, 93);
            this.statusMessagePanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 521);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.statusMessagePanel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "x42 Gui";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageOverview.ResumeLayout(false);
            this.tabPageRecieve.ResumeLayout(false);
            this.tabPageSend.ResumeLayout(false);
            this.tabPageSpendableTransactions.ResumeLayout(false);
            this.tabPageHistory.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyProject.UserControls.StatusMessagePanel statusMessagePanel;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageOverview;
        private System.Windows.Forms.TabPage tabPageRecieve;
        private System.Windows.Forms.Button buttonOverview;
        private System.Windows.Forms.Button buttonRecieve;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TabPage tabPageSend;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private UserControls.OverviewPage overviewPage1;
        private System.Windows.Forms.Button buttonSpendableTransactions;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabPage tabPageSpendableTransactions;
        private UserControls.SpendablTransactionsView spendableTransactionsView1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private UserControls.SendView sendView1;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.TabPage tabPageHistory;
        private UserControls.HistoryView historyView1;
        private System.Windows.Forms.ImageList imageListLarge;
        private System.Windows.Forms.ImageList imageListSmall;
        private UserControls.ReceiveView receiveView1;
        private System.Windows.Forms.ToolStripMenuItem refreshNetToolStripMenuItem;
    }
}