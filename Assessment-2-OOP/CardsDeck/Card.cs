using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsDeck
{
    class Card
    {
        /*
         **Suit - string 
         **Value - int
         */
        public string Suit { get; }
        public int Value { get; }

        public Card(int value, string suit)
        {
            Suit = suit;
            Value = value;
        }

        public override string ToString()
        {
            return $"Value: {Value} Suit: {Suit}";
        }
    }
}
