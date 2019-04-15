namespace x42Gui.UserControls
{
    partial class OverviewPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OverviewPage));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.keyValueViewUnconfirmed = new x42Gui.UserControls.KeyValueView();
            this.keyValueViewSpendable = new x42Gui.UserControls.KeyValueView();
            this.keyValueViewStake = new x42Gui.UserControls.KeyValueView();
            this.keyValueViewTotal = new x42Gui.UserControls.KeyValueView();
            this.keyValueViewConfirmed = new x42Gui.UserControls.KeyValueView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.olvColumnTitle = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnAmount = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnTxId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Controls.Add(this.keyValueViewUnconfirmed, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.keyValueViewSpendable, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.keyValueViewStake, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.keyValueViewTotal, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.keyValueViewConfirmed, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(286, 413);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // keyValueViewUnconfirmed
            // 
            this.keyValueViewUnconfirmed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keyValueViewUnconfirmed.KeyFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.keyValueViewUnconfirmed.Location = new System.Drawing.Point(3, 63);
            this.keyValueViewUnconfirmed.Name = "keyValueViewUnconfirmed";
            this.keyValueViewUnconfirmed.Size = new System.Drawing.Size(275, 24);
            this.keyValueViewUnconfirmed.TabIndex = 4;
            this.keyValueViewUnconfirmed.ValueFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // keyValueViewSpendable
            // 
            this.keyValueViewSpendable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keyValueViewSpendable.KeyFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.keyValueViewSpendable.Location = new System.Drawing.Point(3, 3);
            this.keyValueViewSpendable.Name = "keyValueViewSpendable";
            this.keyValueViewSpendable.Size = new System.Drawing.Size(275, 24);
            this.keyValueViewSpendable.TabIndex = 0;
            this.keyValueViewSpendable.ValueFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // keyValueViewStake
            // 
            this.keyValueViewStake.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keyValueViewStake.KeyFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.keyValueViewStake.Location = new System.Drawing.Point(3, 33);
            this.keyValueViewStake.Name = "keyValueViewStake";
            this.keyValueViewStake.Size = new System.Drawing.Size(275, 24);
            this.keyValueViewStake.TabIndex = 1;
            this.keyValueViewStake.ValueFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // keyValueViewTotal
            // 
            this.keyValueViewTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keyValueViewTotal.KeyFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.keyValueViewTotal.Location = new System.Drawing.Point(3, 138);
            this.keyValueViewTotal.Name = "keyValueViewTotal";
            this.keyValueViewTotal.Size = new System.Drawing.Size(275, 24);
            this.keyValueViewTotal.TabIndex = 11;
            this.keyValueViewTotal.ValueFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // keyValueViewConfirmed
            // 
            this.keyValueViewConfirmed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keyValueViewConfirmed.KeyFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.keyValueViewConfirmed.Location = new System.Drawing.Point(3, 93);
            this.keyValueViewConfirmed.Name = "keyValueViewConfirmed";
            this.keyValueViewConfirmed.Size = new System.Drawing.Size(275, 24);
            this.keyValueViewConfirmed.TabIndex = 12;
            this.keyValueViewConfirmed.ValueFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.objectListView1);
            this.splitContainer1.Size = new System.Drawing.Size(685, 413);
            this.splitContainer1.SplitterDistance = 286;
            this.splitContainer1.TabIndex = 1;
            // 
            // objectListView1
            // 
            this.objectListView1.AllColumns.Add(this.olvColumnTitle);
            this.objectListView1.AllColumns.Add(this.olvColumnAmount);
            this.objectListView1.AllColumns.Add(this.olvColumnTxId);
            this.objectListView1.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.objectListView1.BackColor = System.Drawing.SystemColors.Control;
            this.objectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnTitle,
            this.olvColumnAmount});
            this.objectListView1.CopySelectionOnControlC = false;
            this.objectListView1.CopySelectionOnControlCUsesDragSource = false;
            this.objectListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectListView1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.objectListView1.FullRowSelect = true;
            this.objectListView1.HasCollapsibleGroups = false;
            this.objectListView1.HeaderUsesThemes = false;
            this.objectListView1.HideSelection = false;
            this.objectListView1.HighlightBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.objectListView1.Location = new System.Drawing.Point(0, 0);
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.PersistentCheckBoxes = false;
            this.objectListView1.RowHeight = 52;
            this.objectListView1.SelectAllOnControlA = false;
            this.objectListView1.SelectColumnsMenuStaysOpen = false;
            this.objectListView1.SelectColumnsOnRightClick = false;
            this.objectListView1.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.None;
            this.objectListView1.ShowGroups = false;
            this.objectListView1.ShowImagesOnSubItems = true;
            this.objectListView1.Size = new System.Drawing.Size(395, 413);
            this.objectListView1.SmallImageList = this.imageListSmall;
            this.objectListView1.TabIndex = 0;
            this.objectListView1.UseCellFormatEvents = true;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.UseCustomSelectionColors = true;
            this.objectListView1.UseExplorerTheme = true;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            this.objectListView1.FormatCell += new System.EventHandler<BrightIdeasSoftware.FormatCellEventArgs>(this.objectListView1_FormatCell);
            // 
            // olvColumnTitle
            // 
            this.olvColumnTitle.AspectName = "Title";
            this.olvColumnTitle.CellPadding = null;
            this.olvColumnTitle.FillsFreeSpace = true;
            this.olvColumnTitle.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumnTitle.ImageAspectName = "FeatureIcon";
            this.olvColumnTitle.Text = "Title";
            this.olvColumnTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // olvColumnAmount
            // 
            this.olvColumnAmount.AspectName = "Amount";
            this.olvColumnAmount.CellPadding = null;
            this.olvColumnAmount.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumnAmount.Text = "Amount";
            this.olvColumnAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumnAmount.Width = 100;
            // 
            // olvColumnTxId
            // 
            this.olvColumnTxId.AspectName = "TxId";
            this.olvColumnTxId.CellPadding = null;
            this.olvColumnTxId.DisplayIndex = 2;
            this.olvColumnTxId.IsVisible = false;
            this.olvColumnTxId.Text = "TxId";
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
            this.imageListLarge.Images.SetKeyName(0, "tx_input");
            this.imageListLarge.Images.SetKeyName(1, "tx_output");
            this.imageListLarge.Images.SetKeyName(2, "tx_mined");
            // 
            // OverviewPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "OverviewPage";
            this.Size = new System.Drawing.Size(685, 413);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private KeyValueView keyValueViewSpendable;
        private KeyValueView keyValueViewStake;
        private KeyValueView keyValueViewUnconfirmed;
        private KeyValueView keyValueViewTotal;
        private KeyValueView keyValueViewConfirmed;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private BrightIdeasSoftware.ObjectListView objectListView1;
        private BrightIdeasSoftware.OLVColumn olvColumnTitle;
        private System.Windows.Forms.ImageList imageListLarge;
        private BrightIdeasSoftware.OLVColumn olvColumnAmount;
        private System.Windows.Forms.ImageList imageListSmall;
        private BrightIdeasSoftware.OLVColumn olvColumnTxId;
    }
}
