using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ACNH_Turnips_Fortuneteller.Properties;
using ACNH_Turnips_Fortuneteller.Services;
using NHSE.Core;
using NLog;

namespace ACNH_Turnips_Fortuneteller.UI
{
    public partial class MainForm : Form
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        private SaveGameService SaveGameService { get; }

        private Series StalkMarketSeries;

        public MainForm()
        {
            InitializeComponent();
            Text += $" v{Application.ProductVersion}";

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
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    OpenSaveFile(openFileDialog.FileName);
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

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data != null)
            {
                var files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length > 0)
                {
                    OpenSaveFile(files[0]);
                }
            }
        }

        private void OpenSaveFile(string filePath)
        {
            if (SaveGameService.OpenSaveFromFolder(Path.GetDirectoryName(filePath), out MainSave mainSave) && mainSave != null)
            {
                saveTimeValueLabel.Text = mainSave.LastSaved.TimeStamp;
                SetPrices(mainSave.Turnips);
                SetChartData(mainSave.Turnips);
                SetVisitors(mainSave.Visitor);
            }
            else
            {
                MessageBox.Show(Resources.couldnt_parse_the_save_file, Resources.application_name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetVisitors(GSaveVisitorNpc gSaveVisitorNpc)
        {
            visitorsDataGridView.Rows.Clear();
            visitorsDataGridView.Rows.Add(Resources.monday, gSaveVisitorNpc.VisitorNPC[1].ToString());
            visitorsDataGridView.Rows.Add(Resources.tuesday, gSaveVisitorNpc.VisitorNPC[2].ToString());
            visitorsDataGridView.Rows.Add(Resources.wednesday, gSaveVisitorNpc.VisitorNPC[3].ToString());
            visitorsDataGridView.Rows.Add(Resources.thursday, gSaveVisitorNpc.VisitorNPC[4].ToString());
            visitorsDataGridView.Rows.Add(Resources.friday, gSaveVisitorNpc.VisitorNPC[5].ToString());
            visitorsDataGridView.Rows.Add(Resources.saturday, gSaveVisitorNpc.VisitorNPC[6].ToString());
            visitorsDataGridView.Rows.Add(Resources.sunday, gSaveVisitorNpc.VisitorNPC[0].ToString());

            if (gSaveVisitorNpc.DayCeleste > 0 && gSaveVisitorNpc.DayCeleste <= 7)
            {
                visitorsDataGridView.Rows[gSaveVisitorNpc.DayCeleste - 1].Cells[2].Value = Resources.celeste;
            }
            if (gSaveVisitorNpc.DayWisp > 0 && gSaveVisitorNpc.DayWisp <= 7)
            {
                var cellIndex = 2;
                if (!string.IsNullOrEmpty((string)visitorsDataGridView.Rows[gSaveVisitorNpc.DayWisp - 1].Cells[cellIndex].Value))
                {
                    cellIndex = 3;
                }
                visitorsDataGridView.Rows[gSaveVisitorNpc.DayWisp - 1].Cells[cellIndex].Value = Resources.wisp;
            }

            for (var i = 0; i < visitorsDataGridView.Rows.Count; i++)
            {
                visitorsDataGridView.Rows[i].Cells[1].Value = ((string)visitorsDataGridView.Rows[i].Cells[1].Value).Replace(VisitorNPC.None.ToString(), "");
            }
            visitorsDataGridView.Refresh();
        }

        private void visitorsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            var dataGridView = (DataGridView) sender;
            var primaryVisitor = (string)dataGridView.CurrentRow.Cells[1].Value;
            var secondaryVisitor = (string)dataGridView.CurrentRow.Cells[2].Value;
            var tertiaryVisitor = (string)dataGridView.CurrentRow.Cells[3].Value;
            SetVisitorPicture(primaryVisitorPicture, primaryVisitor);
            SetVisitorPicture(secodanryVisitorPicture, secondaryVisitor);
            SetVisitorPicture(tertiaryVisitorPicture, tertiaryVisitor);
        }

        private void SetVisitorPicture(PictureBox pictureBox, string visitorName)
        {
            if (!string.IsNullOrEmpty(visitorName) && visitorName != VisitorNPC.None.ToString())
            {
                pictureBox.Image = (Image)Resources.ResourceManager.GetObject($"{visitorName}_Image");
            }
            else
            {
                pictureBox.Image = null;
            }

            pictureBox.Refresh();
        }
    }
}
