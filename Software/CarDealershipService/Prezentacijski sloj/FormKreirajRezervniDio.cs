using Sloj_poslovne_logike;
using Sloj_poslovne_logike.UpravljanjeSkladistem;
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
    public partial class FormKreirajRezervniDio : Form
    {
        public FormUpravljanjeSkladistem FormUpravljanjeSkladistem;
        public Sloj_pristupa_podacima.Artikl proslijedeniArtikl;
        private static FormKreirajRezervniDio _instance;
        public static FormKreirajRezervniDio instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FormKreirajRezervniDio();
                }
                return _instance;
            }
        }
        public FormKreirajRezervniDio()
        {
            InitializeComponent();
            panelKreirajRezervniDioHeader.BackColor = Color.FromArgb(45, 45, 48);
            panelKreirajRezervniDioFooter.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void FormKreirajRezervniDio_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
            proslijedeniArtikl = null;
        }

        private void uiActionSpremi_Click(object sender, EventArgs e)
        {
            Sloj_pristupa_podacima.Artikl artikl = new Sloj_pristupa_podacima.Artikl();
            try
            {
                artikl.godina_proizvodnje = int.Parse(uiInputGodinaProizvodnjeDijela.Text);
                artikl.opis_artikla = uiInputOpisRezervnogDijela.Text;
                artikl.naziv_artikla = uiInputNazivRezervnogDijela.Text;
                artikl.cijena_artikla = double.Parse(uiInputCijenaRezervnogDijela.Text);
                artikl.vrsta_artikla = 1;
                artikl.minimalna_kolicina = int.Parse(uiInputMinimalnaKolicina.Text);
                artikl.vrijeme_dostave = int.Parse(uiInputVrijemeDostave.Text);
                if (Sloj_poslovne_logike.UpravljanjeSkladistem.UpravljanjeSkladistemBLL.ProvjeraUnosaRezervnogDijela(artikl) == true)
                {
                    Sloj_pristupa_podacima.UpravljanjeSkladistem.UpravljanjeSkladistemDAL.KreiranjeArtikla(artikl,cbInputSkladiste.SelectedItem as Sloj_pristupa_podacima.Skladiste);
                    FormUpravljanjeSkladistem.OsvjeziPopisArtikala();
                    DnevnikRadaDLL.DnevnikLogin.ZapisiZapis(DnevnikRadaDLL.RadnjaDnevnika.KREIRANJE_REZERVNOG_DIJELA);
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
        }

        private void FormKreirajRezervniDio_Load(object sender, EventArgs e)
        {
            List<Skladiste> listaSkladista = ParserSkladista.ParsirajSkladista();
            cbInputSkladiste.DataSource = null;
            cbInputSkladiste.DataSource = listaSkladista;
            if (proslijedeniArtikl != null)
            {
                uiInputCijenaRezervnogDijela.Text = proslijedeniArtikl.cijena_artikla.ToString();
                uiInputGodinaProizvodnjeDijela.Text = proslijedeniArtikl.godina_proizvodnje.ToString();
                uiInputNazivRezervnogDijela.Text = proslijedeniArtikl.naziv_artikla;
                uiInputOpisRezervnogDijela.Text = proslijedeniArtikl.opis_artikla;
                uiInputMinimalnaKolicina.Text = proslijedeniArtikl.minimalna_kolicina.ToString();
                uiInputVrijemeDostave.Text = proslijedeniArtikl.vrijeme_dostave.ToString();
                uiActionSpremi.Enabled = false;
                uiActionSpremi.Hide();
            }
            else
            {
                uiActionAzuriraj.Enabled = false;
                uiActionAzuriraj.Hide();
            }
                
        }

        private void uiActionAzuriraj_Click(object sender, EventArgs e)
        {
            Sloj_pristupa_podacima.Artikl artikl = new Sloj_pristupa_podacima.Artikl();
            try
            {
                artikl.id_artikl = proslijedeniArtikl.id_artikl;
                artikl.godina_proizvodnje = int.Parse(uiInputGodinaProizvodnjeDijela.Text);
                artikl.opis_artikla = uiInputOpisRezervnogDijela.Text;
                artikl.naziv_artikla = uiInputNazivRezervnogDijela.Text;
                artikl.cijena_artikla = double.Parse(uiInputCijenaRezervnogDijela.Text);
                artikl.vrsta_artikla = 1;
                artikl.minimalna_kolicina = int.Parse(uiInputMinimalnaKolicina.Text);
                artikl.vrijeme_dostave = int.Parse(uiInputVrijemeDostave.Text);
                if (Sloj_poslovne_logike.UpravljanjeSkladistem.UpravljanjeSkladistemBLL.ProvjeraUnosaRezervnogDijela(artikl) == true)
                {
                    Sloj_pristupa_podacima.UpravljanjeSkladistem.UpravljanjeSkladistemDAL.AzurirajArtikl(artikl);
                    FormUpravljanjeSkladistem.OsvjeziPopisArtikala();
                    DnevnikRadaDLL.DnevnikLogin.ZapisiZapis(DnevnikRadaDLL.RadnjaDnevnika.AZURIRAJ_ARTIKL);
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
        }

        private void FormKreirajRezervniDio_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            System.Windows.Forms.Help.ShowHelp(this, "CarAppHelp.chm", HelpNavigator.Topic, "KreirajRezervniDio.html");

        }
    }
}
