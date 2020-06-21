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

        public static void KreirajRezervaciju(Dokument rezervacija)
        {
            using(var db = new CarDealershipandServiceEntities())
            {
                db.Dokuments.Add(rezervacija);
                db.SaveChanges();
            }
        }
        public static void BrisanjeRezervacije(Dokument dokument)
        {
            using(var db=new CarDealershipandServiceEntities())
            {
                var selectedItem = db.Dokuments.Where(d => d.id_dokument == dokument.id_dokument).FirstOrDefault();
                db.Dokuments.Remove(selectedItem);
                db.SaveChanges();
            }
        }
        public static void AzurirajRezervaciju(Dokument dokument)
        {
            int id_dokument = dokument.id_dokument;
            using (var db = new CarDealershipandServiceEntities())
            {
                Dokument dokumenti = (from d in db.Dokuments
                                     where d.id_dokument == id_dokument
                                     select d).SingleOrDefault();
                db.Dokuments.Attach(dokumenti);
                dokumenti.id_dokument = dokument.id_dokument;
                dokumenti.datum_izdavanja = dokument.datum_izdavanja;
                dokumenti.opis_dokumenta = dokument.opis_dokumenta;
                dokumenti.korisnik = dokument.korisnik;
                dokumenti.zaposlenik = dokument.zaposlenik;
                db.SaveChanges();
            }
        }
        public static List<Dokument> DohvatiSverezervacijePoslovnice(Korisnik korisnik)
        {
            List<Dokument> DokumentUPoslovnici = null;
            using (var db = new CarDealershipandServiceEntities())
            {
                var rezervacija = from d in db.Dokuments
                                  from ps in db.Poslovnicas
                              where d.zaposlenik==korisnik.id_korisnik && ps.id_poslovnica==korisnik.poslovnica && d.tip_dokumenta==4
                              select d;
                DokumentUPoslovnici = rezervacija.ToList();
            }
            return DokumentUPoslovnici;
        }

    }
}
