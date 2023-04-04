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
    public partial class FrmKorisnik : Form
    {
        private int prijavljen;

        public FrmKorisnik(Korisnik prijavljen)
        {
            InitializeComponent();
            this.prijavljen = prijavljen.ID;
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            Hide();
            FrmPocetna form = new FrmPocetna();
            form.ShowDialog();   
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            Close();
            FrmProfil formaProfil = new FrmProfil(prijavljen);
            formaProfil.ShowDialog();
        }

        private void btnDostupniVeterinari_Click(object sender, EventArgs e)
        {
            Close();
            FrmDostupniVeterinari formaDostupniVeterinari = new FrmDostupniVeterinari(prijavljen);
            formaDostupniVeterinari.ShowDialog();
        }

        private void btnNadiKorisnika_Click(object sender, EventArgs e)
        {
            FrmPronadiKorisnika formaNadiKorisnika = new FrmPronadiKorisnika();
            formaNadiKorisnika.ShowDialog();
        }
    }
}
