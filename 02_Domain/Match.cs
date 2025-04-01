using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazyDanychBadminton._02_Domain
{
        public class Match
        {
            private int _idMatch;
            private Edition _matchEdition;
            private Season _season;
            private Tournament _tournament;
            private Player _winner;
            private int _round;
            private Player _player1;
            private Player _player2;
            private List<Set> _sets;
            private MatchDAO _matchDAO;

            public int IdMatch
            {
                get { return _idMatch; }
                set { _idMatch = value; }
            }
            public Edition MatchEdition
            {
                get { return _matchEdition; }
                set { _matchEdition = value; }
            }
            public Season Season
            {
                get { return _season; }
                set { _season = value; }
            }
            public Tournament Tournament
            {
                get { return _tournament; }
                set { _tournament = value; }
            }
            public Player Winner
            {
                get { return _winner; }
                set { _winner = value; }
            }
            public int Round
            {
                get { return _round; }
                set { _round = value; }
            }
            public Player Player1 
            {
                get { return _player1; }
                set { _player1 = value; }
            }
            public Player Player2
            {
                get { return _player2; }
                set { _player2 = value; }
            }
            public List<Set> Sets
            {
                get { return _sets; }
                set { _sets = value; }
            }

            public Match()
            {
                this._matchEdition = new Edition();
                this._season = new Season();
                this._tournament = new Tournament();
                this._winner = null;
                this._round = 0;
                this._player1 = new Player();
                this._player2 = new Player();
                this._sets = new List<Set>();
                this._matchDAO = new MatchDAO();
            }

            public Match(int idMatch)
            {
                this.IdMatch = idMatch;
                this._matchEdition = new Edition();
                this._season = Season;
                this._tournament = Tournament;
                this._winner = null;
                this._round = 0;
                this._player1 = new Player();
                this._player2 = new Player();
                this._sets = new List<Set>();
                this._matchDAO = new MatchDAO();
            }

            public List<Match> ReadAllMatches()
            {
                return this._matchDAO.ReadAll();
            }

            public void ReadMatchById()
            {
                this._matchDAO.ReadById(this);
            }

            public int InsertMatch()
            {
                return this._matchDAO.Insert(this);
            }

            public int UpdateMatch()
            {
                return this._matchDAO.Update(this);
            }

            public int DeleteMatch()
            {
                DialogResult dialogResult = MessageBox.Show("Do you really want to delete it?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                if (dialogResult == DialogResult.Yes)
                {
                    return this._matchDAO.Delete(this);
                }
                return 0;
            }

        public void SimulateMatch()
        {
            Random random = new Random();
            int winsPlayer1 = 0, winsPlayer2 = 0;

            for (int i = 0; i < 3; i++)
            {
                _round = i; // updates round on each iteration
                Set set = new Set(this, _player1, _player2, random);
                _sets.Add(set);

                if (set.Winner == _player1) winsPlayer1++;
                else winsPlayer2++;

                if (winsPlayer1 == 2)
                {
                    _winner = _player1;
                    return;
                }
                if (winsPlayer2 == 2)
                {
                    _winner = _player2;
                    return;
                }
            }
        }
    }
    }
