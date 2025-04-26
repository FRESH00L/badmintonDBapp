using BazyDanychBadminton._02_Domain;
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

namespace BazyDanychBadminton._01_Presentation
{

    public partial class frmPlayers : Form
    {
        Player player;
        public frmPlayers()
        {
            InitializeComponent();
        }
        private void lbx_ListOfPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Delete.Enabled = true;
            btn_Update.Enabled = true;
            tbx_isWinner.Text = "";

            player = new Player();
            Tournament tournament = new Tournament();
            List<Tournament> tournaments = new List<Tournament>();
            if (lbx_ListOfPlayers.SelectedItem != null)
            {
                player.PlaName = lbx_ListOfPlayers.SelectedItem.ToString();
            }
            try
            {
                player.ReadPlayerByName();
                tournaments = tournament.ReadTournamentsByPlayer(player);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            lbx_Tournaments.Items.Clear();
            lbx_Editions.Items.Clear();
            cmb_seasonSelector.Items.Clear();
            foreach (Tournament t in tournaments)
            {
                lbx_Tournaments.Items.Add(t.TouName.ToString());
            }
            lbl_PlayerId.Text = player.IdPlayer.ToString();
            dbx_PlayerBirthDate.Value = player.PlaBirthDate;
            tbx_PlayerName.Text = player.PlaName;
            cmb_PlayerCountry.Text = player.PlaCountry.CountryName;

            Season season = new Season();
            List<int> list_season_years = season.ReadSeasonsByPlayer(player);
            foreach (int year in list_season_years)
            {
                cmb_seasonSelector.Items.Add(year);
            }
        }
        private void btn_Insert_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dbx_PlayerBirthDate.Value;
            DateTime today = DateTime.Today;
            int age = today.Year - selectedDate.Year;
            if (selectedDate.Date > today.AddYears(-age))
            {
                age--;
            }
            if (age >= 18)
            {
                player.PlaBirthDate = dbx_PlayerBirthDate.Value;
            }
            else
            {
                MessageBox.Show("Not adult player!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            player = new Player();
            player.PlaName = tbx_PlayerName.Text;
            player.PlaBirthDate = dbx_PlayerBirthDate.Value;


            Country cou = new Country();
            cou.CountryName = cmb_PlayerCountry.Text;
            cou.ReadCountryByName();
            player.PlaCountry = cou;

            try
            {
                if (player.InsertPlayer() == 1)
                {
                    lbx_ListOfPlayers.Items.Add(player.PlaName);
                    tbx_PlayerName.Text = "";
                    dbx_PlayerBirthDate.Text = "";
                    cmb_PlayerCountry.SelectedIndex = -1;
                    btn_Update.Enabled = false;
                    btn_Delete.Enabled = false;
                }
                else
                {
                    MessageBox.Show("An error happened while inserting a player.", "Error: INSERT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            player = new Player(int.Parse(lbl_PlayerId.Text));
            player.ReadPlayerById();
            Player newPlayer = new Player(player.IdPlayer);
            newPlayer.PlaName = tbx_PlayerName.Text;
            newPlayer.PlaBirthDate = dbx_PlayerBirthDate.Value;
            Country country = new Country();
            country.CountryName = cmb_PlayerCountry.Text;
            country.ReadCountryByName();
            newPlayer.PlaCountry = country;

            DateTime selectedDate = dbx_PlayerBirthDate.Value;
            DateTime today = DateTime.Today;
            int age = today.Year - selectedDate.Year;
            if (selectedDate.Date > today.AddYears(-age))
            {
                age--;
            }
            if (age >= 18)
            {
                player.PlaBirthDate = dbx_PlayerBirthDate.Value;
            }
            else
            {
                MessageBox.Show("Not adult player!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                if (newPlayer.UpdatePlayer() == 1)
                {
                    lbx_ListOfPlayers.Items.Remove(player.PlaName);
                    lbx_ListOfPlayers.Items.Add(newPlayer.PlaName);
                    lbl_PlayerId.Text = "";
                    tbx_PlayerName.Text = "";
                    dbx_PlayerBirthDate.Text = "";
                    cmb_PlayerCountry.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("An error happened while updating a country.", "Error: UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            player = new Player(int.Parse(lbl_PlayerId.Text));
            player.PlaName = tbx_PlayerName.Text;
            player.ReadPlayerById();
            try
            {
                if (player.DeletePlayer() == 1)
                {
                    lbx_ListOfPlayers.Items.Remove(player.PlaName);
                    lbl_PlayerId.Text = "";
                    tbx_PlayerName.Text = "";
                    dbx_PlayerBirthDate.Text = "";
                    cmb_PlayerCountry.SelectedIndex = -1;
                    btn_Delete.Enabled = false;
                    btn_Update.Enabled = false;
                }
                else
                {
                    MessageBox.Show("An error happened while deleting a player.", "Error: DELETE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            tbx_PlayerName.Text = "";
            dbx_PlayerBirthDate.Value = DateTime.Now;
            cmb_PlayerCountry.SelectedIndex = -1;
            btn_Delete.Enabled = false;
            btn_Update.Enabled = false;
        }

        private void frmPlayers_Load(object sender, EventArgs e)
        {
            player = new Player();
            List<Player> list_players = player.ReadAllPlayers();
            foreach (Player player in list_players)
            {
                lbx_ListOfPlayers.Items.Add(player.PlaName);
            }

            Country country = new Country();
            List<Country> list_countries = country.ReadAllCountries();
            foreach (Country cou in list_countries)
            {
                cmb_PlayerCountry.Items.Add(cou.CountryName);
            }
        }

        private void player_result(object sender, EventArgs e)
        {
            Player p = new Player();
        }

        private void season_results_button(object sender, EventArgs e)
        {
            if (this.player == null || this.player.IdPlayer <= 0)
            {
                MessageBox.Show("Please, select a player.",
                                "No selected player",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            if (cmb_seasonSelector.SelectedItem == null)
            {
                MessageBox.Show("Please, select a season.",
                                "No selected season",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            Player selectedPlayer = this.player;
            int selectedYear = Convert.ToInt32(cmb_seasonSelector.SelectedItem);
            Season selectedSeason = new Season(selectedYear);

            playersGrid pg = new playersGrid(selectedPlayer, selectedSeason);
            pg.ShowDialog();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbx_Tournaments_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tournament tournament = new Tournament();
            Edition edition = new Edition();
            List<Edition> editions = new List<Edition>();
            if (lbx_Tournaments.SelectedItem != null)
            {
                tournament.TouName = lbx_Tournaments.SelectedItem.ToString();
            }
            try
            {
                tournament.ReadTournamentByName();
                editions = edition.ReadEditionByTournament(tournament);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            lbx_Editions.Items.Clear();
            tbx_isWinner.Text = "";
            foreach (Edition ed in editions)
            {
                lbx_Editions.Items.Add(ed.EditionSeason.ToString());
            }
        }

        private void lbx_Editions_SelectedIndexChanged(object sender, EventArgs e)
        {
            Edition edition = new Edition();
            Match m = new Match();
            if (lbx_Editions.SelectedItem != null)
            {
                Tournament tournament = new Tournament();
                tournament.TouName = lbx_Tournaments.SelectedItem.ToString();
                tournament.ReadTournamentByName();
                Season season = new Season(int.Parse(lbx_Editions.SelectedItem.ToString()));
                edition.EditionSeason = season;
                edition.EditionTournament = tournament;
                edition.ReadEditionBySeasonAndTournament();

                try
                {
                    List<Match> finalMatches = m.ReadMatchByEdition(edition, edition.EditionTournament, "F");
                    player.PlaName = lbx_ListOfPlayers.SelectedItem.ToString();

                    if (finalMatches.Count > 0 && finalMatches[0].Winner.PlaName == player.PlaName)
                    {
                        tbx_isWinner.Text = "Won";
                    }
                    else
                    {
                        tbx_isWinner.Text = "Lost";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
        }

        private void year_elector_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
