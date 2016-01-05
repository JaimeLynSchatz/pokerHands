using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerHands;
using System.Collections.Generic;

namespace PokerHandsTests
{
    [TestClass]
    public class PlayerHandTests
    {
        [TestMethod]
        public void VerifyAHandOfNoCardsLooksRight()
        {
            PlayerHand handOfZero = new PlayerHand();

            Assert.AreEqual("{}", handOfZero.ToString());
        }

        [TestMethod]
        public void VerifyAHandOfFiveCardsLooksRight()
        {
            List<Card> fiveCards = new List<Card>();
            fiveCards.Add(new Card(Rank.Two, Suit.Clubs));
            fiveCards.Add(new Card(Rank.King, Suit.Diamonds));
            fiveCards.Add(new Card(Rank.Queen, Suit.Spades));
            fiveCards.Add(new Card(Rank.Three, Suit.Diamonds));
            fiveCards.Add(new Card(Rank.Three, Suit.Clubs));

            PlayerHand handOfFive = new PlayerHand(fiveCards);

            //Assert.AreEqual(5, fiveCards.Count);
            Assert.AreEqual("{2C,KD,QS,3D,3C}", handOfFive.ToString());

        }
    }
}
