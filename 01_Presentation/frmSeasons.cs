using BazyDanychBadminton._02_Domain;
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
    public partial class frmSeasons : Form
    {
        Season season;
        Tournament tournament;
        public frmSeasons()
        {
            InitializeComponent();
        }
        private void frmSeason_Load(object sender, EventArgs e)
        {
            q_first_player.Text = "";
            q_second_player.Text = "";
            q_third_player.Text = "";
            q_fourth_player.Text = "";
            q_fifth_player.Text = "";
            q_sixth_player.Text = "";
            q_seventh_player.Text = "";
            q_eighth_player.Text = "";
            s_first_player.Text = "";
            s_second_player.Text = "";
            s_third_player.Text = "";
            s_fourth_player.Text = "";
            f_first_player.Text = "";
            f_second_player.Text = "";
            winner_player.Text = "";
            q_score_first_player.Text = "";
            q_score_second_player.Text = "";
            q_score_third_player.Text = "";
            q_score_fourth_player.Text = "";
            q_score_fifth_player.Text = "";
            q_score_sixth_player.Text = "";
            q_score_seventh_player.Text = "";
            q_score_eighth_player.Text = "";
            s_score_first_player.Text = "";
            s_score_second_player.Text = "";
            s_score_third_player.Text = "";
            s_score_fourth_player.Text = "";
            f_score_first_player.Text = "";
            f_score_second_player.Text = "";
            winner_score.Text = "";
            season = new Season();
            List<int> list_seasons = season.ReadAllSeasons();
            foreach (int i in list_seasons)
            {
                lbx_ListOfSeasons.Items.Add(i);
            }
            tournament = new Tournament();
            List<Tournament> list_tournament = tournament.ReadAllTournaments();
            foreach (Tournament tournamnet in list_tournament)
            {
                lbx_ListOfAllTournaments.Items.Add(tournamnet.TouName);
            }
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (lbx_ListOfAllTournaments.SelectedItem != null)
            {
                lbx_ListSelectedTournament.Items.Add(lbx_ListOfAllTournaments.SelectedItem.ToString());
                lbx_ListOfAllTournaments.Items.RemoveAt(lbx_ListOfAllTournaments.SelectedIndex);
            }
        }
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearSelectedList();
            lbx_ListOfSeasons.SelectedIndex = -1;
            q_first_player.Text = "";
            q_second_player.Text = "";
            q_third_player.Text = "";
            q_fourth_player.Text = "";
            q_fifth_player.Text = "";
            q_sixth_player.Text = "";
            q_seventh_player.Text = "";
            q_eighth_player.Text = "";
            s_first_player.Text = "";
            s_second_player.Text = "";
            s_third_player.Text = "";
            s_fourth_player.Text = "";
            f_first_player.Text = "";
            f_second_player.Text = "";
            winner_player.Text = "";
            q_score_first_player.Text = "";
            q_score_second_player.Text = "";
            q_score_third_player.Text = "";
            q_score_fourth_player.Text = "";
            q_score_fifth_player.Text = "";
            q_score_sixth_player.Text = "";
            q_score_seventh_player.Text = "";
            q_score_eighth_player.Text = "";
            s_score_first_player.Text = "";
            s_score_second_player.Text = "";
            s_score_third_player.Text = "";
            s_score_fourth_player.Text = "";
            f_score_first_player.Text = "";
            f_score_second_player.Text = "";
            winner_score.Text = "";
        }
        private void ClearSelectedList()
        {
            foreach (object o in lbx_ListSelectedTournament.Items)
            {
                if (!lbx_ListOfAllTournaments.Items.Contains(o))
                    lbx_ListOfAllTournaments.Items.Add(o);
            }
            lbx_ListSelectedTournament.Items.Clear();
        }
        private void chbx_ChoseRandomly_CheckedChanged(object sender, EventArgs e)
        {
            ClearSelectedList();
            if (lbx_ListOfAllTournaments.Items.Count == 0)
            {
                MessageBox.Show("There are no elements to choose.");
                return;
            }
            if (chbx_ChoseRandomly.Checked)
            {
                if (lbx_ListOfAllTournaments.Items.Count < 4)
                {
                    MessageBox.Show("There are not enough tournaments.");
                    return;
                }
                int n = Convert.ToInt16(nud_NumberOfTournament.Value);
                Random rnd = new Random();
                List<int> indexes = Enumerable.Range(0, lbx_ListOfAllTournaments.Items.Count)
                                  .OrderBy(x => rnd.Next())
                                  .Take(n)
                                  .ToList();
                List<object> selectedItems = new List<object>();

                foreach (int index in indexes)
                {
                    selectedItems.Add(lbx_ListOfAllTournaments.Items[index]);
                }

                foreach (var item in selectedItems)
                {
                    lbx_ListSelectedTournament.Items.Add(item.ToString());
                    lbx_ListOfAllTournaments.Items.Remove(item);
                }
            }
        }
        private void chbx_GenerateRandomly_CheckedChanged(object sender, EventArgs e)
        {
            if (chbx_GenerateRandomly.Checked)
            {
                int n = lbx_ListOfAllTournaments.Items.Count;
                if (n > 3)
                {
                    if (n > 7) n = 7;
                    Random rnd = new Random();
                    int nTou = rnd.Next(4, n + 1);
                    nud_NumberOfTournament.Value = nTou;
                }
                else
                {
                    MessageBox.Show("There are not enough tournaments in database.");
                }
            }
        }
        private void btn_GenerateSeason_Click(object sender, EventArgs e)
        {
            season = new Season(Convert.ToInt16(nud_SeasonYear.Value));
            int nTou = Convert.ToInt16(nud_NumberOfTournament.Value);
            List<Tournament> listOfTournaments = new List<Tournament>();
            foreach (Object o in lbx_ListSelectedTournament.Items)
            {
                Tournament t = new Tournament();
                t.TouName = o.ToString();
                t.ReadTournamentByName();
                listOfTournaments.Add(t);
            }
            if (!(listOfTournaments.Count == nTou))
            {
                MessageBox.Show("The number of tournaments must cover the selected tournaments.", "Error", MessageBoxButtons.OK);
                return;
            }
            try
            {
                if (season.GenerateSeason(listOfTournaments) <= 0)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while generating the season." + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            MessageBox.Show("Correctly Generated Season.");

            lbx_ListOfAllTournaments.Items.Clear();
            tournament = new Tournament();
            List<Tournament> list_tournament = tournament.ReadAllTournaments();
            foreach (Tournament tournamnet in list_tournament)
            {
                lbx_ListOfAllTournaments.Items.Add(tournamnet.TouName);
            }
            lbx_ListOfSeasons.Items.Add(season);
        }
        private void btn_DeleteSeason_Click(object sender, EventArgs e)
        {  
            if (lbx_ListOfSeasons.SelectedItem != null)
            {
                try
                {
                    season = new Season(int.Parse(lbx_ListOfSeasons.SelectedItem.ToString()));
                    season.ReadSeasonsByYear();
                    if (season.DeleteSeason() > 0)
                    {
                        lbx_ListOfSeasons.Items.Clear();
                        List<int> list_seasons = season.ReadAllSeasons();
                        foreach (int i in list_seasons)
                        {
                            lbx_ListOfSeasons.Items.Add(i);
                        }
                        lbx_ListSelectedTournament.Items.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Error while deleting season from database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while deleting season." + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
        private void lbx_ListOfSeasons_SelectedIndexChanged(object sender, EventArgs e)
        {
            q_first_player.Text = "";
            q_second_player.Text = "";
            q_third_player.Text = "";
            q_fourth_player.Text = "";
            q_fifth_player.Text = "";
            q_sixth_player.Text = "";
            q_seventh_player.Text = "";
            q_eighth_player.Text = "";
            s_first_player.Text = "";
            s_second_player.Text = "";
            s_third_player.Text = "";
            s_fourth_player.Text = "";
            f_first_player.Text = "";
            f_second_player.Text = "";
            winner_player.Text = "";
            q_score_first_player.Text = "";
            q_score_second_player.Text = "";
            q_score_third_player.Text = "";
            q_score_fourth_player.Text = "";
            q_score_fifth_player.Text = "";
            q_score_sixth_player.Text = "";
            q_score_seventh_player.Text = "";
            q_score_eighth_player.Text = "";
            s_score_first_player.Text = "";
            s_score_second_player.Text = "";
            s_score_third_player.Text = "";
            s_score_fourth_player.Text = "";
            f_score_first_player.Text = "";
            f_score_second_player.Text = "";
            winner_score.Text = "";
            btn_DeleteSeason.Enabled = true;
            if (lbx_ListOfSeasons.SelectedItem != null)
            {
                season.Season_year = int.Parse(lbx_ListOfSeasons.SelectedItem.ToString());
                if (season.ReadSeasonsByYear() <= 0)
                {
                    MessageBox.Show("Error while reading seasons.", "Error");
                    return;
                }
                nud_SeasonYear.Value = season.Season_year;
                lbx_ListSelectedTournament.Items.Clear();
                foreach (Edition ed in season.Sea_editions)
                {
                    ed.EditionTournament.ReadTournamentById();
                    lbx_ListSelectedTournament.Items.Add(ed.EditionTournament.TouName);
                }
            }
        }
        private void lbx_ListSelectedTournament_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearLabels();

            if (lbx_ListSelectedTournament.SelectedItem != null && lbx_ListOfSeasons.SelectedItem != null)
            {
                Tournament tournament = new Tournament();
                tournament.TouName = lbx_ListSelectedTournament.SelectedItem.ToString();
                tournament.ReadTournamentByName();
                Edition edition = new Edition();
                edition.EditionSeason.Season_year = int.Parse(lbx_ListOfSeasons.SelectedItem.ToString());
                edition.EditionTournament = tournament;
                edition.ReadEditionBySeasonAndTournament();

                Match match = new Match();
                List<Match> quarterFinalMatches = match.ReadMatchByEdition(edition, edition.EditionTournament, "Q");
                List<Match> semiFinalMatches = match.ReadMatchByEdition(edition, edition.EditionTournament, "S");
                List<Match> finalMatches = match.ReadMatchByEdition(edition, edition.EditionTournament, "F");
                if (quarterFinalMatches.Count != 4 && semiFinalMatches.Count != 2 && finalMatches.Count != 1)
                {
                    MessageBox.Show("Error while reading seasons.", "Error");
                    return;
                }

                // Q
                List<Player> players = match.ReadMatchPlayer(quarterFinalMatches[0]);
                List<int> points = new List<int>();

                if (players.Count == 2)
                {
                    var (set1, set2, set3) = match.ReadMatchPoints(quarterFinalMatches[0], players[0]);
                    q_score_first_player.Text = $"{set1}, {set2}, {set3}";
                    (set1, set2, set3) = match.ReadMatchPoints(quarterFinalMatches[0], players[1]);
                    q_score_second_player.Text = $"{set1}, {set2}, {set3}";

                    q_first_player.Text = players[0].PlaName;
                    q_second_player.Text = players[1].PlaName;
                }
                players = match.ReadMatchPlayer(quarterFinalMatches[1]);

                if (players.Count == 2)
                {
                    var (set1, set2, set3) = match.ReadMatchPoints(quarterFinalMatches[1], players[0]);
                    q_score_third_player.Text = $"{set1}, {set2}, {set3}";
                    (set1, set2, set3) = match.ReadMatchPoints(quarterFinalMatches[1], players[1]);
                    q_score_fourth_player.Text = $"{set1}, {set2}, {set3}";

                    q_third_player.Text = players[0].PlaName;
                    q_fourth_player.Text = players[1].PlaName;
                }
                players = match.ReadMatchPlayer(quarterFinalMatches[2]);

                if (players.Count == 2)
                {
                    var (set1, set2, set3) = match.ReadMatchPoints(quarterFinalMatches[2], players[0]);
                    q_score_fifth_player.Text = $"{set1}, {set2}, {set3}";
                    (set1, set2, set3) = match.ReadMatchPoints(quarterFinalMatches[2], players[1]);
                    q_score_sixth_player.Text = $"{set1}, {set2}, {set3}";

                    q_fifth_player.Text = players[0].PlaName;
                    q_sixth_player.Text = players[1].PlaName;
                }
                players = match.ReadMatchPlayer(quarterFinalMatches[3]);

                if (players.Count == 2)
                {
                    var (set1, set2, set3) = match.ReadMatchPoints(quarterFinalMatches[3], players[0]);
                    q_score_seventh_player.Text = $"{set1}, {set2}, {set3}";
                    (set1, set2, set3) = match.ReadMatchPoints(quarterFinalMatches[3], players[1]);
                    q_score_eighth_player.Text = $"{set1}, {set2}, {set3}";

                    q_seventh_player.Text = players[0].PlaName;
                    q_eighth_player.Text = players[1].PlaName;
                }

                // S
                players = match.ReadMatchPlayer(semiFinalMatches[0]);

                if (players.Count == 2)
                {
                    var (set1, set2, set3) = match.ReadMatchPoints(semiFinalMatches[0], players[0]);
                    s_score_first_player.Text = $"{set1}, {set2}, {set3}";
                    (set1, set2, set3) = match.ReadMatchPoints(semiFinalMatches[0], players[1]);
                    s_score_second_player.Text = $"{set1}, {set2}, {set3}";

                    s_first_player.Text = players[0].PlaName;
                    s_second_player.Text = players[1].PlaName;
                }
                players = match.ReadMatchPlayer(semiFinalMatches[1]);

                if (players.Count == 2)
                {
                    var (set1, set2, set3) = match.ReadMatchPoints(semiFinalMatches[1], players[0]);
                    s_score_third_player.Text = $"{set1}, {set2}, {set3}";
                    (set1, set2, set3) = match.ReadMatchPoints(semiFinalMatches[1], players[1]);
                    s_score_fourth_player.Text = $"{set1}, {set2}, {set3}";

                    s_third_player.Text = players[0].PlaName;
                    s_fourth_player.Text = players[1].PlaName;
                }
                // F
                players = match.ReadMatchPlayer(finalMatches[0]);

                if (players.Count == 2)
                {
                    var (set1, set2, set3) = match.ReadMatchPoints(finalMatches[0], players[0]);
                    f_score_first_player.Text = $"{set1}, {set2}, {set3}";
                    (set1, set2, set3) = match.ReadMatchPoints(finalMatches[0], players[1]);
                    f_score_second_player.Text = $"{set1}, {set2}, {set3}";

                    f_first_player.Text = players[0].PlaName;
                    f_second_player.Text = players[1].PlaName;
                }
                // W
                if (finalMatches[0].Winner != null)
                {
                    var (set1, set2, set3) = match.ReadMatchPoints(finalMatches[0], players[0]);
                    winner_score.Text = $"{set1}, {set2}, {set3}";
                    winner_player.Text = finalMatches[0].Winner.PlaName;
                }
            }
        }

        public void clearLabels()
        {
            q_first_player.Text = "";
            q_second_player.Text = "";
            q_third_player.Text = "";
            q_fourth_player.Text = "";
            q_fifth_player.Text = "";
            q_sixth_player.Text = "";
            q_seventh_player.Text = "";
            q_eighth_player.Text = "";
            s_first_player.Text = "";
            s_second_player.Text = "";
            s_third_player.Text = "";
            s_fourth_player.Text = "";
            f_first_player.Text = "";
            f_second_player.Text = "";
            winner_player.Text = "";
            q_score_first_player.Text = "";
            q_score_second_player.Text = "";
            q_score_third_player.Text = "";
            q_score_fourth_player.Text = "";
            q_score_fifth_player.Text = "";
            q_score_sixth_player.Text = "";
            q_score_seventh_player.Text = "";
            q_score_eighth_player.Text = "";
            s_score_first_player.Text = "";
            s_score_second_player.Text = "";
            s_score_third_player.Text = "";
            s_score_fourth_player.Text = "";
            f_score_first_player.Text = "";
            f_score_second_player.Text = "";
            winner_score.Text = "";
        }
    }
}
