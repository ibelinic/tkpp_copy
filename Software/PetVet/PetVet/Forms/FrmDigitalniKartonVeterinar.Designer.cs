namespace PetVet.Forms
{
    partial class FrmDigitalniKartonVeterinar
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblBolesti = new System.Windows.Forms.Label();
            this.dgvBolesti = new System.Windows.Forms.DataGridView();
            this.dgvLijekovi = new System.Windows.Forms.DataGridView();
            this.lblPosjeta = new System.Windows.Forms.Label();
            this.lblLijekovi = new System.Windows.Forms.Label();
            this.dgvPosjeta = new System.Windows.Forms.DataGridView();
            this.txtBrojKartona = new System.Windows.Forms.TextBox();
            this.richtxtBiljeske = new System.Windows.Forms.RichTextBox();
            this.lblBiljeske = new System.Windows.Forms.Label();
            this.lblBrojKartona = new System.Windows.Forms.Label();
            this.lblDigitalniKarton = new System.Windows.Forms.Label();
            this.cmbLjubimac = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEvidentirajPosjet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBolesti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLijekovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosjeta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(11, 557);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(56, 19);
            this.btnBack.TabIndex = 33;
            this.btnBack.Text = "Nazad";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // lblBolesti
            // 
            this.lblBolesti.AutoSize = true;
            this.lblBolesti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblBolesti.Location = new System.Drawing.Point(22, 389);
            this.lblBolesti.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBolesti.Name = "lblBolesti";
            this.lblBolesti.Size = new System.Drawing.Size(86, 13);
            this.lblBolesti.TabIndex = 32;
            this.lblBolesti.Text = "Preboljele bolesti";
            // 
            // dgvBolesti
            // 
            this.dgvBolesti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBolesti.Location = new System.Drawing.Point(114, 281);
            this.dgvBolesti.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBolesti.Name = "dgvBolesti";
            this.dgvBolesti.RowHeadersWidth = 51;
            this.dgvBolesti.RowTemplate.Height = 24;
            this.dgvBolesti.Size = new System.Drawing.Size(409, 122);
            this.dgvBolesti.TabIndex = 31;
            // 
            // dgvLijekovi
            // 
            this.dgvLijekovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLijekovi.Location = new System.Drawing.Point(114, 416);
            this.dgvLijekovi.Margin = new System.Windows.Forms.Padding(2);
            this.dgvLijekovi.Name = "dgvLijekovi";
            this.dgvLijekovi.RowHeadersWidth = 51;
            this.dgvLijekovi.RowTemplate.Height = 24;
            this.dgvLijekovi.Size = new System.Drawing.Size(409, 122);
            this.dgvLijekovi.TabIndex = 30;
            // 
            // lblPosjeta
            // 
            this.lblPosjeta.AutoSize = true;
            this.lblPosjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblPosjeta.Location = new System.Drawing.Point(67, 255);
            this.lblPosjeta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPosjeta.Name = "lblPosjeta";
            this.lblPosjeta.Size = new System.Drawing.Size(42, 13);
            this.lblPosjeta.TabIndex = 29;
            this.lblPosjeta.Text = "Posjeta";
            // 
            // lblLijekovi
            // 
            this.lblLijekovi.AutoSize = true;
            this.lblLijekovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblLijekovi.Location = new System.Drawing.Point(67, 524);
            this.lblLijekovi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLijekovi.Name = "lblLijekovi";
            this.lblLijekovi.Size = new System.Drawing.Size(43, 13);
            this.lblLijekovi.TabIndex = 28;
            this.lblLijekovi.Text = "Lijekovi";
            // 
            // dgvPosjeta
            // 
            this.dgvPosjeta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosjeta.Location = new System.Drawing.Point(114, 147);
            this.dgvPosjeta.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPosjeta.Name = "dgvPosjeta";
            this.dgvPosjeta.RowHeadersWidth = 51;
            this.dgvPosjeta.RowTemplate.Height = 24;
            this.dgvPosjeta.Size = new System.Drawing.Size(409, 122);
            this.dgvPosjeta.TabIndex = 25;
            this.dgvPosjeta.SelectionChanged += new System.EventHandler(this.dgvPosjeta_SelectionChanged);
            // 
            // txtBrojKartona
            // 
            this.txtBrojKartona.Location = new System.Drawing.Point(184, 50);
            this.txtBrojKartona.Margin = new System.Windows.Forms.Padding(2);
            this.txtBrojKartona.Name = "txtBrojKartona";
            this.txtBrojKartona.ReadOnly = true;
            this.txtBrojKartona.Size = new System.Drawing.Size(116, 20);
            this.txtBrojKartona.TabIndex = 24;
            // 
            // richtxtBiljeske
            // 
            this.richtxtBiljeske.Location = new System.Drawing.Point(114, 86);
            this.richtxtBiljeske.Margin = new System.Windows.Forms.Padding(2);
            this.richtxtBiljeske.Name = "richtxtBiljeske";
            this.richtxtBiljeske.ReadOnly = true;
            this.richtxtBiljeske.Size = new System.Drawing.Size(409, 44);
            this.richtxtBiljeske.TabIndex = 23;
            this.richtxtBiljeske.Text = "";
            // 
            // lblBiljeske
            // 
            this.lblBiljeske.AutoSize = true;
            this.lblBiljeske.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblBiljeske.Location = new System.Drawing.Point(66, 116);
            this.lblBiljeske.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBiljeske.Name = "lblBiljeske";
            this.lblBiljeske.Size = new System.Drawing.Size(43, 13);
            this.lblBiljeske.TabIndex = 22;
            this.lblBiljeske.Text = "Bilješke";
            // 
            // lblBrojKartona
            // 
            this.lblBrojKartona.AutoSize = true;
            this.lblBrojKartona.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblBrojKartona.Location = new System.Drawing.Point(115, 52);
            this.lblBrojKartona.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBrojKartona.Name = "lblBrojKartona";
            this.lblBrojKartona.Size = new System.Drawing.Size(64, 13);
            this.lblBrojKartona.TabIndex = 21;
            this.lblBrojKartona.Text = "Broj kartona";
            // 
            // lblDigitalniKarton
            // 
            this.lblDigitalniKarton.AutoSize = true;
            this.lblDigitalniKarton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDigitalniKarton.Location = new System.Drawing.Point(241, 9);
            this.lblDigitalniKarton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDigitalniKarton.Name = "lblDigitalniKarton";
            this.lblDigitalniKarton.Size = new System.Drawing.Size(155, 25);
            this.lblDigitalniKarton.TabIndex = 20;
            this.lblDigitalniKarton.Text = "Digitalni karton";
            // 
            // cmbLjubimac
            // 
            this.cmbLjubimac.FormattingEnabled = true;
            this.cmbLjubimac.Location = new System.Drawing.Point(379, 49);
            this.cmbLjubimac.Name = "cmbLjubimac";
            this.cmbLjubimac.Size = new System.Drawing.Size(116, 21);
            this.cmbLjubimac.TabIndex = 37;
            this.cmbLjubimac.SelectedIndexChanged += new System.EventHandler(this.cmbLjubimac_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Ljubimac:";
            // 
            // btnEvidentirajPosjet
            // 
            this.btnEvidentirajPosjet.Location = new System.Drawing.Point(246, 553);
            this.btnEvidentirajPosjet.Name = "btnEvidentirajPosjet";
            this.btnEvidentirajPosjet.Size = new System.Drawing.Size(139, 27);
            this.btnEvidentirajPosjet.TabIndex = 39;
            this.btnEvidentirajPosjet.Text = "Evidentiraj posjet";
            this.btnEvidentirajPosjet.UseVisualStyleBackColor = true;
            this.btnEvidentirajPosjet.Click += new System.EventHandler(this.btnEvidentirajPosjet_Click);
            // 
            // FrmDigitalniKartonVeterinar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 592);
            this.Controls.Add(this.btnEvidentirajPosjet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbLjubimac);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblBolesti);
            this.Controls.Add(this.dgvBolesti);
            this.Controls.Add(this.dgvLijekovi);
            this.Controls.Add(this.lblPosjeta);
            this.Controls.Add(this.lblLijekovi);
            this.Controls.Add(this.dgvPosjeta);
            this.Controls.Add(this.txtBrojKartona);
            this.Controls.Add(this.richtxtBiljeske);
            this.Controls.Add(this.lblBiljeske);
            this.Controls.Add(this.lblBrojKartona);
            this.Controls.Add(this.lblDigitalniKarton);
            this.Name = "FrmDigitalniKartonVeterinar";
            this.Text = "FrmDigitalniKartonVeterinar";
            this.Load += new System.EventHandler(this.FrmDigitalniKartonVeterinar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBolesti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLijekovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosjeta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblBolesti;
        private System.Windows.Forms.DataGridView dgvBolesti;
        private System.Windows.Forms.DataGridView dgvLijekovi;
        private System.Windows.Forms.Label lblPosjeta;
        private System.Windows.Forms.Label lblLijekovi;
        private System.Windows.Forms.DataGridView dgvPosjeta;
        private System.Windows.Forms.TextBox txtBrojKartona;
        private System.Windows.Forms.RichTextBox richtxtBiljeske;
        private System.Windows.Forms.Label lblBiljeske;
        private System.Windows.Forms.Label lblBrojKartona;
        private System.Windows.Forms.Label lblDigitalniKarton;
        private System.Windows.Forms.ComboBox cmbLjubimac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEvidentirajPosjet;
    }
}