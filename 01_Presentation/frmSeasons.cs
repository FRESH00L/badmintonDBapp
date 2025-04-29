using BazyDanychBadminton._02_Domain;
using MySqlX.XDevAPI.Common;
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
        private List<(Player, List<int>)> frmSeason_Load(object sender, EventArgs e)
        {
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

            List<Match> matches = new List<Match>();
            Match match = new Match();
            List<(Player, List<int>)> final_results = new List<(Player, List<int>)>();

            // Quarterfinal
            var quarterFinals = matches.Where(m => m.Round == "Q").ToList();

            // Semifinal
            var semiFinals = matches.Where(m => m.Round == "S").ToList();

            //Final
            var finals = matches.Where(m => m.Round == "F").ToList();

            try
            {
                List<Player> players = match.ReadMatchPlayer(matches[0]); // Charges 2 players
                List<int> points = new List<int>();

                if (players.Count == 2)
                {
                    var (set1, set2, set3) = match.ReadMatchPoints(matches[0], players[0]);
                    q_score_first_player.Text = $"{set1}, {set2}, {set3}";
                    (set1, set2, set3) = match.ReadMatchPoints(matches[0], players[1]);
                    q_score_second_player.Text = $"{set1}, {set2}, {set3}";

                    q_first_player.Text = players[0].PlaName;
                    q_second_player.Text = players[1].PlaName;
                }
                players = match.ReadMatchPlayer(matches[1]); // Charges 2 players

                if (players.Count == 2)
                {
                    var (set1, set2, set3) = match.ReadMatchPoints(matches[1], players[0]);
                    q_score_third_player.Text = $"{set1}, {set2}, {set3}";
                    (set1, set2, set3) = match.ReadMatchPoints(matches[1], players[1]);
                    q_score_fourth_player.Text = $"{set1}, {set2}, {set3}";

                    q_third_player.Text = players[0].PlaName;
                    q_fourth_player.Text = players[1].PlaName;
                }
                players = match.ReadMatchPlayer(matches[2]); // Charges 2 players

                if (players.Count == 2)
                {
                    var (set1, set2, set3) = match.ReadMatchPoints(matches[2], players[0]);
                    q_score_fifth_player.Text = $"{set1}, {set2}, {set3}";
                    (set1, set2, set3) = match.ReadMatchPoints(matches[2], players[1]);
                    q_score_sixth_player.Text = $"{set1}, {set2}, {set3}";

                    q_fifth_player.Text = players[0].PlaName;
                    q_sixth_player.Text = players[1].PlaName;
                }
                players = match.ReadMatchPlayer(matches[3]); // Charges 2 players

                if (players.Count == 2)
                {
                    var (set1, set2, set3) = match.ReadMatchPoints(matches[3], players[0]);
                    q_score_seventh_player.Text = $"{set1}, {set2}, {set3}";
                    (set1, set2, set3) = match.ReadMatchPoints(matches[3], players[1]);
                    q_score_eightth_player.Text = $"{set1}, {set2}, {set3}";

                    q_seventh_player.Text = players[0].PlaName;
                    q_eighth_player.Text = players[1].PlaName;
                }
                players = match.ReadMatchPlayer(matches[4]); // Charges 2 players

                if (players.Count == 2)
                {
                    var (set1, set2, set3) = match.ReadMatchPoints(matches[4], players[0]);
                    s_score_first_player.Text = $"{set1}, {set2}, {set3}";
                    (set1, set2, set3) = match.ReadMatchPoints(matches[4], players[1]);
                    s_score_second_player.Text = $"{set1}, {set2}, {set3}";

                    s_first_player.Text = players[0].PlaName;
                    s_second_player.Text = players[1].PlaName;
                }
                players = match.ReadMatchPlayer(matches[5]); // Charges 2 players

                if (players.Count == 2)
                {
                    var (set1, set2, set3) = match.ReadMatchPoints(matches[5], players[0]);
                    s_score_third_player.Text = $"{set1}, {set2}, {set3}";
                    (set1, set2, set3) = match.ReadMatchPoints(matches[5], players[1]);
                    s_score_fourth_player.Text = $"{set1}, {set2}, {set3}";

                    s_third_player.Text = players[0].PlaName;
                    s_fourth_player.Text = players[1].PlaName;
                }
                players = match.ReadMatchPlayer(matches[6]); // Charges 2 players

                if (players.Count == 2)
                {
                    var (set1, set2, set3) = match.ReadMatchPoints(matches[6], players[0]);
                    f_score_first_player.Text = $"{set1}, {set2}, {set3}";
                    (set1, set2, set3) = match.ReadMatchPoints(matches[6], players[1]);
                    f_score_second_player.Text = $"{set1}, {set2}, {set3}";

                    f_first_player.Text = players[0].PlaName;
                    f_second_player.Text = players[1].PlaName;
                }

                var final_matches = new List<(Match, List<int>)>();

                // Supposing there is just one final player, we take the first element
                if (final_matches.Count > 0 && final_matches[0].Item1.Winner != null)
                {
                    winner_player.Text = final_matches[0].Item1.Winner.PlaName;
                }
            }catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Error: Index out of range.");
            }
            return final_results;
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
                MessageBox.Show("Theres no elements to choose");
                return;
            }
            if (chbx_ChoseRandomly.Checked)
            {
                if (lbx_ListOfAllTournaments.Items.Count < 4)
                {
                    MessageBox.Show("Not enough tournaments");
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
                    MessageBox.Show("Not enough tournaments in db");
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
                MessageBox.Show("Number of tournaments must cover selected tournaments", "Error", MessageBoxButtons.OK);
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
                MessageBox.Show("Error while generating season:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            MessageBox.Show("Correctly Generated Season");

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
                        MessageBox.Show("Error while deleting season from database:", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while deleting season:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
        private void lbx_ListOfSeasons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbx_ListOfSeasons.SelectedItem != null)
            {
                season.Season_year = int.Parse(lbx_ListOfSeasons.SelectedItem.ToString());
                if (season.ReadSeasonsByYear() <= 0)
                {
                    MessageBox.Show("Error while reading seasons", "Error");
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void q_first_player_Click(object sender, EventArgs e)
        {
            Season s = new Season();
            Match m = new Match();
            s.ReadSeasonsByYear();
            m.ReadMatchById();
            if (m.Round == "Q")
            {
                //m.ReadMatchPlayer(); 
                //q_first_player = m.Player1;
            }

        }

        private void q_second_player_Click(object sender, EventArgs e)
        {
            Season s = new Season();
            Match m = new Match();
            s.ReadSeasonsByYear();
            if (m.Round == "Q")
            {
                //q_second_player = m.Player2;
            }
        }

        private void q_third_player_Click(object sender, EventArgs e)
        {
            Season s = new Season();
            Match m = new Match();
            s.ReadSeasonsByYear();
            if (m.Round == "Q")
            {
                //q_third_player = m.Player1;
            }
        }

        private void q_fourth_player_Click(object sender, EventArgs e)
        {
            Season s = new Season();
            Match m = new Match();
            s.ReadSeasonsByYear();
            if (m.Round == "Q")
            {
                //q_fourth_player = m.Player2;
            }
        }

        private void q_fifth_player_Click(object sender, EventArgs e)
        {
            Season s = new Season();
            Match m = new Match();
            s.ReadSeasonsByYear();
            if (m.Round == "Q")
            {
                //q_fifth_player = m.Player1;
            }
        }

        private void q_sixth_player_Click(object sender, EventArgs e)
        {
            Season s = new Season();
            Match m = new Match();
            s.ReadSeasonsByYear();
            if (m.Round == "Q")
            {
                //q_sixth_player = m.Player2;
            }
        }

        private void q_seventh_player_Click(object sender, EventArgs e)
        {
            Season s = new Season();
            Match m = new Match();
            s.ReadSeasonsByYear();
            if (m.Round == "Q")
            {
                //q_seventh_player = m.Player1;
            }
        }

        private void q_eighth_player_Click(object sender, EventArgs e)
        {
            Season s = new Season();
            Match m = new Match();
            s.ReadSeasonsByYear();
            if (m.Round == "Q")
            {
                //q_eighth_player = m.Player2;
            }
        }

        private void s_first_player_Click(object sender, EventArgs e)
        {
            Season s = new Season();
            Match m = new Match();
            s.ReadSeasonsByYear();
            if (m.Round == "S")
            {
                //s_first_player = m.Player1;
            }
        }

        private void s_second_player_Click(object sender, EventArgs e)
        {
            Season s = new Season();
            Match m = new Match();
            s.ReadSeasonsByYear();
            if (m.Round == "S")
            {
                //s_second_player = m.Player2;
            }
        }

        private void s_third_player_Click(object sender, EventArgs e)
        {
            Season s = new Season();
            Match m = new Match();
            s.ReadSeasonsByYear();
            if (m.Round == "S")
            {
                //s_third_player = m.Player1;
            }
        }

        private void s_fourth_player_Click(object sender, EventArgs e)
        {
            Season s = new Season();
            Match m = new Match();
            s.ReadSeasonsByYear();
            if (m.Round == "S")
            {
                //s_fourth_player = m.Player2;
            }
        }

        private void f_first_player_Click(object sender, EventArgs e)
        {
            Season s = new Season();
            Match m = new Match();
            s.ReadSeasonsByYear();
            if (m.Round == "F")
            {
                //f_first_player = m.Player1;
            }
        }

        private void f_second_player_Click(object sender, EventArgs e)
        {
            Season s = new Season();
            Match m = new Match();
            s.ReadSeasonsByYear();
            m.ReadMatchById();
            if (m.Round == "F")
            {
                //f_second_player = m.Player2;
            }
        }

        private void winner_player_Click(object sender, EventArgs e)
        {
            Season s = new Season();
            Match m = new Match();
            s.ReadSeasonsByYear();
            m.ReadMatchById();
            //winner_player = m.Winner;
        }
    }
}
