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
        Season editionSeason;
        Tournament editionTournament;
        int orderInSeason = 0;
        List<Match> listOfMatches = new List<Match>();

        public Season EditionSeason { get { return editionSeason; } set { editionSeason = value; } }
        public Tournament EditionTournament { get { return editionTournament; } set { editionTournament = value;  } }
        public int OrderInSeason { get {return orderInSeason; } set { orderInSeason = value; } }
        

        public Edition() 
        {
            editionSeason = new Season();
            editionTournament = new Tournament();
            orderInSeason = 0;
        }
        public Edition(int order)
        {
            editionSeason = new Season();
            editionTournament = new Tournament();
            orderInSeason = order;
        }
        public void AddMatch(Match match)
        {
            this.listOfMatches.Add(match);
        }

        public List<Edition> ReadAllEditions()
        {
            return this.editionSeason.ReadAllEditions();
        }

        public Edition ReadEditionByOrder()
        {
            Edition e = this.editionSeason.ReadEditionByOrder(this);
            return e;
        }

        public void InsertEdition()
        {
            this.editionSeason.InsertEdition(this);
        }
        public int DeleteEdition() 
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to delete it?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (dialogResult == DialogResult.Yes)
            {
                this.editionSeason.DeleteEdition(this);
            }
            return 0;
        }

    }
}
