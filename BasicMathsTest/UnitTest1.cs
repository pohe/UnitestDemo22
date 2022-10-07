using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitestDemo22;

namespace BasicMathsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddTwoPositiveNumbers()
        {
            //Arrange
            BasicMaths b = new BasicMaths();

            //Act
            double result = b.Add(20, 40);

            //Assert
            Assert.AreEqual(60, result);
        }
    }
}