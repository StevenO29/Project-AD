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
    public partial class Player : Form
    {
        public Player()
        {
            InitializeComponent();
        }

        private void gameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Game openForm = new Game();
            openForm.ShowDialog();
        }

        private void teamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Team openForm = new Team();
            openForm.ShowDialog();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainMenu openForm = new MainMenu();
            openForm.ShowDialog();
        }
    }
}
