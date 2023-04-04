namespace PetVet.Forms
{
    partial class FrmPronadiKorisnika
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLjubimac = new System.Windows.Forms.TextBox();
            this.dgvPrikazKorisnika = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazKorisnika)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(139, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ljubimac:";
            // 
            // txtLjubimac
            // 
            this.txtLjubimac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLjubimac.Location = new System.Drawing.Point(213, 49);
            this.txtLjubimac.Name = "txtLjubimac";
            this.txtLjubimac.Size = new System.Drawing.Size(121, 22);
            this.txtLjubimac.TabIndex = 1;
            this.txtLjubimac.TextChanged += new System.EventHandler(this.txtLjubimac_TextChanged);
            // 
            // dgvPrikazKorisnika
            // 
            this.dgvPrikazKorisnika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrikazKorisnika.Location = new System.Drawing.Point(28, 96);
            this.dgvPrikazKorisnika.Name = "dgvPrikazKorisnika";
            this.dgvPrikazKorisnika.Size = new System.Drawing.Size(477, 248);
            this.dgvPrikazKorisnika.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(116, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pretraživanje ljubimaca";
            // 
            // FrmPronadiKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 375);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPrikazKorisnika);
            this.Controls.Add(this.txtLjubimac);
            this.Controls.Add(this.label1);
            this.Name = "FrmPronadiKorisnika";
            this.Text = "FrmPronadiKorisnika";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazKorisnika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLjubimac;
        private System.Windows.Forms.DataGridView dgvPrikazKorisnika;
        private System.Windows.Forms.Label label2;
    }
}