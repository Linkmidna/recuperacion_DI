namespace App_UT2_09
{
    partial class ListaPeliculaFrm
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
            this.lvPeliculas = new System.Windows.Forms.ListView();
            this.chTitulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAnno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGenero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsPeliculas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsiCrear = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsiVer = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsiBorrar = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPeliculas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvPeliculas
            // 
            this.lvPeliculas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTitulo,
            this.chAnno,
            this.chGenero});
            this.lvPeliculas.ContextMenuStrip = this.cmsPeliculas;
            this.lvPeliculas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPeliculas.FullRowSelect = true;
            this.lvPeliculas.GridLines = true;
            this.lvPeliculas.HideSelection = false;
            this.lvPeliculas.Location = new System.Drawing.Point(0, 0);
            this.lvPeliculas.MultiSelect = false;
            this.lvPeliculas.Name = "lvPeliculas";
            this.lvPeliculas.Size = new System.Drawing.Size(580, 338);
            this.lvPeliculas.TabIndex = 0;
            this.lvPeliculas.UseCompatibleStateImageBehavior = false;
            this.lvPeliculas.View = System.Windows.Forms.View.Details;
            this.lvPeliculas.DoubleClick += new System.EventHandler(this.lvPeliculas_DoubleClick);
            // 
            // chTitulo
            // 
            this.chTitulo.Text = "Titulo";
            this.chTitulo.Width = 274;
            // 
            // chAnno
            // 
            this.chAnno.Text = "Año";
            this.chAnno.Width = 113;
            // 
            // chGenero
            // 
            this.chGenero.Text = "Género";
            this.chGenero.Width = 189;
            // 
            // cmsPeliculas
            // 
            this.cmsPeliculas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsiCrear,
            this.cmsiVer,
            this.cmsiBorrar});
            this.cmsPeliculas.Name = "cmsPeliculas";
            this.cmsPeliculas.Size = new System.Drawing.Size(107, 70);
            this.cmsPeliculas.Opening += new System.ComponentModel.CancelEventHandler(this.cmsPeliculas_Opening);
            // 
            // cmsiCrear
            // 
            this.cmsiCrear.Name = "cmsiCrear";
            this.cmsiCrear.Size = new System.Drawing.Size(106, 22);
            this.cmsiCrear.Text = "Crear";
            this.cmsiCrear.Click += new System.EventHandler(this.crearToolStripMenuItem_Click);
            // 
            // cmsiVer
            // 
            this.cmsiVer.Name = "cmsiVer";
            this.cmsiVer.Size = new System.Drawing.Size(106, 22);
            this.cmsiVer.Text = "Ver";
            this.cmsiVer.Click += new System.EventHandler(this.verToolStripMenuItem_Click);
            // 
            // cmsiBorrar
            // 
            this.cmsiBorrar.Name = "cmsiBorrar";
            this.cmsiBorrar.Size = new System.Drawing.Size(106, 22);
            this.cmsiBorrar.Text = "Borrar";
            this.cmsiBorrar.Click += new System.EventHandler(this.borrarToolStripMenuItem_Click);
            // 
            // ListaPeliculaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 338);
            this.Controls.Add(this.lvPeliculas);
            this.Name = "ListaPeliculaFrm";
            this.Text = "ListaPeliculaFrm";
            this.cmsPeliculas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvPeliculas;
        private System.Windows.Forms.ColumnHeader chTitulo;
        private System.Windows.Forms.ColumnHeader chAnno;
        private System.Windows.Forms.ColumnHeader chGenero;
        private System.Windows.Forms.ContextMenuStrip cmsPeliculas;
        private System.Windows.Forms.ToolStripMenuItem cmsiCrear;
        private System.Windows.Forms.ToolStripMenuItem cmsiVer;
        private System.Windows.Forms.ToolStripMenuItem cmsiBorrar;
    }
}