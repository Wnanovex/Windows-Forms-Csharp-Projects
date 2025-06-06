using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Math_Quiz_Game.frmGame;

namespace Math_Quiz_Game
{
    public partial class frmResults: Form
    {
       
        public frmResults(stQuiz QuizGame, frmGame FrmGame) {
            InitializeComponent();
            Quiz = QuizGame;
            _FrmGame = FrmGame;
        }

        public static frmGame.stQuiz Quiz;
        frmGame _FrmGame;

        private void frmResults_Load(object sender, EventArgs e) {
            lblNumberOfQuestionsValue.Text = Quiz.NumOfQuestions.ToString();
            lblQuestionsLevelInfoValue.Text = Quiz.QuestionsLevel.ToString();
            lblOperationTypeInfoValue.Text = Quiz.OpType.ToString();
            lblRightAnswersValue.Text = Quiz.NumOfRightAnswers.ToString();
            lblWrongAnswersValue.Text = Quiz.NumOfWrongAnswers.ToString();
            if (Quiz.IsPass)
                lblIsPass.Text = Quiz.PercentageResults + "% PASS :)";
            else{
                lblIsPass.ForeColor = Color.Red;
                lblIsPass.Text = Quiz.PercentageResults + "% FAIL :(";
            }
        }

        private void btnPlayAgain_Click(object sender, EventArgs e) {
            this.Dispose();
            _FrmGame.Close();
        }

        private void btnResetGame_Click(object sender, EventArgs e) {   
            this.Dispose();
            _FrmGame.LoadForm();
            _FrmGame.Show();
        }

        private void frmResults_FormClosing(object sender, FormClosingEventArgs e) {
            _FrmGame.Show();
        }
    }
}
