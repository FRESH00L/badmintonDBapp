﻿using BazyDanychBadminton._03_Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;

namespace BazyDanychBadminton._02_Domain
{
    public class CountryDAO
    {
        public List<Country> ReadAll()
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
                c.IdCountry = row[0];
            }
        }
        public bool CanDelete(Country c)
        {
            string sql = $@"
            SELECT
            (SELECT COUNT(*) FROM players WHERE plaCountry = '{c.IdCountry}') AS playersCount,
            (SELECT COUNT(*) FROM tournaments WHERE touCountry = '{c.IdCountry}') AS tournamentsCount;";

            List<string[]> result = DBBroker.getInstance().Read(sql);
            if (result.Count > 0)
            {
                string[] row = result[0];
                int playersCount = Convert.ToInt32(row[0]);
                int tournamentsCount = Convert.ToInt32(row[1]);
                return playersCount == 0 && tournamentsCount == 0;
            }
            return false;
        }
        public bool CanUpdate(Country c)
        {
            string sql = $@"
            SELECT COUNT(*) AS countriesCount FROM countries WHERE couName = '{c.CountryName}';";

            List<string[]> result = DBBroker.getInstance().Read(sql);
            if (result.Count > 0)
            {
                string[] row = result[0];
                int countriesCount = Convert.ToInt32(row[0]);
                return countriesCount == 0;
            }
            return false;
        }
        public int Insert(Country c)
        {
            string sql = "INSERT INTO Countries VALUES ('" + c.IdCountry + "', '" + c.CountryName + "');";
            return DBBroker.getInstance().Change(sql);
        }
        public int Update(Country c)
        {
            if (!CanUpdate(c))
            {
                return -1; // Cannot update country, there's one with the same name
            }
            string sql = "UPDATE Countries SET couName= '" + c.CountryName + "'WHERE idCountry='" + c.IdCountry + "';";
            return DBBroker.getInstance().Change(sql);

        }
        public int Delete(Country c)
        {
            if (!CanDelete(c))
            {
                return -1; // Cannot delete country, it has players
            }
            string sql = "DELETE FROM Countries WHERE idCountry='" + c.IdCountry + "';";
            return DBBroker.getInstance().Change(sql);
        }
    }
}