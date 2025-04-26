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
        private List<Edition> season_editions;
        private int n_tournaments = 0;
        int MAX_TOURNAMENTS = 7;
        int MIN_TOURNAMENTS = 4;
        
        private SeasonDAO seasonDAO;

        public int Season_year
        {
            get { return season_year; }
            set { season_year = value; }
        }

        public List<Edition> Sea_editions
        {
            get { return season_editions; }
            set { season_editions = value; }
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
            this.season_editions = new List<Edition>();
            this.seasonDAO = new SeasonDAO();
        }

        public Season(int season_year)
        {
            this.season_year = season_year;
            this.MIN_TOURNAMENTS = MIN_TOURNAMENTS;
            this.MAX_TOURNAMENTS = MAX_TOURNAMENTS;
            this.season_editions = new List<Edition>();
            this.seasonDAO = new SeasonDAO();
        }
        public int GenerateSeason(List<Tournament> listT)
        {
            if (ReadSeasonsByYear()>0)
            {
                MessageBox.Show("There's already a season in this year", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            List<Player> players = new Player().ReadAllPlayers();
            if (players.Count < 8)
            {
                MessageBox.Show("There's not enough players", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

            if(listT.Count <= 7 && listT.Count >= 4)
            {
                Random random = new Random();
                int order = 1;
                foreach (Tournament t in listT)
                {

                    t.ReadTournamentByName();

                    List<Player> tournamentPlayers = players.OrderBy(x => random.Next()).Take(8).ToList();
                    List<Match> matches = new List<Match>();
                    List<Player> winners = new List<Player>();

                    for (int i = 0; i < 4; i++)
                    {
                        Match match = new Match()
                        {
                            Player1 = tournamentPlayers[i * 2],
                            Player2 = tournamentPlayers[i * 2 + 1],
                            Round = "Q"
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
                            Round = "S"
                        };
                        semiFinal.SimulateMatch();
                        matches.Add(semiFinal);
                        semiFinalWinners.Add(semiFinal.Winner);
                    }

                    Match finalMatch = new Match()
                    {
                        Player1 = semiFinalWinners[0],
                        Player2 = semiFinalWinners[1],
                        Round = "F"
                    };
                    finalMatch.SimulateMatch();
                    matches.Add(finalMatch);

                    Edition edition = new Edition()
                    {
                        EditionSeason = this,
                        EditionTournament = t,
                        OrderInSeason = order++
                    };
                    foreach (var match in matches)
                    {
                        edition.AddMatch(match);
                    }
                    this.season_editions.Add(edition);
                }

            }            
            InsertSeason(this);
            return 1;
        }

        public int CalculateTotalPointsForPlayer(Player player)
        {
            int totalPoints = 0;

            foreach (Edition edition in this.Sea_editions)
            {
                foreach (Match match in edition.ListOfMatches)
                {
                    foreach (Set set in match.Sets)
                    {
                        if (set.Player1 == player)
                        {
                            totalPoints += set.Player1Points;
                        }
                        else if (set.Player2 == player)
                        {
                            totalPoints += set.Player2Points;
                        }
                    }
                }
            }
            return totalPoints;
        }


        public List<int> ReadAllSeasons()
        {
            return this.seasonDAO.ReadAllSeasons();
        }
        public int ReadSeasonsByYear()
        {
            return this.seasonDAO.ReadByYear(this);
        }
        public int InsertSeason(Season season)
        {
            return this.seasonDAO.InsertSeason(this);
        }
        public int DeleteSeason()
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to delete it?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (dialogResult == DialogResult.Yes)
            {
                return this.seasonDAO.DeleteSeason(this);
            }
            return 0;
        }
        public override string ToString()
        {
            return season_year.ToString();
        }

        public List<int> ReadSeasonsByPlayer(Player player)
        {
            return this.seasonDAO.ReadByPlayer(player);
        }
    }
}