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
    public partial class PantallaListarTutor : Form
    {
        public PantallaListarTutor()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            ServiceTutor.ServicioTutorSoapClient auxServiceTutor = new ServiceTutor.ServicioTutorSoapClient();
            this.dataGridViewTutor.DataSource = auxServiceTutor.consultarTutor();
            this.dataGridViewTutor.DataMember = "tutor";
        }

        private void dataGridViewTutor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
