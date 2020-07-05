using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ACNH_Turnips_Fortuneteller.Properties;
using ACNH_Turnips_Fortuneteller.Services;
using NHSE.Core;

namespace ACNH_Turnips_Fortuneteller.UI
{
    public partial class MainForm : Form
    {
        private SaveGameService SaveGameService { get; }

        private Series StalkMarketSeries;

        public MainForm()
        {
            InitializeComponent();

            StalkMarketSeries = stalkMarketChart.Series["stalkMarketSeries"];
            StalkMarketSeries.Points.Clear(); // cleaning test data

            SaveGameService = new SaveGameService();
        }

        private void openSaveButton_Click(object sender, System.EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = Resources.acnh_save_file_filter;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (SaveGameService.OpenSaveFromFolder(Path.GetDirectoryName(openFileDialog.FileName), out TurnipStonk turnipStonk) && turnipStonk != null)
                    {
                        SetPrices(turnipStonk);
                        SetChartData(turnipStonk);
                    }
                    else
                    {
                        MessageBox.Show(Resources.couldnt_parse_the_save_file, Resources.application_name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void SetPrices(TurnipStonk turnipStonk)
        {
            sellPriceTextBox.Text = turnipStonk.BuyPrice.ToString();
            stalkMarketDataGridView.Rows.Clear();
            AddDayPrice(Resources.monday, turnipStonk.SellMondayAM, turnipStonk.SellMondayPM);
            AddDayPrice(Resources.tuesday, turnipStonk.SellTuesdayAM, turnipStonk.SellTuesdayPM);
            AddDayPrice(Resources.wednesday, turnipStonk.SellWednesdayAM, turnipStonk.SellWednesdayPM);
            AddDayPrice(Resources.thursday, turnipStonk.SellThursdayAM, turnipStonk.SellThursdayPM);
            AddDayPrice(Resources.friday, turnipStonk.SellFridayAM, turnipStonk.SellFridayPM);
            AddDayPrice(Resources.saturday, turnipStonk.SellSaturdayAM, turnipStonk.SellSaturdayPM);


        }

        private void AddDayPrice(string day, uint morningPrice, uint eveningPrice)
        {
            stalkMarketDataGridView.Rows.Add(day, morningPrice, "a.m");
            stalkMarketDataGridView.Rows.Add("", eveningPrice, "p.m");
        }

        private void SetChartData(TurnipStonk stalkMarket)
        {
            StalkMarketSeries.Points.Clear();
            AddXYToChart(Resources.monday, stalkMarket.SellMondayAM);
            AddXYToChart(Resources.monday, stalkMarket.SellMondayPM);
            AddXYToChart(Resources.tuesday, stalkMarket.SellTuesdayAM);
            AddXYToChart(Resources.tuesday, stalkMarket.SellTuesdayPM);
            AddXYToChart(Resources.wednesday, stalkMarket.SellWednesdayAM);
            AddXYToChart(Resources.wednesday, stalkMarket.SellWednesdayPM);
            AddXYToChart(Resources.thursday, stalkMarket.SellThursdayAM);
            AddXYToChart(Resources.thursday, stalkMarket.SellThursdayPM);
            AddXYToChart(Resources.friday, stalkMarket.SellFridayAM);
            AddXYToChart(Resources.friday, stalkMarket.SellFridayPM);
            AddXYToChart(Resources.saturday, stalkMarket.SellSaturdayAM);
            AddXYToChart(Resources.saturday, stalkMarket.SellSaturdayPM);
        }

        private void AddXYToChart(string xValue, uint yValue)
        {
            var index = StalkMarketSeries.Points.AddXY(xValue, yValue);
            var currentDataPoint = StalkMarketSeries.Points[index];
            var color = DefaultForeColor;
            if (index > 0)
            {
                var previousValue = StalkMarketSeries.Points[index - 1].YValues[0];
                if (previousValue < yValue)
                {
                    color = Color.Green;
                }
                else if (previousValue > yValue)
                {
                    color = Color.Red;
                }
                currentDataPoint.Color = color;
            }
        }

        private void stalkMarketDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dataGridView = (DataGridView)sender;
            if (dataGridView.Rows.Count > e.RowIndex && dataGridView.Rows[e.RowIndex].Cells.Count > e.ColumnIndex)
            {
                var value = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (!string.IsNullOrEmpty(value))
                {
                    Clipboard.SetText(value);
                }
            }
        }

        private void sellPriceTextBox_Click(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                Clipboard.SetText(textBox.Text);
            }
        }
    }
}
