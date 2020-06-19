using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sloj_pristupa_podacima.UpravljanjeNarudzbama
{
    public class UpravljanjeNarudzbamaDAL
    {
        public static List<Dokument> DohvatiSveNarudzbe()
        {
            List<Dokument> SveNarudzbe = null;
            using (var db = new CarDealershipandServiceEntities())
            {
                var DohvacenaNarudzba = from n in db.Dokuments
                                           where n.tip_dokumenta == 4
                                           select n;
                SveNarudzbe = DohvacenaNarudzba.ToList();
            }
            return SveNarudzbe;
        }
    }
}
