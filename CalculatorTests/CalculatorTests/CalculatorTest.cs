using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;

namespace CalculatorTests
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void AddMethodTest()
        {
            Calculator.Calculator calc = new Calculator.Calculator();
            calc.Add(1, 2);
            Assert.AreEqual(calc.Add(1, 2), 3);
        }
    }
}
