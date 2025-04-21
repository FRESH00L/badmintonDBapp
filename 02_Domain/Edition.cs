using BazyDanychBadminton._01_Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazyDanychBadminton._02_Domain
{
    public class Edition
    {
        Season _editionSeason;
        Tournament _editionTournament;
        int _orderInSeason = 0;
        List<Match> listOfMatches = new List<Match>();
        private EditionDAO _editionDAO;

        public Season EditionSeason
        {
            get { return _editionSeason; } 
            set { _editionSeason = value; }
        }
        public Tournament EditionTournament
        {
            get { return _editionTournament; } 
            set { _editionTournament = value;  }
        }
        public int OrderInSeason
        {
            get { return _orderInSeason; } 
            set { _orderInSeason = value; }
        }
        
        public Edition() 
        {
            _editionDAO = new EditionDAO();
            _editionSeason = new Season();
            _editionTournament = new Tournament();
            _orderInSeason = 0;
        }
        public Edition(int orderInSeason)
        {
            _editionDAO = new EditionDAO();
            _editionSeason = new Season();
            _editionTournament = new Tournament();
            _orderInSeason = orderInSeason;
        }
        public List<Match> ListOfMatches 
        { 
            get { return listOfMatches; } 
            set { listOfMatches = value; }
        }
        public void AddMatch(Match match)
        {
            this.listOfMatches.Add(match);
        }

        public List<Edition> ReadAllEditions()
        {
            return this._editionDAO.ReadAllEditions();
        }

        public Edition ReadEditionByOrder()
        {
            Edition e = this._editionDAO.ReadByOrder(this);
            return e;
        }
        public List<Edition> ReadEditionByTournament(Tournament t)
        {
            List<Edition> l = this._editionDAO.ReadByTournament(t);
            return l;
        }
        public Edition ReadEditionBySeasonAndTournament()
        {
            return this._editionDAO.ReadBySeasonAndTournament(this);
        }

        public void InsertEdition()
        {
            this._editionDAO.InsertEdition(this);
        }
        public int DeleteEdition() 
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to delete it?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (dialogResult == DialogResult.Yes)
            {
                this._editionDAO.DeleteEdition(this);
            }
            return 0;
        }

    }
}
