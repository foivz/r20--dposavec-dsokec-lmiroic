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
    public partial class FormUpravljanjePoslovnicama : Form
    {
        private static FormUpravljanjePoslovnicama _instance;
        public static FormUpravljanjePoslovnicama instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FormUpravljanjePoslovnicama();
                }
                return _instance;
            }
        }
        public FormUpravljanjePoslovnicama()
        {
            InitializeComponent();
        }

        private void FormUpravljanjePoslovnicama_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
    }
}
