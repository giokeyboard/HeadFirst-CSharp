﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoFishGame
{
    class Player
    {
        private string name;
        public string Name { get { return name; } }
        private Random random;
        private Deck cards;
        private TextBox textBoxOnForm;
        public Player(String name, Random random, TextBox textBoxOnForm)
        {
            // The constructor for the Player class initializes four private fields, and then
            // adds a line to the TextBox control on the form that says, "Joe has just
            // joined the game"—but use the name in the private field, and don't forget to
            // add a line break at the end of every line you add to the TextBox.
            this.name = name;
            this.random = random;
            this.textBoxOnForm = textBoxOnForm;
            this.cards = new Deck(new Card[] { });
            this.textBoxOnForm.Text += $"{name} has just joined the game{Environment.NewLine}";
        }

        /// <summary>
        /// Checks books in a player's own deck and removes the book from the player's cards
        /// </summary>
        public IEnumerable<Values> PullOutBooks()
        {
            List<Values> books = new List<Values>();
            for (int i = 1; i <= 13; i++)
            {
                Values value = (Values)i;
                int howMany = 0;
                for (int card = 0; card < cards.Count; card++)
                    if (cards.Peek(card).Value == value)
                        howMany++;
                if (howMany == 4)
                {
                    books.Add(value);
                    cards.PullOutValues(value);
                }
            }
            return books;
        }

        /// <summary>
        /// Gets a random value from a player's cards
        /// </summary>
        public Values GetRandomValue()
        {
            // This method gets a random value—but it has to be a value that's in the deck!
            Card randomCard = cards.Peek(random.Next(cards.Count));
            return randomCard.Value;
        }

        /// <summary>
        /// Pulls out all cards with a certain value from a player's deck
        /// </summary>
        public Deck DoYouHaveAny(Values value)
        {
            // This is where an opponent asks if I have any cards of a certain value
            // Use Deck.PullOutValues() to pull out the values. Add a line to the TextBox
            // that says, "Joe has 3 sixes"—use the new Card.Plural() static method
            Deck cardsIHave = cards.PullOutValues(value);
            textBoxOnForm.Text += $"{name} has {cardsIHave.Count} {Card.Plural(value)}{Environment.NewLine}";
            return cardsIHave;
        }

        /// <summary>
        /// Ask for a random value from the deck
        /// </summary>
        public void AskForACard(List<Player> players, int myIndex, Deck stock)
        {
            // Here's an overloaded version of AskForACard()—choose a random value
            // from the deck using GetRandomValue() and ask for it using AskForACard()
            if (stock.Count > 0)
            {
                if (cards.Count == 0) { cards.Add(stock.Deal()); }
                AskForACard(players, myIndex, stock, GetRandomValue());
            }

        }

        /// <summary>
        /// Asks other players if they have a value, otherwise deal cards from stock
        /// </summary>
        /// <param name="players">Other players to ask cards from</param>
        /// <param name="myIndex">Current player index</param>
        /// <param name="stock">The pile of cards that’s left after everyone’s dealt a hand</param>
        /// <param name="value">Value the current player asks to other players</param>
        public void AskForACard(List<Player> players, int myIndex, Deck stock, Values value)
        {
            // Ask the other players for a value. First add a line to the TextBox: "Joe asks
            // if anyone has a Queen". Then go through the list of players that was passed in
            // as a parameter and ask each player if he has any of the value (using his
            // DoYouHaveAny() method). He'll pass you a deck of cards—add them to my deck.
            // Keep track of how many cards were added. If there weren't any, you'll need
            // to deal yourself a card from the stock (which was also passed as a parameter),
            // and you'll have to add a line to the TextBox: "Joe had to draw from the stock"
            textBoxOnForm.Text += $"{name} asks if anyone has a {value}{Environment.NewLine}";
            int totalCardsGiven = 0;
            for (int i = 0; i < players.Count; i++) // Iterate through each player
            {
                if (i != myIndex)   // It's not myself
                {
                    Deck cardsGiven = players[i].DoYouHaveAny(value);
                    totalCardsGiven += cardsGiven.Count;
                    for (int j = 0; j < cardsGiven.Count; j++)  // Take from other player's, put in my deck
                    {
                        cards.Add(cardsGiven.Deal());
                    }
                }
            }
            if (totalCardsGiven == 0)   // No other player had the requested value
            {
                textBoxOnForm.Text += $"{name} had to draw from the stock{Environment.NewLine}";
                TakeCard(stock.Deal());
            }
        }

        // Here's a property and a few short methods that were already written for you
        public int CardCount { get { return cards.Count; } }
        public void TakeCard(Card card) { cards.Add(card); }
        public IEnumerable<string> GetCardNames() { return cards.GetCardNames(); }
        public Card Peek(int cardNumber) { return cards.Peek(cardNumber); }
        public void SortHand() { cards.SortByValue(); }
    }
}
