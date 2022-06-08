using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBA
{
    public partial class LoadingPage : Form
    {
        public LoadingPage()
        {
            InitializeComponent();
        }

        private void timerLoad_Tick(object sender, EventArgs e)
        {
            progBarLoadScreen.Value = progBarLoadScreen.Value + 1;
            if (progBarLoadScreen.Value >= 30)
                timerLoad.Enabled = false;
            if (progBarLoadScreen.Value == 30)
            {
                timerLoad.Enabled = false;
                this.Visible = false;
                MainMenu goToMainMenu = new MainMenu();
                goToMainMenu.ShowDialog();
            }
        }
    }
}
