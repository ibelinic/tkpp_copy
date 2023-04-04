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
    public partial class FrmPocetnaVeterinar : Form
    {
        private Korisnik prijavljen;
        VeterinarskaStanicaServices vetStanicaServis=new VeterinarskaStanicaServices();
        KorisnikService korisnikServis= new KorisnikService();

        public FrmPocetnaVeterinar(Korisnik veterinarPrijavljen)
        {
            InitializeComponent();
            this.prijavljen= veterinarPrijavljen;
        }

        private void btnRaspored_Click(object sender, EventArgs e)
        {
            FrmRaspored raspored= new FrmRaspored(prijavljen);
            this.Dispose();
            this.Close();
            raspored.ShowDialog();
        }

        private void FrmPocetnaVeterinar_Load(object sender, EventArgs e)
        {
            GetVeterinarskeStanice();
            
        }

        private void GetVeterinarskeStanice()
        {
            var radnoMjesto=korisnikServis.RadnoMjesto(prijavljen);

            if (radnoMjesto == null)
            {
                cmbRadnoMjesto.DataSource = vetStanicaServis.GetStanice();
            }
            else
            {
                txtRadnoMjesto.Text = radnoMjesto;
                cmbRadnoMjesto.DataSource = vetStanicaServis.GetStanice();
            }
            
                
            
        }

        private void btnEvidentiraj_Click(object sender, EventArgs e)
        {
            FrmEvidentiraj formaEvidentiraj = new FrmEvidentiraj(prijavljen.ID);
            formaEvidentiraj.ShowDialog();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            FrmPocetna pocetna = new FrmPocetna();
            this.Dispose();
            this.Close();
            pocetna.ShowDialog();
            
        }

        private void btnRadnoMjesto_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sigurni ste da želite promijeniti radno mjesto?", "Promjena radnog mjesta", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK) {
                VeterinarskaStanica selectedStanica = cmbRadnoMjesto.SelectedItem as VeterinarskaStanica;
                prijavljen.VeterinarskaStanicaID = selectedStanica.ID; 
                korisnikServis.UpdateKorisnik(prijavljen);
                GetVeterinarskeStanice();
            }
        }

        private void btnIzvjestaj_Click(object sender, EventArgs e)
        {
            FrmIzvjestajVeterinar izvjestaj = new FrmIzvjestajVeterinar(prijavljen);
            this.Dispose();
            this.Close();
            izvjestaj.ShowDialog();
        }

        private void btnIzradiKarton_Click(object sender, EventArgs e)
        {
            FrmDigitalniKartonVeterinar formaDigitalniKarton = new FrmDigitalniKartonVeterinar(prijavljen.ID);
            formaDigitalniKarton.ShowDialog();
        }
    }
}
