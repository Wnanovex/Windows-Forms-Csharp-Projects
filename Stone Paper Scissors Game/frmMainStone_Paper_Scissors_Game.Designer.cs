namespace Stone_Paper_Scissors_Game
{
    partial class frmMainStone_Paper_Scissors_Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainStone_Paper_Scissors_Game));
            this.btnGoToPlay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudHowManyRounds = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudHowManyRounds)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGoToPlay
            // 
            this.btnGoToPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGoToPlay.BackColor = System.Drawing.Color.Lime;
            this.btnGoToPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGoToPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToPlay.ForeColor = System.Drawing.Color.White;
            this.btnGoToPlay.Location = new System.Drawing.Point(284, 357);
            this.btnGoToPlay.Name = "btnGoToPlay";
            this.btnGoToPlay.Size = new System.Drawing.Size(229, 40);
            this.btnGoToPlay.TabIndex = 5;
            this.btnGoToPlay.Text = "Go To Play";
            this.btnGoToPlay.UseVisualStyleBackColor = false;
            this.btnGoToPlay.Click += new System.EventHandler(this.btnGoToPlay_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(41, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(723, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "How many rounds do you want to play";
            // 
            // nudHowManyRounds
            // 
            this.nudHowManyRounds.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudHowManyRounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHowManyRounds.Location = new System.Drawing.Point(312, 279);
            this.nudHowManyRounds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHowManyRounds.Name = "nudHowManyRounds";
            this.nudHowManyRounds.Size = new System.Drawing.Size(169, 35);
            this.nudHowManyRounds.TabIndex = 3;
            this.nudHowManyRounds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmMainStone_Paper_Scissors_Game
            // 
            this.AcceptButton = this.btnGoToPlay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::Stone_Paper_Scissors_Game.Properties.Resources.rock_paper_scissors_logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGoToPlay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudHowManyRounds);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainStone_Paper_Scissors_Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stone Paper Scissors Game";
            ((System.ComponentModel.ISupportInitialize)(this.nudHowManyRounds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoToPlay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudHowManyRounds;
    }
}

