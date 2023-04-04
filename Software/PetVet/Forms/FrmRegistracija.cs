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
    public partial class FrmRegistracija : Form
    {
        public FrmRegistracija()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtIme.Text=="" || txtPrezime.Text=="" || txtAdresa.Text=="" || txtBrojMobitela.Text=="" || txtEmail.Text=="" || txtKorisnicko.Text=="" || txtLozinka.Text == "")
            {
                labelGreska.Text = "Nisu uneseni svi potrebni podaci!";
            }
            else
            {
                var uloga = cmbUloga.SelectedItem as TipKorisnika;
                var noviKorisnik = new Korisnik { 
                    Ime=txtIme.Text,
                    Prezime=txtPrezime.Text,
                    Adresa=txtAdresa.Text,
                    Email=txtEmail.Text,
                    BrojMobitela=txtBrojMobitela.Text,
                    KorisnickoIme=txtKorisnicko.Text,
                    Lozinka=txtLozinka.Text,
                    TipKorisnikaID=Convert.ToInt16(uloga.ID)//uloga.ID ide jer drugacije dodaje u tablicu uloga
                };
                var servis = new KorisnikService();
                servis.Registriraj(noviKorisnik);
                Close();
            }
            FrmPocetna pocetna = new FrmPocetna();
            this.Dispose();
            this.Close();
            pocetna.ShowDialog();
        }

        private void FrmRegistracija_Load(object sender, EventArgs e)
        {
            GetUloge();
        }

        private void GetUloge()
        {
            var tipKorisnikaServis = new TipKorisnikaServices();
            cmbUloga.DataSource=tipKorisnikaServis.GetTipKorisnika();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            FrmPocetna pocetna = new FrmPocetna();
            this.Dispose();
            this.Close();
            pocetna.ShowDialog();
        }
    }
}
