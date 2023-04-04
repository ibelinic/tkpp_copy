namespace PetVet.Forms
{
    partial class FrmRaspored
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRaspored));
            this.dgvRaspored = new System.Windows.Forms.DataGridView();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnAžuriraj = new System.Windows.Forms.Button();
            this.btnNazad = new System.Windows.Forms.Button();
            this.btnPastAppointment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaspored)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRaspored
            // 
            this.dgvRaspored.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgvRaspored.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaspored.Location = new System.Drawing.Point(20, 59);
            this.dgvRaspored.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRaspored.Name = "dgvRaspored";
            this.dgvRaspored.RowHeadersWidth = 51;
            this.dgvRaspored.RowTemplate.Height = 24;
            this.dgvRaspored.Size = new System.Drawing.Size(560, 221);
            this.dgvRaspored.TabIndex = 0;
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.BackColor = System.Drawing.Color.Tan;
            this.btnIzbrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzbrisi.Location = new System.Drawing.Point(508, 296);
            this.btnIzbrisi.Margin = new System.Windows.Forms.Padding(2);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(72, 46);
            this.btnIzbrisi.TabIndex = 1;
            this.btnIzbrisi.Text = "Izbriši sa rasporeda";
            this.btnIzbrisi.UseVisualStyleBackColor = false;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.Tan;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.Location = new System.Drawing.Point(334, 296);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(70, 46);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj na raspored";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnAžuriraj
            // 
            this.btnAžuriraj.BackColor = System.Drawing.Color.Tan;
            this.btnAžuriraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAžuriraj.Location = new System.Drawing.Point(428, 296);
            this.btnAžuriraj.Margin = new System.Windows.Forms.Padding(2);
            this.btnAžuriraj.Name = "btnAžuriraj";
            this.btnAžuriraj.Size = new System.Drawing.Size(68, 46);
            this.btnAžuriraj.TabIndex = 3;
            this.btnAžuriraj.Text = "Ažuriraj termin";
            this.btnAžuriraj.UseVisualStyleBackColor = false;
            this.btnAžuriraj.Click += new System.EventHandler(this.btnAžuriraj_Click);
            // 
            // btnNazad
            // 
            this.btnNazad.BackColor = System.Drawing.Color.Tan;
            this.btnNazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNazad.Location = new System.Drawing.Point(20, 10);
            this.btnNazad.Margin = new System.Windows.Forms.Padding(2);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(59, 22);
            this.btnNazad.TabIndex = 4;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = false;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // btnPastAppointment
            // 
            this.btnPastAppointment.BackColor = System.Drawing.Color.Tan;
            this.btnPastAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPastAppointment.Location = new System.Drawing.Point(224, 296);
            this.btnPastAppointment.Margin = new System.Windows.Forms.Padding(2);
            this.btnPastAppointment.Name = "btnPastAppointment";
            this.btnPastAppointment.Size = new System.Drawing.Size(87, 46);
            this.btnPastAppointment.TabIndex = 5;
            this.btnPastAppointment.Text = "Pogledaj prošle termine";
            this.btnPastAppointment.UseVisualStyleBackColor = false;
            this.btnPastAppointment.Click += new System.EventHandler(this.btnPastAppointment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Raspored";
            // 
            // FrmRaspored
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(606, 363);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPastAppointment);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.btnAžuriraj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.dgvRaspored);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmRaspored";
            this.Text = "Raspored";
            this.Load += new System.EventHandler(this.FrmRaspored_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaspored)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRaspored;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnAžuriraj;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Button btnPastAppointment;
        private System.Windows.Forms.Label label1;
    }
}