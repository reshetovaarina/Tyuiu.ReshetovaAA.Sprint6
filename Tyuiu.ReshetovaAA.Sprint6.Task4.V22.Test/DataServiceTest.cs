using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ReshetovaAA.Sprint6.Task4.V22.Lib;

namespace Tyuiu.ReshetovaAA.Sprint6.Task4.V22.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetMassFunction_ReturnsCorrectLength()
        {
            DataService ds = new DataService();

            double[] res = ds.GetMassFunction(-5, 5);

            Assert.AreEqual(11, res.Length);
        }

        [TestMethod]
        public void GetMassFunction_CheckSomeValues()
        {
            DataService ds = new DataService();

            double[] res = ds.GetMassFunction(-5, 5);

            Assert.AreEqual(11, res.Length);

            Assert.AreEqual(8.04, res[0], 0.01);  
            Assert.AreEqual(0.50, res[5], 0.01); 
            Assert.AreEqual(-8.88, res[10], 0.01); 
        }
    }
}