using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BazyDanychBadminton._02_Domain;

namespace BazyDanychBadminton._01_Presentation
{
    public partial class frmTournaments : Form
    {
        Tournament tournament;
        public frmTournaments()
        {
            InitializeComponent();
        }

        private void lbx_Tournaments_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Update.Enabled = true;
            btn_Delete.Enabled = true;

            tournament = new Tournament();
            if (lbx_Tournaments.SelectedItem != null)
            {
                tournament.TouName = lbx_Tournaments.SelectedItem.ToString();
            }
            try
            {
                tournament.ReadTournamentByName();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            tbx_TournamentName.Text = tournament.TouName;
            tbx_TournamentCity.Text = tournament.TouCity;
            cmb_TournamentCountry.Text = tournament.TouCountry.CountryName;
        }

        private void frmTournaments_Load_1(object sender, EventArgs e)
        {
            tournament = new Tournament();
            List<Tournament> list_tournaments = tournament.ReadAllTournaments();
            foreach (Tournament tournament in list_tournaments)
            {
                lbx_Tournaments.Items.Add(tournament.TouName);
            }

            Country country = new Country();
            List<Country> list_countries = country.ReadAllCountries();
            foreach (Country cou in list_countries)
            {
                cmb_TournamentCountry.Items.Add(cou.CountryName);
            }
        }
        private void btn_Insert_Click(object sender, EventArgs e)
        {
            tournament = new Tournament();
            tournament.TouName = tbx_TournamentName.Text;
            tournament.TouCity = tbx_TournamentCity.Text;

          
            Country cou = new Country();
            cou.CountryName = cmb_TournamentCountry.Text;
            cou.ReadCountryByName();
            tournament.TouCountry = cou;

            try
            {
                if (tournament.InsertTournament() == 1)
                {
                    lbx_Tournaments.Items.Add(tournament.TouName);
                    tbx_TournamentName.Text = "";
                    tbx_TournamentCity.Text = "";
                    cmb_TournamentCountry.SelectedIndex = -1;
                    btn_Update.Enabled = false;
                    btn_Delete.Enabled = false;
                }
                else
                {
                    MessageBox.Show("\"An error happened while inserting the tournament.", "Error: INSERT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            tournament = new Tournament();
            tournament.ReadTournamentById();
            try
            {
                if (tournament.DeleteTournament() == 1)
                {
                    lbx_Tournaments.Items.Remove(tournament.TouName);
                    tbx_TournamentName.Text = "";
                    tbx_TournamentCity.Text = "";
                    cmb_TournamentCountry.Text = "";
                    btn_Update.Enabled = false;
                    btn_Delete.Enabled = false;
                }
                else
                {
                    MessageBox.Show("An error happened while deleting a country.", "Error: DELETE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tbx_TournamentName.Text = "";
            tbx_TournamentCity.Text = "";
            cmb_TournamentCountry.Text = "";
            btn_Delete.Enabled = false;
            btn_Update.Enabled = false;
        }
    }
}

