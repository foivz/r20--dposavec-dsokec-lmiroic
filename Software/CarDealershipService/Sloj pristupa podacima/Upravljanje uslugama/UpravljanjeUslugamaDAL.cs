using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sloj_pristupa_podacima.Upravljanje_uslugama
{
    public class UpravljanjeUslugamaDAL
    {
        public static void KreiranjeUsluge(Usluga usluga)
        {
            Boolean unos = false;
            using (var db = new CarDealershipandServiceEntities())
            {
                foreach (var item in db.Uslugas)
                {
                    if (usluga.naziv_usluge.ToLower().Equals(item.naziv_usluge.ToLower()))
                    {
                        unos = true;
                    }
                    else
                    {                        
                        unos = false;
                    }                        
                }
                if (!unos)
                {
                    db.Uslugas.Add(usluga);
                }
                db.SaveChanges();
            }
        }
        public static Usluga VratiZadnjiUnos(string naziv)
        {
           
            using (var db = new CarDealershipandServiceEntities())
            {
                foreach (var item in db.Uslugas)
                {
                    if (naziv.ToLower().Equals(item.naziv_usluge.ToLower()))
                    {
                        return item as Usluga;
                    }
                }
                return null;
                
            }
        }
    }
}
