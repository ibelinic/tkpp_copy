namespace PetVet.Forms
{
    partial class FrmProsliTermini
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProsliTermini));
            this.dgvPastAppointments = new System.Windows.Forms.DataGridView();
            this.lblTermini = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPastAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPastAppointments
            // 
            this.dgvPastAppointments.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgvPastAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPastAppointments.Location = new System.Drawing.Point(44, 10);
            this.dgvPastAppointments.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPastAppointments.Name = "dgvPastAppointments";
            this.dgvPastAppointments.RowHeadersWidth = 51;
            this.dgvPastAppointments.RowTemplate.Height = 24;
            this.dgvPastAppointments.Size = new System.Drawing.Size(538, 202);
            this.dgvPastAppointments.TabIndex = 0;
            // 
            // lblTermini
            // 
            this.lblTermini.AutoSize = true;
            this.lblTermini.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTermini.Location = new System.Drawing.Point(213, 221);
            this.lblTermini.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTermini.Name = "lblTermini";
            this.lblTermini.Size = new System.Drawing.Size(210, 15);
            this.lblTermini.TabIndex = 1;
            this.lblTermini.Text = "Ovdje su prikazani Vaši prošli termini!";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Tan;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(9, 10);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(30, 25);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "←";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmProsliTermini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(600, 245);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTermini);
            this.Controls.Add(this.dgvPastAppointments);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmProsliTermini";
            this.Text = "FrmProsliTermini";
            this.Load += new System.EventHandler(this.FrmProsliTermini_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPastAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPastAppointments;
        private System.Windows.Forms.Label lblTermini;
        private System.Windows.Forms.Button btnBack;
    }
}