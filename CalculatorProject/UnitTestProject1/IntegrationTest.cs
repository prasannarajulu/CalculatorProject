using System;
using Calculator1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class IntegrationTest
    {
        [TestMethod]
        public void TestCalculator()
        {
            //Arrange Equation
            string equation = "10 + 5 - 2 * 6 / 2";
            var expectedResult = 39;

            //Action
            var actualResult = SingletonManager.Instance.Calculate(equation);

            //Assert
            Assert.IsTrue(actualResult == expectedResult);
        }

        [TestMethod]
        public void TestCalculatorNegative()
        {
            //Arrange Equation
            string equation = "10 + 5 - 2 * 6 / 2";
            var expectedResult = 49;

            //Action
            var actualResult = SingletonManager.Instance.Calculate(equation);

            //Assert
            Assert.IsTrue(actualResult != expectedResult);
        }
    }
}
