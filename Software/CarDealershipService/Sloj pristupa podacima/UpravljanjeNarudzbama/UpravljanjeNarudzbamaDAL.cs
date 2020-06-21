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
                                           where n.tip_dokumenta == 2
                                           select n;
                SveNarudzbe = DohvacenaNarudzba.ToList();
            }
            return SveNarudzbe;
        }
        public static void KreirajNarudzbu(Dokument narudzba)
        {
            using(var db= new CarDealershipandServiceEntities())
            {
                db.Dokuments.Add(narudzba);
                db.SaveChanges();
            }
        }        
        public static void BrisanjeNarudzbe(Dokument narudzba)
        {
            using(var db=new CarDealershipandServiceEntities())
            {
                var selectedItem = db.Dokuments.Where(d => d.id_dokument == narudzba.id_dokument).FirstOrDefault();
                db.Dokuments.Remove(selectedItem);
                db.SaveChanges();
            }
        }
        public static void AzurirajNarudzbu(Dokument narudzba)
        {
            int id_dokument = narudzba.id_dokument;
            using(var db=new CarDealershipandServiceEntities())
            {
                Dokument narudzbe = (from d in db.Dokuments
                                     where d.id_dokument == id_dokument
                                     select d).SingleOrDefault();
                db.Dokuments.Attach(narudzbe);
                narudzbe.id_dokument = narudzba.id_dokument;
                narudzbe.datum_izdavanja = narudzba.datum_izdavanja;
                narudzbe.opis_dokumenta = narudzba.opis_dokumenta;
                narudzbe.korisnik = narudzba.korisnik;
                narudzbe.zaposlenik = narudzba.zaposlenik;
                db.SaveChanges();

            }
        }
        public static List<Dokument> DohvatiSveNarudzbePoslovnice(Korisnik korisnik)
        {
            List<Dokument> NarudzbeUPoslovnici = null;
            using (var db = new CarDealershipandServiceEntities())
            {
                var narudzba = from d in db.Dokuments
                                  from ps in db.Poslovnicas
                               where d.zaposlenik == korisnik.id_korisnik && ps.id_poslovnica == korisnik.poslovnica && d.tip_dokumenta == 2
                               select d;
                NarudzbeUPoslovnici = narudzba.ToList();
            }
            return NarudzbeUPoslovnici;
        }
    }
}
