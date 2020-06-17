using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sloj_poslovne_logike.UpravljanjeSkladistem
{
    class ParserVrsteArtikla
    {
        public static List<VrstaArtikla> ParsirajVrsteArtikla()
        {
            List<VrstaArtikla> vrsteArtikla = new List<VrstaArtikla>();
            foreach (var item in Sloj_pristupa_podacima.UpravljanjeSkladistem.UpravljanjeSkladistemDAL.VratiSveVrsteArtikla())
            {
                VrstaArtikla v = new VrstaArtikla();
                v.id_vrste_artikla = item.id_vrste_artikla;
                v.naziv = item.naziv;
                v.Artikls = item.Artikls;
                vrsteArtikla.Add(v);
            }
            return vrsteArtikla;
        }
    }
}
