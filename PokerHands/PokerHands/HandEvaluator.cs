﻿using System;
using PlayerHand;

namespace PokerHands
{
    class HandEvaluator
    {

        // returns true if sorted successfully
        public bool Sort(PlayerHand playerHand)
        {
            // I need the rank here -- something's off with the way I've set up Card
            // I need to set it up as a List<>
            playerHand.Hand.Rank.Sort; // this isn't working

            return true;
        }
        // may be a clear cause for "magic numbers" - each type of winning hand should have a number code?? No, it needs to compare
        // High Card: Returns card with highest ranking card.
        public Card HighCard(PlayerHand playerHand)
        {
            Card highestCard = new Card("2", "Clubs");
            return highestCard;
        }

        // 1 Royal Flush: Ten, Jack, Queen, King, Ace, in same suit.
        public bool RoyalFlush(PlayerHand playerHand)
        {
            // returns true if there is a Royal Flush
            return false;
        }

        // 2 Straight Flush: All cards are consecutive values of same suit.
        public bool StraightFlush(PlayerHand playerHand)
        {
            // returns true if there is a Straight Flush
            return false;
        }

        // 3 Four of a Kind: Four cards of the same value.
        public bool FourOfAKind(PlayerHand playerHand)
        {
            // returns true if there is four of a kind
            return false;
        }

        // 4 Full House: Three of a kind and a pair.
        public bool FullHouse(PlayerHand playerHand)
        {
            // returns true if there is a FullHouse
            return false;
        }

        // 5 Flush: All cards of the same suit.
        public bool Flush(PlayerHand playerHand)
        {
            // returns true if there is a Flush
            return false;
        }

        // 6 Straight: All cards are consecutive values.
        public bool Straight(PlayerHand playerHand)
        {
            // returns true if there is a straight
            return false;
        }

        // 7 Three of a Kind: Three cards of the same value.
        public bool ThreeOfAKind(PlayerHand playerHand)
        {
            // returns true if there are three of a kind
            return false;
        }

        // 8 Two Pairs: Two different pairs.
        public bool TwoPair(PlayerHand playerHand)
        {
            // returns true if there are two pairs
            return false;
        }

        // 9 One Pair: Two cards of the same value.
        public bool OnePair(PlayerHand playerHand)
        {
            // returns true if there is one pair
            return false;
        }

       
 

  
  
 

       
   
        


    }
}
