
namespace Proj_DAS
{
    partial class PersonalEmp
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
            this.dgEmp = new System.Windows.Forms.DataGridView();
            this.id_Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEmp
            // 
            this.dgEmp.AllowUserToAddRows = false;
            this.dgEmp.AllowUserToDeleteRows = false;
            this.dgEmp.BackgroundColor = System.Drawing.Color.Thistle;
            this.dgEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Empleado,
            this.nombre,
            this.apellido1,
            this.apellido2,
            this.tel,
            this.correo,
            this.num_Cargo,
            this.id_Horario});
            this.dgEmp.Location = new System.Drawing.Point(32, 74);
            this.dgEmp.Name = "dgEmp";
            this.dgEmp.RowHeadersWidth = 51;
            this.dgEmp.RowTemplate.Height = 24;
            this.dgEmp.Size = new System.Drawing.Size(1142, 265);
            this.dgEmp.TabIndex = 69;
            // 
            // id_Empleado
            // 
            this.id_Empleado.DataPropertyName = "id_Empleado";
            this.id_Empleado.HeaderText = "Id ";
            this.id_Empleado.MinimumWidth = 6;
            this.id_Empleado.Name = "id_Empleado";
            this.id_Empleado.Width = 125;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.Width = 125;
            // 
            // apellido1
            // 
            this.apellido1.DataPropertyName = "apellido1";
            this.apellido1.HeaderText = "Apellido Paterno";
            this.apellido1.MinimumWidth = 6;
            this.apellido1.Name = "apellido1";
            this.apellido1.Width = 125;
            // 
            // apellido2
            // 
            this.apellido2.DataPropertyName = "apellido2";
            this.apellido2.HeaderText = "Apellido Materno";
            this.apellido2.MinimumWidth = 6;
            this.apellido2.Name = "apellido2";
            this.apellido2.Width = 125;
            // 
            // tel
            // 
            this.tel.DataPropertyName = "tel";
            this.tel.HeaderText = "Telefono";
            this.tel.MinimumWidth = 6;
            this.tel.Name = "tel";
            this.tel.Width = 125;
            // 
            // correo
            // 
            this.correo.DataPropertyName = "correo";
            this.correo.HeaderText = "Correo";
            this.correo.MinimumWidth = 6;
            this.correo.Name = "correo";
            this.correo.Width = 125;
            // 
            // num_Cargo
            // 
            this.num_Cargo.DataPropertyName = "num_Cargo";
            this.num_Cargo.HeaderText = "Cargo";
            this.num_Cargo.MinimumWidth = 6;
            this.num_Cargo.Name = "num_Cargo";
            this.num_Cargo.Width = 125;
            // 
            // id_Horario
            // 
            this.id_Horario.DataPropertyName = "id_Horario";
            this.id_Horario.HeaderText = "Horario";
            this.id_Horario.MinimumWidth = 6;
            this.id_Horario.Name = "id_Horario";
            this.id_Horario.Width = 125;
            // 
            // PersonalEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(1287, 859);
            this.Controls.Add(this.dgEmp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonalEmp";
            this.Text = "PersonalEmp";
            ((System.ComponentModel.ISupportInitialize)(this.dgEmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido1;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Horario;
    }
}