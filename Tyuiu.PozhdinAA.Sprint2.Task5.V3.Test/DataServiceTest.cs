using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PozhdinAA.Sprint2.Task5.V3.Lib;

namespace Tyuiu.PozhdinAA.Sprint2.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.FindDayName(x);
            Assert.AreEqual(res, "Вторник");
        }
    }
}