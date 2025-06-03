namespace Password_and_Key_Generator
{
    partial class frmPasswordGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPasswordGenerator));
            this.label1 = new System.Windows.Forms.Label();
            this.txtGeneratedPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBarPasswordLenght = new System.Windows.Forms.TrackBar();
            this.lblPasswordLenghtValue = new System.Windows.Forms.Label();
            this.gbPasswordType = new System.Windows.Forms.GroupBox();
            this.chkDigit = new System.Windows.Forms.CheckBox();
            this.chkCapitalLetter = new System.Windows.Forms.CheckBox();
            this.chkSmallLetter = new System.Windows.Forms.CheckBox();
            this.chkSpecialCharacter = new System.Windows.Forms.CheckBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPasswordLenght)).BeginInit();
            this.gbPasswordType.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(98, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 71);
            this.label1.TabIndex = 4;
            this.label1.Text = "Password Generator";
            // 
            // txtGeneratedPassword
            // 
            this.txtGeneratedPassword.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGeneratedPassword.Location = new System.Drawing.Point(110, 126);
            this.txtGeneratedPassword.Name = "txtGeneratedPassword";
            this.txtGeneratedPassword.ReadOnly = true;
            this.txtGeneratedPassword.Size = new System.Drawing.Size(427, 40);
            this.txtGeneratedPassword.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password Lenght:";
            // 
            // trackBarPasswordLenght
            // 
            this.trackBarPasswordLenght.Location = new System.Drawing.Point(251, 201);
            this.trackBarPasswordLenght.Maximum = 20;
            this.trackBarPasswordLenght.Minimum = 1;
            this.trackBarPasswordLenght.Name = "trackBarPasswordLenght";
            this.trackBarPasswordLenght.Size = new System.Drawing.Size(321, 69);
            this.trackBarPasswordLenght.TabIndex = 7;
            this.trackBarPasswordLenght.Value = 1;
            this.trackBarPasswordLenght.Scroll += new System.EventHandler(this.trackBarPasswordLenght_Scroll);
            // 
            // lblPasswordLenghtValue
            // 
            this.lblPasswordLenghtValue.AutoSize = true;
            this.lblPasswordLenghtValue.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordLenghtValue.Location = new System.Drawing.Point(597, 201);
            this.lblPasswordLenghtValue.Name = "lblPasswordLenghtValue";
            this.lblPasswordLenghtValue.Size = new System.Drawing.Size(30, 33);
            this.lblPasswordLenghtValue.TabIndex = 8;
            this.lblPasswordLenghtValue.Text = "1";
            // 
            // gbPasswordType
            // 
            this.gbPasswordType.Controls.Add(this.chkSpecialCharacter);
            this.gbPasswordType.Controls.Add(this.chkSmallLetter);
            this.gbPasswordType.Controls.Add(this.chkCapitalLetter);
            this.gbPasswordType.Controls.Add(this.chkDigit);
            this.gbPasswordType.Location = new System.Drawing.Point(32, 275);
            this.gbPasswordType.Name = "gbPasswordType";
            this.gbPasswordType.Size = new System.Drawing.Size(595, 100);
            this.gbPasswordType.TabIndex = 9;
            this.gbPasswordType.TabStop = false;
            this.gbPasswordType.Text = "Password Type";
            // 
            // chkDigit
            // 
            this.chkDigit.AutoSize = true;
            this.chkDigit.Location = new System.Drawing.Point(30, 43);
            this.chkDigit.Name = "chkDigit";
            this.chkDigit.Size = new System.Drawing.Size(67, 24);
            this.chkDigit.TabIndex = 0;
            this.chkDigit.Text = "Digit";
            this.chkDigit.UseVisualStyleBackColor = true;
            // 
            // chkCapitalLetter
            // 
            this.chkCapitalLetter.AutoSize = true;
            this.chkCapitalLetter.Location = new System.Drawing.Point(132, 43);
            this.chkCapitalLetter.Name = "chkCapitalLetter";
            this.chkCapitalLetter.Size = new System.Drawing.Size(130, 24);
            this.chkCapitalLetter.TabIndex = 1;
            this.chkCapitalLetter.Text = "Capital Letter";
            this.chkCapitalLetter.UseVisualStyleBackColor = true;
            // 
            // chkSmallLetter
            // 
            this.chkSmallLetter.AutoSize = true;
            this.chkSmallLetter.Location = new System.Drawing.Point(288, 43);
            this.chkSmallLetter.Name = "chkSmallLetter";
            this.chkSmallLetter.Size = new System.Drawing.Size(120, 24);
            this.chkSmallLetter.TabIndex = 2;
            this.chkSmallLetter.Text = "Small Letter";
            this.chkSmallLetter.UseVisualStyleBackColor = true;
            // 
            // chkSpecialCharacter
            // 
            this.chkSpecialCharacter.AutoSize = true;
            this.chkSpecialCharacter.Location = new System.Drawing.Point(428, 43);
            this.chkSpecialCharacter.Name = "chkSpecialCharacter";
            this.chkSpecialCharacter.Size = new System.Drawing.Size(161, 24);
            this.chkSpecialCharacter.TabIndex = 3;
            this.chkSpecialCharacter.Text = "Special Character";
            this.chkSpecialCharacter.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Courier New", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(221, 431);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(207, 44);
            this.btnGenerate.TabIndex = 11;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Red;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Courier New", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(221, 502);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(207, 44);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmPasswordGenerator
            // 
            this.AcceptButton = this.btnGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(677, 574);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.gbPasswordType);
            this.Controls.Add(this.lblPasswordLenghtValue);
            this.Controls.Add(this.trackBarPasswordLenght);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGeneratedPassword);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPasswordGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password & Key Generator";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPasswordLenght)).EndInit();
            this.gbPasswordType.ResumeLayout(false);
            this.gbPasswordType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGeneratedPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBarPasswordLenght;
        private System.Windows.Forms.Label lblPasswordLenghtValue;
        private System.Windows.Forms.GroupBox gbPasswordType;
        private System.Windows.Forms.CheckBox chkSpecialCharacter;
        private System.Windows.Forms.CheckBox chkSmallLetter;
        private System.Windows.Forms.CheckBox chkCapitalLetter;
        private System.Windows.Forms.CheckBox chkDigit;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnReset;
    }
}