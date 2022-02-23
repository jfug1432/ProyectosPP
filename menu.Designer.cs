
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
            this.arreglosBidimensionalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arregloMultidimensionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(603, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programasToolStripMenuItem
            // 
            this.programasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumaDeDosNúmerosToolStripMenuItem,
            this.promedioDeTresCalificacionesToolStripMenuItem,
            this.calculadoraToolStripMenuItem,
            this.arreglosBidimensionalesToolStripMenuItem,
            this.arregloMultidimensionalToolStripMenuItem});
            this.programasToolStripMenuItem.Name = "programasToolStripMenuItem";
            this.programasToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.programasToolStripMenuItem.Text = "Programas";
            // 
            // sumaDeDosNúmerosToolStripMenuItem
            // 
            this.sumaDeDosNúmerosToolStripMenuItem.Name = "sumaDeDosNúmerosToolStripMenuItem";
            this.sumaDeDosNúmerosToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.sumaDeDosNúmerosToolStripMenuItem.Text = "Suma de dos números";
            this.sumaDeDosNúmerosToolStripMenuItem.Click += new System.EventHandler(this.sumaDeDosNúmerosToolStripMenuItem_Click);
            // 
            // promedioDeTresCalificacionesToolStripMenuItem
            // 
            this.promedioDeTresCalificacionesToolStripMenuItem.Name = "promedioDeTresCalificacionesToolStripMenuItem";
            this.promedioDeTresCalificacionesToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.promedioDeTresCalificacionesToolStripMenuItem.Text = "Promedio de tres calificaciones";
            this.promedioDeTresCalificacionesToolStripMenuItem.Click += new System.EventHandler(this.promedioDeTresCalificacionesToolStripMenuItem_Click);
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // arreglosBidimensionalesToolStripMenuItem
            // 
            this.arreglosBidimensionalesToolStripMenuItem.Name = "arreglosBidimensionalesToolStripMenuItem";
            this.arreglosBidimensionalesToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.arreglosBidimensionalesToolStripMenuItem.Text = "Arreglos Bidimensionales";
            this.arreglosBidimensionalesToolStripMenuItem.Click += new System.EventHandler(this.arreglosBidimensionalesToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // arregloMultidimensionalToolStripMenuItem
            // 
            this.arregloMultidimensionalToolStripMenuItem.Name = "arregloMultidimensionalToolStripMenuItem";
            this.arregloMultidimensionalToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.arregloMultidimensionalToolStripMenuItem.Text = "Arreglo multidimensional";
            this.arregloMultidimensionalToolStripMenuItem.Click += new System.EventHandler(this.arregloMultidimensionalToolStripMenuItem_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 459);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.ToolStripMenuItem arregloMultidimensionalToolStripMenuItem;
    }
}

