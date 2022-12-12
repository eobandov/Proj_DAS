
namespace Proj_DAS
{
    partial class PersonalPax
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContr = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgPax = new System.Windows.Forms.DataGridView();
            this.id_Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dgDomicilio = new System.Windows.Forms.DataGridView();
            this.num_Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Paciente1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canton = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otrasSenhas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgPax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDomicilio)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(112, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 23);
            this.label3.TabIndex = 63;
            this.label3.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(39, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 23);
            this.label4.TabIndex = 62;
            this.label4.Text = "Nombre de Usuario";
            // 
            // txtContr
            // 
            this.txtContr.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContr.Location = new System.Drawing.Point(307, 474);
            this.txtContr.Margin = new System.Windows.Forms.Padding(4);
            this.txtContr.Name = "txtContr";
            this.txtContr.Size = new System.Drawing.Size(223, 28);
            this.txtContr.TabIndex = 61;
            this.txtContr.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(307, 432);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(223, 28);
            this.txtUsuario.TabIndex = 60;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(78, 519);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(7, 39);
            this.panel1.TabIndex = 67;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(78, 519);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(320, 39);
            this.btnAgregar.TabIndex = 66;
            this.btnAgregar.Text = "Agregar nuevo usuario";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgPax
            // 
            this.dgPax.AllowUserToAddRows = false;
            this.dgPax.AllowUserToDeleteRows = false;
            this.dgPax.BackgroundColor = System.Drawing.Color.Thistle;
            this.dgPax.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPax.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Paciente,
            this.nombre,
            this.apellido1,
            this.apellido2,
            this.edad,
            this.tel,
            this.correo});
            this.dgPax.Location = new System.Drawing.Point(43, 88);
            this.dgPax.Name = "dgPax";
            this.dgPax.RowHeadersWidth = 51;
            this.dgPax.RowTemplate.Height = 24;
            this.dgPax.Size = new System.Drawing.Size(1025, 105);
            this.dgPax.TabIndex = 68;
            this.dgPax.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgPax_RowValidating);
            // 
            // id_Paciente
            // 
            this.id_Paciente.DataPropertyName = "id_Paciente";
            this.id_Paciente.HeaderText = "Id ";
            this.id_Paciente.MinimumWidth = 6;
            this.id_Paciente.Name = "id_Paciente";
            this.id_Paciente.ReadOnly = true;
            this.id_Paciente.Width = 125;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 125;
            // 
            // apellido1
            // 
            this.apellido1.DataPropertyName = "apellido1";
            this.apellido1.HeaderText = "Apellido Paterno";
            this.apellido1.MinimumWidth = 6;
            this.apellido1.Name = "apellido1";
            this.apellido1.ReadOnly = true;
            this.apellido1.Width = 125;
            // 
            // apellido2
            // 
            this.apellido2.DataPropertyName = "apellido2";
            this.apellido2.HeaderText = "Apellido Materno";
            this.apellido2.MinimumWidth = 6;
            this.apellido2.Name = "apellido2";
            this.apellido2.ReadOnly = true;
            this.apellido2.Width = 125;
            // 
            // edad
            // 
            this.edad.DataPropertyName = "edad";
            this.edad.HeaderText = "Edad";
            this.edad.MinimumWidth = 6;
            this.edad.Name = "edad";
            this.edad.ReadOnly = true;
            this.edad.Width = 125;
            // 
            // tel
            // 
            this.tel.DataPropertyName = "tel";
            this.tel.HeaderText = "Telefono";
            this.tel.MinimumWidth = 6;
            this.tel.Name = "tel";
            this.tel.ReadOnly = true;
            this.tel.Width = 125;
            // 
            // correo
            // 
            this.correo.DataPropertyName = "correo";
            this.correo.HeaderText = "Correo";
            this.correo.MinimumWidth = 6;
            this.correo.Name = "correo";
            this.correo.ReadOnly = true;
            this.correo.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 30);
            this.label1.TabIndex = 69;
            this.label1.Text = "Datos Personales - Paciente";
            // 
            // dgDomicilio
            // 
            this.dgDomicilio.AllowUserToAddRows = false;
            this.dgDomicilio.AllowUserToDeleteRows = false;
            this.dgDomicilio.BackgroundColor = System.Drawing.Color.Thistle;
            this.dgDomicilio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDomicilio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num_Provincia,
            this.num_Domicilio,
            this.id_Paciente1,
            this.canton,
            this.Distrito,
            this.otrasSenhas});
            this.dgDomicilio.Location = new System.Drawing.Point(43, 208);
            this.dgDomicilio.Name = "dgDomicilio";
            this.dgDomicilio.RowHeadersWidth = 51;
            this.dgDomicilio.RowTemplate.Height = 24;
            this.dgDomicilio.Size = new System.Drawing.Size(1025, 105);
            this.dgDomicilio.TabIndex = 70;
            this.dgDomicilio.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgDomicilio_RowValidating);
            // 
            // num_Provincia
            // 
            this.num_Provincia.DataPropertyName = "num_Provincia";
            this.num_Provincia.HeaderText = "num_Provincia";
            this.num_Provincia.MinimumWidth = 6;
            this.num_Provincia.Name = "num_Provincia";
            this.num_Provincia.ReadOnly = true;
            this.num_Provincia.Width = 125;
            // 
            // num_Domicilio
            // 
            this.num_Domicilio.DataPropertyName = "num_Domicilio";
            this.num_Domicilio.HeaderText = "num_Domicilio";
            this.num_Domicilio.MinimumWidth = 6;
            this.num_Domicilio.Name = "num_Domicilio";
            this.num_Domicilio.ReadOnly = true;
            this.num_Domicilio.Width = 125;
            // 
            // id_Paciente1
            // 
            this.id_Paciente1.DataPropertyName = "id_Paciente1";
            this.id_Paciente1.HeaderText = "id_Paciente";
            this.id_Paciente1.MinimumWidth = 6;
            this.id_Paciente1.Name = "id_Paciente1";
            this.id_Paciente1.ReadOnly = true;
            this.id_Paciente1.Width = 125;
            // 
            // canton
            // 
            this.canton.DataPropertyName = "canton";
            this.canton.HeaderText = "canton";
            this.canton.MinimumWidth = 6;
            this.canton.Name = "canton";
            this.canton.ReadOnly = true;
            this.canton.Width = 125;
            // 
            // Distrito
            // 
            this.Distrito.DataPropertyName = "Distrito";
            this.Distrito.HeaderText = "Distrito";
            this.Distrito.MinimumWidth = 6;
            this.Distrito.Name = "Distrito";
            this.Distrito.ReadOnly = true;
            this.Distrito.Width = 125;
            // 
            // otrasSenhas
            // 
            this.otrasSenhas.DataPropertyName = "otrasSenhas";
            this.otrasSenhas.HeaderText = "Otras Señas";
            this.otrasSenhas.MinimumWidth = 6;
            this.otrasSenhas.Name = "otrasSenhas";
            this.otrasSenhas.ReadOnly = true;
            this.otrasSenhas.Width = 125;
            // 
            // PersonalPax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(1237, 827);
            this.Controls.Add(this.dgDomicilio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgPax);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtContr);
            this.Controls.Add(this.txtUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonalPax";
            this.Text = "Personal";
            ((System.ComponentModel.ISupportInitialize)(this.dgPax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDomicilio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContr;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgPax;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido1;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido2;
        private System.Windows.Forms.DataGridViewTextBoxColumn edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgDomicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_Provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_Domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Paciente1;
        private System.Windows.Forms.DataGridViewTextBoxColumn canton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn otrasSenhas;
    }
}