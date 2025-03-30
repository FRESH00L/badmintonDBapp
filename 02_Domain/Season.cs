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
        public int GenerateSeason(int nTou)
        {
            if (ReadSeasonsByYear() <=0)
            {
                MessageBox.Show("There's already a season in this year", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }

            Random random = new Random();
            List<Player> players = new Player().ReadAllPlayers();
            if (players.Count < 8)
            {
                MessageBox.Show("There's not enough players", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

            int numberOfTournaments = nTou;
            for (int t = 0; t < numberOfTournaments; t++)
            {
                Tournament tournament = new Tournament() { TouName = this.Season_year + " Tournament " + (t + 1) };
                tournament.InsertTournament();

                List<Player> tournamentPlayers = players.OrderBy(x => random.Next()).Take(8).ToList();
                List<Match> matches = new List<Match>();
                List<Player> winners = new List<Player>();

                for (int i = 0; i < 4; i++)
                {
                    Match match = new Match()
                    {
                        Player1 = tournamentPlayers[i * 2],
                        Player2 = tournamentPlayers[i * 2 + 1],
                        Round = 1
                    };
                    match.SimulateMatch();
                    matches.Add(match);
                    winners.Add(match.Winner);
                }

                List<Player> semiFinalWinners = new List<Player>();
                for (int i = 0; i < 2; i++)
                {
                    Match semiFinal = new Match()
                    {
                        Player1 = winners[i * 2],
                        Player2 = winners[i * 2 + 1],
                        Round = 2
                    };
                    semiFinal.SimulateMatch();
                    matches.Add(semiFinal);
                    semiFinalWinners.Add(semiFinal.Winner);
                }

                Match finalMatch = new Match()
                {
                    Player1 = semiFinalWinners[0],
                    Player2 = semiFinalWinners[1],
                    Round = 3
                };
                finalMatch.SimulateMatch();
                matches.Add(finalMatch);

                Edition edition = new Edition()
                {
                    EditionSeason = this,
                    EditionTournament = tournament,
                    OrderInSeason = t + 1
                };
                foreach (var match in matches)
                {
                    edition.AddMatch(match);
                }
                edition.InsertEdition();
            }

            InsertSeason();
            return 1;
        }


        public List<Season> ReadAllSeasons()
        {
            return this.seasonDAO.ReadAll();
        }
        public int ReadSeasonsByYear()
        {
            return this.seasonDAO.ReadByYear(this);
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