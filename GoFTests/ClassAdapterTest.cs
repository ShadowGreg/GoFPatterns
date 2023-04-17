using GoFPatterns.Structural;
using NUnit.Framework;

namespace GoFTests {
    [TestFixture]
    public class ClassAdapterTest {
        private ICScales rCScales = new CRussianScales(55.0f);
        private ICScales bCScales = new AdapterForBritanScales(55.0f);

        [Test]
        public void the_scales_are_different_between_rScales_bScales() {
            Assert.AreNotEqual(rCScales,bCScales);
        }
    }
}