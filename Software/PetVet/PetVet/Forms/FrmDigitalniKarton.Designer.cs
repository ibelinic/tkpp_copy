namespace PetVet.Forms
{
    partial class FrmDigitalniKarton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDigitalniKarton));
            this.lblDigitalniKarton = new System.Windows.Forms.Label();
            this.lblBrojKartona = new System.Windows.Forms.Label();
            this.lblBiljeske = new System.Windows.Forms.Label();
            this.richtxtBiljeske = new System.Windows.Forms.RichTextBox();
            this.txtBrojKartona = new System.Windows.Forms.TextBox();
            this.dgvPosjeta = new System.Windows.Forms.DataGridView();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.lblLijekovi = new System.Windows.Forms.Label();
            this.lblPosjeta = new System.Windows.Forms.Label();
            this.dgvLijekovi = new System.Windows.Forms.DataGridView();
            this.dgvBolesti = new System.Windows.Forms.DataGridView();
            this.lblBolesti = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnIzvjestaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosjeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLijekovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBolesti)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDigitalniKarton
            // 
            this.lblDigitalniKarton.AutoSize = true;
            this.lblDigitalniKarton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblDigitalniKarton.Location = new System.Drawing.Point(110, 15);
            this.lblDigitalniKarton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDigitalniKarton.Name = "lblDigitalniKarton";
            this.lblDigitalniKarton.Size = new System.Drawing.Size(105, 18);
            this.lblDigitalniKarton.TabIndex = 0;
            this.lblDigitalniKarton.Text = "Digitalni karton";
            // 
            // lblBrojKartona
            // 
            this.lblBrojKartona.AutoSize = true;
            this.lblBrojKartona.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblBrojKartona.Location = new System.Drawing.Point(43, 58);
            this.lblBrojKartona.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBrojKartona.Name = "lblBrojKartona";
            this.lblBrojKartona.Size = new System.Drawing.Size(64, 13);
            this.lblBrojKartona.TabIndex = 1;
            this.lblBrojKartona.Text = "Broj kartona";
            // 
            // lblBiljeske
            // 
            this.lblBiljeske.AutoSize = true;
            this.lblBiljeske.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblBiljeske.Location = new System.Drawing.Point(64, 114);
            this.lblBiljeske.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBiljeske.Name = "lblBiljeske";
            this.lblBiljeske.Size = new System.Drawing.Size(43, 13);
            this.lblBiljeske.TabIndex = 2;
            this.lblBiljeske.Text = "Bilješke";
            // 
            // richtxtBiljeske
            // 
            this.richtxtBiljeske.Location = new System.Drawing.Point(112, 84);
            this.richtxtBiljeske.Margin = new System.Windows.Forms.Padding(2);
            this.richtxtBiljeske.Name = "richtxtBiljeske";
            this.richtxtBiljeske.ReadOnly = true;
            this.richtxtBiljeske.Size = new System.Drawing.Size(364, 44);
            this.richtxtBiljeske.TabIndex = 3;
            this.richtxtBiljeske.Text = "";
            // 
            // txtBrojKartona
            // 
            this.txtBrojKartona.Location = new System.Drawing.Point(112, 56);
            this.txtBrojKartona.Margin = new System.Windows.Forms.Padding(2);
            this.txtBrojKartona.Name = "txtBrojKartona";
            this.txtBrojKartona.ReadOnly = true;
            this.txtBrojKartona.Size = new System.Drawing.Size(116, 20);
            this.txtBrojKartona.TabIndex = 4;
            // 
            // dgvPosjeta
            // 
            this.dgvPosjeta.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgvPosjeta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosjeta.Location = new System.Drawing.Point(112, 145);
            this.dgvPosjeta.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPosjeta.Name = "dgvPosjeta";
            this.dgvPosjeta.RowHeadersWidth = 51;
            this.dgvPosjeta.RowTemplate.Height = 24;
            this.dgvPosjeta.Size = new System.Drawing.Size(363, 122);
            this.dgvPosjeta.TabIndex = 6;
            this.dgvPosjeta.SelectionChanged += new System.EventHandler(this.dgvPosjeta_SelectionChanged);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(218, 16);
            this.txtIme.Margin = new System.Windows.Forms.Padding(2);
            this.txtIme.Name = "txtIme";
            this.txtIme.ReadOnly = true;
            this.txtIme.Size = new System.Drawing.Size(76, 20);
            this.txtIme.TabIndex = 9;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(298, 16);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.ReadOnly = true;
            this.txtPrezime.Size = new System.Drawing.Size(76, 20);
            this.txtPrezime.TabIndex = 10;
            // 
            // lblLijekovi
            // 
            this.lblLijekovi.AutoSize = true;
            this.lblLijekovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblLijekovi.Location = new System.Drawing.Point(65, 522);
            this.lblLijekovi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLijekovi.Name = "lblLijekovi";
            this.lblLijekovi.Size = new System.Drawing.Size(43, 13);
            this.lblLijekovi.TabIndex = 11;
            this.lblLijekovi.Text = "Lijekovi";
            // 
            // lblPosjeta
            // 
            this.lblPosjeta.AutoSize = true;
            this.lblPosjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblPosjeta.Location = new System.Drawing.Point(65, 253);
            this.lblPosjeta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPosjeta.Name = "lblPosjeta";
            this.lblPosjeta.Size = new System.Drawing.Size(42, 13);
            this.lblPosjeta.TabIndex = 12;
            this.lblPosjeta.Text = "Posjeta";
            // 
            // dgvLijekovi
            // 
            this.dgvLijekovi.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgvLijekovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLijekovi.Location = new System.Drawing.Point(112, 414);
            this.dgvLijekovi.Margin = new System.Windows.Forms.Padding(2);
            this.dgvLijekovi.Name = "dgvLijekovi";
            this.dgvLijekovi.RowHeadersWidth = 51;
            this.dgvLijekovi.RowTemplate.Height = 24;
            this.dgvLijekovi.Size = new System.Drawing.Size(363, 122);
            this.dgvLijekovi.TabIndex = 13;
            // 
            // dgvBolesti
            // 
            this.dgvBolesti.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgvBolesti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBolesti.Location = new System.Drawing.Point(112, 279);
            this.dgvBolesti.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBolesti.Name = "dgvBolesti";
            this.dgvBolesti.RowHeadersWidth = 51;
            this.dgvBolesti.RowTemplate.Height = 24;
            this.dgvBolesti.Size = new System.Drawing.Size(363, 122);
            this.dgvBolesti.TabIndex = 14;
            // 
            // lblBolesti
            // 
            this.lblBolesti.AutoSize = true;
            this.lblBolesti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblBolesti.Location = new System.Drawing.Point(20, 387);
            this.lblBolesti.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBolesti.Name = "lblBolesti";
            this.lblBolesti.Size = new System.Drawing.Size(86, 13);
            this.lblBolesti.TabIndex = 15;
            this.lblBolesti.Text = "Preboljele bolesti";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Tan;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBack.Location = new System.Drawing.Point(9, 548);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Location = new System.Drawing.Point(9, 555);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(56, 26);
            this.btnBack.Size = new System.Drawing.Size(56, 19);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "←";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnIzvjestaj
            // 
            this.btnIzvjestaj.BackColor = System.Drawing.Color.Tan;
            this.btnIzvjestaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzvjestaj.Location = new System.Drawing.Point(395, 548);
            this.btnIzvjestaj.Name = "btnIzvjestaj";
            this.btnIzvjestaj.Size = new System.Drawing.Size(75, 23);
            this.btnIzvjestaj.TabIndex = 17;
            this.btnIzvjestaj.Text = "Izvjestaj";
            this.btnIzvjestaj.UseVisualStyleBackColor = false;
            this.btnIzvjestaj.Click += new System.EventHandler(this.btnIzvjestaj_Click);
            // 
            // FrmDigitalniKarton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(506, 583);
            this.Controls.Add(this.btnIzvjestaj);
            this.ClientSize = new System.Drawing.Size(506, 583);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblBolesti);
            this.Controls.Add(this.dgvBolesti);
            this.Controls.Add(this.dgvLijekovi);
            this.Controls.Add(this.lblPosjeta);
            this.Controls.Add(this.lblLijekovi);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.dgvPosjeta);
            this.Controls.Add(this.txtBrojKartona);
            this.Controls.Add(this.richtxtBiljeske);
            this.Controls.Add(this.lblBiljeske);
            this.Controls.Add(this.lblBrojKartona);
            this.Controls.Add(this.lblDigitalniKarton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmDigitalniKarton";
            this.Text = "Digitalni Karton";
            this.Load += new System.EventHandler(this.FrmDigitalniKarton_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosjeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLijekovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBolesti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDigitalniKarton;
        private System.Windows.Forms.Label lblBrojKartona;
        private System.Windows.Forms.Label lblBiljeske;
        private System.Windows.Forms.RichTextBox richtxtBiljeske;
        private System.Windows.Forms.TextBox txtBrojKartona;
        private System.Windows.Forms.DataGridView dgvPosjeta;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label lblLijekovi;
        private System.Windows.Forms.Label lblPosjeta;
        private System.Windows.Forms.DataGridView dgvLijekovi;
        private System.Windows.Forms.DataGridView dgvBolesti;
        private System.Windows.Forms.Label lblBolesti;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnIzvjestaj;
    }
}