using BazyDanychBadminton._03_Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazyDanychBadminton._02_Domain
{
    public class CountryDAO {
        public List<Country> RealAll()
        {
            List<Country> result = new List<Country>();
            string sql = "SELECT * FROM Countries ORDER BY idCountry;";
            List<string[]> table = DBBroker.getInstance().Read(sql);
            foreach (string[] row in table) 
            { 
                Country c = new Country();
                c.IdCountry = row[0];
                c.CountryName = row[1];
                result.Add(c);
            }
            return result;
        }
        public void ReadById(Country c)
        {
            string sql = "SELECT * FROM Countries WHERE idCountry='" + c.IdCountry + "';";
            List<string[]> table = DBBroker.getInstance().Read(sql);
            if (table.Count > 0)
            {
                string[] row = table[0];
                c.CountryName = row[1];
            }
        }
        public void ReadByName(Country c)
        {
            string sql = "SELECT * FROM Countries WHERE couName='" + c.CountryName + "';";
            List<string[]> table = DBBroker.getInstance().Read(sql);
            if (table.Count > 0)
            {
                string[] row = table[0];
                c.CountryName = row[0];
            }
        }
        public int Insert(Country c)
        {
            string sql = "INSERT INTO Countries VALUES ('" + c.IdCountry + "', '" + c.CountryName + "');";
            return DBBroker.getInstance().Change(sql);
        }
        public int Update(Country c)
        {
            string sql = "UPDATE Countries SET couName= '" + c.CountryName + "WHERE idCountry='" + c.IdCountry + "');";
            return DBBroker.getInstance().Change(sql);

        }
        public int Delete(Country c)
        {
            string sql = "DELETE FROM Countries WGERE idCountry='" + c.IdCountry + "');";
            return DBBroker.getInstance().Change(sql);
        }
    }
}
