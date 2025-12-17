using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ReshetovaAA.Sprint6.Task2.V7.Lib
{
    public class DataService : ISprint6Task2V7
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] valueArray = new double[len];

            int idx = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double denom = Math.Cos(x) + 1;
                double fx;

                if (Math.Abs(denom) < 1e-7)
                {
                    fx = 0;
                }
                else
                {
                    fx = 3 * x + 2 - (x / denom);
                }

                valueArray[idx] = Math.Round(fx, 2);
                idx++;
            }

            return valueArray;
        }
    }
}