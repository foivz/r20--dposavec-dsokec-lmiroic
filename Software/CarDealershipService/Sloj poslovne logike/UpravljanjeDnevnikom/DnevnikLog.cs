using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sloj_pristupa_podacima;

namespace Sloj_poslovne_logike.UpravljanjeDnevnikom
{
    public class DnevnikLog
    {
        public static void ZapisiZapis(RadnjaDnevnika radnja)
        {
            Dnevnik_rada dnevnik = PopuniPodatkeDnevnika(radnja);
            Sloj_pristupa_podacima.UpravljanjeDnevnikom.UpravljanjeDnevnikomRada.DodajNoviZapis(dnevnik);
        }
        private static Dnevnik_rada PopuniPodatkeDnevnika(RadnjaDnevnika radnja)
        {
            Dnevnik_rada dnevnik = new Dnevnik_rada();
            dnevnik.korisnik = Sesija.PrijavljenKorisnik.id_korisnik;
            dnevnik.datum_obavljanja_rada = DateTime.Now;
            switch (radnja)
            {
                case RadnjaDnevnika.PRIJAVA_U_SUSTAV:
                    dnevnik.opis_rada = "Prijava u sustav";
                    dnevnik.radnja_dnevnika = (int)radnja;
                    break;
                case RadnjaDnevnika.ODJAVA_IZ_SUSTAVA:
                    dnevnik.opis_rada = "Odjava iz sustav";
                    dnevnik.radnja_dnevnika = (int)radnja;
                    break;
                case RadnjaDnevnika.KREIRANA_POSLOVNICA:
                    dnevnik.opis_rada = "Kreirana nova poslovnica";
                    dnevnik.radnja_dnevnika = (int)radnja;
                    break;
                case RadnjaDnevnika.KREIRANA_REZERVACIJA:
                    dnevnik.opis_rada = "Kreirana nova rezervacija";
                    dnevnik.radnja_dnevnika = (int)radnja;
                    break;
                case RadnjaDnevnika.KREIRANO_SKLADISTE:
                    dnevnik.opis_rada = "Kreirano novo skladiste";
                    dnevnik.radnja_dnevnika = (int)radnja;
                    break;
                case RadnjaDnevnika.KREIRANA_NARUDZBA:
                    dnevnik.opis_rada = "Kreirana nova narudzba";
                    dnevnik.radnja_dnevnika = (int)radnja;
                    break;
                case RadnjaDnevnika.KREIRANJE_VOZILA:
                    dnevnik.opis_rada = "Kreirano novo vozilo";
                    dnevnik.radnja_dnevnika = (int)radnja;
                    break;
                case RadnjaDnevnika.KREIRANJE_REZERVNOG_DIJELA:
                    dnevnik.opis_rada = "Kreiran novi rezervni";
                    dnevnik.radnja_dnevnika = (int)radnja;
                    break;
                case RadnjaDnevnika.BRISANJE_ARTIKLA:
                    dnevnik.opis_rada = "Izbrisan artikl";
                    dnevnik.radnja_dnevnika = (int)radnja;
                    break;
                case RadnjaDnevnika.BRISANJE_KORISNIKA:
                    dnevnik.opis_rada = "Izbrisan korisnik";
                    dnevnik.radnja_dnevnika = (int)radnja;
                    break;
                case RadnjaDnevnika.BRISANJE_NARUDZBE:
                    dnevnik.opis_rada = "Izbrisana narudzba";
                    dnevnik.radnja_dnevnika = (int)radnja;
                    break;
                case RadnjaDnevnika.BRISANJE_POSLOVNICE:
                    dnevnik.opis_rada = "Izbrisana poslovnica";
                    dnevnik.radnja_dnevnika = (int)radnja;
                    break;
                case RadnjaDnevnika.BRISANJE_REZERVACIJE:
                    dnevnik.opis_rada = "Izbrisana rezervacija";
                    dnevnik.radnja_dnevnika = (int)radnja;
                    break;
                case RadnjaDnevnika.AZURIRAJ_KORISNIKA:
                    dnevnik.opis_rada = "Azuriran korisnik";
                    dnevnik.radnja_dnevnika = (int)radnja;
                    break;
                case RadnjaDnevnika.AZURIRAJ_NARUDZBU:
                    dnevnik.opis_rada = "Azurirana narudzba";
                    dnevnik.radnja_dnevnika = (int)radnja;
                    break;
                case RadnjaDnevnika.AZURIRAJ_POSLOVNICU:
                    dnevnik.opis_rada = "Azurirana poslovnica";
                    dnevnik.radnja_dnevnika = (int)radnja;
                    break;
                case RadnjaDnevnika.AZURIRAJ_REZERVACIJU:
                    dnevnik.opis_rada = "Azurirana rezervacija";
                    dnevnik.radnja_dnevnika = (int)radnja;
                    break;
                case RadnjaDnevnika.AZURIRAJ_ARTIKL:
                    dnevnik.opis_rada = "Azuriran artikl";
                    dnevnik.radnja_dnevnika = (int)radnja;
                    break;
            }
            return dnevnik;
        }
    }
}
