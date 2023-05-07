using GoFPatterns.Behavioral;
using NUnit.Framework;

namespace GoFTests {
    [TestFixture]
    public class StrategyTests {
        private ResourceReader _resourceReader;

        [SetUp]
        public void SetUp() {
            _resourceReader = new ResourceReader(new HeadHunterReader());
        }

        [Test]
        public void HeadHunter_Test() {
            // Arrange
            const string expected = "Чтение информации с хэдхатер https://volgograd.hh.ru/";

            // Act
            const string url = "https://volgograd.hh.ru/";
            string actual = _resourceReader.Read(url);

            // Assert
            Assert.AreEqual(expected, actual);
        }
                
        [Test]
        public void Harbor_Test() {
            // Arrange
            const string expected = "Чтение информации с харбор https://habr.com/";

            // Act
            _resourceReader.SetStrategy(new HarborReader());
            const string url = "https://habr.com/";
            string actual = _resourceReader.Read(url);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        
                        
        [Test]
        public void TelegramChannel_Test() {
            // Arrange
            const string expected = "Чтение информации с телеграмм каналов https://t.me/DotNetRuJobsFeed";

            // Act
            _resourceReader.SetStrategy(new TelegramChannelReader());
            const string url = "https://t.me/DotNetRuJobsFeed";
            string actual = _resourceReader.Read(url);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}