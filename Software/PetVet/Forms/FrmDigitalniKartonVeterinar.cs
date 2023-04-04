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
    public partial class FrmDigitalniKartonVeterinar : Form
    {
        public FrmProfil formaProfil;
        public PosjetaLjubimcaServices services = new PosjetaLjubimcaServices();
        public Ljubimac ljubimac;
        public LijekoviServices servisLijekova = new LijekoviServices();
        public PreboljeleBolestiServices servisBolesti = new PreboljeleBolestiServices();
        private int prijavljenKorisnik;

        public FrmDigitalniKartonVeterinar(int prijavljenKorisnik)
        {
            InitializeComponent();
            this.prijavljenKorisnik = prijavljenKorisnik;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            //FrmProfil formaProfil = new FrmProfil(prijavljenKorisnik);
            //formaProfil.ShowDialog();
        }

        private void FrmDigitalniKartonVeterinar_Load(object sender, EventArgs e)
        {
            var petsServices = new LjubimacServices();
            var pets = petsServices.GetPets();
            cmbLjubimac.DataSource = pets;
        }

        private void cmbLjubimac_SelectedIndexChanged(object sender, EventArgs e)
        {
            var LjubimacPodatci = cmbLjubimac.SelectedItem as Ljubimac;

                var posjeta = services.GetPosjetaLjubimcas(LjubimacPodatci);
                //txtIme.Text = ljubimac.Ime;
                //txtPrezime.Text = ljubimac.Prezime;
                txtBrojKartona.Text = LjubimacPodatci.BrojKartona.ToString();
                richtxtBiljeske.Text = LjubimacPodatci.Biljeske;
                dgvPosjeta.DataSource = posjeta;
                if (dgvPosjeta.Rows.Count > 0)
                {
                    dgvPosjeta.CurrentRow.Selected = true;
                }
                else
                {
                    dgvBolesti.DataSource = null;
                    dgvLijekovi.DataSource = null;
                    MessageBox.Show("Digitalni karton je trenutno prazan!");
                }
                dgvPosjeta.Columns["Korisnik"].Visible = false;
                dgvPosjeta.Columns["KorisnikID"].Visible = false;
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

        private void btnEvidentirajPosjet_Click(object sender, EventArgs e)
        {
            FrmEvidentiraj formEvidentiraj = new FrmEvidentiraj(prijavljenKorisnik);
            formEvidentiraj.ShowDialog();

            cmbLjubimac_SelectedIndexChanged(sender, e);
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
