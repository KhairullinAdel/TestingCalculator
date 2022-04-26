using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingCalculator;
using System;

namespace CalcTest
{
    [TestClass]
    public class TestClass
    {
        [TestMethod]
        public void SummatorTest()
        {
            Assert.AreEqual(Calculator.Calculate("2+4"), 6);
        }
        
        [TestMethod]
        public void SubstractorTest()
        {
            Assert.AreEqual(Calculator.Calculate("2-4"), -2);
        }

        [TestMethod]
        public void MultiplicatorTest()
        {
            Assert.AreEqual(Calculator.Calculate("2*4"), 8);
        }

        [TestMethod]
        public void DividerTest()
        {
            Assert.AreEqual(Calculator.Calculate("2/4"), 0.5, 0.1,"Погрешность привышина");
        }

        [TestMethod]
        public void DivideByZeroTest()
        {
            Assert.ThrowsException<Exception>(() => Calculator.Calculate("2/0"));
        }
    }
}
