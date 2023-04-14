using GoFPatterns.Creational.AbstractFactory;
using NUnit.Framework;

namespace GoFTests {
    [TestFixture]
    public class AbstractFactoryTest {
        private IFactory rFactory;
        private IFactory bFactory;

        [Test]
        public void create_car_and_engine_on_factory_test() {
            rFactory = new RussianFactory();
            bFactory = new BelorusFactory();

            ICar rCar = rFactory.createCar();
            IEngine rEngine = rFactory.createEngine();
            ICar bCar = bFactory.createCar();
            IEngine bEngine = bFactory.createEngine();
            
            Assert.AreNotEqual(rCar,bCar);
            Assert.AreNotEqual(rEngine, bEngine);
        }
    }
}