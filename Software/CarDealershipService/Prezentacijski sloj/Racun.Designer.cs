namespace Prezentacijski_sloj
{
    partial class Racun
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
            this.DokumentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.KorisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.uiActionMail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DokumentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KorisnikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DokumentBindingSource1
            // 
            this.DokumentBindingSource1.DataSource = typeof(Sloj_pristupa_podacima.Dokument);
            // 
            // KorisnikBindingSource
            // 
            this.KorisnikBindingSource.DataSource = typeof(Sloj_pristupa_podacima.Korisnik);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DSRacunZaSlanje";
            reportDataSource1.Value = this.DokumentBindingSource1;
            reportDataSource2.Name = "DSKorisnik";
            reportDataSource2.Value = this.KorisnikBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Prezentacijski_sloj.RacunZaSlanje.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(858, 475);
            this.reportViewer1.TabIndex = 0;
            // 
            // uiActionMail
            // 
            this.uiActionMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiActionMail.FlatAppearance.BorderSize = 0;
            this.uiActionMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionMail.Location = new System.Drawing.Point(320, 487);
            this.uiActionMail.Name = "uiActionMail";
            this.uiActionMail.Size = new System.Drawing.Size(210, 52);
            this.uiActionMail.TabIndex = 1;
            this.uiActionMail.Text = "Pošalji email";
            this.uiActionMail.UseVisualStyleBackColor = true;
            this.uiActionMail.Click += new System.EventHandler(this.uiActionMail_Click);
            // 
            // Racun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 541);
            this.Controls.Add(this.uiActionMail);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Racun";
            this.Text = "Racun";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Racun_FormClosed);
            this.Load += new System.EventHandler(this.Racun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DokumentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KorisnikBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DokumentBindingSource1;
        private System.Windows.Forms.BindingSource KorisnikBindingSource;
        private System.Windows.Forms.Button uiActionMail;
    }
}