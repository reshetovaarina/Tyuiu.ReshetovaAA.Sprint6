using System;
using System.IO;
using System.Windows.Forms;

using Tyuiu.ReshetovaAA.Sprint6.Task7.V23.Lib;

namespace Tyuiu.ReshetovaAA.Sprint6.Task7.V23
{
    public partial class FormMain : Form
    {
        static int rows;
        static int colums;
        static string openFilePath;

        DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask.Filter = "Значения, разделённые запятыми (*.csv)|*.csv|Все файлы (*.*)|*.*";
            saveFileDialogMatrix.Filter = "Значения, разделённые запятыми (*.csv)|*.csv|Все файлы (*.*)|*.*";

            buttonDone_RAA.Enabled = false;
            buttonSaveFile_RAA.Enabled = false;
        }

        // Читаем матрицу из CSV (для вывода "Ввод")
        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            colums = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, colums];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < colums; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }

            return arrayValues;
        }

        // Сохраняем матрицу в CSV
        public static void SaveToFileTextData(string path, int[,] matrix)
        {
            int rCount = matrix.GetUpperBound(0) + 1;
            int cCount = matrix.Length / rCount;

            string str = "";

            for (int r = 0; r < rCount; r++)
            {
                for (int c = 0; c < cCount; c++)
                {
                    if (c != cCount - 1) str += matrix[r, c] + ";";
                    else str += matrix[r, c];
                }
                str += Environment.NewLine;
            }

            File.WriteAllText(path, str);
        }

        private void buttonOpenFile_RAA_Click(object sender, EventArgs e)
        {
            openFileDialogTask.FileName = "InPutFileTask7V23.csv";
            openFileDialogTask.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialogTask.ShowDialog();

            openFilePath = openFileDialogTask.FileName;

            int[,] arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInMatrix_RAA.ColumnCount = colums;
            dataGridViewInMatrix_RAA.RowCount = rows;

            dataGridViewOutMatrix_RAA.ColumnCount = colums;
            dataGridViewOutMatrix_RAA.RowCount = rows;

            // ширина столбцов, чтобы табличка была компактной как у препода
            for (int i = 0; i < colums; i++)
            {
                dataGridViewInMatrix_RAA.Columns[i].Width = 25;
                dataGridViewOutMatrix_RAA.Columns[i].Width = 25;
            }

            // заполняем "Ввод"
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewInMatrix_RAA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            // очищаем "Вывод"
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewOutMatrix_RAA.Rows[r].Cells[c].Value = "";
                }
            }

            buttonDone_RAA.Enabled = true;
            buttonSaveFile_RAA.Enabled = false;
        }

        private void buttonDone_RAA_Click(object sender, EventArgs e)
        {
            int[,] result = ds.GetMatrix(openFilePath);

            rows = result.GetUpperBound(0) + 1;
            colums = result.Length / rows;

            dataGridViewOutMatrix_RAA.ColumnCount = colums;
            dataGridViewOutMatrix_RAA.RowCount = rows; for (int i = 0; i < colums; i++)
            {
                dataGridViewOutMatrix_RAA.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewOutMatrix_RAA.Rows[r].Cells[c].Value = result[r, c];
                }
            }

            buttonSaveFile_RAA.Enabled = true;
        }

        private void buttonSaveFile_RAA_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix.FileName = "OutPutFileTask7V23.csv";
            saveFileDialogMatrix.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix.ShowDialog();

            string path = saveFileDialogMatrix.FileName;

            int[,] result = new int[rows, colums];
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    result[r, c] = Convert.ToInt32(dataGridViewOutMatrix_RAA.Rows[r].Cells[c].Value);
                }
            }

            SaveToFileTextData(path, result);
        }

        private void buttonHelp_RAA_Click(object sender, EventArgs e)
        {
            FormAbout_RAA about = new FormAbout_RAA();
            about.ShowDialog();
        }
    }
}