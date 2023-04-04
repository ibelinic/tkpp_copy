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
    public partial class FrmPocetna : Form
    {
        public FrmPocetna()
        {
            InitializeComponent();
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRegistracija registriraj = new FrmRegistracija();
            registriraj.ShowDialog();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPrijava prijava = new FrmPrijava();
            prijava.ShowDialog();
        }
    }
}
