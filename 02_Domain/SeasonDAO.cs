﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BazyDanychBadminton._02_Domain;
using BazyDanychBadminton._03_Persistance;
using Google.Protobuf.Reflection;

namespace BazyDanychBadminton._02_Domain
{
    public class SeasonDAO
    {
        public SeasonDAO() { }

        public List<int> ReadAllSeasons()
        {
            List<int> result = new List<int>();
            string sql = "SELECT DISTINCT season FROM Editions ORDER BY season;";
            List<string[]> table = DBBroker.getInstance().Read(sql);

            foreach (string[] row in table)
            {
                result.Add(int.Parse(row[0]));
            }

            return result;
        }

        public int ReadByYear(Season s)
        {
            string sql = "SELECT * FROM Editions WHERE season='" + s.Season_year + " ORDER BY OrderInSeason';";
            List<string[]> table = DBBroker.getInstance().Read(sql);
            if (table.Count > 0)
            {
                s.Sea_editions = new List<Edition>();
                foreach (string[] row in table)
                {
                    s.Season_year = int.Parse(row[0]);
                    Tournament t = new Tournament(int.Parse(row[1]));
                    Edition e = new Edition();
                    e.EditionTournament = t;
                    e.EditionSeason = s;
                    e.OrderInSeason = int.Parse(row[2]);

                    string sql2 = "SELECT * FROM Matches WHERE season='" + s.Season_year + "' AND tournament='" + t.IdTournament + "';";
                    List<string[]> table2 = DBBroker.getInstance().Read(sql2);
                    foreach (string[] row2 in table2)
                    {
                        Match m = new Match();
                        m.IdMatch = int.Parse(row2[0]);
                        e.ListOfMatches.Add(m);
                    }

                    s.Sea_editions.Add(e);
                }
                return 1;
            }
            return 0;
        }

        public int InsertSeason(Season s)
        {
            foreach (Edition edition in s.Sea_editions)
            {
                List<Match> matches = edition.ListOfMatches;
                string sql = "INSERT INTO Editions(season, tournament, orderInSeason) VALUES ('" + s.Season_year + "', '" + edition.EditionTournament.IdTournament + "', '" + edition.OrderInSeason + "');";
                DBBroker.getInstance().Change(sql);
                foreach(Match m in matches)
                {
                    string sql2 = "INSERT INTO Matches(idMatch, season, tournament, winner, round) VALUES ('" + m.IdMatch + "', '" + edition.EditionSeason.Season_year + "', '" + edition.EditionTournament.IdTournament + "', '" + m.Winner.IdPlayer + "', '" + m.Round + "');";
                    DBBroker.getInstance().Change(sql2);
                    string sqlLastId = "SELECT LAST_INSERT_ID();";
                    List<string[]> table = DBBroker.getInstance().Read(sqlLastId);

                    if (table.Count > 0)
                    {
                        m.IdMatch = int.Parse(table[0][0]);
                    }

                    string sql3;
                    if (m.Sets.Count < 3)
                    {
                        sql3 = "INSERT INTO Plays(player, idMatch, set1, set2) VALUES ('" + m.Player1.IdPlayer + "', '" + m.IdMatch + "', '" + m.Sets[0].IdSet + "', '" + m.Sets[1].IdSet + "');";
                    }
                    else
                    {
                        sql3 = "INSERT INTO Plays(player, idMatch, set1, set2, set3) VALUES ('" + m.Player1.IdPlayer + "', '" + m.IdMatch + "', '" + m.Sets[0].IdSet + "', '" + m.Sets[1].IdSet + "', '" + m.Sets[2].IdSet + "');";
                    }
                
                        DBBroker.getInstance().Change(sql3);
                    
                }
            }
            return 1;
        }

        public int DeleteSeason(Season s)
        {
            foreach (Edition edition in s.Sea_editions)
            {
                List<Match> matches = edition.ListOfMatches;

                foreach (Match m in matches)
                {
                    string sql3 = "DELETE FROM Plays WHERE idMatch = '" + m.IdMatch + "';";
                    DBBroker.getInstance().Change(sql3);
                }

                foreach (Match m in matches)
                {
                    string sql2 = "DELETE FROM Matches WHERE season = '" + edition.EditionSeason.Season_year + "' AND tournament = '" + edition.EditionTournament.IdTournament + "';";
                    DBBroker.getInstance().Change(sql2);
                }

                string sql = "DELETE FROM Editions WHERE season = '" + edition.EditionSeason.Season_year + "' AND tournament = '" + edition.EditionTournament.IdTournament + "';";
                DBBroker.getInstance().Change(sql);
                string sql4 = "DELETE FROM tournaments WHERE idTournament = '" + edition.EditionTournament.IdTournament + "';";
                DBBroker.getInstance().Change(sql4);
            }
            return 1;
        }
<<<<<<< HEAD



        public List<Edition> ReadAllEditions()
        {
            List<Edition> result = new List<Edition>();
            string sql = "SELECT * FROM Editions ORDER BY orderInSeason;";
            List<string[]> table = DBBroker.getInstance().Read(sql);
            foreach (string[] row in table)
            {
                Edition e = new Edition();
                e.EditionSeason = new Season(int.Parse(row[0]));
                e.EditionTournament = new Tournament(int.Parse(row[1]));
                e.OrderInSeason = int.Parse(row[2]);
                result.Add(e);
            }
            return result;
        }
        public Edition ReadByOrder(Edition e)
        {
            string sql = "SELECT * FROM Editions WHERE orderInEdition='" + e.OrderInSeason + "';";
            List<string[]> table = DBBroker.getInstance().Read(sql);
            if (table.Count > 0)
            {
                string[] row = table[0];
                e.EditionSeason = new Season(int.Parse(row[0]));
                e.EditionTournament = new Tournament(int.Parse(row[1]));
            }
            return e;
        }
        public int InsertEdition(Edition e)
        {
            string sql = "INSERT INTO Editions(season, tournament, orderInSeason) VALUES ('" + e.EditionSeason.Season_year + "', '" + e.EditionTournament.IdTournament + "', '" + e.OrderInSeason + "');";
            return DBBroker.getInstance().Change(sql);
        }

        public int DeleteEdition(Edition e)
        {
            string sql = "DELETE FROM Editions WHERE orderInSeason='" + e.OrderInSeason + "';";
            return DBBroker.getInstance().Change(sql);
        }

        
        public List<Match> ReadAllMatches()
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
                m.Season = new Season(int.Parse(row[1]));
                m.Tournament = new Tournament(int.Parse(row[2]));
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

        public int InsertMatch(Match m)
        {
            string sql = "INSERT INTO Matches (season, tournament, winner, round) VALUES ('"
                         + m.Season.Season_year + "', '"
                         + m.Tournament.IdTournament + "', "
                         + m.Winner + ", '"
                         + m.Round + "');";
            return DBBroker.getInstance().Change(sql);
        }

        public int UpdateMatch(Match m)
        {
            string sql = "UPDATE Matches SET season='" + m.Season.Season_year +
                         "', tournament='" + m.Tournament.IdTournament +
                         "', winner=" + m.Winner +
                         ", round='" + m.Round +
                         "' WHERE idMatch='" + m.IdMatch + "';";
            return DBBroker.getInstance().Change(sql);
        }

        public int DeleteMatch(Match m)
        {
            string sql = "DELETE FROM Matches WHERE idMatch='" + m.IdMatch + "';";
            return DBBroker.getInstance().Change(sql);
        }
=======
>>>>>>> 408e5a813ef9b602eb1cd81909b63337bc738693
    }
}