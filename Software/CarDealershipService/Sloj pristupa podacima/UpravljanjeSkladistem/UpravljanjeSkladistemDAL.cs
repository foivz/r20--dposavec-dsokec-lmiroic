using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sloj_pristupa_podacima.UpravljanjeSkladistem
{
    public class UpravljanjeSkladistemDAL
    {
        public static List<Artikl> VratiSveArtikle()
        {
            List<Artikl> SviArtikli = null;
            using (var db = new CarDealershipandServiceEntities())
            {
                SviArtikli = db.Artikls.ToList();
            }
            return SviArtikli;
        }
        public static List<Vrste_artikla> VratiSveVrsteArtikla()
        {
            List<Vrste_artikla> SveVrsteArtikla = null;
            using (var db = new CarDealershipandServiceEntities())
            {
                SveVrsteArtikla = db.Vrste_artikla.ToList();
            }
            return SveVrsteArtikla;
        }
        public static void KreiranjeArtikla(Artikl artikl)
        {
            using (var db = new Sloj_pristupa_podacima.CarDealershipandServiceEntities())
            {

                db.Artikls.Add(artikl);
                db.SaveChanges();
            }
        }
    }
}
