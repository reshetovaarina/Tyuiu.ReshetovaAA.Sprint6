using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ReshetovaAA.Sprint6.Task0.V4.Lib;

namespace Tyuiu.ReshetovaAA.Sprint6.Task0.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int x = 3;
            double res = ds.Calculate(x);
            double wait = 68.3;
            Assert.AreEqual(wait, res);
        }
    }
}