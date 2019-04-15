namespace x42Gui.UserControls
{
    partial class SendView
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
            this.textBoxPayTo = new System.Windows.Forms.TextBox();
            this.labelPayTo = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonSelectInputs = new System.Windows.Forms.Button();
            this.textBoxCustomChangeAddress = new System.Windows.Forms.TextBox();
            this.checkBoxCustomChangeAddress = new System.Windows.Forms.CheckBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.labelAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAutomaticallySelected = new System.Windows.Forms.Label();
            this.groupBoxCoinControlFeatures = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.comboBoxWallet = new System.Windows.Forms.ComboBox();
            this.labelWallet = new System.Windows.Forms.Label();
            this.labelAccount = new System.Windows.Forms.Label();
            this.comboBoxAccount = new System.Windows.Forms.ComboBox();
            this.groupBoxAccount = new System.Windows.Forms.GroupBox();
            this.panelBody = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelTxFee = new System.Windows.Forms.Label();
            this.labelChange = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.numericTextBoxAmount = new x42Gui.UserControls.NumericTextBox();
            this.panelInputsInfo = new System.Windows.Forms.Panel();
            this.groupBoxCoinControlFeatures.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxAccount.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelInputsInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPayTo
            // 
            this.textBoxPayTo.Location = new System.Drawing.Point(64, 98);
            this.textBoxPayTo.Name = "textBoxPayTo";
            this.textBoxPayTo.Size = new System.Drawing.Size(316, 20);
            this.textBoxPayTo.TabIndex = 0;
            this.toolTip1.SetToolTip(this.textBoxPayTo, "получатель");
            this.textBoxPayTo.TextChanged += new System.EventHandler(this.textBoxPayTo_TextChanged);
            // 
            // labelPayTo
            // 
            this.labelPayTo.AutoSize = true;
            this.labelPayTo.Location = new System.Drawing.Point(12, 101);
            this.labelPayTo.Name = "labelPayTo";
            this.labelPayTo.Size = new System.Drawing.Size(44, 13);
            this.labelPayTo.TabIndex = 1;
            this.labelPayTo.Text = "Pay To:";
            // 
            // buttonSelectInputs
            // 
            this.buttonSelectInputs.Location = new System.Drawing.Point(11, 19);
            this.buttonSelectInputs.Name = "buttonSelectInputs";
            this.buttonSelectInputs.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectInputs.TabIndex = 6;
            this.buttonSelectInputs.Text = "Inputs...";
            this.toolTip1.SetToolTip(this.buttonSelectInputs, "выбрать непотраченные выходы");
            this.buttonSelectInputs.UseVisualStyleBackColor = true;
            this.buttonSelectInputs.Click += new System.EventHandler(this.buttonSelectInputs_Click);
            // 
            // textBoxCustomChangeAddress
            // 
            this.textBoxCustomChangeAddress.Enabled = false;
            this.textBoxCustomChangeAddress.Location = new System.Drawing.Point(160, 3);
            this.textBoxCustomChangeAddress.Name = "textBoxCustomChangeAddress";
            this.textBoxCustomChangeAddress.Size = new System.Drawing.Size(385, 20);
            this.textBoxCustomChangeAddress.TabIndex = 9;
            this.toolTip1.SetToolTip(this.textBoxCustomChangeAddress, "получатель");
            // 
            // checkBoxCustomChangeAddress
            // 
            this.checkBoxCustomChangeAddress.AutoSize = true;
            this.checkBoxCustomChangeAddress.Location = new System.Drawing.Point(3, 3);
            this.checkBoxCustomChangeAddress.Name = "checkBoxCustomChangeAddress";
            this.checkBoxCustomChangeAddress.Size = new System.Drawing.Size(139, 17);
            this.checkBoxCustomChangeAddress.TabIndex = 8;
            this.checkBoxCustomChangeAddress.Text = "custom change address";
            this.toolTip1.SetToolTip(this.checkBoxCustomChangeAddress, "доступно только при выбранных входах");
            this.checkBoxCustomChangeAddress.UseVisualStyleBackColor = true;
            this.checkBoxCustomChangeAddress.CheckedChanged += new System.EventHandler(this.checkBoxCustomChangeAddress_CheckedChanged);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.FlatAppearance.BorderSize = 0;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Image = global::x42Gui.Properties.Resources.refresh16green;
            this.buttonRefresh.Location = new System.Drawing.Point(396, 17);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(24, 24);
            this.buttonRefresh.TabIndex = 16;
            this.toolTip1.SetToolTip(this.buttonRefresh, "обновить список кошельков и аккаунтов");
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(12, 146);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(46, 13);
            this.labelAmount.TabIndex = 3;
            this.labelAmount.Text = "Amount:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "coins";
            // 
            // labelAutomaticallySelected
            // 
            this.labelAutomaticallySelected.AutoSize = true;
            this.labelAutomaticallySelected.Location = new System.Drawing.Point(105, 24);
            this.labelAutomaticallySelected.Name = "labelAutomaticallySelected";
            this.labelAutomaticallySelected.Size = new System.Drawing.Size(111, 13);
            this.labelAutomaticallySelected.TabIndex = 7;
            this.labelAutomaticallySelected.Text = "automatically selected";
            // 
            // groupBoxCoinControlFeatures
            // 
            this.groupBoxCoinControlFeatures.Controls.Add(this.buttonSelectInputs);
            this.groupBoxCoinControlFeatures.Controls.Add(this.labelAutomaticallySelected);
            this.groupBoxCoinControlFeatures.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxCoinControlFeatures.Location = new System.Drawing.Point(0, 0);
            this.groupBoxCoinControlFeatures.Name = "groupBoxCoinControlFeatures";
            this.groupBoxCoinControlFeatures.Size = new System.Drawing.Size(601, 52);
            this.groupBoxCoinControlFeatures.TabIndex = 10;
            this.groupBoxCoinControlFeatures.TabStop = false;
            this.groupBoxCoinControlFeatures.Text = "Coin Control Features";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelInfo);
            this.panel1.Controls.Add(this.buttonClearAll);
            this.panel1.Controls.Add(this.buttonSend);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 366);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 38);
            this.panel1.TabIndex = 11;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(95, 12);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(49, 13);
            this.labelInfo.TabIndex = 2;
            this.labelInfo.Text = "Balance:";
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Location = new System.Drawing.Point(14, 7);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(75, 23);
            this.buttonClearAll.TabIndex = 1;
            this.buttonClearAll.Text = "Clear All";
            this.toolTip1.SetToolTip(this.buttonClearAll, "очистить поля ввода");
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSend.Location = new System.Drawing.Point(520, 7);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 0;
            this.buttonSend.Text = "Send";
            this.toolTip1.SetToolTip(this.buttonSend, "послать транзакцию");
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // comboBoxWallet
            // 
            this.comboBoxWallet.FormattingEnabled = true;
            this.comboBoxWallet.Location = new System.Drawing.Point(58, 19);
            this.comboBoxWallet.Name = "comboBoxWallet";
            this.comboBoxWallet.Size = new System.Drawing.Size(121, 21);
            this.comboBoxWallet.TabIndex = 12;
            this.comboBoxWallet.SelectedIndexChanged += new System.EventHandler(this.comboBoxWallet_SelectedIndexChanged);
            // 
            // labelWallet
            // 
            this.labelWallet.AutoSize = true;
            this.labelWallet.Location = new System.Drawing.Point(6, 22);
            this.labelWallet.Name = "labelWallet";
            this.labelWallet.Size = new System.Drawing.Size(40, 13);
            this.labelWallet.TabIndex = 13;
            this.labelWallet.Text = "Wallet:";
            // 
            // labelAccount
            // 
            this.labelAccount.AutoSize = true;
            this.labelAccount.Location = new System.Drawing.Point(201, 22);
            this.labelAccount.Name = "labelAccount";
            this.labelAccount.Size = new System.Drawing.Size(50, 13);
            this.labelAccount.TabIndex = 15;
            this.labelAccount.Text = "Account:";
            // 
            // comboBoxAccount
            // 
            this.comboBoxAccount.FormattingEnabled = true;
            this.comboBoxAccount.Location = new System.Drawing.Point(253, 19);
            this.comboBoxAccount.Name = "comboBoxAccount";
            this.comboBoxAccount.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAccount.TabIndex = 14;
            this.comboBoxAccount.SelectedIndexChanged += new System.EventHandler(this.comboBoxAccount_SelectedIndexChanged);
            // 
            // groupBoxAccount
            // 
            this.groupBoxAccount.Controls.Add(this.buttonRefresh);
            this.groupBoxAccount.Controls.Add(this.comboBoxAccount);
            this.groupBoxAccount.Controls.Add(this.comboBoxWallet);
            this.groupBoxAccount.Controls.Add(this.labelWallet);
            this.groupBoxAccount.Controls.Add(this.labelAccount);
            this.groupBoxAccount.Location = new System.Drawing.Point(6, 45);
            this.groupBoxAccount.Name = "groupBoxAccount";
            this.groupBoxAccount.Size = new System.Drawing.Size(442, 47);
            this.groupBoxAccount.TabIndex = 20;
            this.groupBoxAccount.TabStop = false;
            this.groupBoxAccount.Text = "Account";
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.groupBox1);
            this.panelBody.Controls.Add(this.numericTextBoxAmount);
            this.panelBody.Controls.Add(this.groupBoxAccount);
            this.panelBody.Controls.Add(this.textBoxPayTo);
            this.panelBody.Controls.Add(this.labelPayTo);
            this.panelBody.Controls.Add(this.labelAmount);
            this.panelBody.Controls.Add(this.label1);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 82);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(601, 284);
            this.panelBody.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelTxFee);
            this.groupBox1.Controls.Add(this.labelChange);
            this.groupBox1.Controls.Add(this.labelQuantity);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 36);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // labelTxFee
            // 
            this.labelTxFee.AutoSize = true;
            this.labelTxFee.Location = new System.Drawing.Point(474, 15);
            this.labelTxFee.Name = "labelTxFee";
            this.labelTxFee.Size = new System.Drawing.Size(37, 13);
            this.labelTxFee.TabIndex = 12;
            this.labelTxFee.Text = "TxFee";
            // 
            // labelChange
            // 
            this.labelChange.AutoSize = true;
            this.labelChange.Location = new System.Drawing.Point(223, 15);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(44, 13);
            this.labelChange.TabIndex = 11;
            this.labelChange.Text = "Change";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(10, 15);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(46, 13);
            this.labelQuantity.TabIndex = 10;
            this.labelQuantity.Text = "Quantity";
            // 
            // numericTextBoxAmount
            // 
            this.numericTextBoxAmount.AllowDecimal = true;
            this.numericTextBoxAmount.AllowNegativeSign = false;
            this.numericTextBoxAmount.AllowSeparator = false;
            this.numericTextBoxAmount.Decimals = ((uint)(8u));
            this.numericTextBoxAmount.Location = new System.Drawing.Point(64, 143);
            this.numericTextBoxAmount.Name = "numericTextBoxAmount";
            this.numericTextBoxAmount.Size = new System.Drawing.Size(141, 20);
            this.numericTextBoxAmount.TabIndex = 21;
            this.numericTextBoxAmount.Text = "0";
            this.numericTextBoxAmount.TextChanged += new System.EventHandler(this.numericTextBoxAmount_TextChanged);
            // 
            // panelInputsInfo
            // 
            this.panelInputsInfo.Controls.Add(this.textBoxCustomChangeAddress);
            this.panelInputsInfo.Controls.Add(this.checkBoxCustomChangeAddress);
            this.panelInputsInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInputsInfo.Location = new System.Drawing.Point(0, 52);
            this.panelInputsInfo.Name = "panelInputsInfo";
            this.panelInputsInfo.Size = new System.Drawing.Size(601, 30);
            this.panelInputsInfo.TabIndex = 22;
            // 
            // SendView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelInputsInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxCoinControlFeatures);
            this.Name = "SendView";
            this.Size = new System.Drawing.Size(601, 404);
            this.groupBoxCoinControlFeatures.ResumeLayout(false);
            this.groupBoxCoinControlFeatures.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxAccount.ResumeLayout(false);
            this.groupBoxAccount.PerformLayout();
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelInputsInfo.ResumeLayout(false);
            this.panelInputsInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPayTo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelPayTo;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSelectInputs;
        private System.Windows.Forms.Label labelAutomaticallySelected;
        private System.Windows.Forms.CheckBox checkBoxCustomChangeAddress;
        private System.Windows.Forms.TextBox textBoxCustomChangeAddress;
        private System.Windows.Forms.GroupBox groupBoxCoinControlFeatures;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.ComboBox comboBoxWallet;
        private System.Windows.Forms.Label labelWallet;
        private System.Windows.Forms.Label labelAccount;
        private System.Windows.Forms.ComboBox comboBoxAccount;
        private System.Windows.Forms.GroupBox groupBoxAccount;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Panel panelInputsInfo;
        private System.Windows.Forms.Label labelChange;
        private System.Windows.Forms.Label labelTxFee;
        private NumericTextBox numericTextBoxAmount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonRefresh;
    }
}
