using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CianOReilly_s00187820;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            Phone acc1 = new Phone();
            decimal expectedPrice = 100m;

            //Act
            acc1.IncreasePrice(100m);

            //Assert
            Assert.AreEqual(expectedPrice, acc1.Price);
        }
    }
}
