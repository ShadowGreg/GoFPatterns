using GoFPatterns.Behavioral;
using NUnit.Framework;

namespace GoFTests {
    [TestFixture]
    public class TemplateMethodTests {
                                
        [Test]
        public void AnalogTransmitter_Test() {
            // Arrange
            Transmitter _transmitter = new AnalogTransmitter();
            const string expected = "Запись фрагмента речиМодуляция аналового сигналаПередача сигнала по радиоканалу";

            // Act
            string actual = _transmitter.ProcessStart();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void DigitalTransmitter_Test() {
            // Arrange
            Transmitter _transmitter = new DigitalTransmitter();
            const string expected = "Запись фрагмента речиМодуляция аналового сигналаМодуляция аналового сигналаМодуляция аналового сигналаПередача сигнала по радиоканалу";

            // Act
            string actual = _transmitter.ProcessStart();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}