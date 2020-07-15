using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Sloj_pristupa_podacima.UpravljanjeObavijestima
{
    public class UpravljanjeObavijestimaDAL
    {
        public static bool ProvjeraPostojanostiObavijestiKorisnika(Korisnik korisnik)
        {
            return ProslijediSveNeprocitaneObavijesti(korisnik).Count > 0 ? true : false;
        }
        public static List<Obavijest> ProslijediSveNeprocitaneObavijesti(Korisnik korisnik)
        {
            List<Obavijest> neprocitaneObavijesti = new List<Obavijest>();
            using (var db = new CarDealershipandServiceEntities())
            {
                var obavijest = from o in db.Obavijests
                                where o.Korisnik == korisnik.id_korisnik && o.Procitano == 0
                                select o;
                neprocitaneObavijesti = obavijest.ToList();
            }
            return neprocitaneObavijesti;
        }
        public static void ProcitajObavijesti(List<Obavijest> obavijesti)
        {
            using (var db = new CarDealershipandServiceEntities())
            {
                foreach (var item in obavijesti)
                {
                    Obavijest obavijest = (from o in db.Obavijests
                                           where o.Id == item.Id
                                           select o).SingleOrDefault();
                    db.Obavijests.Attach(obavijest);
                    obavijest.Procitano = 1;
                }
                db.SaveChanges();
            }
        }
        public static void KreirajObavijest(Obavijest obavijest)
        {
            using(var db= new CarDealershipandServiceEntities())
            {
                db.Obavijests.Add(obavijest);
                db.SaveChanges();
            }
        }
    }
}
