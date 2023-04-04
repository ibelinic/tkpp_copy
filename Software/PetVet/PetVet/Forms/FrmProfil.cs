using BusinessLayer;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PetVet.Forms
{
    public partial class FrmProfil : Form
    {
        private LjubimacServices services = new LjubimacServices();
        public Ljubimac ljubimac;
        public int prijavljenKorisnik;
        public PasminaLjubimca pasmina;

        public FrmProfil(int prijavljenKorisnik)
        {
            InitializeComponent();
            this.prijavljenKorisnik = prijavljenKorisnik;
        }

        private void FrmProfil_Load(object sender, EventArgs e)
        {
            cmbProfili.Text = "Odaberite željenog ljubimca!";
        }

        private void btnIzradiProfil_Click(object sender, EventArgs e)
        {
            FrmIzradaProfila formaIzradaProfila = new FrmIzradaProfila(prijavljenKorisnik);
            formaIzradaProfila.ShowDialog();
            Close();
        }

        private void FillPetsComboBox()
        {
            var petsServices = new LjubimacServices();
            var pets = petsServices.GetPetsByKorisnik(prijavljenKorisnik);
            cmbProfili.DataSource = pets;
        }

        private void cmbProfili_DropDownClosed(object sender, EventArgs e)
        {
            var selectedPet = cmbProfili.SelectedItem as Ljubimac;
            FillTextBox(selectedPet);
        }

        private void FillTextBox(Ljubimac ljubimac)
        {
            txtID.Text = ljubimac.ID.ToString();
            txtIme.Text = ljubimac.Ime;
            txtPrezime.Text = ljubimac.Prezime;
            txtBrojIskaznice.Text = ljubimac.BrojIskaznice.ToString();
            txtBrojChipa.Text = ljubimac.BrojChipa.ToString();
            txtTezina.Text = ljubimac.Tezina_Kg.ToString();
            txtVisina.Text = ljubimac.Visina_Cm.ToString();
            txtPasminaLjubimca.Text = ljubimac.TipLjubimcaID.ToString();
            txtKorisnik.Text = prijavljenKorisnik.ToString();
        }

        private void cmbProfili_Click(object sender, EventArgs e)
        {
            FillPetsComboBox();
        }

        private void btnDigitalniKarton_Click(object sender, EventArgs e)
        {
            Close();
            var selectedPet = cmbProfili.SelectedItem as Ljubimac;
            FrmDigitalniKarton formaDigitalniKarton = new FrmDigitalniKarton(selectedPet, prijavljenKorisnik);
            formaDigitalniKarton.ShowDialog();
        }

        private void btnObrisiProfil_Click(object sender, EventArgs e)
        {
            var selectedPet = cmbProfili.SelectedItem as Ljubimac;
            if (selectedPet != null)
            {
                bool isSuccessful = services.RemovePet(selectedPet); //ako je selektiran onda pozvati metodu na servisima, a stavljamo kao bool kako bismo korisniku dali povratnu info
                txtID.Text = "";
                txtIme.Text = "";
                txtPrezime.Text = "";
                txtBrojIskaznice.Text = "";
                txtBrojChipa.Text = "";
                txtTezina.Text = "";
                txtVisina.Text = "";
                txtPasminaLjubimca.Text = null;
                txtKorisnik.Text = null;
                if (isSuccessful == false)
                {
                    MessageBox.Show("Ne može se obrisati odabrani ljubimac");
                }
                cmbProfili.DataSource = null;
                FillPetsComboBox();
                cmbProfili.Text = "Odaberite željenog ljubimca!";
            }
            else
            {
                MessageBox.Show("Morate odabrati ljubimca");
            }

        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            var selectedPet = cmbProfili.SelectedItem as Ljubimac;
            selectedPet.Ime = txtIme.Text;
            selectedPet.Prezime = txtPrezime.Text;
            selectedPet.BrojIskaznice = Convert.ToInt32(txtBrojIskaznice.Text);
            selectedPet.BrojChipa = Convert.ToInt32(txtBrojChipa.Text);
            selectedPet.Tezina_Kg = Convert.ToInt32(txtTezina.Text);
            selectedPet.Visina_Cm = Convert.ToInt32(txtVisina.Text);
            selectedPet.TipLjubimcaID = Convert.ToInt32(txtPasminaLjubimca.Text);
            selectedPet.KorisnikID = prijavljenKorisnik;
            services.UpdateLjubimac(selectedPet);
            cmbProfili.DataSource = null;
            FillPetsComboBox();
            cmbProfili.Text = "Odaberite željenog ljubimca!";
        }
    }
}