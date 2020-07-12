using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sloj_pristupa_podacima
{
    public class Konfiguracija
    {
        public static string DajPostavku(string kljuc)
        {
            return ConfigurationManager.AppSettings.Get(kljuc);
        }
    }
}
