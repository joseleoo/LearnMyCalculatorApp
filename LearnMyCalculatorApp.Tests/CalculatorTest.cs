using Microsoft.VisualStudio.TestTools.UnitTesting;
using LearnMyCalculatorApp;

namespace LearnMyCalculatorApp.Tests
{
    /// <summary>
    /// Arrange is where you declare any variables that the test might need. In this example, we must declare a calculator object to call its Add method.
    /// Act is where you call the code that you want to test. In this step, you can insert parameters and exercise the code.
    /// Assert is where you check if the outcome of the action is expected. You can add multiple assertions to any test. If one assertion fails, the test will fail.
    /// </summary>
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void CalculatorNullTest()
        {
            var calculator = new Calculator();
            Assert.IsNotNull(calculator);
        }
        [TestMethod]
        public void AddTest()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            int actual = calculator.Add(1, 1);
            bool subtractActual = calculator.Subtract(actual, 1) == 1;

            //Assert
            Assert.IsNotNull(calculator);
            Assert.AreEqual(2, actual);
            Assert.IsTrue(subtractActual);
            StringAssert.Contains(actual.ToString(), "2");
        }
        [TestMethod]
        public void SusbtractTest()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var actual = calculator.Subtract(5, 3);

            //Assert

            Assert.AreEqual(2, actual);
        }

    }
}
