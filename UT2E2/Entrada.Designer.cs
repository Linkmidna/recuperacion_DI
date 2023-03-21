namespace UT2E2
{
    partial class Entrada
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.rbMasc = new System.Windows.Forms.RadioButton();
            this.rbFem = new System.Windows.Forms.RadioButton();
            this.rbNB = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbOtras = new System.Windows.Forms.TextBox();
            this.cbOtras = new System.Windows.Forms.CheckBox();
            this.cbLectura = new System.Windows.Forms.CheckBox();
            this.cbMusica = new System.Windows.Forms.CheckBox();
            this.cbDeportes = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSituacion = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(67, 10);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(216, 20);
            this.tbNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nacimiento:";
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNacimiento.Location = new System.Drawing.Point(83, 44);
            this.dtpNacimiento.MaxDate = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            this.dtpNacimiento.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpNacimiento.TabIndex = 3;
            this.dtpNacimiento.Value = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Género:";
            // 
            // rbMasc
            // 
            this.rbMasc.AutoSize = true;
            this.rbMasc.Checked = true;
            this.rbMasc.Location = new System.Drawing.Point(82, 79);
            this.rbMasc.Name = "rbMasc";
            this.rbMasc.Size = new System.Drawing.Size(73, 17);
            this.rbMasc.TabIndex = 5;
            this.rbMasc.TabStop = true;
            this.rbMasc.Tag = "Masculino";
            this.rbMasc.Text = "Masculino";
            this.rbMasc.UseVisualStyleBackColor = true;
            this.rbMasc.CheckedChanged += new System.EventHandler(this.rButton_CheckedChanged);
            // 
            // rbFem
            // 
            this.rbFem.AutoSize = true;
            this.rbFem.Location = new System.Drawing.Point(161, 79);
            this.rbFem.Name = "rbFem";
            this.rbFem.Size = new System.Drawing.Size(71, 17);
            this.rbFem.TabIndex = 6;
            this.rbFem.Tag = "Femenino";
            this.rbFem.Text = "Femenino";
            this.rbFem.UseVisualStyleBackColor = true;
            this.rbFem.CheckedChanged += new System.EventHandler(this.rButton_CheckedChanged);
            // 
            // rbNB
            // 
            this.rbNB.AutoSize = true;
            this.rbNB.Location = new System.Drawing.Point(243, 79);
            this.rbNB.Name = "rbNB";
            this.rbNB.Size = new System.Drawing.Size(40, 17);
            this.rbNB.TabIndex = 7;
            this.rbNB.Tag = "No binario";
            this.rbNB.Text = "NB";
            this.rbNB.UseVisualStyleBackColor = true;
            this.rbNB.CheckedChanged += new System.EventHandler(this.rButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbOtras);
            this.groupBox1.Controls.Add(this.cbOtras);
            this.groupBox1.Controls.Add(this.cbLectura);
            this.groupBox1.Controls.Add(this.cbMusica);
            this.groupBox1.Controls.Add(this.cbDeportes);
            this.groupBox1.Location = new System.Drawing.Point(15, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 136);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aficiones";
            // 
            // tbOtras
            // 
            this.tbOtras.Enabled = false;
            this.tbOtras.Location = new System.Drawing.Point(6, 43);
            this.tbOtras.Multiline = true;
            this.tbOtras.Name = "tbOtras";
            this.tbOtras.Size = new System.Drawing.Size(256, 87);
            this.tbOtras.TabIndex = 9;
            // 
            // cbOtras
            // 
            this.cbOtras.AutoSize = true;
            this.cbOtras.Location = new System.Drawing.Point(214, 20);
            this.cbOtras.Name = "cbOtras";
            this.cbOtras.Size = new System.Drawing.Size(51, 17);
            this.cbOtras.TabIndex = 3;
            this.cbOtras.Text = "Otras";
            this.cbOtras.UseVisualStyleBackColor = true;
            this.cbOtras.CheckedChanged += new System.EventHandler(this.cbOtras_CheckedChanged);
            // 
            // cbLectura
            // 
            this.cbLectura.AutoSize = true;
            this.cbLectura.Location = new System.Drawing.Point(146, 20);
            this.cbLectura.Name = "cbLectura";
            this.cbLectura.Size = new System.Drawing.Size(62, 17);
            this.cbLectura.TabIndex = 2;
            this.cbLectura.Text = "Lectura";
            this.cbLectura.UseVisualStyleBackColor = true;
            // 
            // cbMusica
            // 
            this.cbMusica.AutoSize = true;
            this.cbMusica.Location = new System.Drawing.Point(82, 20);
            this.cbMusica.Name = "cbMusica";
            this.cbMusica.Size = new System.Drawing.Size(60, 17);
            this.cbMusica.TabIndex = 1;
            this.cbMusica.Text = "Música";
            this.cbMusica.UseVisualStyleBackColor = true;
            // 
            // cbDeportes
            // 
            this.cbDeportes.AutoSize = true;
            this.cbDeportes.Location = new System.Drawing.Point(7, 20);
            this.cbDeportes.Name = "cbDeportes";
            this.cbDeportes.Size = new System.Drawing.Size(69, 17);
            this.cbDeportes.TabIndex = 0;
            this.cbDeportes.Text = "Deportes";
            this.cbDeportes.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Situación:";
            // 
            // cbSituacion
            // 
            this.cbSituacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSituacion.FormattingEnabled = true;
            this.cbSituacion.Items.AddRange(new object[] {
            "Becario",
            "Empleado",
            "Excedencia",
            "Jubilado"});
            this.cbSituacion.Location = new System.Drawing.Point(78, 241);
            this.cbSituacion.Name = "cbSituacion";
            this.cbSituacion.Size = new System.Drawing.Size(205, 21);
            this.cbSituacion.TabIndex = 10;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(208, 268);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(127, 268);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(75, 23);
            this.btnReiniciar.TabIndex = 12;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // Entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 297);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cbSituacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbNB);
            this.Controls.Add(this.rbFem);
            this.Controls.Add(this.rbMasc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpNacimiento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Entrada";
            this.Text = "Ficha de socio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbMasc;
        private System.Windows.Forms.RadioButton rbFem;
        private System.Windows.Forms.RadioButton rbNB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbOtras;
        private System.Windows.Forms.CheckBox cbOtras;
        private System.Windows.Forms.CheckBox cbLectura;
        private System.Windows.Forms.CheckBox cbMusica;
        private System.Windows.Forms.CheckBox cbDeportes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSituacion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnReiniciar;
    }
}

