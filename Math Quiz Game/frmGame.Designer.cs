namespace Math_Quiz_Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblOpType = new System.Windows.Forms.Label();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.lblNumber1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNumOfCurrentQuestion = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblQuestionLevelInfoValue = new System.Windows.Forms.Label();
            this.lblOperationTypeInfoValue = new System.Windows.Forms.Label();
            this.lblTimeValue = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblWrongAnswerValue = new System.Windows.Forms.Label();
            this.lblRightAnswerValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnResults = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlCorrectAnswer = new System.Windows.Forms.Panel();
            this.lblCorrectAnswerValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlCorrectAnswer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.lblOpType);
            this.panel1.Controls.Add(this.lblNumber2);
            this.panel1.Controls.Add(this.lblNumber1);
            this.panel1.Location = new System.Drawing.Point(271, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 62);
            this.panel1.TabIndex = 0;
            // 
            // lblOpType
            // 
            this.lblOpType.AutoSize = true;
            this.lblOpType.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpType.ForeColor = System.Drawing.Color.Green;
            this.lblOpType.Location = new System.Drawing.Point(190, 15);
            this.lblOpType.Name = "lblOpType";
            this.lblOpType.Size = new System.Drawing.Size(31, 32);
            this.lblOpType.TabIndex = 2;
            this.lblOpType.Text = "+";
            // 
            // lblNumber2
            // 
            this.lblNumber2.AutoSize = true;
            this.lblNumber2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber2.Location = new System.Drawing.Point(276, 15);
            this.lblNumber2.Name = "lblNumber2";
            this.lblNumber2.Size = new System.Drawing.Size(36, 37);
            this.lblNumber2.TabIndex = 1;
            this.lblNumber2.Text = "0";
            // 
            // lblNumber1
            // 
            this.lblNumber1.AutoSize = true;
            this.lblNumber1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber1.Location = new System.Drawing.Point(105, 15);
            this.lblNumber1.Name = "lblNumber1";
            this.lblNumber1.Size = new System.Drawing.Size(36, 37);
            this.lblNumber1.TabIndex = 0;
            this.lblNumber1.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Question Level:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Operation Type:";
            // 
            // lblNumOfCurrentQuestion
            // 
            this.lblNumOfCurrentQuestion.AutoSize = true;
            this.lblNumOfCurrentQuestion.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfCurrentQuestion.ForeColor = System.Drawing.Color.Red;
            this.lblNumOfCurrentQuestion.Location = new System.Drawing.Point(378, 25);
            this.lblNumOfCurrentQuestion.Name = "lblNumOfCurrentQuestion";
            this.lblNumOfCurrentQuestion.Size = new System.Drawing.Size(192, 28);
            this.lblNumOfCurrentQuestion.TabIndex = 4;
            this.lblNumOfCurrentQuestion.Text = "Question 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Time:";
            // 
            // lblQuestionLevelInfoValue
            // 
            this.lblQuestionLevelInfoValue.AutoSize = true;
            this.lblQuestionLevelInfoValue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionLevelInfoValue.ForeColor = System.Drawing.Color.Yellow;
            this.lblQuestionLevelInfoValue.Location = new System.Drawing.Point(193, 56);
            this.lblQuestionLevelInfoValue.Name = "lblQuestionLevelInfoValue";
            this.lblQuestionLevelInfoValue.Size = new System.Drawing.Size(43, 21);
            this.lblQuestionLevelInfoValue.TabIndex = 6;
            this.lblQuestionLevelInfoValue.Text = "Med";
            // 
            // lblOperationTypeInfoValue
            // 
            this.lblOperationTypeInfoValue.AutoSize = true;
            this.lblOperationTypeInfoValue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperationTypeInfoValue.ForeColor = System.Drawing.Color.Yellow;
            this.lblOperationTypeInfoValue.Location = new System.Drawing.Point(193, 104);
            this.lblOperationTypeInfoValue.Name = "lblOperationTypeInfoValue";
            this.lblOperationTypeInfoValue.Size = new System.Drawing.Size(43, 21);
            this.lblOperationTypeInfoValue.TabIndex = 7;
            this.lblOperationTypeInfoValue.Text = "Add";
            // 
            // lblTimeValue
            // 
            this.lblTimeValue.AutoSize = true;
            this.lblTimeValue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeValue.ForeColor = System.Drawing.Color.Yellow;
            this.lblTimeValue.Location = new System.Drawing.Point(83, 151);
            this.lblTimeValue.Name = "lblTimeValue";
            this.lblTimeValue.Size = new System.Drawing.Size(21, 21);
            this.lblTimeValue.TabIndex = 8;
            this.lblTimeValue.Text = "0";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Courier New", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(748, 434);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(159, 44);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCheck.FlatAppearance.BorderSize = 0;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Courier New", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(401, 362);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(159, 44);
            this.btnCheck.TabIndex = 11;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblWrongAnswerValue
            // 
            this.lblWrongAnswerValue.AutoSize = true;
            this.lblWrongAnswerValue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrongAnswerValue.ForeColor = System.Drawing.Color.Yellow;
            this.lblWrongAnswerValue.Location = new System.Drawing.Point(858, 104);
            this.lblWrongAnswerValue.Name = "lblWrongAnswerValue";
            this.lblWrongAnswerValue.Size = new System.Drawing.Size(21, 21);
            this.lblWrongAnswerValue.TabIndex = 15;
            this.lblWrongAnswerValue.Text = "0";
            // 
            // lblRightAnswerValue
            // 
            this.lblRightAnswerValue.AutoSize = true;
            this.lblRightAnswerValue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightAnswerValue.ForeColor = System.Drawing.Color.Yellow;
            this.lblRightAnswerValue.Location = new System.Drawing.Point(858, 56);
            this.lblRightAnswerValue.Name = "lblRightAnswerValue";
            this.lblRightAnswerValue.Size = new System.Drawing.Size(21, 21);
            this.lblRightAnswerValue.TabIndex = 14;
            this.lblRightAnswerValue.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(699, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Wrong Answer:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(699, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 21);
            this.label8.TabIndex = 12;
            this.label8.Text = "Right Answer:";
            // 
            // btnResults
            // 
            this.btnResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnResults.FlatAppearance.BorderSize = 0;
            this.btnResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResults.Font = new System.Drawing.Font("Courier New", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResults.Location = new System.Drawing.Point(748, 434);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(159, 44);
            this.btnResults.TabIndex = 16;
            this.btnResults.Text = "Results";
            this.btnResults.UseVisualStyleBackColor = false;
            this.btnResults.Visible = false;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14F);
            this.textBox1.Location = new System.Drawing.Point(367, 293);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 40);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlCorrectAnswer
            // 
            this.pnlCorrectAnswer.Controls.Add(this.lblCorrectAnswerValue);
            this.pnlCorrectAnswer.Controls.Add(this.label2);
            this.pnlCorrectAnswer.Location = new System.Drawing.Point(329, 105);
            this.pnlCorrectAnswer.Name = "pnlCorrectAnswer";
            this.pnlCorrectAnswer.Size = new System.Drawing.Size(293, 67);
            this.pnlCorrectAnswer.TabIndex = 17;
            this.pnlCorrectAnswer.Visible = false;
            // 
            // lblCorrectAnswerValue
            // 
            this.lblCorrectAnswerValue.AutoSize = true;
            this.lblCorrectAnswerValue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectAnswerValue.ForeColor = System.Drawing.Color.Yellow;
            this.lblCorrectAnswerValue.Location = new System.Drawing.Point(210, 23);
            this.lblCorrectAnswerValue.Name = "lblCorrectAnswerValue";
            this.lblCorrectAnswerValue.Size = new System.Drawing.Size(21, 21);
            this.lblCorrectAnswerValue.TabIndex = 19;
            this.lblCorrectAnswerValue.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(19, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "The Answer is:";
            // 
            // frmGame
            // 
            this.AcceptButton = this.btnCheck;
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(955, 509);
            this.Controls.Add(this.pnlCorrectAnswer);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnResults);
            this.Controls.Add(this.lblWrongAnswerValue);
            this.Controls.Add(this.lblRightAnswerValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblTimeValue);
            this.Controls.Add(this.lblOperationTypeInfoValue);
            this.Controls.Add(this.lblQuestionLevelInfoValue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblNumOfCurrentQuestion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Math Quiz Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGame_FormClosing);
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlCorrectAnswer.ResumeLayout(false);
            this.pnlCorrectAnswer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNumber1;
        private System.Windows.Forms.Label lblOpType;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNumOfCurrentQuestion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblQuestionLevelInfoValue;
        private System.Windows.Forms.Label lblOperationTypeInfoValue;
        private System.Windows.Forms.Label lblTimeValue;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblWrongAnswerValue;
        private System.Windows.Forms.Label lblRightAnswerValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnResults;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlCorrectAnswer;
        private System.Windows.Forms.Label lblCorrectAnswerValue;
        private System.Windows.Forms.Label label2;
    }
}