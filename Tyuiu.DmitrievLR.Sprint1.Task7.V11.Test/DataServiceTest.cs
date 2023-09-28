using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DmitrievLR.Sprint1.Task7.V11.Lib;

namespace Tyuiu.DmitrievLR.Sprint1.Task7.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {

            DataService ds = new DataService();
            double x = 3;
            
            double y = 2;

            double wait = -2.993;

            var res = ds.Calculate(x, y);

            Assert.AreEqual(wait, res);
        }
    }
}
