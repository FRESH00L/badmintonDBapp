using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BazyDanychBadminton._02_Domain;
using BazyDanychBadminton._03_Persistance;

namespace BazyDanychBadminton._02_Domain
{
    public class TournamentDAO
    {
        public List<Tournament> ReadAll()
        {
            List<Tournament> result = new List<Tournament>();
            string sql = "SELECT * FROM Tournaments ORDER BY idTournament;";
            List<string[]> table = DBBroker.getInstance().Read(sql);
            foreach (string[] row in table)
            {
                Tournament t = new Tournament();
                t.IdTournament = int.Parse(row[0]);
                t.TouName = row[1];
                t.TouCity = row[2];
                Country c = new Country(row[3]);
                c.ReadCountryById();
                t.TouCountry = c;
                result.Add(t);
            }
            return result;
        }
        public void ReadById(Tournament t)
        {
            string sql = "SELECT * FROM Tournaments WHERE idTournament='" + t.IdTournament + "';";
            List<string[]> table = DBBroker.getInstance().Read(sql);
            if (table.Count > 0)
            {
                string[] row = table[0];
                t.IdTournament = int.Parse(row[0]);
                t.TouName = row[1];
                t.TouCity = row[2];
                Country c = new Country(row[3]);
                c.ReadCountryById();
                t.TouCountry = c;
            }
        }
        public void ReadByName(Tournament t)
        {
            string sql = "SELECT * FROM Tournaments WHERE touName='" + t.TouName + "';";
            List<string[]> table = DBBroker.getInstance().Read(sql);
            if (table.Count > 0)
            {
                string[] row = table[0];
                t.IdTournament = int.Parse(row[0]);
                t.TouName = row[1];
                t.TouCity = row[2];
                Country c = new Country(row[3]);
                c.ReadCountryById();
                t.TouCountry = c;
            }
        }
        public List<Tournament> ReadByPlayer(Player p)
        {
            List<Tournament> result = new List<Tournament>();
            List<int> tournamentIds = new List<int>(); // Avoid duplications
            string sql = "SELECT * FROM Plays WHERE player='" + p.IdPlayer + "';";
            List<string[]> table = DBBroker.getInstance().Read(sql);

            foreach (string[] row in table)
            {
                Match m = new Match(int.Parse(row[1]));
                m.ReadMatchById();
                m.Tournament.ReadTournamentById();

                if (!tournamentIds.Contains(m.Tournament.IdTournament))
                {
                    tournamentIds.Add(m.Tournament.IdTournament);
                    result.Add(m.Tournament);
                }
            }
            return result;
        }
        public int Insert(Tournament t)
        {
            string sql = "INSERT INTO Tournaments(touName, touCity, touCountry) VALUES ('" + t.TouName + "', '" + t.TouCity + "', '" + t.TouCountry.IdCountry + "');";
            return DBBroker.getInstance().Change(sql);
        }
        public int Update(Tournament t)
        {
            string sql = "UPDATE Tournaments SET touName= '" + t.TouName + "', touCity= '" + t.TouCity + "', touCountry= '" + t.TouCountry.IdCountry + "' WHERE idTournament='" + t.IdTournament + "';";
            return DBBroker.getInstance().Change(sql);
        }
        public int Delete(Tournament t)
        {
            string sql = "DELETE FROM Tournaments WHERE idTournament='" + t.IdTournament + "';";
            return DBBroker.getInstance().Change(sql);
        }
    }
}