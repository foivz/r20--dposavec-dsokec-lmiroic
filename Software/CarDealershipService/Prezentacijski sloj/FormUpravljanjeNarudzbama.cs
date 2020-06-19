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
    public partial class FormUpravljanjeNarudzbama : Form
    {
        private static FormUpravljanjeNarudzbama _instance;
        public static FormUpravljanjeNarudzbama instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FormUpravljanjeNarudzbama();
                }
                return _instance;
            }
        }
        public FormUpravljanjeNarudzbama()
        {
            InitializeComponent();
            panelUpravljanjeNarudzbamaHeader.BackColor = Color.FromArgb(45, 45, 48);
            panelUpravljanjeNarudzbamaFooter.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void FormUpravljanjeNarudzbama_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void FormUpravljanjeNarudzbama_Load(object sender, EventArgs e)
        {
            dgvUpravljanjeNarudzbamaSveNarudzbe.DataSource = null;
            dgvUpravljanjeNarudzbamaSveNarudzbe.DataSource = Sloj_pristupa_podacima.UpravljanjeNarudzbama.UpravljanjeNarudzbamaDAL.DohvatiSveNarudzbe();
            dgvUpravljanjeNarudzbamaSveNarudzbe.Columns[4].Visible = false;
            dgvUpravljanjeNarudzbamaSveNarudzbe.Columns[7].Visible = false;
            dgvUpravljanjeNarudzbamaSveNarudzbe.Columns[8].Visible = false;
            dgvUpravljanjeNarudzbamaSveNarudzbe.Columns[9].Visible = false;
            dgvUpravljanjeNarudzbamaSveNarudzbe.Columns[10].Visible = false;
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
            foreach (Control previousBtn in panelUpravljanjeNarudzbamaFooter.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(45, 45, 48);
                    previousBtn.ForeColor = Color.LightGray;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void PrikazForme(FormKreirajNarudzbu form, object sender)
        {
            form.FormUpravljanjeNarudzbama = this;
            form.MdiParent = this.MdiParent;
            form.StartPosition = FormStartPosition.CenterScreen;
            ActivateButton(sender);
            form.Show();
            form.Activate();
        }

        private void uiActionAzurirajNarudzbu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Sloj_pristupa_podacima.Dokument narudzba = new Sloj_pristupa_podacima.Dokument();
            narudzba = dgvUpravljanjeNarudzbamaSveNarudzbe.CurrentRow.DataBoundItem as Sloj_pristupa_podacima.Dokument;
            PrikazFormeAzuriranjaNarudzbe(FormKreirajNarudzbu.Instance, sender, narudzba);
        }

        private void uiActionObrisiNarudzbu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Sloj_pristupa_podacima.Dokument narudzba = new Sloj_pristupa_podacima.Dokument();
            narudzba = dgvUpravljanjeNarudzbamaSveNarudzbe.CurrentRow.DataBoundItem as Sloj_pristupa_podacima.Dokument;
            Sloj_pristupa_podacima.UpravljanjeNarudzbama.UpravljanjeNarudzbamaDAL.BrisanjeNarudzbe(narudzba);
            OsvjeziPrikaz();
        }
        private void PrikazFormeAzuriranjaNarudzbe(FormKreirajNarudzbu form, object sender, Sloj_pristupa_podacima.Dokument narudzba)
        {
            form.proslijedeniDokument = narudzba;
            form.FormUpravljanjeNarudzbama = this;
            form.MdiParent = this.MdiParent;
            form.StartPosition = FormStartPosition.CenterScreen;
            ActivateButton(sender);
            form.Show();
            form.Activate();
        }
        private void uiActionKreirajNarudzbu_Click(object sender, EventArgs e)
        {
            PrikazForme(FormKreirajNarudzbu.Instance, sender);
        }
        public void OsvjeziPrikaz()
        {
            dgvUpravljanjeNarudzbamaSveNarudzbe.DataSource = null;
            dgvUpravljanjeNarudzbamaSveNarudzbe.DataSource = Sloj_pristupa_podacima.UpravljanjeNarudzbama.UpravljanjeNarudzbamaDAL.DohvatiSveNarudzbe();
            dgvUpravljanjeNarudzbamaSveNarudzbe.Columns[4].Visible = false;
            dgvUpravljanjeNarudzbamaSveNarudzbe.Columns[7].Visible = false;
            dgvUpravljanjeNarudzbamaSveNarudzbe.Columns[8].Visible = false;
            dgvUpravljanjeNarudzbamaSveNarudzbe.Columns[9].Visible = false;
            dgvUpravljanjeNarudzbamaSveNarudzbe.Columns[10].Visible = false;
        }
    }
    
}
