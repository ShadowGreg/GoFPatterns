using GoFPatterns.Behavioral;
using NUnit.Framework;

namespace GoFTests {
    [TestFixture]
    public class StateTests {
        private TrafficLight _trafficLight;

        [SetUp]
        public void SetUp() {
            _trafficLight = new TrafficLight(new YellowState());
        }

        [Test]
        public void Switch_The_Traffic_Light_To_The_Next_Signal_In_Order_Test() {
            // Arrange
            const string expected = "Установлено состояние Состояние переведено из жёлтого в красный ";

            // Act
            string actual = _trafficLight.NextState();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        
        [Test]
        public void We_Make_Sure_That_The_Lower_State_Is_Attached_Test() {
            // Arrange
            const string expected = "Установлено состояние Состояние красный ";

            // Act
            _trafficLight.NextState();
            _trafficLight.NextState();
            _trafficLight.NextState();
            string actual = _trafficLight.NextState();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Switch_The_Traffic_Light_To_The_First_Signal_In_Order_Test() {
            // Arrange
            const string expected = "Установлено состояние Состяние преведено из жёлтого в зелёный ";

            // Act
            string actual = _trafficLight.PreviousState();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void We_Make_Sure_That_The_Upper_State_Is_Attached__Test() {
            // Arrange
            const string expected = "Установлено состояние Состяние преведено в зелёный ";

            // Act
            _trafficLight.PreviousState();
            _trafficLight.PreviousState();
            _trafficLight.PreviousState();
            string actual = _trafficLight.PreviousState();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}