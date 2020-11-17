using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumbledCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.WriteLine("Here's a list of random cards:");
            List<Card> cards = new List<Card>();
            for (int i = 0; i < 5; i++)
            {
                cards.Add(new Card((Suits)random.Next(0, 4), (Values)random.Next(1, 14)));
                Console.WriteLine(cards[i].Name);
            }
            Console.WriteLine();
            Console.WriteLine("Those same cards, sorted:");
            cards.Sort(new CardComparer_byValue());
            foreach (Card card in cards)
            {
                Console.WriteLine(card.Name);
            }

            Console.ReadKey();
        }
    }

    class CardComparer_byValue : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            if (x.Value > y.Value) { return 1; }
            else if (x.Value < y.Value) { return -1; }
            else
            {
                if (x.Suit > y.Suit) { return 1; }
                else if (x.Suit < y.Suit) { return -1; }
                else { return 0; }
            }
        }
    }
}
