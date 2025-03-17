using BazyDanychBadminton._02_Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BazyDanychBadminton._01_Presentation
{

    public partial class frmPlayers : Form
    {
        Player player;
        public frmPlayers()
        {
            InitializeComponent();
        }
        private void lbx_ListOfPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Delete.Enabled = true;
            btn_Update.Enabled = true;

            player = new Player();
            if (lbx_ListOfPlayers.SelectedItem != null)
            {
                player.PlaName = lbx_ListOfPlayers.SelectedItem.ToString();
            }
            try
            {
                player.ReadPlayerByName();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            lbl_PlayerId.Text = player.IdPlayer.ToString();
            dbx_PlayerBirthDate.Value = player.PlaBirthDate;
            tbx_PlayerName.Text = player.PlaName;
            cmb_PlayerCountry.Text = player.PlaCountry.CountryName;
        }
        private void btn_Insert_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dbx_PlayerBirthDate.Value;
            DateTime today = DateTime.Today;
            int age = today.Year - selectedDate.Year;
            if (selectedDate.Date > today.AddYears(-age))
            {
                age--;
            }
            if (age >= 18)
            {
                player.PlaBirthDate = dbx_PlayerBirthDate.Value;
            }
            else
            {
                MessageBox.Show("Not adult player!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            player = new Player();
            player.PlaName = tbx_PlayerName.Text;
            player.PlaBirthDate = dbx_PlayerBirthDate.Value;


            Country cou = new Country();
            cou.CountryName = cmb_PlayerCountry.Text;
            cou.ReadCountryByName();
            player.PlaCountry = cou;

            try
            {
                if (player.InsertPlayer() == 1)
                {
                    lbx_ListOfPlayers.Items.Add(player.PlaName);
                    tbx_PlayerName.Text = "";
                    dbx_PlayerBirthDate.Text = "";
                    cmb_PlayerCountry.SelectedIndex = -1;
                    btn_Update.Enabled = false;
                    btn_Delete.Enabled = false;
                }
                else
                {
                    MessageBox.Show("An error happened while inserting a player.", "Error: INSERT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            player = new Player(int.Parse(lbl_PlayerId.Text));
            player.ReadPlayerById();
            Player newPlayer = new Player (player.IdPlayer);
            newPlayer.PlaName = tbx_PlayerName.Text;
            newPlayer.PlaBirthDate = dbx_PlayerBirthDate.Value;
            Country country = new Country();
            country.CountryName = cmb_PlayerCountry.Text;
            country.ReadCountryByName();
            newPlayer.PlaCountry = country;

            DateTime selectedDate = dbx_PlayerBirthDate.Value;
            DateTime today = DateTime.Today;
            int age = today.Year - selectedDate.Year;
            if (selectedDate.Date > today.AddYears(-age))
            {
                age--;
            }
            if (age >= 18)
            {
                player.PlaBirthDate = dbx_PlayerBirthDate.Value;
            }
            else
            {
                MessageBox.Show("Not adult player!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                if (newPlayer.UpdatePlayer() == 1)
                {
                    lbx_ListOfPlayers.Items.Remove(player.PlaName);
                    lbx_ListOfPlayers.Items.Add(newPlayer.PlaName);
                    lbl_PlayerId.Text = "";
                    tbx_PlayerName.Text = "";
                    dbx_PlayerBirthDate.Text = "";
                    cmb_PlayerCountry.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("An error happened while updating a country.", "Error: UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            player = new Player(int.Parse(lbl_PlayerId.Text));
            player.PlaName = tbx_PlayerName.Text;
            player.ReadPlayerById();
            try
            {
                if (player.DeletePlayer() == 1)
                {
                    lbx_ListOfPlayers.Items.Remove(player.PlaName);
                    lbl_PlayerId.Text = "";
                    tbx_PlayerName.Text = "";
                    dbx_PlayerBirthDate.Text = "";
                    cmb_PlayerCountry.SelectedIndex = -1;
                    btn_Delete.Enabled = false;
                    btn_Update.Enabled = false;
                }
                else
                {
                    MessageBox.Show("An error happened while deleting a player.", "Error: DELETE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            tbx_PlayerName.Text = "";
            dbx_PlayerBirthDate.Value = DateTime.Now;
            cmb_PlayerCountry.SelectedIndex = -1;
            btn_Delete.Enabled = false;
            btn_Update.Enabled = false;
        }

        private void frmPlayers_Load(object sender, EventArgs e)
        {
            player = new Player();
            List<Player> list_players = player.ReadAllPlayers();
            foreach (Player player in list_players)
            {
                lbx_ListOfPlayers.Items.Add(player.PlaName);
            }

            Country country = new Country();
            List<Country> list_countries = country.ReadAllCountries();
            foreach (Country cou in list_countries)
            {
                cmb_PlayerCountry.Items.Add(cou.CountryName);
            }
        }
    }
}
