using Sloj_poslovne_logike;
using Sloj_pristupa_podacima;
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
    public partial class FormPredvidanje : Form
    {
        private static FormPredvidanje _Instance;
        public static FormPredvidanje Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new FormPredvidanje();
                }
                return _Instance;
            }
        }
        public FormPredvidanje()
        {
            InitializeComponent();
        }
        private void FormPredvidanje_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(45, 45, 48);
            List<Sloj_poslovne_logike.UpravljanjeRezervacijama.Korisnik> dobavljaci = Sloj_poslovne_logike.UpravljanjeRezervacijama.ParserKorisnik.ParsirajDobavljača();
            cbInputDobavljaci.DataSource = null;
            cbInputDobavljaci.DataSource = dobavljaci;
            List<Artikli_na_skladistu> artikli_Na_Skladistu = Sloj_pristupa_podacima.UpravljanjeSkladistem.UpravljanjeSkladistemDAL.DohvatiSveProdaneArtikleNaSkladistu(Sesija.PrijavljenKorisnik);
            foreach (var item in artikli_Na_Skladistu)
            {
                string datum= Prediction.PredvidiVrijemeNarudzbe(item);
                DinamicController.DodajRed(this,item,datum,cbInputDobavljaci.SelectedItem as Sloj_poslovne_logike.UpravljanjeRezervacijama.Korisnik);
            }
        }

        private void FormPredvidanje_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instance = null;
            this.Controls.Clear();
        }

        private void FormPredvidanje_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            System.Windows.Forms.Help.ShowHelp(this, "CarAppHelp.chm", HelpNavigator.Topic, "Predvidanje.html");
        }
    }
}
