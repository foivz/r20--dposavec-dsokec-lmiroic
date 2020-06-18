﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sloj_poslovne_logike.UpravljanjeSkladistem;

namespace Prezentacijski_sloj
{
    public partial class FormKreirajVozilo : Form
    {
        public FormUpravljanjeSkladistem FormUpravljanjeSkladistem;
        public Sloj_pristupa_podacima.Artikl proslijedeniArtikl;
        

        private static FormKreirajVozilo _Instance;
        public static FormKreirajVozilo Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new FormKreirajVozilo();
                }
                return _Instance;
            }
        }
        public FormKreirajVozilo()
        {
            InitializeComponent();
            panelKreirajArtiklHeader.BackColor = Color.FromArgb(45, 45, 48);
            panelKreirajArtiklFooter.BackColor = Color.FromArgb(45, 45, 48);
        }
        
        private void FormKreirajArtikl_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instance = null;
        }

        private void FormKreirajArtikl_Load(object sender, EventArgs e)
        {
            if (proslijedeniArtikl!=null)
            {
                uiInputGodinaProizvodnje.Text = proslijedeniArtikl.godina_proizvodnje.ToString();
                uiInputEmisijaVozila.Text = proslijedeniArtikl.emisija_vozila.ToString();
                uiInputSnagaVozila.Text = proslijedeniArtikl.snaga_vozila.ToString();
                uiInputOpisArtikla.Text = proslijedeniArtikl.opis_artikla;
                uiInputVrstaGoriva.SelectedItem= proslijedeniArtikl.vrsta_goriva;
                uiInputNazivArtikla.Text = proslijedeniArtikl.naziv_artikla;
                uiInputCijenaArtikla.Text = proslijedeniArtikl.cijena_artikla.ToString();
                
            }
            VrsteGoriva.SveVrsteGoriva.Add(new VrsteGoriva { Gorivo = 1, VrstaGoriva = "Dizel" });
            VrsteGoriva.SveVrsteGoriva.Add(new VrsteGoriva { Gorivo = 2, VrstaGoriva = "Benzin" });
            VrsteGoriva.SveVrsteGoriva.Add(new VrsteGoriva { Gorivo = 3, VrstaGoriva = "Hybrid" });
            VrsteGoriva.SveVrsteGoriva.Add(new VrsteGoriva { Gorivo = 4, VrstaGoriva = "Elektricni" });
            uiInputVrstaGoriva.DataSource = VrsteGoriva.SveVrsteGoriva;
             
        }

        private void uiActionSpremi_Click(object sender, EventArgs e)
        {

            Sloj_pristupa_podacima.Artikl artikl = new Sloj_pristupa_podacima.Artikl();
            {
                artikl.godina_proizvodnje = int.Parse(uiInputGodinaProizvodnje.Text);
                artikl.emisija_vozila = int.Parse(uiInputEmisijaVozila.Text);
                artikl.snaga_vozila = int.Parse(uiInputSnagaVozila.Text);
                artikl.opis_artikla = uiInputOpisArtikla.Text;
                artikl.vrsta_goriva = (uiInputVrstaGoriva.SelectedItem as VrsteGoriva).Gorivo;
                artikl.naziv_artikla = uiInputNazivArtikla.Text;
                artikl.cijena_artikla = float.Parse(uiInputCijenaArtikla.Text);
                artikl.vrsta_artikla = 2;
            }
            Sloj_pristupa_podacima.UpravljanjeSkladistem.UpravljanjeSkladistemDAL.KreiranjeArtikla(artikl);
            FormUpravljanjeSkladistem.OsvjeziPopisArtikala();           
            
        }

        private void uiActionAzurirajVozilo_Click(object sender, EventArgs e)
        {
            Sloj_pristupa_podacima.Artikl artikl = new Sloj_pristupa_podacima.Artikl();
            {
                artikl.id_artikl = proslijedeniArtikl.id_artikl;
                artikl.godina_proizvodnje = int.Parse(uiInputGodinaProizvodnje.Text);
                artikl.emisija_vozila = int.Parse(uiInputEmisijaVozila.Text);
                artikl.snaga_vozila = int.Parse(uiInputSnagaVozila.Text);
                artikl.opis_artikla = uiInputOpisArtikla.Text;
                artikl.vrsta_goriva = (uiInputVrstaGoriva.SelectedItem as VrsteGoriva).Gorivo;
                artikl.naziv_artikla = uiInputNazivArtikla.Text;
                artikl.cijena_artikla = float.Parse(uiInputCijenaArtikla.Text);
                artikl.vrsta_artikla = 2;
            }
            Sloj_pristupa_podacima.UpravljanjeSkladistem.UpravljanjeSkladistemDAL.AzurirajArtikl(artikl);
            FormUpravljanjeSkladistem.OsvjeziPopisArtikala();
            proslijedeniArtikl = null;
        }
    }
}