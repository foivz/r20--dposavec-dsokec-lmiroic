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
    public partial class FormKreirajNarudzbu : Form
    {
        public FormUpravljanjeNarudzbama FormUpravljanjeNarudzbama;
        public Sloj_pristupa_podacima.Dokument proslijedeniDokument;
        private static FormKreirajNarudzbu _Instance;
        public static FormKreirajNarudzbu Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new FormKreirajNarudzbu();
                }
                return _Instance;
            }
        }
        public FormKreirajNarudzbu()
        {
            InitializeComponent();
            panelKreirajNarudzbuHeader.BackColor = Color.FromArgb(45, 45, 48);
            panelKreirajNarudzbuFooter.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void FormKreirajNarudzbu_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instance = null;
            proslijedeniDokument = null;
        }

        private void FormKreirajNarudzbu_Load(object sender, EventArgs e)
        {
            List<Korisnik> listaKorisnika = ParserKorisnik.ParsirajKorisnika();
            List<Korisnik> listaZaposlenika = ParserKorisnik.ParsirajKorisnika();
            cbInputKorisnikKreirajNarudzbu.DataSource = listaKorisnika;
            cbInputZaposlenikKreirajNarudzbu.DataSource = listaZaposlenika;
            if (proslijedeniDokument != null)
            {
                dateTimeInputDatumIzdavanjaKreirajNarudzbu.Value = proslijedeniDokument.datum_izdavanja;
                uiInputOpisDokumentaKn.Text = proslijedeniDokument.opis_dokumenta.ToString();
                uiInputUkupniSaldo.Text = proslijedeniDokument.ukupni_saldo.ToString();
                cbInputKorisnikKreirajNarudzbu.SelectedIndex = listaKorisnika.IndexOf(listaKorisnika.Find(x => x.id_korisnik == proslijedeniDokument.korisnik));
                cbInputZaposlenikKreirajNarudzbu.SelectedIndex = listaZaposlenika.IndexOf(listaZaposlenika.Find(x => x.id_korisnik == proslijedeniDokument.zaposlenik));
                uiActionSpremiNarudzbu.Enabled = false;
                uiActionSpremiNarudzbu.Hide();
            }
            else
            {
                uiActionAzurirajNarudzbu.Enabled=false;
                uiActionAzurirajNarudzbu.Hide();
            }
        }

        private void uiActionSpremiNarudzbu_Click(object sender, EventArgs e)
        {
            Sloj_pristupa_podacima.Dokument narudzba = new Sloj_pristupa_podacima.Dokument();
            try
            {
                narudzba.datum_izdavanja = DateTime.Parse(dateTimeInputDatumIzdavanjaKreirajNarudzbu.Text.ToString());
                narudzba.opis_dokumenta = uiInputOpisDokumentaKn.Text;
                narudzba.ukupni_saldo = float.Parse(uiInputUkupniSaldo.Text);
                narudzba.tip_dokumenta = 2;
                narudzba.korisnik = (cbInputKorisnikKreirajNarudzbu.SelectedItem as Sloj_pristupa_podacima.Korisnik).id_korisnik;
                narudzba.zaposlenik = (cbInputZaposlenikKreirajNarudzbu.SelectedItem as Sloj_pristupa_podacima.Korisnik).id_korisnik;
                if (UpravljanjeRezervacijamaBLL.ProvjeraUnosaRezervacije(narudzba)==true)
                {
                    Sloj_pristupa_podacima.UpravljanjeNarudzbama.UpravljanjeNarudzbamaDAL.KreirajNarudzbu(narudzba);
                    FormUpravljanjeNarudzbama.OsvjeziPrikaz();
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

        private void uiActionAzurirajNarudzbu_Click(object sender, EventArgs e)
        {
            Sloj_pristupa_podacima.Dokument narudzba = new Sloj_pristupa_podacima.Dokument();
            try
            {
                narudzba.id_dokument = proslijedeniDokument.id_dokument;
                narudzba.datum_izdavanja = DateTime.Parse(dateTimeInputDatumIzdavanjaKreirajNarudzbu.Text.ToString());
                narudzba.opis_dokumenta = uiInputOpisDokumentaKn.Text;
                narudzba.ukupni_saldo = float.Parse(uiInputUkupniSaldo.Text);
                narudzba.tip_dokumenta = 2;
                narudzba.korisnik = (cbInputKorisnikKreirajNarudzbu.SelectedItem as Sloj_pristupa_podacima.Korisnik).id_korisnik;
                narudzba.zaposlenik = (cbInputZaposlenikKreirajNarudzbu.SelectedItem as Sloj_pristupa_podacima.Korisnik).id_korisnik;
                if (UpravljanjeRezervacijamaBLL.ProvjeraUnosaRezervacije(narudzba) == true)
                {
                    Sloj_pristupa_podacima.UpravljanjeNarudzbama.UpravljanjeNarudzbamaDAL.AzurirajNarudzbu(narudzba);
                    FormUpravljanjeNarudzbama.OsvjeziPrikaz();
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
    }
}
