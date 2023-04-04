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
    public partial class FrmDodajNaRaspored : Form
    {
        private int prijavljenVeterinar;
        private RasporedService rasporedServis=new RasporedService();
        private LjubimacServices ljubimacServis=new LjubimacServices();
        public FrmDodajNaRaspored(int prijavljen)
        {
            InitializeComponent();
            prijavljenVeterinar=prijavljen;
        }

        private void FrmDodajNaRaspored_Load(object sender, EventArgs e)
        {
            PrikaziSamoDatum();
            PrikaziLjubimce();
        }

        private void PrikaziLjubimce()
        {
            cmbLjubimac.DataSource = ljubimacServis.GetPets();
        }

        private void PrikaziSamoDatum()
        {
            dtpPocetak.Format = DateTimePickerFormat.Time;
            dtpPocetak.ShowUpDown = true;
            dtpZavrsetak.Format = DateTimePickerFormat.Time;
            dtpZavrsetak.ShowUpDown = true;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var ljubimacID = cmbLjubimac.SelectedItem as Ljubimac;
            var novaAktivnost = new Raspored {
                Datum = dtpDatum.Value,
                Pocetak=dtpPocetak.Value.TimeOfDay,
                Zavrsetak= dtpZavrsetak.Value.TimeOfDay,
                OpisZauzetosti=txtOpis.Text,
                KorisnikID=prijavljenVeterinar,
                LjubimacID=ljubimacID.ID
            };
            var spremljen=rasporedServis.DodajNaRaspored(novaAktivnost);
            if (spremljen == true)
            {
                Close();
            }
            else
            {
                MessageBox.Show("Nije spremljeno!");
            }
           
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
