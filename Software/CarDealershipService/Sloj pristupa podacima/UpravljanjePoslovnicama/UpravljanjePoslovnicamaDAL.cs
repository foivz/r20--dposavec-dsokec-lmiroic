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
        
        public static void KreiranjeSkladištaPoslovnice(Skladiste skladiste,Korisnik korisnik)
        {
            List<Poslovnica> listaPoslovnica = DohvatiPoslovnicuKorisnika(korisnik);
            Skladiste_poslovnice skladiste_Poslovnice = new Skladiste_poslovnice();
            using (var db=new CarDealershipandServiceEntities())
            {            
                db.Skladistes.Add(skladiste);
                foreach (var item in listaPoslovnica)
                {
                    skladiste_Poslovnice.poslovnica = item.id_poslovnica;
                }
                skladiste_Poslovnice.skladiste = skladiste.id_skladiste;
                db.Skladiste_poslovnice.Add(skladiste_Poslovnice);
                db.SaveChanges();

            }
        }
        public static List<Poslovnica>DohvatiPoslovnicuKorisnika(Korisnik korisnik)
        {
            List<Poslovnica> poslovnicaKorisnika = null;
            using(var db=new CarDealershipandServiceEntities())
            {
                var poslovnica = from p in db.Poslovnicas
                                 where p.id_poslovnica == korisnik.poslovnica
                                 select p;
                poslovnicaKorisnika = poslovnica.ToList();
            }
            return poslovnicaKorisnika;

        }
    }
}
