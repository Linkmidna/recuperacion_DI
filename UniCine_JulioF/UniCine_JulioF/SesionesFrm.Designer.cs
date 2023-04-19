namespace UniCine_JulioF
{
    partial class SesionesFrm
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
            this.lvSesiones = new System.Windows.Forms.ListView();
            this.chSala = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDiaSemana = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chInicio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAforo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsSesiones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSesiones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvSesiones
            // 
            this.lvSesiones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSala,
            this.chDiaSemana,
            this.chInicio,
            this.chFin,
            this.chPrecio,
            this.chAforo});
            this.lvSesiones.ContextMenuStrip = this.cmsSesiones;
            this.lvSesiones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSesiones.FullRowSelect = true;
            this.lvSesiones.GridLines = true;
            this.lvSesiones.HideSelection = false;
            this.lvSesiones.Location = new System.Drawing.Point(0, 0);
            this.lvSesiones.MultiSelect = false;
            this.lvSesiones.Name = "lvSesiones";
            this.lvSesiones.Size = new System.Drawing.Size(528, 402);
            this.lvSesiones.TabIndex = 0;
            this.lvSesiones.UseCompatibleStateImageBehavior = false;
            this.lvSesiones.View = System.Windows.Forms.View.Details;
            this.lvSesiones.DoubleClick += new System.EventHandler(this.lvSesiones_DoubleClick);
            // 
            // chSala
            // 
            this.chSala.Text = "Sala";
            this.chSala.Width = 64;
            // 
            // chDiaSemana
            // 
            this.chDiaSemana.Text = "Dia";
            this.chDiaSemana.Width = 99;
            // 
            // chInicio
            // 
            this.chInicio.Text = "Hora inicio";
            this.chInicio.Width = 111;
            // 
            // chFin
            // 
            this.chFin.Text = "Hora fin";
            this.chFin.Width = 97;
            // 
            // chPrecio
            // 
            this.chPrecio.Text = "Precio";
            this.chPrecio.Width = 75;
            // 
            // chAforo
            // 
            this.chAforo.Text = "Aforo";
            this.chAforo.Width = 78;
            // 
            // cmsSesiones
            // 
            this.cmsSesiones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.borrarToolStripMenuItem});
            this.cmsSesiones.Name = "cmsSesiones";
            this.cmsSesiones.Size = new System.Drawing.Size(126, 70);
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.crearToolStripMenuItem.Text = "Crear";
            this.crearToolStripMenuItem.Click += new System.EventHandler(this.crearToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // borrarToolStripMenuItem
            // 
            this.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            this.borrarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.borrarToolStripMenuItem.Text = "Borrar";
            this.borrarToolStripMenuItem.Click += new System.EventHandler(this.borrarToolStripMenuItem_Click);
            // 
            // SesionesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 402);
            this.Controls.Add(this.lvSesiones);
            this.Name = "SesionesFrm";
            this.Text = "Sesiones";
            this.cmsSesiones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvSesiones;
        private System.Windows.Forms.ColumnHeader chSala;
        private System.Windows.Forms.ColumnHeader chDiaSemana;
        private System.Windows.Forms.ColumnHeader chInicio;
        private System.Windows.Forms.ColumnHeader chFin;
        private System.Windows.Forms.ColumnHeader chPrecio;
        private System.Windows.Forms.ColumnHeader chAforo;
        private System.Windows.Forms.ContextMenuStrip cmsSesiones;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem;
    }
}