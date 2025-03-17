using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazyDanychBadminton._02_Domain
{
    public class Player
    {
        private int _idPlayer;
        private string _playerName;
        private DateTime _playerBirthDate;
        private Country _playerCountry;

        private PlayerDAO _playerDAO;

        public int IdPlayer 
        { 
            get { return _idPlayer; } 
            set { _idPlayer = value; } 
        }
        public string PlayerName 
        { 
            get { return _playerName; } 
            set { _playerName = value; } 
        }
        public DateTime PlayerBirthDate 
        {  
            get { return _playerBirthDate; } 
            set { _playerBirthDate = value; } 
        }
        public Country PlayerCountry 
        { 
            get { return _playerCountry; } 
            set { _playerCountry = value; } 
        }

        public Player()
        {
            this.PlayerName = "";
            this.PlayerBirthDate = DateTime.Now;
            this.PlayerCountry = new Country();
            this._playerDAO = new PlayerDAO();
        }
        public Player(int id)
        {
            this.IdPlayer = id;
            this.PlayerName = "";
            this.PlayerBirthDate = DateTime.Now;
            this.PlayerCountry = new Country();
            this._playerDAO = new PlayerDAO();
        }
        public List<Player> ReadAllPlayers()
        {
            return this._playerDAO.RealAll();
        }

        public void ReadPlayerById()
        {
            this._playerDAO.ReadById(this);
        }
        public void ReadPlayerByName()
        {
            this._playerDAO.ReadByName(this);
        }

        public int InsertPlayer()
        {
            return this._playerDAO.Insert(this);
        }

        public int UpdatePlayer()
        {
            return this._playerDAO.Update(this);
        }

        public int DeletePlayer()
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to delete it?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (dialogResult == DialogResult.Yes)
            {
                return this._playerDAO.Delete(this);
            }
            return 0;
            
        }
        public void GenerateCountryID() // TODO: revise what does this and check if we need one to generate the ID on oturnament and modify this one.
        {
            string idCountry = this.PlayerCountry.CountryName.Substring(0, 3);
            this.PlayerCountry.IdCountry = idCountry;
        }
    }
}
