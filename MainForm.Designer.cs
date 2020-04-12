namespace ACNH_Turnips_Fortuneteller
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
            this.sellPriceLabel = new System.Windows.Forms.Label();
            this.sellPriceTextBox = new System.Windows.Forms.TextBox();
            this.saturdayBuyPricesControl = new ACNH_Turnips_Fortuneteller.BuyPricesControl();
            this.fridayBuyPricesControl = new ACNH_Turnips_Fortuneteller.BuyPricesControl();
            this.thursdayBuyPricesControl = new ACNH_Turnips_Fortuneteller.BuyPricesControl();
            this.wednesdayBuyPricesControl = new ACNH_Turnips_Fortuneteller.BuyPricesControl();
            this.tuesdayBuyPricesControl = new ACNH_Turnips_Fortuneteller.BuyPricesControl();
            this.mondayBuyPricesControl = new ACNH_Turnips_Fortuneteller.BuyPricesControl();
            this.SuspendLayout();
            // 
            // sellPriceLabel
            // 
            this.sellPriceLabel.AutoSize = true;
            this.sellPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellPriceLabel.Location = new System.Drawing.Point(13, 13);
            this.sellPriceLabel.Name = "sellPriceLabel";
            this.sellPriceLabel.Size = new System.Drawing.Size(87, 13);
            this.sellPriceLabel.TabIndex = 0;
            this.sellPriceLabel.Text = "Sunday sell price";
            // 
            // sellPriceTextBox
            // 
            this.sellPriceTextBox.Location = new System.Drawing.Point(106, 10);
            this.sellPriceTextBox.Name = "sellPriceTextBox";
            this.sellPriceTextBox.ReadOnly = true;
            this.sellPriceTextBox.Size = new System.Drawing.Size(55, 20);
            this.sellPriceTextBox.TabIndex = 1;
            // 
            // saturdayBuyPricesControl
            // 
            this.saturdayBuyPricesControl.Location = new System.Drawing.Point(223, 206);
            this.saturdayBuyPricesControl.Name = "saturdayBuyPricesControl";
            this.saturdayBuyPricesControl.Size = new System.Drawing.Size(138, 79);
            this.saturdayBuyPricesControl.TabIndex = 7;
            // 
            // fridayBuyPricesControl
            // 
            this.fridayBuyPricesControl.Location = new System.Drawing.Point(223, 121);
            this.fridayBuyPricesControl.Name = "fridayBuyPricesControl";
            this.fridayBuyPricesControl.Size = new System.Drawing.Size(138, 79);
            this.fridayBuyPricesControl.TabIndex = 6;
            // 
            // thursdayBuyPricesControl
            // 
            this.thursdayBuyPricesControl.Location = new System.Drawing.Point(223, 36);
            this.thursdayBuyPricesControl.Name = "thursdayBuyPricesControl";
            this.thursdayBuyPricesControl.Size = new System.Drawing.Size(138, 79);
            this.thursdayBuyPricesControl.TabIndex = 5;
            // 
            // wednesdayBuyPricesControl
            // 
            this.wednesdayBuyPricesControl.Location = new System.Drawing.Point(12, 206);
            this.wednesdayBuyPricesControl.Name = "wednesdayBuyPricesControl";
            this.wednesdayBuyPricesControl.Size = new System.Drawing.Size(138, 79);
            this.wednesdayBuyPricesControl.TabIndex = 4;
            // 
            // tuesdayBuyPricesControl
            // 
            this.tuesdayBuyPricesControl.Location = new System.Drawing.Point(12, 121);
            this.tuesdayBuyPricesControl.Name = "tuesdayBuyPricesControl";
            this.tuesdayBuyPricesControl.Size = new System.Drawing.Size(138, 79);
            this.tuesdayBuyPricesControl.TabIndex = 3;
            // 
            // mondayBuyPricesControl
            // 
            this.mondayBuyPricesControl.Location = new System.Drawing.Point(12, 36);
            this.mondayBuyPricesControl.Name = "mondayBuyPricesControl";
            this.mondayBuyPricesControl.Size = new System.Drawing.Size(138, 79);
            this.mondayBuyPricesControl.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 301);
            this.Controls.Add(this.saturdayBuyPricesControl);
            this.Controls.Add(this.fridayBuyPricesControl);
            this.Controls.Add(this.thursdayBuyPricesControl);
            this.Controls.Add(this.wednesdayBuyPricesControl);
            this.Controls.Add(this.tuesdayBuyPricesControl);
            this.Controls.Add(this.mondayBuyPricesControl);
            this.Controls.Add(this.sellPriceTextBox);
            this.Controls.Add(this.sellPriceLabel);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACNH Turnips Fortuneteller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sellPriceLabel;
        private System.Windows.Forms.TextBox sellPriceTextBox;
        private BuyPricesControl mondayBuyPricesControl;
        private BuyPricesControl tuesdayBuyPricesControl;
        private BuyPricesControl wednesdayBuyPricesControl;
        private BuyPricesControl thursdayBuyPricesControl;
        private BuyPricesControl fridayBuyPricesControl;
        private BuyPricesControl saturdayBuyPricesControl;
    }
}

