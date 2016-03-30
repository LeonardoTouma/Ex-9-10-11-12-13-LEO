using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Card
    {
        public enum SuitEnum
        {
            Hearts,
            Clubs,
            Diamonds,
            Spades,

        }
        public SuitEnum suit { get; set; }
        public Card (SuitEnum suit)
        {
            this.suit = suit;
        }
    }
}
