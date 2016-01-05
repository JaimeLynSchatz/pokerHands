using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerHands;

namespace PokerHandsTests
{
    [TestClass]
    public class HandEvaluatorTests
    {
        [TestMethod]
        public void HighCardTest()
        {
            // Arrange
            PlayerHand player1 = new PlayerHand();
            player1.Cards.Add(new Card(Rank.Ace, Suit.Diamonds));
            player1.Cards.Add(new Card(Rank.Eight, Suit.Clubs));
            player1.Cards.Add(new Card(Rank.Jack, Suit.Hearts));
            player1.Cards.Add(new Card(Rank.Nine, Suit.Spades));
            player1.Cards.Add(new Card(Rank.Two, Suit.Clubs));

            // Act
            Card highCard = new Card(Rank.Two, Suit.Clubs);
            highCard = HandEvaluator.HighCard(player1);

            // Assert
            Assert.AreEqual((new Card(Rank.Ace, Suit.Diamonds)).Rank, highCard.Rank);
        }
    }
}
