using BazyDanychBadminton._02_Domain;
using System.Diagnostics;

namespace BazyDanychBadminton
{
    public partial class frmCountries : Form
    {
        Country country;
        public frmCountries()
        {
            InitializeComponent();
        }
        private void lbx_Countries_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Update.Enabled = true;
            btn_Delete.Enabled = true;

            country = new Country();
            if (lbx_Countries.SelectedItem != null)
            {
                country.CountryName = lbx_Countries.SelectedItem.ToString();
            }
            try
            {
                country.ReadCountryByName();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            tbx_CountryId.Text = country.IdCountry;
            tbx_CountryName.Text = country.CountryName;
        }
        private void frmCountries_Load(object sender, EventArgs e)
        {
            country = new Country();
            List<Country> list_countries = country.ReadAllCountries();
            foreach (Country country in list_countries)
            {
                lbx_Countries.Items.Add(country.CountryName);
            }
        }
        private void btn_Insert_Click(object sender, EventArgs e)
        {
            country = new Country();
            country.CountryName = tbx_CountryName.Text;
            try
            {
                country.ReadCountryByName();
                if (country.IdCountry != "")
                {
                    MessageBox.Show("This country already exists.", "Error: INSERT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (country.GenerateCountryCode() == -1)
                {
                    MessageBox.Show("The lenght of country name is not acceptable.", "Error: INSERT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (country.InsertCountry() == 1)
                {
                    lbx_Countries.Items.Add(country.CountryName);
                    tbx_CountryId.Text = "";
                    tbx_CountryName.Text = "";
                }
                else
                {
                    MessageBox.Show("An error happened while inserting a country.", "Error: INSERT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            country = new Country(tbx_CountryId.Text);
            country.ReadCountryById();
            Country newCountry = new Country(tbx_CountryId.Text);
            newCountry.CountryName = tbx_CountryName.Text;
            try
            {
                if (newCountry.UpdateCountry() == 1)
                {
                    lbx_Countries.Items.Remove(country.CountryName);
                    lbx_Countries.Items.Add(newCountry.CountryName);
                    tbx_CountryId.Text = "";
                    tbx_CountryName.Text = "";
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
            country = new Country(tbx_CountryId.Text);
            country.ReadCountryById();
            try
            {
                if (country.DeleteCountry() == 1)
                {
                    lbx_Countries.Items.Remove(country.CountryName);
                    tbx_CountryId.Text = "";
                    tbx_CountryName.Text = "";
                    btn_Update.Enabled = false;
                    btn_Delete.Enabled = false;
                }
                else
                {
                    MessageBox.Show("You can't delete a country which has players or tournaments involved.", "Error: DELETE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            tbx_CountryId.Text = "";
            tbx_CountryName.Text = "";
            btn_Delete.Enabled = false;
            btn_Update.Enabled = false;     
        }
    }
}