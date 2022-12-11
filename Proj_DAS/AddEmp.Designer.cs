
namespace Proj_DAS
{
    partial class AddEmp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmp));
            this.dgEmp = new System.Windows.Forms.DataGridView();
            this.id_Empleado1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSEmpleados = new Proj_DAS.DSEmpleados();
            this.label1 = new System.Windows.Forms.Label();
            this.empleadosTableAdapter = new Proj_DAS.DSEmpleadosTableAdapters.EmpleadosTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEmp
            // 
            this.dgEmp.AutoGenerateColumns = false;
            this.dgEmp.BackgroundColor = System.Drawing.Color.Thistle;
            this.dgEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Empleado1,
            this.nombre1,
            this.apellido11,
            this.apellido21,
            this.tel1,
            this.correo1,
            this.num_Cargo,
            this.id_Horario});
            this.dgEmp.DataSource = this.empleadosBindingSource;
            this.dgEmp.Location = new System.Drawing.Point(35, 144);
            this.dgEmp.Name = "dgEmp";
            this.dgEmp.RowHeadersWidth = 51;
            this.dgEmp.RowTemplate.Height = 24;
            this.dgEmp.Size = new System.Drawing.Size(1178, 466);
            this.dgEmp.TabIndex = 44;
            this.dgEmp.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgEmp_RowValidating);
            this.dgEmp.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgEmp_UserDeletingRow);
            // 
            // id_Empleado1
            // 
            this.id_Empleado1.DataPropertyName = "id_Empleado";
            this.id_Empleado1.HeaderText = "Id Empleado";
            this.id_Empleado1.MinimumWidth = 6;
            this.id_Empleado1.Name = "id_Empleado1";
            this.id_Empleado1.ReadOnly = true;
            this.id_Empleado1.Width = 125;
            // 
            // nombre1
            // 
            this.nombre1.DataPropertyName = "nombre";
            this.nombre1.HeaderText = "Nombre";
            this.nombre1.MinimumWidth = 6;
            this.nombre1.Name = "nombre1";
            this.nombre1.Width = 125;
            // 
            // apellido11
            // 
            this.apellido11.DataPropertyName = "apellido1";
            this.apellido11.HeaderText = "Apellido Paterno";
            this.apellido11.MinimumWidth = 6;
            this.apellido11.Name = "apellido11";
            this.apellido11.Width = 125;
            // 
            // apellido21
            // 
            this.apellido21.DataPropertyName = "apellido2";
            this.apellido21.HeaderText = "Apellido Materno";
            this.apellido21.MinimumWidth = 6;
            this.apellido21.Name = "apellido21";
            this.apellido21.Width = 125;
            // 
            // tel1
            // 
            this.tel1.DataPropertyName = "tel";
            this.tel1.HeaderText = "Telefono";
            this.tel1.MinimumWidth = 6;
            this.tel1.Name = "tel1";
            this.tel1.Width = 125;
            // 
            // correo1
            // 
            this.correo1.DataPropertyName = "correo";
            this.correo1.HeaderText = "Correo";
            this.correo1.MinimumWidth = 6;
            this.correo1.Name = "correo1";
            this.correo1.Width = 125;
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
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "Empleados";
            this.empleadosBindingSource.DataSource = this.dSEmpleados;
            // 
            // dSEmpleados
            // 
            this.dSEmpleados.DataSetName = "DSEmpleados";
            this.dSEmpleados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(44, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(623, 30);
            this.label1.TabIndex = 51;
            this.label1.Text = "Empleados - Creación, Modificación y eliminación";
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(1231, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(402, 697);
            this.label2.TabIndex = 52;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(985, 617);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(7, 39);
            this.panel1.TabIndex = 54;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(989, 617);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 39);
            this.button1.TabIndex = 53;
            this.button1.Text = "Actualizar tabla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgEmp);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEmp";
            this.Text = "AddEmp";
            this.Load += new System.EventHandler(this.AddEmp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido1;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Empleado3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Empleado2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Empleado4;
        private System.Windows.Forms.Label label1;
        private DSEmpleados dSEmpleados;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private DSEmpleadosTableAdapters.EmpleadosTableAdapter empleadosTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Empleado1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre1;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido11;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido21;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Horario;
    }
}