using Microsoft.VisualStudio.TestTools.UnitTesting;
using mak1;
using System;
using System.Collections.Generic;
using System.Text;

namespace mak1.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            double res = Calculator.Calculate(6, 2, "+");
            Console.WriteLine("res = " + res);

            return false;
    }
}