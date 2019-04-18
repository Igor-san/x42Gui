namespace x42Gui.UserControls
{
    partial class HistoryView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelNotActual = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.olvColumnWallet = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnAccount = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnAmount = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnTimestamp = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnAddress = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnTxId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.labelBlockCount = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.labelBlockCount);
            this.panelTop.Controls.Add(this.labelNotActual);
            this.panelTop.Controls.Add(this.buttonRefresh);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(551, 30);
            this.panelTop.TabIndex = 36;
            // 
            // labelNotActual
            // 
            this.labelNotActual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNotActual.AutoSize = true;
            this.labelNotActual.ForeColor = System.Drawing.Color.Red;
            this.labelNotActual.Location = new System.Drawing.Point(378, 9);
            this.labelNotActual.Name = "labelNotActual";
            this.labelNotActual.Size = new System.Drawing.Size(100, 13);
            this.labelNotActual.TabIndex = 1;
            this.labelNotActual.Text = "data is not relevant!";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.FlatAppearance.BorderSize = 0;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Image = global::x42Gui.Properties.Resources.refresh16green;
            this.buttonRefresh.Location = new System.Drawing.Point(523, 3);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(24, 24);
            this.buttonRefresh.TabIndex = 0;
            this.toolTip1.SetToolTip(this.buttonRefresh, "обновить список");
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // objectListView1
            // 
            this.objectListView1.AllColumns.Add(this.olvColumnWallet);
            this.objectListView1.AllColumns.Add(this.olvColumnAccount);
            this.objectListView1.AllColumns.Add(this.olvColumnType);
            this.objectListView1.AllColumns.Add(this.olvColumnAmount);
            this.objectListView1.AllColumns.Add(this.olvColumnTimestamp);
            this.objectListView1.AllColumns.Add(this.olvColumnAddress);
            this.objectListView1.AllColumns.Add(this.olvColumnTxId);
            this.objectListView1.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.objectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnWallet,
            this.olvColumnAccount,
            this.olvColumnType,
            this.olvColumnAmount,
            this.olvColumnTimestamp});
            this.objectListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.objectListView1.FullRowSelect = true;
            this.objectListView1.GridLines = true;
            this.objectListView1.Location = new System.Drawing.Point(0, 30);
            this.objectListView1.MultiSelect = false;
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.RowHeight = 30;
            this.objectListView1.Size = new System.Drawing.Size(551, 417);
            this.objectListView1.SortGroupItemsByPrimaryColumn = false;
            this.objectListView1.SpaceBetweenGroups = 3;
            this.objectListView1.TabIndex = 38;
            this.objectListView1.UseAlternatingBackColors = true;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.UseCustomSelectionColors = true;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            this.objectListView1.ItemActivate += new System.EventHandler(this.objectListView1_ItemActivate);
            // 
            // olvColumnWallet
            // 
            this.olvColumnWallet.AspectName = "WalletName";
            this.olvColumnWallet.CellPadding = null;
            this.olvColumnWallet.Text = "Wallet";
            this.olvColumnWallet.Width = 70;
            // 
            // olvColumnAccount
            // 
            this.olvColumnAccount.AspectName = "AccountName";
            this.olvColumnAccount.CellPadding = null;
            this.olvColumnAccount.Text = "Account";
            this.olvColumnAccount.Width = 70;
            // 
            // olvColumnType
            // 
            this.olvColumnType.AspectName = "Type";
            this.olvColumnType.CellPadding = null;
            this.olvColumnType.Text = "Type";
            this.olvColumnType.Width = 70;
            // 
            // olvColumnAmount
            // 
            this.olvColumnAmount.AspectName = "Amount";
            this.olvColumnAmount.CellPadding = null;
            this.olvColumnAmount.Text = "Amount";
            this.olvColumnAmount.Width = 100;
            // 
            // olvColumnTimestamp
            // 
            this.olvColumnTimestamp.AspectName = "Timestamp";
            this.olvColumnTimestamp.CellPadding = null;
            this.olvColumnTimestamp.FillsFreeSpace = true;
            this.olvColumnTimestamp.GroupWithItemCountFormat = "{0} ({1} elementi)";
            this.olvColumnTimestamp.GroupWithItemCountSingularFormat = "{0} (1 elemento)";
            this.olvColumnTimestamp.IsEditable = false;
            this.olvColumnTimestamp.Text = "Timestamp";
            this.olvColumnTimestamp.Width = 120;
            // 
            // olvColumnAddress
            // 
            this.olvColumnAddress.AspectName = "ToAddress";
            this.olvColumnAddress.CellPadding = null;
            this.olvColumnAddress.DisplayIndex = 5;
            this.olvColumnAddress.FillsFreeSpace = true;
            this.olvColumnAddress.IsVisible = false;
            this.olvColumnAddress.Text = "Address";
            // 
            // olvColumnTxId
            // 
            this.olvColumnTxId.AspectName = "TxId";
            this.olvColumnTxId.CellPadding = null;
            this.olvColumnTxId.IsVisible = false;
            this.olvColumnTxId.Text = "TxId";
            // 
            // timerRefresh
            // 
            this.timerRefresh.Interval = 10000;
            this.timerRefresh.Tick += new System.EventHandler(this.TimerRefresh_Tick);
            // 
            // labelBlockCount
            // 
            this.labelBlockCount.AutoSize = true;
            this.labelBlockCount.Location = new System.Drawing.Point(20, 9);
            this.labelBlockCount.Name = "labelBlockCount";
            this.labelBlockCount.Size = new System.Drawing.Size(65, 13);
            this.labelBlockCount.TabIndex = 2;
            this.labelBlockCount.Text = "Block Count";
            // 
            // HistoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.objectListView1);
            this.Controls.Add(this.panelTop);
            this.Name = "HistoryView";
            this.Size = new System.Drawing.Size(551, 447);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelNotActual;
        private BrightIdeasSoftware.ObjectListView objectListView1;
        private BrightIdeasSoftware.OLVColumn olvColumnWallet;
        private BrightIdeasSoftware.OLVColumn olvColumnAccount;
        private BrightIdeasSoftware.OLVColumn olvColumnType;
        private BrightIdeasSoftware.OLVColumn olvColumnAmount;
        private BrightIdeasSoftware.OLVColumn olvColumnAddress;
        private BrightIdeasSoftware.OLVColumn olvColumnTimestamp;
        private BrightIdeasSoftware.OLVColumn olvColumnTxId;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.Label labelBlockCount;
    }
}
