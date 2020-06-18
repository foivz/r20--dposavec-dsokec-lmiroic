using Sloj_poslovne_logike.UpravljanjeRezervacijama;
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
    public partial class FormKreirajRezervaciju : Form
    {
        public FormUpravljanjeRezervacijama FormUpravljanjeRezervacijama;
        public Sloj_pristupa_podacima.Dokument proslijedeniDokument;
        private static FormKreirajRezervaciju _Instance;
        public static FormKreirajRezervaciju Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new FormKreirajRezervaciju();
                }
                return _Instance;
            }
        }
        public FormKreirajRezervaciju()
        {
            InitializeComponent();
            panelKreirajRezervacijuHeader.BackColor = Color.FromArgb(45, 45, 48);
            paneKreirajRezervacijuFooter.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void FormKreirajRezervaciju_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instance = null;
        }

        private void FormKreirajRezervaciju_Load(object sender, EventArgs e)
        {
            cbInputKorisnik.DataSource = ParserKorisnik.ParsirajKorisnika();
            cbInputZaposlenik.DataSource = ParserKorisnik.ParsirajKorisnika();

            if (proslijedeniDokument != null)
            {
                dateTimeInputDatumIzdavanja.Value = proslijedeniDokument.datum_izdavanja;
                uiInputOpisDokumenta.Text = proslijedeniDokument.opis_dokumenta.ToString();
                cbInputKorisnik.SelectedIndex = (int)proslijedeniDokument.korisnik-1;
                cbInputZaposlenik.SelectedIndex = (int)proslijedeniDokument.zaposlenik - 1;
            }                 
                                   
        }

        private void uiACtionSpremiRezervaciju_Click(object sender, EventArgs e)
        {
            Sloj_pristupa_podacima.Dokument rezervacija = new Sloj_pristupa_podacima.Dokument();
            rezervacija.datum_izdavanja = DateTime.Parse(dateTimeInputDatumIzdavanja.Text.ToString());
            rezervacija.opis_dokumenta = uiInputOpisDokumenta.Text;
            rezervacija.tip_dokumenta = 4;
            rezervacija.korisnik = (cbInputKorisnik.SelectedItem as Sloj_pristupa_podacima.Korisnik).id_korisnik;
            rezervacija.zaposlenik = (cbInputZaposlenik.SelectedItem as Sloj_pristupa_podacima.Korisnik).id_korisnik;

            Sloj_pristupa_podacima.UpravljanjeRezervacijama.UpravljanjeRezervacijamaDAL.KreirajRezervaciju(rezervacija);
            FormUpravljanjeRezervacijama.OsvjeziPrikaz();
                                    
        }

        private void uiActionAzurirajRezervaciju_Click(object sender, EventArgs e)
        {

            Sloj_pristupa_podacima.Dokument rezervacija = new Sloj_pristupa_podacima.Dokument();
            rezervacija.id_dokument = proslijedeniDokument.id_dokument;
            rezervacija.datum_izdavanja = DateTime.Parse(dateTimeInputDatumIzdavanja.Text.ToString());
            rezervacija.opis_dokumenta = uiInputOpisDokumenta.Text;
            rezervacija.tip_dokumenta = 4;
            rezervacija.korisnik = (cbInputKorisnik.SelectedItem as Sloj_pristupa_podacima.Korisnik).id_korisnik;
            rezervacija.zaposlenik = (cbInputZaposlenik.SelectedItem as Sloj_pristupa_podacima.Korisnik).id_korisnik;

            Sloj_pristupa_podacima.UpravljanjeRezervacijama.UpravljanjeRezervacijamaDAL.AzurirajRezervaciju(rezervacija);
            FormUpravljanjeRezervacijama.OsvjeziPrikaz();
            proslijedeniDokument = null;
        }
    }
}
