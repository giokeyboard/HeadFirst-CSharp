using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCards
{
    class Card
    {
        public Suits Suit { get; set; }
        public Values Value { get; set; }
        public string Name { get { return $"{Value} of {Suit}"; } }

        public Card(Suits suit, Values value)
        {
            Suit = suit;
            Value = value;
        }
    }

    public enum Values
    {
        Ace = 1, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King,
    }

    public enum Suits
    {
        Spades = 0,
        Clubs = 1,
        Diamonds = 2,
        Hearts = 3,
    }
}
