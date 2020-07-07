using Sloj_poslovne_logike;
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
        public FormProdajaArtikla FormProdajaArtikla;
        public Sloj_pristupa_podacima.Dokument proslijedeniDokument;
        public Sloj_pristupa_podacima.Artikl prosljedeniArtikl;
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
            prosljedeniArtikl = null;
        }

        private void FormKreirajNarudzbu_Load(object sender, EventArgs e)
        {
            List<Korisnik> listaKorisnika = ParserKorisnik.ParsirajKorisnika();
            List<Korisnik> listaZaposlenika = ParserKorisnik.ParsirajKorisnika();
            cbInputKorisnikKreirajNarudzbu.DataSource = listaKorisnika;
            cbInputZaposlenikKreirajNarudzbu.DataSource = listaZaposlenika;
            if (prosljedeniArtikl!=null)
            {
                dateTimeInputDatumIzdavanjaKreirajNarudzbu.Value = DateTime.Now;
                uiInputOpisDokumentaKn.Text = "Narudzba za "+prosljedeniArtikl.naziv_artikla.ToLower()+" "+prosljedeniArtikl.opis_artikla.ToString();
                uiInputUkupniSaldo.Text = prosljedeniArtikl.cijena_artikla.ToString();
                label5.Hide();
                cbInputZaposlenikKreirajNarudzbu.Enabled = false;
                cbInputZaposlenikKreirajNarudzbu.Hide();
                uiActionAzurirajNarudzbu.Enabled = false;
                uiActionAzurirajNarudzbu.Hide();
            }
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
                label5.Hide();
                cbInputZaposlenikKreirajNarudzbu.Enabled = false;
                cbInputZaposlenikKreirajNarudzbu.Hide();
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
                narudzba.zaposlenik = Sesija.PrijavljenKorisnik.id_korisnik;
                if (Sloj_poslovne_logike.UpravljanjeNarudzbama.UpravljanjeNarudzbamaBLL.ProvjeraUnosaNarudzbe(narudzba)==true)
                {
                    Sloj_pristupa_podacima.UpravljanjeNarudzbama.UpravljanjeNarudzbamaDAL.KreirajNarudzbu(narudzba);
                    if (prosljedeniArtikl==null)
                    {
                        FormUpravljanjeNarudzbama.OsvjeziPrikaz();
                    }                    
                    DnevnikRadaDLL.DnevnikLogin.ZapisiZapis(DnevnikRadaDLL.RadnjaDnevnika.KREIRANA_NARUDZBA);
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
                if (Sloj_poslovne_logike.UpravljanjeNarudzbama.UpravljanjeNarudzbamaBLL.ProvjeraUnosaNarudzbe(narudzba) == true)
                {
                    Sloj_pristupa_podacima.UpravljanjeNarudzbama.UpravljanjeNarudzbamaDAL.AzurirajNarudzbu(narudzba);
                    FormUpravljanjeNarudzbama.OsvjeziPrikaz();
                    DnevnikRadaDLL.DnevnikLogin.ZapisiZapis(DnevnikRadaDLL.RadnjaDnevnika.AZURIRAJ_NARUDZBU);
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

        private void FormKreirajNarudzbu_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            System.Windows.Forms.Help.ShowHelp(this, "CarAppHelp.chm", HelpNavigator.Topic, "KreirajNarudzbu.html");

        }
    }
}
