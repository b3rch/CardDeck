using CardDeck.Shuffle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDeck.Models
{
    public class Deck
    {
        private Card[] Cards { get; set; }
        private IShuffleMethod ShuffleMethod { get; set; }
        private int CurrentCard { get; set; }

        public Deck() 
        {
            ShuffleMethod = new ShuffleSwapMethod();
            InitializeDeck();
            CurrentCard = 0;
        }

        public Deck(IShuffleMethod shuffle): this() 
        {
            ShuffleMethod = shuffle;
        }

        private void InitializeDeck() 
        {
            Cards = new Card[Constants.SUIT_SIZE * Constants.DECK_COUNT];
            CreateDeckSuit(SuitEnum.CLUBS,0);
            CreateDeckSuit(SuitEnum.DIAMONDS,1);
            CreateDeckSuit(SuitEnum.HEARTS,2);
            CreateDeckSuit(SuitEnum.SPADES,3);
        }

        private void CreateDeckSuit(SuitEnum suit, int step) 
        {
            for (int i = 0; i < Constants.SUIT_SIZE; i++)
            {
                Cards[i + Constants.SUIT_SIZE * step] = new Card(i + 1, suit);
            }
        }

        override public string ToString() 
        {
            var str = "";
            for (int i = 0; i < Constants.SUIT_SIZE * Constants.DECK_COUNT; i++)
            {
                str += Cards[i].ToString() + "\n";
            }
            return str;
        }

        public Card[] Shuffle(int steps) 
        {
            ShuffleMethod.Shuffle(Cards, steps);
            return Cards;
        }

        public Card Deal() 
        {
            if (CurrentCard >= Constants.SUIT_SIZE * Constants.DECK_COUNT) 
            {
                CurrentCard = 0;
                Shuffle(1);
            }
            return Cards[CurrentCard++];
        }
    }
}
