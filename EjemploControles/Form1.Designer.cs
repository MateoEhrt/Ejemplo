namespace EjemploControles
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lwElementos = new System.Windows.Forms.ListView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.ckbFamilia = new System.Windows.Forms.CheckBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.rbtSoltero = new System.Windows.Forms.RadioButton();
            this.rbtCasado = new System.Windows.Forms.RadioButton();
            this.rbtDivorciado = new System.Windows.Forms.RadioButton();
            this.gbxEstado = new System.Windows.Forms.GroupBox();
            this.lblDisponibilidad = new System.Windows.Forms.Label();
            this.cboDisponibilidad = new System.Windows.Forms.ComboBox();
            this.lblPersonas = new System.Windows.Forms.Label();
            this.numPersonas = new System.Windows.Forms.NumericUpDown();
            this.btnVerPerfil = new System.Windows.Forms.Button();
            this.gbxEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(189, 83);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(245, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(113, 511);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 34);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lwElementos
            // 
            this.lwElementos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lwElementos.HideSelection = false;
            this.lwElementos.Location = new System.Drawing.Point(143, 352);
            this.lwElementos.Name = "lwElementos";
            this.lwElementos.Size = new System.Drawing.Size(267, 133);
            this.lwElementos.TabIndex = 7;
            this.lwElementos.UseCompatibleStateImageBehavior = false;
            this.lwElementos.View = System.Windows.Forms.View.List;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(56, 86);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(118, 16);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre completo:";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(55, 116);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(119, 16);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha Nacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(189, 111);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(245, 22);
            this.dtpFechaNacimiento.TabIndex = 1;
            this.dtpFechaNacimiento.ValueChanged += new System.EventHandler(this.dtpFechaNacimiento_ValueChanged);
            // 
            // ckbFamilia
            // 
            this.ckbFamilia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbFamilia.AutoSize = true;
            this.ckbFamilia.Location = new System.Drawing.Point(189, 139);
            this.ckbFamilia.Name = "ckbFamilia";
            this.ckbFamilia.Size = new System.Drawing.Size(221, 20);
            this.ckbFamilia.TabIndex = 2;
            this.ckbFamilia.Text = "Tiene familiares en la empresa?";
            this.ckbFamilia.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(9, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(225, 38);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Perfil personal";
            // 
            // rbtSoltero
            // 
            this.rbtSoltero.AutoSize = true;
            this.rbtSoltero.Checked = true;
            this.rbtSoltero.Location = new System.Drawing.Point(26, 38);
            this.rbtSoltero.Name = "rbtSoltero";
            this.rbtSoltero.Size = new System.Drawing.Size(71, 20);
            this.rbtSoltero.TabIndex = 8;
            this.rbtSoltero.TabStop = true;
            this.rbtSoltero.Text = "Soltero";
            this.rbtSoltero.UseVisualStyleBackColor = true;
            // 
            // rbtCasado
            // 
            this.rbtCasado.AutoSize = true;
            this.rbtCasado.Location = new System.Drawing.Point(187, 38);
            this.rbtCasado.Name = "rbtCasado";
            this.rbtCasado.Size = new System.Drawing.Size(76, 20);
            this.rbtCasado.TabIndex = 9;
            this.rbtCasado.Text = "Casado";
            this.rbtCasado.UseVisualStyleBackColor = true;
            // 
            // rbtDivorciado
            // 
            this.rbtDivorciado.AutoSize = true;
            this.rbtDivorciado.Location = new System.Drawing.Point(359, 38);
            this.rbtDivorciado.Name = "rbtDivorciado";
            this.rbtDivorciado.Size = new System.Drawing.Size(94, 20);
            this.rbtDivorciado.TabIndex = 10;
            this.rbtDivorciado.Text = "Divorciado";
            this.rbtDivorciado.UseVisualStyleBackColor = true;
            // 
            // gbxEstado
            // 
            this.gbxEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxEstado.Controls.Add(this.rbtDivorciado);
            this.gbxEstado.Controls.Add(this.rbtSoltero);
            this.gbxEstado.Controls.Add(this.rbtCasado);
            this.gbxEstado.Location = new System.Drawing.Point(35, 165);
            this.gbxEstado.Name = "gbxEstado";
            this.gbxEstado.Size = new System.Drawing.Size(489, 83);
            this.gbxEstado.TabIndex = 3;
            this.gbxEstado.TabStop = false;
            this.gbxEstado.Text = "Estado civil";
            // 
            // lblDisponibilidad
            // 
            this.lblDisponibilidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDisponibilidad.AutoSize = true;
            this.lblDisponibilidad.Location = new System.Drawing.Point(32, 254);
            this.lblDisponibilidad.Name = "lblDisponibilidad";
            this.lblDisponibilidad.Size = new System.Drawing.Size(142, 16);
            this.lblDisponibilidad.TabIndex = 12;
            this.lblDisponibilidad.Text = "Disponibilidad horaria:";
            // 
            // cboDisponibilidad
            // 
            this.cboDisponibilidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDisponibilidad.FormattingEnabled = true;
            this.cboDisponibilidad.Location = new System.Drawing.Point(189, 251);
            this.cboDisponibilidad.Name = "cboDisponibilidad";
            this.cboDisponibilidad.Size = new System.Drawing.Size(245, 24);
            this.cboDisponibilidad.TabIndex = 4;
            // 
            // lblPersonas
            // 
            this.lblPersonas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPersonas.AutoSize = true;
            this.lblPersonas.Location = new System.Drawing.Point(55, 284);
            this.lblPersonas.Name = "lblPersonas";
            this.lblPersonas.Size = new System.Drawing.Size(117, 16);
            this.lblPersonas.TabIndex = 15;
            this.lblPersonas.Text = "Personas a cargo:";
            // 
            // numPersonas
            // 
            this.numPersonas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numPersonas.Location = new System.Drawing.Point(189, 282);
            this.numPersonas.Name = "numPersonas";
            this.numPersonas.Size = new System.Drawing.Size(245, 22);
            this.numPersonas.TabIndex = 5;
            // 
            // btnVerPerfil
            // 
            this.btnVerPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerPerfil.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnVerPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerPerfil.Location = new System.Drawing.Point(113, 310);
            this.btnVerPerfil.Name = "btnVerPerfil";
            this.btnVerPerfil.Size = new System.Drawing.Size(75, 36);
            this.btnVerPerfil.TabIndex = 6;
            this.btnVerPerfil.Text = "Ver perfil";
            this.btnVerPerfil.UseVisualStyleBackColor = true;
            this.btnVerPerfil.Click += new System.EventHandler(this.btnVerPerfil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(571, 572);
            this.Controls.Add(this.btnVerPerfil);
            this.Controls.Add(this.numPersonas);
            this.Controls.Add(this.lblPersonas);
            this.Controls.Add(this.cboDisponibilidad);
            this.Controls.Add(this.lblDisponibilidad);
            this.Controls.Add(this.gbxEstado);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.ckbFamilia);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lwElementos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1034, 749);
            this.MinimumSize = new System.Drawing.Size(589, 619);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxEstado.ResumeLayout(false);
            this.gbxEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListView lwElementos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.CheckBox ckbFamilia;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RadioButton rbtSoltero;
        private System.Windows.Forms.RadioButton rbtCasado;
        private System.Windows.Forms.RadioButton rbtDivorciado;
        private System.Windows.Forms.GroupBox gbxEstado;
        private System.Windows.Forms.Label lblDisponibilidad;
        private System.Windows.Forms.ComboBox cboDisponibilidad;
        private System.Windows.Forms.Label lblPersonas;
        private System.Windows.Forms.NumericUpDown numPersonas;
        private System.Windows.Forms.Button btnVerPerfil;
    }
}

