using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DmitrievLR.Sprint1.Task2.V11.Lib;

namespace Tyuiu.DmitrievLR.Sprint1.Task2.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidConvert()
        {
            DataService ds = new DataService();

            int x = 2;
            int y = 40;
            var res = ds.ConvertHoursMinutesToSeconds(x, y);

            Assert.AreEqual(400, res);
        }
    }
}
