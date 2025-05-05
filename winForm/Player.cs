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
        private Button GiveCardButton;
        
        private Label pointsLabel;
        private Label PulledCardsLabel;
        private Label playerLabel;
        public Player(Label playerLabel, Label pointsLabel, Label pulledCardsLabel, Button GiveCardButton, bool isPlayer = true) { 
            this.pointsLabel = pointsLabel;
            this.PulledCardsLabel = pulledCardsLabel;
            this.IsPlayer = isPlayer;

            this.GiveCardButton = GiveCardButton;
            this.playerLabel = playerLabel;
        }
        public void ResetCardsPulled()
        {
            PulledCardsLabel.Text = "0";
            pointsLabel.Text = "0";
            cardsPulled.Clear();
            pointsPulled = 0;

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
            pointsLabel.Text = pointsPulled.ToString();

        }
  
    
        public string GetCardsAsString() {
            string allCards = "";

            foreach (Card card in cardsPulled) {
                allCards += $"{card.Type} - {card.Value}\n";
            }
            return allCards;
            
        }
        public Card PullCard(Deck deck)
        {
            Card newCard = deck.GetNewCard();
            AddPointsFromCard(newCard);
            cardsPulled.Add(newCard);
            PulledCardsLabel.Text = GetCardsAsString();
            return newCard;

        }
        public void EnableDisableLabelsAndButtons() {
            pointsLabel.Visible = !pointsLabel.Visible;
            
            GiveCardButton.Visible = !GiveCardButton.Visible;
            PulledCardsLabel.Visible = !PulledCardsLabel.Visible;
            playerLabel.Visible = !playerLabel.Visible;

        }

       
        public bool IsPlayer { get => isPlayer; set => isPlayer = value; }
        public int PointsPulled { get => pointsPulled; set => pointsPulled = value; }
        internal List<Card> CardsPulled { get => cardsPulled; set => cardsPulled = value; }
        public Label PointsLabel { get => pointsLabel; set => pointsLabel = value; }
        public Label PulledCardsLabel1 { get => PulledCardsLabel; set => PulledCardsLabel = value; }

    }
}
