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
    public partial class PantallaRegistroTutor : Form
    {
        private int posicion;
        private int ultimo;

        public int Posicion { get => posicion; set => posicion = value; }
        public int Ultimo { get => ultimo; set => ultimo = value; }

        public PantallaRegistroTutor()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            this.txtRut.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.txtApellido.Text = string.Empty;
            this.txtCorreo.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
            this.txtClave.Text = string.Empty;
        }

        public void deshabilitar()
        {
            this.txtRut.Enabled = false;
            this.txtNombre.Enabled = false;
            this.txtApellido.Enabled = false;
            this.txtCorreo.Enabled = false;
            this.txtTelefono.Enabled = false;
            this.txtClave.Enabled = false;
        }

        public void habilitar()
        {
            this.txtRut.Enabled = true;
            this.txtNombre.Enabled = true;
            this.txtApellido.Enabled = true;
            this.txtCorreo.Enabled = true;
            this.txtTelefono.Enabled = true;
            this.txtClave.Enabled = true;
        }

        public void mostrar()
        {
            ServiceTutor.ServicioTutorSoapClient auxServiceTutor = new ServiceTutor.ServicioTutorSoapClient();
            ServiceTutor.Tutor auxTutor = new ServiceTutor.Tutor();

            this.Ultimo = auxServiceTutor.consultarTutor().Tables[0].Rows.Count;

            if (this.Posicion <= 1)
                this.Posicion = 1;

            if (this.Posicion >= this.Ultimo)
                this.Posicion = this.Ultimo;

            auxTutor = auxServiceTutor.posicionTutor(this.Posicion);

            this.txtRut.Text = auxTutor.Rut;
            this.txtNombre.Text = auxTutor.Nombre;
            this.txtApellido.Text = auxTutor.Apellido;
            this.txtCorreo.Text = auxTutor.Correo;
            this.txtTelefono.Text = auxTutor.Telefono;
            this.txtClave.Text = auxTutor.Clave;

            this.txtPosicion.Text = (this.Posicion) + "-" + (this.Ultimo);
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
                    ServiceTutor.ServicioTutorSoapClient auxServiceTutor = new ServiceTutor.ServicioTutorSoapClient();
                    ServiceTutor.Tutor auxTutor = new ServiceTutor.Tutor();
                    auxTutor.Rut = this.txtRut.Text;
                    auxTutor.Nombre = this.txtNombre.Text;
                    auxTutor.Apellido = this.txtApellido.Text;
                    auxTutor.Correo = this.txtCorreo.Text;
                    auxTutor.Telefono = this.txtTelefono.Text;
                    auxTutor.Clave = this.txtClave.Text;

                    if (String.IsNullOrEmpty(this.txtRut.Text) ||
                        String.IsNullOrEmpty(this.txtNombre.Text) ||
                        String.IsNullOrEmpty(this.txtApellido.Text) ||
                        String.IsNullOrEmpty(this.txtCorreo.Text) ||
                        String.IsNullOrEmpty(this.txtTelefono.Text) ||
                        String.IsNullOrEmpty(this.txtClave.Text)
                        )
                    {
                        MessageBox.Show("Debe ingresar Datos", "System");
                    }
                    else
                    { 
                        if (String.IsNullOrEmpty(auxServiceTutor.buscaTutor(auxTutor.Rut).Rut))
                        {
                            auxServiceTutor.insertarTutor(auxTutor);
                            MessageBox.Show("¡Datos Guardados!" , "System");
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
                        else
                        {
                            MessageBox.Show("El Tutor ya existe", "System");
                        }
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos no Guardados" + ex.Message, "System");
                this.limpiar();
            }
        }//fin registrar

        private void PantallaRegistroTutor_Load(object sender, EventArgs e)
        {
            this.btnRegistrar.Text = "Nuevo";
            this.deshabilitar();
        }
    }
}
