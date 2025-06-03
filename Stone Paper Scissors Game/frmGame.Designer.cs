namespace Stone_Paper_Scissors_Game
{
    partial class frmGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
            this.lblRound = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnScissors = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnStone = new System.Windows.Forms.Button();
            this.pbPlayer1Choice = new System.Windows.Forms.PictureBox();
            this.pbComputerChoice = new System.Windows.Forms.PictureBox();
            this.pnlGameResultsCard = new System.Windows.Forms.Panel();
            this.lblFinalWinnerValue = new System.Windows.Forms.Label();
            this.lblDrawTimesValue = new System.Windows.Forms.Label();
            this.lblComputerWonTimesValue = new System.Windows.Forms.Label();
            this.lblPlayerWonTimesValue = new System.Windows.Forms.Label();
            this.lblGameRoundsValue = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnResetGame = new System.Windows.Forms.Button();
            this.btnPlayNewGame = new System.Windows.Forms.Button();
            this.lblPlayer1Score = new System.Windows.Forms.Label();
            this.lblComputerScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1Choice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputerChoice)).BeginInit();
            this.pnlGameResultsCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Font = new System.Drawing.Font("Cascadia Mono", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblRound.Location = new System.Drawing.Point(637, 23);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(183, 52);
            this.lblRound.TabIndex = 17;
            this.lblRound.Text = "Round 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(905, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 42);
            this.label3.TabIndex = 13;
            this.label3.Text = "Computer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(419, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 42);
            this.label2.TabIndex = 12;
            this.label2.Text = "Player 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(687, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 68);
            this.label1.TabIndex = 11;
            this.label1.Text = "VS";
            // 
            // btnScissors
            // 
            this.btnScissors.BackgroundImage = global::Stone_Paper_Scissors_Game.Properties.Resources.scissors;
            this.btnScissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnScissors.ForeColor = System.Drawing.Color.Black;
            this.btnScissors.Location = new System.Drawing.Point(870, 463);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(141, 107);
            this.btnScissors.TabIndex = 16;
            this.btnScissors.Tag = "Scissors";
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnPlayer1Choice_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.BackgroundImage = global::Stone_Paper_Scissors_Game.Properties.Resources.paper;
            this.btnPaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPaper.ForeColor = System.Drawing.Color.Black;
            this.btnPaper.Location = new System.Drawing.Point(668, 463);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(141, 107);
            this.btnPaper.TabIndex = 15;
            this.btnPaper.Tag = "Paper";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPlayer1Choice_Click);
            // 
            // btnStone
            // 
            this.btnStone.BackgroundImage = global::Stone_Paper_Scissors_Game.Properties.Resources.stone;
            this.btnStone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStone.ForeColor = System.Drawing.Color.Black;
            this.btnStone.Location = new System.Drawing.Point(464, 463);
            this.btnStone.Name = "btnStone";
            this.btnStone.Size = new System.Drawing.Size(141, 107);
            this.btnStone.TabIndex = 14;
            this.btnStone.Tag = "Stone";
            this.btnStone.UseVisualStyleBackColor = true;
            this.btnStone.Click += new System.EventHandler(this.btnPlayer1Choice_Click);
            // 
            // pbPlayer1Choice
            // 
            this.pbPlayer1Choice.BackgroundImage = global::Stone_Paper_Scissors_Game.Properties.Resources.question_mark_96;
            this.pbPlayer1Choice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPlayer1Choice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPlayer1Choice.Location = new System.Drawing.Point(373, 175);
            this.pbPlayer1Choice.Name = "pbPlayer1Choice";
            this.pbPlayer1Choice.Size = new System.Drawing.Size(232, 203);
            this.pbPlayer1Choice.TabIndex = 18;
            this.pbPlayer1Choice.TabStop = false;
            this.pbPlayer1Choice.Tag = "?";
            // 
            // pbComputerChoice
            // 
            this.pbComputerChoice.BackgroundImage = global::Stone_Paper_Scissors_Game.Properties.Resources.question_mark_96;
            this.pbComputerChoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbComputerChoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbComputerChoice.Location = new System.Drawing.Point(870, 175);
            this.pbComputerChoice.Name = "pbComputerChoice";
            this.pbComputerChoice.Size = new System.Drawing.Size(232, 203);
            this.pbComputerChoice.TabIndex = 19;
            this.pbComputerChoice.TabStop = false;
            this.pbComputerChoice.Tag = "?";
            // 
            // pnlGameResultsCard
            // 
            this.pnlGameResultsCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGameResultsCard.Controls.Add(this.lblFinalWinnerValue);
            this.pnlGameResultsCard.Controls.Add(this.lblDrawTimesValue);
            this.pnlGameResultsCard.Controls.Add(this.lblComputerWonTimesValue);
            this.pnlGameResultsCard.Controls.Add(this.lblPlayerWonTimesValue);
            this.pnlGameResultsCard.Controls.Add(this.lblGameRoundsValue);
            this.pnlGameResultsCard.Controls.Add(this.label10);
            this.pnlGameResultsCard.Controls.Add(this.label9);
            this.pnlGameResultsCard.Controls.Add(this.label8);
            this.pnlGameResultsCard.Controls.Add(this.label7);
            this.pnlGameResultsCard.Controls.Add(this.label6);
            this.pnlGameResultsCard.Controls.Add(this.label5);
            this.pnlGameResultsCard.Location = new System.Drawing.Point(27, 33);
            this.pnlGameResultsCard.Name = "pnlGameResultsCard";
            this.pnlGameResultsCard.Size = new System.Drawing.Size(296, 415);
            this.pnlGameResultsCard.TabIndex = 20;
            this.pnlGameResultsCard.Visible = false;
            // 
            // lblFinalWinnerValue
            // 
            this.lblFinalWinnerValue.AutoSize = true;
            this.lblFinalWinnerValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalWinnerValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblFinalWinnerValue.Location = new System.Drawing.Point(162, 359);
            this.lblFinalWinnerValue.Name = "lblFinalWinnerValue";
            this.lblFinalWinnerValue.Size = new System.Drawing.Size(114, 25);
            this.lblFinalWinnerValue.TabIndex = 10;
            this.lblFinalWinnerValue.Text = "No Winner";
            // 
            // lblDrawTimesValue
            // 
            this.lblDrawTimesValue.AutoSize = true;
            this.lblDrawTimesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrawTimesValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblDrawTimesValue.Location = new System.Drawing.Point(151, 292);
            this.lblDrawTimesValue.Name = "lblDrawTimesValue";
            this.lblDrawTimesValue.Size = new System.Drawing.Size(24, 25);
            this.lblDrawTimesValue.TabIndex = 9;
            this.lblDrawTimesValue.Text = "0";
            // 
            // lblComputerWonTimesValue
            // 
            this.lblComputerWonTimesValue.AutoSize = true;
            this.lblComputerWonTimesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerWonTimesValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblComputerWonTimesValue.Location = new System.Drawing.Point(233, 221);
            this.lblComputerWonTimesValue.Name = "lblComputerWonTimesValue";
            this.lblComputerWonTimesValue.Size = new System.Drawing.Size(24, 25);
            this.lblComputerWonTimesValue.TabIndex = 8;
            this.lblComputerWonTimesValue.Text = "0";
            // 
            // lblPlayerWonTimesValue
            // 
            this.lblPlayerWonTimesValue.AutoSize = true;
            this.lblPlayerWonTimesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerWonTimesValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblPlayerWonTimesValue.Location = new System.Drawing.Point(204, 153);
            this.lblPlayerWonTimesValue.Name = "lblPlayerWonTimesValue";
            this.lblPlayerWonTimesValue.Size = new System.Drawing.Size(24, 25);
            this.lblPlayerWonTimesValue.TabIndex = 7;
            this.lblPlayerWonTimesValue.Text = "0";
            // 
            // lblGameRoundsValue
            // 
            this.lblGameRoundsValue.AutoSize = true;
            this.lblGameRoundsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameRoundsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblGameRoundsValue.Location = new System.Drawing.Point(183, 87);
            this.lblGameRoundsValue.Name = "lblGameRoundsValue";
            this.lblGameRoundsValue.Size = new System.Drawing.Size(24, 25);
            this.lblGameRoundsValue.TabIndex = 6;
            this.lblGameRoundsValue.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 359);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 25);
            this.label10.TabIndex = 5;
            this.label10.Text = "Final Winner:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "Draw times:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Computer won times:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Player won times:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Game Rounds:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(62, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Game Results";
            // 
            // btnResetGame
            // 
            this.btnResetGame.BackColor = System.Drawing.Color.Transparent;
            this.btnResetGame.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnResetGame.FlatAppearance.BorderSize = 2;
            this.btnResetGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetGame.ForeColor = System.Drawing.Color.Red;
            this.btnResetGame.Location = new System.Drawing.Point(54, 492);
            this.btnResetGame.Name = "btnResetGame";
            this.btnResetGame.Size = new System.Drawing.Size(224, 47);
            this.btnResetGame.TabIndex = 21;
            this.btnResetGame.Text = "Reset Game";
            this.btnResetGame.UseVisualStyleBackColor = false;
            this.btnResetGame.Click += new System.EventHandler(this.btnResetGame_Click);
            // 
            // btnPlayNewGame
            // 
            this.btnPlayNewGame.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayNewGame.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPlayNewGame.FlatAppearance.BorderSize = 2;
            this.btnPlayNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayNewGame.ForeColor = System.Drawing.Color.Red;
            this.btnPlayNewGame.Location = new System.Drawing.Point(54, 566);
            this.btnPlayNewGame.Name = "btnPlayNewGame";
            this.btnPlayNewGame.Size = new System.Drawing.Size(224, 47);
            this.btnPlayNewGame.TabIndex = 22;
            this.btnPlayNewGame.Text = "Play New Game";
            this.btnPlayNewGame.UseVisualStyleBackColor = false;
            this.btnPlayNewGame.Click += new System.EventHandler(this.btnPlayNewGame_Click);
            // 
            // lblPlayer1Score
            // 
            this.lblPlayer1Score.AutoSize = true;
            this.lblPlayer1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Score.Location = new System.Drawing.Point(468, 127);
            this.lblPlayer1Score.Name = "lblPlayer1Score";
            this.lblPlayer1Score.Size = new System.Drawing.Size(24, 25);
            this.lblPlayer1Score.TabIndex = 23;
            this.lblPlayer1Score.Text = "0";
            // 
            // lblComputerScore
            // 
            this.lblComputerScore.AutoSize = true;
            this.lblComputerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerScore.Location = new System.Drawing.Point(970, 127);
            this.lblComputerScore.Name = "lblComputerScore";
            this.lblComputerScore.Size = new System.Drawing.Size(24, 25);
            this.lblComputerScore.TabIndex = 24;
            this.lblComputerScore.Text = "0";
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1157, 636);
            this.Controls.Add(this.lblComputerScore);
            this.Controls.Add(this.lblPlayer1Score);
            this.Controls.Add(this.btnPlayNewGame);
            this.Controls.Add(this.btnResetGame);
            this.Controls.Add(this.pnlGameResultsCard);
            this.Controls.Add(this.pbComputerChoice);
            this.Controls.Add(this.pbPlayer1Choice);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnStone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stone Paper Scissors Game";
            this.Load += new System.EventHandler(this.GameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1Choice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputerChoice)).EndInit();
            this.pnlGameResultsCard.ResumeLayout(false);
            this.pnlGameResultsCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnStone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbPlayer1Choice;
        private System.Windows.Forms.PictureBox pbComputerChoice;
        private System.Windows.Forms.Panel pnlGameResultsCard;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFinalWinnerValue;
        private System.Windows.Forms.Label lblDrawTimesValue;
        private System.Windows.Forms.Label lblComputerWonTimesValue;
        private System.Windows.Forms.Label lblPlayerWonTimesValue;
        private System.Windows.Forms.Label lblGameRoundsValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnResetGame;
        private System.Windows.Forms.Button btnPlayNewGame;
        private System.Windows.Forms.Label lblPlayer1Score;
        private System.Windows.Forms.Label lblComputerScore;
    }
}