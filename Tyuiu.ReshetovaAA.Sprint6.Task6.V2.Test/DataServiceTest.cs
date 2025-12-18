using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ReshetovaAA.Sprint6.Task6.V2.Lib;

namespace Tyuiu.ReshetovaAA.Sprint6.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CollectTextFromFile_ReturnsSecondWords()
        {
            DataService ds = new DataService();

            string temp = Path.Combine(Path.GetTempPath(), "InPutFileTask6V2_test.txt");
            File.WriteAllText(temp,
                "one two three\n" +
                "aa bb\n" +
                "x\n" +
                "hello world !!!\n");

            string res = ds.CollectTextFromFile(temp);

            // вторые слова: two, bb, world
            Assert.AreEqual("two bb world", res);

            File.Delete(temp);
        }
    }
}