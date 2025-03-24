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
    public partial class frmSeason : Form
    {
        Season season;
        Tournament tournament;
        public frmSeason()
        {
            InitializeComponent();
        }
<<<<<<< HEAD

        private void frmSeason_Load(object sender, EventArgs e)
        {
            //season = new Season();
            //List<Season> list_seasons = season.ReadAllSeasons();
            //foreach (Season season in list_seasons)
            //{
            //    lbx_ListOfSeasons.Items.Add(season.Season_year);
            //}

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
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            lbx_ListSelectedTournament.Items.Clear();
        }

        private void chbx_ChoseRandomly_CheckedChanged(object sender, EventArgs e)
        {
            lbx_ListSelectedTournament.Items.Clear();
            if (lbx_ListOfAllTournaments.Items.Count == 0)
            {
                MessageBox.Show("Theres no elements to choose");
                return;
            }
            if (chbx_ChoseRandomly.Checked)
            {
                Random rnd = new Random();
                int nTou = rnd.Next(1, lbx_ListOfAllTournaments.Items.Count + 1);
                List<int> indexes = Enumerable.Range(0, lbx_ListOfAllTournaments.Items.Count)
                                  .OrderBy(x => rnd.Next())
                                  .Take(nTou)
                                  .ToList();
                foreach (int index in indexes)
                {
                    lbx_ListSelectedTournament.Items.Add(lbx_ListOfAllTournaments.Items[index].ToString()); // Rzutowanie na Tournament
                }
            }
        }

        private void chbx_GenerateRandomly_CheckedChanged(object sender, EventArgs e)
        {
            if (chbx_GenerateRandomly.Checked)
            {
                Random rnd = new Random();
                int nTou = rnd.Next(4, 8);
                nud_NumberOfTournament.Value = nTou;

            }
        }
        private void btn_GenerateSeason_Click(object sender, EventArgs e)
        {
            season = new Season();
            try
            {
                season.generate_season();
                season.InsertSeason();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while generating season:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            lbx_ListOfSeasons.Items.Add(season);

        }
        private void btn_DeleteSeason_Click(object sender, EventArgs e)
        {
            if(lbx_ListOfSeasons.SelectedItem != null && lbx_ListOfSeasons.SelectedItem is Season selectedSeason)
            {
                try
                {
                    season = new Season(selectedSeason.Season_year);
                    season.ReadSeasonsByYear();
                    if (season.DeleteSeason() > 0)
                    {
                        lbx_ListOfSeasons.Items.Remove(selectedSeason);
                    }
                    else
                    {
                        MessageBox.Show("Error while deleting season from database:", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        return;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error while deleting season:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        
=======
>>>>>>> ee3f4febb1813044380a4c2f826246ced474d8f0
    }
}
