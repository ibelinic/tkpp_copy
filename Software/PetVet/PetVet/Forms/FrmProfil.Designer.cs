namespace PetVet.Forms
{
    partial class FrmProfil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfil));
            this.cmbProfili = new System.Windows.Forms.ComboBox();
            this.lblChip = new System.Windows.Forms.Label();
            this.lblTezinaKg = new System.Windows.Forms.Label();
            this.lblVisinaCm = new System.Windows.Forms.Label();
            this.btnIzradiProfil = new System.Windows.Forms.Button();
            this.btnObrisiProfil = new System.Windows.Forms.Button();
            this.lblProfilLjubimca = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtBrojChipa = new System.Windows.Forms.TextBox();
            this.txtTezina = new System.Windows.Forms.TextBox();
            this.txtVisina = new System.Windows.Forms.TextBox();
            this.btnUredi = new System.Windows.Forms.Button();
            this.lblPasmina = new System.Windows.Forms.Label();
            this.txtPasminaLjubimca = new System.Windows.Forms.TextBox();
            this.lblKorisnik = new System.Windows.Forms.Label();
            this.txtKorisnik = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.btnDigitalniKarton = new System.Windows.Forms.Button();
            this.lblBrojIskaznice = new System.Windows.Forms.Label();
            this.txtBrojIskaznice = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbProfili
            // 
            this.cmbProfili.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cmbProfili.FormattingEnabled = true;
            this.cmbProfili.Location = new System.Drawing.Point(140, 20);
            this.cmbProfili.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbProfili.Name = "cmbProfili";
            this.cmbProfili.Size = new System.Drawing.Size(159, 21);
            this.cmbProfili.TabIndex = 0;
            this.cmbProfili.DropDownClosed += new System.EventHandler(this.cmbProfili_DropDownClosed);
            this.cmbProfili.Click += new System.EventHandler(this.cmbProfili_Click);
            // 
            // lblChip
            // 
            this.lblChip.AutoSize = true;
            this.lblChip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblChip.Location = new System.Drawing.Point(106, 139);
            this.lblChip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChip.Name = "lblChip";
            this.lblChip.Size = new System.Drawing.Size(52, 13);
            this.lblChip.TabIndex = 4;
            this.lblChip.Text = "BrojChipa";
            // 
            // lblTezinaKg
            // 
            this.lblTezinaKg.AutoSize = true;
            this.lblTezinaKg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblTezinaKg.Location = new System.Drawing.Point(101, 170);
            this.lblTezinaKg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTezinaKg.Name = "lblTezinaKg";
            this.lblTezinaKg.Size = new System.Drawing.Size(58, 13);
            this.lblTezinaKg.TabIndex = 5;
            this.lblTezinaKg.Text = "Tezina_Kg";
            // 
            // lblVisinaCm
            // 
            this.lblVisinaCm.AutoSize = true;
            this.lblVisinaCm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblVisinaCm.Location = new System.Drawing.Point(103, 197);
            this.lblVisinaCm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVisinaCm.Name = "lblVisinaCm";
            this.lblVisinaCm.Size = new System.Drawing.Size(56, 13);
            this.lblVisinaCm.TabIndex = 7;
            this.lblVisinaCm.Text = "Visina_Cm";
            // 
            // btnIzradiProfil
            // 
            this.btnIzradiProfil.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnIzradiProfil.Location = new System.Drawing.Point(46, 329);
            this.btnIzradiProfil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIzradiProfil.Name = "btnIzradiProfil";
            this.btnIzradiProfil.Size = new System.Drawing.Size(101, 24);
            this.btnIzradiProfil.TabIndex = 8;
            this.btnIzradiProfil.Text = "Izradi novi profil";
            this.btnIzradiProfil.UseVisualStyleBackColor = false;
            this.btnIzradiProfil.Click += new System.EventHandler(this.btnIzradiProfil_Click);
            // 
            // btnObrisiProfil
            // 
            this.btnObrisiProfil.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnObrisiProfil.Location = new System.Drawing.Point(258, 329);
            this.btnObrisiProfil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnObrisiProfil.Name = "btnObrisiProfil";
            this.btnObrisiProfil.Size = new System.Drawing.Size(101, 24);
            this.btnObrisiProfil.TabIndex = 9;
            this.btnObrisiProfil.Text = "Obriši profil";
            this.btnObrisiProfil.UseVisualStyleBackColor = false;
            this.btnObrisiProfil.Click += new System.EventHandler(this.btnObrisiProfil_Click);
            // 
            // lblProfilLjubimca
            // 
            this.lblProfilLjubimca.AutoSize = true;
            this.lblProfilLjubimca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblProfilLjubimca.Location = new System.Drawing.Point(32, 20);
            this.lblProfilLjubimca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProfilLjubimca.Name = "lblProfilLjubimca";
            this.lblProfilLjubimca.Size = new System.Drawing.Size(100, 18);
            this.lblProfilLjubimca.TabIndex = 11;
            this.lblProfilLjubimca.Text = "Profil ljubimca";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(65, 75);
            this.txtIme.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(99, 20);
            this.txtIme.TabIndex = 13;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(177, 75);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(99, 20);
            this.txtPrezime.TabIndex = 14;
            // 
            // txtBrojChipa
            // 
            this.txtBrojChipa.Location = new System.Drawing.Point(175, 135);
            this.txtBrojChipa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBrojChipa.Name = "txtBrojChipa";
            this.txtBrojChipa.ReadOnly = true;
            this.txtBrojChipa.Size = new System.Drawing.Size(86, 20);
            this.txtBrojChipa.TabIndex = 15;
            // 
            // txtTezina
            // 
            this.txtTezina.Location = new System.Drawing.Point(175, 166);
            this.txtTezina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTezina.Name = "txtTezina";
            this.txtTezina.Size = new System.Drawing.Size(86, 20);
            this.txtTezina.TabIndex = 16;
            // 
            // txtVisina
            // 
            this.txtVisina.Location = new System.Drawing.Point(175, 193);
            this.txtVisina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVisina.Name = "txtVisina";
            this.txtVisina.Size = new System.Drawing.Size(86, 20);
            this.txtVisina.TabIndex = 17;
            // 
            // btnUredi
            // 
            this.btnUredi.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnUredi.Location = new System.Drawing.Point(152, 329);
            this.btnUredi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(101, 24);
            this.btnUredi.TabIndex = 19;
            this.btnUredi.Text = "Uredi profil";
            this.btnUredi.UseVisualStyleBackColor = false;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // lblPasmina
            // 
            this.lblPasmina.AutoSize = true;
            this.lblPasmina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblPasmina.Location = new System.Drawing.Point(70, 230);
            this.lblPasmina.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPasmina.Name = "lblPasmina";
            this.lblPasmina.Size = new System.Drawing.Size(88, 13);
            this.lblPasmina.TabIndex = 20;
            this.lblPasmina.Text = "Pasmina ljubimca";
            // 
            // txtPasminaLjubimca
            // 
            this.txtPasminaLjubimca.Location = new System.Drawing.Point(175, 226);
            this.txtPasminaLjubimca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPasminaLjubimca.Name = "txtPasminaLjubimca";
            this.txtPasminaLjubimca.ReadOnly = true;
            this.txtPasminaLjubimca.Size = new System.Drawing.Size(86, 20);
            this.txtPasminaLjubimca.TabIndex = 21;
            // 
            // lblKorisnik
            // 
            this.lblKorisnik.AutoSize = true;
            this.lblKorisnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblKorisnik.Location = new System.Drawing.Point(118, 260);
            this.lblKorisnik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKorisnik.Name = "lblKorisnik";
            this.lblKorisnik.Size = new System.Drawing.Size(44, 13);
            this.lblKorisnik.TabIndex = 22;
            this.lblKorisnik.Text = "Korisnik";
            // 
            // txtKorisnik
            // 
            this.txtKorisnik.Location = new System.Drawing.Point(175, 256);
            this.txtKorisnik.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKorisnik.Name = "txtKorisnik";
            this.txtKorisnik.ReadOnly = true;
            this.txtKorisnik.Size = new System.Drawing.Size(86, 20);
            this.txtKorisnik.TabIndex = 23;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblIme.Location = new System.Drawing.Point(104, 58);
            this.lblIme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(24, 13);
            this.lblIme.TabIndex = 26;
            this.lblIme.Text = "Ime";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblPrezime.Location = new System.Drawing.Point(208, 58);
            this.lblPrezime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(44, 13);
            this.lblPrezime.TabIndex = 27;
            this.lblPrezime.Text = "Prezime";
            // 
            // btnDigitalniKarton
            // 
            this.btnDigitalniKarton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnDigitalniKarton.Location = new System.Drawing.Point(152, 292);
            this.btnDigitalniKarton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDigitalniKarton.Name = "btnDigitalniKarton";
            this.btnDigitalniKarton.Size = new System.Drawing.Size(101, 24);
            this.btnDigitalniKarton.TabIndex = 28;
            this.btnDigitalniKarton.Text = "Digitalni karton";
            this.btnDigitalniKarton.UseVisualStyleBackColor = false;
            this.btnDigitalniKarton.Click += new System.EventHandler(this.btnDigitalniKarton_Click);
            // 
            // lblBrojIskaznice
            // 
            this.lblBrojIskaznice.AutoSize = true;
            this.lblBrojIskaznice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblBrojIskaznice.Location = new System.Drawing.Point(87, 109);
            this.lblBrojIskaznice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBrojIskaznice.Name = "lblBrojIskaznice";
            this.lblBrojIskaznice.Size = new System.Drawing.Size(72, 13);
            this.lblBrojIskaznice.TabIndex = 29;
            this.lblBrojIskaznice.Text = "Broj iskaznice";
            // 
            // txtBrojIskaznice
            // 
            this.txtBrojIskaznice.Location = new System.Drawing.Point(175, 105);
            this.txtBrojIskaznice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBrojIskaznice.Name = "txtBrojIskaznice";
            this.txtBrojIskaznice.ReadOnly = true;
            this.txtBrojIskaznice.Size = new System.Drawing.Size(86, 20);
            this.txtBrojIskaznice.TabIndex = 30;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(302, 21);
            this.txtID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(37, 20);
            this.txtID.TabIndex = 31;
            // 
            // FrmProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(389, 379);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtBrojIskaznice);
            this.Controls.Add(this.lblBrojIskaznice);
            this.Controls.Add(this.btnDigitalniKarton);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.txtKorisnik);
            this.Controls.Add(this.lblKorisnik);
            this.Controls.Add(this.txtPasminaLjubimca);
            this.Controls.Add(this.lblPasmina);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.txtVisina);
            this.Controls.Add(this.txtTezina);
            this.Controls.Add(this.txtBrojChipa);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.lblProfilLjubimca);
            this.Controls.Add(this.btnObrisiProfil);
            this.Controls.Add(this.btnIzradiProfil);
            this.Controls.Add(this.lblVisinaCm);
            this.Controls.Add(this.lblTezinaKg);
            this.Controls.Add(this.lblChip);
            this.Controls.Add(this.cmbProfili);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmProfil";
            this.Text = "FrmProfil";
            this.Load += new System.EventHandler(this.FrmProfil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProfili;
        private System.Windows.Forms.Label lblChip;
        private System.Windows.Forms.Label lblTezinaKg;
        private System.Windows.Forms.Label lblVisinaCm;
        private System.Windows.Forms.Button btnIzradiProfil;
        private System.Windows.Forms.Button btnObrisiProfil;
        private System.Windows.Forms.Label lblProfilLjubimca;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtBrojChipa;
        private System.Windows.Forms.TextBox txtTezina;
        private System.Windows.Forms.TextBox txtVisina;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Label lblPasmina;
        private System.Windows.Forms.TextBox txtPasminaLjubimca;
        private System.Windows.Forms.Label lblKorisnik;
        private System.Windows.Forms.TextBox txtKorisnik;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Button btnDigitalniKarton;
        private System.Windows.Forms.Label lblBrojIskaznice;
        private System.Windows.Forms.TextBox txtBrojIskaznice;
        private System.Windows.Forms.TextBox txtID;
    }
}