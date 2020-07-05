﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prezentacijski_sloj
{
    public partial class FormIzvjesca : Form
    {
        private static FormIzvjesca _instance;
        public static FormIzvjesca instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FormIzvjesca();
                }
                return _instance;
            }
        }
        public FormIzvjesca()
        {
            InitializeComponent();
        }

        private void FormIzdajDokumente_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void FormIzvjesca_Load(object sender, EventArgs e)
        {
            List<Sloj_pristupa_podacima.Dokument> racun = new List<Sloj_pristupa_podacima.Dokument>();
            racun = Sloj_pristupa_podacima.UpravljanjeNarudzbama.UpravljanjeNarudzbamaDAL.DohvatiRacun(Sloj_poslovne_logike.Sesija.PrijavljenKorisnik);
            DokumentBindingSource.DataSource = null;
            DokumentBindingSource.DataSource = racun;
            this.reportViewer1.RefreshReport();

            List<Sloj_pristupa_podacima.Korisnik> sviKorisnici = new List<Sloj_pristupa_podacima.Korisnik>();
            sviKorisnici = Sloj_pristupa_podacima.UpravljanjeKorisnicima.UpravljanjeKorisnicima.DohvatiSveKorisnike();
            KorisnikBindingSource.DataSource = null;
            KorisnikBindingSource.DataSource = sviKorisnici;
            this.reportViewer2.RefreshReport();
            this.reportViewer2.RefreshReport();
        }
    }
}