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
            string sql = "SELECT * FROM Season WHERE season_year='" + s.Season_year + "';";
            List<string[]> table = DBBroker.getInstance().Read(sql);
            if (table.Count > 0)
            {
                string[] row = table[0];
                s.Season_year = int.Parse(row[0]);
                //Tournament t = new Tournament(row[1]);///////////////////////////////////////////////////
                //t.ReadTournamentById();
                //s.Sea_tournament = t;
            }
        }

        public int Insert(Season s)
        {
            string sql = "INSERT INTO Seasons(season_year, sea_tournament) VALUES ('" + s.Season_year + "', '" + s.Sea_tournament + "');";
            return DBBroker.getInstance().Change(sql);
        }

        public int Delete(Season s)
        {
            string sql = "DELETE FROM Seasons WHERE season_year='" + s.Season_year + "';";
            return DBBroker.getInstance().Change(sql);
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