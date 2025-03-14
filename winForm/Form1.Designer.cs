namespace winForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DealerMoney = new Label();
            PullCardButton = new Button();
            DealerCards = new Label();
            DealerPoints = new Label();
            PlayerCards = new Label();
            PlayerPoints = new Label();
            label1 = new Label();
            label2 = new Label();
            Won = new Label();
            SuspendLayout();
            // 
            // DealerMoney
            // 
            DealerMoney.AutoSize = true;
            DealerMoney.ForeColor = SystemColors.Control;
            DealerMoney.Location = new Point(1323, 25);
            DealerMoney.Name = "DealerMoney";
            DealerMoney.Size = new Size(106, 25);
            DealerMoney.TabIndex = 3;
            DealerMoney.Text = "Money: 100";
            DealerMoney.Click += label1_Click;
            // 
            // PullCardButton
            // 
            PullCardButton.Location = new Point(628, 642);
            PullCardButton.Name = "PullCardButton";
            PullCardButton.Size = new Size(178, 67);
            PullCardButton.TabIndex = 4;
            PullCardButton.Text = "Get new card";
            PullCardButton.UseVisualStyleBackColor = true;
            PullCardButton.Click += button2_Click;
            // 
            // DealerCards
            // 
            DealerCards.AutoSize = true;
            DealerCards.Font = new Font("Segoe UI", 15F);
            DealerCards.ForeColor = Color.Snow;
            DealerCards.Location = new Point(341, 164);
            DealerCards.Name = "DealerCards";
            DealerCards.Size = new Size(214, 41);
            DealerCards.TabIndex = 5;
            DealerCards.Text = "No card pulled";
            DealerCards.Click += label2_Click;
            // 
            // DealerPoints
            // 
            DealerPoints.AutoSize = true;
            DealerPoints.Font = new Font("Segoe UI", 15F);
            DealerPoints.ForeColor = Color.Snow;
            DealerPoints.Location = new Point(31, 25);
            DealerPoints.Name = "DealerPoints";
            DealerPoints.Size = new Size(221, 41);
            DealerPoints.TabIndex = 6;
            DealerPoints.Text = "Points pulled: 0";
            DealerPoints.Click += label3_Click;
            // 
            // PlayerCards
            // 
            PlayerCards.AutoSize = true;
            PlayerCards.Font = new Font("Segoe UI", 15F);
            PlayerCards.ForeColor = Color.Snow;
            PlayerCards.Location = new Point(867, 164);
            PlayerCards.Name = "PlayerCards";
            PlayerCards.Size = new Size(214, 41);
            PlayerCards.TabIndex = 7;
            PlayerCards.Text = "No card pulled";
            // 
            // PlayerPoints
            // 
            PlayerPoints.AutoSize = true;
            PlayerPoints.Font = new Font("Segoe UI", 15F);
            PlayerPoints.ForeColor = Color.Snow;
            PlayerPoints.Location = new Point(1036, 42);
            PlayerPoints.Name = "PlayerPoints";
            PlayerPoints.Size = new Size(221, 41);
            PlayerPoints.TabIndex = 8;
            PlayerPoints.Text = "Points pulled: 0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(373, 25);
            label1.Name = "label1";
            label1.Size = new Size(103, 41);
            label1.TabIndex = 9;
            label1.Text = "Dealer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(867, 42);
            label2.Name = "label2";
            label2.Size = new Size(98, 41);
            label2.TabIndex = 10;
            label2.Text = "Player";
            // 
            // Won
            // 
            Won.AutoSize = true;
            Won.Font = new Font("Segoe UI", 15F);
            Won.ForeColor = Color.Snow;
            Won.Location = new Point(678, 414);
            Won.Name = "Won";
            Won.Size = new Size(0, 41);
            Won.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(1459, 869);
            Controls.Add(Won);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PlayerPoints);
            Controls.Add(PlayerCards);
            Controls.Add(DealerPoints);
            Controls.Add(DealerCards);
            Controls.Add(PullCardButton);
            Controls.Add(DealerMoney);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label DealerMoney;
        private Button PullCardButton;
        private Label DealerCards;
        private Label DealerPoints;
        private Label PlayerCards;
        private Label PlayerPoints;
        private Label label1;
        private Label label2;
        private Label Won;
    }
}
