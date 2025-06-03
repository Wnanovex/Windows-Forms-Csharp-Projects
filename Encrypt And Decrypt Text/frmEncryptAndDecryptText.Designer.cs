namespace Encrypt_And_Decrypt_Text
{
    partial class frmEncryptAndDecryptText
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEncryptAndDecryptText));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnResetEncryptionPart = new System.Windows.Forms.Button();
            this.richtxtAfterEncryption = new System.Windows.Forms.RichTextBox();
            this.btnEncryption = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nudEncryptionKey = new System.Windows.Forms.NumericUpDown();
            this.richtxtEncryption = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnResetDecryptionPart = new System.Windows.Forms.Button();
            this.richtxtAfterDecryption = new System.Windows.Forms.RichTextBox();
            this.btnDecryption = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nudDecryptionKey = new System.Windows.Forms.NumericUpDown();
            this.richtxtDecryption = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEncryptionKey)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecryptionKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnResetEncryptionPart);
            this.panel1.Controls.Add(this.richtxtAfterEncryption);
            this.panel1.Controls.Add(this.btnEncryption);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.nudEncryptionKey);
            this.panel1.Controls.Add(this.richtxtEncryption);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 680);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(97, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Original Text:";
            // 
            // btnResetEncryptionPart
            // 
            this.btnResetEncryptionPart.BackColor = System.Drawing.Color.Red;
            this.btnResetEncryptionPart.FlatAppearance.BorderSize = 0;
            this.btnResetEncryptionPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetEncryptionPart.Font = new System.Drawing.Font("Courier New", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetEncryptionPart.ForeColor = System.Drawing.Color.White;
            this.btnResetEncryptionPart.Location = new System.Drawing.Point(204, 613);
            this.btnResetEncryptionPart.Name = "btnResetEncryptionPart";
            this.btnResetEncryptionPart.Size = new System.Drawing.Size(159, 44);
            this.btnResetEncryptionPart.TabIndex = 11;
            this.btnResetEncryptionPart.Text = "Reset";
            this.btnResetEncryptionPart.UseVisualStyleBackColor = false;
            this.btnResetEncryptionPart.Click += new System.EventHandler(this.btnResetEncryptionPart_Click);
            // 
            // richtxtAfterEncryption
            // 
            this.richtxtAfterEncryption.AcceptsTab = true;
            this.richtxtAfterEncryption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richtxtAfterEncryption.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richtxtAfterEncryption.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.richtxtAfterEncryption.Location = new System.Drawing.Point(101, 439);
            this.richtxtAfterEncryption.Name = "richtxtAfterEncryption";
            this.richtxtAfterEncryption.ReadOnly = true;
            this.richtxtAfterEncryption.Size = new System.Drawing.Size(365, 147);
            this.richtxtAfterEncryption.TabIndex = 13;
            this.richtxtAfterEncryption.Text = "";
            // 
            // btnEncryption
            // 
            this.btnEncryption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnEncryption.FlatAppearance.BorderSize = 0;
            this.btnEncryption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncryption.Font = new System.Drawing.Font("Courier New", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncryption.ForeColor = System.Drawing.Color.White;
            this.btnEncryption.Location = new System.Drawing.Point(173, 370);
            this.btnEncryption.Name = "btnEncryption";
            this.btnEncryption.Size = new System.Drawing.Size(210, 44);
            this.btnEncryption.TabIndex = 12;
            this.btnEncryption.Text = "Encryption";
            this.btnEncryption.UseVisualStyleBackColor = false;
            this.btnEncryption.Click += new System.EventHandler(this.btnEncryption_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(97, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Encryption Key:";
            // 
            // nudEncryptionKey
            // 
            this.nudEncryptionKey.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudEncryptionKey.Location = new System.Drawing.Point(285, 305);
            this.nudEncryptionKey.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudEncryptionKey.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEncryptionKey.Name = "nudEncryptionKey";
            this.nudEncryptionKey.Size = new System.Drawing.Size(168, 33);
            this.nudEncryptionKey.TabIndex = 6;
            this.nudEncryptionKey.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // richtxtEncryption
            // 
            this.richtxtEncryption.AcceptsTab = true;
            this.richtxtEncryption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richtxtEncryption.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richtxtEncryption.Location = new System.Drawing.Point(101, 135);
            this.richtxtEncryption.Name = "richtxtEncryption";
            this.richtxtEncryption.Size = new System.Drawing.Size(365, 147);
            this.richtxtEncryption.TabIndex = 5;
            this.richtxtEncryption.Text = "";
            this.richtxtEncryption.Validating += new System.ComponentModel.CancelEventHandler(this.richtxtEncryption_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(149, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 71);
            this.label1.TabIndex = 3;
            this.label1.Text = "Encryption";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnResetDecryptionPart);
            this.panel2.Controls.Add(this.richtxtAfterDecryption);
            this.panel2.Controls.Add(this.btnDecryption);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.nudDecryptionKey);
            this.panel2.Controls.Add(this.richtxtDecryption);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(574, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(565, 680);
            this.panel2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(98, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Encryption Text:";
            // 
            // btnResetDecryptionPart
            // 
            this.btnResetDecryptionPart.BackColor = System.Drawing.Color.Red;
            this.btnResetDecryptionPart.FlatAppearance.BorderSize = 0;
            this.btnResetDecryptionPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetDecryptionPart.Font = new System.Drawing.Font("Courier New", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetDecryptionPart.ForeColor = System.Drawing.Color.White;
            this.btnResetDecryptionPart.Location = new System.Drawing.Point(212, 613);
            this.btnResetDecryptionPart.Name = "btnResetDecryptionPart";
            this.btnResetDecryptionPart.Size = new System.Drawing.Size(159, 44);
            this.btnResetDecryptionPart.TabIndex = 14;
            this.btnResetDecryptionPart.Text = "Reset";
            this.btnResetDecryptionPart.UseVisualStyleBackColor = false;
            this.btnResetDecryptionPart.Click += new System.EventHandler(this.btnResetDecryptionPart_Click);
            // 
            // richtxtAfterDecryption
            // 
            this.richtxtAfterDecryption.AcceptsTab = true;
            this.richtxtAfterDecryption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richtxtAfterDecryption.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richtxtAfterDecryption.Location = new System.Drawing.Point(102, 439);
            this.richtxtAfterDecryption.Name = "richtxtAfterDecryption";
            this.richtxtAfterDecryption.ReadOnly = true;
            this.richtxtAfterDecryption.Size = new System.Drawing.Size(365, 147);
            this.richtxtAfterDecryption.TabIndex = 14;
            this.richtxtAfterDecryption.Text = "";
            // 
            // btnDecryption
            // 
            this.btnDecryption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDecryption.FlatAppearance.BorderSize = 0;
            this.btnDecryption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecryption.Font = new System.Drawing.Font("Courier New", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecryption.ForeColor = System.Drawing.Color.White;
            this.btnDecryption.Location = new System.Drawing.Point(185, 370);
            this.btnDecryption.Name = "btnDecryption";
            this.btnDecryption.Size = new System.Drawing.Size(210, 44);
            this.btnDecryption.TabIndex = 13;
            this.btnDecryption.Text = "Decryption";
            this.btnDecryption.UseVisualStyleBackColor = false;
            this.btnDecryption.Click += new System.EventHandler(this.btnDecryption_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Decryption Key:";
            // 
            // nudDecryptionKey
            // 
            this.nudDecryptionKey.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDecryptionKey.Location = new System.Drawing.Point(286, 308);
            this.nudDecryptionKey.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudDecryptionKey.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDecryptionKey.Name = "nudDecryptionKey";
            this.nudDecryptionKey.Size = new System.Drawing.Size(168, 33);
            this.nudDecryptionKey.TabIndex = 8;
            this.nudDecryptionKey.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // richtxtDecryption
            // 
            this.richtxtDecryption.AcceptsTab = true;
            this.richtxtDecryption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richtxtDecryption.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richtxtDecryption.Location = new System.Drawing.Point(102, 135);
            this.richtxtDecryption.Name = "richtxtDecryption";
            this.richtxtDecryption.Size = new System.Drawing.Size(365, 147);
            this.richtxtDecryption.TabIndex = 6;
            this.richtxtDecryption.Text = "";
            this.richtxtDecryption.Validating += new System.ComponentModel.CancelEventHandler(this.richtxtDecryption_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(143, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 71);
            this.label2.TabIndex = 4;
            this.label2.Text = "Decryption";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmEncryptAndDecryptText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1139, 680);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEncryptAndDecryptText";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encrypt & Decrypt Text";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEncryptionKey)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecryptionKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richtxtEncryption;
        private System.Windows.Forms.RichTextBox richtxtDecryption;
        private System.Windows.Forms.NumericUpDown nudEncryptionKey;
        private System.Windows.Forms.Button btnEncryption;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDecryption;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudDecryptionKey;
        private System.Windows.Forms.RichTextBox richtxtAfterEncryption;
        private System.Windows.Forms.RichTextBox richtxtAfterDecryption;
        private System.Windows.Forms.Button btnResetEncryptionPart;
        private System.Windows.Forms.Button btnResetDecryptionPart;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

