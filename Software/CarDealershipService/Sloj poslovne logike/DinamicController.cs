using Sloj_poslovne_logike.UpravljanjeRezervacijama;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sloj_poslovne_logike
{
    public class DinamicController
    {
        private static List<Control> sveKontrolePredikcije = new List<Control>();
        private static int VERT_SPACE = 30;
        private static int INITIAL_VERT = 0;
        private static int HORIZ_SPACE = 230;
        private static int INITIAL_HORIZ = 20;

        public static void DodajRed(Form forma,Sloj_pristupa_podacima.Artikli_na_skladistu ans,string datum,Korisnik korisnik)
        {
            Sloj_pristupa_podacima.Artikl artikl = Sloj_pristupa_podacima.UpravljanjeSkladistem.UpravljanjeSkladistemDAL.DohvatiArtikl(ans.artikl);
            Label lblNaziv = new Label();
            lblNaziv.ForeColor = Color.LightGray;
            lblNaziv.Text = artikl.naziv_artikla;
            lblNaziv.Location = new Point(20, INITIAL_VERT + VERT_SPACE);

            Label lblDatum = new Label();
            lblDatum.ForeColor = Color.LightGray;
            lblDatum.Text = datum;
            lblDatum.Location = new Point(INITIAL_HORIZ + HORIZ_SPACE, INITIAL_VERT + VERT_SPACE);

            Button btnNaruci = new Button();
            btnNaruci.Text = "Naruči";
            btnNaruci.ForeColor = Color.LightGray;
            btnNaruci.FlatStyle = FlatStyle.Flat;
            btnNaruci.FlatAppearance.BorderSize = 0;
            if (ProvjeriDaLiJeMoguceNaruciti(datum))
                btnNaruci.Enabled = true;
            else
                btnNaruci.Enabled = false;
            btnNaruci.Click += (s, e) =>
            {
                Sloj_pristupa_podacima.Dokument narudzba = new Sloj_pristupa_podacima.Dokument();
                try
                {
                    narudzba.datum_izdavanja = DateTime.Now;
                    narudzba.opis_dokumenta = "Narudzba za "+artikl.naziv_artikla;
                    narudzba.ukupni_saldo = artikl.cijena_artikla;
                    narudzba.tip_dokumenta = 2;
                    narudzba.korisnik = korisnik.id_korisnik;
                    narudzba.zaposlenik = Sesija.PrijavljenKorisnik.id_korisnik;                    
                    Sloj_pristupa_podacima.UpravljanjeNarudzbama.UpravljanjeNarudzbamaDAL.KreirajNarudzbu(narudzba);

                    Sloj_pristupa_podacima.Usluga usluga = new Sloj_pristupa_podacima.Usluga();
                    usluga.naziv_usluge = narudzba.opis_dokumenta;
                    usluga.vrsta_usluge = 1;
                    Sloj_pristupa_podacima.Upravljanje_uslugama.UpravljanjeUslugamaDAL.KreiranjeUsluge(usluga);
                    Sloj_pristupa_podacima.Stavke_dokumenta stavke_Dokumenta = new Sloj_pristupa_podacima.Stavke_dokumenta();
                    stavke_Dokumenta.usluga = Sloj_pristupa_podacima.Upravljanje_uslugama.UpravljanjeUslugamaDAL.VratiZadnjiUnos(usluga.naziv_usluge).id_usluga;
                    stavke_Dokumenta.dokument = Sloj_pristupa_podacima.UpravljanjeNarudzbama.UpravljanjeNarudzbamaDAL.VratiZadnjiRacun(narudzba).id_dokument;
                    stavke_Dokumenta.artikl = artikl.id_artikl;
                    Sloj_pristupa_podacima.UpravljanjeNarudzbama.UpravljanjeNarudzbamaDAL.KreiranjeStavkeDokumenta(stavke_Dokumenta);

                    Sloj_pristupa_podacima.Obavijest obavijest = new Sloj_pristupa_podacima.Obavijest();
                    obavijest.Korisnik = korisnik.id_korisnik;
                    obavijest.Naslov = "Kreirana narudzba";
                    obavijest.Opis = narudzba.opis_dokumenta;
                    obavijest.Procitano = 0;
                    obavijest.Vrijeme_kreiranja = DateTime.Now;
                    obavijest.Zaposlenik = Sesija.PrijavljenKorisnik.id_korisnik;
                    Sloj_pristupa_podacima.UpravljanjeObavijestima.UpravljanjeObavijestimaDAL.KreirajObavijest(obavijest);
                    Mailer.PosaljiObavijestNaMail(korisnik, narudzba.opis_dokumenta, "Kreirana narudzba");
                }
                catch (Exception)
                {
                    MessageBox.Show("Mail nije poslan!");
                }
            };
            btnNaruci.Location = new Point(INITIAL_HORIZ + 400, INITIAL_VERT + VERT_SPACE);
            INITIAL_VERT += VERT_SPACE;
            forma.Controls.Add(lblNaziv);
            sveKontrolePredikcije.Add(lblNaziv);
            forma.Controls.Add(lblDatum);
            sveKontrolePredikcije.Add(lblDatum);
            forma.Controls.Add(btnNaruci);
            sveKontrolePredikcije.Add(btnNaruci);
        }
        private static bool ProvjeriDaLiJeMoguceNaruciti(string datum)
        {
            if (DateTime.Now >= DateTime.Parse(datum))
            {
                return true;
            }
            else
                return false;
        }
        public static List<Control> DohvatiSveKontrole()
        {
            return sveKontrolePredikcije;
        }
        public static void ResetirajVarijablePozicioniranja()
        {
            VERT_SPACE = 30;
            INITIAL_VERT = 0;
            HORIZ_SPACE = 230;
            INITIAL_HORIZ = 20;
        }
    }
}
