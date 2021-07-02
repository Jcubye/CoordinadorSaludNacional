
namespace CapaGUI
{
    partial class PantallaHomeTutor
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
            this.pacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trazabilidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comunicaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articulosRequeridosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacienteToolStripMenuItem,
            this.trazabilidadToolStripMenuItem,
            this.comunicaciónToolStripMenuItem,
            this.articulosRequeridosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pacienteToolStripMenuItem
            // 
            this.pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            this.pacienteToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.pacienteToolStripMenuItem.Text = "Paciente";
            // 
            // trazabilidadToolStripMenuItem
            // 
            this.trazabilidadToolStripMenuItem.Name = "trazabilidadToolStripMenuItem";
            this.trazabilidadToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.trazabilidadToolStripMenuItem.Text = "Trazabilidad";
            // 
            // comunicaciónToolStripMenuItem
            // 
            this.comunicaciónToolStripMenuItem.Name = "comunicaciónToolStripMenuItem";
            this.comunicaciónToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.comunicaciónToolStripMenuItem.Text = "Comunicación";
            // 
            // articulosRequeridosToolStripMenuItem
            // 
            this.articulosRequeridosToolStripMenuItem.Name = "articulosRequeridosToolStripMenuItem";
            this.articulosRequeridosToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.articulosRequeridosToolStripMenuItem.Text = "Articulos Requeridos";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // PantallaHomeTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PantallaHomeTutor";
            this.Text = "PantallaHomeTutor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trazabilidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comunicaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articulosRequeridosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}