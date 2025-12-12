using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ReshetovaAA.Sprint6.Task1.V8.Lib
{
    public class DataService : ISprint6Task1V8
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] valueArray = new double[len];

            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double denom = x - 0.4;

                if (Math.Abs(denom) < 1e-9)
                {
                    valueArray[count] = 0;
                }
                else
                {
                    double fx = (Math.Cos(x) / denom) + (Math.Sin(x) * 8 * x) + 2;
                    valueArray[count] = Math.Round(fx, 2);
                }

                count++;
            }

            return valueArray;
        }
    }
}