using System.Drawing;
using System.IO;
using System.Resources;
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

            mondayBuyPricesControl.SetTitle("Monday");
            tuesdayBuyPricesControl.SetTitle("Tuesday");
            wednesdayBuyPricesControl.SetTitle("Wednesday");
            thursdayBuyPricesControl.SetTitle("Thursday");
            fridayBuyPricesControl.SetTitle("Friday");
            saturdayBuyPricesControl.SetTitle("Saturday");

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
            mondayBuyPricesControl.SetPrices(stalkMarket.Monday.MorningPrice, stalkMarket.Monday.EveningPrice);
            tuesdayBuyPricesControl.SetPrices(stalkMarket.Tuesday.MorningPrice, stalkMarket.Tuesday.EveningPrice);
            wednesdayBuyPricesControl.SetPrices(stalkMarket.Wednesday.MorningPrice, stalkMarket.Wednesday.EveningPrice);
            thursdayBuyPricesControl.SetPrices(stalkMarket.Thursday.MorningPrice, stalkMarket.Thursday.EveningPrice);
            fridayBuyPricesControl.SetPrices(stalkMarket.Friday.MorningPrice, stalkMarket.Friday.EveningPrice);
            saturdayBuyPricesControl.SetPrices(stalkMarket.Saturday.MorningPrice, stalkMarket.Saturday.EveningPrice);
        }

        private void SetChartData(StalkMarket stalkMarket)
        {
            StalkMarketSeries.Points.Clear();
            AddXYToChart("Monday", stalkMarket.Monday.MorningPrice);
            AddXYToChart("Monday", stalkMarket.Monday.EveningPrice);
            AddXYToChart("Tuesday", stalkMarket.Tuesday.MorningPrice);
            AddXYToChart("Tuesday", stalkMarket.Tuesday.EveningPrice);
            AddXYToChart("Wednesday", stalkMarket.Wednesday.MorningPrice);
            AddXYToChart("Wednesday", stalkMarket.Wednesday.EveningPrice);
            AddXYToChart("Thursday", stalkMarket.Thursday.MorningPrice);
            AddXYToChart("Thursday", stalkMarket.Thursday.EveningPrice);
            AddXYToChart("Friday", stalkMarket.Friday.MorningPrice);
            AddXYToChart("Friday", stalkMarket.Friday.EveningPrice);
            AddXYToChart("Saturday", stalkMarket.Saturday.MorningPrice);
            AddXYToChart("Saturday", stalkMarket.Saturday.EveningPrice);
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
    }
}
