namespace PetVet.Forms
{
    partial class FrmPocetnaVeterinar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPocetnaVeterinar));
            this.btnRaspored = new System.Windows.Forms.Button();
            this.btnIzradiKarton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRadnoMjesto = new System.Windows.Forms.ComboBox();
            this.btnRadnoMjesto = new System.Windows.Forms.Button();
            this.btnEvidentiraj = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRadnoMjesto = new System.Windows.Forms.TextBox();
            this.btnIzvjestaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRaspored
            // 
            this.btnRaspored.BackColor = System.Drawing.Color.Tan;
            this.btnRaspored.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaspored.Location = new System.Drawing.Point(31, 54);
            this.btnRaspored.Margin = new System.Windows.Forms.Padding(2);
            this.btnRaspored.Location = new System.Drawing.Point(31, 54);
            this.btnRaspored.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRaspored.Name = "btnRaspored";
            this.btnRaspored.Size = new System.Drawing.Size(84, 36);
            this.btnRaspored.TabIndex = 0;
            this.btnRaspored.Text = "Moj raspored";
            this.btnRaspored.UseVisualStyleBackColor = false;
            this.btnRaspored.Click += new System.EventHandler(this.btnRaspored_Click);
            // 
            // btnIzradiKarton
            // 
            this.btnIzradiKarton.BackColor = System.Drawing.Color.Tan;
            this.btnIzradiKarton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzradiKarton.Location = new System.Drawing.Point(31, 110);
            this.btnIzradiKarton.Margin = new System.Windows.Forms.Padding(2);
            this.btnIzradiKarton.Location = new System.Drawing.Point(31, 110);
            this.btnIzradiKarton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIzradiKarton.Name = "btnIzradiKarton";
            this.btnIzradiKarton.Size = new System.Drawing.Size(84, 37);
            this.btnIzradiKarton.TabIndex = 1;
            this.btnIzradiKarton.Text = "Izradi karton";
            this.btnIzradiKarton.UseVisualStyleBackColor = false;
            this.btnIzradiKarton.UseVisualStyleBackColor = true;
            this.btnIzradiKarton.Click += new System.EventHandler(this.btnIzradiKarton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(437, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Moji podaci";
            // 
            // cmbRadnoMjesto
            // 
            this.cmbRadnoMjesto.FormattingEnabled = true;
            this.cmbRadnoMjesto.Location = new System.Drawing.Point(367, 211);
            this.cmbRadnoMjesto.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRadnoMjesto.Location = new System.Drawing.Point(369, 211);
            this.cmbRadnoMjesto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbRadnoMjesto.Name = "cmbRadnoMjesto";
            this.cmbRadnoMjesto.Size = new System.Drawing.Size(202, 21);
            this.cmbRadnoMjesto.TabIndex = 3;
            // 
            // btnRadnoMjesto
            // 
            this.btnRadnoMjesto.BackColor = System.Drawing.Color.Tan;
            this.btnRadnoMjesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRadnoMjesto.Location = new System.Drawing.Point(252, 203);
            this.btnRadnoMjesto.Margin = new System.Windows.Forms.Padding(2);
            this.btnRadnoMjesto.Location = new System.Drawing.Point(290, 203);
            this.btnRadnoMjesto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRadnoMjesto.Name = "btnRadnoMjesto";
            this.btnRadnoMjesto.Size = new System.Drawing.Size(100, 38);
            this.btnRadnoMjesto.Size = new System.Drawing.Size(75, 35);
            this.btnRadnoMjesto.TabIndex = 4;
            this.btnRadnoMjesto.Text = "Ažuriraj radno mjesto";
            this.btnRadnoMjesto.UseVisualStyleBackColor = false;
            this.btnRadnoMjesto.Click += new System.EventHandler(this.btnRadnoMjesto_Click);
            // 
            // btnEvidentiraj
            // 
            this.btnEvidentiraj.BackColor = System.Drawing.Color.Tan;
            this.btnEvidentiraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvidentiraj.Location = new System.Drawing.Point(31, 168);
            this.btnEvidentiraj.Margin = new System.Windows.Forms.Padding(2);
            this.btnEvidentiraj.Location = new System.Drawing.Point(31, 168);
            this.btnEvidentiraj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEvidentiraj.Name = "btnEvidentiraj";
            this.btnEvidentiraj.Size = new System.Drawing.Size(84, 32);
            this.btnEvidentiraj.TabIndex = 5;
            this.btnEvidentiraj.Text = "Evidentiraj";
            this.btnEvidentiraj.UseVisualStyleBackColor = false;
            this.btnEvidentiraj.Click += new System.EventHandler(this.btnEvidentiraj_Click);
            // 
            // btnOdjava
            // 
            this.btnOdjava.BackColor = System.Drawing.Color.Tan;
            this.btnOdjava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdjava.Location = new System.Drawing.Point(494, 317);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(75, 23);
            this.btnOdjava.TabIndex = 6;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = false;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Trenutno radno mjesto:";
            // 
            // txtRadnoMjesto
            // 
            this.txtRadnoMjesto.BackColor = System.Drawing.Color.SeaShell;
            this.txtRadnoMjesto.Location = new System.Drawing.Point(367, 51);
            this.txtRadnoMjesto.Name = "txtRadnoMjesto";
            this.txtRadnoMjesto.ReadOnly = true;
            this.txtRadnoMjesto.Size = new System.Drawing.Size(202, 20);
            this.txtRadnoMjesto.TabIndex = 8;
            // 
            // btnIzvjestaj
            // 
            this.btnIzvjestaj.BackColor = System.Drawing.Color.Tan;
            this.btnIzvjestaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzvjestaj.Location = new System.Drawing.Point(31, 226);
            this.btnIzvjestaj.Margin = new System.Windows.Forms.Padding(2);
            this.btnIzvjestaj.Name = "btnIzvjestaj";
            this.btnIzvjestaj.Size = new System.Drawing.Size(84, 37);
            this.btnIzvjestaj.TabIndex = 9;
            this.btnIzvjestaj.Text = "Izvještaj";
            this.btnIzvjestaj.UseVisualStyleBackColor = false;
            this.btnIzvjestaj.Click += new System.EventHandler(this.btnIzvjestaj_Click);
            // 
            // FrmPocetnaVeterinar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnIzvjestaj);
            this.Controls.Add(this.txtRadnoMjesto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOdjava);
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnEvidentiraj);
            this.Controls.Add(this.btnRadnoMjesto);
            this.Controls.Add(this.cmbRadnoMjesto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIzradiKarton);
            this.Controls.Add(this.btnRaspored);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmPocetnaVeterinar";
            this.Text = "Početna veterinar";
            this.Load += new System.EventHandler(this.FrmPocetnaVeterinar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRaspored;
        private System.Windows.Forms.Button btnIzradiKarton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRadnoMjesto;
        private System.Windows.Forms.Button btnRadnoMjesto;
        private System.Windows.Forms.Button btnEvidentiraj;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRadnoMjesto;
        private System.Windows.Forms.Button btnIzvjestaj;
    }
}