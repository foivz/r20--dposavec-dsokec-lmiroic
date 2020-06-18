using System;
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

        }

        private void FormKreirajKorisnika_Load(object sender, EventArgs e)
        {
            panelUpravKorisnicimaHeader.BackColor = Color.FromArgb(45, 45, 48);
            panelUpravKorisnicimaFooter.BackColor = Color.FromArgb(45, 45, 48);
            uiInputTipKorisnika.DataSource = null;
            
        }
    }
}
