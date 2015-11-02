using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace CardDeck.Models
{
    public enum SuitEnum
    {
        [Description("Clubs")]
        CLUBS,
        [Description("Diamonds")]
        DIAMONDS,
        [Description("Hearts")]
        HEARTS,
        [Description("Spades")]
        SPADES
    }
}
