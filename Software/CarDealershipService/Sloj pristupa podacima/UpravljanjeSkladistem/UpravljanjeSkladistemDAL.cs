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
            int id_artikla = artikl.id_artikl;
            using (var db = new CarDealershipandServiceEntities())
            {
                Artikl artikl1 = (from a in db.Artikls
                                    where a.id_artikl == id_artikla
                                    select a).SingleOrDefault();
                db.Artikls.Attach(artikl1);
                artikl1.id_artikl = artikl.id_artikl;
                artikl1.godina_proizvodnje = artikl.godina_proizvodnje;
                artikl1.naziv_artikla = artikl.naziv_artikla;
                artikl1.opis_artikla = artikl.opis_artikla;
                artikl1.snaga_vozila = artikl.snaga_vozila;
                artikl1.vrsta_artikla = artikl.vrsta_artikla;
                artikl1.vrsta_goriva = artikl.vrsta_goriva;
                artikl1.cijena_artikla = artikl.cijena_artikla;
                db.SaveChanges();
            }
        }
        public static List<Artikl> DohvatiArtiklePoslovnice(Korisnik korisnik)
        {
            List<Artikl> ArtikliNaSkladistu = null;
            using(var db= new CarDealershipandServiceEntities())
            {
                var artikli = from sp in db.Skladiste_poslovnice
                              from s in db.Skladistes
                              from artS in db.Artikli_na_skladistu
                              from a in db.Artikls
                              where sp.poslovnica == korisnik.poslovnica && artS.skladiste == s.id_skladiste && artS.artikl == a.id_artikl&&sp.skladiste==s.id_skladiste
                              select a;
                ArtikliNaSkladistu = artikli.ToList();
            }
            return ArtikliNaSkladistu;
        }
    }
}
