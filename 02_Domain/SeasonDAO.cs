using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BazyDanychBadminton._02_Domain;
using BazyDanychBadminton._03_Persistance;

namespace BazyDanychBadminton._02_Domain
{
    internal class SeasonDAO
    {
        public SeasonDAO() { }

        public List<Season> ReadAllSeasons()
        {
            List<Season> result = new List<Season>();
            string sql = "SELECT * FROM Seasons ORDER BY season_year;";
            List<string[]> table = DBBroker.getInstance().Read(sql);
            foreach (string[] row in table)
            {
                Season s = new Season();
                s.Season_year = int.Parse(row[0]);
                //Tournament t = new Tournament(row[1]);
                //t.TouCountry = c;
                result.Add(s);
            }
            return result;
        }

        public int ReadByYear(Season s)
        {
            string sql = "SELECT * FROM Edition WHERE season='" + s.Season_year + "';";
            List<string[]> table = DBBroker.getInstance().Read(sql);
            if (table.Count > 0)
            {
                string[] row = table[0];
                s.Season_year = int.Parse(row[0]);
                Tournament t = new Tournament();
                t.IdTournament = int.Parse(row[1]);
                Edition e = new Edition();
                e.OrderInSeason = int.Parse(row[2]);

            }
            return s.Season_year;
        }

        public int InsertSeason(Season s)
        {
            Match match = new Match();
            Player player = new Player();
            string sql = "INSERT INTO Editions(season, tournament, orderInSeason) VALUES ('" + s.Season_year + "'" + s.Sea_tournament + "'" + s.N_tournaments + "');";
            DBBroker.getInstance().Change(sql);
            for (int i = 0; i < match.Round; i++) 
            {
                string sql2 = "INSERT INTO Matches(idMatch, season, tournament, winner, round) VALUES ('" + match.IdMatch + "'" + s.Season_year + "'" + s.Sea_tournament + "'" + match.Winner + "'" + match.Round + "');"; 
                DBBroker.getInstance().Change(sql2);
                for (int j = 0; j < 7; j++)
                {
                    string sql3 = "INSERT INTO Plays(player, idMatch, set1, set2, set3) VALUES ('" + player.PlaName + "'" + match.IdMatch + "'" + match.Sets[j] + "');";
                    return DBBroker.getInstance().Change(sql3);
                }
            }
            return 0;
        }

        public int DeleteSeason(Season s)
        {
            Match match = new Match();
            Player player = new Player();
            string sql = "DELETE FROM Editions(season, tournament, orderInSeason) VALUES ('" + s.Season_year + "'" + s.Sea_tournament + "'" + s.N_tournaments + "');";
            DBBroker.getInstance().Change(sql);
            for (int i = 0; i < match.Round; i++) 
            {
                string sql2 = "DELETE FROM Matches(idMatch, season, tournament, winner, round) VALUES ('" + match.IdMatch + "'" + s.Season_year + "'" + s.Sea_tournament + "'" + match.Winner + "'" + match.Round + "');"; 
                DBBroker.getInstance().Change(sql2);
                for (int j = 0; j < 7; j++)
                {
                    string sql3 = "DELETE FROM Plays(player, idMatch, set1, set2, set3) VALUES ('" + player.PlaName + "'" + match.IdMatch + "'" + match.Sets[j] + "');";
                    return DBBroker.getInstance().Change(sql3);
                }
            }
            return 0;
        }

        ///////////////////////
        
        public List<Edition> ReadAllEditions()
        {
            List<Edition> result = new List<Edition>();
            string sql = "SELECT * FROM Editions ORDER BY orderInSeason;";
            List<string[]> table = DBBroker.getInstance().Read(sql);
            foreach (string[] row in table)
            {
                Edition e = new Edition();
                e.EditionSeason = new Season(int.Parse(row[0]));
                e.EditionTournament = new Tournament(int.Parse(row[1]));
                e.OrderInSeason = int.Parse(row[2]);
                result.Add(e);
            }
            return result;
        }
        public Edition ReadByOrder(Edition e)
        {
            string sql = "SELECT * FROM Editions WHERE orderInEdition='" + e.OrderInSeason + "';";
            List<string[]> table = DBBroker.getInstance().Read(sql);
            if (table.Count > 0)
            {
                string[] row = table[0];
                e.EditionSeason = new Season(int.Parse(row[0]));
                e.EditionTournament = new Tournament(int.Parse(row[1]));
            }
            return e;
        }
        public int InsertEdition(Edition e)
        {
            string sql = "INSERT INTO Editions(season, tournament, orderInSeason) VALUES ('" + e.EditionSeason + "', '" + e.EditionTournament + "', '" + e.OrderInSeason + "');";
            return DBBroker.getInstance().Change(sql);
        }

