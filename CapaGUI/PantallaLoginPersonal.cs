using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaGUI
{
    public partial class PantallaLoginPersonal : Form
    {
        public PantallaLoginPersonal()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            PantallaHomePersonal pPantallaHomePersonal = new PantallaHomePersonal();
            pPantallaHomePersonal.ShowDialog();
        }
    }
}
