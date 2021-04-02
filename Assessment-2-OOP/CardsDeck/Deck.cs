using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsDeck
{
    class Deck
    {
        /*
        **Deck - List<card>
        ***isempty
        ***shuffle
        ***deal
        */

        public List<Card> Pile { get; set; }

        public bool IsEmpty()
        {
        }

        public void Shuffle()
        {
        }

        public Card Deal()
        {
        }

        public Deck()
        {

            List<string> suits = new List<string> { "Spade", "Heart", "Club", "Diamond" };
            Pile = new List<Card>();
            
            foreach(string suit in suits)
            {
                for( int i = 1; i <= 13; i++)
                {
                    Pile.Add(new Card(i, suit));
                }
            }
            
        }

    }
}
