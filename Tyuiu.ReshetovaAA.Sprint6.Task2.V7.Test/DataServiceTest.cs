using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ReshetovaAA.Sprint6.Task2.V7.Lib;

namespace Tyuiu.ReshetovaAA.Sprint6.Task2.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(-5, 5);

            Assert.AreEqual(11, res.Length);
            Assert.AreEqual(2.00, res[5], 0.01);
        }
    }
}