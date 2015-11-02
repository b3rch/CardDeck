using CardDeck.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDeck.Shuffle
{
    public interface IShuffleMethod
    {
        void Shuffle(Card[] cards, int steps);
    }
}
