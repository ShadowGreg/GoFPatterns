using GoFPatterns.Structural;
using NUnit.Framework;

namespace GoFTests {
    [TestFixture]
    public class CompositeTest {
        private readonly ComposerItem _file = new DropDownComposerItem("Файл->");

        private readonly ComposerItem _create = new DropDownComposerItem("Создать->");
        private readonly ComposerItem _open = new DropDownComposerItem("Открыть->");
        private readonly ComposerItem _exit = new ClickableComposerItem("Файл->");

        [Test]
        public void some_tests() {
            _file.Add(_create);
            _file.Add(_open);
            _file.Add(_exit);
            string expectedText = "";

            string actualText = _file.Display();

            Assert.AreEqual(expectedText, actualText);
        }
    }
}