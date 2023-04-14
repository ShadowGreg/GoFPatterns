using System;
using GoFPatterns.Creational.Singleton;
using NUnit.Framework;

namespace GoFTests {
    [TestFixture]
    public class DataBaseManagerTest {
        [Test]
        public void start_test() {
            const string expectedException = "БД создана";

            string actualException = "";
            try {
                DataBaseManager.GetConnection();
            }
            catch (Exception e) {
                actualException = e.Message;
            }

            Assert.AreEqual(expectedException, actualException);
        }

        [Test]
        public void insert_and_data_select_test() {
            const string expectedData = "TEST";

            string actualData = "";
            try {
                DataBaseManager.GetConnection();
            }
            catch {
            }

            try {
                DataBaseManager.InsertData("TEST");
            }
            catch {
            }
            finally {
                actualData = DataBaseManager.SelectData();
            }

            Assert.AreEqual(expectedData, actualData);
        }
    }
}