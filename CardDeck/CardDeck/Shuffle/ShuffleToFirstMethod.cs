using CardDeck.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDeck.Shuffle
{
    public class ShuffleToFirstMethod : SwapItems, IShuffleMethod
    {
        public ShuffleToFirstMethod() { }

        public void Shuffle(Models.Card[] cards, int steps)
        {
            var random = new Random();
            for (int i = 0; i < steps; i++)
            {
                var firstIndex = random.Next(1, Constants.SUIT_SIZE * Constants.DECK_COUNT);
                Swap(cards, firstIndex, 0);
            }
        }
    }
}
