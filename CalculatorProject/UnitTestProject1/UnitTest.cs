using System;
using Calculator1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        //Arrange
        [DataRow(10, 5, 15, OperatorType.Add)]
        [DataRow(10, 5, 5, OperatorType.Subtract)]
        [DataRow(10, 5, 50, OperatorType.Multiply)]
        [DataRow(10, 5, 2, OperatorType.Divide)]        
        public void TestOperationCalculator(int a, int b, int expectedResult, OperatorType operatorType)
        {
            //Action
            var actualResult = TestOperation(a, b, operatorType);

            //Assert
            Assert.IsTrue(actualResult == expectedResult);
        }        

        private int TestOperation(int a, int b, OperatorType operatorType)
        {
           return OperationFactory.GetOperation(operatorType).Operation(a,b);
        }
    }
}
