using GoFPatterns.Creational.Builder;
using NUnit.Framework;

namespace GoFTests {
    [TestFixture]
    public class BuilderTest {
        private IDeveloper _androidDeveloper;
        private IDeveloper _iphoneDeveloper;
        private Director _director;

        [Test]
        public void create_android_phone() {
            _androidDeveloper = new AndroidDeveloper();
            _director = new Director(_androidDeveloper);

            string phone = _director.MountFullPhone().AboutPhone();
            
            Assert.NotNull(phone);
        }
        
        [Test]
        public void create_iphone_phone() {
            _iphoneDeveloper = new AndroidDeveloper();
            _director = new Director(_iphoneDeveloper);

            string phone = _director.MountFullPhone().AboutPhone();
            
            Assert.NotNull(phone);
        }
        
                
        [Test]
        public void create_iphone_and_android_phones_and_they_NotEqual() {
            _iphoneDeveloper = new IphoneDeveloper();
            _androidDeveloper = new AndroidDeveloper();
            
            
            _director = new Director(_androidDeveloper);
            string samsung = _director.MountFullPhone().AboutPhone();
            _director.SetDeveloper(_iphoneDeveloper);
            string iphone = _director.MountFullPhone().AboutPhone();
            
            Assert.AreNotEqual(samsung,iphone);
        }

        
    }
}