using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializableDeck
{
    class Program
    {
        Random random = new Random();

        static void Main(string[] args)
        {

        }

        /// <summary>
        /// Creates a random deck of cards
        /// </summary>
        private Deck RandomDeck(int number)
        {
            Deck myDeck = new Deck(new Card[] { });
            for (int i = 0; i < number; i++)
            {
                myDeck.Add(new Card(
                (Suits)random.Next(4),
                (Values)random.Next(1, 14)
                ));
            }
            return myDeck;
        }

        /// <summary>
        /// Deals all of the cards and prints them to the console
        /// </summary>
        private void DealCards(Deck deckToDeal, string title)
        {
            Console.WriteLine(title);
            while (deckToDeal.Count > 0)
            {
                Card nextCard = deckToDeal.Deal(0);
                Console.WriteLine(nextCard.Name);
            }
            Console.WriteLine("------------------");
        }
    }
}
