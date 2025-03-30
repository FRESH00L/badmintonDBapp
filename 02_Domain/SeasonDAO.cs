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

        public List<Season> ReadAll()
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

        public int Insert(Season s)
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

        public int Delete(Season s)
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
    }
}