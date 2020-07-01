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
    public partial class FormUpravljanjeRezervacijama : Form
    {
        private static FormUpravljanjeRezervacijama _instance;
        public static FormUpravljanjeRezervacijama instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FormUpravljanjeRezervacijama();
                }
                return _instance;
            }
        }
        public FormUpravljanjeRezervacijama()
        {
            InitializeComponent();
            panelUpravRezervacijamaHeader.BackColor = Color.FromArgb(45, 45, 48);
            panelUpravRezervacijamaFooter.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void FormUpravljanjeRezervacijama_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
            
        }

        private void FormUpravljanjeRezervacijama_Load(object sender, EventArgs e)
        {
            dgvUpravRezervacijamaSveRezervacije.DataSource = null;
            dgvUpravRezervacijamaSveRezervacije.DataSource = Sloj_pristupa_podacima.UpravljanjeRezervacijama.UpravljanjeRezervacijamaDAL.DohvatiSverezervacijePoslovnice(Sloj_poslovne_logike.Sesija.PrijavljenKorisnik);
            dgvUpravRezervacijamaSveRezervacije.Columns[2].Width = 200;
            dgvUpravRezervacijamaSveRezervacije.Columns[3].Visible = false;
            dgvUpravRezervacijamaSveRezervacije.Columns[7].Visible = false;
            dgvUpravRezervacijamaSveRezervacije.Columns[8].Visible = false;
            dgvUpravRezervacijamaSveRezervacije.Columns[9].Visible = false;
            dgvUpravRezervacijamaSveRezervacije.Columns[10].Visible = false;
        }
        private Button currentButton;
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = Color.FromArgb(30, 30, 30);
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelUpravRezervacijamaFooter.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(45, 45, 48);
                    previousBtn.ForeColor = Color.LightGray;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void PrikazForme(FormKreirajRezervaciju form, object sender)
        {
            form.FormUpravljanjeRezervacijama = this;
            form.MdiParent = this.MdiParent;
            form.StartPosition = FormStartPosition.CenterScreen;
            ActivateButton(sender);
            form.Show();
            form.Activate();
        }

        private void uiActionAzuriranjeRezervacije_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Sloj_pristupa_podacima.Dokument dokument = new Sloj_pristupa_podacima.Dokument();
            dokument = dgvUpravRezervacijamaSveRezervacije.CurrentRow.DataBoundItem as Sloj_pristupa_podacima.Dokument;              
            PrikazFormeAzuriranjaRezervacije(FormKreirajRezervaciju.Instance, sender, dokument);
            
        }
        private void PrikazFormeAzuriranjaRezervacije(FormKreirajRezervaciju form, object sender,Sloj_pristupa_podacima.Dokument dokument)
        {
            form.proslijedeniDokument = dokument;
            form.FormUpravljanjeRezervacijama = this;
            form.MdiParent = this.MdiParent;
            form.StartPosition = FormStartPosition.CenterScreen;
            ActivateButton(sender);
            form.Show();
            form.Activate();
        }

        private void uiActionObrisiRezervacije_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Sloj_pristupa_podacima.Dokument dokument = new Sloj_pristupa_podacima.Dokument();
            dokument = dgvUpravRezervacijamaSveRezervacije.CurrentRow.DataBoundItem as Sloj_pristupa_podacima.Dokument;
            Sloj_pristupa_podacima.UpravljanjeRezervacijama.UpravljanjeRezervacijamaDAL.BrisanjeRezervacije(dokument);
            Sloj_poslovne_logike.UpravljanjeDnevnikom.DnevnikLog.ZapisiZapis(Sloj_poslovne_logike.UpravljanjeDnevnikom.RadnjaDnevnika.BRISANJE_REZERVACIJE);
            OsvjeziPrikaz();
        }

        private void uiActionKreirajRezervaciju_Click(object sender, EventArgs e)
        {
            PrikazForme(FormKreirajRezervaciju.Instance, sender);
        }
        public void OsvjeziPrikaz()
        {
            dgvUpravRezervacijamaSveRezervacije.DataSource = null;
            dgvUpravRezervacijamaSveRezervacije.DataSource = Sloj_pristupa_podacima.UpravljanjeRezervacijama.UpravljanjeRezervacijamaDAL.DohvatiSverezervacijePoslovnice(Sloj_poslovne_logike.Sesija.PrijavljenKorisnik);
            dgvUpravRezervacijamaSveRezervacije.Columns[3].Visible = false;
            dgvUpravRezervacijamaSveRezervacije.Columns[2].Width = 200;
            dgvUpravRezervacijamaSveRezervacije.Columns[7].Visible = false;
            dgvUpravRezervacijamaSveRezervacije.Columns[8].Visible = false;
            dgvUpravRezervacijamaSveRezervacije.Columns[9].Visible = false;
            dgvUpravRezervacijamaSveRezervacije.Columns[10].Visible = false;
        }
    }
}
