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
        public string PlaName
        {
            get { return _playerName; }
            set { _playerName = value; }
        }
        public DateTime PlaBirthDate
        {
            get { return _playerBirthDate; }
            set { _playerBirthDate = value; }
        }
        public Country PlaCountry
        {
            get { return _playerCountry; }
            set { _playerCountry = value; }
        }
        public Player()
        {
            this._playerName = "";
            this._playerBirthDate = DateTime.Now;
            this._playerCountry = new Country();
            this._playerDAO = new PlayerDAO();
        }
        public Player(int idPlayer)
        {
            this.IdPlayer = idPlayer;
            this._playerName = "";
            this._playerBirthDate = DateTime.Now;
            this._playerCountry = new Country();
            this._playerDAO = new PlayerDAO();
        }
        public List<Player> ReadAllPlayers()
        {
            return this._playerDAO.ReadAll();
        }
        public void ReadPlayerById()
        {
            this._playerDAO.ReadById(this);
        }
        public void ReadPlayerByName()
        {
            this._playerDAO.ReadByName(this);
        }
        public List<string[]> ReadPlayerResultsByEdition(Edition selectedEdition)
        {
            return this._playerDAO.ReadPlayerResultsByEdition(this, selectedEdition);
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
    }
}
