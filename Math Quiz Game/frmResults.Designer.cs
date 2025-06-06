namespace Math_Quiz_Game
{
    partial class frmResults
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResults));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNumberOfQuestionsValue = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblIsPass = new System.Windows.Forms.Label();
            this.lblWrongAnswersValue = new System.Windows.Forms.Label();
            this.lblRightAnswersValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblOperationTypeInfoValue = new System.Windows.Forms.Label();
            this.lblQuestionsLevelInfoValue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnResetGame = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblNumberOfQuestionsValue);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblIsPass);
            this.panel1.Controls.Add(this.lblWrongAnswersValue);
            this.panel1.Controls.Add(this.lblRightAnswersValue);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblOperationTypeInfoValue);
            this.panel1.Controls.Add(this.lblQuestionsLevelInfoValue);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(139, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 320);
            this.panel1.TabIndex = 0;
            // 
            // lblNumberOfQuestionsValue
            // 
            this.lblNumberOfQuestionsValue.AutoSize = true;
            this.lblNumberOfQuestionsValue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfQuestionsValue.ForeColor = System.Drawing.Color.Yellow;
            this.lblNumberOfQuestionsValue.Location = new System.Drawing.Point(261, 79);
            this.lblNumberOfQuestionsValue.Name = "lblNumberOfQuestionsValue";
            this.lblNumberOfQuestionsValue.Size = new System.Drawing.Size(21, 21);
            this.lblNumberOfQuestionsValue.TabIndex = 22;
            this.lblNumberOfQuestionsValue.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(230, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "Number of Questions:";
            // 
            // lblIsPass
            // 
            this.lblIsPass.AutoSize = true;
            this.lblIsPass.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblIsPass.Location = new System.Drawing.Point(106, 262);
            this.lblIsPass.Name = "lblIsPass";
            this.lblIsPass.Size = new System.Drawing.Size(94, 23);
            this.lblIsPass.TabIndex = 20;
            this.lblIsPass.Text = "Pass :)";
            // 
            // lblWrongAnswersValue
            // 
            this.lblWrongAnswersValue.AutoSize = true;
            this.lblWrongAnswersValue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrongAnswersValue.ForeColor = System.Drawing.Color.Yellow;
            this.lblWrongAnswersValue.Location = new System.Drawing.Point(195, 222);
            this.lblWrongAnswersValue.Name = "lblWrongAnswersValue";
            this.lblWrongAnswersValue.Size = new System.Drawing.Size(21, 21);
            this.lblWrongAnswersValue.TabIndex = 19;
            this.lblWrongAnswersValue.Text = "0";
            // 
            // lblRightAnswersValue
            // 
            this.lblRightAnswersValue.AutoSize = true;
            this.lblRightAnswersValue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightAnswersValue.ForeColor = System.Drawing.Color.Yellow;
            this.lblRightAnswersValue.Location = new System.Drawing.Point(195, 184);
            this.lblRightAnswersValue.Name = "lblRightAnswersValue";
            this.lblRightAnswersValue.Size = new System.Drawing.Size(21, 21);
            this.lblRightAnswersValue.TabIndex = 18;
            this.lblRightAnswersValue.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Wrong Answers:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 21);
            this.label8.TabIndex = 16;
            this.label8.Text = "Right Answers:";
            // 
            // lblOperationTypeInfoValue
            // 
            this.lblOperationTypeInfoValue.AutoSize = true;
            this.lblOperationTypeInfoValue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperationTypeInfoValue.ForeColor = System.Drawing.Color.Yellow;
            this.lblOperationTypeInfoValue.Location = new System.Drawing.Point(206, 150);
            this.lblOperationTypeInfoValue.Name = "lblOperationTypeInfoValue";
            this.lblOperationTypeInfoValue.Size = new System.Drawing.Size(43, 21);
            this.lblOperationTypeInfoValue.TabIndex = 11;
            this.lblOperationTypeInfoValue.Text = "Add";
            // 
            // lblQuestionsLevelInfoValue
            // 
            this.lblQuestionsLevelInfoValue.AutoSize = true;
            this.lblQuestionsLevelInfoValue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionsLevelInfoValue.ForeColor = System.Drawing.Color.Yellow;
            this.lblQuestionsLevelInfoValue.Location = new System.Drawing.Point(217, 113);
            this.lblQuestionsLevelInfoValue.Name = "lblQuestionsLevelInfoValue";
            this.lblQuestionsLevelInfoValue.Size = new System.Drawing.Size(43, 21);
            this.lblQuestionsLevelInfoValue.TabIndex = 10;
            this.lblQuestionsLevelInfoValue.Text = "Med";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Operation Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Questions Level:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(149, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Final Results";
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPlayAgain.FlatAppearance.BorderSize = 0;
            this.btnPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayAgain.Font = new System.Drawing.Font("Courier New", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.Location = new System.Drawing.Point(528, 393);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(212, 44);
            this.btnPlayAgain.TabIndex = 17;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // btnResetGame
            // 
            this.btnResetGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnResetGame.FlatAppearance.BorderSize = 0;
            this.btnResetGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetGame.Font = new System.Drawing.Font("Courier New", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetGame.Location = new System.Drawing.Point(31, 393);
            this.btnResetGame.Name = "btnResetGame";
            this.btnResetGame.Size = new System.Drawing.Size(212, 44);
            this.btnResetGame.TabIndex = 18;
            this.btnResetGame.Text = "Reset Game";
            this.btnResetGame.UseVisualStyleBackColor = false;
            this.btnResetGame.Click += new System.EventHandler(this.btnResetGame_Click);
            // 
            // frmResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(776, 472);
            this.Controls.Add(this.btnResetGame);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Math Quiz Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmResults_FormClosing);
            this.Load += new System.EventHandler(this.frmResults_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOperationTypeInfoValue;
        private System.Windows.Forms.Label lblQuestionsLevelInfoValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblIsPass;
        private System.Windows.Forms.Label lblWrongAnswersValue;
        private System.Windows.Forms.Label lblRightAnswersValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblNumberOfQuestionsValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Button btnResetGame;
    }
}