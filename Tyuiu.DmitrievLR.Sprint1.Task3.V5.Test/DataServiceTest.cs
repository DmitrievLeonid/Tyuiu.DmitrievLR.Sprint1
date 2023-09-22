using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DmitrievLR.Sprint1.Task3.V5.Lib;

namespace Tyuiu.DmitrievLR.Sprint1.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            int Scale = 120;
            double distance = 3.5;
            int wait = 420;

            var res = ds.DistanceLength(Scale, distance);
            Assert.AreEqual(wait, res);
        }
    }
}
