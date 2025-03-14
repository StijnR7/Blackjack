using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winForm
{
    class Player
    {
        private bool isPlayer;
        private List<Card> cardsPulled = new();
        private int pointsPulled;
        public Player(bool isPlayer) { 
            this.IsPlayer = isPlayer;
        }
        private void AddPointsFromCard(Card card)
        {
            if (int.TryParse(card.Value, out _))
            {
                pointsPulled += int.Parse(card.Value);

            }
            else if (card.Value == "A") {
                pointsPulled += 11;
            }
            else {
                pointsPulled += 10;    
                }

        }
        public bool IsPlayer { get => isPlayer; set => isPlayer = value; }
        public int PointsPulled { get => pointsPulled; set => pointsPulled = value; }
        internal List<Card> CardsPulled { get => cardsPulled; set => cardsPulled = value; }

        public Card PullCard(Deck deck) { 
            Card newCard = deck.GetNewCard();
            AddPointsFromCard (newCard);
            cardsPulled.Add(newCard);
            return newCard;
        
        }
        public string GetCardsAsString() {
            string allCards = "";

            foreach (Card card in cardsPulled) {
                allCards += $"{card.Type} - {card.Value}\n";
            }
            return allCards;
            
        }
    }
}
