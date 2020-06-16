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
    public partial class FormIzdajDokumente : Form
    {
        private static FormIzdajDokumente _instance;
        public static FormIzdajDokumente instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FormIzdajDokumente();
                }
                return _instance;
            }
        }
        public FormIzdajDokumente()
        {
            InitializeComponent();
        }

        private void FormIzdajDokumente_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
    }
}
