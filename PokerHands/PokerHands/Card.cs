using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHands
{
    public enum Suit : int
    {
        Clubs, Diamonds, Hearts, Spades
    }

    public enum Rank : int
    {
        Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace
    }

    public class Card
    {
        public Rank Rank { get; set; }
        public Suit Suit { get; set; }

        public Card(Rank r, Suit s)
        {
            Rank = r; Suit = s;
        }

        public override String ToString()
        {
            var suitsArray = new string[] { "C", "D", "H", "S" };
            var rankArray = new string[] { "2","3","4","5","6","7","8","9","T","J","Q","K","A" };
            return rankArray[(int)Rank] + suitsArray[(int)Suit];
        }
    }
}
