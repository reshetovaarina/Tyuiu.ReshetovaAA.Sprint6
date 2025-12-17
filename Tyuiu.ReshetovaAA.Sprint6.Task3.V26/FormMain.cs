using System;
using System.Windows.Forms;
using Tyuiu.ReshetovaAA.Sprint6.Task3.V26.Lib;

namespace Tyuiu.ReshetovaAA.Sprint6.Task3.V26
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();

        int[,] matrix =
        {
            { 16, 19, 17,  2,  8 },
            { -17, 8, -17, -8, 1 },
            { -7, 17, -2, 1, -3 },
            { -12, 0, -17, 15, 6 },
            { 17, -6, -17, 18, -19 }
        };

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            FillGrid(matrix);
        }

        private void FillGrid(int[,] arr)
        {
            int rows = arr.GetUpperBound(0) + 1;
            int columns = arr.GetUpperBound(1) + 1;

            dataGridViewMatrix.ColumnCount = columns;
            dataGridViewMatrix.RowCount = rows;

            for (int i = 0; i < columns; i++)
                dataGridViewMatrix.Columns[i].Width = 35;

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    dataGridViewMatrix.Rows[i].Cells[j].Value = arr[i, j];
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            matrix = ds.ChangeArray(matrix);
            FillGrid(matrix);
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Таск 3 выполнила студентка группы АААБ-23-1 Решетова Арина",
                "Справка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}