using System;
using System.Windows.Forms;
using Tyuiu.ReshetovaAA.Sprint6.Task0.V4.Lib;

namespace Tyuiu.ReshetovaAA.Sprint6.Task0.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonCalc_RAA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();

            try
            {
                int x = Convert.ToInt32(textBoxVarX_RAA.Text);
                textBoxResult_RAA.Text = Convert.ToString(ds.Calculate(x));
            }
            catch
            {
                MessageBox.Show("¬ведены неверные данные!", "ќшибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxVarX_RAA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_RAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task 0 выполнила студентка группы —ћј–“б-25-1 –ешетова јрина",
                "—ообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}