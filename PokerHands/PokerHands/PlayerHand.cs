using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokerHands;

namespace PokerHands
{
    public class PlayerHand
    {
        public List<Card> Cards { get; set; }

        public PlayerHand(List<Card> hand) 
            : this()
        {
            foreach (Card c in hand)
                Add(c);
        }
        public PlayerHand()
        {
            Cards = new List<Card>();
        }

        public void Add(Card c)
        {
            Cards.Add(c);
        }

        public override string ToString()
        {
            return "{" + String.Join(",", (object[])Cards.ToArray()) + "}";
        }
    }
}
