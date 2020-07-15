using Sloj_pristupa_podacima;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sloj_poslovne_logike
{
    public class ProvjeraObavijesti
    {
        private static NotifyIcon uiNotification;
        public static int INTERVAL_PROVJERE = 10000;
        public static bool DOPUSTENA_RADNJA = true;
        public static void Start(NotifyIcon notifyIcon)
        {
            uiNotification = notifyIcon;
        }
        public static void Run()
        {
            while (DOPUSTENA_RADNJA)
            {
                if (Sloj_pristupa_podacima.UpravljanjeObavijestima.UpravljanjeObavijestimaDAL.ProvjeraPostojanostiObavijestiKorisnika(Sesija.PrijavljenKorisnik) == true)
                {
                    List<Obavijest> obavijesti = Sloj_pristupa_podacima.UpravljanjeObavijestima.UpravljanjeObavijestimaDAL.ProslijediSveNeprocitaneObavijesti(Sesija.PrijavljenKorisnik);
                    UpravljanjeObavijestima.WindowsObavijesti.PrikaziSveObavijesti(uiNotification, obavijesti);
                    Sloj_pristupa_podacima.UpravljanjeObavijestima.UpravljanjeObavijestimaDAL.ProcitajObavijesti(obavijesti);
                }
                try
                {
                    Thread.Sleep(INTERVAL_PROVJERE);
                }
                catch (Exception)
                {
                }
            }
        }
        public static void Interrupt()
        {
            DOPUSTENA_RADNJA = false;
        }
    }
}
