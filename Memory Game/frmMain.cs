﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Game
{
    public partial class frmMain: Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e) {
            this.Hide();
            Form FrmGame = new frmGame(this);
            FrmGame.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Dispose();
        }
    }
}
