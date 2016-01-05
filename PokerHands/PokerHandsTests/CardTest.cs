using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerHands;

namespace PokerHandsTests
{
    [TestClass]
    public class CardTest
    {
        [TestMethod]
        public void ShortCardNames()
        {
            Card tenHearts = new Card(Rank.Ten, Suit.Hearts);
            String TH = tenHearts.ToString();
            Assert.AreEqual("TH", TH);

            Assert.AreEqual("TS", new Card(Rank.Ten, Suit.Spades).ToString());
            Assert.AreEqual("2S", new Card(Rank.Two, Suit.Spades).ToString());
            Assert.AreEqual("KC", new Card(Rank.King, Suit.Clubs).ToString());
        }

        [TestMethod]
        public void CanICompareCards()
        {
            Card twoD = new Card(Rank.Two, Suit.Diamonds);
            Card twoC = new Card(Rank.Two, Suit.Clubs);
            Card threeD = new Card(Rank.Three, Suit.Diamonds);

            Assert.AreEqual(twoD.Suit, threeD.Suit);
            Assert.AreEqual(twoD.Rank, twoC.Rank);
            Assert.AreNotEqual(twoD.Suit, twoC.Suit);
            Assert.AreNotEqual(twoD.Rank, threeD.Rank);
        }
    }
}
