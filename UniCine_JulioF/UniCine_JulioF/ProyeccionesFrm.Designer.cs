namespace UniCine_JulioF
{
    partial class ProyeccionesFrm
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
            this.components = new System.ComponentModel.Container();
            this.lvProyecciones = new System.Windows.Forms.ListView();
            this.cmsProyecciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chPelicula = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSesion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chInicio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsProyecciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvProyecciones
            // 
            this.lvProyecciones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSesion,
            this.chPelicula,
            this.chInicio,
            this.chFin});
            this.lvProyecciones.ContextMenuStrip = this.cmsProyecciones;
            this.lvProyecciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvProyecciones.FullRowSelect = true;
            this.lvProyecciones.GridLines = true;
            this.lvProyecciones.HideSelection = false;
            this.lvProyecciones.Location = new System.Drawing.Point(0, 0);
            this.lvProyecciones.MultiSelect = false;
            this.lvProyecciones.Name = "lvProyecciones";
            this.lvProyecciones.Size = new System.Drawing.Size(455, 450);
            this.lvProyecciones.TabIndex = 0;
            this.lvProyecciones.UseCompatibleStateImageBehavior = false;
            this.lvProyecciones.View = System.Windows.Forms.View.Details;
            this.lvProyecciones.DoubleClick += new System.EventHandler(this.lvProyecciones_DoubleClick);
            // 
            // cmsProyecciones
            // 
            this.cmsProyecciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.borrarToolStripMenuItem});
            this.cmsProyecciones.Name = "cmsProyecciones";
            this.cmsProyecciones.Size = new System.Drawing.Size(181, 92);
            this.cmsProyecciones.Opening += new System.ComponentModel.CancelEventHandler(this.cmsProyecciones_Opening);
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.crearToolStripMenuItem.Text = "Crear";
            this.crearToolStripMenuItem.Click += new System.EventHandler(this.crearToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // borrarToolStripMenuItem
            // 
            this.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            this.borrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.borrarToolStripMenuItem.Text = "Borrar";
            this.borrarToolStripMenuItem.Click += new System.EventHandler(this.borrarToolStripMenuItem_Click);
            // 
            // chPelicula
            // 
            this.chPelicula.Text = "Película";
            this.chPelicula.Width = 168;
            // 
            // chSesion
            // 
            this.chSesion.Text = "Sesión";
            this.chSesion.Width = 87;
            // 
            // chInicio
            // 
            this.chInicio.Text = "Fecha inicio";
            this.chInicio.Width = 97;
            // 
            // chFin
            // 
            this.chFin.Text = "Fecha fin";
            this.chFin.Width = 98;
            // 
            // ProyeccionesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 450);
            this.Controls.Add(this.lvProyecciones);
            this.Name = "ProyeccionesFrm";
            this.Text = "Proyecciones";
            this.cmsProyecciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvProyecciones;
        private System.Windows.Forms.ContextMenuStrip cmsProyecciones;
        private System.Windows.Forms.ColumnHeader chSesion;
        private System.Windows.Forms.ColumnHeader chPelicula;
        private System.Windows.Forms.ColumnHeader chInicio;
        private System.Windows.Forms.ColumnHeader chFin;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem;
    }
}