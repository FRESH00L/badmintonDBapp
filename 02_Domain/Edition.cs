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
            _editionSeason = new Season();
            _editionTournament = new Tournament();
            _orderInSeason = 0;
        }
        public Edition(int order)
        {
            _editionSeason = new Season();
            _editionTournament = new Tournament();
            _orderInSeason = order;
        }
        public List<Match> ListOfMatches { get { return listOfMatches; } }
        public void AddMatch(Match match)
        {
            this.listOfMatches.Add(match);
        }

        public List<Edition> ReadAllEditions()
        {
            return this._editionSeason.ReadAllEditions();
        }

        public Edition ReadEditionByOrder()
        {
            Edition e = this._editionSeason.ReadEditionByOrder(this);
            return e;
        }

        public void InsertEdition()
        {
            this._editionSeason.InsertEdition(this);
        }
        public int DeleteEdition() 
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to delete it?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (dialogResult == DialogResult.Yes)
            {
                this._editionSeason.DeleteEdition(this);
            }
            return 0;
        }

    }
}
