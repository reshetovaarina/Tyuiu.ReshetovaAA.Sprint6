using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;
using System.IO;
using Tyuiu.ReshetovaAA.Sprint6.Task5.V1.Lib;

namespace Tyuiu.ReshetovaAA.Sprint6.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFile_ReturnsOnlyPositive_RoundedTo3()
        {
            string tempPath = Path.Combine(Path.GetTempPath(), "Task5V1_test.txt");

            File.WriteAllLines(tempPath, new[]
            {
                "-1",
                "0",
                "2.34567",
                "3,33333",
                "10",
                "-5,5"
            });

            var ds = new DataService();

            double[] res = ds.LoadFromDataFile(tempPath);

            Assert.AreEqual(3, res.Length);
            Assert.AreEqual(2.346, res[0], 0.0001);
            Assert.AreEqual(3.333, res[1], 0.0001);
            Assert.AreEqual(10.000, res[2], 0.0001);
        }
    }
}