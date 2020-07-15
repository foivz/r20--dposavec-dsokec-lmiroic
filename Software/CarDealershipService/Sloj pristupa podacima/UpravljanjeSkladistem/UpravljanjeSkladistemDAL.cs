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
        public static void KreiranjeArtikla(Artikl artikl,Skladiste skladiste,int kolicina)
        {
            Artikli_na_skladistu artikli_Na_Skladistu = new Artikli_na_skladistu();
            using (var db = new CarDealershipandServiceEntities())
            {
                db.Artikls.Add(artikl);
                artikli_Na_Skladistu.skladiste = skladiste.id_skladiste;
                artikli_Na_Skladistu.artikl = artikl.id_artikl;
                artikli_Na_Skladistu.kolicina = kolicina;
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
                artikl1.minimalna_kolicina = artikl.minimalna_kolicina;
                artikl1.vrijeme_dostave = artikl.vrijeme_dostave;
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
        public static List<Artikl> DohvatiUnikatneArtiklePoslovnice(Korisnik korisnik)
        {
            List<Artikl> ArtikliNaSkladistu = null;
            using (var db = new CarDealershipandServiceEntities())
            {
                var artikli = from sp in db.Skladiste_poslovnice
                              from s in db.Skladistes
                              from artS in db.Artikli_na_skladistu
                              from a in db.Artikls
                              where sp.poslovnica == korisnik.poslovnica && artS.skladiste == s.id_skladiste && artS.artikl == a.id_artikl && sp.skladiste == s.id_skladiste
                              select a;
                ArtikliNaSkladistu = artikli.Distinct().ToList();
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
        public static List<Skladiste> DohvatiSkladistePoslovnice(Poslovnica poslovnica)
        {
            List<Skladiste> SkladistePoslovnice = null;
            using (var db = new CarDealershipandServiceEntities())
            {
                var skladiste = from s in db.Skladistes
                                from sp in db.Skladiste_poslovnice
                                where poslovnica.id_poslovnica == sp.poslovnica && sp.skladiste == s.id_skladiste
                                select s;
                SkladistePoslovnice = skladiste.ToList();
            }
            return SkladistePoslovnice;
        }
        public static void ProdajaArtikla(List<Artikl> artikli)
        {
            using (var db = new CarDealershipandServiceEntities())
            {
                foreach (var item in artikli)
                {
                    Artikli_na_skladistu artiklNaSkladistu = (from a in db.Artikli_na_skladistu
                                      where a.artikl == item.id_artikl
                                      select a).SingleOrDefault();
                    db.Artikli_na_skladistu.Attach(artiklNaSkladistu);
                    artiklNaSkladistu.kolicina = artiklNaSkladistu.kolicina - 1;

                    
                }                
                db.SaveChanges();
            }
        }

        public static bool ProvjeraDostupnostiArtikla(Artikl artikl)
        {
            using (var db = new CarDealershipandServiceEntities())
            {
                Artikli_na_skladistu artiklNaSkladistu = (from a in db.Artikli_na_skladistu
                                                          where a.artikl == artikl.id_artikl
                                                          select a).SingleOrDefault();
                if (artiklNaSkladistu.kolicina > 0)
                {
                    return true;
                }
                else
                    return false;
            }
        }
        public static void BrisanjeSkladista(Skladiste skladiste)
        {
            using(var db=new CarDealershipandServiceEntities())
            {
                BrisanjeArtikalaSaSkladista(skladiste);
                BrisanjeSkladistaPoslovnice(skladiste);
                var selectedItem = db.Skladistes.Where(s => s.id_skladiste == skladiste.id_skladiste).FirstOrDefault();
                db.Skladistes.Remove(selectedItem);
                db.SaveChanges();
            }
        }
        public static void BrisanjeArtikalaSaSkladista(Skladiste skladiste)
        {
           
            using (var db = new CarDealershipandServiceEntities())
            {
                List<Artikli_na_skladistu> artikliNaSkladistu = (from a in db.Artikli_na_skladistu
                                                          where a.skladiste == skladiste.id_skladiste
                                                          select a).ToList();
                foreach (var item in artikliNaSkladistu)
                {
                    db.Artikli_na_skladistu.Remove(item);
                }
                db.SaveChanges();
            }
        }
        public static void BrisanjeSkladistaPoslovnice(Skladiste skladiste)
        {
            using (var db = new CarDealershipandServiceEntities())
            {
                var selectedItem = db.Skladiste_poslovnice.Where(sp => sp.skladiste == skladiste.id_skladiste).FirstOrDefault();
                db.Skladiste_poslovnice.Remove(selectedItem);
                db.SaveChanges();
            }
        }
        public static List<Artikl> DohvatiProdaneArtikle()
        {
            List<Artikl> prodaniArtikli = null;
            using (var db = new CarDealershipandServiceEntities())
            {
                var artikli = from a in db.Artikls
                              from sd in db.Stavke_dokumenta
                              where sd.artikl == a.id_artikl
                              select a;
                prodaniArtikli = artikli.Distinct().ToList();
            }
            return prodaniArtikli;
        }
        public static int BrojProdanihArtikala(Artikl artikl)
        {
            int brojac = 0;
            using (var db = new CarDealershipandServiceEntities())
            {
                brojac = (from sd in db.Stavke_dokumenta
                          where sd.artikl == artikl.id_artikl
                          select sd).ToList().Count;
            }
            return brojac;
        }
        public static int BrojRacunaProdanogArtikala(Artikl artikl)
        {
            int brojac = 0;
            using (var db = new CarDealershipandServiceEntities())
            {
                brojac = (from sd in db.Stavke_dokumenta
                          from d in db.Dokuments
                          where sd.artikl == artikl.id_artikl&&d.tip_dokumenta==1&&sd.dokument==d.id_dokument
                          select sd).Distinct().ToList().Count;
            }
            return brojac;
        }
        public static Artikl DohvatiArtikl(int id)
        {
            Artikl artikl = new Artikl();
            using (var db = new CarDealershipandServiceEntities())
            {
                artikl = (from a in db.Artikls
                          where a.id_artikl == id
                          select a).ToList().FirstOrDefault();
            }
            return artikl;
        }
        public static List<Stavke_dokumenta> DohvatiStavkeDokumentaOdabranogArtikla(Artikl artikl,int brojDana)
        {
            List<Stavke_dokumenta> stavkeArtikla = null;
            DateTime datum = DateTime.Now.AddDays(-brojDana);
            using (var db = new CarDealershipandServiceEntities())
            {

                var stavkaArtikla = from sd in db.Stavke_dokumenta
                                    from d in db.Dokuments
                              where sd.artikl == artikl.id_artikl&&sd.dokument==d.id_dokument&&d.datum_izdavanja>=datum&&d.tip_dokumenta==1
                              select sd;
                stavkeArtikla = stavkaArtikla.Distinct().ToList();
            }
            return stavkeArtikla;
        }
        public static List<Artikli_na_skladistu> DohvatiSveArtikleNaSkladistu()
        {
            List<Artikli_na_skladistu> artikli = new List<Artikli_na_skladistu>();
            using (var db = new CarDealershipandServiceEntities())
            {
                artikli = db.Artikli_na_skladistu.ToList();
            }
            return artikli;
        }
        public static Dokument DohvatiDokument(int id)
        {
            Dokument dokument = new Dokument();
            using (var db = new CarDealershipandServiceEntities())
            {
                dokument = (from d in db.Dokuments
                          where  d.id_dokument== id
                          select d).ToList().FirstOrDefault();
            }
            return dokument;
        }
        public static List<Artikli_na_skladistu> DohvatiSveProdaneArtikleNaSkladistu(Korisnik korisnik)
        {
            List<Artikli_na_skladistu> artikli = new List<Artikli_na_skladistu>();
            using (var db = new CarDealershipandServiceEntities())
            {
                artikli = (from ans in db.Artikli_na_skladistu
                           from sd in db.Stavke_dokumenta
                           from d in db.Dokuments
                           where ans.artikl == sd.artikl && sd.dokument == d.id_dokument && d.tip_dokumenta == 1&&d.zaposlenik==korisnik.id_korisnik
                           select ans).Distinct().ToList();
            }
            return artikli;
        }
    }
}
