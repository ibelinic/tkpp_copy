namespace PetVet.Forms
{
    partial class FrmAzurirajRaspored
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAzurirajRaspored));
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.dtpZavrsetak = new System.Windows.Forms.DateTimePicker();
            this.dtpPocetak = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.Tan;
            this.btnOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdustani.Location = new System.Drawing.Point(135, 241);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(61, 28);
            this.btnOdustani.TabIndex = 19;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.BackColor = System.Drawing.Color.Tan;
            this.btnAzuriraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAzuriraj.Location = new System.Drawing.Point(46, 241);
            this.btnAzuriraj.Margin = new System.Windows.Forms.Padding(2);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(59, 28);
            this.btnAzuriraj.TabIndex = 18;
            this.btnAzuriraj.Text = "Ažuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = false;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // dtpZavrsetak
            // 
            this.dtpZavrsetak.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.dtpZavrsetak.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpZavrsetak.Location = new System.Drawing.Point(46, 146);
            this.dtpZavrsetak.Margin = new System.Windows.Forms.Padding(2);
            this.dtpZavrsetak.Name = "dtpZavrsetak";
            this.dtpZavrsetak.Size = new System.Drawing.Size(151, 20);
            this.dtpZavrsetak.TabIndex = 17;
            // 
            // dtpPocetak
            // 
            this.dtpPocetak.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.dtpPocetak.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPocetak.Location = new System.Drawing.Point(46, 93);
            this.dtpPocetak.Margin = new System.Windows.Forms.Padding(2);
            this.dtpPocetak.Name = "dtpPocetak";
            this.dtpPocetak.Size = new System.Drawing.Size(151, 20);
            this.dtpPocetak.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Završetak";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Početak";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(46, 197);
            this.txtOpis.Margin = new System.Windows.Forms.Padding(2);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(151, 20);
            this.txtOpis.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Opis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Datum";
            // 
            // dtpDatum
            // 
            this.dtpDatum.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatum.Location = new System.Drawing.Point(46, 42);
            this.dtpDatum.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(151, 20);
            this.dtpDatum.TabIndex = 10;
            // 
            // FrmAzurirajRaspored
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(240, 309);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnAzuriraj);
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
            this.Name = "FrmAzurirajRaspored";
            this.Text = "Ažuriraj raspored";
            this.Load += new System.EventHandler(this.FrmAzurirajRaspored_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.DateTimePicker dtpZavrsetak;
        private System.Windows.Forms.DateTimePicker dtpPocetak;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDatum;
    }
}