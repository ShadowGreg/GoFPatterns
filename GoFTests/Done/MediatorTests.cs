using GoFPatterns.Behavioral;
using NUnit.Framework;

namespace GoFTests {
    [TestFixture]
    public class MediatorTests {
        private static ITDirector _director;
        private static UXDesigner _designer;
        private Mediator _mediator;

        [SetUp]
        public void SetUp() {
            _designer = new UXDesigner();
            _director = new ITDirector();
            _mediator = new Mediator(_designer, _director);
        }
        
        [Test]
        public void Recognition_Of_Command_Through_A_Mediator_When_Submitting_Through_A_Director_Test() {
            // Arrange
            SetUp();
            const string expected = "<-Дизайнер в работе";

            // Act
            _director.GiveCommand("Проектировать");

            // Assert
            string actual = _designer.ExecuteWork();
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void Recognition__Command_Through_A_Mediator_When_Submitting_Through_A_Director_Test() {
            // Arrange
            SetUp();
            const string expected = "-> Директор знает, что UX дизайнер в работе";

            // Act
            _director.GiveCommand("Проектировать");
            _designer.ExecuteWork();
            

            // Assert
            string actual = _director.GiveCommand("Сделапй ещё и это срочно!");
            Assert.AreEqual(expected, actual);
        }       
       
    }
}