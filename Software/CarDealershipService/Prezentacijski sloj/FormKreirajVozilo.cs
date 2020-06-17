using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sloj_poslovne_logike.UpravljanjeSkladistem;

namespace Prezentacijski_sloj
{
    public partial class FormKreirajVozilo : Form
    {
        private static FormKreirajVozilo _Instance;
        public static FormKreirajVozilo Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new FormKreirajVozilo();
                }
                return _Instance;
            }
        }
        public FormKreirajVozilo()
        {
            InitializeComponent();
            panelKreirajArtiklHeader.BackColor = Color.FromArgb(45, 45, 48);
            panelKreirajArtiklFooter.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void FormKreirajArtikl_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instance = null;
        }

        private void FormKreirajArtikl_Load(object sender, EventArgs e)
        {
            VrsteGoriva.SveVrsteGoriva.Add(new VrsteGoriva { Gorivo = 0, VrstaGoriva = "" });
            VrsteGoriva.SveVrsteGoriva.Add(new VrsteGoriva { Gorivo = 1, VrstaGoriva = "Dizel" });
            VrsteGoriva.SveVrsteGoriva.Add(new VrsteGoriva { Gorivo = 2, VrstaGoriva = "Benzin" });
            VrsteGoriva.SveVrsteGoriva.Add(new VrsteGoriva { Gorivo = 3, VrstaGoriva = "Hybrid" });
            VrsteGoriva.SveVrsteGoriva.Add(new VrsteGoriva { Gorivo = 4, VrstaGoriva = "Elektricni" });
            uiInputVrstaGoriva.DataSource = VrsteGoriva.SveVrsteGoriva;
        }
    }
}
