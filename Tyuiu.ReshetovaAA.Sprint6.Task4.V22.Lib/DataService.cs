using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ReshetovaAA.Sprint6.Task4.V22.Lib
{
    public class DataService : ISprint6Task4V22
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] result = new double[len];

            int index = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double y;

                y = Math.Sin(x) + Math.Cos(2 * x) / 2 - 1.5 * x;

                result[index] = Math.Round(y, 2);
                index++;
            }

            return result;
        }
    }
}