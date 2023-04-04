namespace PetVet.Forms
{
    partial class FrmEvidentiraj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEvidentiraj));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLjubimci = new System.Windows.Forms.ComboBox();
            this.lblBrojKartona = new System.Windows.Forms.Label();
            this.txtBrojKartona = new System.Windows.Forms.TextBox();
            this.rtxtBiljeske = new System.Windows.Forms.RichTextBox();
            this.lblBiljeske = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRazlogPosjete = new System.Windows.Forms.Label();
            this.rtxtRazlogPosjete = new System.Windows.Forms.RichTextBox();
            this.txtKorisnikVeterinar = new System.Windows.Forms.TextBox();
            this.txtLjubimac = new System.Windows.Forms.TextBox();
            this.btnEvidentiraj = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dtpPosjeta = new System.Windows.Forms.DateTimePicker();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblNazivBolesti = new System.Windows.Forms.Label();
            this.rtxtOpisBolesti = new System.Windows.Forms.RichTextBox();
            this.lblOpisBolesti = new System.Windows.Forms.Label();
            this.dtpDatumBolesti = new System.Windows.Forms.DateTimePicker();
            this.lblDatumBolesti = new System.Windows.Forms.Label();
            this.cbSpremi = new System.Windows.Forms.CheckBox();
            this.txtNazivLijeka = new System.Windows.Forms.TextBox();
            this.lblNazivLijeka = new System.Windows.Forms.Label();
            this.lblOpisLijeka = new System.Windows.Forms.Label();
            this.rtxtOpisLijeka = new System.Windows.Forms.RichTextBox();
            this.cmbPosjete = new System.Windows.Forms.ComboBox();
            this.btnNadopuniPostojecu = new System.Windows.Forms.Button();
            this.btnPonisti = new System.Windows.Forms.Button();
            this.lblUnesi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(116, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Evidentiranje tretmana u digitalni karton";
            // 
            // cmbLjubimci
            // 
            this.cmbLjubimci.FormattingEnabled = true;
            this.cmbLjubimci.Location = new System.Drawing.Point(128, 34);
            this.cmbLjubimci.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLjubimci.Name = "cmbLjubimci";
            this.cmbLjubimci.Size = new System.Drawing.Size(182, 21);
            this.cmbLjubimci.TabIndex = 1;
            this.cmbLjubimci.DropDownClosed += new System.EventHandler(this.cmbLjubimci_DropDownClosed);
            this.cmbLjubimci.Click += new System.EventHandler(this.cmbLjubimci_Click);
            // 
            // lblBrojKartona
            // 
            this.lblBrojKartona.AutoSize = true;
            this.lblBrojKartona.Location = new System.Drawing.Point(13, 89);
            this.lblBrojKartona.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBrojKartona.Name = "lblBrojKartona";
            this.lblBrojKartona.Size = new System.Drawing.Size(64, 13);
            this.lblBrojKartona.TabIndex = 2;
            this.lblBrojKartona.Text = "Broj kartona";
            // 
            // txtBrojKartona
            // 
            this.txtBrojKartona.Location = new System.Drawing.Point(76, 86);
            this.txtBrojKartona.Margin = new System.Windows.Forms.Padding(2);
            this.txtBrojKartona.Name = "txtBrojKartona";
            this.txtBrojKartona.ReadOnly = true;
            this.txtBrojKartona.Size = new System.Drawing.Size(76, 20);
            this.txtBrojKartona.TabIndex = 3;
            // 
            // rtxtBiljeske
            // 
            this.rtxtBiljeske.Location = new System.Drawing.Point(76, 120);
            this.rtxtBiljeske.Margin = new System.Windows.Forms.Padding(2);
            this.rtxtBiljeske.Name = "rtxtBiljeske";
            this.rtxtBiljeske.Size = new System.Drawing.Size(76, 180);
            this.rtxtBiljeske.TabIndex = 4;
            this.rtxtBiljeske.Text = "";
            // 
            // lblBiljeske
            // 
            this.lblBiljeske.AutoSize = true;
            this.lblBiljeske.Location = new System.Drawing.Point(31, 120);
            this.lblBiljeske.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBiljeske.Name = "lblBiljeske";
            this.lblBiljeske.Size = new System.Drawing.Size(43, 13);
            this.lblBiljeske.TabIndex = 5;
            this.lblBiljeske.Text = "Bilješke";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Datum posjete";
            // 
            // lblRazlogPosjete
            // 
            this.lblRazlogPosjete.AutoSize = true;
            this.lblRazlogPosjete.Location = new System.Drawing.Point(183, 146);
            this.lblRazlogPosjete.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRazlogPosjete.Name = "lblRazlogPosjete";
            this.lblRazlogPosjete.Size = new System.Drawing.Size(77, 13);
            this.lblRazlogPosjete.TabIndex = 11;
            this.lblRazlogPosjete.Text = "Razlog posjete";
            // 
            // rtxtRazlogPosjete
            // 
            this.rtxtRazlogPosjete.Location = new System.Drawing.Point(261, 146);
            this.rtxtRazlogPosjete.Margin = new System.Windows.Forms.Padding(2);
            this.rtxtRazlogPosjete.Name = "rtxtRazlogPosjete";
            this.rtxtRazlogPosjete.Size = new System.Drawing.Size(184, 45);
            this.rtxtRazlogPosjete.TabIndex = 12;
            this.rtxtRazlogPosjete.Text = "";
            // 
            // txtKorisnikVeterinar
            // 
            this.txtKorisnikVeterinar.Location = new System.Drawing.Point(401, 10);
            this.txtKorisnikVeterinar.Margin = new System.Windows.Forms.Padding(2);
            this.txtKorisnikVeterinar.Name = "txtKorisnikVeterinar";
            this.txtKorisnikVeterinar.Size = new System.Drawing.Size(20, 20);
            this.txtKorisnikVeterinar.TabIndex = 14;
            // 
            // txtLjubimac
            // 
            this.txtLjubimac.Location = new System.Drawing.Point(424, 10);
            this.txtLjubimac.Margin = new System.Windows.Forms.Padding(2);
            this.txtLjubimac.Name = "txtLjubimac";
            this.txtLjubimac.Size = new System.Drawing.Size(20, 20);
            this.txtLjubimac.TabIndex = 15;
            // 
            // btnEvidentiraj
            // 
            this.btnEvidentiraj.BackColor = System.Drawing.Color.Tan;
            this.btnEvidentiraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvidentiraj.Location = new System.Drawing.Point(15, 429);
            this.btnEvidentiraj.Margin = new System.Windows.Forms.Padding(2);
            this.btnEvidentiraj.Location = new System.Drawing.Point(15, 429);
            this.btnEvidentiraj.Margin = new System.Windows.Forms.Padding(2);
            this.btnEvidentiraj.Name = "btnEvidentiraj";
            this.btnEvidentiraj.Size = new System.Drawing.Size(426, 27);
            this.btnEvidentiraj.TabIndex = 17;
            this.btnEvidentiraj.Text = "Evidentiraj novu posjetu";
            this.btnEvidentiraj.UseVisualStyleBackColor = false;
            this.btnEvidentiraj.Click += new System.EventHandler(this.btnEvidentiraj_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Tan;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBack.Location = new System.Drawing.Point(9, 10);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBack.Location = new System.Drawing.Point(9, 10);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(22, 30);
            this.btnBack.Size = new System.Drawing.Size(34, 22);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "←";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dtpPosjeta
            // 
            this.dtpPosjeta.Location = new System.Drawing.Point(261, 120);
            this.dtpPosjeta.Margin = new System.Windows.Forms.Padding(2);
            this.dtpPosjeta.Name = "dtpPosjeta";
            this.dtpPosjeta.Size = new System.Drawing.Size(184, 20);
            this.dtpPosjeta.TabIndex = 19;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(261, 218);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(2);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(184, 20);
            this.txtNaziv.TabIndex = 20;
            // 
            // lblNazivBolesti
            // 
            this.lblNazivBolesti.AutoSize = true;
            this.lblNazivBolesti.Location = new System.Drawing.Point(194, 223);
            this.lblNazivBolesti.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNazivBolesti.Name = "lblNazivBolesti";
            this.lblNazivBolesti.Size = new System.Drawing.Size(67, 13);
            this.lblNazivBolesti.TabIndex = 21;
            this.lblNazivBolesti.Text = "Naziv bolesti";
            // 
            // rtxtOpisBolesti
            // 
            this.rtxtOpisBolesti.Location = new System.Drawing.Point(261, 241);
            this.rtxtOpisBolesti.Margin = new System.Windows.Forms.Padding(2);
            this.rtxtOpisBolesti.Name = "rtxtOpisBolesti";
            this.rtxtOpisBolesti.Size = new System.Drawing.Size(184, 51);
            this.rtxtOpisBolesti.TabIndex = 22;
            this.rtxtOpisBolesti.Text = "";
            // 
            // lblOpisBolesti
            // 
            this.lblOpisBolesti.AutoSize = true;
            this.lblOpisBolesti.Location = new System.Drawing.Point(198, 279);
            this.lblOpisBolesti.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOpisBolesti.Name = "lblOpisBolesti";
            this.lblOpisBolesti.Size = new System.Drawing.Size(61, 13);
            this.lblOpisBolesti.TabIndex = 23;
            this.lblOpisBolesti.Text = "Opis bolesti";
            // 
            // dtpDatumBolesti
            // 
            this.dtpDatumBolesti.Location = new System.Drawing.Point(261, 301);
            this.dtpDatumBolesti.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDatumBolesti.Name = "dtpDatumBolesti";
            this.dtpDatumBolesti.Size = new System.Drawing.Size(184, 20);
            this.dtpDatumBolesti.TabIndex = 24;
            // 
            // lblDatumBolesti
            // 
            this.lblDatumBolesti.AutoSize = true;
            this.lblDatumBolesti.Location = new System.Drawing.Point(167, 306);
            this.lblDatumBolesti.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatumBolesti.Name = "lblDatumBolesti";
            this.lblDatumBolesti.Size = new System.Drawing.Size(94, 13);
            this.lblDatumBolesti.TabIndex = 25;
            this.lblDatumBolesti.Text = "Početak simptoma";
            // 
            // cbSpremi
            // 
            this.cbSpremi.AutoSize = true;
            this.cbSpremi.Location = new System.Drawing.Point(355, 195);
            this.cbSpremi.Margin = new System.Windows.Forms.Padding(2);
            this.cbSpremi.Name = "cbSpremi";
            this.cbSpremi.Size = new System.Drawing.Size(95, 17);
            this.cbSpremi.TabIndex = 26;
            this.cbSpremi.Text = "Spremi posjetu";
            this.cbSpremi.UseVisualStyleBackColor = true;
            this.cbSpremi.Click += new System.EventHandler(this.cbSpremi_Click);
            // 
            // txtNazivLijeka
            // 
            this.txtNazivLijeka.Location = new System.Drawing.Point(261, 330);
            this.txtNazivLijeka.Margin = new System.Windows.Forms.Padding(2);
            this.txtNazivLijeka.Name = "txtNazivLijeka";
            this.txtNazivLijeka.Size = new System.Drawing.Size(184, 20);
            this.txtNazivLijeka.TabIndex = 27;
            // 
            // lblNazivLijeka
            // 
            this.lblNazivLijeka.AutoSize = true;
            this.lblNazivLijeka.Location = new System.Drawing.Point(200, 336);
            this.lblNazivLijeka.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNazivLijeka.Name = "lblNazivLijeka";
            this.lblNazivLijeka.Size = new System.Drawing.Size(61, 13);
            this.lblNazivLijeka.TabIndex = 28;
            this.lblNazivLijeka.Text = "Naziv lijeka";
            // 
            // lblOpisLijeka
            // 
            this.lblOpisLijeka.AutoSize = true;
            this.lblOpisLijeka.Location = new System.Drawing.Point(204, 397);
            this.lblOpisLijeka.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOpisLijeka.Name = "lblOpisLijeka";
            this.lblOpisLijeka.Size = new System.Drawing.Size(55, 13);
            this.lblOpisLijeka.TabIndex = 30;
            this.lblOpisLijeka.Text = "Opis lijeka";
            // 
            // rtxtOpisLijeka
            // 
            this.rtxtOpisLijeka.Location = new System.Drawing.Point(261, 360);
            this.rtxtOpisLijeka.Margin = new System.Windows.Forms.Padding(2);
            this.rtxtOpisLijeka.Name = "rtxtOpisLijeka";
            this.rtxtOpisLijeka.Size = new System.Drawing.Size(184, 51);
            this.rtxtOpisLijeka.TabIndex = 31;
            this.rtxtOpisLijeka.Text = "";
            // 
            // cmbPosjete
            // 
            this.cmbPosjete.FormattingEnabled = true;
            this.cmbPosjete.Location = new System.Drawing.Point(261, 89);
            this.cmbPosjete.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPosjete.Name = "cmbPosjete";
            this.cmbPosjete.Size = new System.Drawing.Size(184, 21);
            this.cmbPosjete.TabIndex = 32;
            this.cmbPosjete.DropDownClosed += new System.EventHandler(this.cmbPosjete_DropDownClosed);
            // 
            // btnNadopuniPostojecu
            // 
            this.btnNadopuniPostojecu.BackColor = System.Drawing.Color.Tan;
            this.btnNadopuniPostojecu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNadopuniPostojecu.Location = new System.Drawing.Point(15, 461);
            this.btnNadopuniPostojecu.Margin = new System.Windows.Forms.Padding(2);
            this.btnNadopuniPostojecu.Location = new System.Drawing.Point(15, 461);
            this.btnNadopuniPostojecu.Margin = new System.Windows.Forms.Padding(2);
            this.btnNadopuniPostojecu.Name = "btnNadopuniPostojecu";
            this.btnNadopuniPostojecu.Size = new System.Drawing.Size(426, 27);
            this.btnNadopuniPostojecu.TabIndex = 33;
            this.btnNadopuniPostojecu.Text = "Nadopuni postojeću posjetu";
            this.btnNadopuniPostojecu.UseVisualStyleBackColor = false;
            this.btnNadopuniPostojecu.Click += new System.EventHandler(this.btnNadopuniPostojecu_Click);
            // 
            // btnPonisti
            // 
            this.btnPonisti.Location = new System.Drawing.Point(364, 65);
            this.btnPonisti.Margin = new System.Windows.Forms.Padding(2);
            this.btnPonisti.Name = "btnPonisti";
            this.btnPonisti.Size = new System.Drawing.Size(80, 19);
            this.btnPonisti.TabIndex = 34;
            this.btnPonisti.Text = "Poništi odabir";
            this.btnPonisti.UseVisualStyleBackColor = true;
            this.btnPonisti.Click += new System.EventHandler(this.btnPonisti_Click);
            // 
            // lblUnesi
            // 
            this.lblUnesi.AutoSize = true;
            this.lblUnesi.Location = new System.Drawing.Point(216, 196);
            this.lblUnesi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnesi.Name = "lblUnesi";
            this.lblUnesi.Size = new System.Drawing.Size(242, 13);
            this.lblUnesi.TabIndex = 35;
            this.lblUnesi.Text = "Možete unijeti bolesti i lijekove za postojeći termin!";
            // 
            // FrmEvidentiraj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(463, 502);
            this.ClientSize = new System.Drawing.Size(463, 502);
            this.Controls.Add(this.lblUnesi);
            this.Controls.Add(this.btnPonisti);
            this.Controls.Add(this.btnNadopuniPostojecu);
            this.Controls.Add(this.cmbPosjete);
            this.Controls.Add(this.rtxtOpisLijeka);
            this.Controls.Add(this.lblOpisLijeka);
            this.Controls.Add(this.lblNazivLijeka);
            this.Controls.Add(this.txtNazivLijeka);
            this.Controls.Add(this.cbSpremi);
            this.Controls.Add(this.lblDatumBolesti);
            this.Controls.Add(this.dtpDatumBolesti);
            this.Controls.Add(this.lblOpisBolesti);
            this.Controls.Add(this.rtxtOpisBolesti);
            this.Controls.Add(this.lblNazivBolesti);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.dtpPosjeta);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnEvidentiraj);
            this.Controls.Add(this.txtLjubimac);
            this.Controls.Add(this.txtKorisnikVeterinar);
            this.Controls.Add(this.rtxtRazlogPosjete);
            this.Controls.Add(this.lblRazlogPosjete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBiljeske);
            this.Controls.Add(this.rtxtBiljeske);
            this.Controls.Add(this.txtBrojKartona);
            this.Controls.Add(this.lblBrojKartona);
            this.Controls.Add(this.cmbLjubimci);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmEvidentiraj";
            this.Text = "Evidentiraj";
            this.Load += new System.EventHandler(this.FrmEvidentiraj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLjubimci;
        private System.Windows.Forms.Label lblBrojKartona;
        private System.Windows.Forms.TextBox txtBrojKartona;
        private System.Windows.Forms.RichTextBox rtxtBiljeske;
        private System.Windows.Forms.Label lblBiljeske;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRazlogPosjete;
        private System.Windows.Forms.RichTextBox rtxtRazlogPosjete;
        private System.Windows.Forms.TextBox txtKorisnikVeterinar;
        private System.Windows.Forms.TextBox txtLjubimac;
        private System.Windows.Forms.Button btnEvidentiraj;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DateTimePicker dtpPosjeta;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblNazivBolesti;
        private System.Windows.Forms.RichTextBox rtxtOpisBolesti;
        private System.Windows.Forms.Label lblOpisBolesti;
        private System.Windows.Forms.DateTimePicker dtpDatumBolesti;
        private System.Windows.Forms.Label lblDatumBolesti;
        private System.Windows.Forms.CheckBox cbSpremi;
        private System.Windows.Forms.TextBox txtNazivLijeka;
        private System.Windows.Forms.Label lblNazivLijeka;
        private System.Windows.Forms.Label lblOpisLijeka;
        private System.Windows.Forms.RichTextBox rtxtOpisLijeka;
        private System.Windows.Forms.ComboBox cmbPosjete;
        private System.Windows.Forms.Button btnNadopuniPostojecu;
        private System.Windows.Forms.Button btnPonisti;
        private System.Windows.Forms.Label lblUnesi;
    }
}