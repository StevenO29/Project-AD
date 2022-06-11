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
    public partial class Boxscore : Form
    {
        public Boxscore()
        {
            InitializeComponent();
        }

        public static string sqlConnection = "server = 139.255.11.84;uid=student;pwd=isbmantap;database=DBD_01_NBA";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection); //Sebagai data koneksi ke DBMS
        public MySqlCommand sqlCommand; //Sebagai perintah SQL (select, insert, update, delete)
        public MySqlDataAdapter sqlAdapter; //Sebagai menampung hasil query
        public string sqlQuery; //Sebagai penampung query SQL

        DataTable dtDetail = new DataTable();
        DataTable dtReferee = new DataTable();

        public string Game_ID = Game.DetailMatch;



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Boxscore_Load(object sender, EventArgs e)
        {
            dtDetail.Clear();
            dtReferee.Clear();
            lblRefereeName.Text = "";
            sqlQuery = "select distinct p.PLAYER_NAME as 'Player Name', t.team_name as 'Team Name', b.minute_play as 'Minute Play', b.field_goal, b.FIELD_GOAL_3, b.FREE_THROW, b.assist, b.STEAL, b.`BLOCK` from boxscore b left join team t on b.TEAM_ID = t.Team_id left join player p on p.PLAYER_ID = b.PLAYER_ID where b.GAME_ID = '"+ Game_ID +"' and PLAYER_NAME is not null;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtDetail);
            
            sqlQuery = "select r.REFEREE_NAME from gamereferee g left join referee r on g.referee_id = r.referee_id where g.game_id = '"+ Game_ID +"' and r.referee_name is not null";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtReferee);

            dataDetail.DataSource = dtDetail;
            for (int i = 0; i < dtReferee.Rows.Count; i++)
            {
                lblRefereeName.Text += dtReferee.Rows[i][0].ToString() + " | ";
            }
        }
    }
}