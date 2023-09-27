using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DmitrievLR.Sprint1.Task6.V6.Lib;

namespace Tyuiu.DmitrievLR.Sprint1.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string strTest = "привет мир";

            var res = ds.DeleteFirstLetter(strTest);
            string wait = "ривет ир";
            Assert.AreEqual(wait, res);
        }
    }
}
