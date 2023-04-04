namespace PetVet.Forms
{
    partial class FrmKorisnik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKorisnik));
            this.btnOdjava = new System.Windows.Forms.Button();
            this.btnProfil = new System.Windows.Forms.Button();
            this.btnDostupniVeterinari = new System.Windows.Forms.Button();
            this.btnNadiKorisnika = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOdjava
            // 
            this.btnOdjava.BackColor = System.Drawing.Color.Tan;
            this.btnOdjava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdjava.Location = new System.Drawing.Point(432, 234);
            this.btnOdjava.Location = new System.Drawing.Point(432, 234);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(75, 23);
            this.btnOdjava.TabIndex = 0;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = false;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // btnProfil
            // 
            this.btnProfil.BackColor = System.Drawing.Color.Tan;
            this.btnProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfil.Location = new System.Drawing.Point(178, 31);
            this.btnProfil.Margin = new System.Windows.Forms.Padding(2);
            this.btnProfil.Location = new System.Drawing.Point(178, 31);
            this.btnProfil.Margin = new System.Windows.Forms.Padding(2);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(115, 28);
            this.btnProfil.TabIndex = 1;
            this.btnProfil.Text = "Profil";
            this.btnProfil.UseVisualStyleBackColor = false;
            this.btnProfil.Click += new System.EventHandler(this.btnProfil_Click);
            // 
            // btnDostupniVeterinari
            // 
            this.btnDostupniVeterinari.BackColor = System.Drawing.Color.Tan;
            this.btnDostupniVeterinari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDostupniVeterinari.Location = new System.Drawing.Point(164, 77);
            this.btnDostupniVeterinari.Margin = new System.Windows.Forms.Padding(2);
            this.btnDostupniVeterinari.Location = new System.Drawing.Point(164, 77);
            this.btnDostupniVeterinari.Margin = new System.Windows.Forms.Padding(2);
            this.btnDostupniVeterinari.Name = "btnDostupniVeterinari";
            this.btnDostupniVeterinari.Size = new System.Drawing.Size(141, 28);
            this.btnDostupniVeterinari.TabIndex = 2;
            this.btnDostupniVeterinari.Text = "Pregled dostupnih veterinara";
            this.btnDostupniVeterinari.UseVisualStyleBackColor = false;
            this.btnDostupniVeterinari.Click += new System.EventHandler(this.btnDostupniVeterinari_Click);
            // 
            // btnNadiKorisnika
            // 
            this.btnNadiKorisnika.Location = new System.Drawing.Point(178, 122);
            this.btnNadiKorisnika.Name = "btnNadiKorisnika";
            this.btnNadiKorisnika.Size = new System.Drawing.Size(115, 42);
            this.btnNadiKorisnika.TabIndex = 3;
            this.btnNadiKorisnika.Text = "Nađi korisnika i njegovog ljubimca";
            this.btnNadiKorisnika.UseVisualStyleBackColor = true;
            this.btnNadiKorisnika.Click += new System.EventHandler(this.btnNadiKorisnika_Click);
            // 
            // FrmKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(519, 269);
            this.ClientSize = new System.Drawing.Size(519, 269);
            this.Controls.Add(this.btnNadiKorisnika);
            this.Controls.Add(this.btnDostupniVeterinari);
            this.Controls.Add(this.btnProfil);
            this.Controls.Add(this.btnOdjava);
            this.Name = "FrmKorisnik";
            this.Text = "Početna Korisnik";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Button btnProfil;
        private System.Windows.Forms.Button btnDostupniVeterinari;
        private System.Windows.Forms.Button btnNadiKorisnika;
    }
}