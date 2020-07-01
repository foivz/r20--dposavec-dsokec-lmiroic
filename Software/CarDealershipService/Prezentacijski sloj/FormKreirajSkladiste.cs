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
    public partial class FormKreirajSkladiste : Form
    {
        public FormUpravljanjePoslovnicama FormUpravljanjePoslovnicama;
        private static FormKreirajSkladiste _instance;
        public static FormKreirajSkladiste instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FormKreirajSkladiste();
                }
                return _instance;
            }
        }
        public FormKreirajSkladiste()
        {
            InitializeComponent();
            panelKreirajSkladistePoslovniceHeader.BackColor = Color.FromArgb(45, 45, 48);
            panelKreirajSkladistePoslovniceFooter.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void FormKreirajSkladiste_Load(object sender, EventArgs e)
        {
            OsvjeziPrikazSkladista();
        }

        private void FormKreirajSkladiste_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void uiActionKreirajSkladiste_Click(object sender, EventArgs e)
        {
            Sloj_pristupa_podacima.Skladiste skladiste = new Sloj_pristupa_podacima.Skladiste();
            try
            {
                skladiste.naziv = uiInputNazivSkladista.Text;
                skladiste.adresa = uiInputAdresaSkladista.Text;
                if (Sloj_poslovne_logike.UpravljanjePoslovnicama.UpravljanjePoslovnicamaBLL.ProvjeraUnosaSkladista(skladiste) == true)
                {
                    Sloj_pristupa_podacima.UpravljanjePoslovnicama.UpravljanjePoslovnicamaDAL.KreiranjeSkladištaPoslovnice(skladiste, Sloj_poslovne_logike.Sesija.PrijavljenKorisnik);
                    Sloj_poslovne_logike.UpravljanjeDnevnikom.DnevnikLog.ZapisiZapis(Sloj_poslovne_logike.UpravljanjeDnevnikom.RadnjaDnevnika.KREIRANO_SKLADISTE);
                }
                else
                {
                    MessageBox.Show("Niste unijeli odgovarajuće parametre! Za pomoć pritisnite F1.");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Morate unijeti sve parametre");
            }
            OsvjeziPrikazSkladista();
        }
        private void OsvjeziPrikazSkladista()
        {
            dgvSkladistaPoslovnice.DataSource = null;
            dgvSkladistaPoslovnice.DataSource = Sloj_pristupa_podacima.UpravljanjeSkladistem.UpravljanjeSkladistemDAL.DohvatiSkladisteKorisnika(Sloj_poslovne_logike.Sesija.PrijavljenKorisnik);
            dgvSkladistaPoslovnice.Columns[3].Visible = false;
            dgvSkladistaPoslovnice.Columns[4].Visible = false;
        }
    }
}
