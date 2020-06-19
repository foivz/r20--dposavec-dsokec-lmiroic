using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sloj_poslovne_logike.UpravljanjeKorisnicima
{
    public class TipKorisnika:Sloj_pristupa_podacima.Tip_korisnika
    {
        public override string ToString()
        {
            return naziv_uloge;
        }
    }
}
