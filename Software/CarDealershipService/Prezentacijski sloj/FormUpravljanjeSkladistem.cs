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
    public partial class FormUpravljanjeSkladistem : Form
    {
        private static FormUpravljanjeSkladistem _instance;
        public static FormUpravljanjeSkladistem instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FormUpravljanjeSkladistem();
                }
                return _instance;
            }
        }
        public FormUpravljanjeSkladistem()
        {
            InitializeComponent();
            panelUpravSkladistemHeader.BackColor = Color.FromArgb(45, 45, 48);
            panelUpravSkladistemFooter.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void FormUpravljanjeSkladistem_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
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
            foreach (Control previousBtn in panelUpravSkladistemFooter.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(45, 45, 48);
                    previousBtn.ForeColor = Color.LightGray;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void FormUpravljanjeSkladistem_Load(object sender, EventArgs e)
        {
            dgvSviArtikliNaSkladistu.DataSource = null;
            dgvSviArtikliNaSkladistu.DataSource = Sloj_pristupa_podacima.UpravljanjeSkladistem.UpravljanjeSkladistemDAL.VratiSveArtikle();
            dgvSviArtikliNaSkladistu.Columns[9].Visible = false;
            dgvSviArtikliNaSkladistu.Columns[10].Visible = false;
            dgvSviArtikliNaSkladistu.Columns[11].Visible = false;
        }
        private void PrikaziFormuAzuriranjeRezervnogDijela(FormKreirajRezervniDio form, object sender,Sloj_pristupa_podacima.Artikl artikl)
        {
            form.proslijedeniArtikl = artikl;
            form.FormUpravljanjeSkladistem = this;
            form.MdiParent = this.MdiParent;
            form.StartPosition = FormStartPosition.CenterScreen;
            ActivateButton(sender);
            form.Show();
            form.Activate();
        }
        private void PrikazFormeKreirajVozilo(FormKreirajVozilo form, object sender)
        {
            form.FormUpravljanjeSkladistem = this;
            form.MdiParent = this.MdiParent;
            form.StartPosition = FormStartPosition.CenterScreen;
            ActivateButton(sender);
            form.Show();
            form.Activate();
        }
        private void PrikaziFormuAzuriranjeVozila(FormKreirajVozilo form, object sender,Sloj_pristupa_podacima.Artikl artikl)
        {
            form.proslijedeniArtikl = artikl;
            form.FormUpravljanjeSkladistem = this;
            form.MdiParent = this.MdiParent;
            form.StartPosition = FormStartPosition.CenterScreen;
            ActivateButton(sender);
            form.Show();
            form.Activate();
        }
        private void PrikaziFormuRezervniDio(FormKreirajRezervniDio form, object sender)
        {
            form.FormUpravljanjeSkladistem = this;
            form.MdiParent = this.MdiParent;
            form.StartPosition = FormStartPosition.CenterScreen;
            ActivateButton(sender);
            form.Show();
            form.Activate();
        }
        private void uiActionBrisanje_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Sloj_pristupa_podacima.Artikl artikl = new Sloj_pristupa_podacima.Artikl();
            artikl = dgvSviArtikliNaSkladistu.CurrentRow.DataBoundItem as Sloj_pristupa_podacima.Artikl;
            Sloj_pristupa_podacima.UpravljanjeSkladistem.UpravljanjeSkladistemDAL.BrisanjeArtikla(artikl);
            OsvjeziPopisArtikala();
        }

        private void uiActionAzuriranje_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Sloj_pristupa_podacima.Artikl artikl = new Sloj_pristupa_podacima.Artikl();
            artikl = dgvSviArtikliNaSkladistu.CurrentRow.DataBoundItem as Sloj_pristupa_podacima.Artikl;
            if (artikl.vrsta_artikla==2)
            {
                PrikaziFormuAzuriranjeVozila(FormKreirajVozilo.Instance, sender,artikl);
            }
            else
                PrikaziFormuAzuriranjeRezervnogDijela(FormKreirajRezervniDio.instance, sender,artikl);
        }

        private void uiActionKreiraj_Click(object sender, EventArgs e)
        {
            PrikazFormeKreirajVozilo(FormKreirajVozilo.Instance, sender);
        }

        private void uiActionKreiranjeRezervnogDijela_Click(object sender, EventArgs e)
        {
            PrikaziFormuRezervniDio(FormKreirajRezervniDio.instance, sender);
        }
        public void OsvjeziPopisArtikala()
        {
            dgvSviArtikliNaSkladistu.DataSource = null;
            dgvSviArtikliNaSkladistu.DataSource = Sloj_pristupa_podacima.UpravljanjeSkladistem.UpravljanjeSkladistemDAL.VratiSveArtikle();
            dgvSviArtikliNaSkladistu.Columns[9].Visible = false;
            dgvSviArtikliNaSkladistu.Columns[10].Visible = false;
            dgvSviArtikliNaSkladistu.Columns[11].Visible = false;

        }
    }
}
