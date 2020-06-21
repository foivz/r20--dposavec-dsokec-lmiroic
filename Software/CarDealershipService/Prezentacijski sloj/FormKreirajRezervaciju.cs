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
            proslijedeniDokument = null;
        }

        private void FormKreirajRezervaciju_Load(object sender, EventArgs e)
        {
            cbInputKorisnik.DataSource = ParserKorisnik.ParsirajKorisnika();
            List<Korisnik> listaKorisnika = ParserKorisnik.ParsirajKorisnika();
            List<Korisnik> listaZaposlenika = ParserKorisnik.ParsirajKorisnika();
            if (proslijedeniDokument != null)
            {
                dateTimeInputDatumIzdavanja.Value = proslijedeniDokument.datum_izdavanja;
                uiInputOpisDokumenta.Text = proslijedeniDokument.opis_dokumenta.ToString();
                cbInputKorisnik.SelectedIndex = listaKorisnika.IndexOf(listaKorisnika.Find(x => x.id_korisnik == proslijedeniDokument.korisnik));
                cbInputZaposlenik.SelectedIndex= listaZaposlenika.IndexOf(listaZaposlenika.Find(x => x.id_korisnik == proslijedeniDokument.zaposlenik));
                uiACtionSpremiRezervaciju.Enabled = false;
                uiACtionSpremiRezervaciju.Hide();
            }
            else
            {
                label4.Hide();
                cbInputZaposlenik.Enabled = false;
                cbInputZaposlenik.Hide();
                uiActionAzurirajRezervaciju.Enabled = false;
                uiActionAzurirajRezervaciju.Hide();
            }                        
        }

        private void uiACtionSpremiRezervaciju_Click(object sender, EventArgs e)
        {
            Sloj_pristupa_podacima.Dokument rezervacija = new Sloj_pristupa_podacima.Dokument();
            try
            {
                rezervacija.datum_izdavanja = DateTime.Parse(dateTimeInputDatumIzdavanja.Text.ToString());
                rezervacija.opis_dokumenta = uiInputOpisDokumenta.Text.ToString();
                rezervacija.tip_dokumenta = 4;
                rezervacija.korisnik = (cbInputKorisnik.SelectedItem as Sloj_pristupa_podacima.Korisnik).id_korisnik;
                rezervacija.zaposlenik = Sloj_poslovne_logike.Sesija.PrijavljenKorisnik.id_korisnik;
                if (UpravljanjeRezervacijamaBLL.ProvjeraUnosaRezervacije(rezervacija)==true)
                {
                    Sloj_pristupa_podacima.UpravljanjeRezervacijama.UpravljanjeRezervacijamaDAL.KreirajRezervaciju(rezervacija);
                    FormUpravljanjeRezervacijama.OsvjeziPrikaz();
                }
                else
                {
                    MessageBox.Show("Niste unijeli odgovarajuće parametre! Za pomoć pritisnite F1.");
                }
            }
            catch (Exception ex)
            {

                //MessageBox.Show("Morate unijeti sve parametre!");
                MessageBox.Show(ex.Message);
            }                                 
        }

        private void uiActionAzurirajRezervaciju_Click(object sender, EventArgs e)
        {
            Sloj_pristupa_podacima.Dokument rezervacija = new Sloj_pristupa_podacima.Dokument();
            try
            {
                rezervacija.id_dokument = proslijedeniDokument.id_dokument;
                rezervacija.datum_izdavanja = DateTime.Parse(dateTimeInputDatumIzdavanja.Text.ToString());
                rezervacija.opis_dokumenta = uiInputOpisDokumenta.Text.ToString();
                rezervacija.tip_dokumenta = 4;
                rezervacija.korisnik = (cbInputKorisnik.SelectedItem as Korisnik).id_korisnik;
                rezervacija.zaposlenik = Sloj_poslovne_logike.Sesija.PrijavljenKorisnik.id_korisnik;
                if (UpravljanjeRezervacijamaBLL.ProvjeraUnosaRezervacije(rezervacija) == true)
                {
                    Sloj_pristupa_podacima.UpravljanjeRezervacijama.UpravljanjeRezervacijamaDAL.AzurirajRezervaciju(rezervacija);
                    FormUpravljanjeRezervacijama.OsvjeziPrikaz();
                }
                else
                {
                    MessageBox.Show("Niste unijeli odgovarajuće parametre! Za pomoć pritisnite F1.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }          
        }
    }
}
