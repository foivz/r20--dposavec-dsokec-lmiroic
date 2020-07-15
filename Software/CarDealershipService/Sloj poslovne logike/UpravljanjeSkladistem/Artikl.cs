using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sloj_poslovne_logike.UpravljanjeSkladistem
{
    public class Artikl:Sloj_pristupa_podacima.Artikl
    {
        public override string ToString()
        {
            return this.naziv_artikla;
        }
    }
}
