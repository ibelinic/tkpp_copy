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
    public partial class FrmProsliTermini : Form
    {
        private Korisnik prijavljenVeterinar;
        private RasporedService rasporedServis = new RasporedService();
        public FrmProsliTermini(Korisnik prijavljenVeterinar)
        {
            InitializeComponent();
            this.prijavljenVeterinar = prijavljenVeterinar; 
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
            FrmRaspored formaRaspored = new FrmRaspored(prijavljenVeterinar);
            formaRaspored.ShowDialog();
        }

        private void FrmProsliTermini_Load(object sender, EventArgs e)
        {
            GetRasporedPast();
        }

        private void GetRasporedPast()
        {
            dgvPastAppointments.DataSource = rasporedServis.GetRasporedVeterinarPast(prijavljenVeterinar.ID);
            dgvPastAppointments.Columns[0].Visible = false;
            dgvPastAppointments.Columns[5].Visible = false;
            dgvPastAppointments.Columns[7].Visible = false;
            dgvPastAppointments.Columns[8].Visible = false;
            
        }
    }
}
