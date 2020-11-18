using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsDeckForm
{
    class Deck
    {
        private List<Card> cards;
        private Random random = new Random();

        public Deck()
        {
            cards = new List<Card>();
            for (int suit = 0; suit <= 3; suit++)
                for (int value = 1; value <= 13; value++)
                    cards.Add(new Card((Suits)suit, (Values)value));
        }

        public Deck(IEnumerable<Card> initialCards)
        {
            cards = new List<Card>(initialCards);
        }

        public int Count { get { return cards.Count; } }

        public void Add(Card cardToAdd)
        {
            cards.Add(cardToAdd);
        }

        public Card Deal(int index)
        {
            Card CardToDeal = cards[index];
            cards.RemoveAt(index);
            return CardToDeal;
        }

        public void Shuffle()
        {
            if (Count > 0)
            {
                List<Card> shuffledCards = new List<Card>();

                while (cards.Count > 0)
                {
                    int randIndex = random.Next(cards.Count);
                    shuffledCards.Add(cards[randIndex]);
                    cards.RemoveAt(randIndex);
                }

                cards = shuffledCards;
            }
        }

        public IEnumerable<string> GetCardNames()
        {
            string[] names = new string[Count];
            for (int i = 0; i < Count; i++)
            {
                names[i] = cards[i].Name;
            }
            return names;
        }

        public void Sort()
        {
            cards.Sort(new CardComparer_bySuit());
        }
    }
}
