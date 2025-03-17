using BazyDanychBadminton._03_Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazyDanychBadminton._02_Domain
{
    public class PlayerDAO
    {
        public PlayerDAO() { }
        public List<Player> ReadAll()
        {
            List<Player> result = new List<Player>();
            string sql = "SELECT * FROM Players ORDER BY idPlayer;";
            List<string[]> table = DBBroker.getInstance().Read(sql);
            foreach (string[] row in table)
            {
                Player p = new Player();
                p.IdPlayer = int.Parse(row[0]);
                p.PlaName = row[1];
                p.PlaBirthDate = DateTime.Parse(row[2]);
                Country c = new Country(row[3]);
                c.ReadCountryById();
                p.PlaCountry = c;
                p.PlaCountry = new Country(row[3]);
                result.Add(p);
            }
            return result;
        }
            public void ReadById(Player p)
        {
            string sql = "SELECT * FROM Players WHERE idPlayer='" + p.IdPlayer + "';";
            List<string[]> table = DBBroker.getInstance().Read(sql);
            if (table.Count > 0)
            {
                string[] row = table[0];
                p.IdPlayer = int.Parse(row[0]);
                p.PlaName = row[1];
                p.PlaBirthDate = DateTime.Parse(row[2]);
                Country c = new Country(row[3]);
                c.ReadCountryById();
                p.PlaCountry = c;
            }
        }
        public void ReadByName(Player p)
        {
            string sql = "SELECT * FROM Players WHERE plaName='" + p.PlaName + "';";
            List<string[]> table = DBBroker.getInstance().Read(sql);
            if (table.Count > 0)
            {
                string[] row = table[0];
                p.IdPlayer = int.Parse(row[0]);
                p.PlaName = row[1];
                p.PlaBirthDate = DateTime.Parse(row[2]);
                Country c = new Country(row[3]);
                c.ReadCountryById();
                p.PlaCountry = c;
            }
        }
        public int Insert(Player p)
        {
            string sql = "INSERT INTO Players(plaName, plaBirthDate, plaCountry) VALUES ('" + p.PlaName + "', '" + p.PlaBirthDate.ToString("yyyy-MM-dd") + "', '" + p.PlaCountry.IdCountry + "');";
            return DBBroker.getInstance().Change(sql);
        }
        public int Update(Player p)
        {
            string sql = "UPDATE Players SET plaName='" + p.PlaName + "', plaBirthDate= '" + p.PlaBirthDate.ToString("yyyy-MM-dd") + "', plaCountry= '" + p.PlaCountry.IdCountry + "' Where idPlayer='" + p.IdPlayer + "';";
            return DBBroker.getInstance().Change(sql);
        }
        public int Delete(Player p)
        {
            string sql = "DELETE FROM Players Where idPlayer='" + p.IdPlayer + "';";
            return DBBroker.getInstance().Change(sql);
        }
    }
}
