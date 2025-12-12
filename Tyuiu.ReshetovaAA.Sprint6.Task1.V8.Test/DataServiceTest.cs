using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ReshetovaAA.Sprint6.Task1.V8.Lib;

namespace Tyuiu.ReshetovaAA.Sprint6.Task1.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(-5, 5);

            double[] wait = new double[]
            {
                -36.41, -22.07, 5.68, 16.72, 8.35, -0.50, 9.63, 16.29, 5.01, -22.40, -36.30
            };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}