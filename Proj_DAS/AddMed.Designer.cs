
namespace Proj_DAS
{
    partial class AddMed
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
            this.dgMed = new System.Windows.Forms.DataGridView();
            this.cod_Medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citasMedicasDataSet9 = new Proj_DAS.CitasMedicasDataSet9();
            this.medicosTableAdapter = new Proj_DAS.CitasMedicasDataSet9TableAdapters.MedicosTableAdapter();
            this.dgCorreo = new System.Windows.Forms.DataGridView();
            this.num_Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_Medico2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoMédicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citasMedicasDataSet10 = new Proj_DAS.CitasMedicasDataSet10();
            this.correo_MédicosTableAdapter = new Proj_DAS.CitasMedicasDataSet10TableAdapters.Correo_MédicosTableAdapter();
            this.dgDispo = new System.Windows.Forms.DataGridView();
            this.num_Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_Medico3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disponibilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disponibilidadMedicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citasMedicasDataSet11 = new Proj_DAS.CitasMedicasDataSet11();
            this.disponibilidad_MedicosTableAdapter = new Proj_DAS.CitasMedicasDataSet11TableAdapters.Disponibilidad_MedicosTableAdapter();
            this.dgEsp = new System.Windows.Forms.DataGridView();
            this.cod_Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_Medico4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidadMedicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citasMedicasDataSet12 = new Proj_DAS.CitasMedicasDataSet12();
            this.especialidad_MedicosTableAdapter = new Proj_DAS.CitasMedicasDataSet12TableAdapters.Especialidad_MedicosTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgMed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasMedicasDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCorreo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.correoMédicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasMedicasDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDispo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disponibilidadMedicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasMedicasDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEsp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadMedicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasMedicasDataSet12)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMed
            // 
            this.dgMed.AutoGenerateColumns = false;
            this.dgMed.BackgroundColor = System.Drawing.Color.Thistle;
            this.dgMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_Medico,
            this.nombre,
            this.apellido1,
            this.apellido2,
            this.tel});
            this.dgMed.DataSource = this.medicosBindingSource;
            this.dgMed.Location = new System.Drawing.Point(12, 21);
            this.dgMed.Name = "dgMed";
            this.dgMed.RowHeadersWidth = 51;
            this.dgMed.RowTemplate.Height = 24;
            this.dgMed.Size = new System.Drawing.Size(1401, 265);
            this.dgMed.TabIndex = 44;
            this.dgMed.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgMed_RowValidating);
            this.dgMed.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgMed_UserDeletingRow);
            // 
            // cod_Medico
            // 
            this.cod_Medico.DataPropertyName = "cod_Médico";
            this.cod_Medico.HeaderText = "cod_Médico";
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
            // medicosBindingSource
            // 
            this.medicosBindingSource.DataMember = "Medicos";
            this.medicosBindingSource.DataSource = this.citasMedicasDataSet9;
            // 
            // citasMedicasDataSet9
            // 
            this.citasMedicasDataSet9.DataSetName = "CitasMedicasDataSet9";
            this.citasMedicasDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicosTableAdapter
            // 
            this.medicosTableAdapter.ClearBeforeFill = true;
            // 
            // dgCorreo
            // 
            this.dgCorreo.AutoGenerateColumns = false;
            this.dgCorreo.BackgroundColor = System.Drawing.Color.Thistle;
            this.dgCorreo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCorreo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num_Correo,
            this.cod_Medico2,
            this.correo});
            this.dgCorreo.DataSource = this.correoMédicosBindingSource;
            this.dgCorreo.Location = new System.Drawing.Point(12, 292);
            this.dgCorreo.Name = "dgCorreo";
            this.dgCorreo.RowHeadersWidth = 51;
            this.dgCorreo.RowTemplate.Height = 24;
            this.dgCorreo.Size = new System.Drawing.Size(1401, 265);
            this.dgCorreo.TabIndex = 45;
            this.dgCorreo.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgCorreo_RowValidating);
            this.dgCorreo.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgCorreo_UserDeletingRow);
            // 
            // num_Correo
            // 
            this.num_Correo.DataPropertyName = "num_Correo";
            this.num_Correo.HeaderText = "num_Correo";
            this.num_Correo.MinimumWidth = 6;
            this.num_Correo.Name = "num_Correo";
            this.num_Correo.Width = 125;
            // 
            // cod_Medico2
            // 
            this.cod_Medico2.DataPropertyName = "cod_Médico";
            this.cod_Medico2.HeaderText = "cod_Médico";
            this.cod_Medico2.MinimumWidth = 6;
            this.cod_Medico2.Name = "cod_Medico2";
            this.cod_Medico2.Width = 125;
            // 
            // correo
            // 
            this.correo.DataPropertyName = "correo";
            this.correo.HeaderText = "correo";
            this.correo.MinimumWidth = 6;
            this.correo.Name = "correo";
            this.correo.Width = 125;
            // 
            // correoMédicosBindingSource
            // 
            this.correoMédicosBindingSource.DataMember = "Correo_Médicos";
            this.correoMédicosBindingSource.DataSource = this.citasMedicasDataSet10;
            // 
            // citasMedicasDataSet10
            // 
            this.citasMedicasDataSet10.DataSetName = "CitasMedicasDataSet10";
            this.citasMedicasDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // correo_MédicosTableAdapter
            // 
            this.correo_MédicosTableAdapter.ClearBeforeFill = true;
            // 
            // dgDispo
            // 
            this.dgDispo.AutoGenerateColumns = false;
            this.dgDispo.BackgroundColor = System.Drawing.Color.Thistle;
            this.dgDispo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDispo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num_Dia,
            this.cod_Medico3,
            this.disponibilidad});
            this.dgDispo.DataSource = this.disponibilidadMedicosBindingSource;
            this.dgDispo.Location = new System.Drawing.Point(12, 563);
            this.dgDispo.Name = "dgDispo";
            this.dgDispo.RowHeadersWidth = 51;
            this.dgDispo.RowTemplate.Height = 24;
            this.dgDispo.Size = new System.Drawing.Size(1401, 265);
            this.dgDispo.TabIndex = 46;
            this.dgDispo.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgDispo_RowValidating);
            this.dgDispo.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgDispo_UserDeletingRow);
            // 
            // num_Dia
            // 
            this.num_Dia.DataPropertyName = "num_Dia";
            this.num_Dia.HeaderText = "num_Dia";
            this.num_Dia.MinimumWidth = 6;
            this.num_Dia.Name = "num_Dia";
            this.num_Dia.Width = 125;
            // 
            // cod_Medico3
            // 
            this.cod_Medico3.DataPropertyName = "cod_Medico";
            this.cod_Medico3.HeaderText = "cod_Medico";
            this.cod_Medico3.MinimumWidth = 6;
            this.cod_Medico3.Name = "cod_Medico3";
            this.cod_Medico3.Width = 125;
            // 
            // disponibilidad
            // 
            this.disponibilidad.DataPropertyName = "disponibilidad";
            this.disponibilidad.HeaderText = "disponibilidad";
            this.disponibilidad.MinimumWidth = 6;
            this.disponibilidad.Name = "disponibilidad";
            this.disponibilidad.Width = 125;
            // 
            // disponibilidadMedicosBindingSource
            // 
            this.disponibilidadMedicosBindingSource.DataMember = "Disponibilidad_Medicos";
            this.disponibilidadMedicosBindingSource.DataSource = this.citasMedicasDataSet11;
            // 
            // citasMedicasDataSet11
            // 
            this.citasMedicasDataSet11.DataSetName = "CitasMedicasDataSet11";
            this.citasMedicasDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // disponibilidad_MedicosTableAdapter
            // 
            this.disponibilidad_MedicosTableAdapter.ClearBeforeFill = true;
            // 
            // dgEsp
            // 
            this.dgEsp.AutoGenerateColumns = false;
            this.dgEsp.BackgroundColor = System.Drawing.Color.Thistle;
            this.dgEsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEsp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_Especialidad,
            this.cod_Medico4,
            this.especialidad});
            this.dgEsp.DataSource = this.especialidadMedicosBindingSource;
            this.dgEsp.Location = new System.Drawing.Point(12, 834);
            this.dgEsp.Name = "dgEsp";
            this.dgEsp.RowHeadersWidth = 51;
            this.dgEsp.RowTemplate.Height = 24;
            this.dgEsp.Size = new System.Drawing.Size(1401, 265);
            this.dgEsp.TabIndex = 47;
            this.dgEsp.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgEsp_RowValidating);
            this.dgEsp.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgEsp_UserDeletingRow);
            // 
            // cod_Especialidad
            // 
            this.cod_Especialidad.DataPropertyName = "cod_Especialidad";
            this.cod_Especialidad.HeaderText = "cod_Especialidad";
            this.cod_Especialidad.MinimumWidth = 6;
            this.cod_Especialidad.Name = "cod_Especialidad";
            this.cod_Especialidad.Width = 125;
            // 
            // cod_Medico4
            // 
            this.cod_Medico4.DataPropertyName = "cod_Medico";
            this.cod_Medico4.HeaderText = "cod_Medico";
            this.cod_Medico4.MinimumWidth = 6;
            this.cod_Medico4.Name = "cod_Medico4";
            this.cod_Medico4.Width = 125;
            // 
            // especialidad
            // 
            this.especialidad.DataPropertyName = "especialidad";
            this.especialidad.HeaderText = "especialidad";
            this.especialidad.MinimumWidth = 6;
            this.especialidad.Name = "especialidad";
            this.especialidad.Width = 125;
            // 
            // especialidadMedicosBindingSource
            // 
            this.especialidadMedicosBindingSource.DataMember = "Especialidad_Medicos";
            this.especialidadMedicosBindingSource.DataSource = this.citasMedicasDataSet12;
            // 
            // citasMedicasDataSet12
            // 
            this.citasMedicasDataSet12.DataSetName = "CitasMedicasDataSet12";
            this.citasMedicasDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // especialidad_MedicosTableAdapter
            // 
            this.especialidad_MedicosTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(26, 1131);
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
            this.btnActualizar.Location = new System.Drawing.Point(30, 1131);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(224, 39);
            this.btnActualizar.TabIndex = 48;
            this.btnActualizar.Text = "Actualizar tablas";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // AddMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(2656, 1238);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgEsp);
            this.Controls.Add(this.dgDispo);
            this.Controls.Add(this.dgCorreo);
            this.Controls.Add(this.dgMed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddMed";
            this.Text = "AddMed";
            this.Load += new System.EventHandler(this.AddMed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasMedicasDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCorreo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.correoMédicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasMedicasDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDispo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disponibilidadMedicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasMedicasDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEsp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadMedicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasMedicasDataSet12)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMed;
        private CitasMedicasDataSet9 citasMedicasDataSet9;
        private System.Windows.Forms.BindingSource medicosBindingSource;
        private CitasMedicasDataSet9TableAdapters.MedicosTableAdapter medicosTableAdapter;
        private System.Windows.Forms.DataGridView dgCorreo;
        private CitasMedicasDataSet10 citasMedicasDataSet10;
        private System.Windows.Forms.BindingSource correoMédicosBindingSource;
        private CitasMedicasDataSet10TableAdapters.Correo_MédicosTableAdapter correo_MédicosTableAdapter;
        private System.Windows.Forms.DataGridView dgDispo;
        private CitasMedicasDataSet11 citasMedicasDataSet11;
        private System.Windows.Forms.BindingSource disponibilidadMedicosBindingSource;
        private CitasMedicasDataSet11TableAdapters.Disponibilidad_MedicosTableAdapter disponibilidad_MedicosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_Dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_Medico3;
        private System.Windows.Forms.DataGridViewTextBoxColumn disponibilidad;
        private System.Windows.Forms.DataGridView dgEsp;
        private CitasMedicasDataSet12 citasMedicasDataSet12;
        private System.Windows.Forms.BindingSource especialidadMedicosBindingSource;
        private CitasMedicasDataSet12TableAdapters.Especialidad_MedicosTableAdapter especialidad_MedicosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_Especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_Medico4;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_Medico;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido1;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_Medico2;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnActualizar;
    }
}