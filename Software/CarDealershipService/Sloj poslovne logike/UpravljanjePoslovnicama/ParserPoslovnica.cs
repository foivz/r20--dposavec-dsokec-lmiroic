using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sloj_poslovne_logike.UpravljanjePoslovnicama
{
    public class ParserPoslovnica
    {
        public static List<Poslovnica> ParsirajPoslovnicu()
        {
            List<Poslovnica> poslovnicas = new List<Poslovnica>();
            foreach (var item in Sloj_pristupa_podacima.UpravljanjePoslovnicama.UpravljanjePoslovnicamaDAL.DohvatiSvePoslovnice())
            {
                Poslovnica p = new Poslovnica();
                p.id_poslovnica = item.id_poslovnica;
                p.adresa_poslovnice = item.adresa_poslovnice;
                p.naziv_poslovnice = item.naziv_poslovnice;
                p.OIB_poslovnice = item.OIB_poslovnice;
                poslovnicas.Add(p);
            }
            return poslovnicas;
        }
    }
}
