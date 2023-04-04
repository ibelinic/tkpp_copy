using BusinessLayer;
using DataAccessLayer.Repositories;
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
    public partial class FrmIzvjestajVeterinar : Form
    {

        private Korisnik prijavljeniKorisnik;

        private LjubimacServices ljubimacServis = new LjubimacServices();
        private PosjetaLjubimcaServices posjetaServis=new PosjetaLjubimcaServices();
        public FrmIzvjestajVeterinar(Korisnik korisnik)
        {
            InitializeComponent();
            prijavljeniKorisnik = korisnik;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetPosjete(comboBox1.SelectedItem as Ljubimac);
        }

        private void GetPosjete(Ljubimac ljubimac)
        {
            var posjeteLjubimca=posjetaServis.GetPosjetaLjubimcas(ljubimac);
            dgvPosjeta.DataSource=posjeteLjubimca;
            dgvPosjeta.Columns["Korisnik"].Visible = false;
            dgvPosjeta.Columns["Lijekovis"].Visible = false;
            dgvPosjeta.Columns["Ljubimac"].Visible = false;
            dgvPosjeta.Columns["PreboljeleBolestis"].Visible = false;
        }

        private void FrmIzvjestajVeterinar_Load(object sender, EventArgs e)
        {
            GetLjubimce();
        }

        private void GetLjubimce()
        {
            var ljubimci = ljubimacServis.GetPets();
            comboBox1.DataSource= ljubimci;
        }

        private void btnIzvjestajVeterinara_Click(object sender, EventArgs e)
        {
            var odabranaPosjeta = dgvPosjeta.CurrentRow.DataBoundItem as PosjetaLjubimca;
            var odabraniLjubimac = comboBox1.SelectedItem as Ljubimac;
            FrmIzvjestajLjubimacKorisnik izvjestajVeterinar = new FrmIzvjestajLjubimacKorisnik(odabraniLjubimac, odabranaPosjeta);
            
            izvjestajVeterinar.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPocetnaVeterinar pocetnaVeterinar = new FrmPocetnaVeterinar(prijavljeniKorisnik);
            this.Dispose();
            this.Close();
            pocetnaVeterinar.ShowDialog();
        }
    }
}
