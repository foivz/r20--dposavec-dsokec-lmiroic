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
    public partial class FormUpravljanjeRezervacijama : Form
    {
        private static FormUpravljanjeRezervacijama _instance;
        public static FormUpravljanjeRezervacijama instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FormUpravljanjeRezervacijama();
                }
                return _instance;
            }
        }
        public FormUpravljanjeRezervacijama()
        {
            InitializeComponent();
        }

        private void FormUpravljanjeRezervacijama_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
    }
}
