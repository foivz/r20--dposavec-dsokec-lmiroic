namespace Prezentacijski_sloj
{
    partial class FormIzvjesca
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.DokumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KorisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.uiGrafikon = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.DokumentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KorisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGrafikon)).BeginInit();
            this.SuspendLayout();
            // 
            // DokumentBindingSource
            // 
            this.DokumentBindingSource.DataSource = typeof(Sloj_pristupa_podacima.Dokument);
            // 
            // KorisnikBindingSource
            // 
            this.KorisnikBindingSource.DataSource = typeof(Sloj_pristupa_podacima.Korisnik);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DsRacun";
            reportDataSource1.Value = this.DokumentBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Prezentacijski_sloj.ReportRacun.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 61);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(636, 253);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Popis računa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Popis zaposlenika";
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "DsZaposlenici";
            reportDataSource2.Value = this.KorisnikBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Prezentacijski_sloj.ReportZaposlenici.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(12, 383);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(636, 277);
            this.reportViewer2.TabIndex = 2;
            // 
            // uiGrafikon
            // 
            chartArea1.Name = "ChartArea1";
            this.uiGrafikon.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.uiGrafikon.Legends.Add(legend1);
            this.uiGrafikon.Location = new System.Drawing.Point(692, 202);
            this.uiGrafikon.Name = "uiGrafikon";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.uiGrafikon.Series.Add(series1);
            this.uiGrafikon.Size = new System.Drawing.Size(666, 278);
            this.uiGrafikon.TabIndex = 3;
            this.uiGrafikon.Text = "Grafikon";
            // 
            // FormIzvjesca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 672);
            this.Controls.Add(this.uiGrafikon);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormIzvjesca";
            this.Text = "Izvješća";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormIzdajDokumente_FormClosed);
            this.Load += new System.EventHandler(this.FormIzvjesca_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FormIzvjesca_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.DokumentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KorisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGrafikon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DokumentBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource KorisnikBindingSource;
        private System.Windows.Forms.DataVisualization.Charting.Chart uiGrafikon;
    }
}