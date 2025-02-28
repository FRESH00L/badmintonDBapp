using System;
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

        }
    }
}
