using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DmitrievLR.Sprint1.Task4.V18.Lib;

namespace Tyuiu.DmitrievLR.Sprint1.Task4.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 1;
            double y = 2;

            var wait = 0.5;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);

        }
    }
}
