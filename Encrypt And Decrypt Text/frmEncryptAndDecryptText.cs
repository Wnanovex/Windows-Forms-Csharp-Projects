using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Encrypt_And_Decrypt_Text
{
    public partial class frmEncryptAndDecryptText: Form
    {
        public frmEncryptAndDecryptText() {
            InitializeComponent();
        }

        public class EncryptDecryptText {
            public static string EncryptText(string Text, short EncryptionKey) {
                char[] charArray = Text.ToCharArray();
                for (int i = 0; i < Text.Length; i++)
                    charArray[i] = (char) ((int)Text[i] + EncryptionKey);
                Text = new string(charArray);
                return Text;
            }

            public static string DecryptText(string Text, short EncryptionKey) {
                char[] charArray = Text.ToCharArray();
                for (int i = 0; i < Text.Length; i++)
                    charArray[i] = (char) ((int)Text[i] - EncryptionKey);
                Text = new string(charArray);
                return Text;
            }
        }

        private void richTextBox_Validating(RichTextBox richTextBox, CancelEventArgs e, string errorMessage, System.Windows.Forms.Button btn) {
            if (string.IsNullOrWhiteSpace(richTextBox.Text)) {
                e.Cancel = true;
                richTextBox.Focus();
                errorProvider1.SetError(richTextBox, errorMessage);
                //btn.Enabled = false;
            }else {
                e.Cancel = false;
                errorProvider1.SetError(richTextBox, "");
                //if (richTextBox.Text != "") {
                //    btn.Enabled = true;
                //}
            }
        }

        private void richtxtEncryption_Validating(object sender, CancelEventArgs e) {
            richTextBox_Validating((RichTextBox)sender, e, "Text is required!", btnEncryption);
        }

        private void richtxtDecryption_Validating(object sender, CancelEventArgs e) {
            richTextBox_Validating((RichTextBox)sender, e, "Text is required!", btnDecryption);
        }

        private void btnEncryption_Click(object sender, EventArgs e) {
            string TextEncrypted = EncryptDecryptText.EncryptText(richtxtEncryption.Text, (short)nudEncryptionKey.Value);
            richtxtAfterEncryption.Text = TextEncrypted;
        }

        private void btnDecryption_Click(object sender, EventArgs e) {
            string TextDecrypted = EncryptDecryptText.DecryptText(richtxtDecryption.Text, (short)nudDecryptionKey.Value);
            richtxtAfterDecryption.Text = TextDecrypted;
        }

        private void btnResetEncryptionPart_Click(object sender, EventArgs e) {
            richtxtEncryption.Clear();
            richtxtAfterEncryption.Clear();
        }

        private void btnResetDecryptionPart_Click(object sender, EventArgs e) {
            richtxtDecryption.Clear();
            richtxtAfterDecryption.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            this.Dispose();
        }
    }
}
