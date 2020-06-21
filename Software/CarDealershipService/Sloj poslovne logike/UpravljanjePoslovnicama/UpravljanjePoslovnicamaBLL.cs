using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sloj_poslovne_logike.UpravljanjePoslovnicama
{
    public class UpravljanjePoslovnicamaBLL
    {
        public static bool ProvjeraUnosaPoslovnice(Sloj_pristupa_podacima.Poslovnica poslovnica)
        {
            if (poslovnica.naziv_poslovnice==""||poslovnica.OIB_poslovnice.Length!=11||poslovnica.adresa_poslovnice=="")
            {
                return false;
            }
            else
                return true;
        }
        public static bool ProvjeraUnosaSkladista(Sloj_pristupa_podacima.Skladiste skladiste)
        {
            if (skladiste.naziv == "" || skladiste.adresa == "")
            {
                return false;
            }
            else
                return true;
        }
    }
}
