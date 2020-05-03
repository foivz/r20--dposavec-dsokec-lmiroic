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

        public static string HashirajLozinku(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
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
            using(var db=new CarDealershipandServiceEntities())
            {
                var dohvaceniKorisnik = from k in db.Korisniks
                                        where k.korisnicko_ime == korisnickoIme && k.lozinka == lozinka
                                        select k;
                pronadenKorisnik = dohvaceniKorisnik as Korisnik;
            }
            return pronadenKorisnik;
        }
    }
}
