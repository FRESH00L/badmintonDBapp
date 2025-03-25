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
                m.Season = row[1];
                m.Tournament = row[2];
                m.Round = int.Parse(row[4]);

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
                m.Season = row[1];
                m.Tournament = row[2];
                m.Round = int.Parse(row[4]);

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

        public int Insert(Match m)
        {
<<<<<<< HEAD
            string sql = "INSERT INTO Matches (idEdition, idPlayer1, idPlayer2, idWinner) VALUES ('"
                         + m.MatchEdition.OrderInSeason + "', '"
                         + m.Player1.IdPlayer + "', '"
                         + m.Player2.IdPlayer + "', "
                         + (m.Winner != null ? "'" + m.Winner.IdPlayer + "'" : "NULL") + ");";
=======
            string sql = "INSERT INTO Matches (season, tournament, winner, round) VALUES ('"
                         + m.Season + "', '"
                         + m.Tournament + "', "
                         + (m.Winner != null ? "'" + m.Winner.IdPlayer + "'" : "NULL") + ", '"
                         + m.Round + "');";
>>>>>>> 2bc359f2cd20170dfd4a1b096ce4ac8a60cf56b1
            return DBBroker.getInstance().Change(sql);
        }

        public int Update(Match m)
        {
<<<<<<< HEAD
            string sql = "UPDATE Matches SET idEdition='" + m.MatchEdition.OrderInSeason +
                         "', idPlayer1='" + m.Player1.IdPlayer +
                         "', idPlayer2='" + m.Player2.IdPlayer +
                         "', idWinner=" + (m.Winner != null ? "'" + m.Winner.IdPlayer + "'" : "NULL") +
                         " WHERE idMatch='" + m.IdMatch + "';";
=======
            string sql = "UPDATE Matches SET season='" + m.Season +
                         "', tournament='" + m.Tournament +
                         "', winner=" + (m.Winner != null ? "'" + m.Winner.IdPlayer + "'" : "NULL") +
                         ", round='" + m.Round +
                         "' WHERE idMatch='" + m.IdMatch + "';";
>>>>>>> 2bc359f2cd20170dfd4a1b096ce4ac8a60cf56b1
            return DBBroker.getInstance().Change(sql);
        }

        public int Delete(Match m)
        {
            string sql = "DELETE FROM Matches WHERE idMatch='" + m.IdMatch + "';";
            return DBBroker.getInstance().Change(sql);
        }
    }
}