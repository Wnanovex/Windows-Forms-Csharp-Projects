using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Game
{
    public partial class frmChoicePlayingWith: Form
    {
        public frmChoicePlayingWith()
        {
            InitializeComponent();
        }

        private void btnComputer_Click(object sender, EventArgs e) {
            frmGame FrmGame = new frmGame(frmGame.enPlayingWith.Computer);
            FrmGame.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            frmGame FrmGame = new frmGame(frmGame.enPlayingWith.Player2);
            FrmGame.ShowDialog();
        }
    }
}
