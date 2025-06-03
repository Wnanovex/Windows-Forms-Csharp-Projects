using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Game.Properties;

namespace Tic_Tac_Toe_Game
{
    public partial class frmGame: Form
    {
        public frmGame(enPlayingWith playingWith) {
            InitializeComponent();
            PlayingWith = playingWith;
            InitializeListButtons();
        }

        List<Button> ListButtons;

        private void InitializeListButtons() {
            ListButtons = new List<Button>() { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
        }

        private void Form1_Paint(object sender, PaintEventArgs e) {
            Color White = Color.FromArgb(255, 255, 255, 255);

            Pen Pen = new Pen(White);
            Pen.Width = 10;

            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            //e.Graphics.DrawLine(Pen, 400, 100, 400, 400);
            //e.Graphics.DrawLine(Pen, 550, 100, 550, 400);
            //e.Graphics.DrawLine(Pen, 280, 200, 670, 200);
            //e.Graphics.DrawLine(Pen, 280, 310, 670, 310);

            e.Graphics.DrawLine(Pen, 610, 130, 610, 650);
            e.Graphics.DrawLine(Pen, 820, 130, 820, 650);
            e.Graphics.DrawLine(Pen, 400, 313, 1030, 313);
            e.Graphics.DrawLine(Pen, 400, 478, 1030, 478);
        }

        public enum enPlayingWith { Player2, Computer };
        enPlayingWith PlayingWith;

        enum enPlayerTurn { Player1, Player2, Computer };
        enPlayerTurn PlayerTurn = enPlayerTurn.Player1;

        enum enWinner { Player1, Player2, Computer, Draw, GameInProgress };

        struct stGameStatus {
            public enWinner Winner;
            public bool GameOver;
            public byte PlayCount;
        }
        stGameStatus GameStatus = new stGameStatus();

        Random rdm = new Random();

        private void ResetButton(Button btn) {
            btn.Image = Resources.question_mark_96;
            btn.BackColor = Color.Transparent;
            btn.Tag = "?";
        }

        private void RestartGame() {
            ResetButton(button1);
            ResetButton(button2);
            ResetButton(button3);
            ResetButton(button4);
            ResetButton(button5);
            ResetButton(button6);
            ResetButton(button7);
            ResetButton(button8);
            ResetButton(button9);

            lblTurnValue.Text = "Player 1";
            lblWinnerValue.Text = "In Progress";
            GameStatus.Winner = enWinner.GameInProgress;
            GameStatus.PlayCount = 0;
            GameStatus.GameOver = false;
            PlayerTurn = enPlayerTurn.Player1;
            InitializeListButtons();
        }

        private void EndGame() {
            lblTurnValue.Text = "Game Over";
            switch (GameStatus.Winner) {
                case enWinner.Player1:
                    lblWinnerValue.Text = "Player 1";
                    break;
                case enWinner.Player2:
                    lblWinnerValue.Text = "Player 2";
                    break;
                case enWinner.Computer:
                    lblWinnerValue.Text = "Computer";
                    break;
                case enWinner.Draw:
                    lblWinnerValue.Text = "Draw";
                    break;
            }
            MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool CheckValue(Button btn1, Button btn2, Button btn3) {
            if(btn1.Tag.ToString() != "?" && btn1.Tag.ToString() == btn2.Tag.ToString() && btn1.Tag.ToString() == btn3.Tag.ToString()) {
                btn1.BackColor = Color.GreenYellow;
                btn2.BackColor = Color.GreenYellow;
                btn3.BackColor = Color.GreenYellow;

                if(btn1.Tag.ToString() == "X") {
                    GameStatus.GameOver = true;
                    GameStatus.Winner = enWinner.Player1;
                    EndGame();
                    return true;
                }else{
                    GameStatus.GameOver = true;
                    if (PlayingWith == enPlayingWith.Computer)
                        GameStatus.Winner = enWinner.Computer;
                    else 
                        GameStatus.Winner = enWinner.Player2;
                    EndGame();
                    return true;
                }

            }
            GameStatus.GameOver = false;

            return false;
        }

        private void CheckWinner() {
            if (CheckValue(button1, button2, button3)) return;
            if (CheckValue(button4, button5, button6)) return;
            if (CheckValue(button7, button8, button9)) return;
            if (CheckValue(button1, button4, button7)) return;
            if (CheckValue(button2, button5, button8)) return;
            if (CheckValue(button3, button6, button9)) return;
            if (CheckValue(button1, button5, button9)) return;
            if (CheckValue(button3, button5, button7)) return;
        }

        private async void HandleComputerChoice() {
            await Task.Delay(1000);
            if (ListButtons.Count > 0) {
                int index = rdm.Next(ListButtons.Count);
                Button btnChoiceComputer = ListButtons[index];
                btnChoiceComputer.Image = Resources.O;
                btnChoiceComputer.Tag = "O";

                PlayerTurn = enPlayerTurn.Player1;
                lblTurnValue.Text = "Player 1";
                GameStatus.PlayCount++;
                CheckWinner();

                ListButtons.Remove(btnChoiceComputer);
            }
        }

        private void SelectChoiceOfPlayer(Button btn) {
            if (GameStatus.GameOver) return;

            if (btn.Tag.ToString() == "?") {
                switch (PlayerTurn) {
                    case enPlayerTurn.Player1:
                        btn.Image = Resources.X;
                        GameStatus.PlayCount++;
                        btn.Tag = "X";
                        CheckWinner();
                        if(PlayingWith == enPlayingWith.Computer && !GameStatus.GameOver) {
                            PlayerTurn = enPlayerTurn.Computer;
                            lblTurnValue.Text = "Computer";
                            ListButtons.Remove(btn);
                            HandleComputerChoice();
                        }else {
                            PlayerTurn = enPlayerTurn.Player2;
                            lblTurnValue.Text = "Player 2";    
                        }
                        break;
                    case enPlayerTurn.Player2:
                        btn.Image = Resources.O;
                        PlayerTurn = enPlayerTurn.Player1;
                        lblTurnValue.Text = "Player 1";
                        GameStatus.PlayCount++;
                        btn.Tag = "O";
                        CheckWinner();
                        break;
                }
            }else {
                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(GameStatus.PlayCount == 9 && !GameStatus.GameOver) {
                GameStatus.GameOver = true;
                GameStatus.Winner = enWinner.Draw;
                EndGame();
            }
            
        }

        private void button_Click(object sender, EventArgs e) {
            SelectChoiceOfPlayer((Button) sender);
        }

        private void btnRestartGame_Click(object sender, EventArgs e) {
            RestartGame();
        }
    }
}
