using Microsoft.Reporting.WinForms;
using Sloj_poslovne_logike;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prezentacijski_sloj
{
    public partial class Racun : Form
    {
        public FormProdajaArtikla FormProdajaArtikla;
        public Sloj_pristupa_podacima.Dokument prosljedeniDokument;
        public Sloj_pristupa_podacima.Korisnik prosljedeniKorisnik;
        private static Racun _instance;
        public static Racun instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Racun();
                }
                return _instance;
            }
        }
        public Racun()
        {
            InitializeComponent();
        }

        private void Racun_Load(object sender, EventArgs e)
        {
            DokumentBindingSource1.DataSource = null;
            DokumentBindingSource1.DataSource = prosljedeniDokument;
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Zaposlenik", Sesija.PrijavljenKorisnik.ime_korisnika + " " + Sesija.PrijavljenKorisnik.prezime_korisnika));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Kupac", prosljedeniKorisnik.ime_korisnika + " " + prosljedeniKorisnik.prezime_korisnika));
            this.reportViewer1.RefreshReport();            
        }
        private void Racun_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
            prosljedeniDokument = null;
            prosljedeniKorisnik = null;
        }

        private void uiActionMail_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string filePath = "";
            if (ofd.ShowDialog()==DialogResult.OK)
            {
                filePath = ofd.FileName;
            }
            try
            {
                Mailer.PosaljiMail(prosljedeniKorisnik, filePath, "Racun za "+prosljedeniKorisnik.ime_korisnika+" "+prosljedeniKorisnik.prezime_korisnika);
                MessageBox.Show("Mail je uspješno poslan");
            }
            catch (Exception)
            {

                MessageBox.Show("Unesena pogrešna akreditacija elektroničke pošte!");
            }
            
        }
    }
}
