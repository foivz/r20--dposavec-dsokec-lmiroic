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
    public partial class FormKreirajKorisnika : Form
    {
        public FormUpravljanjeKorisnicima FormUpravljanjeKorisnicima;
        public Sloj_pristupa_podacima.Korisnik ProsljedeniKorisnik;
        private static FormKreirajKorisnika _Instance;
        public static FormKreirajKorisnika Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new FormKreirajKorisnika();
                }
                return _Instance;
            }
        }
        public FormKreirajKorisnika()
        {
            InitializeComponent();
            
        }

        private void uiActionKreiraj_Click(object sender, EventArgs e)
        {
            Sloj_pristupa_podacima.Korisnik korisnik = new Sloj_pristupa_podacima.Korisnik();
            korisnik.ime_korisnika = uiInputImeKorisnika.Text;
            korisnik.prezime_korisnika = uiInputPrezimeKorisnika.Text;
            korisnik.adresa = uiInputAdresaKorisnika.Text;
            korisnik.email = uiInputMailKorisnika.Text;
            korisnik.IBAN = uiInputIBANKorisnika.Text;
            korisnik.korisnicko_ime = uiInputKorisnickoIme.Text;
            korisnik.lozinka = Sloj_pristupa_podacima.UpravljanjeKorisnicima.UpravljanjeKorisnicima.HashirajLozinku(uiInputLozinka.Text);
            korisnik.tip_korisnika = (uiInputTipKorisnika.SelectedItem as Sloj_pristupa_podacima.Tip_korisnika).id_tip_korisnika;
            korisnik.poslovnica = (uiInputKorisnikovaPoslovnica.SelectedItem as Sloj_pristupa_podacima.Poslovnica).id_poslovnica;

            Sloj_pristupa_podacima.UpravljanjeKorisnicima.UpravljanjeKorisnicima.KreiranjeKorisnika(korisnik);
            FormUpravljanjeKorisnicima.OsvjeziPopisKorisnika();

        }

        private void FormKreirajKorisnika_Load(object sender, EventArgs e)
        {
            panelUpravKorisnicimaHeader.BackColor = Color.FromArgb(45, 45, 48);
            panelUpravKorisnicimaFooter.BackColor = Color.FromArgb(45, 45, 48);
            uiInputTipKorisnika.DataSource = null;
            uiInputTipKorisnika.DataSource = Sloj_poslovne_logike.UpravljanjeKorisnicima.ParserTipKorisnika.ParsirajTipKorisnika();
            uiInputKorisnikovaPoslovnica.DataSource = null;
            uiInputKorisnikovaPoslovnica.DataSource = Sloj_poslovne_logike.UpravljanjePoslovnicama.ParserPoslovnica.ParsirajPoslovnicu();
            if (ProsljedeniKorisnik != null)
            {
                uiInputImeKorisnika.Text = ProsljedeniKorisnik.ime_korisnika;
                uiInputPrezimeKorisnika.Text = ProsljedeniKorisnik.prezime_korisnika;
                uiInputAdresaKorisnika.Text = ProsljedeniKorisnik.adresa;
                uiInputIBANKorisnika.Text = ProsljedeniKorisnik.IBAN;
                uiInputMailKorisnika.Text = ProsljedeniKorisnik.email;
                uiInputKorisnickoIme.Text = ProsljedeniKorisnik.korisnicko_ime;
                uiInputLozinka.Text = ProsljedeniKorisnik.lozinka;
                uiInputTipKorisnika.SelectedIndex = (int)ProsljedeniKorisnik.tip_korisnika - 1;
                if (ProsljedeniKorisnik.poslovnica!=null)
                {
                    uiInputKorisnikovaPoslovnica.SelectedIndex = (int)ProsljedeniKorisnik.poslovnica-1;
                }
            }

        }

        private void uiActionAzuriranje_Click(object sender, EventArgs e)
        {
            Sloj_pristupa_podacima.Korisnik korisnik = new Sloj_pristupa_podacima.Korisnik();
            korisnik.id_korisnik = ProsljedeniKorisnik.id_korisnik;
            korisnik.ime_korisnika = uiInputImeKorisnika.Text;
            korisnik.prezime_korisnika = uiInputPrezimeKorisnika.Text;
            korisnik.adresa = uiInputAdresaKorisnika.Text;
            korisnik.email = uiInputMailKorisnika.Text;
            korisnik.IBAN = uiInputIBANKorisnika.Text;
            korisnik.korisnicko_ime = uiInputKorisnickoIme.Text;
            korisnik.lozinka = Sloj_pristupa_podacima.UpravljanjeKorisnicima.UpravljanjeKorisnicima.HashirajLozinku(uiInputLozinka.Text);
            korisnik.tip_korisnika = (uiInputTipKorisnika.SelectedItem as Sloj_pristupa_podacima.Tip_korisnika).id_tip_korisnika;
            if (ProsljedeniKorisnik.poslovnica != null)
            {
                korisnik.poslovnica = (uiInputKorisnikovaPoslovnica.SelectedItem as Sloj_pristupa_podacima.Poslovnica).id_poslovnica;
            }
            else
                korisnik.poslovnica = null;
            Sloj_pristupa_podacima.UpravljanjeKorisnicima.UpravljanjeKorisnicima.AzurirajKorisnika(korisnik);
            FormUpravljanjeKorisnicima.OsvjeziPopisKorisnika();
            ProsljedeniKorisnik = null;
        }

        private void FormKreirajKorisnika_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instance = null;
        }
    }
}
