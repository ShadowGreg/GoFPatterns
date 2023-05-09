using GoFPatterns.Behavioral;
using NUnit.Framework;

namespace GoFTests {
    [TestFixture]
    public class IteratorTests {
        [Test]
        public void Comparison_Of_Two_Unequal_Stacks_Test() {
            // Arrange
            DataStack firstStack = new DataStack();
            DataStack secondStack = new DataStack();

            // Act
            for (int i = 0; i < 10; i++) {
                firstStack.Push(i);
            }

            // Assert
            Assert.False(firstStack == secondStack);
        }

        [Test]
        public void Copying_From_One_Stack_To_Another_Test() {
            // Arrange
            DataStack firstStack = new DataStack();

            // Act
            for (int i = 0; i < 10; i++) {
                firstStack.Push(i);
            }

            DataStack secondStack = new DataStack(firstStack);


            // Assert
            Assert.True(firstStack == secondStack);
        }
        
        [Test]
        public void Test_Removal_Items_From_The_Stack_Test() {
            // Arrange
            DataStack firstStack = new DataStack();

            // Act
            for (int i = 0; i < 10; i++) {
                firstStack.Push(i);
            }

            DataStack secondStack = new DataStack(firstStack);
            firstStack.Pop();


            // Assert
            Assert.True(firstStack != secondStack);
        }
    }
}