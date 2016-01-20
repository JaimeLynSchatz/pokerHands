using System;
using System.Collections.Generic;
using System.Linq;

// Using rules round at: http://www.pokerhands.com/poker_hand_tie_rules.html
namespace PokerHands
{
    public enum HandStrength
    {
        RoyalFlush,     // same suit, consecutively ranked, 10-Ace
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
    
        private static Dictionary<Rank, int> rankCount = new Dictionary<Rank, int>();
    
        public static int CompareCards(Card x, Card y)  // take two cards, compare Rank - return 1 if x > y, 0 if x == y, -1 if x < y
        {
            if ((x == null && y == null) || (x.Rank == y.Rank))
                { return 0; }// either they're both null or both equal

            else if (x.Rank > y.Rank) // need to see how to cast this
                { return 1; }

            else // y.Rank > x.Rank is the only other option
                { return -1; }
        }
        
        public static HandStrength evaluateHand(PlayerHand playerHand)
        {
            HandStrength strength = new HandStrength();
            return strength;
        }

        // returns a sorted copy of the hand passed in 
        public static PlayerHand SortByRank(PlayerHand playerHand)
        {
            // I need the rank here -- something's off with the way I've set up Card
            // I need to set it up as a List<>
            PlayerHand sorted = new PlayerHand(playerHand.Cards);
            sorted.Cards.Sort(CompareCards);
            return sorted;
        }

        // returns the number of matching cards
        public static Dictionary<Rank, int> CountRanks(PlayerHand playerHand)
        {
            for (int i = 0; i < playerHand.Cards.Count; i++)
            {
                Rank cardRank = playerHand.Cards[i].Rank;
                if (rankCount.ContainsKey(cardRank))
                {
                    rankCount[cardRank] += 1;
                }
                else
                {
                    rankCount[cardRank] = 1;
                }
            }
            
            return rankCount;
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

        // 1 Royal Flush: Returns true if hand is Ten, Jack, Queen, King, Ace, in same suit.
        public static bool RoyalFlush(PlayerHand playerHand)
        {
            if (Flush(playerHand) && Straight(playerHand) && (playerHand.Cards[0].Rank) == Rank.Ten) 
            {
                // do we assign the HandStrength enum value here?
                return true;
            }

                return false;
        }

        // 2 Straight Flush: Returns true if all cards are consecutive values of same suit.
        public static bool StraightFlush(PlayerHand playerHand)
        {
            if (Flush(playerHand) && Straight(playerHand))
            {
                return true;
            }
            else return false;
        }

        // 3 Four of a Kind: Returns true is the hand has four cards of the same value.
        public static bool FourOfAKind(PlayerHand playerHand)
        {
            if (rankCount.ContainsValue(4))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // 4 Full House: Returns true if there are three of a kind and a pair.
        public static bool FullHouse(PlayerHand playerHand)
        {
            if (rankCount.ContainsValue(3) && rankCount.ContainsValue(2))
            {
                return true;
            }
            else
            {
                return false;
            }
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

        // 7 Three of a Kind: Returns true if there are three cards of the same value.
        public static bool ThreeOfAKind(PlayerHand playerHand)
        {
            if (rankCount.ContainsValue(3))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // 8 Two Pairs: Returns true if there are two different pairs.
        public static bool TwoPair(PlayerHand playerHand)
        {
            
            // Do I need to count how many keys lead to the value 2? 
            // if there are three ranks counted, and one is a pair, then there must be another pair
            if (rankCount.Count == 3 && rankCount.ContainsValue(2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // 9 One Pair: Two cards of the same value.
        public static bool OnePair(PlayerHand playerHand)
        {
            SortByRank(playerHand); // TODO - bring this up to the top DRY DRY DRY

            if (rankCount.ContainsValue(2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
