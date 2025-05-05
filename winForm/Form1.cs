namespace winForm
{
    public partial class Form1 : Form
    {
        Dictionary<int, Label[]> PlrLabels = new Dictionary<int, Label[]>();

        private int round = 0;
        private int betAmount = 1;
        private int currentMoney = 100;
        private int playersCount = 0;
        private const int playerPointsToStop = 16;
        Button[] buttons = new Button[4];

        //Dealer
        Player dealer;

        List<Player> players = new(4);





        private void EnablePlayers(int plrCount)
        {



            foreach (Player plr in players)
            {
                plr.EnableDisableLabelsAndButtons();

            }
            dealer.EnableDisableLabelsAndButtons();



        }
        private void EnableDisableGame(bool enable, int playerAmount = 0)
        {



            if (playerAmount > 0)
            {
                EnablePlayers(playerAmount);

                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;

            }


        }
        Deck deck = new(false);
        public Form1()
        {
            InitializeComponent();
            PlrLabels.Add(1, [label6, label7, label8]);
            PlrLabels.Add(2, [label3, label4, label5]);
            PlrLabels.Add(3, [label2, PlayerPoints, PlayerCards]);
            PlrLabels.Add(4, [label9, label10, label11]);




        }

        private void ChangeMoney(double changeTo)
        {
            DealerMoney.Text = $"Money: {changeTo}";

        }


        private Card PullNewCard(bool isPlayer)
        {
            return new Card();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            EnableDisableGame(false);
            ChangeMoney(currentMoney);

            Player theDealer = new Player(label1, DealerPoints, DealerCards, button8);
            dealer = theDealer;

        }




        private void AddPlayers(int playerCount)
        {
            buttons[0] = button6;
            buttons[1] = button5;
            buttons[2] = button12;
            buttons[3] = button7;
            for (int i = 1; i < playerCount + 1; i++)
            {
                Player player = new(PlrLabels[i][0], PlrLabels[i][1], PlrLabels[i][2], buttons[i - 1]);
                players.Add(player);


            }
            EnableDisableGame(true, playerCount);

        }





        //Pull card button




        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPlayers(1);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddPlayers(4);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddPlayers(3);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AddPlayers(2);
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void PlayerPoints_Click(object sender, EventArgs e)
        {

        }

        private void PlayerCards_Click(object sender, EventArgs e)
        {

        }
        private void PullCard(int plr)
        {
            if (plr == 0)
            {
                if (dealer.PointsPulled < 21)
                {

                    dealer.PullCard(deck);
                }

            }
            else if (players[plr - 1].PointsPulled < 21)
            {
                players[plr - 1].PullCard(deck); ;

            }

        }
        private void button6_Click(object sender, EventArgs e)
        {
            //plr 1
            PullCard(1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //plr 2
            PullCard(2);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //plr 3
            PullCard(3);

        }
        private void button7_Click(object sender, EventArgs e)
        {
            //plr 4
            PullCard(4);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Dealer
            PullCard(0);
        }
        private int[] CheckWinners()
        {
            int dealerPoints = (21-dealer.PointsPulled);
            List<int> plrsWon = new();

           for(int i = 0; i < players.Count; i++)
            {
                if (players[i].PointsPulled <= 21 && 21 - players[i].PointsPulled < dealerPoints || dealerPoints < 0 && players[i].PointsPulled <= 21)
                {
                 
                    plrsWon.Add(i+1);

                }

            }
            return plrsWon.ToArray();

        }
        private void button9_Click(object sender, EventArgs e)
        {
            label12.Visible = true;

            int[] wonPlayers = CheckWinners();

            foreach (Player plr in players)
            {
                plr.ResetCardsPulled();

            }
            dealer.ResetCardsPulled();
            
            if(wonPlayers.Length == 0)
            {
                label12.Text = "Dealer won";

            }
            else
            {
                string wonText = "";
                foreach(int i in wonPlayers)
                {
                    wonText += $"Player {i} Won!\n";

                }

                label12.Text = wonText;

            }
        }
    }
}
