using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PimenovaTS.Sprint4.Task7.V13.Lib;

namespace Tyuiu.PimenovaTS.Sprint4.Task7.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            int kols = 3;
            int kolst = 3;
            int[,] zombi = new int[kols, kolst];
            string buk = "159357246";
            DataService ds = new DataService();
            int res = ds.Calculate(kols, kolst, buk);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}
