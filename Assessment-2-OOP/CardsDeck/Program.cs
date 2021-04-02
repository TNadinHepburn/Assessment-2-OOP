using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsDeck
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck test = new Deck();
            Console.WriteLine(test.IsEmpty());
            Console.WriteLine("--------------------------");
            test.Shuffle();
            foreach (Card card in test.Pile)
            {
                Console.WriteLine(card.ToString());
            }
            Console.WriteLine("--------------------------");
            test.DealAll();
            Console.WriteLine("--------------------------");
            Console.WriteLine(test.IsEmpty());
        }
    }
}
