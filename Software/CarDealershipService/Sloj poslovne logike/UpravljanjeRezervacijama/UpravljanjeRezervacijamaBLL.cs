using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sloj_poslovne_logike.UpravljanjeRezervacijama
{
    public class UpravljanjeRezervacijamaBLL
    {
        public static bool ProvjeraUnosaRezervacije(Sloj_pristupa_podacima.Dokument dokument)
        {
            if (dokument.datum_izdavanja==null|| dokument.korisnik==null || dokument.opis_dokumenta=="" || dokument.ukupni_saldo<0)
            {
                return false;
            }
            else return true;
        }
    }
}
