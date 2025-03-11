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
        public List<Player> RealAll()
        {
            List<Player> result = new List<Player>();
            string sql = "SELECT * FROM Players ORDER BY idPlayer;";
            List<string[]> table = DBBroker.getInstance().Read(sql);
            foreach (string[] row in table)
            {
                Player p = new Player();
                p.IdPlayer = int.Parse(row[0]);
                p.PlayerName = row[1];
                p.PlayerBirthDate = DateTime.Parse(row[2]); 
                p.PlayerCountry = new Country(row[3]);
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
                p.PlayerName = row[1];
                p.PlayerBirthDate = DateTime.Parse(row[2]);
                p.PlayerCountry = new Country(row[3]);
            }
        }
        public void ReadByName(Player p)
        {
            string sql = "SELECT * FROM Players WHERE plaName='" + p.PlayerName + "';";
            List<string[]> table = DBBroker.getInstance().Read(sql);
            if (table.Count > 0)
            {
                string[] row = table[0];
                p.IdPlayer = int.Parse(row[0]);
                p.PlayerName = row[1];
                p.PlayerBirthDate = DateTime.Parse(row[2]);
                p.PlayerCountry = new Country(row[3]);
            }
        }
        public int Insert(Player p)
        {
            string sql = "INSERT INTO Players(plaName, plaBirthDate, plaCountry) VALUES ('" + p.PlayerName + "', '" + p.PlayerBirthDate.ToString("yyyy-MM-dd") + "', '" + p.PlayerCountry.IdCountry + "');";
            return DBBroker.getInstance().Change(sql);
        }
        public int Update(Player p)
        {
            string sql = "UPDATE Players SET plaName='" + p.PlayerName + "' Where idPlayer='" + p.IdPlayer + "';";
            return DBBroker.getInstance().Change(sql);
        }
        public int Delete(Player p)
        {
            string sql = "DELETE FROM Players Where idPlayer='" + p.IdPlayer + "';";
            return DBBroker.getInstance().Change(sql);
        }
    }
}
