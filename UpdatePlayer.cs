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
    public partial class UpdatePlayer : Form
    {
        public UpdatePlayer()
        {
            InitializeComponent();
        }

        public static string sqlConnection = "server = 139.255.11.84;uid=student;pwd=isbmantap;database=DBD_01_NBA";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection); //Sebagai data koneksi ke DBMS
        public MySqlCommand sqlCommand; //Sebagai perintah SQL (select, insert, update, delete)
        public MySqlDataAdapter sqlAdapter; //Sebagai menampung hasil query
        public string sqlQuery; //Sebagai penampung query SQL

        DataTable dtPos = new DataTable();
        DataTable dtTeam = new DataTable();
        DataTable dtPlayer = new DataTable();
        DataTable dtDetail = new DataTable();

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Team OpenWindow = new Team();
            OpenWindow.ShowDialog();
            this.Close();
        }

        private void UpdatePlayer_Load(object sender, EventArgs e)
        {
            sqlQuery = "select distinct pos from player;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPos);
            sqlQuery = "select team_id, team_name from team;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam);

            cbTeamS.DataSource = dtTeam;
            cbTeamS.DisplayMember = "team_name";
            cbTeamS.ValueMember = "team_id";

            cbTeamU.ValueMember = "team_id";
            cbTeamU.DisplayMember = "team_name";
            cbPosU.DisplayMember = "pos";
        }

        private void cbTeamS_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtPlayer.Clear();
            sqlQuery = "select player_id, player_name from player where team_id = '"+ cbTeamS.SelectedValue.ToString() +"'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPlayer);
            cbPlayerS.DataSource = dtPlayer;
            cbPlayerS.DisplayMember = "player_name";
            cbPlayerS.ValueMember = "player_id";
        }

        private void btnDet_Click(object sender, EventArgs e)
        {
            dtPlayer.Clear();
            sqlQuery = "select p.PLAYER_ID, p.PLAYER_NAME, p.team_id, p.pos from player p left where PLAYER_ID = '"+ cbPlayerS.SelectedValue.ToString() +"' and p.status_del = 0;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtDetail);

            tbID.Text = dtDetail.Rows[0][0].ToString();
            tbNameU.Text = dtDetail.Rows[0][1].ToString();
            cbTeamS.SelectedValue = dtDetail.Rows[0][3].ToString();
            cbPosU.SelectedText = dtDetail.Rows[0][4].ToString();
        }
    }
}
