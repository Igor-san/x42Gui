namespace x42Gui.Forms
{
    partial class OptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageNetwork = new System.Windows.Forms.TabPage();
            this.numericUpDownMinTxFee = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonStratis = new System.Windows.Forms.RadioButton();
            this.radioButtonX42 = new System.Windows.Forms.RadioButton();
            this.buttonFromStratis = new System.Windows.Forms.Button();
            this.buttonFromX42 = new System.Windows.Forms.Button();
            this.textBoxTestApiUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMainApiUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonTestnet = new System.Windows.Forms.RadioButton();
            this.radioButtonMainnet = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageNetwork.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinTxFee)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonOk);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 43);
            this.panel1.TabIndex = 0;
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(294, 8);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(12, 8);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageNetwork);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(381, 202);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageNetwork
            // 
            this.tabPageNetwork.Controls.Add(this.numericUpDownMinTxFee);
            this.tabPageNetwork.Controls.Add(this.groupBox2);
            this.tabPageNetwork.Controls.Add(this.buttonFromStratis);
            this.tabPageNetwork.Controls.Add(this.buttonFromX42);
            this.tabPageNetwork.Controls.Add(this.textBoxTestApiUrl);
            this.tabPageNetwork.Controls.Add(this.label2);
            this.tabPageNetwork.Controls.Add(this.textBoxMainApiUrl);
            this.tabPageNetwork.Controls.Add(this.label1);
            this.tabPageNetwork.Controls.Add(this.groupBox1);
            this.tabPageNetwork.Location = new System.Drawing.Point(4, 22);
            this.tabPageNetwork.Name = "tabPageNetwork";
            this.tabPageNetwork.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNetwork.Size = new System.Drawing.Size(373, 176);
            this.tabPageNetwork.TabIndex = 1;
            this.tabPageNetwork.Text = "Network";
            this.tabPageNetwork.UseVisualStyleBackColor = true;
            // 
            // numericUpDownMinTxFee
            // 
            this.numericUpDownMinTxFee.DecimalPlaces = 8;
            this.numericUpDownMinTxFee.Increment = new decimal(new int[] {
            1,
            0,
            0,
            524288});
            this.numericUpDownMinTxFee.Location = new System.Drawing.Point(243, 128);
            this.numericUpDownMinTxFee.Name = "numericUpDownMinTxFee";
            this.numericUpDownMinTxFee.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMinTxFee.TabIndex = 8;
            this.toolTip1.SetToolTip(this.numericUpDownMinTxFee, "минимальная комиссия");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonStratis);
            this.groupBox2.Controls.Add(this.radioButtonX42);
            this.groupBox2.Location = new System.Drawing.Point(227, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(136, 35);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // radioButtonStratis
            // 
            this.radioButtonStratis.AutoSize = true;
            this.radioButtonStratis.Location = new System.Drawing.Point(66, 9);
            this.radioButtonStratis.Name = "radioButtonStratis";
            this.radioButtonStratis.Size = new System.Drawing.Size(54, 17);
            this.radioButtonStratis.TabIndex = 1;
            this.radioButtonStratis.Text = "Stratis";
            this.radioButtonStratis.UseVisualStyleBackColor = true;
            // 
            // radioButtonX42
            // 
            this.radioButtonX42.AutoSize = true;
            this.radioButtonX42.Checked = true;
            this.radioButtonX42.Location = new System.Drawing.Point(6, 9);
            this.radioButtonX42.Name = "radioButtonX42";
            this.radioButtonX42.Size = new System.Drawing.Size(42, 17);
            this.radioButtonX42.TabIndex = 0;
            this.radioButtonX42.TabStop = true;
            this.radioButtonX42.Text = "x42";
            this.radioButtonX42.UseVisualStyleBackColor = true;
            // 
            // buttonFromStratis
            // 
            this.buttonFromStratis.Image = ((System.Drawing.Image)(resources.GetObject("buttonFromStratis.Image")));
            this.buttonFromStratis.Location = new System.Drawing.Point(121, 128);
            this.buttonFromStratis.Name = "buttonFromStratis";
            this.buttonFromStratis.Size = new System.Drawing.Size(75, 42);
            this.buttonFromStratis.TabIndex = 6;
            this.buttonFromStratis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.buttonFromStratis, "настройки сети Stratis");
            this.buttonFromStratis.UseVisualStyleBackColor = true;
            this.buttonFromStratis.Click += new System.EventHandler(this.buttonFromStratis_Click);
            // 
            // buttonFromX42
            // 
            this.buttonFromX42.Image = ((System.Drawing.Image)(resources.GetObject("buttonFromX42.Image")));
            this.buttonFromX42.Location = new System.Drawing.Point(21, 128);
            this.buttonFromX42.Name = "buttonFromX42";
            this.buttonFromX42.Size = new System.Drawing.Size(75, 42);
            this.buttonFromX42.TabIndex = 5;
            this.buttonFromX42.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.buttonFromX42, "настройки сети x42");
            this.buttonFromX42.UseVisualStyleBackColor = true;
            this.buttonFromX42.Click += new System.EventHandler(this.buttonFromX42_Click);
            // 
            // textBoxTestApiUrl
            // 
            this.textBoxTestApiUrl.Location = new System.Drawing.Point(99, 79);
            this.textBoxTestApiUrl.Name = "textBoxTestApiUrl";
            this.textBoxTestApiUrl.Size = new System.Drawing.Size(264, 20);
            this.textBoxTestApiUrl.TabIndex = 4;
            this.textBoxTestApiUrl.Text = "http://localhost:42221/api/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Testnet Api Url:";
            // 
            // textBoxMainApiUrl
            // 
            this.textBoxMainApiUrl.Location = new System.Drawing.Point(99, 53);
            this.textBoxMainApiUrl.Name = "textBoxMainApiUrl";
            this.textBoxMainApiUrl.Size = new System.Drawing.Size(264, 20);
            this.textBoxMainApiUrl.TabIndex = 2;
            this.textBoxMainApiUrl.Text = "http://localhost:42220/api/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mainnet Api Url:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonTestnet);
            this.groupBox1.Controls.Add(this.radioButtonMainnet);
            this.groupBox1.Location = new System.Drawing.Point(14, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 35);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonTestnet
            // 
            this.radioButtonTestnet.AutoSize = true;
            this.radioButtonTestnet.Location = new System.Drawing.Point(94, 9);
            this.radioButtonTestnet.Name = "radioButtonTestnet";
            this.radioButtonTestnet.Size = new System.Drawing.Size(61, 17);
            this.radioButtonTestnet.TabIndex = 1;
            this.radioButtonTestnet.Text = "Testnet";
            this.radioButtonTestnet.UseVisualStyleBackColor = true;
            // 
            // radioButtonMainnet
            // 
            this.radioButtonMainnet.AutoSize = true;
            this.radioButtonMainnet.Checked = true;
            this.radioButtonMainnet.Location = new System.Drawing.Point(6, 9);
            this.radioButtonMainnet.Name = "radioButtonMainnet";
            this.radioButtonMainnet.Size = new System.Drawing.Size(63, 17);
            this.radioButtonMainnet.TabIndex = 0;
            this.radioButtonMainnet.TabStop = true;
            this.radioButtonMainnet.Text = "Mainnet";
            this.radioButtonMainnet.UseVisualStyleBackColor = true;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 245);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Опции";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageNetwork.ResumeLayout(false);
            this.tabPageNetwork.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinTxFee)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageNetwork;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonTestnet;
        private System.Windows.Forms.RadioButton radioButtonMainnet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMainApiUrl;
        private System.Windows.Forms.TextBox textBoxTestApiUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonFromStratis;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonFromX42;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonStratis;
        private System.Windows.Forms.RadioButton radioButtonX42;
        private System.Windows.Forms.NumericUpDown numericUpDownMinTxFee;
    }
}