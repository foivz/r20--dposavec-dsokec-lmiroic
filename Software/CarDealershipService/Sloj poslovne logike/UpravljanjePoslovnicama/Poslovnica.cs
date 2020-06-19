using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sloj_poslovne_logike.UpravljanjePoslovnicama
{
    public class Poslovnica:Sloj_pristupa_podacima.Poslovnica
    {
        public override string ToString()
        {
            return naziv_poslovnice;
        }
    }
}
