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
    public partial class FormKreirajRezervniDio : Form
    {
        public FormUpravljanjeSkladistem FormUpravljanjeSkladistem;
        public Sloj_pristupa_podacima.Artikl proslijedeniArtikl;
        private static FormKreirajRezervniDio _instance;
        public static FormKreirajRezervniDio instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FormKreirajRezervniDio();
                }
                return _instance;
            }
        }
        public FormKreirajRezervniDio()
        {
            InitializeComponent();
            panelKreirajRezervniDioHeader.BackColor = Color.FromArgb(45, 45, 48);
            panelKreirajRezervniDioFooter.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void FormKreirajRezervniDio_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void uiActionSpremi_Click(object sender, EventArgs e)
        {
            Sloj_pristupa_podacima.Artikl artikl = new Sloj_pristupa_podacima.Artikl();
            {
                artikl.godina_proizvodnje = int.Parse(uiInputGodinaProizvodnjeDijela.Text);               
                artikl.opis_artikla = uiInputOpisRezervnogDijela.Text;                
                artikl.naziv_artikla = uiInputNazivRezervnogDijela.Text;
                artikl.cijena_artikla = double.Parse(uiInputCijenaRezervnogDijela.Text);
                artikl.vrsta_artikla = 1;
            }
            Sloj_pristupa_podacima.UpravljanjeSkladistem.UpravljanjeSkladistemDAL.KreiranjeArtikla(artikl);
            FormUpravljanjeSkladistem.OsvjeziPopisArtikala();
        }

        private void FormKreirajRezervniDio_Load(object sender, EventArgs e)
        {
            if (proslijedeniArtikl!=null)
            {
                uiInputCijenaRezervnogDijela.Text = proslijedeniArtikl.cijena_artikla.ToString();
                uiInputGodinaProizvodnjeDijela.Text = proslijedeniArtikl.godina_proizvodnje.ToString();
                uiInputNazivRezervnogDijela.Text = proslijedeniArtikl.naziv_artikla;
                uiInputOpisRezervnogDijela.Text = proslijedeniArtikl.opis_artikla;
            }
        }

        private void uiActionAzuriraj_Click(object sender, EventArgs e)
        {
            Sloj_pristupa_podacima.Artikl artikl = new Sloj_pristupa_podacima.Artikl();
            {
                artikl.id_artikl = proslijedeniArtikl.id_artikl;
                artikl.godina_proizvodnje = int.Parse(uiInputGodinaProizvodnjeDijela.Text);
                artikl.opis_artikla = uiInputOpisRezervnogDijela.Text;
                artikl.naziv_artikla = uiInputNazivRezervnogDijela.Text;
                artikl.cijena_artikla = double.Parse(uiInputCijenaRezervnogDijela.Text);
                artikl.vrsta_artikla = 1;
            }
            Sloj_pristupa_podacima.UpravljanjeSkladistem.UpravljanjeSkladistemDAL.AzurirajArtikl(artikl);
            FormUpravljanjeSkladistem.OsvjeziPopisArtikala();
            proslijedeniArtikl = null;
        }
    }
}