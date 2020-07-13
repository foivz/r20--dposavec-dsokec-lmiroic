using Sloj_poslovne_logike;
using Sloj_pristupa_podacima;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Prezentacijski_sloj
{
    public partial class GlavnaForma : Form
    {
        private Thread dretva = new Thread(new ThreadStart(ProvjeraObavijesti.Run));
        private Button currentButton;
        public GlavnaForma()
        {
            InitializeComponent();
            panelGlFormaLogo.BackColor = Color.FromArgb(45, 45, 48);
            panelGlFormaIzbornik.BackColor = Color.FromArgb(45, 45, 48);
            panelGlFormaNaslov.BackColor = Color.FromArgb(45, 45, 48);
        }
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
            foreach (Control previousBtn in panelGlFormaIzbornik.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(45, 45, 48);
                    previousBtn.ForeColor = Color.LightGray;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }


        private void PrikaziFormu(Form form, object sender)
        {
            form.MdiParent = this;
            form.StartPosition = FormStartPosition.CenterScreen;
            ActivateButton(sender);
            form.Show();
            form.Activate();
        }

        private void uiActionProdaja_Click(object sender, EventArgs e)
        {

            PrikaziFormu(FormProdajaArtikla.instance,sender);
        }

        private void uiActionUpravljanjeSkladištem_Click(object sender, EventArgs e)
        {

            PrikaziFormu(FormUpravljanjeSkladistem.instance, sender);
        }

        private void uiActionRezervacija_Click(object sender, EventArgs e)
        {

            PrikaziFormu(FormUpravljanjeRezervacijama.instance, sender);
        }

        private void uiActionIzdavanjeDokumenata_Click(object sender, EventArgs e)
        {
            PrikaziFormu(FormIzvjesca.instance, sender);
        }

        private void uiActionUpravljanjeNarudzbama_Click(object sender, EventArgs e)
        {
            PrikaziFormu(FormUpravljanjeNarudzbama.instance, sender);
        }

        private void uiActionUpravljanjeKorisnicima_Click(object sender, EventArgs e)
        {
            PrikaziFormu(FormUpravljanjeKorisnicima.instance, sender);
        }

        private void uiActionUpravljanjePoslovnicama_Click(object sender, EventArgs e)
        {
            PrikaziFormu(FormUpravljanjePoslovnicama.instance, sender);
        }

        private void GlavnaForma_Load(object sender, EventArgs e)
        {
            ProvjeraObavijesti.Start(uiNotification);
            dretva.Start();
            if (Sesija.PrijavljenKorisnik.tip_korisnika!=2)
            {
                uiActionUpravljanjeKorisnicima.Enabled = false;
                uiActionUpravljanjePoslovnicama.Enabled = false;
            }               
        }

        private void uiActionOdjava_Click(object sender, EventArgs e)
        {
            DnevnikRadaDLL.DnevnikLogin.ZapisiZapis(DnevnikRadaDLL.RadnjaDnevnika.ODJAVA_IZ_SUSTAVA);
            FormPrijava formPrijava = new FormPrijava();
            this.Hide();
            this.Close();
            formPrijava.ShowDialog();          
            ProvjeraObavijesti.Interrupt();
            dretva.Interrupt();
        }

        private void GlavnaForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            Application.Exit();
        }

        private void GlavnaForma_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            System.Windows.Forms.Help.ShowHelp(this, "CarAppHelp.chm", HelpNavigator.Topic, "GlavnaForma.html");

        }
    }
}
