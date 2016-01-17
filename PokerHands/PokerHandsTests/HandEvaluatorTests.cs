using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerHands;
using System.Collections.Generic;

namespace PokerHandsTests
{
    [TestClass]
    public class HandEvaluatorTests
    {

        static private string basicHandStringSorted = "{2C,8C,9S,JH,AD}";
        static private PlayerHand basicHand = new PlayerHand();
        static private PlayerHand aceOfDiamondHighCard = new PlayerHand();
        private static PlayerHand straightHand = new PlayerHand();
        private static PlayerHand flushHand = new PlayerHand();
        private static PlayerHand royalFlushHand = new PlayerHand();
        private static PlayerHand straightFlushHand = new PlayerHand();

        //Use ClassInitialize to run code before running the first test  in the class
        [ClassInitialize] // tried with and without the parens - not being run
        public static void HandEvaluatorTestsInitialize(TestContext testContext) { 
            
            // A basic hand used for tests that don't require a special hand
            basicHand.Cards.Add(new Card(Rank.Ace, Suit.Diamonds));
            basicHand.Cards.Add(new Card(Rank.Eight, Suit.Clubs));
            basicHand.Cards.Add(new Card(Rank.Jack, Suit.Hearts));
            basicHand.Cards.Add(new Card(Rank.Nine, Suit.Spades));
            basicHand.Cards.Add(new Card(Rank.Two, Suit.Clubs));
            
            aceOfDiamondHighCard.Cards.Add(new Card(Rank.Ace, Suit.Diamonds));
            aceOfDiamondHighCard.Cards.Add(new Card(Rank.Eight, Suit.Clubs));
            aceOfDiamondHighCard.Cards.Add(new Card(Rank.Jack, Suit.Hearts));
            aceOfDiamondHighCard.Cards.Add(new Card(Rank.Nine, Suit.Spades));
            aceOfDiamondHighCard.Cards.Add(new Card(Rank.Two, Suit.Clubs));
            
            straightHand.Cards.Add(new Card(Rank.Three, Suit.Diamonds));
            straightHand.Cards.Add(new Card(Rank.Six, Suit.Diamonds));
            straightHand.Cards.Add(new Card(Rank.Five, Suit.Diamonds));
            straightHand.Cards.Add(new Card(Rank.Four, Suit.Diamonds));
            straightHand.Cards.Add(new Card(Rank.Two, Suit.Diamonds));
            
            flushHand.Cards.Add(new Card(Rank.Ace, Suit.Diamonds));
            flushHand.Cards.Add(new Card(Rank.Eight, Suit.Diamonds));
            flushHand.Cards.Add(new Card(Rank.Jack, Suit.Diamonds));
            flushHand.Cards.Add(new Card(Rank.Nine, Suit.Diamonds));
            flushHand.Cards.Add(new Card(Rank.Two, Suit.Diamonds));
            
            royalFlushHand.Cards.Add(new Card(Rank.Ace, Suit.Clubs));
            royalFlushHand.Cards.Add(new Card(Rank.Ten, Suit.Clubs));
            royalFlushHand.Cards.Add(new Card(Rank.Queen, Suit.Clubs));
            royalFlushHand.Cards.Add(new Card(Rank.Jack, Suit.Clubs));
            royalFlushHand.Cards.Add(new Card(Rank.King, Suit.Clubs));
            
            straightFlushHand.Cards.Add(new Card(Rank.Five, Suit.Hearts));
            straightFlushHand.Cards.Add(new Card(Rank.Four, Suit.Hearts));
            straightFlushHand.Cards.Add(new Card(Rank.Two, Suit.Hearts));
            straightFlushHand.Cards.Add(new Card(Rank.Three, Suit.Hearts));
            straightFlushHand.Cards.Add(new Card(Rank.Six, Suit.Hearts));
        }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        [ClassCleanup]
        public static void MyClassCleanup() { }

        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        [TestMethod]
        public void CanSortCardsByRank()
        {  
            Assert.AreEqual(basicHandStringSorted, HandEvaluator.SortByRank(basicHand).ToString());
        }
        [TestMethod]

