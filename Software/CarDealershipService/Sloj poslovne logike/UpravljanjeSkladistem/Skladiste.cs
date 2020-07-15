using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sloj_poslovne_logike.UpravljanjeSkladistem
{
    public class Skladiste:Sloj_pristupa_podacima.Skladiste
    {
        public override string ToString()
        {
            return this.naziv;
        }
    }
}
