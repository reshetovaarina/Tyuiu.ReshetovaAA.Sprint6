using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.ReshetovaAA.Sprint6.Task2.V7.Lib;

namespace Tyuiu.ReshetovaAA.Sprint6.Task2.V7
{
    public partial class FormMain : Form
    {
        private DataService ds = new DataService();
        private Chart chartFunction_RAA;

        public FormMain()
        {
            InitializeComponent();
            InitChart();
        }

        private void InitChart()
        {
            chartFunction_RAA = new Chart();
            chartFunction_RAA.Dock = DockStyle.Fill;

            ChartArea area = new ChartArea("MainArea");
            area.AxisX.Title = "X";
            area.AxisY.Title = "F(x)";
            chartFunction_RAA.ChartAreas.Add(area);

            Legend legend = new Legend("MainLegend");
            chartFunction_RAA.Legends.Add(legend);

            Series s = new Series("F(x)");
            s.ChartType = SeriesChartType.Spline;
            s.ChartArea = "MainArea";
            s.Legend = "MainLegend";
            chartFunction_RAA.Series.Add(s);

            chartFunction_RAA.Titles.Clear();
            chartFunction_RAA.Titles.Add("График функции F(x)");

            panelChart_RAA.Controls.Clear();
            panelChart_RAA.Controls.Add(chartFunction_RAA);
        }

        private void buttonDone_RAA_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStartStep_RAA.Text);
                int stop = Convert.ToInt32(textBoxStopStep_RAA.Text);

                dataGridViewFunction_RAA.Rows.Clear();
                chartFunction_RAA.Series["F(x)"].Points.Clear();

                double[] y = ds.GetMassFunction(start, stop);

                int x = start;
                for (int i = 0; i < y.Length; i++)
                {
                    dataGridViewFunction_RAA.Rows.Add(x, y[i].ToString("F2"));
                    chartFunction_RAA.Series["F(x)"].Points.AddXY(x, y[i]);
                    x++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_RAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Спринт 6 | Таск 2 | Вариант 7\nРешетова Арина (RAA) | СМАРТб-25-1",
                "Справка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void buttonDone_RAA_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_RAA.BackColor = Color.Red;
        }

        private void buttonDone_RAA_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_RAA.BackColor = Color.LightGreen;
        }

        private void buttonDone_RAA_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_RAA.BackColor = Color.LightBlue;
        }
    }
}