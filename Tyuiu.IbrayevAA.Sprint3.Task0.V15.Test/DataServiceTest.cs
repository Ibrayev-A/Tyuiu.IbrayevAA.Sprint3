using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IbrayevAA.Sprint3.Task0.V15.Lib;

namespace Tyuiu.IbrayevAA.Sprint3.Task0.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double value = 0.7;
            int startValue = 1;
            int stopValue = 10;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 2.087;
            Assert.AreEqual(wait, res);
        }
    }
}
