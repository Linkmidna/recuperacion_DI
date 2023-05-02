namespace UniCine_JulioF
{
    partial class BuscarSesionFrm
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
            this.lvSesion = new System.Windows.Forms.ListView();
            this.chSala = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chComienzo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAforo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.cbSala = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDia = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvSesion
            // 
            this.lvSesion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSala,
            this.chDia,
            this.chComienzo,
            this.chFin,
            this.chPrecio,
            this.chAforo});
            this.lvSesion.FullRowSelect = true;
            this.lvSesion.GridLines = true;
            this.lvSesion.HideSelection = false;
            this.lvSesion.Location = new System.Drawing.Point(12, 53);
            this.lvSesion.MultiSelect = false;
            this.lvSesion.Name = "lvSesion";
            this.lvSesion.Size = new System.Drawing.Size(776, 385);
            this.lvSesion.TabIndex = 0;
            this.lvSesion.UseCompatibleStateImageBehavior = false;
            this.lvSesion.View = System.Windows.Forms.View.Details;
            this.lvSesion.DoubleClick += new System.EventHandler(this.lvSesion_DoubleClick);
            // 
            // chSala
            // 
            this.chSala.Text = "Sala";
            // 
            // chDia
            // 
            this.chDia.Text = "Dia";
            // 
            // chComienzo
            // 
            this.chComienzo.Text = "Comienzo";
            // 
            // chFin
            // 
            this.chFin.Text = "Fin";
            // 
            // chPrecio
            // 
            this.chPrecio.Text = "Precio";
            // 
            // chAforo
            // 
            this.chAforo.Text = "Aforo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sala";
            // 
            // cbSala
            // 
            this.cbSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSala.FormattingEnabled = true;
            this.cbSala.Items.AddRange(new object[] {
            "Todo",
            "SALA 1",
            "SALA 2",
            "SALA 3",
            "SALA 4",
            "SALA 5",
            "SALA 6",
            "SALA 7"});
            this.cbSala.Location = new System.Drawing.Point(46, 15);
            this.cbSala.Name = "cbSala";
            this.cbSala.Size = new System.Drawing.Size(121, 21);
            this.cbSala.TabIndex = 2;
            this.cbSala.SelectedIndexChanged += new System.EventHandler(this.cbSala_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dia";
            // 
            // cbDia
            // 
            this.cbDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDia.FormattingEnabled = true;
            this.cbDia.Items.AddRange(new object[] {
            "Todo",
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado",
            "Domingo"});
            this.cbDia.Location = new System.Drawing.Point(228, 15);
            this.cbDia.Name = "cbDia";
            this.cbDia.Size = new System.Drawing.Size(121, 21);
            this.cbDia.TabIndex = 4;
            this.cbDia.SelectedIndexChanged += new System.EventHandler(this.cbDia_SelectedIndexChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(713, 15);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // BuscarSesionFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cbDia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSala);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvSesion);
            this.Name = "BuscarSesionFrm";
            this.Text = "Buscar sesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvSesion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSala;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDia;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ColumnHeader chSala;
        private System.Windows.Forms.ColumnHeader chDia;
        private System.Windows.Forms.ColumnHeader chComienzo;
        private System.Windows.Forms.ColumnHeader chFin;
        private System.Windows.Forms.ColumnHeader chPrecio;
        private System.Windows.Forms.ColumnHeader chAforo;
    }
}