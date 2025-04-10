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
            button12 = new Button();
            DealerCards = new Label();
            DealerPoints = new Label();
            PlayerCards = new Label();
            PlayerPoints = new Label();
            label1 = new Label();
            label2 = new Label();
            Won = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button5 = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button6 = new Button();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            label12 = new Label();
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
            DealerMoney.Click += label2_Click;
            // 
            // button12
            // 
            button12.Location = new Point(890, 455);
            button12.Name = "button12";
            button12.Size = new Size(178, 67);
            button12.TabIndex = 4;
            button12.Text = "Give card";
            button12.UseVisualStyleBackColor = true;
            button12.Visible = false;
            button12.Click += button2_Click;
            // 
            // DealerCards
            // 
            DealerCards.AutoSize = true;
            DealerCards.Font = new Font("Segoe UI", 15F);
            DealerCards.ForeColor = Color.Snow;
            DealerCards.Location = new Point(308, 88);
            DealerCards.Name = "DealerCards";
            DealerCards.Size = new Size(214, 41);
            DealerCards.TabIndex = 5;
            DealerCards.Text = "No card pulled";
            DealerCards.Visible = false;
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
            DealerPoints.Visible = false;
            DealerPoints.Click += label3_Click;
            // 
            // PlayerCards
            // 
            PlayerCards.AutoSize = true;
            PlayerCards.Font = new Font("Segoe UI", 15F);
            PlayerCards.ForeColor = Color.Snow;
            PlayerCards.Location = new Point(1078, 481);
            PlayerCards.Name = "PlayerCards";
            PlayerCards.Size = new Size(214, 41);
            PlayerCards.TabIndex = 7;
            PlayerCards.Text = "No card pulled";
            PlayerCards.Visible = false;
            PlayerCards.Click += PlayerCards_Click;
            // 
            // PlayerPoints
            // 
            PlayerPoints.AutoSize = true;
            PlayerPoints.Font = new Font("Segoe UI", 15F);
            PlayerPoints.ForeColor = Color.Snow;
            PlayerPoints.Location = new Point(1089, 405);
            PlayerPoints.Name = "PlayerPoints";
            PlayerPoints.Size = new Size(221, 41);
            PlayerPoints.TabIndex = 8;
            PlayerPoints.Text = "Points pulled: 0";
            PlayerPoints.Visible = false;
            PlayerPoints.Click += PlayerPoints_Click;
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
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(946, 405);
            label2.Name = "label2";
            label2.Size = new Size(122, 41);
            label2.TabIndex = 10;
            label2.Text = "Player 3";
            label2.Visible = false;
            label2.Click += label2_Click_1;
            // 
            // Won
            // 
            Won.AutoSize = true;
            Won.Font = new Font("Segoe UI", 15F);
            Won.ForeColor = Color.Snow;
            Won.Location = new Point(653, 550);
            Won.Name = "Won";
            Won.Size = new Size(0, 41);
            Won.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(447, 609);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 12;
            button1.Text = "1 Player";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(579, 609);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 13;
            button2.Text = "2 Players";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(713, 609);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 14;
            button3.Text = "3 Players";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(852, 609);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 15;
            button4.Text = "4 Players";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(511, 405);
            label3.Name = "label3";
            label3.Size = new Size(122, 41);
            label3.TabIndex = 19;
            label3.Text = "Player 2";
            label3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.ForeColor = Color.Snow;
            label4.Location = new Point(654, 405);
            label4.Name = "label4";
            label4.Size = new Size(221, 41);
            label4.TabIndex = 18;
            label4.Text = "Points pulled: 0";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.ForeColor = Color.Snow;
            label5.Location = new Point(643, 481);
            label5.Name = "label5";
            label5.Size = new Size(214, 41);
            label5.TabIndex = 17;
            label5.Text = "No card pulled";
            label5.Visible = false;
            // 
            // button5
            // 
            button5.Location = new Point(455, 455);
            button5.Name = "button5";
            button5.Size = new Size(178, 67);
            button5.TabIndex = 16;
            button5.Text = "Give card";
            button5.UseVisualStyleBackColor = true;
            button5.Visible = false;
            button5.Click += button5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.ForeColor = Color.Snow;
            label6.Location = new Point(78, 405);
            label6.Name = "label6";
            label6.Size = new Size(122, 41);
            label6.TabIndex = 23;
            label6.Text = "Player 1";
            label6.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.ForeColor = Color.Snow;
            label7.Location = new Point(221, 405);
            label7.Name = "label7";
            label7.Size = new Size(221, 41);
            label7.TabIndex = 22;
            label7.Text = "Points pulled: 0";
            label7.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F);
            label8.ForeColor = Color.Snow;
            label8.Location = new Point(210, 481);
            label8.Name = "label8";
            label8.Size = new Size(214, 41);
            label8.TabIndex = 21;
            label8.Text = "No card pulled";
            label8.Visible = false;
            // 
            // button6
            // 
            button6.Location = new Point(22, 455);
            button6.Name = "button6";
            button6.Size = new Size(178, 67);
            button6.TabIndex = 20;
            button6.Text = "Give card";
            button6.UseVisualStyleBackColor = true;
            button6.Visible = false;
            button6.Click += button6_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15F);
            label9.ForeColor = Color.Snow;
            label9.Location = new Point(1379, 405);
            label9.Name = "label9";
            label9.Size = new Size(122, 41);
            label9.TabIndex = 27;
            label9.Text = "Player 4";
            label9.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15F);
            label10.ForeColor = Color.Snow;
            label10.Location = new Point(1530, 405);
            label10.Name = "label10";
            label10.Size = new Size(221, 41);
            label10.TabIndex = 26;
            label10.Text = "Points pulled: 0";
            label10.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15F);
            label11.ForeColor = Color.Snow;
            label11.Location = new Point(1519, 481);
            label11.Name = "label11";
            label11.Size = new Size(214, 41);
            label11.TabIndex = 25;
            label11.Text = "No card pulled";
            label11.Visible = false;
            // 
            // button7
            // 
            button7.Location = new Point(1323, 455);
            button7.Name = "button7";
            button7.Size = new Size(178, 67);
            button7.TabIndex = 24;
            button7.Text = "Give card";
            button7.UseVisualStyleBackColor = true;
            button7.Visible = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(49, 88);
            button8.Name = "button8";
            button8.Size = new Size(178, 67);
            button8.TabIndex = 28;
            button8.Text = "Give card";
            button8.UseVisualStyleBackColor = true;
            button8.Visible = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(1317, 66);
            button9.Name = "button9";
            button9.Size = new Size(112, 34);
            button9.TabIndex = 29;
            button9.Text = "Done";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 15F);
            label12.ForeColor = Color.Snow;
            label12.Location = new Point(675, 88);
            label12.Name = "label12";
            label12.Size = new Size(0, 41);
            label12.TabIndex = 30;
            label12.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(1778, 1044);
            Controls.Add(label12);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(button7);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(button6);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Won);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PlayerPoints);
            Controls.Add(PlayerCards);
            Controls.Add(DealerPoints);
            Controls.Add(DealerCards);
            Controls.Add(button12);
            Controls.Add(DealerMoney);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label DealerMoney;
        private Button button12;
        private Label DealerCards;
        private Label DealerPoints;
        private Label PlayerCards;
        private Label PlayerPoints;
        private Label label1;
        private Label label2;
        private Label Won;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button6;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label label12;
    }
}
