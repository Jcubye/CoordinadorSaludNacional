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
        private int posicion;
        private int ultimo;

        public int Posicion { get => posicion; set => posicion = value; }
        public int Ultimo { get => ultimo; set => ultimo = value; }

        public PantallaRegistroDepartamento()
        {
            InitializeComponent();
            this.txtId.Text = String.Empty;
            this.txtNombre.Focus();
        }
        public void limpiar()
        {
            this.txtId.Text = String.Empty;
            this.txtNombre.Text = String.Empty;
            this.txtNombre.Focus();
        }

        public void deshabilitar()
        {
            this.txtNombre.Enabled = false;
        }

        public void habilitar()
        {
            this.txtNombre.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (this.btnCancelar.Text == "Salir")
            {
                this.Dispose();
                System.GC.Collect();
            }
            else
            {
                this.deshabilitar();
                this.btnRegistrar.Text = "Nuevo";
                this.btnActualizar.Enabled = true;
                this.btnEliminar.Enabled = true;
                this.btnListar.Enabled = true;
                this.btnPrimero.Enabled = true;
                this.btnAnterior.Enabled = true;
                this.btnSiguiente.Enabled = true;
                this.btnUltimo.Enabled = true;
                this.btnCancelar.Text = "Salir";
                this.mostrar();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.btnRegistrar.Text == "Nuevo")
                {
                    this.limpiar();
                    this.habilitar();
                    this.btnRegistrar.Text = "Registrar";
                    this.btnActualizar.Enabled = false;
                    this.btnEliminar.Enabled = false;
                    this.btnListar.Enabled = false;
                    this.btnPrimero.Enabled = false;
                    this.btnAnterior.Enabled = false;
                    this.btnSiguiente.Enabled = false;
                    this.btnUltimo.Enabled = false;
                    this.btnCancelar.Text = "Cancelar";
                }
                else
                {
                    ServiceDepartamento.ServicioDepartamentoSoapClient auxServiceDepartamento = new ServiceDepartamento.ServicioDepartamentoSoapClient();
                    ServiceDepartamento.Departamento auxDepartamento = new ServiceDepartamento.Departamento();
                    auxDepartamento.Id = 0;
                    auxDepartamento.Nombre = this.txtNombre.Text;

                    if (String.IsNullOrEmpty(this.txtNombre.Text))
                    {
                        MessageBox.Show("Debe ingresar Datos", "Salir");
                    }
                    else
                    {
                        //no valida si existe, pero en este caso no lo hara ya que Id no es ingresable y se autoincrementa
                        //if (String.IsNullOrEmpty(auxServiceDepartamento.buscaDepartamento(auxDepartamento.Id).Nombre))
                        //{
                        //    MessageBox.Show("El Departamento ya existe", "System");
                        //}
                        //else
                        //{
                            //aca iria el grabar, si el dpto no existiera
                        //}
                        auxServiceDepartamento.insertarDepartamentoService(auxDepartamento);

                        MessageBox.Show("¡Datos Guardados!", "System");
                        this.deshabilitar();
                        this.btnRegistrar.Text = "Nuevo";
                        this.btnActualizar.Enabled = true;
                        this.btnEliminar.Enabled = true;
                        this.btnListar.Enabled = true;
                        this.btnPrimero.Enabled = true;
                        this.btnAnterior.Enabled = true;
                        this.btnSiguiente.Enabled = true;
                        this.btnUltimo.Enabled = true;
                        this.btnCancelar.Text = "Salir";
                        this.mostrar();


                    }
                    
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos no Guardados" + ex.Message, "System");
                this.limpiar();
            }
        }

        //metodo para mostrar datos en mantenedor
        public void mostrar()
        {
            ServiceDepartamento.ServicioDepartamentoSoapClient auxServiceDepartamento = new ServiceDepartamento.ServicioDepartamentoSoapClient();
            ServiceDepartamento.Departamento auxDepartamento = new ServiceDepartamento.Departamento();

            this.Ultimo = auxServiceDepartamento.consultarDepartamento().Tables[0].Rows.Count;

            if (this.Posicion <= 1)
                this.Posicion = 1;

            if (this.Posicion >= this.Ultimo)
                this.Posicion = this.Ultimo;
     
            auxDepartamento = auxServiceDepartamento.posicionDepartamento(this.Posicion);

            this.txtId.Text = auxDepartamento.Id.ToString();
            this.txtNombre.Text = auxDepartamento.Nombre;
            
            this.txtPosicion.Text = (this.Posicion) + "-" + (this.Ultimo);


        }

        private void PantallaRegistroDepartamento_Load(object sender, EventArgs e)
        {
            this.txtId.Text = String.Empty;
            this.btnRegistrar.Text = "Nuevo";
            this.Posicion = 1;
            this.deshabilitar();
            this.mostrar(); 

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            PantallaListadoDepartamento pListadoDepartamento = new PantallaListadoDepartamento();
            pListadoDepartamento.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Posicion = this.Posicion - 1;
            this.mostrar();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            this.Posicion = this.Posicion + 1;
            this.mostrar();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            this.Posicion = 1;
            this.mostrar();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            this.Posicion = this.Ultimo;
            this.mostrar();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
