using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sloj_poslovne_logike.UpravljanjeRezervacijama
{
    public class Korisnik:Sloj_pristupa_podacima.Korisnik
    {       
     
        public override string ToString()
        {
            return this.ime_korisnika;
        }
    }
}
