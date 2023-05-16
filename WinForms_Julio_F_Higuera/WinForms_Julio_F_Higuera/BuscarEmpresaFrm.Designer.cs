namespace WinForms_Julio_F_Higuera
{
    partial class BuscarEmpresaFrm
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
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.lvEmpresas = new System.Windows.Forms.ListView();
            this.chEmpresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(12, 12);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(232, 20);
            this.txtFiltro.TabIndex = 0;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(251, 12);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 20);
            this.btnFiltrar.TabIndex = 1;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(332, 12);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 20);
            this.btnSeleccionar.TabIndex = 2;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // lvEmpresas
            // 
            this.lvEmpresas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chEmpresa});
            this.lvEmpresas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvEmpresas.FullRowSelect = true;
            this.lvEmpresas.GridLines = true;
            this.lvEmpresas.HideSelection = false;
            this.lvEmpresas.Location = new System.Drawing.Point(0, 38);
            this.lvEmpresas.MultiSelect = false;
            this.lvEmpresas.Name = "lvEmpresas";
            this.lvEmpresas.Size = new System.Drawing.Size(488, 125);
            this.lvEmpresas.TabIndex = 3;
            this.lvEmpresas.UseCompatibleStateImageBehavior = false;
            this.lvEmpresas.View = System.Windows.Forms.View.Details;
            this.lvEmpresas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvEmpresas_MouseDoubleClick);
            // 
            // chEmpresa
            // 
            this.chEmpresa.Text = "Empresa";
            this.chEmpresa.Width = 484;
            // 
            // BuscarEmpresaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 163);
            this.Controls.Add(this.lvEmpresas);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtFiltro);
            this.Name = "BuscarEmpresaFrm";
            this.Text = "Buscador Empresas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.ListView lvEmpresas;
        private System.Windows.Forms.ColumnHeader chEmpresa;
    }
}