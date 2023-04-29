using System.Collections.Generic;
using GoFPatterns;
using NUnit.Framework;

namespace GoFTests {
    [TestFixture]
    public class FlyweightTests {
        FlyweightFactory factory = new FlyweightFactory(new List<Shared>()
        {
            new Shared("Яндекс", "Software Developer"),
            new Shared("Mail.ru Group", "Software Test Engineer"),
            new Shared("IBS Group", "UI/UX Designer"),
            new Shared("CROC", "Project Manager"),
            new Shared("Parallels", "System Administrator")
        });

        static string AddSpecialistDatabases(FlyweightFactory factory, string companyName, string position,
            string specialistName, string passport) {
            Flyweight flyweight = factory.GetFlyweight(new Shared(companyName, position));
            return flyweight.Process(new Unigue(specialistName, passport));
        }

        [Test]
        public void FlyweightFactory_Test() {
            // Arrange
            string expected =
                "Яндекс_Software Developer Mail.ru Group_Software Test Engineer IBS Group_UI/UX Designer CROC_Project Manager Parallels_System Administrator ";

            // Act


            // Assert
            string actual = factory.ListFlyweights();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AddSpecialistDatabases_Test() {
            // Arrange
            string expected =
                "Яндекс_Software Developer Mail.ru Group_Software Test Engineer IBS Group_UI/UX Designer CROC_Project Manager Parallels_System Administrator ";

            // Act
            string actual =AddSpecialistDatabases(factory, "Яндекс", "Software Developer", "Григорий", "AM-34563-234523");

            // Assert
            Assert.AreNotEqual(expected, actual);
        }
    }
}