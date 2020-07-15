using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sloj_poslovne_logike.UpravljanjeSkladistem
{
    public class ParserSkladista
    {
        public static List<Skladiste> ParsirajSkladista()
        {
            List<Skladiste> skladistes = new List<Skladiste>();
            foreach (var item in Sloj_pristupa_podacima.UpravljanjeSkladistem.UpravljanjeSkladistemDAL.DohvatiSkladisteKorisnika(Sesija.PrijavljenKorisnik))
            {
                Skladiste s = new Skladiste();
                s.id_skladiste = item.id_skladiste;
                s.naziv = item.naziv;
                s.adresa = item.adresa;
                skladistes.Add(s);
            }
            return skladistes;
        }
    }
}
