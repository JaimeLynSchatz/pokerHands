using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerHands;

namespace PokerHandsTests
{
    [TestClass]
    public class PlayerHandTests
    {
        [TestMethod]
        public void CanGetNewHand()
        {
            // Arrange
            PlayerHand playerHand1 = new PlayerHand();


            // Act


            // Assert
            Assert.IsNotNull(playerHand1);
        }
    }
}
