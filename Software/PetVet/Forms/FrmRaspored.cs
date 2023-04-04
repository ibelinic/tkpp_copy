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
    public partial class FrmRaspored : Form
    {
        
        private RasporedService rasporedServis = new RasporedService();
        private Korisnik prijavljenVeterinar;

        Dictionary<int, string> ljubimacDictionary = new Dictionary<int, string>();

        public FrmRaspored(Korisnik veterinar)
        {
            InitializeComponent();
            prijavljenVeterinar = veterinar;
        }

        
        private void FrmRaspored_Load(object sender, EventArgs e)
        {
            GetRaspored();
        }

        private void GetRaspored() {
          
            dgvRaspored.DataSource = rasporedServis.GetRasporedVeterinar(prijavljenVeterinar);
            dgvRaspored.Columns[0].Visible = false;
            dgvRaspored.Columns[5].Visible = false;
            dgvRaspored.Columns[7].Visible = false;
            dgvRaspored.Columns[8].Visible = false;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmDodajNaRaspored dodajRaspored = new FrmDodajNaRaspored(prijavljenVeterinar.ID);
            dodajRaspored.ShowDialog();
            GetRaspored();
        }

        private void btnAžuriraj_Click(object sender, EventArgs e)
        {
            var odabranaAktivnost=dgvRaspored.CurrentRow.DataBoundItem as Raspored;
            FrmAzurirajRaspored azurirajAktivnost = new FrmAzurirajRaspored(odabranaAktivnost);
            azurirajAktivnost.ShowDialog();
            GetRaspored();

        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            var odabranaAktivnost = dgvRaspored.CurrentRow.DataBoundItem as Raspored;
            rasporedServis.Remove(odabranaAktivnost);
            GetRaspored();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            
            FrmPocetnaVeterinar pocetna = new FrmPocetnaVeterinar(prijavljenVeterinar);
            this.Dispose();
            this.Close();
            pocetna.ShowDialog();
        }

        private void btnPastAppointment_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
            FrmProsliTermini formaProsli = new FrmProsliTermini(prijavljenVeterinar);
            formaProsli.ShowDialog();
        }

    }
}
