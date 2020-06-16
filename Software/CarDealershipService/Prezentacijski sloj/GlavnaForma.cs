using System;
using System.Drawing;
using System.Windows.Forms;

namespace Prezentacijski_sloj
{
    public partial class GlavnaForma : Form
    {
        public GlavnaForma()
        {
            InitializeComponent();
            panelGlFormaLogo.BackColor = Color.FromArgb(45, 45, 48);
            panelGlFormaIzbornik.BackColor = Color.FromArgb(45, 45, 48);
            panelGlFormaNaslov.BackColor = Color.FromArgb(45, 45, 48);
        }
        private void PrikaziFormu(Form form)
        {
            form.MdiParent = this;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            form.Activate();
        }

        private void uiActionProdaja_Click(object sender, EventArgs e)
        {
            PrikaziFormu(FormProdajaArtikla.instance);
        }

        private void uiActionUpravljanjeSkladištem_Click(object sender, EventArgs e)
        {
            PrikaziFormu(FormUpravljanjeSkladistem.instance);
        }
    }
}
