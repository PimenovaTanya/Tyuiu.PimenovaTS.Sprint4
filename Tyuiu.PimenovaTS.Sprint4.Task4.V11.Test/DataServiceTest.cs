using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PimenovaTS.Sprint4.Task4.V11.Lib;

namespace Tyuiu.PimenovaTS.Sprint4.Task4.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] mass = new int[5, 5] { { 5, 7, 7, 8, 5 }, { 6, 5, 6, 8, 6 }, { 7, 6, 8, 8, 5 }, { 7, 6, 7, 8, 6 }, { 7, 6, 7, 7, 5 } };
            int res = ds.Calculate(mass);
            int wait = 81;

            Assert.AreEqual(wait, res);
        }
    }
}
