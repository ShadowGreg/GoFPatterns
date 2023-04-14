using GoFPatterns.Creational.FactoryMethod;
using NUnit.Framework;

namespace GoFTests
{
    [TestFixture]
    public class FactoryMethodTest
    {
        private IWorkShop creator;

        [Test]
        public void Car_Realise_Test()
        {
            const string expectedText = "Выпущен новый легковой автомобиль";
            creator = new CarWorkShop();
            IProductions car = creator.Create();

            string actualText = car.Realise();

            Assert.AreEqual(expectedText, actualText);
        }

        [Test]
        public void Truck_Realise_Test()
        {
            const string expectedText = "Выпущен новый грузовой автомобиль";
            creator = new TruckWorkShop();
            IProductions Truck = creator.Create();

            string actualText = Truck.Realise();

            Assert.AreEqual(expectedText, actualText);
        }

        [Test]
        public void Car_and_Truck_assert_Test()
        {
            creator = new CarWorkShop();
            IProductions car = creator.Create();

            creator = new TruckWorkShop();
            IProductions truck = creator.Create();

            Assert.AreNotEqual(car, truck);
        }
    }
}