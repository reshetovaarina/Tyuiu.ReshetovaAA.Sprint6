using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.ReshetovaAA.Sprint6.Task7.V23.Lib;

namespace Tyuiu.ReshetovaAA.Sprint6.Task7.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix_LastColumnLessThan2_SetTo2()
        {
            string path = "InPutFileTask7V23_test.csv";

            File.WriteAllText(path,
                "5;1;0\r\n" +
                "9;3;1\r\n" +
                "7;8;2\r\n" +
                "-1;4;-5\r\n");

            DataService ds = new DataService();
            int[,] res = ds.GetMatrix(path);

            // последний столбец: 0->2, 1->2, 2 stays, -5->2
            Assert.AreEqual(2, res[0, 2]);
            Assert.AreEqual(2, res[1, 2]);
            Assert.AreEqual(2, res[2, 2]);
            Assert.AreEqual(2, res[3, 2]);

            File.Delete(path);
        }
    }
}
