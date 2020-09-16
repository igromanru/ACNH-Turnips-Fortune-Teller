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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sellPriceLabel = new System.Windows.Forms.Label();
            this.sellPriceTextBox = new System.Windows.Forms.TextBox();
            this.openSaveButton = new System.Windows.Forms.Button();
            this.stalkMarketChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.stalkMarketDataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DayTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.turnipsTabPage = new System.Windows.Forms.TabPage();
            this.visitorsTabPage = new System.Windows.Forms.TabPage();
            this.visitorsDataGridView = new System.Windows.Forms.DataGridView();
            this.visitDayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primaryVisitorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondaryVisitorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveTimeLabel = new System.Windows.Forms.Label();
            this.saveTimeValueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stalkMarketChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stalkMarketDataGridView)).BeginInit();
            this.tabControl.SuspendLayout();
            this.turnipsTabPage.SuspendLayout();
            this.visitorsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitorsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sellPriceLabel
            // 
            this.sellPriceLabel.AutoSize = true;
            this.sellPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellPriceLabel.Location = new System.Drawing.Point(3, 9);
            this.sellPriceLabel.Name = "sellPriceLabel";
            this.sellPriceLabel.Size = new System.Drawing.Size(87, 13);
            this.sellPriceLabel.TabIndex = 0;
            this.sellPriceLabel.Text = "Sunday sell price";
            // 
            // sellPriceTextBox
            // 
            this.sellPriceTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.sellPriceTextBox.Location = new System.Drawing.Point(93, 6);
            this.sellPriceTextBox.Name = "sellPriceTextBox";
            this.sellPriceTextBox.ReadOnly = true;
            this.sellPriceTextBox.Size = new System.Drawing.Size(60, 20);
            this.sellPriceTextBox.TabIndex = 1;
            this.sellPriceTextBox.Click += new System.EventHandler(this.sellPriceTextBox_Click);
            // 
            // openSaveButton
            // 
            this.openSaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openSaveButton.BackColor = System.Drawing.SystemColors.Window;
            this.openSaveButton.Location = new System.Drawing.Point(169, 6);
            this.openSaveButton.Name = "openSaveButton";
            this.openSaveButton.Size = new System.Drawing.Size(555, 23);
            this.openSaveButton.TabIndex = 8;
            this.openSaveButton.Text = "Open save game...";
            this.openSaveButton.UseVisualStyleBackColor = false;
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
            this.stalkMarketChart.Location = new System.Drawing.Point(159, 6);
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
            this.stalkMarketChart.Size = new System.Drawing.Size(550, 352);
            this.stalkMarketChart.TabIndex = 9;
            this.stalkMarketChart.Text = "Stalk Market";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            title1.Name = "stalkMarketTitle";
            title1.Text = "Stalk Market";
            this.stalkMarketChart.Titles.Add(title1);
            // 
            // stalkMarketDataGridView
            // 
            this.stalkMarketDataGridView.AllowUserToAddRows = false;
            this.stalkMarketDataGridView.AllowUserToDeleteRows = false;
            this.stalkMarketDataGridView.AllowUserToResizeColumns = false;
            this.stalkMarketDataGridView.AllowUserToResizeRows = false;
            this.stalkMarketDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.stalkMarketDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.stalkMarketDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.stalkMarketDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.stalkMarketDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.stalkMarketDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.PriceColumn,
            this.DayTimeColumn});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.stalkMarketDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.stalkMarketDataGridView.GridColor = System.Drawing.SystemColors.Window;
            this.stalkMarketDataGridView.Location = new System.Drawing.Point(3, 32);
            this.stalkMarketDataGridView.MultiSelect = false;
            this.stalkMarketDataGridView.Name = "stalkMarketDataGridView";
            this.stalkMarketDataGridView.ReadOnly = true;
            this.stalkMarketDataGridView.RowHeadersVisible = false;
            this.stalkMarketDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.stalkMarketDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.stalkMarketDataGridView.Size = new System.Drawing.Size(150, 326);
            this.stalkMarketDataGridView.TabIndex = 10;
            this.stalkMarketDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stalkMarketDataGridView_CellContentClick);
            // 
            // ColumnName
            // 
            this.ColumnName.FillWeight = 60F;
            this.ColumnName.HeaderText = "Day";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnName.Width = 60;
            // 
            // PriceColumn
            // 
            this.PriceColumn.FillWeight = 45F;
            this.PriceColumn.HeaderText = "Price";
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.ReadOnly = true;
            this.PriceColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PriceColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PriceColumn.Width = 45;
            // 
            // DayTimeColumn
            // 
            this.DayTimeColumn.FillWeight = 40F;
            this.DayTimeColumn.HeaderText = "Time";
            this.DayTimeColumn.Name = "DayTimeColumn";
            this.DayTimeColumn.ReadOnly = true;
            this.DayTimeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DayTimeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DayTimeColumn.Width = 40;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.turnipsTabPage);
            this.tabControl.Controls.Add(this.visitorsTabPage);
            this.tabControl.Location = new System.Drawing.Point(6, 35);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(722, 389);
            this.tabControl.TabIndex = 11;
            // 
            // turnipsTabPage
            // 
            this.turnipsTabPage.Controls.Add(this.stalkMarketChart);
            this.turnipsTabPage.Controls.Add(this.stalkMarketDataGridView);
            this.turnipsTabPage.Controls.Add(this.sellPriceLabel);
            this.turnipsTabPage.Controls.Add(this.sellPriceTextBox);
            this.turnipsTabPage.Location = new System.Drawing.Point(4, 22);
            this.turnipsTabPage.Name = "turnipsTabPage";
            this.turnipsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.turnipsTabPage.Size = new System.Drawing.Size(714, 363);
            this.turnipsTabPage.TabIndex = 0;
            this.turnipsTabPage.Text = "Turnips";
            this.turnipsTabPage.UseVisualStyleBackColor = true;
            // 
            // visitorsTabPage
            // 
            this.visitorsTabPage.Controls.Add(this.visitorsDataGridView);
            this.visitorsTabPage.Location = new System.Drawing.Point(4, 22);
            this.visitorsTabPage.Name = "visitorsTabPage";
            this.visitorsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.visitorsTabPage.Size = new System.Drawing.Size(714, 363);
            this.visitorsTabPage.TabIndex = 1;
            this.visitorsTabPage.Text = "Visitors";
            this.visitorsTabPage.UseVisualStyleBackColor = true;
            // 
            // visitorsDataGridView
            // 
            this.visitorsDataGridView.AllowUserToAddRows = false;
            this.visitorsDataGridView.AllowUserToDeleteRows = false;
            this.visitorsDataGridView.AllowUserToResizeRows = false;
            this.visitorsDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.visitorsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.visitorsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.visitorsDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.visitorsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.visitDayColumn,
            this.primaryVisitorColumn,
            this.secondaryVisitorColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.visitorsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.visitorsDataGridView.GridColor = System.Drawing.SystemColors.Window;
            this.visitorsDataGridView.Location = new System.Drawing.Point(0, 3);
            this.visitorsDataGridView.MultiSelect = false;
            this.visitorsDataGridView.Name = "visitorsDataGridView";
            this.visitorsDataGridView.ReadOnly = true;
            this.visitorsDataGridView.RowHeadersVisible = false;
            this.visitorsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.visitorsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.visitorsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.visitorsDataGridView.Size = new System.Drawing.Size(246, 286);
            this.visitorsDataGridView.TabIndex = 11;
            // 
            // visitDayColumn
            // 
            this.visitDayColumn.FillWeight = 70F;
            this.visitDayColumn.HeaderText = "Day";
            this.visitDayColumn.Name = "visitDayColumn";
            this.visitDayColumn.ReadOnly = true;
            this.visitDayColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.visitDayColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.visitDayColumn.Width = 70;
            // 
            // primaryVisitorColumn
            // 
            this.primaryVisitorColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.primaryVisitorColumn.HeaderText = "Primary Visitor";
            this.primaryVisitorColumn.Name = "primaryVisitorColumn";
            this.primaryVisitorColumn.ReadOnly = true;
            this.primaryVisitorColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.primaryVisitorColumn.Width = 78;
            // 
            // secondaryVisitorColumn
            // 
            this.secondaryVisitorColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.secondaryVisitorColumn.HeaderText = "Secondary Visitor";
            this.secondaryVisitorColumn.Name = "secondaryVisitorColumn";
            this.secondaryVisitorColumn.ReadOnly = true;
            this.secondaryVisitorColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.secondaryVisitorColumn.Width = 95;
            // 
            // saveTimeLabel
            // 
            this.saveTimeLabel.AutoSize = true;
            this.saveTimeLabel.Location = new System.Drawing.Point(3, 11);
            this.saveTimeLabel.Name = "saveTimeLabel";
            this.saveTimeLabel.Size = new System.Drawing.Size(57, 13);
            this.saveTimeLabel.TabIndex = 12;
            this.saveTimeLabel.Text = "Save time:";
            // 
            // saveTimeValueLabel
            // 
            this.saveTimeValueLabel.AutoSize = true;
            this.saveTimeValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveTimeValueLabel.Location = new System.Drawing.Point(57, 12);
            this.saveTimeValueLabel.Name = "saveTimeValueLabel";
            this.saveTimeValueLabel.Size = new System.Drawing.Size(0, 13);
            this.saveTimeValueLabel.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(732, 427);
            this.Controls.Add(this.saveTimeLabel);
            this.Controls.Add(this.saveTimeValueLabel);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.openSaveButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(748, 466);
            this.Name = "MainForm";
            this.Text = "ACNH Turnips Fortune Teller";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.stalkMarketChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stalkMarketDataGridView)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.turnipsTabPage.ResumeLayout(false);
            this.turnipsTabPage.PerformLayout();
            this.visitorsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.visitorsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sellPriceLabel;
        private System.Windows.Forms.TextBox sellPriceTextBox;
        private System.Windows.Forms.Button openSaveButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart stalkMarketChart;
        private System.Windows.Forms.DataGridView stalkMarketDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DayTimeColumn;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage turnipsTabPage;
        private System.Windows.Forms.TabPage visitorsTabPage;
        private System.Windows.Forms.Label saveTimeLabel;
        private System.Windows.Forms.Label saveTimeValueLabel;
        private System.Windows.Forms.DataGridView visitorsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitDayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primaryVisitorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondaryVisitorColumn;
    }
}

