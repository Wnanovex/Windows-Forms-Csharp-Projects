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
    public partial class frmKeyGenerator: Form
    {
        public frmKeyGenerator()
        {
            InitializeComponent();
        }

        private void GenerateKeys() {
            for (int i = 1; i <= nupNumberOfKeys.Value; i++) {
                richtxtKeyGenerated.Text += "Key[" + i + "] : " + PasswordKeyGenerator.GenerateKey() + Environment.NewLine;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e) {
            GenerateKeys();
        }

        private void btnReset_Click(object sender, EventArgs e) {
            richtxtKeyGenerated.Clear();
        }
    }
}
