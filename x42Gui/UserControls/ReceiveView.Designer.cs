namespace x42Gui.UserControls
{
    partial class ReceiveView
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
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.olvColumnWallet = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnAccount = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnIsUsed = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnIsChange = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnAddress = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelNotActual = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.contextMenuStripCopy = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            this.panelTop.SuspendLayout();
            this.contextMenuStripCopy.SuspendLayout();
            this.SuspendLayout();
            // 
            // objectListView1
            // 
            this.objectListView1.AllColumns.Add(this.olvColumnWallet);
            this.objectListView1.AllColumns.Add(this.olvColumnAccount);
            this.objectListView1.AllColumns.Add(this.olvColumnIsUsed);
            this.objectListView1.AllColumns.Add(this.olvColumnIsChange);
            this.objectListView1.AllColumns.Add(this.olvColumnAddress);
            this.objectListView1.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.objectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnWallet,
            this.olvColumnAccount,
            this.olvColumnIsUsed,
            this.olvColumnIsChange,
            this.olvColumnAddress});
            this.objectListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.objectListView1.FullRowSelect = true;
            this.objectListView1.GridLines = true;
            this.objectListView1.Location = new System.Drawing.Point(0, 30);
            this.objectListView1.MultiSelect = false;
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.RowHeight = 30;
            this.objectListView1.Size = new System.Drawing.Size(517, 328);
            this.objectListView1.SortGroupItemsByPrimaryColumn = false;
            this.objectListView1.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.objectListView1.SpaceBetweenGroups = 3;
            this.objectListView1.TabIndex = 40;
            this.objectListView1.UseAlternatingBackColors = true;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.UseCustomSelectionColors = true;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            this.objectListView1.CellRightClick += new System.EventHandler<BrightIdeasSoftware.CellRightClickEventArgs>(this.objectListView1_CellRightClick);
            // 
            // olvColumnWallet
            // 
            this.olvColumnWallet.AspectName = "WalletName";
            this.olvColumnWallet.CellPadding = null;
            this.olvColumnWallet.Text = "Wallet";
            this.olvColumnWallet.Width = 80;
            // 
            // olvColumnAccount
            // 
            this.olvColumnAccount.AspectName = "AccountName";
            this.olvColumnAccount.CellPadding = null;
            this.olvColumnAccount.Text = "Account";
            this.olvColumnAccount.Width = 70;
            // 
            // olvColumnIsUsed
            // 
            this.olvColumnIsUsed.AspectName = "IsUsed";
            this.olvColumnIsUsed.CellPadding = null;
            this.olvColumnIsUsed.Text = "IsUsed";
            // 
            // olvColumnIsChange
            // 
            this.olvColumnIsChange.AspectName = "IsChange";
            this.olvColumnIsChange.CellPadding = null;
            this.olvColumnIsChange.GroupWithItemCountFormat = "";
            this.olvColumnIsChange.GroupWithItemCountSingularFormat = "";
            this.olvColumnIsChange.IsEditable = false;
            this.olvColumnIsChange.Text = "IsChange";
            this.olvColumnIsChange.Width = 65;
            // 
            // olvColumnAddress
            // 
            this.olvColumnAddress.AspectName = "Address";
            this.olvColumnAddress.CellPadding = null;
            this.olvColumnAddress.FillsFreeSpace = true;
            this.olvColumnAddress.Groupable = false;
            this.olvColumnAddress.Text = "Address";
            this.olvColumnAddress.Width = 120;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.labelNotActual);
            this.panelTop.Controls.Add(this.buttonRefresh);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(517, 30);
            this.panelTop.TabIndex = 39;
            // 
            // labelNotActual
            // 
            this.labelNotActual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNotActual.AutoSize = true;
            this.labelNotActual.ForeColor = System.Drawing.Color.Red;
            this.labelNotActual.Location = new System.Drawing.Point(348, 9);
            this.labelNotActual.Name = "labelNotActual";
            this.labelNotActual.Size = new System.Drawing.Size(100, 13);
            this.labelNotActual.TabIndex = 2;
            this.labelNotActual.Text = "data is not relevant!";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.FlatAppearance.BorderSize = 0;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Image = global::x42Gui.Properties.Resources.refresh16green;
            this.buttonRefresh.Location = new System.Drawing.Point(489, 3);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(24, 24);
            this.buttonRefresh.TabIndex = 0;
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // contextMenuStripCopy
            // 
            this.contextMenuStripCopy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCopy});
            this.contextMenuStripCopy.Name = "contextMenuStripCopy";
            this.contextMenuStripCopy.Size = new System.Drawing.Size(203, 26);
            // 
            // toolStripMenuItemCopy
            // 
            this.toolStripMenuItemCopy.Name = "toolStripMenuItemCopy";
            this.toolStripMenuItemCopy.Size = new System.Drawing.Size(202, 22);
            this.toolStripMenuItemCopy.Text = "toolStripMenuItemCopy";
            this.toolStripMenuItemCopy.Click += new System.EventHandler(this.toolStripMenuItemCopy_Click);
            // 
            // ReceiveView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.objectListView1);
            this.Controls.Add(this.panelTop);
            this.Name = "ReceiveView";
            this.Size = new System.Drawing.Size(517, 358);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.contextMenuStripCopy.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView objectListView1;
        private BrightIdeasSoftware.OLVColumn olvColumnWallet;
        private BrightIdeasSoftware.OLVColumn olvColumnAccount;
        private BrightIdeasSoftware.OLVColumn olvColumnIsUsed;
        private BrightIdeasSoftware.OLVColumn olvColumnIsChange;
        private BrightIdeasSoftware.OLVColumn olvColumnAddress;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label labelNotActual;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCopy;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopy;
    }
}
