using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DmitrievLR.Sprint1.Task5.V5.Lib;

namespace Tyuiu.DmitrievLR.Sprint1.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 32.597;
            int wait = 5;

            int res = Convert.ToInt32(ds.Calculate(x));


            Assert.AreEqual(wait, res);
        }
    }
}
