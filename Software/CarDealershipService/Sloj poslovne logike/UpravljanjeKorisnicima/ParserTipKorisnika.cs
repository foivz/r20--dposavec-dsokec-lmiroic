using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sloj_poslovne_logike.UpravljanjeKorisnicima
{
    public class ParserTipKorisnika
    {
        public static List<TipKorisnika> ParsirajTipKorisnika()
        {
            List<TipKorisnika> tipKorisnikas = new List<TipKorisnika>();
            foreach (var item in Sloj_pristupa_podacima.UpravljanjeKorisnicima.UpravljanjeKorisnicima.DohvatiSveTipoveKorisnika())
            {
                TipKorisnika tip = new TipKorisnika();
                tip.id_tip_korisnika = item.id_tip_korisnika;
                tip.naziv_uloge = item.naziv_uloge;
                tipKorisnikas.Add(tip);
            }
            return tipKorisnikas;
        }
    }
}
