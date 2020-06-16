using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sloj_poslovne_logike.UpravljanjeKorisnicima
{
    public class UpravljanjeKorisnicimaBLL
    {
        public static bool PrijaviKorisnika(string korisnickoIme, string lozinka)
        {
            bool provjera = Sloj_pristupa_podacima.UpravljanjeKorisnicima.UpravljanjeKorisnicima.ProvjeriKorisnika(korisnickoIme, lozinka);
            if (provjera)
            {
                Sesija.PrijavljenKorisnik = Sloj_pristupa_podacima.UpravljanjeKorisnicima.UpravljanjeKorisnicima.DohvatiKorisnika(korisnickoIme, lozinka);
            }
            return provjera;

        }
        public static int ProvjeriTipKorisnika()
        {
           return Sesija.PrijavljenKorisnik.tip_korisnika;       
        }
        public static bool ProvjeriUloguAdministratora()
        {
            if (ProvjeriTipKorisnika()==2)
            {
                return true;
            }
            return false;
        }
    }
}
