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
            using (var db = new CarDealershipandServiceEntities())
            {

                db.Artikls.Add(artikl);
                db.SaveChanges();
            }
        }
        public static void BrisanjeArtikla(Artikl artikl)
        {
            using (var db = new CarDealershipandServiceEntities())
            {
                var selectedItem = db.Artikls.Where(t => t.id_artikl == artikl.id_artikl).FirstOrDefault();
                db.Artikls.Remove(selectedItem);
                db.SaveChanges();
            }
        }
        public static void AzurirajArtikl(Artikl artikl)
        {
            using (var db = new CarDealershipandServiceEntities())
            {
                var selectedItem = db.Artikls.Where(t => t.id_artikl == artikl.id_artikl).FirstOrDefault();
                db.Artikls.Attach(selectedItem);
                db.SaveChanges();
            }
        }
    }
}
