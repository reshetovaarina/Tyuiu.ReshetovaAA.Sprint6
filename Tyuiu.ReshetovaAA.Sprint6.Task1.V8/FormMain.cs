using System;
using System.Windows.Forms;
using Tyuiu.ReshetovaAA.Sprint6.Task1.V8.Lib;

namespace Tyuiu.ReshetovaAA.Sprint6.Task1.V8
{
    public partial class FormMain : Form
    {
        private DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonCalc_RAA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_RAA.Text);
                int stopStep = Convert.ToInt32(textBoxStop_RAA.Text);

                double[] valueArray = ds.GetMassFunction(startStep, stopStep);

                textBoxResult_RAA.Text = "";
                textBoxResult_RAA.AppendText("+-----+----------+" + Environment.NewLine);
                textBoxResult_RAA.AppendText("|  X  |   f(x)   |" + Environment.NewLine);
                textBoxResult_RAA.AppendText("+-----+----------+" + Environment.NewLine);

                for (int i = 0; i < valueArray.Length; i++)
                {
                    string strLine = String.Format("|{0,5:d}|{1,10:f2}|", startStep, valueArray[i]);
                    textBoxResult_RAA.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_RAA.AppendText("+-----+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_RAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы СМАРТб-25-1 Решетова Арина",
                "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxStart_RAA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void textBoxStop_RAA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }
    }
}