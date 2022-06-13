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

        //coba
        DataTable teamcb = new DataTable();
        DataTable dtstadium = new DataTable();

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
            /*
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
            */

            //coba
            sqlQuery = "select Team_Name as `Team Name`, Team_id as `Team ID` from team where status_del = 0 order by 1";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(teamcb);
            cBoxSearchTeam.DataSource = teamcb;
            cBoxSearchTeam.DisplayMember = "Team Name";
            cBoxSearchTeam.ValueMember = "Team ID";
            sqlQuery = "select Team_Name as 'Team Name', City, CONF_AREA as `Conference Area`, WINS as `Wins`, LOSSES as `Loss`, L10 as `Last 10 Game` from team where status_del = 0 order by 1";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(team);
            dgvTeam.DataSource = team;
            
            sqlQuery = "select s.stadium_name as 'Stadium Name', t.team_name as 'Team Name', s.city as City, s.capacity as Capacity from stadium s left join team t on s.team_id = t.team_id order by 2;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(stadium);
            dgvStadium.DataSource = stadium;
            

            lblStadium.Left = 36;
            lblStadium.Top = 300;

            dgvTeam.RowHeadersVisible = false;
            dgvStadium.RowHeadersVisible = false;
            lblStadCap.Visible = false;
            lbStadCity.Visible = false;
            lblStadName.Visible = false;
            lbName.Visible = false;
            lbCity.Visible = false;
            lbCap.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            teamPlayer.Clear();
            stadium.Clear();

            dgvTeam.Visible = false;
            dgvStadium.Visible = false;
            dgvPlayer.Visible = true;
            pictBoxLogo.Visible = true;
            lbl_teamname.Visible = true;

            sqlQuery = "select p.PLAYER_NAME as `Player Name`, p.POS as `POS`, p.AGE as `AGE`, p.GP as `GP`, p.MPG as `MPG`, p.FTA as `FTA`, p.FTP as `FTP`, p.`2PA` as `2PA`, p.`2PP` as `2PP`, p.`3PA` as `3PA`, p.`3PP` as `3PP`, p.PPG as `PPG`, p.RPG as `RPG`, p.APG as `APG`, p.SPG as `SPG`, p.BPG as `BPG`, p.TOPG as `TOPG` from player p, team t where upper(p.TEAM_ID) = '" + cBoxSearchTeam.SelectedValue.ToString() + "' and p.status_del = 0 group by 1 order by 3";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(teamPlayer);
            dgvPlayer.DataSource = teamPlayer;
            dgvPlayer.RowHeadersVisible = false;

            //logo
            pictBoxLogo.Image = (Image)Properties.Resources.ResourceManager.GetObject(cBoxSearchTeam.SelectedValue.ToString());
            pictBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            lbl_teamname.Text = team.Rows[cBoxSearchTeam.SelectedIndex][0].ToString();

            /*
            sqlQuery = "select stadium_name as `Stadium Name`, stadium_id as `Stadium ID`, team_id as `Team ID`,  capacity as `Capacity`, city as `City` from stadium where team_id = '" + cBoxSearchTeam.SelectedValue.ToString() + "' order by 1";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(stadium);
            dgvStadium.DataSource = stadium;
            */

            lblStadium.Left = 474;
            lblStadium.Top = 320;
            dtstadium.Clear();
            sqlQuery = " select s.stadium_name as 'Stadium Name', s.city as City, s.capacity as Capacity from stadium s where s.team_id = '"+ cBoxSearchTeam.SelectedValue.ToString()+"';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtstadium);
            lblStadName.Text = ": " + dtstadium.Rows[0][0].ToString();
            lblStadCap.Text = ": " + dtstadium.Rows[0][2].ToString();
            lbStadCity.Text = ": " + dtstadium.Rows[0][1].ToString();
            lblStadName.Visible = true;
            lblStadCap.Visible = true;
            lbStadCity.Visible = true;
            lbName.Visible = true;
            lbCity.Visible = true;
            lbCap.Visible = true;
        }

        private void teamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            UpdateTeam updateTeam = new UpdateTeam();
            updateTeam.ShowDialog();
        }
    }
}
