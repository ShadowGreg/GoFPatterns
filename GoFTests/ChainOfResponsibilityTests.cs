using GoFPatterns.Behavioral;
using NUnit.Framework;

namespace GoFTests {
    [TestFixture]
    public class ChainOfResponsibilityTests {
        private readonly Designer _designer = new Designer();
        private readonly Mason _mason = new Mason();
        private readonly Plasterer _plasterer = new Plasterer();
        private readonly Painter _painter = new Painter();
        private readonly Plumber _plumber = new Plumber();
        private readonly Electrician _electrician = new Electrician();


        [Test]
        public void How_The_Class_Executes_The_Commands_Assigned_To_It_Test() {
            // Arrange
            string expected =
                "Проектировщик выполнил команду: спроектировать дом";

            // Act
            _designer.SetNextWorker(_mason);
            string actual = ChainOfResponsibility.GiveCommand(_designer, "спроектировать дом");

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void A_Chain_Of_Commands_Executed_By_Specialists_Test() {
            // Arrange
            string expected = "Проектировщик выполнил команду: спроектировать дом Каменщик выполнил команду: класть керпичь Штукатур выполнил команду: штукатурить стены Маляр выполнил команду: красить поверхности Сантехник выполнил команду: подсоединить сантехнику Электрик выполнил команду: подсоединить электрику";

            // Act
            _designer.SetNextWorker(_mason).SetNextWorker(_plasterer).SetNextWorker(_painter).SetNextWorker(_plumber)
                .SetNextWorker(_electrician);
            string actual = ChainOfResponsibility.GiveCommand(_designer, "спроектировать дом") + " " +
                            ChainOfResponsibility.GiveCommand(_designer, "класть керпичь") + " " +
                            ChainOfResponsibility.GiveCommand(_designer, "штукатурить стены") + " " +
                            ChainOfResponsibility.GiveCommand(_designer, "красить поверхности") + " " +
                            ChainOfResponsibility.GiveCommand(_designer, "подсоединить сантехнику") + " " +
                            ChainOfResponsibility.GiveCommand(_designer, "подсоединить электрику");


            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void When_None_Of_The_Specialists_Knows_How_To_Execute_The_Command_Test() {
            // Arrange
            string expected =
                "Проектировщик выполнил команду: спроектировать дом Каменщик выполнил команду: класть керпичь Штукатур выполнил команду: штукатурить стены Маляр выполнил команду: красить поверхности Сантехник выполнил команду: подсоединить сантехнику Электрик выполнил команду: подсоединить электрику Подсоединить отопление и вентиляцию - никто не умеет этого делать";

            // Act
            _designer.SetNextWorker(_mason).SetNextWorker(_plasterer).SetNextWorker(_painter).SetNextWorker(_plumber)
                .SetNextWorker(_electrician);
            string actual = ChainOfResponsibility.GiveCommand(_designer, "спроектировать дом") + " " +
                            ChainOfResponsibility.GiveCommand(_designer, "класть керпичь") + " " +
                            ChainOfResponsibility.GiveCommand(_designer, "штукатурить стены") + " " +
                            ChainOfResponsibility.GiveCommand(_designer, "красить поверхности") + " " +
                            ChainOfResponsibility.GiveCommand(_designer, "подсоединить сантехнику") + " " +
                            ChainOfResponsibility.GiveCommand(_designer, "подсоединить электрику") + " " +
                            ChainOfResponsibility.GiveCommand(_designer, "Подсоединить отопление и вентиляцию");


            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}