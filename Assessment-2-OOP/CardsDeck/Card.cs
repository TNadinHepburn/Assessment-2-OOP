using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsDeck
{
    class Card
    {
        public string Suit { get; }
        public int Value { get; }

        public Card(int value, string suit)
        {
            Suit = suit;
            Value = value;
        }

        public override string ToString()
        {
            //outputs the value and suit of a card e.g Value: 6 Suit: Heart
            return $"Value: {Value} Suit: {Suit}";
        }
    }
}
