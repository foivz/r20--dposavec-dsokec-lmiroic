using Sloj_poslovne_logike;
using Sloj_poslovne_logike.UpravljanjeRezervacijama;
using Sloj_poslovne_logike.UpravljanjeSkladistem;
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
            List<Artikl> artikli = ParserArtikla.ParsirajArtikl();
            cbInputArtiklZaNaruciti.DataSource = null;
            cbInputArtiklZaNaruciti.DataSource = artikli;
            if (prosljedeniArtikl!=null)
            {
                
                cbInputArtiklZaNaruciti.SelectedIndex= artikli.IndexOf(artikli.Find(x => x.id_artikl == prosljedeniArtikl.id_artikl));
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
                cbInputArtiklZaNaruciti.Enabled = false;
                cbInputArtiklZaNaruciti.Hide();
                label7.Hide();
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

                    Sloj_pristupa_podacima.Usluga usluga = new Sloj_pristupa_podacima.Usluga();
                    usluga.naziv_usluge = narudzba.opis_dokumenta;
                    usluga.vrsta_usluge = 1;
                    Sloj_pristupa_podacima.Upravljanje_uslugama.UpravljanjeUslugamaDAL.KreiranjeUsluge(usluga);
                    Sloj_pristupa_podacima.Stavke_dokumenta stavke_Dokumenta = new Sloj_pristupa_podacima.Stavke_dokumenta();
                    stavke_Dokumenta.usluga = Sloj_pristupa_podacima.Upravljanje_uslugama.UpravljanjeUslugamaDAL.VratiZadnjiUnos(usluga.naziv_usluge).id_usluga;
                    stavke_Dokumenta.dokument = Sloj_pristupa_podacima.UpravljanjeNarudzbama.UpravljanjeNarudzbamaDAL.VratiZadnjiRacun(narudzba).id_dokument;
                    stavke_Dokumenta.artikl = (cbInputArtiklZaNaruciti.SelectedItem as Artikl).id_artikl;
                    Sloj_pristupa_podacima.UpravljanjeNarudzbama.UpravljanjeNarudzbamaDAL.KreiranjeStavkeDokumenta(stavke_Dokumenta);

                    if (prosljedeniArtikl==null)
                    {
                        FormUpravljanjeNarudzbama.OsvjeziPrikaz();
                    }                    
                    DnevnikRadaDLL.DnevnikLogin.ZapisiZapis(DnevnikRadaDLL.RadnjaDnevnika.KREIRANA_NARUDZBA);
                    Sloj_pristupa_podacima.Obavijest obavijest = new Sloj_pristupa_podacima.Obavijest();
                    obavijest.Korisnik= (cbInputKorisnikKreirajNarudzbu.SelectedItem as Sloj_pristupa_podacima.Korisnik).id_korisnik;
                    obavijest.Naslov = "Kreirana narudzba";
                    obavijest.Opis = uiInputOpisDokumentaKn.Text;
                    obavijest.Procitano = 0;
                    obavijest.Vrijeme_kreiranja= DateTime.Parse(dateTimeInputDatumIzdavanjaKreirajNarudzbu.Text.ToString());
                    obavijest.Zaposlenik = Sesija.PrijavljenKorisnik.id_korisnik;
                    Sloj_pristupa_podacima.UpravljanjeObavijestima.UpravljanjeObavijestimaDAL.KreirajObavijest(obavijest);
                    Mailer.PosaljiObavijestNaMail(cbInputKorisnikKreirajNarudzbu.SelectedItem as Sloj_pristupa_podacima.Korisnik, obavijest.Opis, obavijest.Naslov);
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
                if (Sloj_poslovne_logike.UpravljanjeNarudzbama.UpravljanjeNarudzbamaBLL.ProvjeraUnosaNarudzbe(narudzba) == true)
                {
                    Sloj_pristupa_podacima.UpravljanjeNarudzbama.UpravljanjeNarudzbamaDAL.AzurirajNarudzbu(narudzba);
                    FormUpravljanjeNarudzbama.OsvjeziPrikaz();
                    DnevnikRadaDLL.DnevnikLogin.ZapisiZapis(DnevnikRadaDLL.RadnjaDnevnika.AZURIRAJ_NARUDZBU);
                    Sloj_pristupa_podacima.Obavijest obavijest = new Sloj_pristupa_podacima.Obavijest();
                    obavijest.Korisnik = (cbInputKorisnikKreirajNarudzbu.SelectedItem as Sloj_pristupa_podacima.Korisnik).id_korisnik;
                    obavijest.Naslov = "Azurirana narudzba";
                    obavijest.Opis = uiInputOpisDokumentaKn.Text;
                    obavijest.Procitano = 0;
                    obavijest.Vrijeme_kreiranja = DateTime.Parse(dateTimeInputDatumIzdavanjaKreirajNarudzbu.Text.ToString());
                    obavijest.Zaposlenik = Sesija.PrijavljenKorisnik.id_korisnik;
                    Sloj_pristupa_podacima.UpravljanjeObavijestima.UpravljanjeObavijestimaDAL.KreirajObavijest(obavijest);
                    Mailer.PosaljiObavijestNaMail(cbInputKorisnikKreirajNarudzbu.SelectedItem as Sloj_pristupa_podacima.Korisnik, obavijest.Opis, obavijest.Naslov);
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
