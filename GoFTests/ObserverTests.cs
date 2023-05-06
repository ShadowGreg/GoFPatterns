using GoFPatterns.Behavioral;
using NUnit.Framework;

namespace GoFTests {
    [TestFixture]
    public class ObserverTests {
        private Product _product;
        private Wholesale _wholesale;
        private Buyer _buyer;

        [SetUp]
        public void SetUp() {
            _product = new Product(400.99);
            _wholesale = new Wholesale(_product);
            _buyer = new Buyer(_product);
        }

        [Test]
        public void Warning_The_Entire_Chain_Of_Observers_About_Changes_In_The_Price_Of_Goods_Test() {
            // Arrange
            SetUp();
            const string expected =
                "Цена изменилась и стала 399,99Не подходящая цена на Некий товар для Оптовик ОптовикНе подходящая цена на Некий товар для Покупатель Покупатель предупреждены об измении цены";

            // Act
            string actual = _product.ChangePrice(399.99);

            // Assert
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void Purchase_Of_Goods_By_The_Buyer_And_Seller_Test() {
            // Arrange
            SetUp();
            const string expected =
                "Цена изменилась и стала 349,99Не подходящая цена на Некий товар для Оптовик ОптовикПокупатель закупил Некий товар Покупатель предупреждены об измении ценыЦена изменилась и стала 210,34Оптовик закупил Некий товар Оптовик предупреждены об измении цены";

            // Act
            string actual = _product.ChangePrice(349.99);
            actual += _product.ChangePrice(210.34);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}