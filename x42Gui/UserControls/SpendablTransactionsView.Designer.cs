namespace x42Gui.UserControls
{
    partial class SpendablTransactionsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpendablTransactionsView));
            this.treeListView1 = new BrightIdeasSoftware.TreeListView();
            this.olvColumnTitle = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnAmount = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnTime = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnConfirmations = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.labelSeveralAccountChecked = new System.Windows.Forms.Label();
            this.labelSelectedTransactions = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelBottom = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.contextMenuStripCopy = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.treeListView1)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.contextMenuStripCopy.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeListView1
            // 
            this.treeListView1.AllColumns.Add(this.olvColumnTitle);
            this.treeListView1.AllColumns.Add(this.olvColumnAmount);
            this.treeListView1.AllColumns.Add(this.olvColumnTime);
            this.treeListView1.AllColumns.Add(this.olvColumnConfirmations);
            this.treeListView1.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.treeListView1.CheckBoxes = true;
            this.treeListView1.CheckedAspectName = "";
            this.treeListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnTitle,
            this.olvColumnAmount,
            this.olvColumnTime,
            this.olvColumnConfirmations});
            this.treeListView1.CopySelectionOnControlC = false;
            this.treeListView1.CopySelectionOnControlCUsesDragSource = false;
            this.treeListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListView1.GridLines = true;
            this.treeListView1.Location = new System.Drawing.Point(0, 30);
            this.treeListView1.Name = "treeListView1";
            this.treeListView1.OwnerDraw = true;
            this.treeListView1.ShowGroups = false;
            this.treeListView1.ShowImagesOnSubItems = true;
            this.treeListView1.Size = new System.Drawing.Size(587, 395);
            this.treeListView1.SmallImageList = this.imageList1;
            this.treeListView1.TabIndex = 34;
            this.treeListView1.UseCellFormatEvents = true;
            this.treeListView1.UseCompatibleStateImageBehavior = false;
            this.treeListView1.View = System.Windows.Forms.View.Details;
            this.treeListView1.VirtualMode = true;
            this.treeListView1.CellRightClick += new System.EventHandler<BrightIdeasSoftware.CellRightClickEventArgs>(this.treeListView1_CellRightClick);
            this.treeListView1.FormatCell += new System.EventHandler<BrightIdeasSoftware.FormatCellEventArgs>(this.treeListView1_FormatCell);
            // 
            // olvColumnTitle
            // 
            this.olvColumnTitle.AspectName = "Title";
            this.olvColumnTitle.CellPadding = null;
            this.olvColumnTitle.IsEditable = false;
            this.olvColumnTitle.Text = "Title";
            this.olvColumnTitle.Width = 254;
            // 
            // olvColumnAmount
            // 
            this.olvColumnAmount.AspectName = "Amount";
            this.olvColumnAmount.CellPadding = null;
            this.olvColumnAmount.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumnAmount.IsEditable = false;
            this.olvColumnAmount.Text = "Сумма";
            this.olvColumnAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumnAmount.Width = 102;
            // 
            // olvColumnTime
            // 
            this.olvColumnTime.AspectName = "Time";
            this.olvColumnTime.AspectToStringFormat = "{0:dd-MMM-yyyy HH:MM}";
            this.olvColumnTime.CellPadding = null;
            this.olvColumnTime.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumnTime.IsEditable = false;
            this.olvColumnTime.Text = "Дата";
            this.olvColumnTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumnTime.Width = 110;
            // 
            // olvColumnConfirmations
            // 
            this.olvColumnConfirmations.AspectName = "Confirmations";
            this.olvColumnConfirmations.CellPadding = null;
            this.olvColumnConfirmations.IsEditable = false;
            this.olvColumnConfirmations.IsTileViewColumn = true;
            this.olvColumnConfirmations.Text = "Подтверждений";
            this.olvColumnConfirmations.Width = 85;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "tx_inout.png");
            this.imageList1.Images.SetKeyName(1, "stratis32.png");
            this.imageList1.Images.SetKeyName(2, "male24.png");
            this.imageList1.Images.SetKeyName(3, "wallet-icon2.png");
            this.imageList1.Images.SetKeyName(4, "refreshBlue.png");
            this.imageList1.Images.SetKeyName(5, "mail.png");
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.buttonRefresh);
            this.panelTop.Controls.Add(this.labelSeveralAccountChecked);
            this.panelTop.Controls.Add(this.labelSelectedTransactions);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(587, 30);
            this.panelTop.TabIndex = 35;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.FlatAppearance.BorderSize = 0;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Image = global::x42Gui.Properties.Resources.refresh16green;
            this.buttonRefresh.Location = new System.Drawing.Point(560, 3);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(24, 24);
            this.buttonRefresh.TabIndex = 41;
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // labelSeveralAccountChecked
            // 
            this.labelSeveralAccountChecked.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSeveralAccountChecked.AutoSize = true;
            this.labelSeveralAccountChecked.ForeColor = System.Drawing.Color.Red;
            this.labelSeveralAccountChecked.Location = new System.Drawing.Point(303, 9);
            this.labelSeveralAccountChecked.Name = "labelSeveralAccountChecked";
            this.labelSeveralAccountChecked.Size = new System.Drawing.Size(229, 13);
            this.labelSeveralAccountChecked.TabIndex = 40;
            this.labelSeveralAccountChecked.Text = "Выбраны транзакции из разных аккаунтов!";
            this.labelSeveralAccountChecked.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSelectedTransactions
            // 
            this.labelSelectedTransactions.AutoSize = true;
            this.labelSelectedTransactions.Location = new System.Drawing.Point(3, 9);
            this.labelSelectedTransactions.Name = "labelSelectedTransactions";
            this.labelSelectedTransactions.Size = new System.Drawing.Size(110, 13);
            this.labelSelectedTransactions.TabIndex = 39;
            this.labelSelectedTransactions.Text = "SelectedTransactions";
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.buttonCancel);
            this.panelBottom.Controls.Add(this.buttonOk);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 425);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(587, 31);
            this.panelBottom.TabIndex = 36;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCancel.Location = new System.Drawing.Point(6, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(509, 3);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
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
            // SpendablTransactionsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeListView1);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.DoubleBuffered = true;
            this.Name = "SpendablTransactionsView";
            this.Size = new System.Drawing.Size(587, 456);
            ((System.ComponentModel.ISupportInitialize)(this.treeListView1)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.contextMenuStripCopy.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.TreeListView treeListView1;
        private BrightIdeasSoftware.OLVColumn olvColumnTitle;
        private BrightIdeasSoftware.OLVColumn olvColumnAmount;
        private BrightIdeasSoftware.OLVColumn olvColumnTime;
        private BrightIdeasSoftware.OLVColumn olvColumnConfirmations;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelSeveralAccountChecked;
        private System.Windows.Forms.Label labelSelectedTransactions;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCopy;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopy;
        private System.Windows.Forms.Button buttonRefresh;
    }
}
