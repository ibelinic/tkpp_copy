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
    public partial class FrmAzurirajRaspored : Form
    {
        Raspored azurirajAktivnost;
        private RasporedService rasporedServis = new RasporedService();
        public FrmAzurirajRaspored(Raspored aktivnost)
        {
            InitializeComponent();
            azurirajAktivnost= aktivnost;
        }

        private void FrmAzurirajRaspored_Load(object sender, EventArgs e)
        {
            PrikaziSamoDatum();
            PopuniFormu();
            
        }

        private void PopuniFormu()
        {
            dtpDatum.Value = (DateTime)azurirajAktivnost.Datum;
            dtpPocetak.Value = Convert.ToDateTime(azurirajAktivnost.Pocetak.ToString());
            dtpZavrsetak.Value = Convert.ToDateTime(azurirajAktivnost.Zavrsetak.ToString());
            txtOpis.Text = azurirajAktivnost.OpisZauzetosti;
        }

        private void PrikaziSamoDatum()
        {
            dtpPocetak.Format = DateTimePickerFormat.Time;
            dtpPocetak.ShowUpDown = true;
            dtpZavrsetak.Format = DateTimePickerFormat.Time;
            dtpZavrsetak.ShowUpDown = true;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            azurirajAktivnost.Datum = dtpDatum.Value;
            azurirajAktivnost.Pocetak = dtpPocetak.Value.TimeOfDay;
            azurirajAktivnost.Zavrsetak = dtpZavrsetak.Value.TimeOfDay;
            azurirajAktivnost.OpisZauzetosti = txtOpis.Text;
            var azuriran=rasporedServis.Update(azurirajAktivnost);
            if (azuriran == true)
            {
                Close();
            }
            else
            {
                MessageBox.Show("Nije ažurirano!");
            }
        }
    }
}
