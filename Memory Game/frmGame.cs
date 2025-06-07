using Memory_Game.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Game
{
    public partial class frmGame: Form
    {
        public frmGame(frmMain frmMain) {
            InitializeComponent();
            InitializeButtons();
            _frmMain = frmMain;
        }
        private frmMain _frmMain;

        private byte CountClick = 0;
        private const byte InitialGameTime = 50;
        private byte gameTime = InitialGameTime;
        private const byte Rows = 4;
        private const byte Columns = 4;
        private const byte TotalButtons = Rows * Columns;

        private Button firstButtonClicked;
        private Button secondButtonClicked;

        private Button[,] arrButtons;

        private Random rng = new Random();

        private void InitializeButtons() {
            arrButtons = new Button[Rows, Columns]  {
                {button1, button2, button3, button4},
                { button5, button6, button7, button8},
                { button9, button10, button11, button12},
                { button13, button14, button15, button16},
            };
        }

        Dictionary <string, Image> imageMapping = new Dictionary<string, Image> {
            { "elephant", Resources.elephant },
            { "hedgehog", Resources.hedgehog },
            { "octopus", Resources.octopus },
            { "turtle", Resources.turtle },
            { "lion", Resources.lion },
            { "giraffe", Resources.giraffe },
            { "fox", Resources.fox },
            { "cow", Resources.cow }
        };

        private void SetImageOfButton(Button btn) {
            if (imageMapping.ContainsKey(btn.Tag.ToString())) 
                btn.BackgroundImage = imageMapping[btn.Tag.ToString()];
        }

        private bool IsSimilarImage(Button btn1, Button btn2) {
            return btn1.Tag.ToString() == btn2.Tag.ToString();
        }

        private void ResetButtons() {
            foreach (Button button in arrButtons) {
                button.Visible = true;
                button.Enabled = true;
                button.BackgroundImage = Resources.question_mark_96;
                button.Tag = "?";
            }
        }

        private bool IsPlayerWin() {
            return arrButtons.Cast<Button>().All(b => !b.Visible);
        }

        //private void FisherYatesShuffle<T>(List<T> list) {
        //    int n = list.Count;
        //    while (n > 1) {
        //        n--;
        //        int k = rng.Next(n + 1);
        //        T value = list[k];
        //        list[k] = list[n];
        //        list[n] = value;
        //    }
        //}

        int RandomNumbers(int From, int To) {
            return rng.Next(From, To + 1);
        }

        private void Swap<T>(List<T> list, int index1, int index2) {
            T temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }

        private void ShuffleList<T>(List<T> list) {
            for (int i = 0; i < list.Count; i++) {
                //int j = RandomNumbers(1, list.Count) - 1;
                //int k = RandomNumbers(1, list.Count) - 1;
                //T value1 = list[RandomNumbers(1, list.Count) - 1];
                //T value2 = list[RandomNumbers(1, list.Count) - 1];
                //Swap(ref value1, ref value2);

                Swap(list, RandomNumbers(1, list.Count) - 1, RandomNumbers(1, list.Count) - 1);
                //Swap(list.ElementAt<T>, list[RandomNumbers(1, list.Count) - 1]);
            }
        }

        private void SetTagsButtons() {
            List<string> tags = new List<string> {
                "elephant", "elephant", "hedgehog", "hedgehog", "octopus", "octopus",
                "turtle", "turtle", "lion", "lion", "giraffe", "giraffe", "fox", "fox",
                "cow", "cow"
            };

            //FisherYatesShuffle(tags);
            ShuffleList(tags);
            //tags = tags.OrderBy(x => Guid.NewGuid()).ToList(); // Shuffle cards

            List<Button> buttonList = new List<Button>();
            for (int i = 0; i < Rows; i++) {
                for (int j = 0; j < Columns; j++)
                    buttonList.Add(arrButtons[i, j]);
            }

            for (int i = 0; i < buttonList.Count; i++)
                buttonList[i].Tag = tags[i];
        }

        private void RestartGame() {
            timer1.Stop();
            ResetButtons();
            SetTagsButtons();
            gameTime = InitialGameTime;
            timer1.Start();
        }

        private void ShowWinMessage() {
            MessageBox.Show("You are win", "Win", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void HandleMatchImages(Button btn1, Button btn2) {
            btn1.Visible = false;
            btn2.Visible = false;
        }

        private void HandleNotMatchImages(Button btn1, Button btn2) {
            btn1.BackgroundImage = Resources.question_mark_96;
            btn2.BackgroundImage = Resources.question_mark_96;
        }

        private async Task HandleSecondClick() {
            await Task.Delay(1000);
            if (firstButtonClicked == secondButtonClicked) {
                firstButtonClicked.BackgroundImage = Resources.question_mark_96;
                return;
            }

            if (IsSimilarImage(firstButtonClicked, secondButtonClicked))
                HandleMatchImages(firstButtonClicked, secondButtonClicked);
            else
                HandleNotMatchImages(firstButtonClicked, secondButtonClicked);
        }

        private async void HandleButtonClick(Button clickedButton) {
            switch (CountClick) {
                case 1:
                    SetImageOfButton(clickedButton);
                    firstButtonClicked = clickedButton;
                    break;
                case 2:
                    SetImageOfButton(clickedButton);
                    secondButtonClicked = clickedButton;
                    await HandleSecondClick();
                    CountClick = 0;
                    break;
            }
            if (IsPlayerWin()) { EndGame(); ShowWinMessage(); }
        }

        private void DisableAllButtons() {
            foreach (Button button in arrButtons)
                button.Enabled = false;
        }

        private void ShowGameOver() {
            MessageBox.Show("Game Over", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EndGame() {
            timer1.Stop();
            gameTime = InitialGameTime;
            ShowGameOver();
        }

        private void CountGameTime() {
            byte remainingTime = gameTime;
            lblTimeValue.Text = remainingTime.ToString();

            gameTime--;

            if (remainingTime == 0) {
                lblTimeValue.Text = "0";
                EndGame();
                MessageBox.Show("You are Lost", "Lose", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DisableAllButtons();
            }
        }

        private void frmGame_Load(object sender, EventArgs e){
            SetTagsButtons();
            timer1.Start();
        }

        private void button_Click(object sender, EventArgs e) {
            CountClick++;
            HandleButtonClick(((Button)sender));
        }

        private void btnRestartGame_Click(object sender, EventArgs e) {
            RestartGame();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            CountGameTime();
        }

        private void frmGame_FormClosing(object sender, FormClosingEventArgs e) {
            timer1.Stop();
            _frmMain.Show();
        }
    }
}
