using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sloj_poslovne_logike.UpravljanjeSkladistem
{
    class VrstaArtikla:Sloj_pristupa_podacima.Vrste_artikla
    {
        public override string ToString()
        {
            return naziv;
        }
    }
}
