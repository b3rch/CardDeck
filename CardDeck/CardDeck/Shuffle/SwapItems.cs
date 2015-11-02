using CardDeck.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDeck.Shuffle
{
    public class SwapItems
    {
        public void Swap(Card[] cards, int firstIndex, int secondIndex)
        {
            var card = cards[firstIndex];
            cards[firstIndex] = cards[secondIndex];
            cards[secondIndex] = card;
        }
    }
}
