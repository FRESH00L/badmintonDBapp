using BazyDanychBadminton._03_Persistance;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Asn1.Cmp;
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
        public List<string[]> ReadPlayerResultsByEdition(Player player, Edition edition)
        {
            string sql = $@"  
                SELECT
                    (SELECT t.touName 
                    FROM Tournaments t 
                    WHERE t.idTournament = m.tournament) AS Tournament,
                    CASE
                        WHEN m.winner = {player.IdPlayer} AND m.round = 'F' THEN 'Won'
                        ELSE 'Lost'
                    END AS Result,
                    m.round AS Round,
                    (SELECT p.PlaName
                     FROM players p
                     JOIN plays pl_rival ON p.idPlayer = pl_rival.player
                     WHERE pl_rival.idMatch = m.idMatch
                       AND pl_rival.player <> {player.IdPlayer}
                    ) AS Rival
                FROM matches m
                JOIN plays pl_selected ON m.idMatch = pl_selected.idMatch
                WHERE pl_selected.player = {player.IdPlayer}
                AND m.season = {edition.EditionSeason.Season_year}
                AND (
                    CASE
                        WHEN m.round = 'F' THEN 3
                        WHEN m.round = 'S' THEN 2
                        WHEN m.round = 'Q' THEN 1
                        ELSE 0
                    END
                ) = (
                    SELECT MAX(
                        CASE WHEN m2.round = 'F' THEN 3
                             WHEN m2.round = 'S' THEN 2
                             WHEN m2.round = 'Q' THEN 1
                             ELSE 0
                        END)
                    FROM matches m2
                    JOIN plays pl_selected2 ON m2.idMatch = pl_selected2.idMatch
                    WHERE pl_selected2.player = {player.IdPlayer}
                        AND m2.tournament = m.tournament
                        AND m2.season = m.season
                )
              ;";
            return DBBroker.getInstance().Read(sql);
        }
        public bool CanDelete(Player p)
        {
            string sql = $@"
            SELECT
            (SELECT COUNT(*) FROM matches WHERE winner = {p.IdPlayer}) AS matchCount,
            (SELECT COUNT(*) FROM plays WHERE player = {p.IdPlayer}) AS playsCount;";

            List<string[]> result = DBBroker.getInstance().Read(sql);
            if (result.Count > 0)
            {
                string[] row = result[0];
                int matchCount = Convert.ToInt32(row[0]);
                int playsCount = Convert.ToInt32(row[1]);
                return matchCount == 0 && playsCount == 0;
            }
            return false;
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
            if (!CanDelete(p))
            {
                return -1; // Cannot delete player, they are involved in matches or plays
            }
            string sql = "DELETE FROM Players Where idPlayer='" + p.IdPlayer + "';";
            return DBBroker.getInstance().Change(sql);
        }
    }
}