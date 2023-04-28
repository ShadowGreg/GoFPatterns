using GoFPatterns.Structural;
using NUnit.Framework;

namespace GoFTests {
    [TestFixture]
    public class DecoratorTests {
        [Test]
        public void Transmitter_Created_Test() {
            // Arrange
            IProcessor transmitter = new Transmitter("Совершенно секретное сообщение. Штирлиц.");
            string expected = "Данные-> Совершенно секретное сообщение. Штирлиц. Переданы по каналу связи";

            // Act
            

            // Assert
            string actual = transmitter.Process();
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void Hamming_Coder_Creation_Test() {
            // Arrange
            IProcessor transmitter = new Transmitter("Совершенно секретное сообщение. Штирлиц.");
            string expected = "Наложен помехоустойчивый код Хамминга-> Данные-> Совершенно секретное сообщение. Штирлиц. Переданы по каналу связи";

            // Act
            Shell hammingCoder = new HammingCoder(transmitter);
            

            // Assert
            string actual = hammingCoder.Process();
            Assert.AreEqual(expected, actual);
        }
                
        [Test]
        public void Encryptor_Coder_Creation_Test() {
            // Arrange
            IProcessor transmitter = new Transmitter("Совершенно секретное сообщение. Штирлиц.");
            Shell hammingCoder = new HammingCoder(transmitter);
            string expected = "Шифрование данных-> Наложен помехоустойчивый код Хамминга-> Данные-> Совершенно секретное сообщение. Штирлиц. Переданы по каналу связи";

            // Act
            Shell encryptor = new Encryptor(hammingCoder);

            // Assert
            string actual = encryptor.Process();
            Assert.AreEqual(expected, actual);
        }
    }
}