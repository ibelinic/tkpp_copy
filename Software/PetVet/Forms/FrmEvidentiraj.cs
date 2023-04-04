using BusinessLayer;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace PetVet.Forms
{
    public partial class FrmEvidentiraj : Form
    {
        private LjubimacServices services = new LjubimacServices();
        private int prijavljenVeterinar;

        public FrmEvidentiraj(int prijavljenVeterinar)
        {
            InitializeComponent();
            this.prijavljenVeterinar = prijavljenVeterinar;
        }

        private void FrmEvidentiraj_Load(object sender, EventArgs e)
        {
            cmbLjubimci.Text = "Odaberite željenog ljubimca!";
            dtpPosjeta.Value = DateTime.Now;
            dtpDatumBolesti.Value = DateTime.Now;
            txtKorisnikVeterinar.Text = prijavljenVeterinar.ToString();
            txtKorisnikVeterinar.Visible = false;
            txtLjubimac.Visible = false;
            btnNadopuniPostojecu.Visible = false;
            cmbPosjete.Text = "Odaberite postojeći termin!";
            lblUnesi.Visible = false;
            btnEvidentiraj.Enabled = false;
            //onemoguci dok se ne odabere ljubimac
            DisableInputs();
        }

        private void DisableInputs()
        {
            cmbPosjete.Enabled = false;
            dtpPosjeta.Enabled = false;
            rtxtRazlogPosjete.Enabled = false;
            cbSpremi.Enabled = false;
            txtNaziv.Enabled = false;
            rtxtOpisBolesti.Enabled = false;
            dtpDatumBolesti.Enabled = false;
            txtNazivLijeka.Enabled = false;
            rtxtOpisLijeka.Enabled = false;
            btnPonisti.Enabled = false;
        }

        private void FillPosjetaComboBox(Ljubimac ljubimac)
        {
            var posjetaServis = new PosjetaLjubimcaServices();
            var posjeta = posjetaServis.GetPosjetaLjubimcas(ljubimac);
            cmbPosjete.DataSource = posjeta;
            cmbPosjete.Text = "Odaberite postojeći termin!";
        }

        private void FillPetsComboBox()
        {
            var petsServices = new LjubimacServices();
            var pets = petsServices.GetPets();
            cmbLjubimci.DataSource = pets;
        }

        private void cmbLjubimci_Click(object sender, EventArgs e)
        {
            FillPetsComboBox();
        }

        private void cmbLjubimci_DropDownClosed(object sender, EventArgs e)
        {
            var selectedPet = cmbLjubimci.SelectedItem as Ljubimac;
            FillTextBox(selectedPet);
            FillPosjetaComboBox(selectedPet);
            cmbPosjete.Enabled = true;
            dtpPosjeta.Enabled = true;
            rtxtRazlogPosjete.Enabled = true;
            cbSpremi.Enabled = true;
            btnEvidentiraj.Enabled = true;
        }

        private void FillTextBox(Ljubimac ljubimac)
        {
            txtBrojKartona.Text = ljubimac.BrojKartona.ToString();
            rtxtBiljeske.Text = ljubimac.Biljeske;
            txtLjubimac.Text = ljubimac.ID.ToString();
        }

        private void btnEvidentiraj_Click(object sender, EventArgs e)
        {
            //Update
            var selectedPet = cmbLjubimci.SelectedItem as Ljubimac;
            selectedPet.Biljeske = rtxtBiljeske.Text;
            services.UpdateLjubimac(selectedPet);
            cmbLjubimci.Text = "Odaberite željenog ljubimca!";

            //Get ID of last inserted visit
            var posjetaServis = new PosjetaLjubimcaServices();
            var lastInsertedPosjeta = posjetaServis.GetLastInsertedPosjeta();

            //Add bolest
            var bolest = new PreboljeleBolesti
            {
                Naziv = txtNaziv.Text,
                Opis = rtxtOpisBolesti.Text,
                DatumBolesti = dtpDatumBolesti.Value,
                PosjetaLjubimcaID = lastInsertedPosjeta
            };
            if (txtNaziv.Text != null && rtxtOpisBolesti.Text != null && dtpDatumBolesti.Value != null)
            {
                var bolestServis = new PreboljeleBolestiServices();
                bolestServis.AddBolest(bolest);
            }
            else
            {
                MessageBox.Show("Nisu uneseni svi podaci!");
            }

            //Add lijek
            var lijek = new Lijekovi
            {
                Naziv = txtNazivLijeka.Text,
                Opis = rtxtOpisLijeka.Text,
                PosjetaLjubimcaID = lastInsertedPosjeta
            };
            if (txtNazivLijeka.Text != null && rtxtOpisLijeka.Text != null)
            {
                var lijekServis = new LijekoviServices();
                lijekServis.AddLijek(lijek);
            }
            else
            {
                MessageBox.Show("Nisu uneseni svi podaci!");
            }

            //Isprazni sve textboxove
            EmptyTextBox();
            DisableInputs();
        }

        private void EmptyTextBox()
        {
            txtBrojKartona.Text = "";
            rtxtBiljeske.Text = "";
            dtpPosjeta.Value = DateTime.Now;
            rtxtRazlogPosjete.Text = "";
            txtKorisnikVeterinar.Text = "";
            txtLjubimac.Text = "";
            txtNaziv.Text = "";
            rtxtOpisBolesti.Text = "";
            dtpDatumBolesti.Value = DateTime.Now;
            if (cbSpremi.Checked)
            {
                cbSpremi.Checked = false;

            }
            txtNazivLijeka.Text = "";
            rtxtOpisLijeka.Text = "";
            cmbPosjete.Text = "Odaberite postojeći termin!";
            cmbPosjete.SelectedItem = null;
            cmbLjubimci.SelectedItem = null;
            cmbLjubimci.Text = "Odaberite željenog ljubimca!";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }



        private void btnNadopuniPostojecu_Click(object sender, EventArgs e)
        {
            //Update
            var selectedPet = cmbLjubimci.SelectedItem as Ljubimac;
            selectedPet.Biljeske = rtxtBiljeske.Text;
            services.UpdateLjubimac(selectedPet);
            cmbLjubimci.Text = "Odaberite željenog ljubimca!";

            var selectedPosjeta = cmbPosjete.SelectedItem as PosjetaLjubimca;
            //Add bolest
            var bolest = new PreboljeleBolesti
            {
                Naziv = txtNaziv.Text,
                Opis = rtxtOpisBolesti.Text,
                DatumBolesti = dtpDatumBolesti.Value,
                PosjetaLjubimcaID = selectedPosjeta.ID
            };
            if (txtNaziv.Text != null && rtxtOpisBolesti.Text != null && dtpDatumBolesti.Value != null)
            {
                var bolestServis = new PreboljeleBolestiServices();
                bolestServis.AddBolest(bolest);
            }
            else
            {
                MessageBox.Show("Nisu uneseni svi podaci!");
            }

            //Add lijek
            var lijek = new Lijekovi
            {
                Naziv = txtNazivLijeka.Text,
                Opis = rtxtOpisLijeka.Text,
                PosjetaLjubimcaID = selectedPosjeta.ID
            };
            if (txtNazivLijeka.Text != null && rtxtOpisLijeka.Text != null)
            {
                var lijekServis = new LijekoviServices();
                lijekServis.AddLijek(lijek);
            }
            else
            {
                MessageBox.Show("Nisu uneseni svi podaci!");
            }

            //Isprazni sve textboxove
            EmptyTextBox();
            DisableInputs();


        }

        private void cmbPosjete_DropDownClosed(object sender, EventArgs e)
        {
            var selectedPosjeta = cmbPosjete.SelectedItem as PosjetaLjubimca;
            FillTextBoxPosjeta(selectedPosjeta);
            dtpPosjeta.Enabled = false;
            rtxtRazlogPosjete.Enabled = false;

            cbSpremi.Visible = false;
            btnEvidentiraj.Visible = false;
            btnNadopuniPostojecu.Visible = true;
            lblUnesi.Visible = true;
            txtNaziv.Enabled = true;
            rtxtOpisBolesti.Enabled = true;
            dtpDatumBolesti.Enabled = true;
            txtNazivLijeka.Enabled = true;
            rtxtOpisLijeka.Enabled = true;
            btnPonisti.Enabled = true;
        }

        private void FillTextBoxPosjeta(PosjetaLjubimca selectedPosjeta)
        {
            dtpDatumBolesti.Value = selectedPosjeta.DatumPosjete;
            rtxtRazlogPosjete.Text = selectedPosjeta.RazlogPosjete;
        }

        private void btnPonisti_Click(object sender, EventArgs e)
        {
            cmbPosjete.SelectedItem = null;
            cmbPosjete.Text = "Odaberite postojeći termin!";
            cbSpremi.Visible = false;
            btnEvidentiraj.Visible = true;
            btnNadopuniPostojecu.Visible = false;
            dtpPosjeta.Enabled = true;
            dtpPosjeta.Value = DateTime.Now;
            rtxtRazlogPosjete.Text = "";
            cbSpremi.Visible = true;
            lblUnesi.Visible = false;
        }

        private void cbSpremi_Click(object sender, EventArgs e)
        {
            var posjeta = new PosjetaLjubimca
            {
                DatumPosjete = dtpPosjeta.Value,
                RazlogPosjete = rtxtRazlogPosjete.Text,
                KorisnikID = Convert.ToInt32(txtKorisnikVeterinar.Text),
                LjubimacID = Convert.ToInt32(txtLjubimac.Text)
            };
            if (dtpPosjeta.Value != null && rtxtRazlogPosjete.Text != null)
            {
                var posjetaServis = new PosjetaLjubimcaServices();
                posjetaServis.AddPosjeta(posjeta);
                txtNaziv.Enabled = true;
                rtxtOpisBolesti.Enabled = true;
                dtpDatumBolesti.Enabled = true;
                txtNazivLijeka.Enabled = true;
                rtxtOpisLijeka.Enabled = true;
            }
            else
            {
                MessageBox.Show("Nisu uneseni svi podaci za posjetu!");
            }
        }

    }
}
