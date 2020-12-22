/// author: Stefan Tölle
/// Date: 21.12.2020

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using Gpx;

namespace StraightLineMission
{
    /// <summary>
    /// Main Form of the straight line mission calculator application
    /// </summary>
    public partial class MainForm : Form
    {
        private static String COORDFORMAT = ">L| 990.00000"; // decimal gps coordinate format

        private Logic logic;

        public MainForm(Logic logic)
        {
            InitializeComponent();

            // specify format of the text boxes
            maskedTextBoxStartCoord1.Mask = COORDFORMAT;
            maskedTextBoxStartCoord2.Mask = COORDFORMAT;
            maskedTextBoxEndCoord1.Mask = COORDFORMAT;
            maskedTextBoxEndCoord2.Mask = COORDFORMAT;

            this.Height = 520;
            this.Width = 940;

            this.logic = logic;
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = this.openFileDialog.ShowDialog(); // open windows file dialog
            if (result == DialogResult.OK)
                this.textBoxDirectory.Text = this.openFileDialog.FileName;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            // try to parse user given coordinates...
            string startingCoords = maskedTextBoxStartCoord1.Text + " " + maskedTextBoxStartCoord2.Text;
            string endCoords = maskedTextBoxEndCoord1.Text + " " + maskedTextBoxEndCoord2.Text;
            try
            {
                logic.startingPoint = Gps.GpsLocation.Parse(startingCoords);
                logic.endPoint = Gps.GpsLocation.Parse(endCoords);
            }
            catch (FormatException ex)  // user given coordinates were invalid
            {
                toolTipCoords.Show("Please check the starting/end coordinates", buttonCalculate, 130, 0, 5000);
                return;
            }

            // ... start/end coordinates correct
            // try to parse gpx file
            try
            {
                using (FileStream stream = File.Open(textBoxDirectory.Text, FileMode.Open))
                {
                    try
                    {
                        logic.gpxData = GpxParser.parseGpx(stream);
                    }
                    catch
                    {
                        toolTipCoords.Show("Couldn't read .gpx file", buttonCalculate, 130, 0, 5000);
                    }
                }

                CalculationResult result = logic.calculate();
                displayResult(result);
            }
            catch (System.Security.SecurityException sEx)
            {
                toolTipDirectory.Show("I have no permission to read this file", buttonCalculate, 130, 0, 5000);
            }/*
            catch (Exception ex)
            {
                toolTipDirectory.Show("Please check the the directory", buttonCalculate, 130, 0, 5000);
            }*/
        }

        // displays the result for the user
        private void displayResult(CalculationResult result)
        {
            labelAreaResult.Text = String.Format("{0:0,0} m²", (int)result.area);
            labelAreaNormResult.Text = String.Format("{0:0,0.00} m", result.areaNorm);
            labelMSEResult.Text = String.Format("{0:0,0.00} m²", result.awgSquareDeviation);
            labelMaxDeviationResult.Text = String.Format("{0:0,0.00} m", result.maxDeviation);
            labelOver10Result.Text = String.Format("{0:00.0000}% on {1} individual occurrences", result.over10 * 100, result.numOver10);
            labelOver25Result.Text = String.Format("{0:00.0000}% on {1} individual occurrences", result.over25 * 100, result.numOver25);
            labelOver50Result.Text = String.Format("{0:00.0000}% on {1} individual occurrences", result.over50 * 100, result.numOver50);
            labelOver80Result.Text = String.Format("{0:00.0000}% on {1} individual occurrences", result.over80 * 100, result.numOver80);
            labelOver120Result.Text = String.Format("{0:00.0000}% on {1} individual occurrences", result.over120 * 100, result.numOver120);

            // configure histogram
            chartHistogram.Series.Clear();
            chartHistogram.Series.Add(result.histogramData);
            chartHistogram.Series[0]["PointWidth"] = "1";
            chartHistogram.Series[0].ChartType = SeriesChartType.Column;
            chartHistogram.ChartAreas[0].AxisX.Minimum = -50; // configures x axis
            chartHistogram.ChartAreas[0].AxisX.Maximum = 50;
            chartHistogram.ChartAreas[0].AxisY.Maximum = 1.1*result.histogramData.Points.FindMaxByValue("Y1").YValues[0]; // configures y axis
            chartHistogram.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartHistogram.Series[0].BorderWidth = 0;
            // Vertical line
            Series zeroSeries = new Series();
            chartHistogram.Series.Add(zeroSeries);
            chartHistogram.Series[1].ChartType = SeriesChartType.Line;
            chartHistogram.Series[1].Points.AddXY(Single.Epsilon, 0);
            chartHistogram.Series[1].Points.AddXY(Single.Epsilon, 100);
            chartHistogram.Series[1].Color = Color.Black;
            chartHistogram.Series[1].BorderDashStyle = ChartDashStyle.Dash;
            // set labels
            chartHistogram.ChartAreas[0].AxisX.Title = "deviation [m]";
            chartHistogram.ChartAreas[0].AxisY.Title = "frequency [%]";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            chartHistogram.ChartAreas[0].AxisX.Minimum =
                System.Math.Min(-10, chartHistogram.ChartAreas[0].AxisX.Minimum + 10);
            chartHistogram.ChartAreas[0].AxisX.Maximum =
                System.Math.Max(10, chartHistogram.ChartAreas[0].AxisX.Maximum - 10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chartHistogram.ChartAreas[0].AxisX.Minimum =
                System.Math.Max(-200, chartHistogram.ChartAreas[0].AxisX.Minimum - 10);
            chartHistogram.ChartAreas[0].AxisX.Maximum =
                System.Math.Min(200, chartHistogram.ChartAreas[0].AxisX.Maximum + 10);
        }
    }
}
