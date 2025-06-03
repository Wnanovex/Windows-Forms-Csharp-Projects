using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_and_Key_Generator
{
    public partial class frmPasswordGenerator: Form
    {
        public frmPasswordGenerator() {
            InitializeComponent();
        }

        private void GeneratePassword() {
            List<PasswordKeyGenerator.enCharType> selectedTypes = new List<PasswordKeyGenerator.enCharType>();

            // Add the corresponding character types to the list if the checkboxes are checked
            if (chkDigit.Checked)
                selectedTypes.Add(PasswordKeyGenerator.enCharType.Digit);
            
            if (chkCapitalLetter.Checked) 
                selectedTypes.Add(PasswordKeyGenerator.enCharType.CapitalLetter);
            
            if (chkSmallLetter.Checked)
                selectedTypes.Add(PasswordKeyGenerator.enCharType.SmallLetter);
            
            if (chkSpecialCharacter.Checked)
            
                selectedTypes.Add(PasswordKeyGenerator.enCharType.SpecialCharacter);

            // Check if at least one character type is selected
            if (selectedTypes.Count > 0) {
                switch (selectedTypes.Count) {
                    case 1:
                        txtGeneratedPassword.Text = PasswordKeyGenerator.GeneratePassword(selectedTypes[0], (short)trackBarPasswordLenght.Value);
                        break;
                    case 2:
                        txtGeneratedPassword.Text = PasswordKeyGenerator.GeneratePassword(selectedTypes[0], selectedTypes[1], (short)trackBarPasswordLenght.Value);
                        break;
                    case 3:
                        txtGeneratedPassword.Text = PasswordKeyGenerator.GeneratePassword(selectedTypes[0], selectedTypes[1], selectedTypes[2], (short)trackBarPasswordLenght.Value);
                        break;
                    case 4:
                        txtGeneratedPassword.Text = PasswordKeyGenerator.GeneratePassword(PasswordKeyGenerator.enCharType.MixChars, (short)trackBarPasswordLenght.Value);
                        break;
                }
            }
        }

        private void trackBarPasswordLenght_Scroll(object sender, EventArgs e) {
            lblPasswordLenghtValue.Text = trackBarPasswordLenght.Value.ToString();
        }

        private void btnGenerate_Click(object sender, EventArgs e) {
            GeneratePassword();
        }

        private void btnReset_Click(object sender, EventArgs e) {
            txtGeneratedPassword.Clear();
        }
    }
}
