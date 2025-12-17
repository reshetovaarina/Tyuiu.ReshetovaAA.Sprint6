using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ReshetovaAA.Sprint6.Task3.V26.Lib
{
    public class DataService : ISprint6Task3V26
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.GetUpperBound(1) + 1;

            int rowIndex = 2;

            for (int j = 0; j < columns; j++)
            {
                if (matrix[rowIndex, j] % 2 == 0)
                {
                    matrix[rowIndex, j] = 0;
                }
            }

            return matrix;
        }
    }
}