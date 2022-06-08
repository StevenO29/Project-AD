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
    public partial class Team : Form
    {
        public Team()
        {
            InitializeComponent();
        }

        private void gameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Game openForm = new Game();
            openForm.ShowDialog();
        }

        private void playerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Player openForm = new Player();
            openForm.ShowDialog();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainMenu openForm = new MainMenu();
            openForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
