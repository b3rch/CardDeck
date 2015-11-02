using CardDeck.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDeck.Shuffle
{
    public class ShuffleSwapMethod : SwapItems, IShuffleMethod
    {
        public ShuffleSwapMethod()
        {

        }

        public void Shuffle(Card[] cards, int steps)
        {
            var random = new Random();
            for (int i = 0; i < steps; i++) 
            {
                var firstIndex = random.Next(0, Constants.SUIT_SIZE * Constants.DECK_COUNT);
                var secondIndex = random.Next(0, Constants.SUIT_SIZE * Constants.DECK_COUNT);
                Swap(cards, firstIndex, secondIndex);
            }
        }

    }
}
