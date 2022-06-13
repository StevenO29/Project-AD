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

        public static string sqlConnection = "server = 139.255.11.84;uid=student;pwd=isbmantap;database=DBD_01_NBA";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection); //Sebagai data koneksi ke DBMS
        public MySqlCommand sqlCommand; //Sebagai perintah SQL (select, insert, update, delete)
        public MySqlDataAdapter sqlAdapter; //Sebagai menampung hasil query
        public string sqlQuery; //Sebagai penampung query SQL

        DataTable dtGame = new DataTable();

        public static string DetailMatch;
        int PosisiSekarang = 0;
        string Home;
        string Away;
        string date;
        string datepick;
        int checkdate = 0;
        int getindex;

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
            try
            {
                sqlQuery = "select date_format(g.game_date, '%Y-%m-%d'), g.HOMETEAM_ID, t1.Team_Name, g.HOME_SCORE,g.AWAYTEAM_ID, t2.Team_Name, g.AWAY_SCORE, g.GAME_ID, s.stadium_name from game g left join team t1 on t1.team_id = g.hometeam_id left join team t2 on t2.team_id = g.awayteam_id left join stadium s on t1.Stadium_id = s.STADIUM_ID where g.status_del = 0;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtGame);
                load(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void load(int Posisi)
        {
            dateGame.Value = Convert.ToDateTime(dtGame.Rows[Posisi][0].ToString());
            Home = dtGame.Rows[Posisi][1].ToString();
            Away = dtGame.Rows[Posisi][4].ToString();
            lbl_teamhome.Text = dtGame.Rows[Posisi][2].ToString();
            lbl_teamaway.Text = dtGame.Rows[Posisi][5].ToString();
            lbStad.Text = $"Stadium :\n{ dtGame.Rows[Posisi][8].ToString()}";
            DetailMatch = dtGame.Rows[Posisi][7].ToString();
            pbox_home.Image = (Image)Properties.Resources.ResourceManager.GetObject(Home);
            pbox_home.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxAway.Image = (Image)Properties.Resources.ResourceManager.GetObject(Away);
            picBoxAway.SizeMode = PictureBoxSizeMode.StretchImage;
            PosisiSekarang = Posisi;
        }
        
        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (PosisiSekarang > 0)
            {
                PosisiSekarang--;
                load(PosisiSekarang);
            }
            else
                MessageBox.Show("Data Sudah Data Pertama");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (PosisiSekarang < dtGame.Rows.Count - 1)
                {
                    PosisiSekarang++;
                    load(PosisiSekarang);
                }
                else
                    MessageBox.Show("Data Sudah Data Terakhir");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                checkdate = 0;
                datepick = dateGame.Value.ToString();
                for (int i = 0; i < dtGame.Rows.Count; i++)
                {
                    if (dateGame.Value.ToString("yyyy-MM-dd") == dtGame.Rows[i][0].ToString())
                    {
                        date = dtGame.Rows[i][0].ToString();
                        checkdate = 1;
                        getindex = i;
                        break;
                    }
                }
                if (checkdate == 1)
                {
                    PosisiSekarang = getindex;
                    load(PosisiSekarang);
                }
                else
                    MessageBox.Show("Tidak ada game pada tanggal yang dipilih");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
