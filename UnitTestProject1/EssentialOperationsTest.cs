using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using CalculatorNS;

namespace CalculatorNS.Tests
{
    [TestClass()]
    public class EssentialOperationsTest
    {
        [TestMethod()]
        public void SumTest()
        {
            var Calculator = new Calculator();
            var result = Calculator.Sum(1, 2);
            Assert.AreEqual(3, result);
        }

        [TestMethod()]
        public void SumTest2()
        {
            var Calculator = new Calculator();
            var result = Calculator.Sum(2, 2);
            Assert.AreEqual(5, result);
        }


        [TestMethod()]
        public void SumTest3()
        {
            var Calculator = new Calculator();
            var result = Calculator.Sum(1, 6);
            Assert.AreEqual(8, result);
        }


        [TestMethod()]
        public void minusTest()
        {
            var Calculator = new Calculator();
            var result = Calculator.Minus(1, 2);
            Assert.AreEqual(-1, result);
        }

        [TestMethod()]
        public void minusTest2()
        {
            var Calculator = new Calculator();
            var result = Calculator.Minus(4, 2);
            Assert.AreEqual(-2, result);
        }

        [TestMethod()]
        public void methodWihoutFullCoverageTest()
        {
            var Calculator = new Calculator();
            var result = Calculator.methodWithoutFullCoverage(10);
            Assert.AreEqual(1, result);
        }
    }
}


