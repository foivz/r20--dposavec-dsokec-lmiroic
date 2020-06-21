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
        public static void KreiranjeArtikla(Artikl artikl,Korisnik korisnik)
        {
            List<Skladiste> listaSkladista = DohvatiSkladisteKorisnika(korisnik);
            Artikli_na_skladistu artikli_Na_Skladistu = new Artikli_na_skladistu();
            using (var db = new CarDealershipandServiceEntities())
            {
                db.Artikls.Add(artikl);
                foreach (var item in listaSkladista)
                {
                    artikli_Na_Skladistu.skladiste = item.id_skladiste;
                    
                }
                artikli_Na_Skladistu.artikl = artikl.id_artikl;
                artikli_Na_Skladistu.kolicina = 1;
                db.Artikli_na_skladistu.Add(artikli_Na_Skladistu);
                db.SaveChanges();
            }
        }
        public static void BrisanjeArtikla(Artikl artikl)
        {
            using (var db = new CarDealershipandServiceEntities())
            {
                var selectedItem = db.Artikls.Where(t => t.id_artikl == artikl.id_artikl).FirstOrDefault();
                var selectedItem1 = db.Artikli_na_skladistu.Where(x => x.artikl == artikl.id_artikl).FirstOrDefault();
                db.Artikls.Remove(selectedItem);
                db.Artikli_na_skladistu.Remove(selectedItem1);
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
        public static List<Skladiste> DohvatiSkladisteKorisnika(Korisnik korisnik)
        {
            List<Skladiste> SkladisteKorisnika = null;
            using(var db=new CarDealershipandServiceEntities())
            {
                var skladiste = from s in db.Skladistes
                                from sp in db.Skladiste_poslovnice
                                where korisnik.poslovnica == sp.poslovnica && sp.skladiste == s.id_skladiste
                                select s;
                SkladisteKorisnika = skladiste.ToList();
            }
            return SkladisteKorisnika;
        }
    }
}
