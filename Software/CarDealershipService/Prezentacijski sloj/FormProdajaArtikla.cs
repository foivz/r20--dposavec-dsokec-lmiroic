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
    public partial class FormProdajaArtikla : Form
    {
        private static FormProdajaArtikla _instance;
        public static FormProdajaArtikla instance
        {
            get
            {                
                if (_instance == null)
                {
                    _instance = new FormProdajaArtikla();
                }
                return _instance;
            }
        }
        public FormProdajaArtikla()
        {
            InitializeComponent();
        }

        private void FormProdajaArtikla_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
    }
}
