using BazyDanychBadminton._02_Domain;

namespace BazyDanychBadminton
{
    public partial class frmCountries : Form
    {
        Country country;
        public frmCountries()
        {
            InitializeComponent();
        }
        private void FrmCountries_Load(object sender, EventArgs e)
        {
            
        }

        private void lbx_Countries_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Update.Enabled = true;
            btn_Delete.Enabled = true;

            country = new Country();
            country.CountryName = lbx_Countries.SelectedItem.ToString();
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

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            country = new Country(tbx_CountryId.Text);
            country.CountryName = tbx_CountryName.Text;
            try
            {
                if (country.InsertCountry() == 1)
                {
                    lbx_Countries.Items.Add(country.CountryName);
                    tbx_CountryId.Text = "";
                    tbx_CountryName.Text = "";
                }
                else
                {
                    MessageBox.Show("An error happened ahile inserting a coutry.", "Error: INSERT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

        }

        private void frmCountries_Load_1(object sender, EventArgs e)
        {
            country = new Country();
            List<Country> list_countries = country.ReadAllCountries();
            foreach (Country country in list_countries)
            {
                lbx_Countries.Items.Add(country.CountryName);
            }
        }
    }
}
