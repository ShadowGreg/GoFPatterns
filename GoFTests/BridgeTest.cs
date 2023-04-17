using GoFPatterns.Structural;
using NUnit.Framework;

namespace GoFTests {
    [TestFixture]
    public class BridgeTest {
        private readonly WindowsControl _winC = new WindowsControl();
        private readonly WebControl _webC = new WebControl();

        [Test]
        public void text_from_button_win_and_web_are_not_equal() {
            Button winButton = new Button(_winC);
            Button webButton = new Button(_webC);
            
            Assert.AreNotEqual(winButton.Draw(),webButton.Draw());
        }
        
        [Test]
        public void textBox_win_text() {
            TextBox winTextBox = new TextBox(_winC);
            const string expectedText = "Элменет текст бокс нарисован для Windows";
            
            string actualText = winTextBox.Draw();
            
            Assert.AreEqual(expectedText,actualText);
        }
        
        [Test]
        public void textBox_web_text() {
            TextBox winTextBox = new TextBox(_webC);
            const string expectedText = "Элменет текст бокс нарисован для Web приложения";
            
            string actualText = winTextBox.Draw();
            
            Assert.AreEqual(expectedText,actualText);
        }
    }
}