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
        }

        private void FormUpravljanjeSkladistem_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
    }
}
