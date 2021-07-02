
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
            this.pacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoPacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoPersonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoTutoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearDepartamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarDepartamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearEquipoMédicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarEquiposMedicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            // pacienteToolStripMenuItem
            // 
            this.pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            this.pacienteToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.pacienteToolStripMenuItem.Text = "Pacientes";
            this.pacienteToolStripMenuItem.Click += new System.EventHandler(this.pacienteToolStripMenuItem_Click);
            // 
            // tutorToolStripMenuItem
            // 
            this.tutorToolStripMenuItem.Name = "tutorToolStripMenuItem";
            this.tutorToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.tutorToolStripMenuItem.Text = "Personal";
            this.tutorToolStripMenuItem.Click += new System.EventHandler(this.tutorToolStripMenuItem_Click);
            // 
            // personalToolStripMenuItem
            // 
            this.personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            this.personalToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.personalToolStripMenuItem.Text = "Tutor";
            this.personalToolStripMenuItem.Click += new System.EventHandler(this.personalToolStripMenuItem_Click);
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
            // listadoPacientesToolStripMenuItem
            // 
            this.listadoPacientesToolStripMenuItem.Name = "listadoPacientesToolStripMenuItem";
            this.listadoPacientesToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.listadoPacientesToolStripMenuItem.Text = "Listado Pacientes";
            // 
            // listadoPersonalToolStripMenuItem
            // 
            this.listadoPersonalToolStripMenuItem.Name = "listadoPersonalToolStripMenuItem";
            this.listadoPersonalToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.listadoPersonalToolStripMenuItem.Text = "Listado Personal";
            // 
            // listadoTutoresToolStripMenuItem
            // 
            this.listadoTutoresToolStripMenuItem.Name = "listadoTutoresToolStripMenuItem";
            this.listadoTutoresToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.listadoTutoresToolStripMenuItem.Text = "Listado Tutores";
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
            // equiposToolStripMenuItem
            // 
            this.equiposToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearEquipoMédicoToolStripMenuItem,
            this.listarEquiposMedicosToolStripMenuItem});
            this.equiposToolStripMenuItem.Name = "equiposToolStripMenuItem";
            this.equiposToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.equiposToolStripMenuItem.Text = "Equipos Médicos";
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
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total de pacientes hospitalizados:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total de personal:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(426, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(426, 167);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(426, 195);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pacientes sin tutor:";
            // 
            // PantallaHomePersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PantallaHomePersonal";
            this.Text = "PantallaHomePersonal";
            this.Load += new System.EventHandler(this.PantallaHomePersonal_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
    }
}