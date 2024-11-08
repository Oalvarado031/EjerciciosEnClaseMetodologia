namespace InterfazClaseViernes11Nov
{
    partial class Form1
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDiasTrabajados = new System.Windows.Forms.Label();
            this.lblPagoDia = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtSalarioDia = new System.Windows.Forms.TextBox();
            this.txtDiasLab = new System.Windows.Forms.TextBox();
            this.btnGuardarRegistro = new System.Windows.Forms.Button();
            this.btnCalcularSalario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDevengado = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(135, 47);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(121, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cálculo nómina de pago";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(53, 98);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "Número:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(53, 128);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDiasTrabajados
            // 
            this.lblDiasTrabajados.AutoSize = true;
            this.lblDiasTrabajados.Location = new System.Drawing.Point(33, 166);
            this.lblDiasTrabajados.Name = "lblDiasTrabajados";
            this.lblDiasTrabajados.Size = new System.Drawing.Size(83, 13);
            this.lblDiasTrabajados.TabIndex = 3;
            this.lblDiasTrabajados.Text = "Dias trabajados:";
            // 
            // lblPagoDia
            // 
            this.lblPagoDia.AutoSize = true;
            this.lblPagoDia.Location = new System.Drawing.Point(35, 195);
            this.lblPagoDia.Name = "lblPagoDia";
            this.lblPagoDia.Size = new System.Drawing.Size(72, 13);
            this.lblPagoDia.TabIndex = 4;
            this.lblPagoDia.Text = "Pago por día:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(122, 95);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(111, 20);
            this.txtNumero.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(122, 128);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(111, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtSalarioDia
            // 
            this.txtSalarioDia.Location = new System.Drawing.Point(122, 195);
            this.txtSalarioDia.Name = "txtSalarioDia";
            this.txtSalarioDia.Size = new System.Drawing.Size(111, 20);
            this.txtSalarioDia.TabIndex = 7;
            // 
            // txtDiasLab
            // 
            this.txtDiasLab.Location = new System.Drawing.Point(122, 163);
            this.txtDiasLab.Name = "txtDiasLab";
            this.txtDiasLab.Size = new System.Drawing.Size(111, 20);
            this.txtDiasLab.TabIndex = 8;
            // 
            // btnGuardarRegistro
            // 
            this.btnGuardarRegistro.Location = new System.Drawing.Point(111, 234);
            this.btnGuardarRegistro.Name = "btnGuardarRegistro";
            this.btnGuardarRegistro.Size = new System.Drawing.Size(145, 23);
            this.btnGuardarRegistro.TabIndex = 9;
            this.btnGuardarRegistro.Text = "Guardar registro";
            this.btnGuardarRegistro.UseVisualStyleBackColor = true;
            this.btnGuardarRegistro.Click += new System.EventHandler(this.btnGuardarRegistro_Click);
            // 
            // btnCalcularSalario
            // 
            this.btnCalcularSalario.Location = new System.Drawing.Point(122, 277);
            this.btnCalcularSalario.Name = "btnCalcularSalario";
            this.btnCalcularSalario.Size = new System.Drawing.Size(128, 30);
            this.btnCalcularSalario.TabIndex = 10;
            this.btnCalcularSalario.Text = "Calcular salario";
            this.btnCalcularSalario.UseVisualStyleBackColor = true;
            this.btnCalcularSalario.Click += new System.EventHandler(this.btnCalcularSalario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Total devengado:";
            // 
            // txtDevengado
            // 
            this.txtDevengado.Location = new System.Drawing.Point(156, 336);
            this.txtDevengado.Name = "txtDevengado";
            this.txtDevengado.Size = new System.Drawing.Size(100, 20);
            this.txtDevengado.TabIndex = 12;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(36, 383);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(51, 33);
            this.btnNuevo.TabIndex = 13;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(272, 383);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(62, 33);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtDevengado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcularSalario);
            this.Controls.Add(this.btnGuardarRegistro);
            this.Controls.Add(this.txtDiasLab);
            this.Controls.Add(this.txtSalarioDia);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblPagoDia);
            this.Controls.Add(this.lblDiasTrabajados);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Formulario Nómina";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDiasTrabajados;
        private System.Windows.Forms.Label lblPagoDia;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtSalarioDia;
        private System.Windows.Forms.TextBox txtDiasLab;
        private System.Windows.Forms.Button btnGuardarRegistro;
        private System.Windows.Forms.Button btnCalcularSalario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDevengado;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnSalir;
    }
}

