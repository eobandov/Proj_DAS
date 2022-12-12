
namespace Proj_DAS
{
    partial class PersonalMed
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgMed = new System.Windows.Forms.DataGridView();
            this.cod_Medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContr = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgMed)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 30);
            this.label1.TabIndex = 70;
            this.label1.Text = "Datos Personales - Medico\r\n";
            // 
            // dgMed
            // 
            this.dgMed.AllowUserToAddRows = false;
            this.dgMed.AllowUserToDeleteRows = false;
            this.dgMed.BackgroundColor = System.Drawing.Color.Thistle;
            this.dgMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_Medico,
            this.nombre,
            this.apellido1,
            this.apellido2,
            this.tel,
            this.correo});
            this.dgMed.Location = new System.Drawing.Point(17, 55);
            this.dgMed.Name = "dgMed";
            this.dgMed.RowHeadersWidth = 51;
            this.dgMed.RowTemplate.Height = 24;
            this.dgMed.Size = new System.Drawing.Size(1051, 133);
            this.dgMed.TabIndex = 71;
            this.dgMed.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgMed_RowValidating);
            // 
            // cod_Medico
            // 
            this.cod_Medico.DataPropertyName = "cod_Medico";
            this.cod_Medico.HeaderText = "cod_Medico";
            this.cod_Medico.MinimumWidth = 6;
            this.cod_Medico.Name = "cod_Medico";
            this.cod_Medico.Width = 125;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.Width = 125;
            // 
            // apellido1
            // 
            this.apellido1.DataPropertyName = "apellido1";
            this.apellido1.HeaderText = "apellido1";
            this.apellido1.MinimumWidth = 6;
            this.apellido1.Name = "apellido1";
            this.apellido1.Width = 125;
            // 
            // apellido2
            // 
            this.apellido2.DataPropertyName = "apellido2";
            this.apellido2.HeaderText = "apellido2";
            this.apellido2.MinimumWidth = 6;
            this.apellido2.Name = "apellido2";
            this.apellido2.Width = 125;
            // 
            // tel
            // 
            this.tel.DataPropertyName = "tel";
            this.tel.HeaderText = "tel";
            this.tel.MinimumWidth = 6;
            this.tel.Name = "tel";
            this.tel.Width = 125;
            // 
            // correo
            // 
            this.correo.DataPropertyName = "correo";
            this.correo.HeaderText = "correo";
            this.correo.MinimumWidth = 6;
            this.correo.Name = "correo";
            this.correo.Width = 125;
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
            this.btnAgregar.Location = new System.Drawing.Point(72, 307);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(320, 39);
            this.btnAgregar.TabIndex = 76;
            this.btnAgregar.Text = "Agregar nuevo usuario";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(106, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 23);
            this.label3.TabIndex = 75;
            this.label3.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(33, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 23);
            this.label4.TabIndex = 74;
            this.label4.Text = "Nombre de Usuario";
            // 
            // txtContr
            // 
            this.txtContr.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContr.Location = new System.Drawing.Point(301, 262);
            this.txtContr.Margin = new System.Windows.Forms.Padding(4);
            this.txtContr.Name = "txtContr";
            this.txtContr.Size = new System.Drawing.Size(223, 28);
            this.txtContr.TabIndex = 73;
            this.txtContr.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(301, 220);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(223, 28);
            this.txtUsuario.TabIndex = 72;
            // 
            // PersonalMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(1139, 591);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtContr);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.dgMed);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonalMed";
            this.Text = "PersonalMed";
            ((System.ComponentModel.ISupportInitialize)(this.dgMed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgMed;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_Medico;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido1;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContr;
        private System.Windows.Forms.TextBox txtUsuario;
    }
}