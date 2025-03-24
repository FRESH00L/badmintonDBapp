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
        int MAX_TOURNAMENTS = 10;
        int MIN_TOURNAMENTS = 4;
        int MAX_TOURNAMENTS_PER_SEASON = 7;

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

        public int max_tournaments_per_season
        {
            get { return MAX_TOURNAMENTS_PER_SEASON; }
            set { MAX_TOURNAMENTS_PER_SEASON = value; }
        }
        public Season()
        {
            this.season_year = 2020;
            this.sea_tournament = new Tournament();
            this.seasonDAO = new SeasonDAO();
        }

        public Season(int season_year)
        {
            this.season_year = season_year;
            this.sea_tournament = new Tournament();
            this.seasonDAO = new SeasonDAO();
        }
        public void generate_season()/////////////////////////////////////////////
        {

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
    }
}