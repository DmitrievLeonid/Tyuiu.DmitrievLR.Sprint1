using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DmitrievLR.Sprint1.Task0.Lib;

namespace Tyuiu.DmitrievLR.Sprint1.Task0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            //как будто сокращаешь ссылку

            var result = ds.Calculate();

           
            Assert.AreEqual(12, result);
        }
    }
}
