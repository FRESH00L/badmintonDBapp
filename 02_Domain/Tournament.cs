using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazyDanychBadminton._02_Domain
{
    public class Tournament
    {
        private int _idTournament;
        private string _tournamentName;
        private string _tournamentCity;
        private Country _tournamentCountry;
        private TournamentDAO _tournamentDAO;

        public int IdTournament
        {
            get { return _idTournament; }
            set { _idTournament = value; }
        }

        public string TouName
        {
            get { return _tournamentName; }
            set { _tournamentName = value; }
        }

        public string TouCity
        {
            get { return _tournamentCity; }
            set { _tournamentCity = value; }
        }

        public Country TouCountry
        {
            get { return _tournamentCountry; }
            set { _tournamentCountry = value; }
        }

        public TournamentDAO TournamentDAO
        {
            get { return _tournamentDAO; }
            set { _tournamentDAO = value; }
        }

        public Tournament()
        {
            this._tournamentName = "";
            this._tournamentCity = "";
            this._tournamentCountry = new Country();
            this._tournamentDAO = new TournamentDAO();
        }
        public Tournament(int idTournament)
        {
            this._idTournament = idTournament;
            this._tournamentName = "";
            this._tournamentCity = "";
            this._tournamentCountry = new Country();
            this._tournamentDAO = new TournamentDAO();
        }

        public List<Tournament> ReadAllTournaments()
        {
            return this.TournamentDAO.ReadAll();
        }

        public void ReadTournamentByName()
        {
            this.TournamentDAO.ReadByName(this);
        }
        public void ReadTournamentById()
        {
            this.TournamentDAO.ReadById(this);
        }
        public int InsertTournament()
        {
            return this.TournamentDAO.Insert(this);
        }
        public int UpdateTournament()
        {
            return this.TournamentDAO.Update(this);
        }
        public int DeleteTournament()
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to delete it?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (dialogResult == DialogResult.Yes)
            {
                return this.TournamentDAO.Delete(this);
            }
            return 0;
        }
    }
}
