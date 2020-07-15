using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sloj_poslovne_logike.UpravljanjeSkladistem
{
    public class ParserArtikla
    {
        public static List<Artikl> ParsirajArtikl()
        {
            List<Artikl> artikli = new List<Artikl>();
            foreach (var item in Sloj_pristupa_podacima.UpravljanjeSkladistem.UpravljanjeSkladistemDAL.DohvatiArtiklePoslovnice(Sesija.PrijavljenKorisnik))
            {
                Artikl a = new Artikl();
                a.naziv_artikla = item.naziv_artikla;
                a.cijena_artikla = item.cijena_artikla;
                a.emisija_vozila = item.emisija_vozila;
                a.godina_proizvodnje = item.godina_proizvodnje;
                a.id_artikl = item.id_artikl;
                a.minimalna_kolicina = item.minimalna_kolicina;
                a.opis_artikla = item.opis_artikla;
                a.snaga_vozila = item.snaga_vozila;
                a.vrijeme_dostave = item.vrijeme_dostave;
                a.vrsta_artikla = item.vrsta_artikla;
                a.vrsta_goriva = item.vrsta_goriva;
                artikli.Add(a);
            }
            return artikli;
        }
    }
}
