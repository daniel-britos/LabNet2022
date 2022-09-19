using Microsoft.VisualStudio.TestTools.UnitTesting;
using Extensions_Exceptions_Units.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions_Exceptions_Units.Extensions.Tests
{
    [TestClass()]
    public class MyExtensionTests
    {
        [TestMethod()]
        public void DivideSingleNumberTest()
        {
            //arrage
            int number = 20;

            //act
            int dividerNumber = number / 0;

            //Assert.Fail(); Exception result.
        }
        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideSingleNumberTest1()
        {
            int number = 20;
            int dividerNumber = number / 0;

            Exception ex = new Exception(); 
            string msgEx = ex.Message;            

            Assert.AreEqual(dividerNumber, msgEx);
       
        }

        [TestMethod()]
        public void DivideTwoNumbersTest()
        {
            //arrage
            int numberOne = 10;
            int numberTwo = 2;
            double dividerNumber = numberOne / numberTwo;

            //act
            double result = 5;

            //Assert
            Assert.AreEqual(dividerNumber, result);
        }
    }
}