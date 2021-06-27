
namespace CapaGUI
{
    partial class PantallaHomePersonal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.resumenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoPacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoPersonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoTutoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearDepartamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarDepartamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearEquipoMédicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarEquiposMedicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resumenToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.departamentosToolStripMenuItem,
            this.equiposToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // resumenToolStripMenuItem
            // 
            this.resumenToolStripMenuItem.Name = "resumenToolStripMenuItem";
            this.resumenToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.resumenToolStripMenuItem.Text = "Resumen";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacienteToolStripMenuItem,
            this.tutorToolStripMenuItem,
            this.personalToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.usuariosToolStripMenuItem.Text = "Registrar";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoPacientesToolStripMenuItem,
            this.listadoPersonalToolStripMenuItem,
            this.listadoTutoresToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // departamentosToolStripMenuItem
            // 
            this.departamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearDepartamentoToolStripMenuItem,
            this.listarDepartamentosToolStripMenuItem});
            this.departamentosToolStripMenuItem.Name = "departamentosToolStripMenuItem";
            this.departamentosToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.departamentosToolStripMenuItem.Text = "Departamentos";
            // 
            // equiposToolStripMenuItem
            // 
            this.equiposToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearEquipoMédicoToolStripMenuItem,
            this.listarEquiposMedicosToolStripMenuItem});
            this.equiposToolStripMenuItem.Name = "equiposToolStripMenuItem";
            this.equiposToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.equiposToolStripMenuItem.Text = "Equipos Médicos";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // pacienteToolStripMenuItem
            // 
            this.pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            this.pacienteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pacienteToolStripMenuItem.Text = "Pacientes";
            // 
            // tutorToolStripMenuItem
            // 
            this.tutorToolStripMenuItem.Name = "tutorToolStripMenuItem";
            this.tutorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tutorToolStripMenuItem.Text = "Personal";
            // 
            // personalToolStripMenuItem
            // 
            this.personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            this.personalToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.personalToolStripMenuItem.Text = "Tutor";
            // 
            // listadoPacientesToolStripMenuItem
            // 
            this.listadoPacientesToolStripMenuItem.Name = "listadoPacientesToolStripMenuItem";
            this.listadoPacientesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listadoPacientesToolStripMenuItem.Text = "Listado Pacientes";
            // 
            // listadoPersonalToolStripMenuItem
            // 
            this.listadoPersonalToolStripMenuItem.Name = "listadoPersonalToolStripMenuItem";
            this.listadoPersonalToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listadoPersonalToolStripMenuItem.Text = "Listado Personal";
            // 
            // listadoTutoresToolStripMenuItem
            // 
            this.listadoTutoresToolStripMenuItem.Name = "listadoTutoresToolStripMenuItem";
            this.listadoTutoresToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listadoTutoresToolStripMenuItem.Text = "Listado Tutores";
            // 
            // crearDepartamentoToolStripMenuItem
            // 
            this.crearDepartamentoToolStripMenuItem.Name = "crearDepartamentoToolStripMenuItem";
            this.crearDepartamentoToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.crearDepartamentoToolStripMenuItem.Text = "Crear Departamento";
            this.crearDepartamentoToolStripMenuItem.Click += new System.EventHandler(this.crearDepartamentoToolStripMenuItem_Click);
            // 
            // listarDepartamentosToolStripMenuItem
            // 
            this.listarDepartamentosToolStripMenuItem.Name = "listarDepartamentosToolStripMenuItem";
            this.listarDepartamentosToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.listarDepartamentosToolStripMenuItem.Text = "Listar Departamentos";
            // 
            // crearEquipoMédicoToolStripMenuItem
            // 
            this.crearEquipoMédicoToolStripMenuItem.Name = "crearEquipoMédicoToolStripMenuItem";
            this.crearEquipoMédicoToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.crearEquipoMédicoToolStripMenuItem.Text = "Crear Equipo Médico";
            // 
            // listarEquiposMedicosToolStripMenuItem
            // 
            this.listarEquiposMedicosToolStripMenuItem.Name = "listarEquiposMedicosToolStripMenuItem";
            this.listarEquiposMedicosToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.listarEquiposMedicosToolStripMenuItem.Text = "Listar Equipos Medicos";
            // 
            // PantallaHomePersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PantallaHomePersonal";
            this.Text = "PantallaHomePersonal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem resumenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoPacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoPersonalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoTutoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearDepartamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarDepartamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearEquipoMédicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarEquiposMedicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}