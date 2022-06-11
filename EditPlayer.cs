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
    public partial class AddPlayer : Form
    {
        public AddPlayer()
        {
            InitializeComponent();
        }

        public static string sqlConnection = "server = 139.255.11.84;uid=student;pwd=isbmantap;database=DBD_01_NBA";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection); //Sebagai data koneksi ke DBMS
        public MySqlCommand sqlCommand; //Sebagai perintah SQL (select, insert, update, delete)
        public MySqlDataAdapter sqlAdapter; //Sebagai menampung hasil query
        public string sqlQuery; //Sebagai penampung query SQL

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Player openForm = new Player();
            openForm.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                sqlQuery = "insert into player (PLAYER_ID, TEAM_ID, PLAYER_NAME, POS, AGE) values ('" + txtBoxPlayerID.Text + "', '" + txtBoxTeamID.Text + "', '" + txtBoxPlayerName.Text + "', '" + txtBoxPOS.Text + "', '" + numUpDownAge.Value.ToString() + "')";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Data Player bernama " + txtBoxPlayerName.Text + " berhasil diinput!");
                this.Visible = false;
                Player openForm = new Player();
                openForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddPlayer_Load(object sender, EventArgs e)
        {
            sqlConnect.Open();
        }
    }
}
