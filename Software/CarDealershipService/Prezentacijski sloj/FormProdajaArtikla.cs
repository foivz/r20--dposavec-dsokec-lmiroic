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
    public partial class FormProdajaArtikla : Form
    {
        private List<Sloj_pristupa_podacima.Artikl> odabraniArtikli = new List<Sloj_pristupa_podacima.Artikl>();
        private double suma = 0;
        private static FormProdajaArtikla _instance;
        public static FormProdajaArtikla instance
        {
            get
            {                
                if (_instance == null)
                {
                    _instance = new FormProdajaArtikla();
                }
                return _instance;
            }
        }
        public FormProdajaArtikla()
        {
            InitializeComponent();
            panelProdajaArtikalaFooter.BackColor = Color.FromArgb(45, 45, 48);
            panelProdajaArtikalaHeader.BackColor = Color.FromArgb(45, 45, 48);
            panelProdajaArtiklaOdabraniArtikli.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void FormProdajaArtikla_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void FormProdajaArtikla_Load(object sender, EventArgs e)
        {
            lblSuma.Hide();
            List<Sloj_poslovne_logike.UpravljanjeRezervacijama.Korisnik> listaKorisnika = Sloj_poslovne_logike.UpravljanjeRezervacijama.ParserKorisnik.ParsirajKorisnika();
            uiInputKlijenti.DataSource = null;
            uiInputKlijenti.DataSource = listaKorisnika;
            dgvProdajniArtikli.DataSource = null;
            dgvProdajniArtikli.DataSource = Sloj_pristupa_podacima.UpravljanjeSkladistem.UpravljanjeSkladistemDAL.DohvatiArtiklePoslovnice(Sloj_poslovne_logike.Sesija.PrijavljenKorisnik);
            dgvProdajniArtikli.Columns[9].Visible = false;
            dgvProdajniArtikli.Columns[10].Visible = false;
            dgvProdajniArtikli.Columns[11].Visible = false;
        }

        private void uiActionProdaja_Click(object sender, EventArgs e)
        {
            Sloj_pristupa_podacima.UpravljanjeSkladistem.UpravljanjeSkladistemDAL.ProdajaArtikla(odabraniArtikli);
            Sloj_pristupa_podacima.Dokument dokument = new Sloj_pristupa_podacima.Dokument();
            dokument.datum_izdavanja = DateTime.Now;
            string opis = "Račun za ";
            foreach (var item in odabraniArtikli)
            {
                opis += item.naziv_artikla + ", ";
            }
            dokument.opis_dokumenta = opis;
            dokument.tip_dokumenta = 1;
            dokument.ukupni_saldo = suma;
            dokument.zaposlenik = Sloj_poslovne_logike.Sesija.PrijavljenKorisnik.id_korisnik;
            dokument.korisnik = (uiInputKlijenti.SelectedItem as Sloj_pristupa_podacima.Korisnik).id_korisnik;
            Sloj_pristupa_podacima.UpravljanjeNarudzbama.UpravljanjeNarudzbamaDAL.KreirajRacun(dokument);
            foreach (var item in odabraniArtikli)
            {
                Sloj_pristupa_podacima.Usluga usluga = new Sloj_pristupa_podacima.Usluga();
                if (item.naziv_artikla.EndsWith("a"))
                {
                    usluga.naziv_usluge = "Prodaja " + item.naziv_artikla;
                }
                else
                {
                    usluga.naziv_usluge = "Prodaja " + item.naziv_artikla + "a";
                }                
                if (item.vrsta_artikla==1)
                {
                    usluga.vrsta_usluge = 3;
                }
                else
                {
                    usluga.vrsta_usluge = 2;
                }
                Sloj_pristupa_podacima.Upravljanje_uslugama.UpravljanjeUslugamaDAL.KreiranjeUsluge(usluga);
                Sloj_pristupa_podacima.Stavke_dokumenta stavke_Dokumenta = new Sloj_pristupa_podacima.Stavke_dokumenta();
                stavke_Dokumenta.usluga=Sloj_pristupa_podacima.Upravljanje_uslugama.UpravljanjeUslugamaDAL.VratiZadnjiUnos(usluga.naziv_usluge).id_usluga;
                stavke_Dokumenta.dokument = Sloj_pristupa_podacima.UpravljanjeNarudzbama.UpravljanjeNarudzbamaDAL.VratiZadnjiRacun(dokument).id_dokument;
                stavke_Dokumenta.artikl = item.id_artikl;
                Sloj_pristupa_podacima.UpravljanjeNarudzbama.UpravljanjeNarudzbamaDAL.KreiranjeStavkeDokumenta(stavke_Dokumenta);
                DnevnikRadaDLL.DnevnikLogin.ZapisiZapis(DnevnikRadaDLL.RadnjaDnevnika.PRODAN_ARTIKL);
            }
        }       
        
        private void dgvProdajniArtikli_DoubleClick(object sender, EventArgs e)
        {
            
            Sloj_pristupa_podacima.Artikl odabraniArtikl =dgvProdajniArtikli.CurrentRow.DataBoundItem as Sloj_pristupa_podacima.Artikl;
            
            if (Sloj_pristupa_podacima.UpravljanjeSkladistem.UpravljanjeSkladistemDAL.ProvjeraDostupnostiArtikla(odabraniArtikl)==true)
            {
                odabraniArtikli.Add(odabraniArtikl);
                suma += odabraniArtikl.cijena_artikla;
                OsvjeziOdabraneArtikle();

            }
            else
            {
                MessageBox.Show("Odabrani artikl nije dostupan na skladištu.");
            }
        }
        private void OsvjeziOdabraneArtikle()
        {
            dgvOdabraniArtikli.DataSource = null;
            dgvOdabraniArtikli.DataSource = odabraniArtikli;
            dgvOdabraniArtikli.Columns[9].Visible = false;
            dgvOdabraniArtikli.Columns[10].Visible = false;
            dgvOdabraniArtikli.Columns[11].Visible = false;
            lblSuma.Text = "Ukupna cijena = " + suma;
            lblSuma.Show();
        }

        private void FormProdajaArtikla_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            System.Windows.Forms.Help.ShowHelp(this, "CarAppHelp.chm", HelpNavigator.Topic, "Prodaja.html");

        }
    }
}
