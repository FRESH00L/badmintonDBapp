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
                List<string[]> table = _selectedPlayer.ReadPlayerResultsByEdition(_selectedEdition);

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