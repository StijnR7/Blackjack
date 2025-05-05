using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winForm
{
    class Deck
    {

        private string[] allTypes = { "Spades", "Clubs", "Hearts", "Diamonds" };
        private string[] allValues = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "K", "Q", "A", "J" };
        List<Card> cardsInDeck = new List<Card>();
        int cardAmount = 52;
        Random rand = new();
        public Deck(bool RandomDeck)
        {
            if (RandomDeck)
            {
                for (int i = 0; i < cardAmount; i++)
                {
                    cardsInDeck.Add(new Card());
                }

            }
            else { 
                foreach(string type in allTypes)
                {
                    foreach(string value in allValues)
                    {
                        cardsInDeck.Add(new Card(type, value));
                    }

                }
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
