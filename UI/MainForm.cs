using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ACNH_Turnips_Fortuneteller.Properties;
using ACNH_Turnips_Fortuneteller.Services;
using MyHorizons.Data.TownData;

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
                    if (SaveGameService.OpenSaveFromFolder(Path.GetDirectoryName(openFileDialog.FileName), out StalkMarket? stalkMarket) && stalkMarket != null)
                    {
                        SetPrices(stalkMarket.Value);
                        SetChartData(stalkMarket.Value);
                    }
                    else
                    {
                        MessageBox.Show(Resources.couldnt_parse_the_save_file, Resources.application_name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void SetPrices(StalkMarket stalkMarket)
        {
            sellPriceTextBox.Text = stalkMarket.BuyPrice.ToString();
            stalkMarketDataGridView.Rows.Clear();
            AddDayPrice(Resources.monday, stalkMarket.Monday.MorningPrice, stalkMarket.Monday.EveningPrice);
            AddDayPrice(Resources.tuesday, stalkMarket.Tuesday.MorningPrice, stalkMarket.Tuesday.EveningPrice);
            AddDayPrice(Resources.wednesday, stalkMarket.Wednesday.MorningPrice, stalkMarket.Wednesday.EveningPrice);
            AddDayPrice(Resources.thursday, stalkMarket.Thursday.MorningPrice, stalkMarket.Thursday.EveningPrice);
            AddDayPrice(Resources.friday, stalkMarket.Friday.MorningPrice, stalkMarket.Friday.EveningPrice);
            AddDayPrice(Resources.saturday, stalkMarket.Saturday.MorningPrice, stalkMarket.Saturday.EveningPrice);


        }

        private void AddDayPrice(string day, uint morningPrice, uint eveningPrice)
        {
            stalkMarketDataGridView.Rows.Add(day, morningPrice, "a.m");
            stalkMarketDataGridView.Rows.Add("", eveningPrice, "p.m");
        }

        private void SetChartData(StalkMarket stalkMarket)
        {
            StalkMarketSeries.Points.Clear();
            AddXYToChart(Resources.monday, stalkMarket.Monday.MorningPrice);
            AddXYToChart(Resources.monday, stalkMarket.Monday.EveningPrice);
            AddXYToChart(Resources.tuesday, stalkMarket.Tuesday.MorningPrice);
            AddXYToChart(Resources.tuesday, stalkMarket.Tuesday.EveningPrice);
            AddXYToChart(Resources.wednesday, stalkMarket.Wednesday.MorningPrice);
            AddXYToChart(Resources.wednesday, stalkMarket.Wednesday.EveningPrice);
            AddXYToChart(Resources.thursday, stalkMarket.Thursday.MorningPrice);
            AddXYToChart(Resources.thursday, stalkMarket.Thursday.EveningPrice);
            AddXYToChart(Resources.friday, stalkMarket.Friday.MorningPrice);
            AddXYToChart(Resources.friday, stalkMarket.Friday.EveningPrice);
            AddXYToChart(Resources.saturday, stalkMarket.Saturday.MorningPrice);
            AddXYToChart(Resources.saturday, stalkMarket.Saturday.EveningPrice);
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
