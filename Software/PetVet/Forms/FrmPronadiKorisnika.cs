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
    public partial class FrmPronadiKorisnika : Form
    {
        private LjubimacServices ljubimacServices = new LjubimacServices();

        public FrmPronadiKorisnika()
        {
            InitializeComponent();
        }

        private void txtLjubimac_TextChanged(object sender, EventArgs e)
        {
            var pets = ljubimacServices.GetPetsByName(txtLjubimac.Text);
            var source = new BindingSource();
            source.DataSource = pets;
            dgvPrikazKorisnika.DataSource = source;

            dgvPrikazKorisnika.Columns[0].Visible = false;
            dgvPrikazKorisnika.Columns[3].Visible = false;
            dgvPrikazKorisnika.Columns[4].Visible = false;
            dgvPrikazKorisnika.Columns[5].Visible = false;
            dgvPrikazKorisnika.Columns[6].Visible = false;
            dgvPrikazKorisnika.Columns[7].Visible = false;
            dgvPrikazKorisnika.Columns[8].Visible = false;
            dgvPrikazKorisnika.Columns[9].Visible = false;
            dgvPrikazKorisnika.Columns[10].Visible = false; //TipLjubimcaID
            dgvPrikazKorisnika.Columns[13].Visible = false;
            dgvPrikazKorisnika.Columns[14].Visible = false;
        }
    }
}
