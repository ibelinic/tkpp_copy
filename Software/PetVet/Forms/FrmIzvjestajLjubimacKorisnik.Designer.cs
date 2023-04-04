namespace PetVet.Forms
{
    partial class FrmIzvjestajLjubimacKorisnik
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIzvjestajLjubimacKorisnik));
            this.ljubimacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.posjetaLjubimcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.preboljeleBolestiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lijekoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rvLjubimac = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ljubimacBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posjetaLjubimcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preboljeleBolestiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ljubimacBindingSource
            // 
            this.ljubimacBindingSource.DataSource = typeof(EntitiesLayer.Ljubimac);
            // 
            // posjetaLjubimcaBindingSource
            // 
            this.posjetaLjubimcaBindingSource.DataSource = typeof(EntitiesLayer.PosjetaLjubimca);
            // 
            // preboljeleBolestiBindingSource
            // 
            this.preboljeleBolestiBindingSource.DataSource = typeof(EntitiesLayer.PreboljeleBolesti);
            // 
            // lijekoviBindingSource
            // 
            this.lijekoviBindingSource.DataSource = typeof(EntitiesLayer.Lijekovi);
            // 
            // rvLjubimac
            // 
            this.rvLjubimac.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DsLjubimac";
            reportDataSource1.Value = this.ljubimacBindingSource;
            reportDataSource2.Name = "DsPosjeta";
            reportDataSource2.Value = this.posjetaLjubimcaBindingSource;
            reportDataSource3.Name = "DsPreboljeleBolesti";
            reportDataSource3.Value = this.preboljeleBolestiBindingSource;
            reportDataSource4.Name = "DsLijekovi";
            reportDataSource4.Value = this.lijekoviBindingSource;
            this.rvLjubimac.LocalReport.DataSources.Add(reportDataSource1);
            this.rvLjubimac.LocalReport.DataSources.Add(reportDataSource2);
            this.rvLjubimac.LocalReport.DataSources.Add(reportDataSource3);
            this.rvLjubimac.LocalReport.DataSources.Add(reportDataSource4);
            this.rvLjubimac.LocalReport.ReportEmbeddedResource = "PetVet.Forms.ReportLjubimac.rdlc";
            this.rvLjubimac.Location = new System.Drawing.Point(0, 0);
            this.rvLjubimac.Name = "rvLjubimac";
            this.rvLjubimac.ServerReport.BearerToken = null;
            this.rvLjubimac.Size = new System.Drawing.Size(655, 450);
            this.rvLjubimac.TabIndex = 0;
            // 
            // FrmIzvjestajLjubimacKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.rvLjubimac);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmIzvjestajLjubimacKorisnik";
            this.Text = "Vlasnik-Izvještaj ljubimca";
            this.Load += new System.EventHandler(this.FrmIzvjestajLjubimac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ljubimacBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posjetaLjubimcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preboljeleBolestiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvLjubimac;
        private System.Windows.Forms.BindingSource posjetaLjubimcaBindingSource;
        private System.Windows.Forms.BindingSource ljubimacBindingSource;
        private System.Windows.Forms.BindingSource preboljeleBolestiBindingSource;
        private System.Windows.Forms.BindingSource lijekoviBindingSource;
    }
}