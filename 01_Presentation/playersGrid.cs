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
        private Season _selectedSeason;

        public playersGrid(Player player, Season season)
        {
            InitializeComponent();
            this._selectedPlayer = player;
            this._selectedSeason = season;
            this.Text = $"Results of {_selectedPlayer.PlaName} - Season {_selectedSeason.Season_year}";
        }

        private void playersGrid_Load(object sender, EventArgs e)
        {
            try
            {
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
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
