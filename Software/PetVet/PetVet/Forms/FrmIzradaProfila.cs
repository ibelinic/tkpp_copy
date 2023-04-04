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

namespace PetVet.Forms
{
    public partial class FrmIzradaProfila : Form
    {
        public int prijavljenKorisnik;
        public FrmIzradaProfila(int prijavljenKorisnik)
        {
            InitializeComponent();
            this.prijavljenKorisnik = prijavljenKorisnik;
        }
        public Ljubimac ljubimacPostojeci;

        private void FrmIzradaProfila_Load(object sender, EventArgs e)
        {
            FillComboBox();
            txtKorisnik.Text = prijavljenKorisnik.ToString();

            Random randomBrojKartona = new Random();
            int nineDigitNumberKarton = randomBrojKartona.Next(100000000, 1000000000);
            txtBrojKartona.Text = nineDigitNumberKarton.ToString();
        }

        private void FillComboBox()
        {
            var pasminaService = new PasminaLjubimcaService();
            var pasmina = pasminaService.GetTypeAnimal();
            cmbPasmina.DataSource = pasmina;
        }

        private void btnIzradiProfil_Click(object sender, EventArgs e)
        {
            var ljubimac = new Ljubimac
            {
                //ID = Convert.ToInt32(txtid.Text),
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                BrojIskaznice = Convert.ToInt32(txtBrojIskaznice.Text),
                Tezina_Kg = Convert.ToInt32(txtTezina.Text),
                Visina_Cm = Convert.ToInt32(txtVisina.Text),
                BrojChipa = Convert.ToInt32(txtBrojChipa.Text),
                PasminaLjubimca = cmbPasmina.SelectedItem as PasminaLjubimca,
                KorisnikID = Convert.ToInt32(txtKorisnik.Text),
                BrojKartona = Convert.ToInt32(txtBrojKartona.Text),
                Biljeske = richtxtBiljeske.Text
            };
            if (ljubimac.Ime != null && ljubimac.Prezime != null && ljubimac.BrojIskaznice.ToString() != null && ljubimac.Tezina_Kg.ToString() != null && ljubimac.Visina_Cm.ToString() != null && 
                ljubimac.BrojChipa.ToString() != null && ljubimac.PasminaLjubimca != null && ljubimac.BrojKartona.ToString() != null && ljubimac.Biljeske != null)
            {
                var ljubimacServices = new LjubimacServices();
                ljubimacServices.AddPet(ljubimac);
                Dispose();
                Close();
                FrmProfil formaProfil = new FrmProfil(prijavljenKorisnik);
                formaProfil.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nisu uneseni svi podaci!");
            }
        }
    }
}