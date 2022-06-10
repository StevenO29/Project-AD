using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NBA
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        public static string sqlConnection = "server = localhost;uid=root;pwd=;database=premier_league";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection); //Sebagai data koneksi ke DBMS
        public MySqlCommand sqlCommand; //Sebagai perintah SQL (select, insert, update, delete)
        public MySqlDataAdapter sqlAdapter; //Sebagai menampung hasil query
        public string sqlQuery; //Sebagai penampung query SQL

        private void teamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Team openForm = new Team();
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

        private void btn_detail_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Boxscore openForm = new Boxscore();
            openForm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
