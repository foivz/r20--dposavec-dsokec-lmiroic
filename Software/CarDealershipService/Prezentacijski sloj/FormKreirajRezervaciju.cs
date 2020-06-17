using Sloj_poslovne_logike.UpravljanjeRezervacijama;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prezentacijski_sloj
{
    public partial class FormKreirajRezervaciju : Form
    {
        private static FormKreirajRezervaciju _Instance;
        public static FormKreirajRezervaciju Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new FormKreirajRezervaciju();
                }
                return _Instance;
            }
        }
        public FormKreirajRezervaciju()
        {
            InitializeComponent();
            panelKreirajRezervacijuHeader.BackColor = Color.FromArgb(45, 45, 48);
            paneKreirajRezervacijuFooter.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void FormKreirajRezervaciju_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instance = null;
        }

        private void FormKreirajRezervaciju_Load(object sender, EventArgs e)
        {
            cbInputKorisnik.DataSource = Sloj_poslovne_logike.UpravljanjeRezervacijama.ParserKorisnik.ParsirajKorisnika();
        }
    }
}
