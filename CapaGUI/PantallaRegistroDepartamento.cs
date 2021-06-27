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
    public partial class PantallaRegistroDepartamento : Form
    {
        public PantallaRegistroDepartamento()
        {
            InitializeComponent();
            this.txtNombre.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceDepartamento.ServicioDepartamentoSoapClient auxServiceDepartamento = new ServiceDepartamento.ServicioDepartamentoSoapClient();
                ServiceDepartamento.Departamento auxDepartamento = new ServiceDepartamento.Departamento();
                auxDepartamento.Id = 0;
                auxDepartamento.Nombre = this.txtNombre.Text;

                auxServiceDepartamento.insertarDepartamentoService(auxDepartamento);

                MessageBox.Show("¡Datos Guardados!" , "System");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos no Guardados" + ex.Message, "System");
            }
        }

        private void PantallaRegistroDepartamento_Load(object sender, EventArgs e)
        {
            this.txtNombre.Focus();
        }
    }
}
