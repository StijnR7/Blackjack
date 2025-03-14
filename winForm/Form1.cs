namespace winForm
{
    public partial class Form1 : Form
    {

        private int round = 0;
        private int betAmount = 1;
        private int currentMoney = 100;

        private const int playerPointsToStop = 16;

        Player dealer = new(false);
        Player player = new(true);

        Deck deck = new();
        public Form1()
        {
            InitializeComponent();

        }

        private void ChangeMoney(double changeTo)
        {
            DealerMoney.Text = $"Money: {changeTo}";

        }
        private void ChangePointsPulled(Player plr)
        {
            if (plr.IsPlayer)
            {

                PlayerPoints.Text = $"Points pulled: {plr.PointsPulled}";
            }
            else {

                DealerPoints.Text = $"Points pulled: {plr.PointsPulled}";
            }
        }
        private void UpdatePulledCards(Player plr) {
            if (plr.IsPlayer)
            {
                PlayerCards.Text = plr.GetCardsAsString();
            }
            else { 
                DealerCards.Text = plr.GetCardsAsString();
            }


        }
        private Card PullNewCard(bool isPlayer) {
            return new Card();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
            ChangeMoney(currentMoney);
        }
       






        private void label1_Click(object sender, EventArgs e)
        {

        }
        private bool DidDealerWin() {
            int plrDiff = 21 - player.PointsPulled;
            int dealerDiff = 21 - dealer.PointsPulled;

            if (plrDiff < 0) { return true; }
            if (dealerDiff < 0) { return false; }
            if (dealerDiff < plrDiff) { return true; }
            if (dealerDiff == plrDiff) { return true; }
            else { return false; }

        }

        //Pull card button
        private void button2_Click(object sender, EventArgs e)
        {
            round++;
            if (round % 2 == 0 && round >= 2 && dealer.PointsPulled < 17)
            {
                //Dealers turn
                
                dealer.PullCard(deck);
                UpdatePulledCards(dealer);
                ChangePointsPulled(dealer);
            }
            else if(player.PointsPulled < playerPointsToStop)
            {
                //Players turn
                player.PullCard(deck);
                UpdatePulledCards(player);
                ChangePointsPulled(player);
            }
            if (dealer.PointsPulled >= 17 && player.PointsPulled >= playerPointsToStop) {
                if (DidDealerWin())
                {
                    Won.Text = "Dealer won!";
                }
                else { Won.Text = "Player won!"; }
            }
           
            
        }
            
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
