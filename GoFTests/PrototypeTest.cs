using GoFPatterns.Creational.Prototype;
using NUnit.Framework;

namespace GoFTests {
    [TestFixture]
    public class PrototypeTest {
        [Test]
        public void are_the_donor_and_clone_sheeps_name_Equals() {
            IAnimal sheepDonor = new Sheep();
            sheepDonor.SetName("Долли");

            IAnimal sheepClone = sheepDonor.Clone();

            Assert.AreEqual(sheepDonor.GetName(), sheepClone.GetName());
        }

        [Test]
        public void are_the_natural_and_clone_not_Equals() {
            IAnimal sheepDonor = new Sheep();
            sheepDonor.SetName("Долли");

            IAnimal sheepClone = sheepDonor.Clone();
            bool temp = sheepDonor.Equals(sheepClone);

            Assert.True(temp);
        }
    }
}