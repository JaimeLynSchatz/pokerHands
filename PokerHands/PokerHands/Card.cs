using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHands
{
    class Card
    {
        public string Rank { get; set; }
        public string Suit { get; set; }

        public Card (string Rank, string Suit)
        {
            this.Rank = Rank;
            this.Suit = Suit;
        }
    }
}
