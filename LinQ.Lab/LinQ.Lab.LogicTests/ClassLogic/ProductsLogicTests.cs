using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinQ.Lab.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinQ.Lab.Data;

namespace LinQ.Lab.Logic.Tests
{
    [TestClass()]
    public class ProductsLogicTests
    {
        [TestMethod()]
        public void GetProductsStockTest()
        {            
            ProductsLogic list = new ProductsLogic();
            var stock = list.GetProductsStock();
            var countInDb = 5; 

            Assert.AreEqual(countInDb, stock.Count);
        }
    }
}