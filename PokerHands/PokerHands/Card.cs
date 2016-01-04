using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHands
{
    public class Card
    {
        public string FullCard { get; set; }
        public int Rank { get; set; }
        public string Suit { get; set; }

        public Card(string FullCard)
        {
            // TODO: write parameter checking here - simplifies switch and fail fast if bad parameters
            if (FullCard == null)
            {
                throw System.ArgumentNullException; // ??? Why doesn't this work in this context?
            }
        
            else if (FullCard.Length != 2)
            {
                throw System.ArgumentException;
            }

            else if (false) // TODO: I need a regex here for anything that doesn't fit the "R(ank)S(suit)" pattern
            {
                throw System.ArgumentException;
            }

            this.FullCard = FullCard;

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
