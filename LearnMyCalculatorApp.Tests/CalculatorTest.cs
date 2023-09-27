using Microsoft.VisualStudio.TestTools.UnitTesting;
using LearnMyCalculatorApp;
using FluentAssertions;

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
        /// <summary>
        /// Puede usar pruebas controladas por datos para ejecutar el mismo método de prueba muchas veces con varios parámetros. Esta técnica también se denomina prueba parametrizada. Permite evitar la repetición en el código al mismo tiempo que se comprueba la misma función con un conjunto completo de entradas de datos diferentes.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="expected"></param>
        [DataTestMethod]
        [DataRow(1,1,2)]
        [DataRow(2,2,4)]
        [DataRow(3,3,6)]
        [DataRow(0,0,1)]// The test run with this row fails
        public void AddDataTest(int x, int y, int expected)
        {
            var calculator=new Calculator();
            var actual =calculator.Add(x,y);    
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Las aserciones de Fluent son un conjunto popular de métodos de extensión proporcionados por la comunidad de .NET que pueden ayudarle a identificar claramente los métodos de aserción. Usa lenguaje legible para facilitar la escritura y lectura de pruebas.
        /// </summary>
        [TestMethod]
        public void AddTestFluentassertion() { 
        
            var calculator = new Calculator();
            var actual = calculator.Add(1, 1);

            //Non-fluent asserts:
            //Assert.AreEqual(actual,2);
            //Assert.AreNotEqual(actual,1);

            //same asserts as what is commented out above, but using Fluent Assertions
            actual.Should().Be(2).And.NotBe(1);

        }
        [TestMethod]
        public void CalculatorNullTest()
        {
            var calculator = new Calculator();
            Assert.IsNotNull(calculator);
            Assert.IsTrue(false); // Will fail the test
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
