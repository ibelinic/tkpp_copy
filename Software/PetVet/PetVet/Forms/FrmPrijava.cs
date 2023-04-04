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
    public partial class FrmPrijava : Form
    {
        public FrmPrijava()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            var servis = new KorisnikService();
            if(txtKorisnickoIme.Text=="" || txtLozinka.Text=="")
            {
                label3.Text=("Unesite podatke!");
            }
            else
            {
                label3.Text = "";

                List<Korisnik>  pronaden =servis.KorisnikPostoji(txtKorisnickoIme.Text);
                bool ispravnaLozinka= servis.ProvjeriLozinku(txtKorisnickoIme.Text,txtLozinka.Text);
                if (pronaden.Count!=0)//ako ga ima
                {
                    if (!ispravnaLozinka)
                    {
                        label3.Text = ("Lozinka nije ispravna");
                    }
                    else
                    {
                        var uloga = servis.Uloga(pronaden[0]);
                        if (uloga.ToString() == "Veterinar")
                        {
                            //label3.Text = "Veterinar";
                             FrmPocetnaVeterinar forma = new FrmPocetnaVeterinar(pronaden[0]);
                             Close();
                             forma.Show();
                        }
                        if (uloga.ToString() == "Vlasnik")
                        {
                            //label3.Text = "Vlasnik";
                            FrmKorisnik korisnik = new FrmKorisnik(pronaden[0]);
                             Close();
                             korisnik.Show();
                        }
                    }
                    
                }
                else//ako ga nema
                {
                   MessageBox.Show("Neispravni podaci!");
                }
            }
            
        }
    }
}
