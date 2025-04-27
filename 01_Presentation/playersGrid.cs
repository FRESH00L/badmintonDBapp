using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BazyDanychBadminton._02_Domain;
using BazyDanychBadminton._03_Persistance;

namespace BazyDanychBadminton._01_Presentation
{
    public partial class playersGrid : Form
    {
        private Player _selectedPlayer;
        private Edition _selectedEdition;

        public playersGrid(Player player, Edition edition)
        {
            InitializeComponent();
            this._selectedPlayer = player;
            this._selectedEdition = edition;
            this.Text = $"Results of {_selectedPlayer.PlaName} - Season {_selectedEdition.EditionSeason.Season_year}";
        }
        // Solo selecciona los de 2020, por que

        private void playersGrid_Load(object sender, EventArgs e)
        {
            try
            {
                // Consulta SQL para obtener los partidos del jugador  
                string sql = $@"  
               SELECT  
                   m.tournament AS Tournaments,  
                   CASE  
                       WHEN m.winner = {_selectedPlayer.IdPlayer} THEN 'Won'  
                       ELSE 'Lost'  
                   END AS Result,  
                   m.round AS Round,  
                   (  
                       SELECT p.PlaName  
                       FROM players p  
                       JOIN plays pl_rival ON p.idPlayer = pl_rival.player  
                       WHERE pl_rival.idMatch = m.idMatch  
                         AND pl_rival.player <> {_selectedPlayer.IdPlayer}  
                   ) AS Rival  
               FROM matches m  
               JOIN plays pl_selected ON m.idMatch = pl_selected.idMatch  
               WHERE pl_selected.player = {_selectedPlayer.IdPlayer}  
                 AND m.season = {_selectedEdition.EditionSeason.Season_year};";

                // Leer los datos de la base de datos  
                List<string[]> table = DBBroker.getInstance().Read(sql);

                if (table == null || table.Count == 0)
                {
                    MessageBox.Show("No se encontraron partidos para el jugador seleccionado en esta temporada.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Tournaments");
                dataTable.Columns.Add("Result");
                dataTable.Columns.Add("Round");
                dataTable.Columns.Add("Rival");

                // Llenar el DataGridView con los datos correctamente  
                foreach (string[] row in table)
                {
                    dataTable.Rows.Add(row);
                }
                dataGridView1.DataSource = dataTable;
                Console.WriteLine("Data loaded successfully into the DataGridView.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos de los partidos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
/*private void playersGrid_Load(object sender, EventArgs e)
        {
            Match m = new Match();
            List<Match> matches = m.ReadMatchesByPlayerAndSeason(this._selectedPlayer, this._selectedEdition);
            string sql = "SELECT m.idMatch, m.tournament, m.winner, m.round " +
                            " FROM matches m, plays pl " +
                            " WHERE m.idMatch = pl.idMatch " +
                            " AND pl.player = " + _selectedPlayer.IdPlayer +
                            " AND m.season = " + _selectedEdition.EditionSeason.Season_year + ";";
            List<string[]> table = DBBroker.getInstance().Read(sql);

            string currentTournament = "";
            string furthestRound = "";
            string finalMatchId = "";
            int finalWinner = 0;

            foreach (string[] row in table)
            {
                string matchId = row[0];
                int tournamentId = Convert.ToInt32(row[1]);
                int winnerId = Convert.ToInt32(row[2]);
                string round = row[3];

                Tournament t = new Tournament(tournamentId);
                t.ReadTournamentById();

                // If switching tournaments, add the previous tournament's data to the grid  
                if (!string.IsNullOrEmpty(currentTournament) && currentTournament != t.TouName)
                {
                    string rival = getRivalName(finalMatchId, _selectedPlayer.IdPlayer);
                    matches.Add(new string[]
                    {
                       currentTournament, (finalWinner == _selectedPlayer.IdPlayer) ? "Won" : "Lost", furthestRound, rival
                    });

                    // Reset tracking for new tournament
                    furthestRound = round;
                    finalMatchId = matchId;
                    finalWinner = winnerId;
                    */

/* try
    {
        Match m = new Match();
        List<Match> matches = m.ReadMatchesByPlayerAndSeason(this._selectedPlayer,this._selectedSeason);
        // TODO: get maximum round in each match for a tournament in order to get result, round and rival in the final match

        string sql = $@"SELECT t.TouName AS Tournament,
                       m.Result,
                       m.Round,
                       m.Rival
                FROM Matches m
                INNER JOIN Tournaments t ON m.TournamentId = t.IdTournament
                INNER JOIN Editions e ON m.EditionId = e.IdEdition
                WHERE m.PlayerId = {_selectedPlayer.IdPlayer} 
                  AND e.EditionSeason = {_selectedSeason.Season_year}";
        List<string[]> table = DBBroker.getInstance().Read(sql);

        if (table == null || table.Count == 0)
        {
            MessageBox.Show("No data found for the selected player and season.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        dataGridView1.Rows.Clear();
        foreach (var row in table)
        {
            if (row.Length == 4)
            {
                dataGridView1.Rows.Add(row);
            }
            else
            {
                MessageBox.Show("Row format is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Error loading match data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    */
