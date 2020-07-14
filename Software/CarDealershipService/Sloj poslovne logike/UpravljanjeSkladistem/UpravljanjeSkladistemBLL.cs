using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sloj_poslovne_logike.UpravljanjeSkladistem
{
    public class UpravljanjeSkladistemBLL
    {
        public static bool ProvjeraUnosaRezervnogDijela(Sloj_pristupa_podacima.Artikl artikl)
        {
            if (artikl.naziv_artikla == "" || artikl.opis_artikla == "" || artikl.cijena_artikla <= 0 || artikl.godina_proizvodnje < 1900||artikl.minimalna_kolicina<=0||artikl.vrijeme_dostave<=0)
            {
                return false;
            }
            else return true;
        }
        public static bool ProvjeraUnosaVozila(Sloj_pristupa_podacima.Artikl artikl)
        {
            if (artikl.naziv_artikla == "" || artikl.opis_artikla == "" || artikl.cijena_artikla <= 0 || artikl.godina_proizvodnje < 1900 || artikl.emisija_vozila <= 0 || artikl.snaga_vozila <= 0 || artikl.vrsta_goriva == null||artikl.minimalna_kolicina<=0||artikl.vrijeme_dostave<=0)
            {
                return false;
            }
            else return true;
        }
        
    }
}
