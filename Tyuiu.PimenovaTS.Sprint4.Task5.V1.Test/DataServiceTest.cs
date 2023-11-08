using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PimenovaTS.Sprint4.Task5.V1.Lib;

namespace Tyuiu.PimenovaTS.Sprint4.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] zombi = new int[5, 5] { { 5, -7, 7, 8, 5 }, { 6, -5, -6, 8, 6 }, { 7, -6, 8, -8, 5 }, { 7, -6, 7, 8, 6 }, { -7, -6, -7, 7, 5 } };

            int[,] res = ds.Calculate(zombi);
            int[,] wait = { { 1, -7, 1, 1, 1 }, { 1, -5, -6, 1, 1 }, { 1, -6, 1, -8, 1 }, { 1, -6, 1, 1, 1 }, { -7, -6, -7, 1, 1 } };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
