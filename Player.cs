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
    public partial class Player : Form
    {
        public Player()
        {
            InitializeComponent();
        }

        public static string sqlConnection = "server = 139.255.11.84;uid=student;pwd=isbmantap;database=DBD_01_NBA"; 
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection); //Sebagai data koneksi ke DBMS
        public MySqlCommand sqlCommand; //Sebagai perintah SQL (select, insert, update, delete)
        public MySqlDataAdapter sqlAdapter; //Sebagai menampung hasil query
        public string sqlQuery; //Sebagai penampung query SQL

        DataTable teamName = new DataTable();
        DataTable player = new DataTable();

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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void cBoxPlayerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.Clear();
            sqlQuery = "select p.PLAYER_ID as `Player ID`, upper(p.TEAM_ID) as `Team ID`, p.PLAYER_NAME as `Player Name`, p.POS as `POS`, p.AGE as `AGE`, p.GP as `GP`, p.MPG as `MPG`, p.FTA as `FTA`, p.FTP as `FTP`, p.`2PA` as `2PA`, p.`2PP` as `2PP`, p.`3PA` as `3PA`, p.`3PP` as `3PP`, p.PPG as `PPG`, p.RPG as `RPG`, p.APG as `APG`, p.SPG as `SPG`, p.BPG as `BPG`, p.TOPG as `TOPG` from player p, team t where upper(p.TEAM_ID) = '" + cBoxPlayerName.SelectedValue.ToString() + "' group by 1 order by 3";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(player);
            dgv_player.DataSource = player;
            dgv_player.RowHeadersVisible = false;
        }

        private void Player_Load(object sender, EventArgs e)
        {
            sqlQuery = "select * from team order by Team_Name";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(teamName);
            cBoxPlayerName.DataSource = teamName;
            cBoxPlayerName.DisplayMember = "Team_Name";
            cBoxPlayerName.ValueMember = "Team_id";
            sqlQuery = "select p.PLAYER_ID as `Player ID`, upper(p.TEAM_ID) as `Team ID`, p.PLAYER_NAME as `Player Name`, p.POS as `POS`, p.AGE as `AGE`, p.GP as `GP`, p.MPG as `MPG`, p.FTA as `FTA`, p.FTP as `FTP`, p.`2PA` as `2PA`, p.`2PP` as `2PP`, p.`3PA` as `3PA`, p.`3PP` as `3PP`, p.PPG as `PPG`, p.RPG as `RPG`, p.APG as `APG`, p.SPG as `SPG`, p.BPG as `BPG`, p.TOPG as `TOPG` from player p, team t where upper(p.TEAM_ID) = '" + cBoxPlayerName.SelectedValue.ToString() + "' group by 1 order by 3";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(player);
            dgv_player.DataSource = player;
        }

        private void addPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AddPlayer openForm = new AddPlayer();
            openForm.ShowDialog();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            UpdatePlayer openForm = new UpdatePlayer();
            openForm.ShowDialog();
        }
    }
}
