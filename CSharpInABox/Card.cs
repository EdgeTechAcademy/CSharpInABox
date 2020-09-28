using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpInABox
{
    class Card
    {
        string image;
        public string Rank { get; set; }
        public string Suit { get; set; }
        public int Value { get; set; }

        public override string ToString()
        {
            return Rank + " " + Suit;
        }

        public Card(string rank, string suit, int value)
        {
            Rank = rank;
            Suit = suit;
            Value = value;
        }
    }
}
