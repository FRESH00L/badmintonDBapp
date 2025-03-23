using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BazyDanychBadminton._01_Presentation
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btn_Countries_Click(object sender, EventArgs e)
        {
            frmCountries window = new frmCountries();
            window.ShowDialog();
        }

        private void btn_Players_Click(object sender, EventArgs e)
        {
            frmPlayers window = new frmPlayers();
            window.ShowDialog();
        }

        private void btn_Tournaments_Click(object sender, EventArgs e)
        {
            frmTournaments window = new frmTournaments();
            window.ShowDialog();
        }

        private void btn_Seasons_Click(object sender, EventArgs e)
        {
            frmSeason window = new frmSeason();
            window.ShowDialog();
        }
    }
}
