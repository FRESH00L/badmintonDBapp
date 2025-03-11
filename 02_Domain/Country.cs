﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazyDanychBadminton._02_Domain
{
    public class Country
    {
        private string _idCountry;
        private string _countryName;
        private CountryDAO _countryDAO;

        public string IdCountry { get { return _idCountry; } set { _idCountry = value; } }
        public string CountryName { get { return _countryName; } set { _countryName = value; } }
        public CountryDAO CountryDAO { get { return _countryDAO; } set { _countryDAO = value; } }
        public Country() 
        {
            this._idCountry = "";
            this._countryName = "";
            this._countryDAO = new CountryDAO();
        }
        public Country(string idCountry) 
        {
            this._idCountry = idCountry;
            this._countryName = "";
            this._countryDAO = new CountryDAO();
        }
        public List<Country> ReadAllCountries() {
            return this.CountryDAO.RealAll();
        }
        public void ReadCountryByName() {
            this.CountryDAO.ReadByName(this);
        }
        public void ReadCountryById() {
            this.CountryDAO.ReadById(this);
        }
        public int InsertCountry() {
            return this.CountryDAO.Insert(this);
        }
        public int UpdateCountry() { 
            return this.CountryDAO.Update(this);
        }
        public int DeleteCountry() {
            return this.CountryDAO.Delete(this);
        }
        public void GenerateCountryCode()
        {
            string idCountry = this.CountryName.Substring(0, 3);
            Country countryInDB = new Country(idCountry);
            this.CountryDAO.ReadById(countryInDB);
            if (countryInDB.CountryName != "")
            {
                // if the country is found by that idCountry, get the next letter
                idCountry = idCountry.Substring(0, 2) + this.CountryName.Substring(3, 1);
            }
            this.IdCountry = idCountry.ToUpper();
        }
    }
}
