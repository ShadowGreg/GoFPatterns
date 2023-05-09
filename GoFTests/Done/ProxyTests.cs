using GoFPatterns.Structural;
using NUnit.Framework;

namespace GoFTests {
    [TestFixture]
    public class ProxyTests {
        private ISite mySite = new SiteProxy(new Site());
        
        [Test]
        public void Extract_Pages_Test() {
            // Arrange
            string expected =
                "Это страница 1";

            // Act


            // Assert
            string actual = mySite.GetPage(1);
            Assert.AreEqual(expected, actual);
        }
        
                
        [Test]
        public void Pages_Сaching_Test() {
            // Arrange
            string expected =
                "из кэша: Это страница 1";

            // Act
            Extract_Pages_Test();

            // Assert
            string actual = mySite.GetPage(1);
            Assert.AreEqual(expected, actual);
        }
    }
}