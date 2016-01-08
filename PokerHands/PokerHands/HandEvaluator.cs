using System;
using System.Linq;

// Using rules round at: http://www.pokerhands.com/poker_hand_tie_rules.html
namespace PokerHands
{
    enum HandStrength
    {
        StraightFlush,  // same suit, consecutively ranked cards
        FourOfAKind,
        FullHouse,      // a set of three and a pair
        Flush,          // same suit, ranks not consecutive
        Straight,       // different suits, consecutively ranked cards
        ThreeOfAKind,
        TwoPair,
        OnePair,
        HighCard
    }

    // build the functions to return true/false if there's a match
    // in the even of a tie, go to the high card.

    public static class HandEvaluator
    {
        

        public static int CompareCards(Card x, Card y)  // take two cards, compare Rank - return 1 if x > y, 0 if x == y, -1 if x < y
        {
            if ((x == null && y == null) || (x.Rank == y.Rank))
                { return 0; }// either they're both null or both equal

            else if (x.Rank > y.Rank) // need to see how to cast this
                { return 1; }

            else // y.Rank > x.Rank is the only other option
                { return -1; }
        }
        

        // returns true if sorted successfully
        
        public static bool SortByRank(PlayerHand playerHand)
        {
            // I need the rank here -- something's off with the way I've set up Card
            // I need to set it up as a List<>
            playerHand.Cards.Sort(CompareCards);

            return true;
        }
        

        // High Card: Returns card with highest ranking card.
        public static Card HighCard(PlayerHand playerHand)
        {
            Card highCard = new Card(Rank.Two, Suit.Clubs);
            foreach (Card c in playerHand.Cards)
            {
                if (c.Rank > highCard.Rank)
                {
                    highCard = c;
                }
                else
                {
                    // keep current highCard
                }
            }

            return highCard;
        }

        // 1 Royal Flush: Ten, Jack, Queen, King, Ace, in same suit.
        public static bool RoyalFlush(PlayerHand playerHand)
        {
            if (Flush(playerHand) && Straight(playerHand) && (playerHand.Cards[0].Rank) == Rank.Ten) 
            {
                return true;
            }

                return false;
        }

        // 2 Straight Flush: All cards are consecutive values of same suit.
        public static bool StraightFlush(PlayerHand playerHand)
        {
            // returns true if there is a Straight Flush
            if (Flush(playerHand))
            {
                // run straight test
                return true;
            }
            else return false;
        }

        // 3 Four of a Kind: Four cards of the same value.
        public static bool FourOfAKind(PlayerHand playerHand)
        {
            // returns true if there is four of a kind
            return false;
        }

        // 4 Full House: Three of a kind and a pair.
        public static bool FullHouse(PlayerHand playerHand)
        {
            // returns true if there is a FullHouse
            return false;
        }

        // 5 Flush: All cards of the same suit.
        public static bool Flush(PlayerHand playerHand)
        {
            if (playerHand.Cards[0].Suit == playerHand.Cards[1].Suit)
            {
                Suit handSuit = playerHand.Cards[0].Suit;
                foreach (Card c in playerHand.Cards)
                {
                    if (c.Suit != handSuit)
                    {
                        return false;
                    }
                    else
                    {
                        continue;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
            return false;
        }

        // 6 Straight: Returns true if all cards are consecutive values.
        public static bool Straight(PlayerHand playerHand)
        {
            SortByRank(playerHand);
            for (int i = 0; i < playerHand.Cards.Count-1; i++)
            {
                if ((playerHand.Cards[i].Rank + 1) != playerHand.Cards[i + 1].Rank)
                {
                    return false;
                }
            }
      
            return true;
        }

        // 7 Three of a Kind: Three cards of the same value.
        public static bool ThreeOfAKind(PlayerHand playerHand)
        {
            // returns true if there are three of a kind
            return false;
        }

        // 8 Two Pairs: Two different pairs.
        public static bool TwoPair(PlayerHand playerHand)
        {
            // returns true if there are two pairs
            return false;
        }

        // 9 One Pair: Two cards of the same value.
        public static bool OnePair(PlayerHand playerHand)
        {
            // returns true if there is one pair
            return false;
        }

       
 

  
  
 

       
   
        


    }
}
