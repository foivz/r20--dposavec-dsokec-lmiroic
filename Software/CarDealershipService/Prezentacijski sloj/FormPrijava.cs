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
    public partial class FormPrijava : Form
    {
        public FormPrijava()
        {
            InitializeComponent();
            panelFrmPrijava.BackColor = Color.FromArgb(45, 45, 48);
            uiActionPrijava.BackColor=Color.FromArgb(127, 127, 128);
        }
        private bool ProvjeraUnesenihPodataka()
        {
            string korisnickoIme = uiInputKorisnickoIme.Text;
            string lozinka = uiInputLozinka.Text;
            if (korisnickoIme.Trim().Length != 0 && lozinka.Trim().Length != 0)
                return true;
            else
                return false;
        }

        private void uiActionPrijava_Click(object sender, EventArgs e)
        {           
            if (ProvjeraUnesenihPodataka())
            {
                string korisnickoIme = uiInputKorisnickoIme.Text;
                string lozinka = uiInputLozinka.Text;
                if (Sloj_poslovne_logike.UpravljanjeKorisnicima.UpravljanjeKorisnicimaBLL.PrijaviKorisnika(korisnickoIme, lozinka))
                {
                    GlavnaForma glavnaForma = new GlavnaForma();
                    DnevnikRadaDLL.DnevnikLogin.ZapisiZapis(DnevnikRadaDLL.RadnjaDnevnika.PRIJAVA_U_SUSTAV);
                    this.Hide();
                    glavnaForma.ShowDialog();
                    
                }
                else
                    MessageBox.Show("Korisnik ne postoji");
            }
            else
            {
                MessageBox.Show("Podaci nisu uneseni!");
            }           
        }

        private void FormPrijava_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
