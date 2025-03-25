using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazyDanychBadminton._02_Domain
{
    public class Season
    {
        private int season_year;
        private Tournament sea_tournament;
        private int n_tournaments;
        int MAX_TOURNAMENTS = 7;
        int MIN_TOURNAMENTS = 4;
        //
        private SeasonDAO seasonDAO;

        public int Season_year
        {
            get { return season_year; }
            set { season_year = value; }
        }

        public Tournament Sea_tournament
        {
            get { return sea_tournament; }
            set { sea_tournament = value; }
        }

        public int N_tournaments
        {
            get { return n_tournaments; }
            set { n_tournaments = value; }
        }

        public int max_tournaments
        {
            get { return MAX_TOURNAMENTS; }
            set { MAX_TOURNAMENTS = value; }
        }

        public int min_tournaments
        {
            get { return MIN_TOURNAMENTS; }
            set { MIN_TOURNAMENTS = value; }
        }
        //
        public Season()
        {
            this.season_year = 2020;
            this.MIN_TOURNAMENTS = 4;
            this.MAX_TOURNAMENTS = 7;
            this.sea_tournament = new Tournament();
            this.seasonDAO = new SeasonDAO();
        }

        public Season(int season_year)
        {
            this.season_year = season_year;
            this.MIN_TOURNAMENTS = MIN_TOURNAMENTS;
            this.MAX_TOURNAMENTS = MAX_TOURNAMENTS;
            this.sea_tournament = new Tournament();
            this.seasonDAO = new SeasonDAO();
        }
        public int generate_season()
        {
            Random random = new Random();
            //n_tournaments = n_tournaments.
            if (n_tournaments > MIN_TOURNAMENTS && n_tournaments < MAX_TOURNAMENTS)
            {
                if (season_year != 0)
                {
                    for (int i = 0; i < n_tournaments; i++)
                    {
                        Tournament tournament = new Tournament();
                        if (tournament.TouName != "")
                        {
                            tournament.InsertTournament();
                        }
                        else
                        {
                            return -1;
                        }
                    }
                }
                return 1;
            }
            else
            {
                return -1;
            }
            //if(random == 1) //generar numero de torneos random
            // {
            //  n_tournaments = random.Next(MIN_TOURNAMENTS, MAX_TOURNAMENTS);

            //  return n_tournaments;
            // }

        }

        public List<Season> ReadAllSeasons()
        {
            return this.seasonDAO.ReadAll();
        }
        public void ReadSeasonsByYear()
        {
            this.seasonDAO.ReadByYear(this);
        }
        public int InsertSeason()
        {
            return this.seasonDAO.Insert(this);
        }
        public int DeleteSeason()
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to delete it?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (dialogResult == DialogResult.Yes)
            {
                return this.seasonDAO.Delete(this);
            }
            return 0;
        }
        public override string ToString()
        {
            return Season_year.ToString();
        }

        /////////////////////////////////
        public List<Edition> ReadAllEditions()
        {
            return this.seasonDAO.ReadAllEditions();
        }
        public Edition ReadEditionByOrder(Edition e)
        {
            return this.seasonDAO.ReadByOrder(e);
        }
        public int InsertEdition(Edition e)
        {
            return this.seasonDAO.InsertEdition(e);
        }
        public int DeleteEdition(Edition e)
        {
            return this.seasonDAO.DeleteEdition(e);
        }
    }
}