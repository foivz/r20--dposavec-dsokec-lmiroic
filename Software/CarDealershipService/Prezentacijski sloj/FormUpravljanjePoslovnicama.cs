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
    public partial class FormUpravljanjePoslovnicama : Form
    {
        private static FormUpravljanjePoslovnicama _instance;
        public static FormUpravljanjePoslovnicama instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FormUpravljanjePoslovnicama();
                }
                return _instance;
            }
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
            foreach (Control previousBtn in panelUpravljanjePoslovnicamaFooter.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(45, 45, 48);
                    previousBtn.ForeColor = Color.LightGray;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        public FormUpravljanjePoslovnicama()
        {
            InitializeComponent();
            panelUpravljanjePoslovnicamaHeader.BackColor = Color.FromArgb(45, 45, 48);
            panelUpravljanjePoslovnicamaFooter.BackColor = Color.FromArgb(45, 45, 48);
        }
        private void PrikazFormeKreirajPoslovnicu(FormKreirajPoslovnicu form, object sender)
        {
            form.FormUpravljanjePoslovnicama = this;
            form.MdiParent = this.MdiParent;
            form.StartPosition = FormStartPosition.CenterScreen;
            ActivateButton(sender);
            form.Show();
            form.Activate();
        }
        private void PrikaziFormuAzuriranjePoslovnice(FormKreirajPoslovnicu form, object sender, Sloj_pristupa_podacima.Poslovnica poslovnica)
        {
            form.prosljedenaPoslovnica = poslovnica;
            form.FormUpravljanjePoslovnicama = this;
            form.MdiParent = this.MdiParent;
            form.StartPosition = FormStartPosition.CenterScreen;
            ActivateButton(sender);
            form.Show();
            form.Activate();
        }
        private void PrikazFormeKreirajSkladiste(FormKreirajSkladiste form, object sender)
        {
            form.FormUpravljanjePoslovnicama = this;
            form.MdiParent = this.MdiParent;
            form.StartPosition = FormStartPosition.CenterScreen;
            ActivateButton(sender);
            form.Show();
            form.Activate();
        }

        private void FormUpravljanjePoslovnicama_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void uiActionFrmUpravPoslovnicamaKreiranje_Click(object sender, EventArgs e)
        {
            PrikazFormeKreirajPoslovnicu(FormKreirajPoslovnicu.instance, sender);
        }

        private void FormUpravljanjePoslovnicama_Load(object sender, EventArgs e)
        {
            dgvUpravljanjePoslovnicama.DataSource = null;
            dgvUpravljanjePoslovnicama.DataSource = Sloj_pristupa_podacima.UpravljanjePoslovnicama.UpravljanjePoslovnicamaDAL.DohvatiSvePoslovnice();
            dgvUpravljanjePoslovnicama.Columns[4].Visible = false;
            dgvUpravljanjePoslovnicama.Columns[5].Visible = false;
            dgvUpravljanjePoslovnicama.Columns[0].Width = 150;
            dgvUpravljanjePoslovnicama.Columns[1].Width = 150;
            dgvUpravljanjePoslovnicama.Columns[2].Width = 150;
            dgvUpravljanjePoslovnicama.Columns[3].Width = 150;
        }
        public void OsvjeziPopisPoslovnica()
        {
            dgvUpravljanjePoslovnicama.DataSource = null;
            dgvUpravljanjePoslovnicama.DataSource = Sloj_pristupa_podacima.UpravljanjePoslovnicama.UpravljanjePoslovnicamaDAL.DohvatiSvePoslovnice();
            dgvUpravljanjePoslovnicama.Columns[4].Visible = false;
            dgvUpravljanjePoslovnicama.Columns[5].Visible = false;
            dgvUpravljanjePoslovnicama.Columns[0].Width = 150;
            dgvUpravljanjePoslovnicama.Columns[1].Width = 150;
            dgvUpravljanjePoslovnicama.Columns[2].Width = 150;
            dgvUpravljanjePoslovnicama.Columns[3].Width = 150;
        }

        private void uiActionFrmUpravPoslovnicamaBrisanje_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Sloj_pristupa_podacima.Poslovnica poslovnica = new Sloj_pristupa_podacima.Poslovnica();
            poslovnica = dgvUpravljanjePoslovnicama.CurrentRow.DataBoundItem as Sloj_pristupa_podacima.Poslovnica;
            Sloj_pristupa_podacima.UpravljanjePoslovnicama.UpravljanjePoslovnicamaDAL.BrisanjePoslovnice(poslovnica);
            DnevnikRadaDLL.DnevnikLogin.ZapisiZapis(DnevnikRadaDLL.RadnjaDnevnika.BRISANJE_POSLOVNICE);
            OsvjeziPopisPoslovnica();
        }

        private void uiActionFrmUpravPoslovnicamaAzuriranje_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Sloj_pristupa_podacima.Poslovnica poslovnica = new Sloj_pristupa_podacima.Poslovnica();
            poslovnica = dgvUpravljanjePoslovnicama.CurrentRow.DataBoundItem as Sloj_pristupa_podacima.Poslovnica;
            PrikaziFormuAzuriranjePoslovnice(FormKreirajPoslovnicu.instance, sender, poslovnica);
        }

        private void uiActionUpravljanjeSkladistima_Click(object sender, EventArgs e)
        {
            PrikazFormeKreirajSkladiste(FormKreirajSkladiste.instance, sender);
        }

        private void FormUpravljanjePoslovnicama_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            System.Windows.Forms.Help.ShowHelp(this, "CarAppHelp.chm", HelpNavigator.Topic, "UpravljanjePoslovnicama.html");

        }
    }
}
