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
    public partial class Team : Form
    {
        public Team()
        {
            InitializeComponent();
        }

        public static string sqlConnection = "server = 139.255.11.84;uid=student;pwd=isbmantap;database=DBD_01_NBA";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection); //Sebagai data koneksi ke DBMS
        public MySqlCommand sqlCommand; //Sebagai perintah SQL (select, insert, update, delete)
        public MySqlDataAdapter sqlAdapter; //Sebagai menampung hasil query
        public string sqlQuery; //Sebagai penampung query SQL
        
        DataTable team = new DataTable();
        DataTable teamPlayer = new DataTable();
        DataTable stadium = new DataTable();

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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Team_Load(object sender, EventArgs e)
        {
            sqlQuery = "select Team_Name as `Team Name`, Team_id as `Team ID`, City, CONF_AREA as `Conference Area`, WINS as `Wins`, LOSSES as `Loss`, L10 as `Last 10 Game` from team order by 1";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(team);
            cBoxSearchTeam.DataSource = team;
            cBoxSearchTeam.DisplayMember = "Team Name";
            cBoxSearchTeam.ValueMember = "Team ID";
            dgvTeam.DataSource = team;
            sqlQuery = "select stadium_name as `Stadium Name`, stadium_id as `Stadium ID`, team_id as `Team ID`, capacity as `Capacity`, city as `City` from stadium order by 1";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(stadium);
            dgvStadium.DataSource = stadium;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            teamPlayer.Clear();
            stadium.Clear();
            sqlQuery = "select p.PLAYER_ID as `Player ID`, upper(p.TEAM_ID) as `Team ID`, p.PLAYER_NAME as `Player Name`, p.POS as `POS`, p.AGE as `AGE`, p.GP as `GP`, p.MPG as `MPG`, p.FTA as `FTA`, p.FTP as `FTP`, p.`2PA` as `2PA`, p.`2PP` as `2PP`, p.`3PA` as `3PA`, p.`3PP` as `3PP`, p.PPG as `PPG`, p.RPG as `RPG`, p.APG as `APG`, p.SPG as `SPG`, p.BPG as `BPG`, p.TOPG as `TOPG` from player p, team t where upper(p.TEAM_ID) = '" + cBoxSearchTeam.SelectedValue.ToString() + "' group by 1 order by 3";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(teamPlayer);
            dgvTeam.DataSource = teamPlayer;
            sqlQuery = "select stadium_name as `Stadium Name`, stadium_id as `Stadium ID`, team_id as `Team ID`,  capacity as `Capacity`, city as `City` from stadium where team_id = '" + cBoxSearchTeam.SelectedValue.ToString() + "' order by 1";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(stadium);
            dgvStadium.DataSource = stadium;
        }
    }
}
