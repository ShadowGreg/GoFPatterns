using GoFPatterns.Creational.FactoryMethod;
using NUnit.Framework;

namespace GoFTests
{
    [TestFixture]
    public class FactoryMethodTest
    {
        IWorkShop creator = new CarWorkShop();

        [Test]
        public void Test()
        {
            IProductions car = creator.Create();

            creator = new TruckWorkShop();
            IProductions truck = creator.Create();
            
            Assert.AreNotEqual(car, truck);
        }

    }

}