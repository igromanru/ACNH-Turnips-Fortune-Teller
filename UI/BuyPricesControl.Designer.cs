namespace ACNH_Turnips_Fortuneteller.UI
{
    partial class BuyPricesControl
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
            this.buyPricesGroupBox = new System.Windows.Forms.GroupBox();
            this.eveningBuyPriceTextBox = new System.Windows.Forms.TextBox();
            this.eveningLabel = new System.Windows.Forms.Label();
            this.morningBuyPriceTextBox = new System.Windows.Forms.TextBox();
            this.morningLabel = new System.Windows.Forms.Label();
            this.buyPricesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // buyPricesGroupBox
            // 
            this.buyPricesGroupBox.BackColor = System.Drawing.SystemColors.Window;
            this.buyPricesGroupBox.Controls.Add(this.eveningBuyPriceTextBox);
            this.buyPricesGroupBox.Controls.Add(this.eveningLabel);
            this.buyPricesGroupBox.Controls.Add(this.morningBuyPriceTextBox);
            this.buyPricesGroupBox.Controls.Add(this.morningLabel);
            this.buyPricesGroupBox.Location = new System.Drawing.Point(3, 3);
            this.buyPricesGroupBox.Name = "buyPricesGroupBox";
            this.buyPricesGroupBox.Size = new System.Drawing.Size(130, 73);
            this.buyPricesGroupBox.TabIndex = 3;
            this.buyPricesGroupBox.TabStop = false;
            this.buyPricesGroupBox.Text = " buy prices";
            // 
            // eveningBuyPriceTextBox
            // 
            this.eveningBuyPriceTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.eveningBuyPriceTextBox.Location = new System.Drawing.Point(57, 43);
            this.eveningBuyPriceTextBox.Name = "eveningBuyPriceTextBox";
            this.eveningBuyPriceTextBox.ReadOnly = true;
            this.eveningBuyPriceTextBox.Size = new System.Drawing.Size(55, 20);
            this.eveningBuyPriceTextBox.TabIndex = 5;
            // 
            // eveningLabel
            // 
            this.eveningLabel.AutoSize = true;
            this.eveningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eveningLabel.Location = new System.Drawing.Point(6, 46);
            this.eveningLabel.Name = "eveningLabel";
            this.eveningLabel.Size = new System.Drawing.Size(46, 13);
            this.eveningLabel.TabIndex = 4;
            this.eveningLabel.Text = "Evening";
            // 
            // morningBuyPriceTextBox
            // 
            this.morningBuyPriceTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.morningBuyPriceTextBox.Location = new System.Drawing.Point(57, 17);
            this.morningBuyPriceTextBox.Name = "morningBuyPriceTextBox";
            this.morningBuyPriceTextBox.ReadOnly = true;
            this.morningBuyPriceTextBox.Size = new System.Drawing.Size(55, 20);
            this.morningBuyPriceTextBox.TabIndex = 3;
            // 
            // morningLabel
            // 
            this.morningLabel.AutoSize = true;
            this.morningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.morningLabel.Location = new System.Drawing.Point(6, 20);
            this.morningLabel.Name = "morningLabel";
            this.morningLabel.Size = new System.Drawing.Size(45, 13);
            this.morningLabel.TabIndex = 2;
            this.morningLabel.Text = "Morning";
            // 
            // BuyPricesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buyPricesGroupBox);
            this.Name = "BuyPricesControl";
            this.Size = new System.Drawing.Size(138, 79);
            this.buyPricesGroupBox.ResumeLayout(false);
            this.buyPricesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox buyPricesGroupBox;
        private System.Windows.Forms.TextBox eveningBuyPriceTextBox;
        private System.Windows.Forms.Label eveningLabel;
        private System.Windows.Forms.TextBox morningBuyPriceTextBox;
        private System.Windows.Forms.Label morningLabel;
    }
}
