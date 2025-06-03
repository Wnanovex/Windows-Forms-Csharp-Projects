using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stone_Paper_Scissors_Game
{
    public partial class frmMainStone_Paper_Scissors_Game: Form
    {
        public frmMainStone_Paper_Scissors_Game()
        {
            InitializeComponent();
        }

        private void btnGoToPlay_Click(object sender, EventArgs e) {
            Form GameForm = new frmGame((byte)nudHowManyRounds.Value);
            GameForm.ShowDialog();
        }
    }
}
