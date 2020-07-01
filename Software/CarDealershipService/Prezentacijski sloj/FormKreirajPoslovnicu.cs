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
    public partial class FormKreirajPoslovnicu : Form
    {
        public FormUpravljanjePoslovnicama FormUpravljanjePoslovnicama;
        public Sloj_pristupa_podacima.Poslovnica prosljedenaPoslovnica;
        private static FormKreirajPoslovnicu _instance;
        public static FormKreirajPoslovnicu instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FormKreirajPoslovnicu();
                }
                return _instance;
            }
        }
        public FormKreirajPoslovnicu()
        {
            InitializeComponent();
            panelKreirajPoslovnicuHeader.BackColor = Color.FromArgb(45, 45, 48);
            panelKreirajPoslovnicuFooter.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void FormKreirajPoslovnicu_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
            prosljedenaPoslovnica = null;
        }

        private void uiActionKreirajPoslovnicu_Click(object sender, EventArgs e)
        {
            Sloj_pristupa_podacima.Poslovnica poslovnica = new Sloj_pristupa_podacima.Poslovnica();
            try
            {
                poslovnica.adresa_poslovnice = uiInputAdresaPoslovnice.Text;
                poslovnica.OIB_poslovnice = uiInputOIBPoslovnice.Text;
                poslovnica.naziv_poslovnice = uiInputNazivPoslovnice.Text;
                if (Sloj_poslovne_logike.UpravljanjePoslovnicama.UpravljanjePoslovnicamaBLL.ProvjeraUnosaPoslovnice(poslovnica)==true)
                {
                    Sloj_pristupa_podacima.UpravljanjePoslovnicama.UpravljanjePoslovnicamaDAL.KreirajPoslovnicu(poslovnica);
                    FormUpravljanjePoslovnicama.OsvjeziPopisPoslovnica();
                    Sloj_poslovne_logike.UpravljanjeDnevnikom.DnevnikLog.ZapisiZapis(Sloj_poslovne_logike.UpravljanjeDnevnikom.RadnjaDnevnika.KREIRANA_POSLOVNICA);
                }
                else
                {
                    MessageBox.Show("Niste unijeli odgovarajuće parametre! Za pomoć pritisnite F1.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Morate unijeti sve parametre!");
            } 
        }

        private void FormKreirajPoslovnicu_Load(object sender, EventArgs e)
        {
            if (prosljedenaPoslovnica!=null)
            {
                uiInputAdresaPoslovnice.Text = prosljedenaPoslovnica.adresa_poslovnice;
                uiInputNazivPoslovnice.Text = prosljedenaPoslovnica.naziv_poslovnice;
                uiInputOIBPoslovnice.Text = prosljedenaPoslovnica.OIB_poslovnice;
                uiActionKreirajPoslovnicu.Enabled = false;
                uiActionKreirajPoslovnicu.Hide();
            }
            else
            {
                uiActionAzuriranjePoslovnice.Enabled = false;
                uiActionAzuriranjePoslovnice.Hide();
            }
        }

        private void uiActionAzuriranjePoslovnice_Click(object sender, EventArgs e)
        {
            Sloj_pristupa_podacima.Poslovnica poslovnica = new Sloj_pristupa_podacima.Poslovnica();
            try
            {
                poslovnica.id_poslovnica = prosljedenaPoslovnica.id_poslovnica;
                poslovnica.adresa_poslovnice = uiInputAdresaPoslovnice.Text;
                poslovnica.OIB_poslovnice = uiInputOIBPoslovnice.Text;
                poslovnica.naziv_poslovnice = uiInputNazivPoslovnice.Text;
                if (Sloj_poslovne_logike.UpravljanjePoslovnicama.UpravljanjePoslovnicamaBLL.ProvjeraUnosaPoslovnice(poslovnica) == true)
                {
                    Sloj_pristupa_podacima.UpravljanjePoslovnicama.UpravljanjePoslovnicamaDAL.AzurirajPoslovnicu(poslovnica);
                    FormUpravljanjePoslovnicama.OsvjeziPopisPoslovnica();
                }
                else
                {
                    MessageBox.Show("Niste unijeli odgovarajuće parametre! Za pomoć pritisnite F1.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Morate unijeti sve parametre!");
            }        
        }
    }
}
