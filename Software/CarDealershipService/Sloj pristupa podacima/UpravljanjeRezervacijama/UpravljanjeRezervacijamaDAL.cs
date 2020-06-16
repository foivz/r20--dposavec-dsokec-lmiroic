using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sloj_pristupa_podacima.UpravljanjeRezervacijama
{
    public class UpravljanjeRezervacijamaDAL
    {
        public static List<Dokument> DohvatiSveRezervacije()
        {
            List<Dokument> SveRezervacije = null;
            using (var db = new CarDealershipandServiceEntities())
            {
                var DohvacenaRezervacija = from r in db.Dokuments
                                           where r.tip_dokumenta == 4
                                           select r;
                SveRezervacije = DohvacenaRezervacija.ToList();
            }
            return SveRezervacije;
        }

    }
}
