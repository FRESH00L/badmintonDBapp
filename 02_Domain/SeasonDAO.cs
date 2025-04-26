using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BazyDanychBadminton._02_Domain;
using BazyDanychBadminton._03_Persistance;
using Google.Protobuf.Reflection;

namespace BazyDanychBadminton._02_Domain
{
    public class SeasonDAO
    {
        public SeasonDAO() { }
        public List<int> ReadAllSeasons()
        {
            List<int> result = new List<int>();
            string sql = "SELECT DISTINCT season FROM Editions ORDER BY season;";
            List<string[]> table = DBBroker.getInstance().Read(sql);

            foreach (string[] row in table)
            {
                result.Add(int.Parse(row[0]));
            }
            return result;
        }

        public int ReadByYear(Season s)
        {
            string sql = "SELECT * FROM Editions WHERE season='" + s.Season_year + " ORDER BY OrderInSeason';";
            List<string[]> table = DBBroker.getInstance().Read(sql);
            if (table.Count > 0)
            {
                s.Sea_editions = new List<Edition>();
                foreach (string[] row in table)
                {
                    s.Season_year = int.Parse(row[0]);
                    Tournament t = new Tournament(int.Parse(row[1]));
                    Edition e = new Edition();
                    e.EditionTournament = t;
                    e.EditionSeason = s;
                    e.OrderInSeason = int.Parse(row[2]);

                    string sql2 = "SELECT * FROM Matches WHERE season='" + s.Season_year + "' AND tournament='" + t.IdTournament + "';";
                    List<string[]> table2 = DBBroker.getInstance().Read(sql2);
                    foreach (string[] row2 in table2)
                    {
                        Match m = new Match();
                        m.IdMatch = int.Parse(row2[0]);
                        e.ListOfMatches.Add(m);
                    }

                    s.Sea_editions.Add(e);
                }
                return 1;
            }
            return 0;
        }

        public int InsertSeason(Season s)
        {
            foreach (Edition edition in s.Sea_editions)
            {
                List<Match> matches = edition.ListOfMatches;
                string sql = "INSERT INTO Editions(season, tournament, orderInSeason) VALUES ('" + s.Season_year + "', '" + edition.EditionTournament.IdTournament + "', '" + edition.OrderInSeason + "');";
                DBBroker.getInstance().Change(sql);

                foreach(Match m in matches)
                {
                    string sql2 = "INSERT INTO Matches(idMatch, season, tournament, winner, round) VALUES ('" + m.IdMatch + "', '" + edition.EditionSeason.Season_year + "', '" + edition.EditionTournament.IdTournament + "', '" + m.Winner.IdPlayer + "', '" + m.Round + "');";
                    DBBroker.getInstance().Change(sql2);
                    string sqlLastId = "SELECT LAST_INSERT_ID();";
                    List<string[]> table = DBBroker.getInstance().Read(sqlLastId);
                    if (table.Count > 0)
                    {
                        m.IdMatch = int.Parse(table[0][0]);
                    }
                    string sql3, sql4;
                    if (m.Sets.Count < 3)
                    {
                        sql3 = "INSERT INTO Plays(player, idMatch, set1, set2) VALUES ('" + m.Player1.IdPlayer + "', '" + m.IdMatch + "', '" + m.Sets[0].Player1Points + "', '" + m.Sets[1].Player1Points + "');";
                        sql4 = "INSERT INTO Plays(player, idMatch, set1, set2) VALUES ('" + m.Player2.IdPlayer + "', '" + m.IdMatch + "', '" + m.Sets[0].Player2Points + "', '" + m.Sets[1].Player2Points + "');";
                    }
                    else
                    {
                        sql3 = "INSERT INTO Plays(player, idMatch, set1, set2, set3) VALUES ('" + m.Player1.IdPlayer + "', '" + m.IdMatch + "', '" + m.Sets[0].Player1Points + "', '" + m.Sets[1].Player1Points + "', '" + m.Sets[2].Player1Points + "');";
                        sql4 = "INSERT INTO Plays(player, idMatch, set1, set2, set3) VALUES ('" + m.Player2.IdPlayer + "', '" + m.IdMatch + "', '" + m.Sets[0].Player2Points + "', '" + m.Sets[1].Player2Points + "', '" + m.Sets[2].Player2Points + "');";
                    }
                    DBBroker.getInstance().Change(sql3);
                    DBBroker.getInstance().Change(sql4);
                }
            }
            return 1;
        }
        public int DeleteSeason(Season s)
        {
            foreach (Edition edition in s.Sea_editions)
            {
                List<Match> matches = edition.ListOfMatches;

                foreach (Match m in matches)
                {
                    string sql3 = "DELETE FROM Plays WHERE idMatch = '" + m.IdMatch + "';";
                    DBBroker.getInstance().Change(sql3);
                }

                foreach (Match m in matches)
                {
                    string sql2 = "DELETE FROM Matches WHERE season = '" + edition.EditionSeason.Season_year + "' AND tournament = '" + edition.EditionTournament.IdTournament + "';";
                    DBBroker.getInstance().Change(sql2);
                }

                string sql = "DELETE FROM Editions WHERE season = '" + edition.EditionSeason.Season_year + "' AND tournament = '" + edition.EditionTournament.IdTournament + "';";
                DBBroker.getInstance().Change(sql);
            }
            return 1;
        }

        public List<int> ReadByPlayer(Player player)
        {
            string sql = "SELECT * FROM Plays WHERE player='" + player.IdPlayer + "';";
            List<string[]> table = DBBroker.getInstance().Read(sql);
            List<int> seasons = new List<int>();
            if (table.Count > 0)
            {
                foreach (string[] row in table)
                {
                    Match m = new Match(int.Parse(row[1]));
                    m.ReadMatchById();
                    if (!seasons.Contains(m.Season.Season_year))
                    {
                        seasons.Add(m.Season.Season_year);
                    }
                }
            }
            return seasons;
        }
    }
}