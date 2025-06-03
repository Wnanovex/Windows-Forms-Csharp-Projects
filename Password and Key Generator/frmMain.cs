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
    public partial class frmMain: Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnPassword_Click(object sender, EventArgs e) {
            Form FrmPasswordGenerator = new frmPasswordGenerator();
            FrmPasswordGenerator.ShowDialog();
        }

        private void btnKey_Click(object sender, EventArgs e) {
            Form FrmKeyGenerator = new frmKeyGenerator();
            FrmKeyGenerator.ShowDialog();
        }
    }
}
