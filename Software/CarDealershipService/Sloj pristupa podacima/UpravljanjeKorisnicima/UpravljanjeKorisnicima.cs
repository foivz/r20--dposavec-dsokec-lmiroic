using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Sloj_pristupa_podacima.UpravljanjeKorisnicima
{
    public class UpravljanjeKorisnicima
    {
        public static List<Korisnik> DohvatiSveKorisnike()
        {
            List<Korisnik> SviKorisnici = null;
            using (var db = new CarDealershipandServiceEntities())
            {
                SviKorisnici = db.Korisniks.ToList();
            }
            return SviKorisnici;
        }
        public static List<Tip_korisnika> DohvatiSveTipoveKorisnika()
        {
            List<Tip_korisnika> SviTipoviKorisnika = null;
            using (var db = new CarDealershipandServiceEntities())
            {
                SviTipoviKorisnika = db.Tip_korisnika.ToList();
            }
            return SviTipoviKorisnika;
        }

        public static string HashirajLozinku(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2"));
                }

                return sb.ToString();
            }
        }
        public static bool ProvjeriKorisnika(string korisnickoIme, string lozinka)
        {
            Korisnik odabranKorisnik = null;
            odabranKorisnik= DohvatiSveKorisnike().Find(k => k.korisnicko_ime == korisnickoIme && k.lozinka == HashirajLozinku(lozinka));
            if (odabranKorisnik != null)
                return true;
            else
                return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="korisnickoIme"></param>
        /// <param name="lozinka"></param>
        /// <returns></returns>
        public static Korisnik DohvatiKorisnika(string korisnickoIme,string lozinka)
        {
            Korisnik pronadenKorisnik = null;
            pronadenKorisnik = DohvatiSveKorisnike().Find(k => k.korisnicko_ime == korisnickoIme && k.lozinka == HashirajLozinku(lozinka));
            return pronadenKorisnik;
        }
        public static void KreiranjeKorisnika(Korisnik korisnik)
        {
            using (var db = new CarDealershipandServiceEntities())
            {
                db.Korisniks.Add(korisnik);
                db.SaveChanges();
            }
        }
        public static void BrisanjeKorisnika(Korisnik korisnik)
        {
            using (var db = new CarDealershipandServiceEntities())
            {
                var selectedItem = db.Korisniks.Where(t => t.id_korisnik == korisnik.id_korisnik).FirstOrDefault();
                db.Korisniks.Remove(selectedItem);
                db.SaveChanges();
            }
        }
        public static void AzurirajKorisnika(Korisnik korisnik)
        {
            int id_korisnik = korisnik.id_korisnik;
            using (var db = new CarDealershipandServiceEntities())
            {
                Korisnik noviKorisnik = (from k in db.Korisniks
                                      where k.id_korisnik == id_korisnik
                                      select k).SingleOrDefault();
                db.Korisniks.Attach(noviKorisnik);
                noviKorisnik.id_korisnik = korisnik.id_korisnik;
                noviKorisnik.ime_korisnika = korisnik.ime_korisnika;
                noviKorisnik.prezime_korisnika = korisnik.prezime_korisnika;
                noviKorisnik.adresa = korisnik.adresa;
                noviKorisnik.email = korisnik.email;
                noviKorisnik.IBAN = korisnik.IBAN;
                noviKorisnik.korisnicko_ime = korisnik.korisnicko_ime;
                noviKorisnik.lozinka = korisnik.lozinka;
                noviKorisnik.tip_korisnika = korisnik.tip_korisnika;
                noviKorisnik.poslovnica = korisnik.poslovnica;
                db.SaveChanges();
            }
        }
        public static Korisnik DohvatiKorisnikovMail(Korisnik korisnik)
        {
            Korisnik pronadenKorisnik = null;
            pronadenKorisnik = DohvatiSveKorisnike().Find(k => k.email == korisnik.email && k.id_korisnik == korisnik.id_korisnik);
            return pronadenKorisnik;
        }
        public static List<Korisnik> DohvatiSveDobavljace()
        {
            List<Korisnik> SviDobavljaci = null;
            using (var db = new CarDealershipandServiceEntities())
            {
                SviDobavljaci = (from k in db.Korisniks
                                where k.tip_korisnika == 3
                                select k).ToList();
            }
            return SviDobavljaci;
        }
    }
}
