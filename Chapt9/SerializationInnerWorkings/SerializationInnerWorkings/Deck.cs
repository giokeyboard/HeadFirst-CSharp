using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationInnerWorkings
{
    [Serializable]
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

        /// <summary>
        /// More human-readable version. Deals a card off he top of the deck
        /// </summary>
        public Card Deal()
        {
            return Deal(0);
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

        /// <summary>
        /// Take a peek at one of the cards in the deck without dealing it
        /// </summary>
        public Card Peek(int cardNumber)
        {
            return cards[cardNumber];
        }

        /// <summary>
        /// Searches through the deck for cards with a certain value
        /// </summary>
        public bool ContainsValue(Values value)
        {
            foreach (Card card in cards)
                if (card.Value == value)
                    return true;
            return false;
        }

        /// <summary>
        /// Looks for any cards that match a value, pulls them out of the deck, and returns a new deck with those
        /// </summary>
        public Deck PullOutValues(Values value)
        {
            Deck deckToReturn = new Deck(new Card[] { });
            for (int i = cards.Count - 1; i >= 0; i--)
                if (cards[i].Value == value)
                    deckToReturn.Add(Deal(i));
            return deckToReturn;
        }

        /// <summary>
        /// Checks a deck to see if it contains a book of four cards of whatever value was passed as the parameter
        /// </summary>
        public bool HasBook(Values value)
        {
            int NumberOfCards = 0;
            foreach (Card card in cards)
                if (card.Value == value)
                    NumberOfCards++;
            if (NumberOfCards == 4)
                return true;
            else
                return false;
        }

        public void SortByValue()
        {
            cards.Sort(new CardComparer_byValue());
        }
    }
}
