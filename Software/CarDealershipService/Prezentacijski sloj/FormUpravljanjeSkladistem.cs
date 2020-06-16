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

        private void uiActionBrisanje_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void uiActionAzuriranje_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void uiActionKreiraj_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
    }
}
