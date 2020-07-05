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
    public partial class FormUpravljanjeKorisnicima : Form
    {
        private static FormUpravljanjeKorisnicima _instance;
        public static FormUpravljanjeKorisnicima instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FormUpravljanjeKorisnicima();
                }
                return _instance;
            }
        }
        public FormUpravljanjeKorisnicima()
        {
            InitializeComponent();
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
            foreach (Control previousBtn in panelUpravKorisnicimaFooter.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(45, 45, 48);
                    previousBtn.ForeColor = Color.LightGray;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void FormUpravljanjeKorisnicima_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
        private void PrikazFormeKreirajKorisnika(FormKreirajKorisnika form, object sender)
        {
            form.FormUpravljanjeKorisnicima = this;
            form.MdiParent = this.MdiParent;
            form.StartPosition = FormStartPosition.CenterScreen;
            ActivateButton(sender);
            form.Show();
            form.Activate();
        }
        private void PrikaziFormuAzuriranjeKorisnika(FormKreirajKorisnika form, object sender, Sloj_pristupa_podacima.Korisnik korisnik)
        {
            form.ProsljedeniKorisnik = korisnik;
            form.FormUpravljanjeKorisnicima = this;
            form.MdiParent = this.MdiParent;
            form.StartPosition = FormStartPosition.CenterScreen;
            ActivateButton(sender);
            form.Show();
            form.Activate();
        }

        private void uiActionBrisanje_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Sloj_pristupa_podacima.Korisnik korisnik = new Sloj_pristupa_podacima.Korisnik();
            korisnik = dgvUpravljanjeKorisnicima.CurrentRow.DataBoundItem as Sloj_pristupa_podacima.Korisnik;
            Sloj_pristupa_podacima.UpravljanjeKorisnicima.UpravljanjeKorisnicima.BrisanjeKorisnika(korisnik);
            DnevnikRadaDLL.DnevnikLogin.ZapisiZapis(DnevnikRadaDLL.RadnjaDnevnika.BRISANJE_KORISNIKA);
            OsvjeziPopisKorisnika();
        }

        private void FormUpravljanjeKorisnicima_Load(object sender, EventArgs e)
        {
            panelUpravKorisnicimaHeader.BackColor = Color.FromArgb(45, 45, 48);
            panelUpravKorisnicimaFooter.BackColor = Color.FromArgb(45, 45, 48);
            dgvUpravljanjeKorisnicima.DataSource = null;
            dgvUpravljanjeKorisnicima.DataSource = Sloj_pristupa_podacima.UpravljanjeKorisnicima.UpravljanjeKorisnicima.DohvatiSveKorisnike();
            dgvUpravljanjeKorisnicima.Columns[10].Visible = false;
            dgvUpravljanjeKorisnicima.Columns[11].Visible = false;
            dgvUpravljanjeKorisnicima.Columns[12].Visible = false;
            dgvUpravljanjeKorisnicima.Columns[13].Visible = false;
            dgvUpravljanjeKorisnicima.Columns[14].Visible = false;
        }

        private void uiActionKreiraj_Click(object sender, EventArgs e)
        {
            PrikazFormeKreirajKorisnika(FormKreirajKorisnika.Instance, sender);
        }
        public void OsvjeziPopisKorisnika()
        {
            dgvUpravljanjeKorisnicima.DataSource = null;
            dgvUpravljanjeKorisnicima.DataSource = Sloj_pristupa_podacima.UpravljanjeKorisnicima.UpravljanjeKorisnicima.DohvatiSveKorisnike();
            dgvUpravljanjeKorisnicima.Columns[10].Visible = false;
            dgvUpravljanjeKorisnicima.Columns[11].Visible = false;
            dgvUpravljanjeKorisnicima.Columns[12].Visible = false;
            dgvUpravljanjeKorisnicima.Columns[13].Visible = false;
            dgvUpravljanjeKorisnicima.Columns[14].Visible = false;
        }

        private void uiActionAzuriranje_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Sloj_pristupa_podacima.Korisnik korisnik = new Sloj_pristupa_podacima.Korisnik();
            korisnik = dgvUpravljanjeKorisnicima.CurrentRow.DataBoundItem as Sloj_pristupa_podacima.Korisnik;
            PrikaziFormuAzuriranjeKorisnika(FormKreirajKorisnika.Instance, sender, korisnik);
        }
    }
}
