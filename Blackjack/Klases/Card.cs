using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Card
    {
        //vērtība
        public string Value;

        //masts
        public char Suit;

        //izveido jaunu kārti
        //value = vērtība
        //suit = masts
        public Card(string value, char suit)
        {
            this.Value = value;
            this.Suit = suit;
        }
        //kārts skaitliskā vērtība
        public int GetValue()
        {
            return 0;
        }
    }
}
