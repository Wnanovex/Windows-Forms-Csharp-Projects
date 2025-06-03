﻿namespace Tic_Tac_Toe_Game
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTurnValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWinnerValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRestartGame = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(99, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Turn";
            // 
            // lblTurnValue
            // 
            this.lblTurnValue.AutoSize = true;
            this.lblTurnValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnValue.ForeColor = System.Drawing.Color.White;
            this.lblTurnValue.Location = new System.Drawing.Point(84, 160);
            this.lblTurnValue.Name = "lblTurnValue";
            this.lblTurnValue.Size = new System.Drawing.Size(157, 40);
            this.lblTurnValue.TabIndex = 1;
            this.lblTurnValue.Text = "Player 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(84, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Winner";
            // 
            // lblWinnerValue
            // 
            this.lblWinnerValue.AutoSize = true;
            this.lblWinnerValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinnerValue.ForeColor = System.Drawing.Color.Lime;
            this.lblWinnerValue.Location = new System.Drawing.Point(74, 299);
            this.lblWinnerValue.Name = "lblWinnerValue";
            this.lblWinnerValue.Size = new System.Drawing.Size(211, 40);
            this.lblWinnerValue.TabIndex = 3;
            this.lblWinnerValue.Text = "In Progress";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(465, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(441, 58);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tic-Tac-Toe Game";
            // 
            // btnRestartGame
            // 
            this.btnRestartGame.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRestartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestartGame.ForeColor = System.Drawing.Color.Blue;
            this.btnRestartGame.Location = new System.Drawing.Point(56, 447);
            this.btnRestartGame.Name = "btnRestartGame";
            this.btnRestartGame.Size = new System.Drawing.Size(217, 60);
            this.btnRestartGame.TabIndex = 5;
            this.btnRestartGame.Text = "Restart Game";
            this.btnRestartGame.UseVisualStyleBackColor = false;
            this.btnRestartGame.Click += new System.EventHandler(this.btnRestartGame_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.button1.Location = new System.Drawing.Point(422, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 139);
            this.button1.TabIndex = 6;
            this.button1.Tag = "?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.button2.Location = new System.Drawing.Point(633, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 139);
            this.button2.TabIndex = 7;
            this.button2.Tag = "?";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.button3.Location = new System.Drawing.Point(847, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 139);
            this.button3.TabIndex = 8;
            this.button3.Tag = "?";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.button4.Location = new System.Drawing.Point(422, 325);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(163, 139);
            this.button4.TabIndex = 9;
            this.button4.Tag = "?";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.button5.Location = new System.Drawing.Point(633, 325);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(163, 139);
            this.button5.TabIndex = 10;
            this.button5.Tag = "?";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.button6.Location = new System.Drawing.Point(847, 325);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(163, 139);
            this.button6.TabIndex = 11;
            this.button6.Tag = "?";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.button7.Location = new System.Drawing.Point(422, 489);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(163, 139);
            this.button7.TabIndex = 12;
            this.button7.Tag = "?";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.button8.Location = new System.Drawing.Point(633, 489);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(163, 139);
            this.button8.TabIndex = 13;
            this.button8.Tag = "?";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.button9.Location = new System.Drawing.Point(847, 489);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(163, 139);
            this.button9.TabIndex = 14;
            this.button9.Tag = "?";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1143, 693);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRestartGame);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblWinnerValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTurnValue);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic-Tac-Toe Game";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTurnValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWinnerValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRestartGame;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}

