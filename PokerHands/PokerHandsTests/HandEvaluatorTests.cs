using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerHands;

namespace PokerHandsTests
{
    [TestClass]
    public class HandEvaluatorTests
    {

        [TestMethod]
        public void CanSortCardsByRank()
        {
            PlayerHand player1 = new PlayerHand();
            player1.Cards.Add(new Card(Rank.Ace, Suit.Diamonds));
            player1.Cards.Add(new Card(Rank.Eight, Suit.Clubs));
            player1.Cards.Add(new Card(Rank.Jack, Suit.Hearts));
            player1.Cards.Add(new Card(Rank.Nine, Suit.Spades));
            player1.Cards.Add(new Card(Rank.Two, Suit.Clubs));

            HandEvaluator.SortByRank(player1);

            Assert.AreEqual("{2C,8C,9S,JH,AD}", player1.ToString());
        }
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

        [TestMethod]
        public void CanDetermineIfHandIsNotAFlush()
        {
            // Arrange
            PlayerHand player1 = new PlayerHand();
            player1.Cards.Add(new Card(Rank.Ace, Suit.Diamonds));
            player1.Cards.Add(new Card(Rank.Eight, Suit.Clubs));
            player1.Cards.Add(new Card(Rank.Jack, Suit.Hearts));
            player1.Cards.Add(new Card(Rank.Nine, Suit.Spades));
            player1.Cards.Add(new Card(Rank.Two, Suit.Clubs));
            
            //Act


            // Assert
            Assert.IsFalse(HandEvaluator.Flush(player1));
        }

        [TestMethod]
        public void CanDetermineIfHandIsAFlush()
        {
            // Arrange
            PlayerHand player2 = new PlayerHand();
            player2.Cards.Add(new Card(Rank.Ace, Suit.Diamonds));
            player2.Cards.Add(new Card(Rank.Eight, Suit.Diamonds));
            player2.Cards.Add(new Card(Rank.Jack, Suit.Diamonds));
            player2.Cards.Add(new Card(Rank.Nine, Suit.Diamonds));
            player2.Cards.Add(new Card(Rank.Two, Suit.Diamonds));

            // Act

            // Assert
            Assert.IsTrue(HandEvaluator.Flush(player2));
        }
    }
}