        public int DeleteEdition(Edition e)
        {
            string sql = "DELETE FROM Editions WHERE orderInSeason='" + e.OrderInSeason + "';";
            return DBBroker.getInstance().Change(sql);
        }

        //////////////////////////////
        public List<Match> ReadAllMatches()
        {
            List<Match> result = new List<Match>();
            string sql = "SELECT * FROM Matches ORDER BY idMatch;";
            List<string[]> table = DBBroker.getInstance().Read(sql);

            foreach (string[] row in table)
            {
                Match m = new Match();
                m.IdMatch = int.Parse(row[0]);
                m.Season = row[1];
                m.Tournament = row[2];
                m.Round = int.Parse(row[4]);

                Edition e = new Edition(int.Parse(row[1]));
                e.ReadEditionByOrder();
                m.MatchEdition = e;

                Player p1 = new Player(int.Parse(row[2]));
                p1.ReadPlayerById();
                m.Player1 = p1;

                Player p2 = new Player(int.Parse(row[3]));
                p2.ReadPlayerById();
                m.Player2 = p2;

                if (!string.IsNullOrEmpty(row[4]))
                {
                    Player winner = new Player(int.Parse(row[4]));
                    winner.ReadPlayerById();
                    m.Winner = winner;
                }

                result.Add(m);
            }
            return result;
        }

        public void ReadById(Match m)
        {
            string sql = "SELECT * FROM Matches WHERE idMatch='" + m.IdMatch + "';";
            List<string[]> table = DBBroker.getInstance().Read(sql);

            if (table.Count > 0)
            {
                string[] row = table[0];
                m.IdMatch = int.Parse(row[0]);
                m.Season = row[1];
                m.Tournament = row[2];
                m.Round = int.Parse(row[4]);

                Edition e = new Edition(int.Parse(row[1]));
                e.ReadEditionByOrder();
                m.MatchEdition = e;

                Player p1 = new Player(int.Parse(row[2]));
                p1.ReadPlayerById();
                m.Player1 = p1;

                Player p2 = new Player(int.Parse(row[3]));
                p2.ReadPlayerById();
                m.Player2 = p2;

                if (!string.IsNullOrEmpty(row[4]))
                {
                    Player winner = new Player(int.Parse(row[4]));
                    winner.ReadPlayerById();
                    m.Winner = winner;
                }
            }
        }

        public int InsertMatch(Match m)
        {
<<<<<<< HEAD
            string sql = "INSERT INTO Matches (idEdition, idPlayer1, idPlayer2, idWinner) VALUES ('"
                         + m.MatchEdition.OrderInSeason + "', '"
                         + m.Player1.IdPlayer + "', '"
                         + m.Player2.IdPlayer + "', "
                         + (m.Winner != null ? "'" + m.Winner.IdPlayer + "'" : "NULL") + ");";
=======
            string sql = "INSERT INTO Matches (season, tournament, winner, round) VALUES ('"
                         + m.Season + "', '"
                         + m.Tournament + "', "
                         + (m.Winner != null ? "'" + m.Winner.IdPlayer + "'" : "NULL") + ", '"
                         + m.Round + "');";
>>>>>>> 2bc359f2cd20170dfd4a1b096ce4ac8a60cf56b1
            return DBBroker.getInstance().Change(sql);
        }

        public int UpdateMatch(Match m)
        {
<<<<<<< HEAD
            string sql = "UPDATE Matches SET idEdition='" + m.MatchEdition.OrderInSeason +
                         "', idPlayer1='" + m.Player1.IdPlayer +
                         "', idPlayer2='" + m.Player2.IdPlayer +
                         "', idWinner=" + (m.Winner != null ? "'" + m.Winner.IdPlayer + "'" : "NULL") +
                         " WHERE idMatch='" + m.IdMatch + "';";
=======
            string sql = "UPDATE Matches SET season='" + m.Season +
                         "', tournament='" + m.Tournament +
                         "', winner=" + (m.Winner != null ? "'" + m.Winner.IdPlayer + "'" : "NULL") +
                         ", round='" + m.Round +
                         "' WHERE idMatch='" + m.IdMatch + "';";
>>>>>>> 2bc359f2cd20170dfd4a1b096ce4ac8a60cf56b1
            return DBBroker.getInstance().Change(sql);
        }

        public int DeleteMatch(Match m)
        {
            string sql = "DELETE FROM Matches WHERE idMatch='" + m.IdMatch + "';";
            return DBBroker.getInstance().Change(sql);
        }
    }
}