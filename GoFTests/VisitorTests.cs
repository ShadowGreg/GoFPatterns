using System;
using System.Collections.Generic;
using GoFPatterns.Behavioral;
using NUnit.Framework;

namespace GoFTests {
    [TestFixture]
    public class VisitorTests {
                                        
        [Test]
        public void When_The_Visitor_Visited_All_The_Interesting_Places_In_The_City_Test() {
            // Arrange
            List<IPlace> _placesies = new List<IPlace>(){new Zoo(),new Cinema(),new Circus(), new Park()};
            const string expected = "В зоопарке я увидел слона. В кинотеатре мы посомтрели фильм Армагедон. В цирке мы увидели акробата. В парке мы увидели акробата. ";

            // Act
            string actual = string.Empty;
            foreach (IPlace place in _placesies) {
                HolidayMaker visitor = new HolidayMaker();
                place.Accept(visitor);
                actual += visitor.Msg;
            }

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}