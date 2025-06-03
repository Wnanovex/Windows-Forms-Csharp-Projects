using Stone_Paper_Scissors_Game.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stone_Paper_Scissors_Game
{
    public partial class frmGame: Form
    {
        public frmGame(byte HowManyRounds) {
            InitializeComponent();
            _HowManyRounds = HowManyRounds;
        }

        private byte _HowManyRounds;

        enum enGameChoice { Stone = 1, Paper = 2, Scissors = 3 };
        enum enWinner { Player1 = 1, Computer = 2, Draw = 3 };

        struct stRoundInfo {
            public short RoundNumber;
            public enGameChoice Player1Choice;
            public enGameChoice ComputerChoice;
            public enWinner Winner;
            public string WinnerName;
        };
        stRoundInfo RoundInfo = new stRoundInfo();

        private struct stGameResults {
            public short Rounds, Player1Score, ComputerScore, DrawScore;
            public enWinner Winner;
            public string WinnerName;
        };
        stGameResults GameResults = new stGameResults();

        private byte CountRounds = 1;

        private void ResetRoundInfoAndGameResultsData() {
            RoundInfo.RoundNumber = 0;
            RoundInfo.Player1Choice = enGameChoice.Stone;
            RoundInfo.ComputerChoice = enGameChoice.Stone;
            RoundInfo.Winner = enWinner.Draw;
            RoundInfo.WinnerName = "";

            GameResults.Rounds = 0;
            GameResults.Player1Score = 0;
            GameResults.ComputerScore = 0;
            GameResults.DrawScore = 0;
            GameResults.Winner = enWinner.Draw;
            GameResults.WinnerName = "";
        }

        private void SetGameChoiceButtonsState(bool isEnabled) {
            btnStone.Enabled = isEnabled;
            btnPaper.Enabled = isEnabled;
            btnScissors.Enabled = isEnabled;
        }

        private enGameChoice GetPlayerChoiceFromClickedButton(Button btn) {
            switch (btn.Tag.ToString()) {
                case "Stone":
                    return enGameChoice.Stone;
                case "Paper":
                    return enGameChoice.Paper;
                case "Scissors":
                    return enGameChoice.Scissors;
            }
            return enGameChoice.Stone;
        }

        private static Random rnd = new Random();
        private enGameChoice GetComputerChoice() {
            return (enGameChoice)rnd.Next(1, 4);
        }

        private void UpdateChoiceImage(PictureBox pictureBox, enGameChoice choice) {
            switch (choice) {
                case enGameChoice.Stone:
                    pictureBox.BackgroundImage = Resources.stone;
                    break;
                case enGameChoice.Paper:
                    pictureBox.BackgroundImage = Resources.paper;
                    break;
                case enGameChoice.Scissors:
                    pictureBox.BackgroundImage = Resources.scissors;
                    break;
            }
        }

        private void UpdateChoiceImages() {
            UpdateChoiceImage(pbPlayer1Choice, RoundInfo.Player1Choice);
            UpdateChoiceImage(pbComputerChoice, RoundInfo.ComputerChoice);
        }

        private void ResetImagesPlayer1AndComputerChoices() {
            pbPlayer1Choice.BackgroundImage = Resources.question_mark_96;
            pbComputerChoice.BackgroundImage = Resources.question_mark_96;
        }

        private enWinner CheckWinnerInRound(stRoundInfo RoundInfo) {
            if (RoundInfo.Player1Choice == RoundInfo.ComputerChoice)
                return enWinner.Draw;

            switch (RoundInfo.Player1Choice) {
                case enGameChoice.Stone:
                    if (RoundInfo.ComputerChoice == enGameChoice.Paper)
                        return enWinner.Computer;
                    break;
                case enGameChoice.Paper:
                    if (RoundInfo.ComputerChoice == enGameChoice.Scissors)
                        return enWinner.Computer;
                    break;
                case enGameChoice.Scissors:
                    if (RoundInfo.ComputerChoice == enGameChoice.Stone)
                        return enWinner.Computer;
                    break;
            }
            return enWinner.Player1;
        }

        private string WinnerName(enWinner Winner) {
            string[] arrWinnersName = { "Player1", "Computer", "No Winner" };
            return arrWinnersName[(byte)Winner - 1];
        }

        private void CountScore() {
            switch (RoundInfo.Winner) {
                case enWinner.Player1:
                    GameResults.Player1Score++;
                    break;
                case enWinner.Computer:
                    GameResults.ComputerScore++;
                    break;
                case enWinner.Draw:
                    GameResults.DrawScore++;
                    break;
            }
        }

        private void UpdateLabelsRoundScore() {
            lblPlayer1Score.Text = GameResults.Player1Score.ToString();
            lblComputerScore.Text = GameResults.ComputerScore.ToString();
        }

        private enWinner ShowFinalWinner() {
            if (GameResults.Player1Score > GameResults.ComputerScore)
                return enWinner.Player1;
            else if (GameResults.Player1Score < GameResults.ComputerScore)
                return enWinner.Computer;
            else
                return enWinner.Draw;
        }

        private void ShowGameResultsCard() {
            pnlGameResultsCard.Visible = true;
            lblGameRoundsValue.Text = GameResults.Rounds.ToString();
            lblPlayerWonTimesValue.Text = GameResults.Player1Score.ToString();
            lblComputerWonTimesValue.Text = GameResults.ComputerScore.ToString();
            lblDrawTimesValue.Text = GameResults.DrawScore.ToString();
            lblFinalWinnerValue.Text = GameResults.WinnerName;
        }

        private void PlayRound(Button btn) {

            RoundInfo.Player1Choice = GetPlayerChoiceFromClickedButton(btn);
            RoundInfo.ComputerChoice = GetComputerChoice();
            UpdateChoiceImages();
            RoundInfo.Winner = CheckWinnerInRound(RoundInfo);
            RoundInfo.WinnerName = WinnerName(RoundInfo.Winner);
            MessageBox.Show(RoundInfo.WinnerName, "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ResetImagesPlayer1AndComputerChoices();
            CountScore();
            UpdateLabelsRoundScore();

            if(CountRounds == _HowManyRounds) {
                GameResults.Rounds = _HowManyRounds;
                GameResults.Winner = ShowFinalWinner();
                GameResults.WinnerName = WinnerName(GameResults.Winner);
                ShowGameResultsCard();
                SetGameChoiceButtonsState(false);
                MessageBox.Show("Game Over", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnPlayer1Choice_Click(object sender, EventArgs e) {
            if (CountRounds <= _HowManyRounds) {
                PlayRound((Button) sender);
                CountRounds++;
                if(CountRounds <= _HowManyRounds)
                    lblRound.Text = $"Round {CountRounds}";
            }
        }

        private void btnResetGame_Click(object sender, EventArgs e) {
            ResetRoundInfoAndGameResultsData();
            CountRounds = 1;
            lblRound.Text = "Round " + CountRounds.ToString();

            lblPlayer1Score.Text = "0";
            lblComputerScore.Text = "0";

            SetGameChoiceButtonsState(true);

            pnlGameResultsCard.Visible = false;
        }

        private void btnPlayNewGame_Click(object sender, EventArgs e) {
            this.Dispose();
        }

        private void GameForm_Load(object sender, EventArgs e) {
            ResetRoundInfoAndGameResultsData();
        }
    }
}
