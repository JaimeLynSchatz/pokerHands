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
        public List<Card> Hand { get; set; }
        public Card HighCard { get; set; }
        public string BestHand { get; set; }

        public PlayerHand()
        {
            this.Hand = Dealer.Deal(5);
        }
        
    }
}
