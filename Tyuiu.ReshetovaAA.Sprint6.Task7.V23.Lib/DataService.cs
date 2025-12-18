using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ReshetovaAA.Sprint6.Task7.V23.Lib
{
    public class DataService : ISprint6Task7V23
    {
        public int[,] GetMatrix(string path)
        {
            // читаем файл целиком
            string fileData = File.ReadAllText(path);

            // делим на строки (как у препода)
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int cols = lines[0].Split(';').Length;

            int[,] matrix = new int[rows, cols];

            // заполнить матрицу из csv
            for (int r = 0; r < rows; r++)
            {
                string[] line = lines[r].Split(';');
                for (int c = 0; c < cols; c++)
                {
                    matrix[r, c] = Convert.ToInt32(line[c]);
                }
            }

            // в последнем столбце все значения < 2 заменить на 2
            int lastCol = cols - 1;
            for (int r = 0; r < rows; r++)
            {
                if (matrix[r, lastCol] < 2)
                {
                    matrix[r, lastCol] = 2;
                }
            }

            return matrix;
        }
    }
}