﻿using System.IO;
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
        private ResourceManager ResourceManager { get; }

        private SaveGameService SaveGameService { get; }

        public MainForm()
        {
            InitializeComponent();
            mondayBuyPricesControl.SetTitle("Monday");
            tuesdayBuyPricesControl.SetTitle("Tuesday");
            wednesdayBuyPricesControl.SetTitle("Wednesday");
            thursdayBuyPricesControl.SetTitle("Thursday");
            fridayBuyPricesControl.SetTitle("Friday");
            saturdayBuyPricesControl.SetTitle("Saturday");

            ResourceManager = new ResourceManager(typeof(MainForm));
            SaveGameService = new SaveGameService();
        }

        private void openSaveButton_Click(object sender, System.EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = ResourceManager.GetString("acnh_save_file");
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (SaveGameService.OpenSaveFromFolder(Path.GetDirectoryName(openFileDialog.FileName), out StalkMarket? stalkMarket) && stalkMarket != null)
                    {
                        var stalkMarketValue = stalkMarket.Value;
                        sellPriceTextBox.Text = stalkMarketValue.BuyPrice.ToString();
                        mondayBuyPricesControl.SetPrices(stalkMarketValue.Monday.MorningPrice, stalkMarketValue.Monday.EveningPrice);
                        tuesdayBuyPricesControl.SetPrices(stalkMarketValue.Tuesday.MorningPrice, stalkMarketValue.Tuesday.EveningPrice);
                        wednesdayBuyPricesControl.SetPrices(stalkMarketValue.Wednesday.MorningPrice, stalkMarketValue.Wednesday.EveningPrice);
                        thursdayBuyPricesControl.SetPrices(stalkMarketValue.Thursday.MorningPrice, stalkMarketValue.Thursday.EveningPrice);
                        fridayBuyPricesControl.SetPrices(stalkMarketValue.Friday.MorningPrice, stalkMarketValue.Friday.EveningPrice);
                        saturdayBuyPricesControl.SetPrices(stalkMarketValue.Saturday.MorningPrice, stalkMarketValue.Saturday.EveningPrice);

                        stalkMarketChart.Series["stalkMarketSeries"].Points.Clear();
                        stalkMarketChart.Series["stalkMarketSeries"].Points.AddXY("Monday", stalkMarketValue.Monday.MorningPrice);
                        stalkMarketChart.Series["stalkMarketSeries"].Points.AddXY("Monday", stalkMarketValue.Monday.EveningPrice);
                        stalkMarketChart.Series["stalkMarketSeries"].Points.AddXY("Tuesday", stalkMarketValue.Tuesday.MorningPrice);
                        stalkMarketChart.Series["stalkMarketSeries"].Points.AddXY("Tuesday", stalkMarketValue.Tuesday.EveningPrice);
                        stalkMarketChart.Series["stalkMarketSeries"].Points.AddXY("Wednesday", stalkMarketValue.Wednesday.MorningPrice);
                        stalkMarketChart.Series["stalkMarketSeries"].Points.AddXY("Wednesday", stalkMarketValue.Wednesday.EveningPrice);
                        stalkMarketChart.Series["stalkMarketSeries"].Points.AddXY("Thursday", stalkMarketValue.Thursday.MorningPrice);
                        stalkMarketChart.Series["stalkMarketSeries"].Points.AddXY("Thursday", stalkMarketValue.Thursday.EveningPrice);
                        stalkMarketChart.Series["stalkMarketSeries"].Points.AddXY("Friday", stalkMarketValue.Friday.MorningPrice);
                        stalkMarketChart.Series["stalkMarketSeries"].Points.AddXY("Friday", stalkMarketValue.Friday.EveningPrice);
                        stalkMarketChart.Series["stalkMarketSeries"].Points.AddXY("Saturday", stalkMarketValue.Saturday.MorningPrice);
                        stalkMarketChart.Series["stalkMarketSeries"].Points.AddXY("Saturday", stalkMarketValue.Saturday.EveningPrice);
                    }
                    else
                    {
                        MessageBox.Show(Resources.couldnt_parse_the_save_file, Resources.application_name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
