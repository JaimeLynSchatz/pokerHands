using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokerHands;

namespace PokerHands
{
    class Dealer
    {
        
        public static List<Card> Deal(int cardsPerHand) // doesn't make sense as instance method -- only one dealer per game/program
        {
            // generate a hand of cardsPerHand cards
            // keep track of how many cards there are left in the deck
            // returns a Hand of cards in a List<>

            List<Card> newPlayerHand = new List<Card>();
            Card card1 = new Card("AH");
            newPlayerHand.Add(card1);

            newPlayerHand.Add(new Card("2D"));
            newPlayerHand.Add(new Card("5C"));
            newPlayerHand.Add(new Card("2C"));
            newPlayerHand.Add(new Card("9H"));

            return newPlayerHand;
        }



    }
}
