using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazyDanychBadminton._02_Domain
{
    public class Set
    {
        private int _idSet;
        private Match _match;
        private Player _winner;
        private int _player1Points;
        private int _player2Points;

        public int IdSet
        {
            get { return _idSet; }
            set { _idSet = value; }
        }
        public Match Match
        {
            get { return _match; }
            set { _match = value; }
        }
        public Player Winner
        {
            get { return _winner; }
            set { _winner = value; }
        }
        public int Player1Points
        {
            get { return _player1Points; }
            set { _player1Points = value; }
        }
        public int Player2Points
        {
            get { return _player2Points; }
            set { _player2Points = value; }
        }

        public Set()
        {
            this._match = new Match();
            this._winner = null;
            this._player1Points = 0;
            this._player2Points = 0;
        }

        public Set(int idSet)
        {
            this.IdSet = idSet;
            this._match = new Match();
            this._winner = null;
            this._player1Points = 0;
            this._player2Points = 0;
        }

        public Set(Match match, Player player1, Player player2, Random random)
        {
            this._match = match;
            if (random.Next(2) == 0)
            {
                this._winner = player1;
                this._player1Points = 21;
                this._player2Points = random.Next(20);
            }
            else
            {
                this._winner = player2;
                this._player2Points = 21;
                this._player1Points = random.Next(20);
            }
        }
    }
}

