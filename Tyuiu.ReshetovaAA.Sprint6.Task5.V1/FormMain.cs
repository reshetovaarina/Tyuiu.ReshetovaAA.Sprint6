using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Tyuiu.ReshetovaAA.Sprint6.Task5.V1.Lib;

namespace Tyuiu.ReshetovaAA.Sprint6.Task5.V1
{
    public partial class FormMain : Form
    {
        private readonly DataService ds = new DataService();
        private readonly string path;

        public FormMain()
        {
            InitializeComponent();
            path = @"C:\DataSprint5\InPutDataFileTask5V1.txt";
            textBoxPath.Text = path;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewNums.Rows.Clear();
                chartDiag.Series[0].Points.Clear();

                double[] res = ds.LoadFromDataFile(path);

                for (int i = 0; i < res.Length; i++)
                {
                    dataGridViewNums.Rows.Add(i, res[i].ToString("F3"));
                    chartDiag.Series[0].Points.AddXY(i, res[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string outPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "OutPutFileTask5V1.txt");

                using (StreamWriter sw = new StreamWriter(outPath, false))
                {
                    for (int i = 0; i < dataGridViewNums.Rows.Count; i++)
                    {
                        if (dataGridViewNums.Rows[i].Cells[1].Value != null)
                            sw.WriteLine(dataGridViewNums.Rows[i].Cells[1].Value.ToString());
                    }
                }

                DialogResult dr = MessageBox.Show(
                    "Файл сохранён:\n" + outPath + "\n\nОткрыть файл?",
                    "Сохранение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    Process.Start(new ProcessStartInfo("notepad.exe", outPath) { UseShellExecute = true });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(path))
                {
                    MessageBox.Show("В папке запуска нет InPutFileTask5V1.txt.\n" +
                                    "Положи файл в bin\\Debug\\net8.0-windows и поставь Copy to Output Directory.",
                                    "Файл не найден",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                Process.Start(new ProcessStartInfo("notepad.exe", path) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Task 5 (Sprint 6) выполнила: Решетова Арина Андреевна (RAA)\n" +
                "Вариант 1\n" +
                "Файл: InPutFileTask5V1.txt",
                "Справка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}