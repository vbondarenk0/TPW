using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleAdditionApp;

namespace SimpleAdditionAppTests
{
    [TestClass]
    public class DodawanieTests
    {
        [TestMethod]
        public void Add_ShouldCorrectlyAddTwoNumbers()
        {
            // Arrange
            var dodawanie = new Dodawanie();
            int number1 = 5;
            int number2 = 7;

            // Act
            var result = dodawanie.Add(number1, number2);

            // Assert
            Assert.AreEqual(12, result);
        }
    }
}
