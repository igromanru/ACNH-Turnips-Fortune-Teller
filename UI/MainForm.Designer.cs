namespace ACNH_Turnips_Fortuneteller.UI
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 95D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 90D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 101D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 125D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 171D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 186D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 150D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 82D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 78D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 73D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 68D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 64D);
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sellPriceLabel = new System.Windows.Forms.Label();
            this.sellPriceTextBox = new System.Windows.Forms.TextBox();
            this.openSaveButton = new System.Windows.Forms.Button();
            this.stalkMarketChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.saturdayBuyPricesControl = new ACNH_Turnips_Fortuneteller.UI.BuyPricesControl();
            this.fridayBuyPricesControl = new ACNH_Turnips_Fortuneteller.UI.BuyPricesControl();
            this.thursdayBuyPricesControl = new ACNH_Turnips_Fortuneteller.UI.BuyPricesControl();
            this.wednesdayBuyPricesControl = new ACNH_Turnips_Fortuneteller.UI.BuyPricesControl();
            this.tuesdayBuyPricesControl = new ACNH_Turnips_Fortuneteller.UI.BuyPricesControl();
            this.mondayBuyPricesControl = new ACNH_Turnips_Fortuneteller.UI.BuyPricesControl();
            ((System.ComponentModel.ISupportInitialize)(this.stalkMarketChart)).BeginInit();
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
            this.sellPriceTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.sellPriceTextBox.Location = new System.Drawing.Point(106, 10);
            this.sellPriceTextBox.Name = "sellPriceTextBox";
            this.sellPriceTextBox.ReadOnly = true;
            this.sellPriceTextBox.Size = new System.Drawing.Size(55, 20);
            this.sellPriceTextBox.TabIndex = 1;
            // 
            // openSaveButton
            // 
            this.openSaveButton.Location = new System.Drawing.Point(223, 8);
            this.openSaveButton.Name = "openSaveButton";
            this.openSaveButton.Size = new System.Drawing.Size(138, 23);
            this.openSaveButton.TabIndex = 8;
            this.openSaveButton.Text = "Open save game...";
            this.openSaveButton.UseVisualStyleBackColor = true;
            this.openSaveButton.Click += new System.EventHandler(this.openSaveButton_Click);
            // 
            // stalkMarketChart
            // 
            this.stalkMarketChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stalkMarketChart.BorderlineColor = System.Drawing.Color.Silver;
            this.stalkMarketChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX2.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY2.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.Name = "stalkMarketChartArea";
            this.stalkMarketChart.ChartAreas.Add(chartArea1);
            this.stalkMarketChart.Location = new System.Drawing.Point(368, 8);
            this.stalkMarketChart.Name = "stalkMarketChart";
            series1.BorderWidth = 2;
            series1.ChartArea = "stalkMarketChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.Name = "stalkMarketSeries";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            series1.Points.Add(dataPoint7);
            series1.Points.Add(dataPoint8);
            series1.Points.Add(dataPoint9);
            series1.Points.Add(dataPoint10);
            series1.Points.Add(dataPoint11);
            series1.Points.Add(dataPoint12);
            series1.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            series1.SmartLabelStyle.MaxMovingDistance = 40D;
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt32;
            this.stalkMarketChart.Series.Add(series1);
            this.stalkMarketChart.Size = new System.Drawing.Size(528, 336);
            this.stalkMarketChart.TabIndex = 9;
            this.stalkMarketChart.Text = "Stalk Market";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            title1.Name = "stalkMarketTitle";
            title1.Text = "Stalk Market";
            this.stalkMarketChart.Titles.Add(title1);
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
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(904, 351);
            this.Controls.Add(this.stalkMarketChart);
            this.Controls.Add(this.openSaveButton);
            this.Controls.Add(this.saturdayBuyPricesControl);
            this.Controls.Add(this.fridayBuyPricesControl);
            this.Controls.Add(this.thursdayBuyPricesControl);
            this.Controls.Add(this.wednesdayBuyPricesControl);
            this.Controls.Add(this.tuesdayBuyPricesControl);
            this.Controls.Add(this.mondayBuyPricesControl);
            this.Controls.Add(this.sellPriceTextBox);
            this.Controls.Add(this.sellPriceLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(920, 390);
            this.Name = "MainForm";
            this.Text = "ACNH Turnips Fortune Teller";
            ((System.ComponentModel.ISupportInitialize)(this.stalkMarketChart)).EndInit();
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
        private System.Windows.Forms.Button openSaveButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart stalkMarketChart;
    }
}

