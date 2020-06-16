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

        private void FormUpravljanjeKorisnicima_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
    }
}
