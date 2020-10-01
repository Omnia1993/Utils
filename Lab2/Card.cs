using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class Card
    {
string Rank { get; set; }
        string Suit { get; set; }
        int Value { get; set; }

        public override string ToString()
        {
            return Rank + " Omnia" +Suit;
        }

        public Card(string rank, string suit, int value)
        {
            Rank = rank ?? throw new ArgumentNullException(nameof(rank));
            Suit = suit ?? throw new ArgumentNullException(nameof(suit));
            Value = value;
        }
    }
}
