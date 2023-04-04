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
    public partial class FrmDigitalniKarton : Form
    {
        public FrmProfil formaProfil;
        public PosjetaLjubimcaServices services = new PosjetaLjubimcaServices();
        public Ljubimac ljubimac;
        public LijekoviServices servisLijekova = new LijekoviServices();
        public PreboljeleBolestiServices servisBolesti = new PreboljeleBolestiServices();
        private int prijavljenKorisnik;

        public FrmDigitalniKarton(Ljubimac selectedPet, int prijavljenKorisnik)
        {
            InitializeComponent();
            ljubimac = selectedPet;
            this.prijavljenKorisnik = prijavljenKorisnik;
        }

        private void FrmDigitalniKarton_Load(object sender, EventArgs e)
        {
            var posjeta = services.GetPosjetaLjubimcas(ljubimac);
            txtIme.Text = ljubimac.Ime;
            txtPrezime.Text = ljubimac.Prezime;
            txtBrojKartona.Text = ljubimac.BrojKartona.ToString();
            richtxtBiljeske.Text = ljubimac.Biljeske;
            dgvPosjeta.DataSource = posjeta;
            if (dgvPosjeta.Rows.Count > 0)
            {
                dgvPosjeta.CurrentRow.Selected = true;
            }
            else
            {
                MessageBox.Show("Digitalni karton je trenutno prazan!");
            }
            dgvPosjeta.Columns["Korisnik"].Visible = false;
            dgvPosjeta.Columns["Lijekovis"].Visible = false;
            dgvPosjeta.Columns["Ljubimac"].Visible = false;
            dgvPosjeta.Columns["PreboljeleBolestis"].Visible = false;
        }

        private void dgvPosjeta_SelectionChanged(object sender, EventArgs e)
        {
            var selectedVisit = dgvPosjeta.CurrentRow.DataBoundItem as PosjetaLjubimca;
            var idVisit = selectedVisit.ID;

            var lijekovi = servisLijekova.GetLijekovi(idVisit);
            dgvLijekovi.DataSource = lijekovi;
            dgvLijekovi.Columns["PosjetaLjubimca"].Visible = false;

            var bolesti = servisBolesti.GetBolesti(idVisit);
            dgvBolesti.DataSource = bolesti;
            dgvBolesti.Columns["PosjetaLjubimca"].Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            FrmProfil formaProfil = new FrmProfil(prijavljenKorisnik);
            formaProfil.ShowDialog();
        }

        private void btnIzvjestaj_Click(object sender, EventArgs e)
        {
            var odabranaPosjeta = dgvPosjeta.CurrentRow.DataBoundItem as PosjetaLjubimca;
            FrmIzvjestajLjubimacKorisnik izvjestaj = new FrmIzvjestajLjubimacKorisnik(ljubimac,odabranaPosjeta);
            izvjestaj.ShowDialog();
        }
    }
}
