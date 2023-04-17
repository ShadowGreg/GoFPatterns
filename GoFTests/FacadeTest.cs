using GoFPatterns.Structural;
using NUnit.Framework;

namespace GoFTests {
    [TestFixture]
    public class FacadeTest {
        private readonly Facade _facade = new Facade(new OperationA(), new OperationB(), new OperationC());

        [Test]
        public void some_command_from_facade_are_notEqual() {
            string fistOperation = _facade.FirstDifficultyOperation();
            string secondOperation = _facade.SecondDifficultyOperation();
            
            Assert.AreNotEqual(fistOperation,secondOperation);
        }
    }
}