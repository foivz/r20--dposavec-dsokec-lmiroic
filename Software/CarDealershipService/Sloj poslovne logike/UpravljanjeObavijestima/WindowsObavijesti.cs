using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sloj_poslovne_logike.UpravljanjeObavijestima
{
    public class WindowsObavijesti
    {
        public static void PrikaziObavijest(NotifyIcon uiNotification, Sloj_pristupa_podacima.Obavijest obavijest)
        {
            uiNotification.Icon = new Icon(SystemIcons.Application, 40, 40);
            uiNotification.Visible = true;
            uiNotification.Text = "";
            uiNotification.BalloonTipText = obavijest.Opis;
            uiNotification.BalloonTipIcon = ToolTipIcon.Info;
            uiNotification.BalloonTipTitle = obavijest.Naslov;
            uiNotification.ShowBalloonTip(5000);
        }
        public static void PrikaziSveObavijesti(NotifyIcon uiNotification, List<Sloj_pristupa_podacima.Obavijest> obavijesti)
        {
            foreach (var item in obavijesti)
            {
                uiNotification.Icon = new Icon(SystemIcons.Application, 40, 40);
                uiNotification.Visible = true;
                uiNotification.Text = "";
                uiNotification.BalloonTipText = item.Opis;
                uiNotification.BalloonTipIcon = ToolTipIcon.Info;
                uiNotification.BalloonTipTitle = item.Naslov;
                uiNotification.ShowBalloonTip(5000);
            }

        }
    }
}
