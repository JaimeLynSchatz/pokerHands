using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHands
{
    class PlayerHand
    {
        public Card[] Hand { get; set; }
        public Card HighCard { get; set; }
        public string BestHand { get; set; }

        
    }
}
