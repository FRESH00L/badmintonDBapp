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
                player.PlayerName = lbx_ListOfPlayers.SelectedItem.ToString();
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
            dbx_PlayerBirthDate.DataContext = player.PlayerBirthDate;
            tbx_PlayerName.Text = player.PlayerName.ToString();
            tbx_PlayerCountry.Text = player.PlayerCountry.IdCountry;
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
            if(age >= 18) 
            { 
                player.PlayerBirthDate = dbx_PlayerBirthDate.Value;
            }
            else
            {
                MessageBox.Show("Not adult player!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            player = new Player();
            player.PlayerName = tbx_PlayerName.Text;
            player.PlayerCountry.CountryName = tbx_PlayerCountry.Text;
            player.GenerateCountryID();
            
            player.PlayerBirthDate = dbx_PlayerBirthDate.Value;

            try
            {
                if(player.InsertPlayer() == 1)
                {
                    lbx_ListOfPlayers.Items.Add(player.PlayerName);
                    tbx_PlayerCountry.Text = "";
                    tbx_PlayerName.Text = "";
                    dbx_PlayerBirthDate.Text = "";
                }
                else
                {
                    MessageBox.Show("An error happened while inserting a player.", "Error: INSERT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            player = new Player();
            player.PlayerName = lbx_ListOfPlayers.SelectedItem.ToString();
            player.ReadPlayerByName();
            Player newPlayer = new Player(player.IdPlayer);
            newPlayer.PlayerName = tbx_PlayerName.Text;

            try
            {
                if(newPlayer.UpdatePlayer() == 1)
                {
                    lbx_ListOfPlayers.Items.Remove(player.PlayerName);
                    lbx_ListOfPlayers.Items.Add(newPlayer.PlayerName);
                    tbx_PlayerCountry.Text = "";
                    tbx_PlayerName.Text = "";
                    btn_Delete.Enabled = false;
                    btn_Update.Enabled = false;
                    lbx_ListOfPlayers.ClearSelected();
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
            player = new Player();
            player.PlayerName = tbx_PlayerName.Text;
            player.ReadPlayerByName();
            try
            {
                if(player.IdPlayer == 0)
                {
                    MessageBox.Show("Theres no player with this id.", "Error: ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (player.DeletePlayer() == 1)
                {
                    lbx_ListOfPlayers.Items.Remove(player.PlayerName);
                    tbx_PlayerCountry.Text = "";
                    tbx_PlayerName.Text = "";
                    btn_Delete.Enabled = false;
                    btn_Update.Enabled = false;
                    lbx_ListOfPlayers.ClearSelected();
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
            tbx_PlayerCountry.Text = "";
            dbx_PlayerBirthDate.Text = "";
            btn_Delete.Enabled = false;
            btn_Update.Enabled = false;
        }

        private void frmPlayers_Load(object sender, EventArgs e)
        {
            player = new Player();
            List<Player> list_players = player.ReadAllPlayers();
            foreach (Player player in list_players)
            {
                lbx_ListOfPlayers.Items.Add(player.PlayerName);
            }
        }
       
    }
}
