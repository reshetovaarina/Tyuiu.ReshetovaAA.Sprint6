using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Tyuiu.ReshetovaAA.Sprint6.Task4.V22.Lib;

namespace Tyuiu.ReshetovaAA.Sprint6.Task4.V22
{
    public partial class FormMain : Form
    {
        private readonly DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
            textBoxStartStep.Text = "-5";
            textBoxStopStep.Text = "5";
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep.Text);

                double[] values = ds.GetMassFunction(startStep, stopStep);

                // очистка вывода
                textBoxResult.Clear();
                chartFunction.Series[0].Points.Clear();

                // подписи осей (как в лекции)
                chartFunction.ChartAreas[0].AxisX.Title = "X";
                chartFunction.ChartAreas[0].AxisY.Title = "F(x)";

                int x = startStep;
                for (int i = 0; i < values.Length; i++)
                {
                    // вывод в textbox
                    textBoxResult.AppendText($"x = {x}\tF(x) = {values[i]}{Environment.NewLine}");

                    // точки на график
                    chartFunction.Series[0].Points.AddXY(x, values[i]);

                    x++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(Directory.GetCurrentDirectory(), "OutPutFileTask4V22.txt");
                File.WriteAllText(path, textBoxResult.Text);

                DialogResult dialogResult = MessageBox.Show(
                    "Файл:\n" + path + "\n\nСохранен успешно!\nОткрыть файл?",
                    "Сообщение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    Process.Start(new ProcessStartInfo("notepad.exe", path) { UseShellExecute = true });
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Таск 4 выполнила студентка группы ААА6-23-1 Решетова Арина (RAA)\n" +
                "F(x) = sin(x) + cos(2x)/2 - 1.5x\n" +
                "Диапазон: [-5; 5], шаг 1, округление до 2 знаков.",
                "Справка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}