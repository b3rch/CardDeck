using CardDeck;
using CardDeck.Models;
using CardDeck.Shuffle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDeck
{
    class Program
    {
        static void Main(string[] args)
        {
            var deck = new Deck(new ShuffleToFirstMethod());
            deck.Shuffle(52);
            System.Console.WriteLine(deck.ToString());
            System.Console.WriteLine("Ten cards");
            for (int i = 0; i < 60; i++)
            {
                var card = deck.Deal();
                System.Console.WriteLine(card.ToString());
            }
            System.Console.WriteLine("Press any key...");
            System.Console.ReadKey();
        }
    }
}
