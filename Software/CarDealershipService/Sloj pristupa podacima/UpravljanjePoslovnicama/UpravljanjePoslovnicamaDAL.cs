using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sloj_pristupa_podacima.UpravljanjePoslovnicama
{
    public class UpravljanjePoslovnicamaDAL
    {
        public static List<Poslovnica> DohvatiSvePoslovnice()
        {
            List<Poslovnica> SvePoslovnice = null;
            using (var db = new CarDealershipandServiceEntities())
            {
                SvePoslovnice = db.Poslovnicas.ToList();
            }
            return SvePoslovnice;
        }
    }
}
