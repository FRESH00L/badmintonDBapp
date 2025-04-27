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

        private void playersGrid_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = $@"  
                SELECT
                    (SELECT t.touName 
                    FROM Tournaments t 
                    WHERE t.idTournament = m.tournament) AS Tournament,
                    CASE
                        WHEN m.winner = {_selectedPlayer.IdPlayer} AND m.round = 'F' THEN 'Won'
                        ELSE 'Lost'
                    END AS Result,
                    m.round AS Round,
                    (SELECT p.PlaName
                     FROM players p
                     JOIN plays pl_rival ON p.idPlayer = pl_rival.player
                     WHERE pl_rival.idMatch = m.idMatch
                       AND pl_rival.player <> {_selectedPlayer.IdPlayer}
                    ) AS Rival
                FROM matches m
                JOIN plays pl_selected ON m.idMatch = pl_selected.idMatch
                WHERE pl_selected.player = {_selectedPlayer.IdPlayer}
                AND m.season = {_selectedEdition.EditionSeason.Season_year}
                AND (
                    CASE
                        WHEN m.round = 'F' THEN 3
                        WHEN m.round = 'S' THEN 2
                        WHEN m.round = 'Q' THEN 1
                        ELSE 0
                    END
                ) = (
                    SELECT MAX(
                        CASE WHEN m2.round = 'F' THEN 3
                             WHEN m2.round = 'S' THEN 2
                             WHEN m2.round = 'Q' THEN 1
                             ELSE 0
                        END)
                    FROM matches m2
                    JOIN plays pl_selected2 ON m2.idMatch = pl_selected2.idMatch
                    WHERE pl_selected2.player = {_selectedPlayer.IdPlayer}
                        AND m2.tournament = m.tournament
                        AND m2.season = m.season
                )
              ;";

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