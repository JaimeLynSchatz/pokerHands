using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerHands;

namespace PokerHandsTests
{
    [TestClass]
    public class CardTest
    {
        [TestMethod]
        public void CanCreateACard()
        {
            // Arrange
            Card testAceOfHearts = new Card("AH");
            //Card test2OfDiamonds = new Card("2D");

            // Act
            // same as Arrange

            // Assert
            Assert.IsNotNull(testAceOfHearts); 
        }
    }
}
