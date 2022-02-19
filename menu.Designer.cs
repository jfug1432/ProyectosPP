
namespace ProyectosPP
{
    partial class menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumaDeDosNúmerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promedioDeTresCalificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arreglosBidimensionalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(902, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programasToolStripMenuItem
            // 
            this.programasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumaDeDosNúmerosToolStripMenuItem,
            this.promedioDeTresCalificacionesToolStripMenuItem,
            this.calculadoraToolStripMenuItem,
            this.arreglosBidimensionalesToolStripMenuItem});
            this.programasToolStripMenuItem.Name = "programasToolStripMenuItem";
            this.programasToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.programasToolStripMenuItem.Text = "Programas";
            // 
            // sumaDeDosNúmerosToolStripMenuItem
            // 
            this.sumaDeDosNúmerosToolStripMenuItem.Name = "sumaDeDosNúmerosToolStripMenuItem";
            this.sumaDeDosNúmerosToolStripMenuItem.Size = new System.Drawing.Size(299, 26);
            this.sumaDeDosNúmerosToolStripMenuItem.Text = "Suma de dos números";
            this.sumaDeDosNúmerosToolStripMenuItem.Click += new System.EventHandler(this.sumaDeDosNúmerosToolStripMenuItem_Click);
            // 
            // promedioDeTresCalificacionesToolStripMenuItem
            // 
            this.promedioDeTresCalificacionesToolStripMenuItem.Name = "promedioDeTresCalificacionesToolStripMenuItem";
            this.promedioDeTresCalificacionesToolStripMenuItem.Size = new System.Drawing.Size(299, 26);
            this.promedioDeTresCalificacionesToolStripMenuItem.Text = "Promedio de tres calificaciones";
            this.promedioDeTresCalificacionesToolStripMenuItem.Click += new System.EventHandler(this.promedioDeTresCalificacionesToolStripMenuItem_Click);
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(299, 26);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // arreglosBidimensionalesToolStripMenuItem
            // 
            this.arreglosBidimensionalesToolStripMenuItem.Name = "arreglosBidimensionalesToolStripMenuItem";
            this.arreglosBidimensionalesToolStripMenuItem.Size = new System.Drawing.Size(299, 26);
            this.arreglosBidimensionalesToolStripMenuItem.Text = "Arreglos Bidimensionales";
            this.arreglosBidimensionalesToolStripMenuItem.Click += new System.EventHandler(this.arreglosBidimensionalesToolStripMenuItem_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 565);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU DE OPCIONES MATERIA PARADIGMAS DE PROGRAMACION";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumaDeDosNúmerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promedioDeTresCalificacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arreglosBidimensionalesToolStripMenuItem;
    }
}

