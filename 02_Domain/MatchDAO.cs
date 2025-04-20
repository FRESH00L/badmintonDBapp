using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BazyDanychBadminton._03_Persistance;
using MySql.Data.MySqlClient;

namespace BazyDanychBadminton._02_Domain
{
    public class MatchDAO
    {
        public MatchDAO() { }

        public List<Match> ReadAll()
        {
            List<Match> result = new List<Match>();
            string sql = "SELECT * FROM Matches ORDER BY idMatch;";
            List<string[]> table = DBBroker.getInstance().Read(sql);

            foreach (string[] row in table)
            {
                Match m = new Match();
                m.IdMatch = int.Parse(row[0]);
                m.Season = new Season(int.Parse(row[1]));
                m.Tournament = new Tournament(int.Parse(row[2]));
                m.Winner = new Player(int.Parse(row[3]));
                m.Round = row[4];

                Edition e = new Edition(int.Parse(row[1]));
                e.ReadEditionByOrder();
                m.MatchEdition = e;

                Player p1 = new Player(int.Parse(row[2]));
                p1.ReadPlayerById();
                m.Player1 = p1;

                Player p2 = new Player(int.Parse(row[3]));
                p2.ReadPlayerById();
                m.Player2 = p2;

                if (!string.IsNullOrEmpty(row[4]))
                {
                    Player winner = new Player(int.Parse(row[4]));
                    winner.ReadPlayerById();
                    m.Winner = winner;
                }
                result.Add(m);
            }
            return result;
        }

        public void ReadById(Match m)
        {
            string sql = "SELECT * FROM Matches WHERE idMatch='" + m.IdMatch + "';";
            List<string[]> table = DBBroker.getInstance().Read(sql);

            if (table.Count > 0)
            {
                string[] row = table[0];
                m.IdMatch = int.Parse(row[0]);
                m.Season = new Season(int.Parse(row[1]));
                m.Tournament = new Tournament(int.Parse(row[2]));
                m.Round = row[4];

                Edition e = new Edition(int.Parse(row[1]));
                e.ReadEditionByOrder();
                m.MatchEdition = e;

                Player p1 = new Player(int.Parse(row[2]));
                p1.ReadPlayerById();
                m.Player1 = p1;

                Player p2 = new Player(int.Parse(row[3]));
                p2.ReadPlayerById();
                m.Player2 = p2;

                if (!string.IsNullOrEmpty(row[4]))
                {
                    Player winner = new Player(int.Parse(row[4]));
                    winner.ReadPlayerById();
                    m.Winner = winner;
                }
            }
        }
		public List<Match> ReadByEdition(Edition e, Tournament t, string r)
		{
			string sql = "SELECT * FROM Matches WHERE season='" + e.EditionSeason.ToString() + "' AND tournament='" + t.IdTournament + "' AND round='" + r + "';";
			List<string[]> table = DBBroker.getInstance().Read(sql);

			List<Match> matches = new List<Match>();

			foreach (var row in table)
			{
				Match m = new Match();
				m.IdMatch = int.Parse(row[0]);
				m.Season = new Season(int.Parse(row[1]));
				m.Tournament = new Tournament(int.Parse(row[2]));
				m.Round = row[4];
				m.MatchEdition = e;

				if (!string.IsNullOrEmpty(row[3]))
				{
					Player winner = new Player(int.Parse(row[3]));
					winner.ReadPlayerById();
					m.Winner = winner;
				}

				matches.Add(m);
			}

			return matches;
		}
        public List<Player> ReadPlayer(Match m)
        {
            string sql = "SELECT * FROM Plays WHERE idMatch='" + m.IdMatch + "';";
			List<string[]> table = DBBroker.getInstance().Read(sql);

			List<Player> players = new List<Player>();

			foreach (var row in table)
            {
                Player player = new Player();
                player.IdPlayer = int.Parse(row[0]);
                player.ReadPlayerById();
                players.Add(player);
            }
            return players;
		}


		public int Insert(Match m)
        {
            string sql = "INSERT INTO Matches (season, tournament, winner, round) VALUES ('"
                         + m.Season + "', '"
                         + m.Tournament + "', "
                         + m.Winner + ", '"
                         + m.Round + "');";
            return DBBroker.getInstance().Change(sql);
        }

        public int Update(Match m)
        {
            string sql = "UPDATE Matches SET season='" + m.Season +
                         "', tournament='" + m.Tournament +
                         "', winner=" + m.Winner +
                         ", round='" + m.Round +
                         "' WHERE idMatch='" + m.IdMatch + "';";
            return DBBroker.getInstance().Change(sql);
        }

        public int Delete(Match m)
        {
            string sql = "DELETE FROM Matches WHERE idMatch='" + m.IdMatch + "';";
            return DBBroker.getInstance().Change(sql);
        }
    }
}