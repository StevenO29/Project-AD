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
    public partial class UpdateTeam : Form
    {
        public UpdateTeam()
        {
            InitializeComponent();
        }

        public static string sqlConnection = "server = 139.255.11.84;uid=student;pwd=isbmantap;database=DBD_01_NBA";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection); //Sebagai data koneksi ke DBMS
        public MySqlCommand sqlCommand; //Sebagai perintah SQL (select, insert, update, delete)
        public MySqlDataAdapter sqlAdapter; //Sebagai menampung hasil query
        public string sqlQuery; //Sebagai penampung query SQL

        DataTable dtTeamName = new DataTable();
        DataTable dtStad = new DataTable();
        DataTable dtTeam = new DataTable();
        DataTable dtCekID = new DataTable();
        
        string teamid;
        string statusdel;
        private void UpdateTeam_Load(object sender, EventArgs e)
        {
            tbTeamID.MaxLength = 3;
            statusdel = "select Team_Name as `Name`, Team_id as ID from team where status_del = 0 order by 1;";
            LoadForm();
        }

        private void LoadForm()
        {
            dtTeamName.Clear();
            dtStad.Clear();
            
            lblAva.Text = "";
            lblAva.ForeColor = System.Drawing.Color.Black;
            sqlQuery = statusdel;
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeamName);
            cbTeam.DataSource = dtTeamName;
            cbTeam.DisplayMember = "Name";
            cbTeam.ValueMember = "ID";
            cbTeam.SelectedValue = 0;

            sqlQuery = "select stadium_id, stadium_name from stadium;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtStad);
            cbStad.DataSource = dtStad;
            cbStad.DisplayMember = "stadium_name";
            cbStad.ValueMember = "stadium_id";
            
            tbTeamID.Text = "";
            tbTeamName.Text = "";
            cbStad.Text = "";
            tbCity.Text = "";
            cbTeam.Text = "";
            cbStad.Text = "";

            lblAva.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lblAva.Text == "Available" && tbTeamID.Text != "" && tbTeamName.Text != "" && cbStad.Text != "" && cbStad.Text != "")
            {
                var confirmResult = MessageBox.Show("Are you sure to update this team?", "Confirm Update!", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    //table team
                    sqlQuery = "UPDATE team SET team_id = '" + tbTeamID.Text + "', Team_name = '" + tbTeamName.Text + "', stadium_id = '" + cbStad.SelectedValue.ToString() + "', City = '" + tbCity.Text + "' WHERE team_id = '" + teamid + "';";
                    sqlConnect.Open();
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();
                    //table stadium
                    sqlQuery = "update stadium set team_id = '" + tbTeamID.Text + "' where team_id = '" + teamid + "';";
                    sqlConnect.Open();
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();
                    //table game
                    sqlQuery = "update game set hometeam_id = '" + tbTeamID.Text + "' where hometeam_id = '" + teamid + "';";
                    sqlConnect.Open();
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();

                    sqlQuery = "update game set awayteam_id = '" + tbTeamID.Text + "' where awayteam_id = '" + teamid + "';";
                    sqlConnect.Open();
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();
                    //table boxscore
                    sqlQuery = "update boxscore set team_id = '" + tbTeamID.Text + "' where team_id = '" + teamid + "';";
                    sqlConnect.Open();
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();
                    //table player
                    sqlQuery = "update player set team_id = '" + tbTeamID.Text + "' where team_id = '" + teamid + "';";
                    sqlConnect.Open();
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();

                    LoadForm();
                }
            }
            else
                MessageBox.Show("Ada data yang tidak diisi");
        }

        private void tbTeamID_TextChanged(object sender, EventArgs e)
        {
            CekID();
        }

        private void CekID()
        {
            lblAva.Visible = true;
            

            bool exist = dtCekID.Select().ToList().Exists(row => row["team_id"].ToString().ToUpper() == tbTeamID.Text.ToUpper());
            if ((exist && tbTeamID.Text != teamid) || tbTeamID.TextLength != 3)
            {
                lblAva.Text = "Not Available";
                lblAva.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblAva.Text = "Available";
                lblAva.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void chbDel_CheckedChanged(object sender, EventArgs e)
        {
            if (chbDel.Checked == true)
            {
                statusdel = "select Team_Name as `Name`, Team_id as ID from team where status_del = 1 order by 1;";
                LoadForm();
            }
            else
            {
                statusdel = "select Team_Name as `Name`, Team_id as ID from team where status_del = 0 order by 1;";
                LoadForm();
            }
                
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (btnDelete.Text == "Delete")
            {
                var confirmResult = MessageBox.Show("Are you sure to delete this team?", "Confirm Delete!", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    sqlQuery = "UPDATE team set status_del = 1 WHERE team_id = '" + teamid + "';";
                    sqlConnect.Open();
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();
                    teamid = "";
                }
            }
            else
            {
                var confirmResult = MessageBox.Show("Are you sure to restore this team?", "Confirm Restore!", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    sqlQuery = "UPDATE team set status_del = 0 WHERE team_id = '" + teamid + "';";
                    sqlConnect.Open();
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();
                    teamid = "";
                }
            }
            LoadForm();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Team OpenWindow = new Team();
            OpenWindow.ShowDialog();
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dtTeam.Clear();
            sqlQuery = "select team_id, team_name, Stadium_id, city, status_del from team where team_id = '" + cbTeam.SelectedValue.ToString() + "';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam);

            tbTeamID.Text = dtTeam.Rows[0][0].ToString();
            tbTeamName.Text = dtTeam.Rows[0][1].ToString();
            cbStad.SelectedValue = dtTeam.Rows[0][2].ToString();
            tbCity.Text = dtTeam.Rows[0][3].ToString();

            dtCekID.Clear();
            sqlQuery = "select team_id from team;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtCekID);

            btnDelete.Visible = true;
            if (dtTeam.Rows[0][4].ToString() == "0")
                btnDelete.Text = "Delete";
            else
                btnDelete.Text = "Restore";
            teamid = cbTeam.SelectedValue.ToString();
            CekID();
        }
    }
}
