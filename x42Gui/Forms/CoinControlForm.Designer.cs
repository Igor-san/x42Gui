namespace x42Gui.Forms
{
    partial class CoinControlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoinControlForm));
            this.spendableTransactionsView1 = new x42Gui.UserControls.SpendablTransactionsView();
            this.SuspendLayout();
            // 
            // spendableTransactionsView1
            // 
            this.spendableTransactionsView1.CommandPanelVisible = true;
            this.spendableTransactionsView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spendableTransactionsView1.Location = new System.Drawing.Point(0, 0);
            this.spendableTransactionsView1.Name = "spendableTransactionsView1";
            this.spendableTransactionsView1.Size = new System.Drawing.Size(649, 397);
            this.spendableTransactionsView1.TabIndex = 2;
            // 
            // CoinControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 397);
            this.Controls.Add(this.spendableTransactionsView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CoinControlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Coin Control";
            this.Load += new System.EventHandler(this.CoinControlForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal UserControls.SpendablTransactionsView spendableTransactionsView1;
    }
}