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
        public static void KreirajPoslovnicu(Poslovnica poslovnica)
        {
            using (var db = new CarDealershipandServiceEntities())
            {
                db.Poslovnicas.Add(poslovnica);
                db.SaveChanges();
            }
        }
        public static void BrisanjePoslovnice(Poslovnica poslovnica)
        {
            using (var db = new CarDealershipandServiceEntities())
            {
                var selectedItem = db.Poslovnicas.Where(p => p.id_poslovnica == poslovnica.id_poslovnica).FirstOrDefault();
                db.Poslovnicas.Remove(selectedItem);
                db.SaveChanges();
            }
        }

        public static void AzurirajPoslovnicu(Poslovnica poslovnica)
        {
            int id_poslovnice = poslovnica.id_poslovnica;
            using (var db = new CarDealershipandServiceEntities())
            {
                Poslovnica novaPoslovnica = (from p in db.Poslovnicas
                                      where p.id_poslovnica == id_poslovnice
                                      select p).SingleOrDefault();
                db.Poslovnicas.Attach(novaPoslovnica);
                novaPoslovnica.id_poslovnica = poslovnica.id_poslovnica;
                novaPoslovnica.naziv_poslovnice = poslovnica.naziv_poslovnice;
                novaPoslovnica.adresa_poslovnice = poslovnica.adresa_poslovnice;
                novaPoslovnica.OIB_poslovnice = poslovnica.OIB_poslovnice;
                db.SaveChanges();
            }
        }
    }
}
