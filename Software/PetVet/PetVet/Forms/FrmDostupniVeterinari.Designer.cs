namespace PetVet.Forms
{
    partial class FrmDostupniVeterinari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDostupniVeterinari));
            this.lblDostupniVeterinari = new System.Windows.Forms.Label();
            this.dgvDostupniVeterinari = new System.Windows.Forms.DataGridView();
            this.cmbVeterinari = new System.Windows.Forms.ComboBox();
            this.dtpPregled = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrijaviTermin = new System.Windows.Forms.Button();
            this.btnOdjaviTermin = new System.Windows.Forms.Button();
            this.lblTrajanje = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPocetak = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.dtPocetak = new System.Windows.Forms.DateTimePicker();
            this.txtOpisZauzetosti = new System.Windows.Forms.TextBox();
            this.lblOpisZauzetosti = new System.Windows.Forms.Label();
            this.dtZavrsetak = new System.Windows.Forms.DateTimePicker();
            this.lblZavrsetak = new System.Windows.Forms.Label();
            this.txtKorisnik = new System.Windows.Forms.TextBox();
            this.lblKorisnik = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbLjubimac = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDostupniVeterinari)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDostupniVeterinari
            // 
            this.lblDostupniVeterinari.AutoSize = true;
            this.lblDostupniVeterinari.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblDostupniVeterinari.Location = new System.Drawing.Point(183, 7);
            this.lblDostupniVeterinari.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDostupniVeterinari.Name = "lblDostupniVeterinari";
            this.lblDostupniVeterinari.Size = new System.Drawing.Size(194, 18);
            this.lblDostupniVeterinari.TabIndex = 1;
            this.lblDostupniVeterinari.Text = "Pregled dostupnih veterinara";
            // 
            // dgvDostupniVeterinari
            // 
            this.dgvDostupniVeterinari.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgvDostupniVeterinari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDostupniVeterinari.Location = new System.Drawing.Point(20, 72);
            this.dgvDostupniVeterinari.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDostupniVeterinari.Location = new System.Drawing.Point(20, 72);
            this.dgvDostupniVeterinari.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDostupniVeterinari.Name = "dgvDostupniVeterinari";
            this.dgvDostupniVeterinari.RowHeadersWidth = 51;
            this.dgvDostupniVeterinari.RowTemplate.Height = 24;
            this.dgvDostupniVeterinari.Size = new System.Drawing.Size(470, 171);
            this.dgvDostupniVeterinari.TabIndex = 2;
            // 
            // cmbVeterinari
            // 
            this.cmbVeterinari.FormattingEnabled = true;
            this.cmbVeterinari.Location = new System.Drawing.Point(20, 47);
            this.cmbVeterinari.Margin = new System.Windows.Forms.Padding(2);
            this.cmbVeterinari.Location = new System.Drawing.Point(20, 47);
            this.cmbVeterinari.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbVeterinari.Name = "cmbVeterinari";
            this.cmbVeterinari.Size = new System.Drawing.Size(212, 21);
            this.cmbVeterinari.TabIndex = 3;
            this.cmbVeterinari.DropDownClosed += new System.EventHandler(this.cmbVeterinari_DropDownClosed);
            this.cmbVeterinari.Click += new System.EventHandler(this.cmbVeterinari_Click);
            // 
            // dtpPregled
            // 
            this.dtpPregled.Location = new System.Drawing.Point(57, 343);
            this.dtpPregled.Margin = new System.Windows.Forms.Padding(2);
            this.dtpPregled.Location = new System.Drawing.Point(55, 295);
            this.dtpPregled.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpPregled.Name = "dtpPregled";
            this.dtpPregled.ShowCheckBox = true;
            this.dtpPregled.Size = new System.Drawing.Size(212, 20);
            this.dtpPregled.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ovdje su prikazani zauzeti termini odabranog veterinara!";
            // 
            // btnPrijaviTermin
            // 
            this.btnPrijaviTermin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPrijaviTermin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnPrijaviTermin.Location = new System.Drawing.Point(344, 383);
            this.btnPrijaviTermin.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrijaviTermin.Location = new System.Drawing.Point(342, 335);
            this.btnPrijaviTermin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrijaviTermin.Name = "btnPrijaviTermin";
            this.btnPrijaviTermin.Size = new System.Drawing.Size(82, 29);
            this.btnPrijaviTermin.TabIndex = 6;
            this.btnPrijaviTermin.Text = "Prijavi termin";
            this.btnPrijaviTermin.UseVisualStyleBackColor = false;
            this.btnPrijaviTermin.Click += new System.EventHandler(this.btnPrijaviTermin_Click);
            // 
            // btnOdjaviTermin
            // 
            this.btnOdjaviTermin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOdjaviTermin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnOdjaviTermin.Location = new System.Drawing.Point(344, 428);
            this.btnOdjaviTermin.Margin = new System.Windows.Forms.Padding(2);
            this.btnOdjaviTermin.Location = new System.Drawing.Point(342, 380);
            this.btnOdjaviTermin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOdjaviTermin.Name = "btnOdjaviTermin";
            this.btnOdjaviTermin.Size = new System.Drawing.Size(82, 29);
            this.btnOdjaviTermin.TabIndex = 7;
            this.btnOdjaviTermin.Text = "Odjavi termin";
            this.btnOdjaviTermin.UseVisualStyleBackColor = false;
            this.btnOdjaviTermin.Click += new System.EventHandler(this.btnOdjaviTermin_Click);
            // 
            // lblTrajanje
            // 
            this.lblTrajanje.AutoSize = true;
            this.lblTrajanje.Location = new System.Drawing.Point(41, 255);
            this.lblTrajanje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrajanje.Name = "lblTrajanje";
            this.lblTrajanje.Size = new System.Drawing.Size(430, 13);
            this.lblTrajanje.TabIndex = 9;
            this.lblTrajanje.Text = "Kod prijave termina, pripazite na vrijeme trajanja pregleda! Pregled traje otpril" +
    "ike 30 minuta!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 301);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 11;
            // 
            // lblPocetak
            // 
            this.lblPocetak.AutoSize = true;
            this.lblPocetak.Location = new System.Drawing.Point(55, 368);
            this.lblPocetak.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPocetak.Location = new System.Drawing.Point(53, 320);
            this.lblPocetak.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPocetak.Name = "lblPocetak";
            this.lblPocetak.Size = new System.Drawing.Size(264, 13);
            this.lblPocetak.TabIndex = 12;
            this.lblPocetak.Text = "Unesite željeno vrijeme početka u formatu HH:MM:SS!";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(55, 327);
            this.lblDatum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatum.Location = new System.Drawing.Point(53, 279);
            this.lblDatum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(120, 13);
            this.lblDatum.TabIndex = 13;
            this.lblDatum.Text = "Odaberite željeni datum!";
            // 
            // dtPocetak
            // 
            this.dtPocetak.CustomFormat = "HH:mm:ss";
            this.dtPocetak.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPocetak.Location = new System.Drawing.Point(57, 383);
            this.dtPocetak.Margin = new System.Windows.Forms.Padding(2);
            this.dtPocetak.Location = new System.Drawing.Point(55, 335);
            this.dtPocetak.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtPocetak.Name = "dtPocetak";
            this.dtPocetak.ShowUpDown = true;
            this.dtPocetak.Size = new System.Drawing.Size(212, 20);
            this.dtPocetak.TabIndex = 14;
            // 
            // txtOpisZauzetosti
            // 
            this.txtOpisZauzetosti.Location = new System.Drawing.Point(57, 467);
            this.txtOpisZauzetosti.Margin = new System.Windows.Forms.Padding(2);
            this.txtOpisZauzetosti.Location = new System.Drawing.Point(55, 467);
            this.txtOpisZauzetosti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOpisZauzetosti.Name = "txtOpisZauzetosti";
            this.txtOpisZauzetosti.ReadOnly = true;
            this.txtOpisZauzetosti.Size = new System.Drawing.Size(212, 20);
            this.txtOpisZauzetosti.TabIndex = 15;
            // 
            // lblOpisZauzetosti
            // 
            this.lblOpisZauzetosti.AutoSize = true;
            this.lblOpisZauzetosti.Location = new System.Drawing.Point(55, 452);
            this.lblOpisZauzetosti.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOpisZauzetosti.Location = new System.Drawing.Point(53, 452);
            this.lblOpisZauzetosti.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOpisZauzetosti.Name = "lblOpisZauzetosti";
            this.lblOpisZauzetosti.Size = new System.Drawing.Size(78, 13);
            this.lblOpisZauzetosti.TabIndex = 16;
            this.lblOpisZauzetosti.Text = "Opis zauzetosti";
            // 
            // dtZavrsetak
            // 
            this.dtZavrsetak.CustomFormat = "HH:mm:ss";
            this.dtZavrsetak.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtZavrsetak.Location = new System.Drawing.Point(57, 425);
            this.dtZavrsetak.Margin = new System.Windows.Forms.Padding(2);
            this.dtZavrsetak.Location = new System.Drawing.Point(55, 377);
            this.dtZavrsetak.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtZavrsetak.Name = "dtZavrsetak";
            this.dtZavrsetak.ShowUpDown = true;
            this.dtZavrsetak.Size = new System.Drawing.Size(212, 20);
            this.dtZavrsetak.TabIndex = 17;
            // 
            // lblZavrsetak
            // 
            this.lblZavrsetak.AutoSize = true;
            this.lblZavrsetak.Location = new System.Drawing.Point(55, 410);
            this.lblZavrsetak.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblZavrsetak.Location = new System.Drawing.Point(53, 362);
            this.lblZavrsetak.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblZavrsetak.Name = "lblZavrsetak";
            this.lblZavrsetak.Size = new System.Drawing.Size(271, 13);
            this.lblZavrsetak.TabIndex = 18;
            this.lblZavrsetak.Text = "Unesite željeno vrijeme završetka u formatu HH:MM:SS!";
            // 
            // txtKorisnik
            // 
            this.txtKorisnik.Location = new System.Drawing.Point(57, 507);
            this.txtKorisnik.Margin = new System.Windows.Forms.Padding(2);
            this.txtKorisnik.Location = new System.Drawing.Point(55, 507);
            this.txtKorisnik.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKorisnik.Name = "txtKorisnik";
            this.txtKorisnik.ReadOnly = true;
            this.txtKorisnik.Size = new System.Drawing.Size(212, 20);
            this.txtKorisnik.TabIndex = 21;
            // 
            // lblKorisnik
            // 
            this.lblKorisnik.AutoSize = true;
            this.lblKorisnik.Location = new System.Drawing.Point(55, 492);
            this.lblKorisnik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKorisnik.Location = new System.Drawing.Point(53, 492);
            this.lblKorisnik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKorisnik.Name = "lblKorisnik";
            this.lblKorisnik.Size = new System.Drawing.Size(44, 13);
            this.lblKorisnik.TabIndex = 22;
            this.lblKorisnik.Text = "Korisnik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Ljubimac:";
            // 
            // cmbLjubimac
            // 
            this.cmbLjubimac.FormattingEnabled = true;
            this.cmbLjubimac.Location = new System.Drawing.Point(55, 420);
            this.cmbLjubimac.Name = "cmbLjubimac";
            this.cmbLjubimac.Size = new System.Drawing.Size(212, 21);
            this.cmbLjubimac.TabIndex = 24;
            // 
            // FrmDostupniVeterinari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(518, 546);
            this.ClientSize = new System.Drawing.Size(518, 546);
            this.Controls.Add(this.cmbLjubimac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblKorisnik);
            this.Controls.Add(this.txtKorisnik);
            this.Controls.Add(this.lblZavrsetak);
            this.Controls.Add(this.dtZavrsetak);
            this.Controls.Add(this.lblOpisZauzetosti);
            this.Controls.Add(this.txtOpisZauzetosti);
            this.Controls.Add(this.dtPocetak);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblPocetak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTrajanje);
            this.Controls.Add(this.btnOdjaviTermin);
            this.Controls.Add(this.btnPrijaviTermin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpPregled);
            this.Controls.Add(this.cmbVeterinari);
            this.Controls.Add(this.dgvDostupniVeterinari);
            this.Controls.Add(this.lblDostupniVeterinari);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmDostupniVeterinari";
            this.Text = "Dostupni veterinari";
            this.Load += new System.EventHandler(this.FrmDostupniVeterinari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDostupniVeterinari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDostupniVeterinari;
        private System.Windows.Forms.DataGridView dgvDostupniVeterinari;
        private System.Windows.Forms.ComboBox cmbVeterinari;
        private System.Windows.Forms.DateTimePicker dtpPregled;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrijaviTermin;
        private System.Windows.Forms.Button btnOdjaviTermin;
        private System.Windows.Forms.Label lblTrajanje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPocetak;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.DateTimePicker dtPocetak;
        private System.Windows.Forms.TextBox txtOpisZauzetosti;
        private System.Windows.Forms.Label lblOpisZauzetosti;
        private System.Windows.Forms.DateTimePicker dtZavrsetak;
        private System.Windows.Forms.Label lblZavrsetak;
        private System.Windows.Forms.TextBox txtKorisnik;
        private System.Windows.Forms.Label lblKorisnik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbLjubimac;
    }
}