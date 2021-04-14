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
            Deck deck = new Deck();
            Console.WriteLine(deck.IsEmpty());
            deck.Shuffle();
            Console.WriteLine("press enter for new card");
            while (!deck.IsEmpty())
            {
                Console.WriteLine($"{deck.Deal()}\npress enter for new card");
                Console.ReadLine();
            }
            Console.WriteLine(deck.IsEmpty());

        }
    }

}

