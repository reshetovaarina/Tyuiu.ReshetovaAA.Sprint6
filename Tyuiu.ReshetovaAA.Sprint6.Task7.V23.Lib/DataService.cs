using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ReshetovaAA.Sprint6.Task7.V23.Lib
{
    public class DataService : ISprint6Task7V23
    {
        public int[,] GetMatrix(string path)
        {
            string fileData = File.ReadAllText(path);

            fileData = fileData.Replace('\n', '\r');

            string[] lines = fileData.Split(
                new char[] { '\r' },
                StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int cols = lines[0].Split(';').Length;

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] temp = lines[i].Split(';');

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = Convert.ToInt32(temp[j]);
                }
            }

            int lastCol = cols - 1;

            for (int i = 0; i < rows; i++)
            {
                if (matrix[i, lastCol] < 2)
                {
                    matrix[i, lastCol] = 2;
                }
            }

            return matrix;
        }
    }
}
