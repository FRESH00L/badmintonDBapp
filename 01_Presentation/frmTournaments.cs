﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BazyDanychBadminton._02_Domain;

namespace BazyDanychBadminton._01_Presentation
{
    public partial class frmTournaments : Form
    {
        Tournament tournament;
        Edition edition;
        public frmTournaments()
        {
            InitializeComponent();
        }

        private void lbx_Tournaments_SelectedIndexChanged(object sender, EventArgs e)
        {
            tournament = new Tournament();
            edition = new Edition();
            List<Edition> editions = new List<Edition>();
            if (lbx_Tournaments.SelectedItem != null)
            {
                btn_Update.Enabled = true;
                btn_Delete.Enabled = true;
                tbx_Winner.Text = "";
                tournament.TouName = lbx_Tournaments.SelectedItem.ToString();
            }
            try
            {
                tournament.ReadTournamentByName();
                editions = edition.ReadEditionByTournament(tournament);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            lbx_TouEdi.Items.Clear();
            foreach (Edition ed in editions)
            {
                lbx_TouEdi.Items.Add(ed.EditionSeason.ToString());
            }
            lbl_TournamentId.Text = tournament.IdTournament.ToString();
            tbx_TournamentName.Text = tournament.TouName;
            tbx_TournamentCity.Text = tournament.TouCity;
            cmb_TournamentCountry.Text = tournament.TouCountry.CountryName;
        }
        private void lbx_TouEdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Match m = new Match();
            if (lbx_TouEdi.SelectedItem != null && lbx_Tournaments.SelectedItem != null)
            {
                tournament.TouName = lbx_Tournaments.SelectedItem.ToString();
                edition.EditionSeason = new Season(int.Parse(lbx_TouEdi.SelectedItem.ToString()));
                try
                {
                    tournament.ReadTournamentByName();

                    List<Match> finalMatches = m.ReadMatchByEdition(edition, tournament, "F");

                    if (finalMatches.Count > 0 && finalMatches[0].Winner != null)
                    {
                        tbx_Winner.Text = finalMatches[0].Winner.PlaName;
                    }
                    else
                    {
                        tbx_Winner.Text = "No Winner";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                btn_show.Enabled = true;
            }

        }
        private void frmTournaments_Load(object sender, EventArgs e)
        {
            tournament = new Tournament();
            List<Tournament> list_tournaments = tournament.ReadAllTournaments();
            foreach (Tournament tournament in list_tournaments)
            {
                lbx_Tournaments.Items.Add(tournament.TouName);
            }

            Country country = new Country();
            List<Country> list_countries = country.ReadAllCountries();
            foreach (Country cou in list_countries)
            {
                cmb_TournamentCountry.Items.Add(cou.CountryName);
            }
        }
        private void btn_Insert_Click(object sender, EventArgs e)
        {
            tournament = new Tournament();
            tournament.TouName = tbx_TournamentName.Text;
            tournament.TouCity = tbx_TournamentCity.Text;


            Country cou = new Country();
            cou.CountryName = cmb_TournamentCountry.Text;
            cou.ReadCountryByName();
            tournament.TouCountry = cou;

            try
            {
                tournament.ReadTournamentByName();
                if (tournament.IdTournament > 0)
                {
                    MessageBox.Show("This tournament already exists.", "Error: INSERT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (tournament.InsertTournament() == 1)
                {
                    lbx_Tournaments.Items.Add(tournament.TouName);
                    tbx_TournamentName.Text = "";
                    tbx_TournamentCity.Text = "";
                    cmb_TournamentCountry.SelectedIndex = -1;
                    btn_Update.Enabled = false;
                    btn_Delete.Enabled = false;
                }
                else
                {
                    MessageBox.Show("\"An error happened while inserting the tournament.", "Error: INSERT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            tournament = new Tournament(int.Parse(lbl_TournamentId.Text));
            tournament.ReadTournamentById();
            Tournament newTournament = new Tournament(tournament.IdTournament);
            newTournament.TouName = tbx_TournamentName.Text;
            newTournament.TouCity = tbx_TournamentCity.Text;
            Country country = new Country();
            country.CountryName = cmb_TournamentCountry.Text;
            country.ReadCountryByName();
            newTournament.TouCountry = country;

            try
            {
                if (newTournament.UpdateTournament() == 1)
                {
                    lbx_Tournaments.Items.Remove(tournament.TouName);
                    lbx_Tournaments.Items.Add(newTournament.TouName);
                    lbl_TournamentId.Text = "";
                    tbx_TournamentName.Text = "";
                    tbx_TournamentCity.Text = "";
                    cmb_TournamentCountry.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Tournament cannot be updated if there's one with that name.", "Error: UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            tournament = new Tournament(int.Parse(lbl_TournamentId.Text));
            tournament.ReadTournamentById();
            try
            {
                if (tournament.DeleteTournament() == 1)
                {
                    lbx_Tournaments.Items.Remove(tournament.TouName);
                    lbl_TournamentId.Text = "";
                    tbx_TournamentName.Text = "";
                    tbx_TournamentCity.Text = "";
                    cmb_TournamentCountry.SelectedIndex = -1;
                    btn_Update.Enabled = false;
                    btn_Delete.Enabled = false;
                }
                else
                {
                    MessageBox.Show("You can't delete a tournament which has editions involved.", "Error: DELETE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            lbl_TournamentId.Text = "";
            tbx_TournamentName.Text = "";
            tbx_TournamentCity.Text = "";
            lbx_Tournaments.SelectedIndex = -1;
            cmb_TournamentCountry.SelectedIndex = -1;
            lbx_TouEdi.Items.Clear();
            tbx_Winner.Text = "";
            btn_Delete.Enabled = false;
            btn_Update.Enabled = false;
            btn_show.Enabled = false;
        }

        private void show_edition_matches(object sender, EventArgs e)
        {
            frmMatches fm = new frmMatches(edition, tournament);
            fm.Show();
        }
    }
}

