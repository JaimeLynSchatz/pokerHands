using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokerHands;

namespace PokerHands
{
    class HandEvaluator
    {

        // may be a clear cause for "magic numbers" - each type of winning hand should have a number code?? No, it needs to compare
        // High Card: Returns card with highest ranking card.
        public Card HighCard(playerHand playerHand)
        {
            Card highestCard = new Card(Rank 2, Suit "Clubs");21
            return highestCard;
        }
        
        //One Pair: Two cards of the same value.
        public bool OnePair(PlayerHand playerHand)
        {
            // returns true if there is one pair
            return false;
        }

        //Two Pairs: Two different pairs.
        public bool TwoPair(PlayerHand playerHand)
        {
            // returns true if there are two pairs
            return false;
        }

        //Three of a Kind: Three cards of the same value.
        public bool ThreeOfAKind(PlayerHand playerHand)
        {
            // returns true if there are three of a kind
            return false;
        }

        // Straight: All cards are consecutive values.
        public bool Straight(PlayerHand playerHand)
        {
            // returns true if there is a straight
            return false;
        }

        /*Flush: All cards of the same suit.
        Full House: Three of a kind and a pair.
        Four of a Kind: Four cards of the same value.
        Straight Flush: All cards are consecutive values of same suit.
        Royal Flush: Ten, Jack, Queen, King, Ace, in same suit.
        */

    }
}
