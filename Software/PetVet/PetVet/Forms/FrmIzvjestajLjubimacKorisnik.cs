using BusinessLayer;
using DataAccessLayer;
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
    public partial class FrmIzvjestajLjubimacKorisnik : Form
    {
        private PosjetaLjubimcaServices services = new PosjetaLjubimcaServices();
        private LjubimacServices ljubimacServis= new LjubimacServices();
        private PreboljeleBolestiServices preboljeleServis = new PreboljeleBolestiServices();
        private LijekoviServices lijekoviServis=new LijekoviServices();

        public Ljubimac ljubimac;
        public PosjetaLjubimca posjeta;
        public FrmIzvjestajLjubimacKorisnik(Ljubimac selectedPet, PosjetaLjubimca odabranaPosjeta)
        {
            InitializeComponent();
            ljubimac = selectedPet;
            posjeta = odabranaPosjeta;
        }

        private void FrmIzvjestajLjubimac_Load(object sender, EventArgs e)
        {
            var ljubimac2 = ljubimacServis.GetLjubimac(ljubimac);
            ljubimacBindingSource.DataSource = ljubimac2;

            var posjetaLjubimca=services.GetOdabranaPosjeta(posjeta,ljubimac.ID);
            posjetaLjubimcaBindingSource.DataSource = posjetaLjubimca;

            var bolesti=preboljeleServis.GetBolesti(posjeta.ID);
            preboljeleBolestiBindingSource.DataSource = bolesti;

            var lijekovi=lijekoviServis.GetLijekovi(posjeta.ID);
            lijekoviBindingSource.DataSource = lijekovi;
            
            this.rvLjubimac.RefreshReport();
        }
    }
}
