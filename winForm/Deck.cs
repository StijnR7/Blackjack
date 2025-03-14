using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winForm
{
    class Deck
    {
        List<Card> cardsInDeck = new List<Card>();
        int cardAmount = 52;
        Random rand = new();
        public Deck()
        {
            for (int i = 0; i < cardAmount; i++)
            {
                cardsInDeck.Add(new Card());
            }
        }
        public Card GetNewCard()
        {
            return cardsInDeck[rand.Next(cardsInDeck.Count)];

        }
        public void ShowAllCards()
        {
            foreach (Card card in cardsInDeck)
            {
                Console.WriteLine($"{card.Type} {card.Value}");

            }
        }
    }
}
