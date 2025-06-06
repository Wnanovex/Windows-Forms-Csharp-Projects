using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Math_Quiz_Game
{
    public partial class frmGame: Form
    {
        public frmGame(enQuestionsLevel QuestionsLevel, enOperationType OperationType, short NumOfQuestions) {
            InitializeComponent();
            _QuestionsLevel = QuestionsLevel;
            _OperationType = OperationType;
            _NumOfQuestions = NumOfQuestions;
        }

        public enum enQuestionsLevel { Easy = 1, Med = 2, Hard = 3, Mix = 4 };
        public enum enOperationType { Add = 1, Subtract = 2, Multiply = 3, Divide = 4, Mix = 5 };

        enQuestionsLevel _QuestionsLevel;
        enOperationType _OperationType;
        short _NumOfQuestions;

        public struct stQuestion {
            public int Number1, Number2;
            public enOperationType OperationType;
            public enQuestionsLevel QuestionLevel;
            public int CorrectAnswer, PlayerAnswer;
            public bool AnswerResult;
        };

        public struct stQuiz {
            public stQuestion[] QuestionsList;
            public short NumOfQuestions, NumOfRightAnswers, NumOfWrongAnswers;
            public enQuestionsLevel QuestionsLevel;
            public enOperationType OpType;
            public float PercentageResults;
            public bool IsPass;
        };
        private stQuiz Quiz = new stQuiz();

        private short currentQuestion = 1;

        private short EasyLevelTime = 20;
        private short MedLevelTime = 15;
        private short HardLevelTime = 10;

        Random rdm = new Random();

        private void ResetQuizData() {
            Quiz.QuestionsList = new stQuestion[_NumOfQuestions];
            Quiz.NumOfQuestions = _NumOfQuestions;
            Quiz.NumOfRightAnswers = 0;
            Quiz.NumOfWrongAnswers = 0;
            Quiz.QuestionsLevel = _QuestionsLevel;
            Quiz.OpType = _OperationType;
            Quiz.IsPass = false;
        }

        string GetOptTypeSymbol(enOperationType OperationType) {
            switch (OperationType) {
                case enOperationType.Add:
                    return "+";
                case enOperationType.Subtract:
                    return "-";
                case enOperationType.Multiply:
                    return "*";
                case enOperationType.Divide:
                    return "/";
                default:
                    return "Mix";
            }
        }

        int RandomNumbers(int From, int To) {
            return rdm.Next(From, To);
        }

        private int GetRandomNumberBasedOnLevel(enQuestionsLevel level) {
            switch (level) {
                case enQuestionsLevel.Easy: return RandomNumbers(1, 10);
                case enQuestionsLevel.Med: return RandomNumbers(10, 100);
                case enQuestionsLevel.Hard: return RandomNumbers(100, 1000);
                default: return RandomNumbers(1, 1000);
            }
        }

        enOperationType GetRandomOperationType() {
            int Opt = RandomNumbers(1, 5);
            return (enOperationType)Opt;
        }

        int SimpleCalculator(int Num1, int Num2, enOperationType OperationType) {
            switch (OperationType) {
                case enOperationType.Add:
                    return Num1 + Num2;
                case enOperationType.Subtract:
                    return Num1 - Num2;
                case enOperationType.Multiply:
                    return Num1 * Num2;
                case enOperationType.Divide:
                    return Num1 / Num2;
                default:
                    return 0;
            }
        }

        stQuestion GenerateQuestion(enQuestionsLevel QuestionsLevel, enOperationType OpType) {
            stQuestion Question = new stQuestion();

            Question.QuestionLevel = QuestionsLevel == enQuestionsLevel.Mix ? (enQuestionsLevel)RandomNumbers(1, 4) : QuestionsLevel;
            Question.OperationType = OpType == enOperationType.Mix ? OpType = GetRandomOperationType() : OpType;
            Question.Number1 = GetRandomNumberBasedOnLevel(Question.QuestionLevel);
            Question.Number2 = GetRandomNumberBasedOnLevel(Question.QuestionLevel);
            Question.CorrectAnswer = SimpleCalculator(Question.Number1, Question.Number2, Question.OperationType);

            return Question;
        }

        void GenerateQuizzQuestions() {
            for (short Question = 0; Question < Quiz.QuestionsList.Length; Question++) {
                Quiz.QuestionsList[Question] = GenerateQuestion(Quiz.QuestionsLevel, Quiz.OpType);
                //MessageBox.Show($"Question {Question + 1}: {Quiz.QuestionsList[Question].Number1} {GetOptTypeSymbol(Quiz.QuestionsList[Question].OperationType)} {Quiz.QuestionsList[Question].Number2} = {Quiz.QuestionsList[Question].CorrectAnswer}");
            }
        }

        private void DisplayCurrentQuestion() {
            stQuestion Question = Quiz.QuestionsList[currentQuestion - 1];
            lblNumOfCurrentQuestion.Text = "Question " + currentQuestion.ToString();
            lblNumber1.Text = Question.Number1.ToString();
            lblNumber2.Text = Question.Number2.ToString();
            lblOpType.Text = GetOptTypeSymbol(Question.OperationType);
            lblQuestionLevelInfoValue.Text = Question.QuestionLevel.ToString();
            lblOperationTypeInfoValue.Text = Question.OperationType.ToString();
        }

        public void LoadForm() {
            currentQuestion = 1;
            ResetQuizData();
            lblRightAnswerValue.Text = Quiz.NumOfRightAnswers.ToString();
            lblWrongAnswerValue.Text = Quiz.NumOfWrongAnswers.ToString();
            textBox1.Focus();
            textBox1.Clear();

            btnNext.Enabled = false;
            btnCheck.Enabled = true;
            btnResults.Visible = false;
            timer1.Enabled = true;

            GenerateQuizzQuestions();

            DisplayCurrentQuestion();
        }

        private void CheckPlayerAnswer() {
            if (textBox1.Text == Quiz.QuestionsList[currentQuestion - 1].CorrectAnswer.ToString()) {
                Quiz.QuestionsList[currentQuestion - 1].AnswerResult = true;
                Quiz.NumOfRightAnswers++;
                MessageBox.Show("Your answer is Right :)", "Right", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else{
                Quiz.QuestionsList[currentQuestion - 1].AnswerResult = false;
                Quiz.NumOfWrongAnswers++;
                MessageBox.Show("Your answer is Wrong :(", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            pnlCorrectAnswer.Visible = true;

            lblCorrectAnswerValue.Text = Quiz.QuestionsList[currentQuestion - 1].CorrectAnswer.ToString();
            lblRightAnswerValue.Text = Quiz.NumOfRightAnswers.ToString();
            lblWrongAnswerValue.Text = Quiz.NumOfWrongAnswers.ToString();

            btnCheck.Enabled = false;
            btnNext.Enabled = true;
        }

        private void MoveToNextQuestion() {
            if (currentQuestion >= Quiz.NumOfQuestions) {
                btnResults.Visible = true;
                return;
            }

            currentQuestion++;
            textBox1.Text = "";
            textBox1.Focus();

            DisplayCurrentQuestion();

            btnCheck.Enabled = true;
            btnNext.Enabled = false;
            pnlCorrectAnswer.Visible = false;
            timer1.Enabled = true;
        }

        private short GetTimeForLevel(enQuestionsLevel QuestionsLevel) {
            switch (QuestionsLevel) {
                case enQuestionsLevel.Easy:
                    return EasyLevelTime;
                case enQuestionsLevel.Med:
                    return MedLevelTime;
                case enQuestionsLevel.Hard:
                    return HardLevelTime;
                default:
                    return 0;
            }
        }

        private void DecreaseTimeForLevel(enQuestionsLevel level) {
            switch (level) {
                case enQuestionsLevel.Easy:
                    EasyLevelTime--;
                    break;
                case enQuestionsLevel.Med:
                    MedLevelTime--;
                    break;
                case enQuestionsLevel.Hard:
                    HardLevelTime--;
                    break;
            }
        }

        private void ResetLevelTime(){
            EasyLevelTime = 20;
            MedLevelTime = 15;
            HardLevelTime = 10;
        }

        private void CountQuestionTime() {
            enQuestionsLevel currentQuestionLevel = Quiz.QuestionsList[currentQuestion - 1].QuestionLevel;
            short remainingTime = GetTimeForLevel(currentQuestionLevel);
            //switch (Quiz.QuestionsList[currentQuestion - 1].QuestionLevel) {
            //    case enQuestionsLevel.Easy:
            //        lblTimeValue.Text = EasyLevelTime.ToString();
            //        EasyLevelTime--;
            //        break;
            //    case enQuestionsLevel.Med:
            //        lblTimeValue.Text = MedLevelTime.ToString();
            //        MedLevelTime--;
            //        break;
            //    case enQuestionsLevel.Hard:
            //        lblTimeValue.Text = HardLevelTime.ToString();
            //        HardLevelTime--;
            //        break;
            //}

            lblTimeValue.Text = remainingTime.ToString();

            DecreaseTimeForLevel(currentQuestionLevel);

            // EasyLevelTime == 0 || MedLevelTime == 0 || HardLevelTime == 0
            if (remainingTime == 0) {
                lblTimeValue.Text = "0";
                timer1.Enabled = false;
                CheckPlayerAnswer();
                ResetLevelTime();
            }
        }

        private void ShowFinalResults() {
            Quiz.IsPass = (Quiz.NumOfRightAnswers >= Quiz.NumOfWrongAnswers);
            Quiz.PercentageResults = (100f / Quiz.NumOfQuestions) * Quiz.NumOfRightAnswers;
            this.Hide();
            Form FrmResults = new frmResults(Quiz, this);
            FrmResults.ShowDialog();
        }

        private void frmGame_Load(object sender, EventArgs e) {
            LoadForm();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) {
            // Allow control keys like backspace, delete, etc.
            if (char.IsControl(e.KeyChar))
                return;

            // Allow digits
            if (char.IsDigit(e.KeyChar))
                return;

            // Allow a decimal point, but only if there isn't already one in the text
            if (e.KeyChar == '.' && !textBox1.Text.Contains("."))
                return;

            // Allow a negative sign at the beginning only
            if (e.KeyChar == '-' && textBox1.SelectionStart == 0 && !textBox1.Text.Contains("-"))
                return;

            // Block the invalid characters
            e.Handled = true;
        }

        private void btnCheck_Click(object sender, EventArgs e) {
            timer1.Enabled = false;
            CheckPlayerAnswer();
            ResetLevelTime();
        }

        private void btnNext_Click(object sender, EventArgs e) {
            MoveToNextQuestion();
        }

        private void btnResults_Click(object sender, EventArgs e) {
            ShowFinalResults();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            CountQuestionTime();
        }

        private void frmGame_FormClosing(object sender, FormClosingEventArgs e) {
            timer1.Enabled = false;
            ResetLevelTime();
        }
    }
}
