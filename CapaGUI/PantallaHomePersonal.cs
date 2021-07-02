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
    public partial class PantallaHomePersonal : Form
    {
        public PantallaHomePersonal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }

        private void crearDepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaRegistroDepartamento pRegistroDepartamento = new PantallaRegistroDepartamento();
            pRegistroDepartamento.ShowDialog();
        }

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaRegistroTutor pRegistroTutor = new PantallaRegistroTutor();
            pRegistroTutor.ShowDialog();
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaRegistroPaciente pRegistroPaciente = new PantallaRegistroPaciente();
            pRegistroPaciente.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void PantallaHomePersonal_Load(object sender, EventArgs e)
        {

        }

        private void tutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaRegistroPersonal pRegistroPersonal = new PantallaRegistroPersonal();
            pRegistroPersonal.ShowDialog();
        }
    }
}
