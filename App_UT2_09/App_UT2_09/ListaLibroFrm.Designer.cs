namespace App_UT2_09
{
    partial class ListaLibroFrm
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
            this.msLibros = new System.Windows.Forms.MenuStrip();
            this.librosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvLibros = new System.Windows.Forms.ListView();
            this.chTitulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAnno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGenero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsLibros = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsiCrear = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsiVer = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsiBorrar = new System.Windows.Forms.ToolStripMenuItem();
            this.msLibros.SuspendLayout();
            this.cmsLibros.SuspendLayout();
            this.SuspendLayout();
            // 
            // msLibros
            // 
            this.msLibros.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.librosToolStripMenuItem});
            this.msLibros.Location = new System.Drawing.Point(0, 0);
            this.msLibros.Name = "msLibros";
            this.msLibros.Size = new System.Drawing.Size(537, 24);
            this.msLibros.TabIndex = 0;
            this.msLibros.Text = "menuStrip1";
            // 
            // librosToolStripMenuItem
            // 
            this.librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            this.librosToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.librosToolStripMenuItem.Text = "Libros";
            // 
            // lvLibros
            // 
            this.lvLibros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTitulo,
            this.chAnno,
            this.chGenero});
            this.lvLibros.ContextMenuStrip = this.cmsLibros;
            this.lvLibros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvLibros.GridLines = true;
            this.lvLibros.HideSelection = false;
            this.lvLibros.Location = new System.Drawing.Point(0, 24);
            this.lvLibros.MultiSelect = false;
            this.lvLibros.Name = "lvLibros";
            this.lvLibros.Size = new System.Drawing.Size(537, 287);
            this.lvLibros.TabIndex = 1;
            this.lvLibros.UseCompatibleStateImageBehavior = false;
            this.lvLibros.View = System.Windows.Forms.View.Details;
            this.lvLibros.DoubleClick += new System.EventHandler(this.lvLibros_DoubleClick);
            // 
            // chTitulo
            // 
            this.chTitulo.Text = "Título";
            this.chTitulo.Width = 227;
            // 
            // chAnno
            // 
            this.chAnno.Text = "Año";
            this.chAnno.Width = 88;
            // 
            // chGenero
            // 
            this.chGenero.Text = "Género";
            this.chGenero.Width = 218;
            // 
            // cmsLibros
            // 
            this.cmsLibros.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsiCrear,
            this.cmsiVer,
            this.cmsiBorrar});
            this.cmsLibros.Name = "cmsLibros";
            this.cmsLibros.Size = new System.Drawing.Size(181, 92);
            this.cmsLibros.Opening += new System.ComponentModel.CancelEventHandler(this.cmsLibros_Opening);
            // 
            // cmsiCrear
            // 
            this.cmsiCrear.Name = "cmsiCrear";
            this.cmsiCrear.Size = new System.Drawing.Size(180, 22);
            this.cmsiCrear.Text = "Crear";
            this.cmsiCrear.Click += new System.EventHandler(this.cmsiCrear_Click);
            // 
            // cmsiVer
            // 
            this.cmsiVer.Name = "cmsiVer";
            this.cmsiVer.Size = new System.Drawing.Size(180, 22);
            this.cmsiVer.Text = "Ver";
            this.cmsiVer.Click += new System.EventHandler(this.cmsiVer_Click);
            // 
            // cmsiBorrar
            // 
            this.cmsiBorrar.Name = "cmsiBorrar";
            this.cmsiBorrar.Size = new System.Drawing.Size(180, 22);
            this.cmsiBorrar.Text = "Borrar";
            this.cmsiBorrar.Click += new System.EventHandler(this.cmsiBorrar_Click);
            // 
            // ListaLibroFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 311);
            this.Controls.Add(this.lvLibros);
            this.Controls.Add(this.msLibros);
            this.MainMenuStrip = this.msLibros;
            this.Name = "ListaLibroFrm";
            this.Text = "ListaLibroFrm";
            this.msLibros.ResumeLayout(false);
            this.msLibros.PerformLayout();
            this.cmsLibros.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msLibros;
        private System.Windows.Forms.ToolStripMenuItem librosToolStripMenuItem;
        private System.Windows.Forms.ListView lvLibros;
        private System.Windows.Forms.ColumnHeader chTitulo;
        private System.Windows.Forms.ColumnHeader chAnno;
        private System.Windows.Forms.ColumnHeader chGenero;
        private System.Windows.Forms.ContextMenuStrip cmsLibros;
        private System.Windows.Forms.ToolStripMenuItem cmsiCrear;
        private System.Windows.Forms.ToolStripMenuItem cmsiVer;
        private System.Windows.Forms.ToolStripMenuItem cmsiBorrar;
    }
}