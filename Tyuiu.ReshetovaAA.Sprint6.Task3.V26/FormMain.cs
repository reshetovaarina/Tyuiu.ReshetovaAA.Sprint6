using System;
using System.IO;
using System.Windows.Forms;
using Tyuiu.ReshetovaAA.Sprint6.Task7.V23.Lib;

namespace Tyuiu.ReshetovaAA.Sprint6.Task7.V23
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();

        string openFilePath = string.Empty;

        int[,] inputMatrix;
        int[,] resultMatrix;

        public FormMain()
        {
            InitializeComponent();
        }


        private static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');

            string[] lines = fileData.Split(
                new char[] { '\r' },
                StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int cols = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, cols];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < cols; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }

            return arrayValues;
        }

        private static void FillGrid(DataGridView grid, int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            grid.RowCount = rows;
            grid.ColumnCount = cols;

            for (int i = 0; i < cols; i++)
            {
                grid.Columns[i].Width = 40;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    grid.Rows[r].Cells[c].Value = matrix[r, c];
                }
            }
        }


        private void buttonOpen_RAA_Click(object sender, EventArgs e)
        {
            if (openFileDialogTask.ShowDialog() == DialogResult.OK)
            {
                openFilePath = openFileDialogTask.FileName;

                inputMatrix = LoadFromFileData(openFilePath);
                FillGrid(dataGridViewInMatrix_RAA, inputMatrix);

                buttonDone_RAA.Enabled = true;
                buttonSaveFile_RAA.Enabled = false;

                dataGridViewOutMatrix_RAA.Rows.Clear();
                dataGridViewOutMatrix_RAA.Columns.Clear();
            }
        }

        private void buttonDone_RAA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(openFilePath))
            {
                MessageBox.Show("Сначала загрузите файл.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            resultMatrix = ds.GetMatrix(openFilePath);

            FillGrid(dataGridViewOutMatrix_RAA, resultMatrix);

            buttonSaveFile_RAA.Enabled = true;
        }

        private void buttonSaveFile_RAA_Click(object sender, EventArgs e)
        {
            if (resultMatrix == null)
            {
                MessageBox.Show("Нет данных для сохранения.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            saveFileDialogMatrix.FileName = "OutPutFileTask7V23.csv";
            saveFileDialogMatrix.InitialDirectory = Directory.GetCurrentDirectory();

            if (saveFileDialogMatrix.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialogMatrix.FileName;

                int rows = resultMatrix.GetLength(0);
                int cols = resultMatrix.GetLength(1);

                using (StreamWriter sw = new StreamWriter(path, false))
                {
                    for (int r = 0; r < rows; r++)
                    {
                        string[] parts = new string[cols];
                        for (int c = 0; c < cols; c++)
                        {
                            parts[c] = resultMatrix[r, c].ToString();
                        }

                        string line = string.Join(";", parts);
                        sw.WriteLine(line);
                    }
                }

                MessageBox.Show("Файл успешно сохранён.", "Сохранение",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonHelp_RAA_Click(object sender, EventArgs e)
        {
            FormAbout_RAA about = new FormAbout_RAA();
            about.ShowDialog();
        }
    }
}
