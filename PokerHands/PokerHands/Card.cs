﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHands
{
    class Card
    {
        /*
        Will get back to this idea -- blocking other ideas right now - 1/1/16
        public string Rank { get; set; }
        public string Suit { get; set; }
        */

        public string FullCard { get; set; }
        public int Rank { get; set; }

        public Card(string FullCard)
        {
            // do some parameter checking here so your switch is easier?? Fail fast

            this.FullCard = FullCard;
            int rankValue = (int)Char.GetNumericValue(this.FullCard[0]);
            // playing with int val = (int)Char.GetNumericValue('8');

            // what if the whole thing is a switch statement with the default being a number rank?
            switch (FullCard[0])
            {
                case 'J':
                    // Jack
                    break;

                case 'Q':
                    // Queen
                    break;

                case 'K':
                    // King
                    break;

                case 'A':
                    // Ace
                    break;

                default:
                    // it's a basic number card
                    break;

            }

            if (rankValue >= 2 && rankValue <= 10)
            {
                // do something awesome
            }
            else  // I think I want to nest a switch statement in an if/else statement and that just seems wrong
            {
                // do something even awesomer
            }
            
        }



    }
}
