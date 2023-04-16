using GoFPatterns.Structural.Adapter;
using NUnit.Framework;

namespace GoFTests {
    [TestFixture]
    public class AdapterTest {
        private static float kg = 55.0f; // кг
        private static float lb = 55.0f; // фунт

        private IScales rScales = new RussianScales(kg);
        private IScales bScales = new AdapterForBritishScales(new BritishScales(lb));

        [Test]
        public void adapter_test() {
            Assert.AreNotEqual(rScales,bScales);
        }

    }
}