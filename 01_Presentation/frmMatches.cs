using BazyDanychBadminton._02_Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BazyDanychBadminton._01_Presentation
{
	public partial class frmMatches : Form
	{
		private Edition edition;
		private Tournament tournament;
		public frmMatches(Edition edition, Tournament tournament)
		{
			InitializeComponent();
			this.edition = edition;
			this.tournament = tournament;
		}

		private void q_first_player_name_TextChanged(object sender, EventArgs e)
		{

		}

		private void frmMatches_Load(object sender, EventArgs e)
		{
			List<Match> matches = new List<Match>();
			Match match = new Match();

			// Pobierz mecze ćwierćfinałowe (Q)
			matches.AddRange(match.ReadMatchByEdition(edition, tournament, "Q"));

			// Półfinały (S)
			matches.AddRange(match.ReadMatchByEdition(edition, tournament, "S"));

			// Finał (F)
			matches.AddRange(match.ReadMatchByEdition(edition, tournament, "F"));


			List<Player> players = match.ReadMatchPlayer(matches[0]); // pobierz 2 graczy

			if (players.Count == 2)
			{
				q_first_player_name.Text = players[0].PlaName;
				q_first_rival_name.Text = players[1].PlaName;
			}
			players = match.ReadMatchPlayer(matches[1]); // pobierz 2 graczy

			if (players.Count == 2)
			{
				q_second_player_name.Text = players[0].PlaName;
				q_second_rival_name.Text = players[1].PlaName;
			}
			players = match.ReadMatchPlayer(matches[2]); // pobierz 2 graczy

			if (players.Count == 2)
			{
				q_third_player_name.Text = players[0].PlaName;
				q_third_rival_name.Text = players[1].PlaName;
			}
			players = match.ReadMatchPlayer(matches[3]); // pobierz 2 graczy

			if (players.Count == 2)
			{
				q_fourth_player_name.Text = players[0].PlaName;
				q_fourth_rival_name.Text = players[1].PlaName;
			}
			players = match.ReadMatchPlayer(matches[4]); // pobierz 2 graczy

			if (players.Count == 2)
			{
				s_first_player_name.Text = players[0].PlaName;
				s_first_rival_name.Text = players[1].PlaName;
			}
			players = match.ReadMatchPlayer(matches[5]); // pobierz 2 graczy

			if (players.Count == 2)
			{
				s_second_player_name.Text = players[0].PlaName;
				s_second_rival_name.Text = players[1].PlaName;
			}
			players = match.ReadMatchPlayer(matches[6]); // pobierz 2 graczy

			if (players.Count == 2)
			{
				first_final_player.Text = players[0].PlaName;
				second_final_player.Text = players[1].PlaName;
			}
			

		}

	}
}
