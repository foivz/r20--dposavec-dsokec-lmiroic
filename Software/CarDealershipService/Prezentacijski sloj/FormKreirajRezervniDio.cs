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
    public partial class FormKreirajRezervniDio : Form
    {
        private static FormKreirajRezervniDio _instance;
        public static FormKreirajRezervniDio instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FormKreirajRezervniDio();
                }
                return _instance;
            }
        }
        public FormKreirajRezervniDio()
        {
            InitializeComponent();
            panelKreirajRezervniDioHeader.BackColor = Color.FromArgb(45, 45, 48);
            panelKreirajRezervniDioFooter.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void FormKreirajRezervniDio_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void uiActionSpremi_Click(object sender, EventArgs e)
        {

        }
    }
}
