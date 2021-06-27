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
    public partial class PantallaListadoDepartamento : Form
    {
        public PantallaListadoDepartamento()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceDepartamento.ServicioDepartamentoSoapClient auxServicio = new ServiceDepartamento.ServicioDepartamentoSoapClient();
            this.dataGridViewDepartamento.DataSource = auxServicio.consultarDepartamento();
            this.dataGridViewDepartamento.DataMember = "departamento";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }

        private void dataGridViewDepartamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
