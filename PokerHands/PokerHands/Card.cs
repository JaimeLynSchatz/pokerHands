using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHands
{
    class Card
    {
        public string FullCard { get; set; }
        public int Rank { get; set; }
        public string Suit { get; set; }

        public Card(string FullCard)
        {
            // do some parameter checking here so your switch is easier?? Fail fast

            this.FullCard = FullCard;

            // what if the whole thing is a switch statement with the default being a number rank?
            switch (FullCard[0])
            {
                case 'J':
                    // Jack
                    this.Rank = 11;
                    break;

                case 'Q':
                    // Queen
                    this.Rank = 12;
                    break;

                case 'K':
                    // King
                    this.Rank = 13;
                    break;

                case 'A':
                    // Ace
                    this.Rank = 14;
                    break;

                default: // we did the parameter checking above so the only thing left can be a number card
                         // it's a basic number card
                    this.Rank = (int)Char.GetNumericValue(FullCard[0]);
                    break;
            }
        }
    }
}
