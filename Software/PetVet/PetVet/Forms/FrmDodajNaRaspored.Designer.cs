namespace PetVet.Forms
{
    partial class FrmDodajNaRaspored
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDodajNaRaspored));
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpPocetak = new System.Windows.Forms.DateTimePicker();
            this.dtpZavrsetak = new System.Windows.Forms.DateTimePicker();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.cmbLjubimac = new System.Windows.Forms.ComboBox();
            this.Ljubimac = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpDatum
            // 
            this.dtpDatum.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatum.Location = new System.Drawing.Point(56, 42);
            this.dtpDatum.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(151, 20);
            this.dtpDatum.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Opis";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(56, 197);
            this.txtOpis.Margin = new System.Windows.Forms.Padding(2);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(151, 20);
            this.txtOpis.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Početak";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Završetak";
            // 
            // dtpPocetak
            // 
            this.dtpPocetak.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.dtpPocetak.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPocetak.Location = new System.Drawing.Point(56, 93);
            this.dtpPocetak.Margin = new System.Windows.Forms.Padding(2);
            this.dtpPocetak.Name = "dtpPocetak";
            this.dtpPocetak.Size = new System.Drawing.Size(151, 20);
            this.dtpPocetak.TabIndex = 6;
            // 
            // dtpZavrsetak
            // 
            this.dtpZavrsetak.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.dtpZavrsetak.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpZavrsetak.Location = new System.Drawing.Point(56, 146);
            this.dtpZavrsetak.Margin = new System.Windows.Forms.Padding(2);
            this.dtpZavrsetak.Name = "dtpZavrsetak";
            this.dtpZavrsetak.Size = new System.Drawing.Size(151, 20);
            this.dtpZavrsetak.TabIndex = 7;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.Tan;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.Location = new System.Drawing.Point(52, 309);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(59, 28);
            this.btnDodaj.TabIndex = 8;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.Tan;
            this.btnOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdustani.Location = new System.Drawing.Point(146, 309);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(61, 28);
            this.btnOdustani.TabIndex = 9;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // cmbLjubimac
            // 
            this.cmbLjubimac.FormattingEnabled = true;
            this.cmbLjubimac.Location = new System.Drawing.Point(56, 250);
            this.cmbLjubimac.Name = "cmbLjubimac";
            this.cmbLjubimac.Size = new System.Drawing.Size(151, 21);
            this.cmbLjubimac.TabIndex = 10;
            // 
            // Ljubimac
            // 
            this.Ljubimac.AutoSize = true;
            this.Ljubimac.Location = new System.Drawing.Point(54, 234);
            this.Ljubimac.Name = "Ljubimac";
            this.Ljubimac.Size = new System.Drawing.Size(49, 13);
            this.Ljubimac.TabIndex = 11;
            this.Ljubimac.Text = "Ljubimac";
            // 
            // FrmDodajNaRaspored
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(284, 362);
            this.Controls.Add(this.Ljubimac);
            this.Controls.Add(this.cmbLjubimac);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dtpZavrsetak);
            this.Controls.Add(this.dtpPocetak);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDatum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmDodajNaRaspored";
            this.Text = "Dodaj na raspored";
            this.Load += new System.EventHandler(this.FrmDodajNaRaspored_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpPocetak;
        private System.Windows.Forms.DateTimePicker dtpZavrsetak;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.ComboBox cmbLjubimac;
        private System.Windows.Forms.Label Ljubimac;
    }
}