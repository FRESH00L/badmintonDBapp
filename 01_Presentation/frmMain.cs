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
        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmCountries window = new frmCountries();
            this.Hide();
            window.FormClosed += (s, args) => this.Show();
            window.ShowDialog();
        }

        private void btn_Players_Click(object sender, EventArgs e)
        {
            frmPlayers window = new frmPlayers();
            this.Hide();
            window.FormClosed += (s, args) => this.Show();
            window.ShowDialog();
        }

        private void btn_Tournaments_Click_1(object sender, EventArgs e)
        {
            frmTournaments window = new frmTournaments();
            this.Hide();
            window.FormClosed += (s, args) => this.Show();
            window.ShowDialog();
        }
    }
}
