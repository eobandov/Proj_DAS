
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
            this.dgEmp = new System.Windows.Forms.DataGridView();
            this.id_Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citasMedicasDataSet3 = new Proj_DAS.CitasMedicasDataSet3();
            this.empleadosTableAdapter = new Proj_DAS.CitasMedicasDataSet3TableAdapters.EmpleadosTableAdapter();
            this.dgCorreo = new System.Windows.Forms.DataGridView();
            this.id_Empleado2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoEmpleadosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.citasMedicasDataSet8 = new Proj_DAS.CitasMedicasDataSet8();
            this.citasMedicasDataSet4 = new Proj_DAS.CitasMedicasDataSet4();
            this.correoEmpleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.correo_EmpleadosTableAdapter = new Proj_DAS.CitasMedicasDataSet4TableAdapters.Correo_EmpleadosTableAdapter();
            this.citasMedicasDataSet5 = new Proj_DAS.CitasMedicasDataSet5();
            this.correoEmpleadosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.correo_EmpleadosTableAdapter1 = new Proj_DAS.CitasMedicasDataSet5TableAdapters.Correo_EmpleadosTableAdapter();
            this.dgHorario = new System.Windows.Forms.DataGridView();
            this.id_Empleado3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dia_Inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dia_Final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioEmpleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citasMedicasDataSet6 = new Proj_DAS.CitasMedicasDataSet6();
            this.horario_EmpleadosTableAdapter = new Proj_DAS.CitasMedicasDataSet6TableAdapters.Horario_EmpleadosTableAdapter();
            this.dgCargo = new System.Windows.Forms.DataGridView();
            this.id_Empleado4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoEmpleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citasMedicasDataSet7 = new Proj_DAS.CitasMedicasDataSet7();
            this.cargo_EmpleadosTableAdapter = new Proj_DAS.CitasMedicasDataSet7TableAdapters.Cargo_EmpleadosTableAdapter();
            this.correo_EmpleadosTableAdapter2 = new Proj_DAS.CitasMedicasDataSet8TableAdapters.Correo_EmpleadosTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasMedicasDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCorreo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.correoEmpleadosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasMedicasDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasMedicasDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.correoEmpleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasMedicasDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.correoEmpleadosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgHorario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horarioEmpleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasMedicasDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoEmpleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasMedicasDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEmp
            // 
            this.dgEmp.AutoGenerateColumns = false;
            this.dgEmp.BackgroundColor = System.Drawing.Color.Thistle;
            this.dgEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Empleado,
            this.nombre,
            this.apellido1,
            this.apellido2,
            this.tel});
            this.dgEmp.DataSource = this.empleadosBindingSource;
            this.dgEmp.Location = new System.Drawing.Point(12, 64);
            this.dgEmp.Name = "dgEmp";
            this.dgEmp.RowHeadersWidth = 51;
            this.dgEmp.RowTemplate.Height = 24;
            this.dgEmp.Size = new System.Drawing.Size(1391, 265);
            this.dgEmp.TabIndex = 44;
            this.dgEmp.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgEmp_RowValidating);
            this.dgEmp.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgEmp_UserDeletingRow);
            // 
            // id_Empleado
            // 
            this.id_Empleado.DataPropertyName = "id_Empleado";
            this.id_Empleado.HeaderText = "id_Empleado";
            this.id_Empleado.MinimumWidth = 6;
            this.id_Empleado.Name = "id_Empleado";
            this.id_Empleado.Width = 125;
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
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "Empleados";
            this.empleadosBindingSource.DataSource = this.citasMedicasDataSet3;
            // 
            // citasMedicasDataSet3
            // 
            this.citasMedicasDataSet3.DataSetName = "CitasMedicasDataSet3";
            this.citasMedicasDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // dgCorreo
            // 
            this.dgCorreo.AutoGenerateColumns = false;
            this.dgCorreo.BackgroundColor = System.Drawing.Color.Thistle;
            this.dgCorreo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCorreo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Empleado2,
            this.num_Correo,
            this.correo});
            this.dgCorreo.DataSource = this.correoEmpleadosBindingSource2;
            this.dgCorreo.Location = new System.Drawing.Point(12, 346);
            this.dgCorreo.Name = "dgCorreo";
            this.dgCorreo.RowHeadersWidth = 51;
            this.dgCorreo.RowTemplate.Height = 24;
            this.dgCorreo.Size = new System.Drawing.Size(748, 265);
            this.dgCorreo.TabIndex = 45;
            this.dgCorreo.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgCorreo_RowValidating);
            this.dgCorreo.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgCorreo_UserDeletingRow);
            // 
            // id_Empleado2
            // 
            this.id_Empleado2.DataPropertyName = "id_Empleado";
            this.id_Empleado2.HeaderText = "id_Empleado";
            this.id_Empleado2.MinimumWidth = 6;
            this.id_Empleado2.Name = "id_Empleado2";
            this.id_Empleado2.Width = 125;
            // 
            // num_Correo
            // 
            this.num_Correo.DataPropertyName = "num_Correo";
            this.num_Correo.HeaderText = "num_Correo";
            this.num_Correo.MinimumWidth = 6;
            this.num_Correo.Name = "num_Correo";
            this.num_Correo.Width = 125;
            // 
            // correo
            // 
            this.correo.DataPropertyName = "correo";
            this.correo.HeaderText = "correo";
            this.correo.MinimumWidth = 6;
            this.correo.Name = "correo";
            this.correo.Width = 125;
            // 
            // correoEmpleadosBindingSource2
            // 
            this.correoEmpleadosBindingSource2.DataMember = "Correo_Empleados";
            this.correoEmpleadosBindingSource2.DataSource = this.citasMedicasDataSet8;
            // 
            // citasMedicasDataSet8
            // 
            this.citasMedicasDataSet8.DataSetName = "CitasMedicasDataSet8";
            this.citasMedicasDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // citasMedicasDataSet4
            // 
            this.citasMedicasDataSet4.DataSetName = "CitasMedicasDataSet4";
            this.citasMedicasDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // correoEmpleadosBindingSource
            // 
            this.correoEmpleadosBindingSource.DataMember = "Correo_Empleados";
            this.correoEmpleadosBindingSource.DataSource = this.citasMedicasDataSet4;
            // 
            // correo_EmpleadosTableAdapter
            // 
            this.correo_EmpleadosTableAdapter.ClearBeforeFill = true;
            // 
            // citasMedicasDataSet5
            // 
            this.citasMedicasDataSet5.DataSetName = "CitasMedicasDataSet5";
            this.citasMedicasDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // correoEmpleadosBindingSource1
            // 
            this.correoEmpleadosBindingSource1.DataMember = "Correo_Empleados";
            this.correoEmpleadosBindingSource1.DataSource = this.citasMedicasDataSet5;
            // 
            // correo_EmpleadosTableAdapter1
            // 
            this.correo_EmpleadosTableAdapter1.ClearBeforeFill = true;
            // 
            // dgHorario
            // 
            this.dgHorario.AutoGenerateColumns = false;
            this.dgHorario.BackgroundColor = System.Drawing.Color.Thistle;
            this.dgHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHorario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Empleado3,
            this.id_Horario,
            this.dia_Inicio,
            this.dia_Final});
            this.dgHorario.DataSource = this.horarioEmpleadosBindingSource;
            this.dgHorario.Location = new System.Drawing.Point(12, 617);
            this.dgHorario.Name = "dgHorario";
            this.dgHorario.RowHeadersWidth = 51;
            this.dgHorario.RowTemplate.Height = 24;
            this.dgHorario.Size = new System.Drawing.Size(896, 265);
            this.dgHorario.TabIndex = 46;
            this.dgHorario.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgHorario_RowValidating);
            this.dgHorario.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgHorario_UserDeletingRow);
            // 
            // id_Empleado3
            // 
            this.id_Empleado3.DataPropertyName = "id_Empleado";
            this.id_Empleado3.HeaderText = "id_Empleado";
            this.id_Empleado3.MinimumWidth = 6;
            this.id_Empleado3.Name = "id_Empleado3";
            this.id_Empleado3.Width = 125;
            // 
            // id_Horario
            // 
            this.id_Horario.DataPropertyName = "id_Horario";
            this.id_Horario.HeaderText = "id_Horario";
            this.id_Horario.MinimumWidth = 6;
            this.id_Horario.Name = "id_Horario";
            this.id_Horario.Width = 125;
            // 
            // dia_Inicio
            // 
            this.dia_Inicio.DataPropertyName = "dia_Inicio";
            this.dia_Inicio.HeaderText = "dia_Inicio";
            this.dia_Inicio.MinimumWidth = 6;
            this.dia_Inicio.Name = "dia_Inicio";
            this.dia_Inicio.Width = 125;
            // 
            // dia_Final
            // 
            this.dia_Final.DataPropertyName = "dia_Final";
            this.dia_Final.HeaderText = "dia_Final";
            this.dia_Final.MinimumWidth = 6;
            this.dia_Final.Name = "dia_Final";
            this.dia_Final.Width = 125;
            // 
            // horarioEmpleadosBindingSource
            // 
            this.horarioEmpleadosBindingSource.DataMember = "Horario_Empleados";
            this.horarioEmpleadosBindingSource.DataSource = this.citasMedicasDataSet6;
            // 
            // citasMedicasDataSet6
            // 
            this.citasMedicasDataSet6.DataSetName = "CitasMedicasDataSet6";
            this.citasMedicasDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // horario_EmpleadosTableAdapter
            // 
            this.horario_EmpleadosTableAdapter.ClearBeforeFill = true;
            // 
            // dgCargo
            // 
            this.dgCargo.AutoGenerateColumns = false;
            this.dgCargo.BackgroundColor = System.Drawing.Color.Thistle;
            this.dgCargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCargo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Empleado4,
            this.num_Cargo,
            this.cargo});
            this.dgCargo.DataSource = this.cargoEmpleadosBindingSource;
            this.dgCargo.Location = new System.Drawing.Point(766, 346);
            this.dgCargo.Name = "dgCargo";
            this.dgCargo.RowHeadersWidth = 51;
            this.dgCargo.RowTemplate.Height = 24;
            this.dgCargo.Size = new System.Drawing.Size(637, 265);
            this.dgCargo.TabIndex = 47;
            this.dgCargo.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgCargo_RowValidating);
            this.dgCargo.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgCargo_UserDeletingRow);
            // 
            // id_Empleado4
            // 
            this.id_Empleado4.DataPropertyName = "id_Empleado";
            this.id_Empleado4.HeaderText = "id_Empleado";
            this.id_Empleado4.MinimumWidth = 6;
            this.id_Empleado4.Name = "id_Empleado4";
            this.id_Empleado4.Width = 125;
            // 
            // num_Cargo
            // 
            this.num_Cargo.DataPropertyName = "num_Cargo";
            this.num_Cargo.HeaderText = "num_Cargo";
            this.num_Cargo.MinimumWidth = 6;
            this.num_Cargo.Name = "num_Cargo";
            this.num_Cargo.Width = 125;
            // 
            // cargo
            // 
            this.cargo.DataPropertyName = "cargo";
            this.cargo.HeaderText = "cargo";
            this.cargo.MinimumWidth = 6;
            this.cargo.Name = "cargo";
            this.cargo.Width = 125;
            // 
            // cargoEmpleadosBindingSource
            // 
            this.cargoEmpleadosBindingSource.DataMember = "Cargo_Empleados";
            this.cargoEmpleadosBindingSource.DataSource = this.citasMedicasDataSet7;
            // 
            // citasMedicasDataSet7
            // 
            this.citasMedicasDataSet7.DataSetName = "CitasMedicasDataSet7";
            this.citasMedicasDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cargo_EmpleadosTableAdapter
            // 
            this.cargo_EmpleadosTableAdapter.ClearBeforeFill = true;
            // 
            // correo_EmpleadosTableAdapter2
            // 
            this.correo_EmpleadosTableAdapter2.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(31, 1019);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(7, 39);
            this.panel2.TabIndex = 49;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(35, 1019);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(224, 39);
            this.btnActualizar.TabIndex = 48;
            this.btnActualizar.Text = "Actualizar tablas";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // AddEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(2656, 1238);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgCargo);
            this.Controls.Add(this.dgHorario);
            this.Controls.Add(this.dgCorreo);
            this.Controls.Add(this.dgEmp);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEmp";
            this.Text = "AddEmp";
            this.Load += new System.EventHandler(this.AddEmp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasMedicasDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCorreo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.correoEmpleadosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasMedicasDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasMedicasDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.correoEmpleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasMedicasDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.correoEmpleadosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgHorario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horarioEmpleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasMedicasDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoEmpleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasMedicasDataSet7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEmp;
        private CitasMedicasDataSet3 citasMedicasDataSet3;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private CitasMedicasDataSet3TableAdapters.EmpleadosTableAdapter empleadosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido1;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DataGridView dgCorreo;
        private CitasMedicasDataSet4 citasMedicasDataSet4;
        private System.Windows.Forms.BindingSource correoEmpleadosBindingSource;
        private CitasMedicasDataSet4TableAdapters.Correo_EmpleadosTableAdapter correo_EmpleadosTableAdapter;
        private CitasMedicasDataSet5 citasMedicasDataSet5;
        private System.Windows.Forms.BindingSource correoEmpleadosBindingSource1;
        private CitasMedicasDataSet5TableAdapters.Correo_EmpleadosTableAdapter correo_EmpleadosTableAdapter1;
        private System.Windows.Forms.DataGridView dgHorario;
        private CitasMedicasDataSet6 citasMedicasDataSet6;
        private System.Windows.Forms.BindingSource horarioEmpleadosBindingSource;
        private CitasMedicasDataSet6TableAdapters.Horario_EmpleadosTableAdapter horario_EmpleadosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Empleado3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia_Inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia_Final;
        private System.Windows.Forms.DataGridView dgCargo;
        private CitasMedicasDataSet7 citasMedicasDataSet7;
        private System.Windows.Forms.BindingSource cargoEmpleadosBindingSource;
        private CitasMedicasDataSet7TableAdapters.Cargo_EmpleadosTableAdapter cargo_EmpleadosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Empleado2;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Empleado4;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
        private CitasMedicasDataSet8 citasMedicasDataSet8;
        private System.Windows.Forms.BindingSource correoEmpleadosBindingSource2;
        private CitasMedicasDataSet8TableAdapters.Correo_EmpleadosTableAdapter correo_EmpleadosTableAdapter2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnActualizar;
    }
}