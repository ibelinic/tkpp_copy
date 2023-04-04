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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace PetVet.Forms
{
    public partial class FrmDostupniVeterinari : Form
    {
        private int prijavljenKorisnik;
        public FrmDostupniVeterinari(int prijavljen)
        {
            InitializeComponent();
            this.prijavljenKorisnik = prijavljen;
        }

        private void FrmDostupniVeterinari_Load(object sender, EventArgs e)
        {
            cmbVeterinari.Text = "Odaberite željenog veterinara!";
            txtOpisZauzetosti.Text = "Pregled";
            txtKorisnik.Text = prijavljenKorisnik.ToString();
        }

        private void cmbVeterinari_Click(object sender, EventArgs e)
        {
            FillComboBox();
        }

        private void FillComboBox()
        {
            var vetsServices = new KorisnikService();
            var vet = vetsServices.GetVets();
            cmbVeterinari.DataSource = vet;

            var petsServices = new LjubimacServices();
            var pets = petsServices.GetPetsByKorisnik(prijavljenKorisnik);
            cmbLjubimac.DataSource = pets;
        }

        private void cmbVeterinari_DropDownClosed(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            var selectedVet = cmbVeterinari.SelectedItem as Korisnik;
            
            var rasporedService = new RasporedService();
            var schedule = rasporedService.GetRasporedVeterinar(selectedVet);

            dgvDostupniVeterinari.DataSource = schedule;
            dgvDostupniVeterinari.Columns["OpisZauzetosti"].Visible = false;
            dgvDostupniVeterinari.Columns["KorisnikID"].Visible = false;
            dgvDostupniVeterinari.Columns["Korisnik"].Visible = false;
            dgvDostupniVeterinari.Columns["LjubimacID"].Visible = false;
        }

        private void btnPrijaviTermin_Click(object sender, EventArgs e)
        {
            Raspored postojeciRaspored = new Raspored();
            var selectedVet = cmbVeterinari.SelectedItem as Korisnik;
            var selVet = selectedVet.ID;
            var selectedLjubimac = cmbLjubimac.SelectedItem as Ljubimac;
            var selLjubimac = selectedLjubimac.ID;
            var noviTermin = new Raspored
            {
                Datum = dtpPregled.Value,
                Pocetak = dtPocetak.Value.TimeOfDay,
                Zavrsetak = dtZavrsetak.Value.TimeOfDay,
                OpisZauzetosti = txtOpisZauzetosti.Text,
                KorisnikID = selVet,
                LjubimacID = selLjubimac
            };
            if (dtpPregled.Value != null && dtPocetak.Value.TimeOfDay != null && dtZavrsetak.Value.TimeOfDay != null)
            {
                var rasporedServices = new RasporedService();
                rasporedServices.DodajNaRaspored(noviTermin);
                RefreshDataGridView();
            }
            else
            {
                MessageBox.Show("Nisu uneseni svi podaci ili već postoji taj ID!");
            }
        }

        private void btnOdjaviTermin_Click(object sender, EventArgs e)
        {
            var selectedRow = dgvDostupniVeterinari.SelectedRows[0];
            int selectedID = (int)selectedRow.Cells["ID"].Value;
            var rasporedServices = new RasporedService();
            int selectedPetID = (int)selectedRow.Cells["LjubimacID"].Value;
            var petServices = new LjubimacServices();
            int scheduledByUserID = petServices.GetKorisnikIDByPetID(selectedPetID);

            if (scheduledByUserID == prijavljenKorisnik)
            {
                rasporedServices.OdjaviTermin(selectedID);
                RefreshDataGridView();
                MessageBox.Show("Termin uspješno odjavljen!");
            }
            else
            {
                MessageBox.Show("Nemate pravo odjaviti ovaj termin!");
            }
        }
    }
}
