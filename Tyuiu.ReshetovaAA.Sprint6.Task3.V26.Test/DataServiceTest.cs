using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ReshetovaAA.Sprint6.Task3.V26.Lib;

namespace Tyuiu.ReshetovaAA.Sprint6.Task3.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix =
            {
                {1,2,3,4,5},
                {6,7,8,9,10},
                {2,4,6,8,10},
                {1,1,1,1,1},
                {3,3,3,3,3}
            };

            var res = ds.Calculate(matrix);

            Assert.AreEqual(0, res[2, 0]);
            Assert.AreEqual(0, res[2, 1]);
        }
    }
}
