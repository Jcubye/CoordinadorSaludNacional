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
        public void limpiar()
        {
            this.txtNombre.Text = "";
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
                this.limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos no Guardados" + ex.Message, "System");
                this.txtNombre.Focus();
            }
        }

        private void PantallaRegistroDepartamento_Load(object sender, EventArgs e)
        {
            this.txtNombre.Focus();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            PantallaListadoDepartamento pListadoDepartamento = new PantallaListadoDepartamento();
            pListadoDepartamento.ShowDialog();
        }
    }
}
