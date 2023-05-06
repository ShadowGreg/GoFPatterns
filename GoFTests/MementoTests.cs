using GoFPatterns.Behavioral;
using NUnit.Framework;

namespace GoFTests {
    [TestFixture]
    public class MementoTests {
        private Exchange _exchange;
        private Memory _memory;

        [SetUp]
        public void SetUp() {
            _exchange = new Exchange(10.5, 10.7);
            _memory = new Memory(_exchange);
        }

        [Test]
        public void Availability_Of_Metals_On_The_Stock_Exchange_Test() {
            // Arrange
            SetUp();
            const string expected = "Количество золота: 10,5 Количество серебра: 10,7";

            // Act

            // Assert
            string actual = _exchange.GetGold() + " " + _exchange.GetSilver();
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void Sale_And_Purchase_Of_Metals_Test() {
            // Arrange
            Availability_Of_Metals_On_The_Stock_Exchange_Test();
            const string expected = "Количество золота: 9,5 Количество серебра: 11,7";

            // Act
            _exchange.Sell();
            _exchange.Buy();

            // Assert
            string actual = _exchange.GetGold() + " " + _exchange.GetSilver();
            Assert.AreEqual(expected, actual);
        }
        
                
        [Test]
        public void Сonservation_Test() {
            // Arrange
            Sale_And_Purchase_Of_Metals_Test();
            const string expected = "Количество золота: 9,5 Количество серебра: 11,7";

            // Act
            _memory.Backup();
            _exchange.Sell();
            _exchange.Buy();
            _memory.Undo();

            // Assert
            string actual = _exchange.GetGold() + " " + _exchange.GetSilver();
            Assert.AreEqual(expected, actual);
        }
    }
}