using Microsoft.VisualStudio.TestTools.UnitTesting;
using Extensions_Exceptions_Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions_Exceptions_Units.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        [ExpectedException(typeof(NotImplementedException))]
        public void ThrowTest()
        {
            //assert
            Logic oLogic = new Logic();
            oLogic.Throw();
            //act
            //NotImplementedException

        }
    }
}