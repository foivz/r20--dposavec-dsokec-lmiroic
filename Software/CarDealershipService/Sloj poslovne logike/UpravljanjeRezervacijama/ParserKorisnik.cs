using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sloj_poslovne_logike.UpravljanjeRezervacijama
{
    public class ParserKorisnik
    {
        public static List<Korisnik> ParsirajKorisnika()
        {
            List<Korisnik> korisniks = new List<Korisnik>();
            foreach (var item in Sloj_pristupa_podacima.UpravljanjeKorisnicima.UpravljanjeKorisnicima.DohvatiSveKorisnike())
            {
                Korisnik k = new Korisnik();
                k.id_korisnik = item.id_korisnik;
                k.ime_korisnika = item.ime_korisnika;
                k.prezime_korisnika = item.prezime_korisnika;
                k.adresa = item.adresa;
                k.email = item.email;
                k.IBAN = item.IBAN;
                k.korisnicko_ime = item.korisnicko_ime;
                k.lozinka = item.lozinka;
                k.tip_korisnika = item.tip_korisnika;
                k.poslovnica = item.poslovnica;
                korisniks.Add(k);

            }
            return korisniks;
        }
        public static List<Korisnik> ParsirajDobavljača()
        {        
            List<Korisnik> korisniks = new List<Korisnik>();
            foreach (var item in Sloj_pristupa_podacima.UpravljanjeKorisnicima.UpravljanjeKorisnicima.DohvatiSveDobavljace())
            {
                Korisnik k = new Korisnik();
                k.id_korisnik = item.id_korisnik;
                k.ime_korisnika = item.ime_korisnika;
                k.prezime_korisnika = item.prezime_korisnika;
                k.adresa = item.adresa;
                k.email = item.email;
                k.IBAN = item.IBAN;
                k.korisnicko_ime = item.korisnicko_ime;
                k.lozinka = item.lozinka;
                k.tip_korisnika = item.tip_korisnika;
                k.poslovnica = item.poslovnica;
                korisniks.Add(k);

            }
            return korisniks;
        }
    }
}
