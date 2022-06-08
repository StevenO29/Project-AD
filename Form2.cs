using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBA
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnMenuGame_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Game openForm = new Game();
            openForm.ShowDialog();
        }

        private void btnMenuTeam_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Team openForm = new Team();
            openForm.ShowDialog();
        }

        private void btnMenuPlayer_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Player openForm = new Player();
            openForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
