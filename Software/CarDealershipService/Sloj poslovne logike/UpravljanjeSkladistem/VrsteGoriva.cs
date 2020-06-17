using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sloj_poslovne_logike.UpravljanjeSkladistem
{
    public class VrsteGoriva
    {
        public int Gorivo { get; set; }
        public string VrstaGoriva { get; set; }

        public static List<VrsteGoriva> SveVrsteGoriva = new List<VrsteGoriva>();
        public VrsteGoriva()
        {
            
        }
        public override string ToString()
        {
            return this.VrstaGoriva;
        }


    }
}
