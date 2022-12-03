using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durak.Common
{
    class Pair
    {
        public Card First { get; set; }
        public Card Second { get; set; }
        Pair(Card first = null, Card second = null)
        {
            First = first;
            Second = second;
        }
    }
}
