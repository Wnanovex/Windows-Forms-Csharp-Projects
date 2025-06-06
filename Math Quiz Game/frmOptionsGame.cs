using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Quiz_Game
{
    public partial class frmOptionsGame: Form
    {
        public frmOptionsGame(Form FrmMain)
        {
            InitializeComponent();
            _FrmMain = FrmMain;
        }
        private Form _FrmMain;
        private frmGame.enQuestionsLevel _selectedLevel;
        private frmGame.enOperationType _selectedOperation;
        private short _numOfQuestions;

        private void CheckSelectedLevel() {
            switch (cbLevel.Text) {
                case "Easy":
                    _selectedLevel = frmGame.enQuestionsLevel.Easy;
                    break;
                case "Medium":
                    _selectedLevel = frmGame.enQuestionsLevel.Med;
                    break;
                case "Hard":
                    _selectedLevel = frmGame.enQuestionsLevel.Hard;
                    break;
                case "Mix":
                    _selectedLevel = frmGame.enQuestionsLevel.Mix;
                    break;
            }
        }

        private void CheckSelectedOperation() {
            switch (cbOperation.Text) {
                case "+":
                    _selectedOperation = frmGame.enOperationType.Add;
                    break;
                case "-":
                    _selectedOperation = frmGame.enOperationType.Subtract;
                    break;
                case "*":
                    _selectedOperation = frmGame.enOperationType.Multiply;
                    break;
                case "/":
                    _selectedOperation = frmGame.enOperationType.Divide;
                    break;
                case "Mix":
                    _selectedOperation = frmGame.enOperationType.Mix;
                    break;
            }
        }

        private void frmOptionsGame_Load(object sender, EventArgs e) {
            btnStart.Enabled = false;
        }

        private void cbLevel_SelectedIndexChanged(object sender, EventArgs e) {
            CheckSelectedLevel();
        }

        private void cbOperation_SelectedIndexChanged(object sender, EventArgs e) {
            CheckSelectedOperation();
        }

        private void ComboBox_Validating(ComboBox comboBox, CancelEventArgs e, string errorMessage) {
            if (string.IsNullOrWhiteSpace(comboBox.Text)) {
                e.Cancel = true;
                comboBox.Focus();
                errorProvider1.SetError(comboBox, errorMessage);
                btnStart.Enabled = false;
            }else {
                e.Cancel = false;
                errorProvider1.SetError(comboBox, "");
                if (comboBox.Text != "") {
                    btnStart.Enabled = true;
                }
            }
        }

        private void frmOptionsGame_FormClosing(object sender, FormClosingEventArgs e) {
            _FrmMain.Show();
        }

        private void cbLevel_Validating(object sender, CancelEventArgs e) {
            ComboBox_Validating((ComboBox)sender, e, "Level is required!");
        }

        private void cbOperation_Validating(object sender, CancelEventArgs e) {
            ComboBox_Validating((ComboBox) sender, e, "Operation is required!");
        }

        private void btnStart_Click(object sender, EventArgs e) {
            _numOfQuestions = (short)nudQuestions.Value;

            Form FrmGame = new frmGame(_selectedLevel, _selectedOperation, _numOfQuestions);
            FrmGame.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e) {
            this.Dispose();
            _FrmMain.Show();
        }
    }
}