        public void HighCardTest()
        {
            Card highCard = new Card(Rank.Two, Suit.Clubs);
            highCard = HandEvaluator.HighCard(aceOfDiamondHighCard);
            Assert.AreEqual((new Card(Rank.Ace, Suit.Diamonds)).Rank, highCard.Rank);
        }

        [TestMethod]
        public void CanDetermineIfHandIsNotAFlush()
        {
            // Assert
            Assert.IsFalse(HandEvaluator.Flush(basicHand));
        }

        [TestMethod]
        public void CanDetermineIfHandIsAFlush()
        {
            Assert.IsTrue(HandEvaluator.Flush(flushHand));
        }

        [TestMethod]
        public void CanDetermineIfHandIsNotAStraight()
        {
            Assert.IsFalse(HandEvaluator.Straight(basicHand));
        }

        [TestMethod]
        public void CanDetermineIfHandIsAStraight()
        {
            Assert.IsTrue(HandEvaluator.Straight(straightHand));
        }

        [TestMethod]
        public void CanDetermineIfHandIsNotARoyalFlush()
        {
            Assert.IsFalse(HandEvaluator.RoyalFlush(straightHand));
        }

        [TestMethod]
        public void CanDetermineIfHandIsARoyalFlush()
        {
            // test with this sort removed - this really should be in the evaluator, not the test
            //HandEvaluator.SortByRank(royalFlushHand);
            Assert.IsTrue(HandEvaluator.RoyalFlush(royalFlushHand));
        }

        [TestMethod]
        public void CanDeterminIfHandIsNotAStraightFlush()
        {
            Assert.IsFalse(HandEvaluator.StraightFlush(basicHand));
        }

        [TestMethod]
        public void CanDetermineIfHandIsAStraightFlush()
        {
            // test with this sort removed - this really should be in the evaluator, not the test
            //HandEvaluator.SortByRank(straightFlushHand);
            Assert.IsTrue(HandEvaluator.StraightFlush(straightFlushHand));
        }

        [TestMethod]
        public void CanCountRanksInAHand()
        {
            // this one needs some work, leaving here for now -- what's a better way??
            PlayerHand player1 = new PlayerHand();
            player1.Cards.Add(new Card(Rank.Ace, Suit.Diamonds));
            player1.Cards.Add(new Card(Rank.Eight, Suit.Clubs));
            player1.Cards.Add(new Card(Rank.Ace, Suit.Hearts));
            player1.Cards.Add(new Card(Rank.Nine, Suit.Spades));
            player1.Cards.Add(new Card(Rank.Two, Suit.Clubs));

            Dictionary<Rank, int> actualRanks = new Dictionary<Rank, int>();

            actualRanks = HandEvaluator.CountRanks(player1);
            Assert.IsTrue(actualRanks.ContainsKey(Rank.Ace) && actualRanks.ContainsValue(2));
            // need a better way to evaluate what's coming out of CountRanks
        }

        [TestMethod]
        public void LambdaFun()
        {
            // this is so close to my grasp
            // just not quite there
            // from https://social.msdn.microsoft.com/Forums/en-US/2c08a0d0-58e4-4df6-b6d3-75e785fff8a8/array-of-function-pointers?forum=csharplanguage

            Func<bool>[] evaluators = { RoyalFlush, StraightFlush, FourOfAKind, FullHouse, Flush, Straight, ThreeOfAKind, TwoPair, OnePair, HighCard }

                foreach (var e in evaluators) {
                    if ( something here - error? )
                    {
                    break;
                    }
                }

            var evaluators = new Func<PlayerHand, uint>[] {
                (PlayerHand hand) =>
                {
                    return 10;
                }
            };

            var result = 0;
            foreach (var e in evaluators) 
            {
                result = e(playerHand);
                if (result > 0)
                    break;
            }

            if (result >100)
            {
                //
            }
            else
            {
                //
            }

        }
    }
}
