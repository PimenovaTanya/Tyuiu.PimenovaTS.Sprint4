using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PimenovaTS.Sprint4.Task2.V9.Lib;

namespace Tyuiu.PimenovaTS.Sprint4.Task2.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] lol = { 4, 9, 2, 3, 7, 1 };

            int res = ds.Calculate(lol);
            int wait = 8;

            Assert.AreEqual(wait, res);
        }
    }
}
