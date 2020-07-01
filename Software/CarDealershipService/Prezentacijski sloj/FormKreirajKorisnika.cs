using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sloj_poslovne_logike.UpravljanjePoslovnicama;

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
            try
            {
                korisnik.ime_korisnika = uiInputImeKorisnika.Text;
                korisnik.prezime_korisnika = uiInputPrezimeKorisnika.Text;
                korisnik.adresa = uiInputAdresaKorisnika.Text;
                korisnik.email = uiInputMailKorisnika.Text;
                korisnik.IBAN = uiInputIBANKorisnika.Text;
                korisnik.korisnicko_ime = uiInputKorisnickoIme.Text;
                korisnik.lozinka = Sloj_pristupa_podacima.UpravljanjeKorisnicima.UpravljanjeKorisnicima.HashirajLozinku(uiInputLozinka.Text);
                korisnik.tip_korisnika = (uiInputTipKorisnika.SelectedItem as Sloj_pristupa_podacima.Tip_korisnika).id_tip_korisnika;
                korisnik.poslovnica = (uiInputKorisnikovaPoslovnica.SelectedItem as Sloj_pristupa_podacima.Poslovnica).id_poslovnica;
                if (Sloj_poslovne_logike.UpravljanjeKorisnicima.UpravljanjeKorisnicimaBLL.ProvjeriUnosKorisnika(korisnik)==true)
                {
                    Sloj_pristupa_podacima.UpravljanjeKorisnicima.UpravljanjeKorisnicima.KreiranjeKorisnika(korisnik);
                    FormUpravljanjeKorisnicima.OsvjeziPopisKorisnika();
                    Sloj_poslovne_logike.UpravljanjeDnevnikom.DnevnikLog.ZapisiZapis(Sloj_poslovne_logike.UpravljanjeDnevnikom.RadnjaDnevnika.KREIRAN_KORISNIK);
                }
                else
                {
                    MessageBox.Show("Niste unijeli odgovarajuće parametre! Za pomoć pritisnite F1.");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Morate unijeti sve parametre!");
            }
        }

        private void FormKreirajKorisnika_Load(object sender, EventArgs e)
        {
            List<Poslovnica> listaPoslovnica = ParserPoslovnica.ParsirajPoslovnicu();
            List<Sloj_poslovne_logike.UpravljanjeKorisnicima.TipKorisnika> listaTipaKorisnika = Sloj_poslovne_logike.UpravljanjeKorisnicima.ParserTipKorisnika.ParsirajTipKorisnika();
            panelUpravKorisnicimaHeader.BackColor = Color.FromArgb(45, 45, 48);
            panelUpravKorisnicimaFooter.BackColor = Color.FromArgb(45, 45, 48);
            uiInputTipKorisnika.DataSource = null;
            uiInputTipKorisnika.DataSource = listaTipaKorisnika;
            uiInputKorisnikovaPoslovnica.DataSource = null;
            uiInputKorisnikovaPoslovnica.DataSource = listaPoslovnica;
            if (ProsljedeniKorisnik != null)
            {
                uiInputImeKorisnika.Text = ProsljedeniKorisnik.ime_korisnika;
                uiInputPrezimeKorisnika.Text = ProsljedeniKorisnik.prezime_korisnika;
                uiInputAdresaKorisnika.Text = ProsljedeniKorisnik.adresa;
                uiInputIBANKorisnika.Text = ProsljedeniKorisnik.IBAN;
                uiInputMailKorisnika.Text = ProsljedeniKorisnik.email;
                uiInputKorisnickoIme.Text = ProsljedeniKorisnik.korisnicko_ime;
                uiInputLozinka.Text = ProsljedeniKorisnik.lozinka;
                uiInputTipKorisnika.SelectedIndex = listaTipaKorisnika.IndexOf(listaTipaKorisnika.Find(x => x.id_tip_korisnika == ProsljedeniKorisnik.tip_korisnika));
                if (ProsljedeniKorisnik.poslovnica!=null)
                {
                    uiInputKorisnikovaPoslovnica.SelectedIndex = listaPoslovnica.IndexOf(listaPoslovnica.Find(x => x.id_poslovnica == ProsljedeniKorisnik.poslovnica));
                }
                uiActionKreiraj.Enabled = false;
                uiActionKreiraj.Hide();
            }
            else
            {
                uiActionAzuriranje.Enabled = false;
                uiActionAzuriranje.Hide();
            }

        }

        private void uiActionAzuriranje_Click(object sender, EventArgs e)
        {
            Sloj_pristupa_podacima.Korisnik korisnik = new Sloj_pristupa_podacima.Korisnik();
            try
            {
                korisnik.id_korisnik = ProsljedeniKorisnik.id_korisnik;
                korisnik.ime_korisnika = uiInputImeKorisnika.Text;
                korisnik.prezime_korisnika = uiInputPrezimeKorisnika.Text;
                korisnik.adresa = uiInputAdresaKorisnika.Text;
                korisnik.email = uiInputMailKorisnika.Text;
                korisnik.IBAN = uiInputIBANKorisnika.Text;
                korisnik.korisnicko_ime = uiInputKorisnickoIme.Text;
                if (uiInputLozinka.Text.Length!=40)
                {
                    korisnik.lozinka = Sloj_pristupa_podacima.UpravljanjeKorisnicima.UpravljanjeKorisnicima.HashirajLozinku(uiInputLozinka.Text);
                }
                else
                    korisnik.lozinka = uiInputLozinka.Text;
                korisnik.tip_korisnika = (uiInputTipKorisnika.SelectedItem as Sloj_pristupa_podacima.Tip_korisnika).id_tip_korisnika;
                if (ProsljedeniKorisnik.poslovnica != null)
                {
                    korisnik.poslovnica = (uiInputKorisnikovaPoslovnica.SelectedItem as Sloj_pristupa_podacima.Poslovnica).id_poslovnica;
                }
                else
                    korisnik.poslovnica = null;
                if (Sloj_poslovne_logike.UpravljanjeKorisnicima.UpravljanjeKorisnicimaBLL.ProvjeriUnosKorisnika(korisnik)==true)
                {
                    Sloj_pristupa_podacima.UpravljanjeKorisnicima.UpravljanjeKorisnicima.AzurirajKorisnika(korisnik);
                    FormUpravljanjeKorisnicima.OsvjeziPopisKorisnika();
                }
                else
                {
                    MessageBox.Show("Niste unijeli odgovarajuće parametre! Za pomoć pritisnite F1.");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Morate unijeti sve parametre!");
            }
        }

        private void FormKreirajKorisnika_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instance = null;
            ProsljedeniKorisnik = null;
        }
    }
}
