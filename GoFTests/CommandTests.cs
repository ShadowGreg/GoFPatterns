using GoFPatterns.Behavioral;
using NUnit.Framework;

namespace GoFTests {
    [TestFixture]
    public class CommandTests {
        private static readonly Conveyor _conveyor = new Conveyor();
        private static readonly СonveyorControlPanel multipult = new СonveyorControlPanel();

        private static void SetUp() {
            multipult.SetCommand(0, new EnableDisableButtons(_conveyor));
            multipult.SetCommand(1, new ZoomButtonsDecreaseSpeed(_conveyor));
        }


        [Test]
        public void Pipeline_Enable_Test() {
            // Arrange
            string expected =
                "Конвейер запущен. Скорость конвейера увеличина. ";

            // Act
            SetUp();
            string actual = multipult.PressOn(0) + multipult.PressOn(1);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Undo_Commands_Test() {
            // Arrange
            string expected =
                "Конвейер запущен. Скорость конвейера увеличина. Скорость конвейера понижена. Конвейер остановлен. ";

            // Act
            SetUp();
            string actual = multipult.PressOn(0) + multipult.PressOn(1) + multipult.PressCancel() +
                            multipult.PressCancel();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}