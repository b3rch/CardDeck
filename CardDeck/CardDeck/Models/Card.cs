using CardDeck.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CardDeck.Models
{
    public class Card
    {
        public Card(int value, SuitEnum suit) 
        {
            Value = value;
            Suit = suit;
        }
        public int Value { get; set; }
        public SuitEnum Suit { get; set; }

        override public string ToString() 
        {
            return "Suit=" + EnumExtension.GetDescription((SuitEnum)Suit) + " Value=" + Value.ToString();    
        }
    }
}
