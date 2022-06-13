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
        DataTable dtTeamU = new DataTable();
        DataTable dtCekID = new DataTable();

        string playerid;
        string teamid;
        string selecteddata = "and status_del = 0";

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Player openForm = new Player();
            openForm.ShowDialog();
        }

        private void UpdatePlayer_Load(object sender, EventArgs e)
        {
            tbID.MaxLength = 9;
            LoadForm();
            dtTeam.Clear();
            dtPlayer.Clear();
            sqlQuery = "select team_id, team_name from team;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam);

            cbTeamS.DataSource = dtTeam;
            cbTeamS.DisplayMember = "team_name";
            cbTeamS.ValueMember = "team_id";
            lbAva.Text = "";
        }
        private void LoadForm()
        {
            lbAva.Visible = false;
            cbTeamS.Text = "";

            sqlQuery = "select player_id, player_name from player where team_id = '" + teamid + "'" + selecteddata + ";";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPlayer);
            cbPlayerS.DataSource = dtPlayer;
            cbPlayerS.DisplayMember = "player_name";
            cbPlayerS.ValueMember = "player_id";
            cbPlayerS.Text = "";
        }

        private void cbTeamS_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtPlayer.Clear();
            teamid = cbTeamS.SelectedValue.ToString();

            tbID.Text = "";
            tbNameU.Text = "";
            cbPosU.Text = "";
            cbTeamU.Text = "";
            lbAva.Visible = false;

            LoadForm();
        }

        private void cbPlayerS_SelectedIndexChanged(object sender, EventArgs e)
        {
            playerid = "";
            if (cbPlayerS.SelectedValue != null)
                playerid = cbPlayerS.SelectedValue.ToString();
        }

        private void btnDet_Click(object sender, EventArgs e)
        {
            if (playerid != null && playerid != "")
            {
                dtTeamU.Clear();
                sqlQuery = "select team_id, team_name from team;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtTeamU);

                dtPos.Clear();
                sqlQuery = "select distinct pos from player;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPos);

                cbTeamU.DataSource = dtTeamU;
                cbTeamU.ValueMember = "team_id";
                cbTeamU.DisplayMember = "team_name";
                cbPosU.DataSource = dtPos;
                cbPosU.DisplayMember = "pos";
                cbPosU.ValueMember = "pos";

                dtDetail.Clear();
                sqlQuery = "select PLAYER_ID, PLAYER_NAME, team_id, pos, status_del from player where PLAYER_ID = '" + playerid + "' " + selecteddata + ";";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtDetail);

                tbID.Text = dtDetail.Rows[0][0].ToString();
                tbNameU.Text = dtDetail.Rows[0][1].ToString();
                cbTeamU.SelectedValue = dtDetail.Rows[0][2].ToString();
                cbPosU.SelectedValue = dtDetail.Rows[0][3].ToString();

                dtCekID.Clear();
                sqlQuery = "select player_id from player;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtCekID);

                if (dtDetail.Rows[0][4].ToString() == "0")
                {
                    btnDel.Text = "Delete";
                }
                else
                {
                    btnDel.Text = "Restore";
                }
            }
            else
                MessageBox.Show("No player selected!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lbAva.Text == "Available")
            {
                var confirmResult = MessageBox.Show("Are you sure to update this player?", "Confirm Update!", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    sqlQuery = "update player set player_id = '" + tbID.Text + "', player_name = '" + tbNameU.Text + "', team_id = '" + cbTeamU.SelectedValue.ToString() + "', pos = '" + cbPosU.SelectedValue.ToString() + "' where player_id = '" + playerid + "';";
                    sqlConnect.Open();
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();
                    playerid = "";
                    tbID.Text = "";
                    tbNameU.Text = "";
                    cbPosU.Text = "";
                    cbTeamU.Text = "";
                    cbTeamS.Text = "";
                    LoadForm();
                }
            }
            else
                MessageBox.Show("Not Available");
        }

        private void tbID_TextChanged(object sender, EventArgs e)
        {
            CekID();
        }
        private void CekID()
        {
            lbAva.Visible = true;

            bool exist = dtCekID.Select().ToList().Exists(row => row["player_id"].ToString().ToUpper() == tbID.Text.ToUpper());
            if ((exist && tbID.Text != playerid) || tbID.TextLength < 7)
            {
                lbAva.Text = "Not Available";
                lbAva.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lbAva.Text = "Available";
                lbAva.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void chbAllData_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAllData.Checked == true)
                selecteddata = "";
            else
                selecteddata = "and status_del = 0";
            cbTeamS.SelectedIndex = 0;
            LoadForm();
            cbTeamS.Text = "";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lbAva.Text == "Available")
            {
                if (btnDel.Text == "Delete")
                {
                    var confirmResult = MessageBox.Show("Are you sure to delete this player?", "Confirm Delete!", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        sqlQuery = "UPDATE player set status_del = 1 WHERE player_id = '" + playerid + "';";
                        sqlConnect.Open();
                        sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                        sqlCommand.ExecuteNonQuery();
                        sqlConnect.Close();
                        
                    }
                }
                else
                {
                    var confirmResult = MessageBox.Show("Are you sure to restore this player?", "Confirm Restore!", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        sqlQuery = "UPDATE player set status_del = 0 WHERE player_id = '" + playerid + "';";
                        sqlConnect.Open();
                        sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                        sqlCommand.ExecuteNonQuery();
                        sqlConnect.Close();
                    }
                }
                playerid = "";
                tbID.Text = "";
                tbNameU.Text = "";
                cbPosU.Text = "";
                cbTeamU.Text = "";
                cbTeamS.Text = "";
                LoadForm();
            }
        }
    }
}
