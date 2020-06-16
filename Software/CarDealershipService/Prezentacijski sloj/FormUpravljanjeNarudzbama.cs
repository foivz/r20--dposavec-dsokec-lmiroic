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
        }

        private void FormUpravljanjeNarudzbama_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
    }
}
