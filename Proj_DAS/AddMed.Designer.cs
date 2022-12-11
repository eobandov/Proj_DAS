
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMed));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgMed = new System.Windows.Forms.DataGridView();
            this.cod_Medico1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSMedicos = new Proj_DAS.DSMedicos();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dgDispo = new System.Windows.Forms.DataGridView();
            this.num_Dia111 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_Medico111 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disponibilidadMedicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.disponibilidadDS = new Proj_DAS.DisponibilidadDS();
            this.medicosTableAdapter = new Proj_DAS.DSMedicosTableAdapters.MedicosTableAdapter();
            this.disponibilidad_MedicosTableAdapter = new Proj_DAS.DisponibilidadDSTableAdapters.Disponibilidad_MedicosTableAdapter();
            this.dgEsp = new System.Windows.Forms.DataGridView();
            this.dSEspe = new Proj_DAS.DSEspe();
            this.especialidadMedicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.especialidad_MedicosTableAdapter = new Proj_DAS.DSEspeTableAdapters.Especialidad_MedicosTableAdapter();
            this.cod_Especialidad222 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_Medico222 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidad222 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgMed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMedicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDispo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disponibilidadMedicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disponibilidadDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEsp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSEspe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadMedicosBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(593, 30);
            this.label1.TabIndex = 54;
            this.label1.Text = "Médicos - Creación, Modificación y eliminación";
            // 
            // dgMed
            // 
            this.dgMed.AutoGenerateColumns = false;
            this.dgMed.BackgroundColor = System.Drawing.Color.Thistle;
            this.dgMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_Medico1,
            this.nombre1,
            this.apellido11,
            this.apellido21,
            this.tel1,
            this.correo1});
            this.dgMed.DataSource = this.medicosBindingSource;
            this.dgMed.Location = new System.Drawing.Point(27, 90);
            this.dgMed.Name = "dgMed";
            this.dgMed.RowHeadersWidth = 51;
            this.dgMed.RowTemplate.Height = 24;
            this.dgMed.Size = new System.Drawing.Size(1138, 450);
            this.dgMed.TabIndex = 55;
            this.dgMed.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgMed_RowValidating);
            this.dgMed.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgMed_UserDeletingRow);
            // 
            // cod_Medico1
            // 
            this.cod_Medico1.DataPropertyName = "cod_Medico";
            this.cod_Medico1.HeaderText = "Codigo de Medico";
            this.cod_Medico1.MinimumWidth = 6;
            this.cod_Medico1.Name = "cod_Medico1";
            this.cod_Medico1.ReadOnly = true;
            this.cod_Medico1.Width = 125;
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
            // medicosBindingSource
            // 
            this.medicosBindingSource.DataMember = "Medicos";
            this.medicosBindingSource.DataSource = this.dSMedicos;
            // 
            // dSMedicos
            // 
            this.dSMedicos.DataSetName = "DSMedicos";
            this.dSMedicos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(937, 814);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(7, 39);
            this.panel1.TabIndex = 57;
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
            this.button1.Location = new System.Drawing.Point(941, 814);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 39);
            this.button1.TabIndex = 56;
            this.button1.Text = "Actualizar tablas";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgDispo
            // 
            this.dgDispo.AutoGenerateColumns = false;
            this.dgDispo.BackgroundColor = System.Drawing.Color.Thistle;
            this.dgDispo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDispo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num_Dia111,
            this.cod_Medico111});
            this.dgDispo.DataSource = this.disponibilidadMedicosBindingSource;
            this.dgDispo.Location = new System.Drawing.Point(27, 613);
            this.dgDispo.Name = "dgDispo";
            this.dgDispo.RowHeadersWidth = 51;
            this.dgDispo.RowTemplate.Height = 24;
            this.dgDispo.Size = new System.Drawing.Size(564, 194);
            this.dgDispo.TabIndex = 58;
            this.dgDispo.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgDispo_RowValidating);
            this.dgDispo.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgDispo_UserDeletingRow);
            // 
            // num_Dia111
            // 
            this.num_Dia111.DataPropertyName = "num_Dia";
            this.num_Dia111.HeaderText = "Numero de Dias";
            this.num_Dia111.MinimumWidth = 6;
            this.num_Dia111.Name = "num_Dia111";
            this.num_Dia111.Width = 125;
            // 
            // cod_Medico111
            // 
            this.cod_Medico111.DataPropertyName = "cod_Medico";
            this.cod_Medico111.HeaderText = "Codigo Medico";
            this.cod_Medico111.MinimumWidth = 6;
            this.cod_Medico111.Name = "cod_Medico111";
            this.cod_Medico111.Width = 125;
            // 
            // disponibilidadMedicosBindingSource
            // 
            this.disponibilidadMedicosBindingSource.DataMember = "Disponibilidad_Medicos";
            this.disponibilidadMedicosBindingSource.DataSource = this.disponibilidadDS;
            // 
            // disponibilidadDS
            // 
            this.disponibilidadDS.DataSetName = "DisponibilidadDS";
            this.disponibilidadDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicosTableAdapter
            // 
            this.medicosTableAdapter.ClearBeforeFill = true;
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
            this.cod_Especialidad222,
            this.cod_Medico222,
            this.especialidad222});
            this.dgEsp.DataSource = this.especialidadMedicosBindingSource;
            this.dgEsp.Location = new System.Drawing.Point(597, 613);
            this.dgEsp.Name = "dgEsp";
            this.dgEsp.RowHeadersWidth = 51;
            this.dgEsp.RowTemplate.Height = 24;
            this.dgEsp.Size = new System.Drawing.Size(568, 194);
            this.dgEsp.TabIndex = 59;
            this.dgEsp.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgEsp_RowValidating);
            this.dgEsp.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgEsp_UserDeletingRow);
            // 
            // dSEspe
            // 
            this.dSEspe.DataSetName = "DSEspe";
            this.dSEspe.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // especialidadMedicosBindingSource
            // 
            this.especialidadMedicosBindingSource.DataMember = "Especialidad_Medicos";
            this.especialidadMedicosBindingSource.DataSource = this.dSEspe;
            // 
            // especialidad_MedicosTableAdapter
            // 
            this.especialidad_MedicosTableAdapter.ClearBeforeFill = true;
            // 
            // cod_Especialidad222
            // 
            this.cod_Especialidad222.DataPropertyName = "cod_Especialidad";
            this.cod_Especialidad222.HeaderText = "Codigo de Especialidad";
            this.cod_Especialidad222.MinimumWidth = 6;
            this.cod_Especialidad222.Name = "cod_Especialidad222";
            this.cod_Especialidad222.ReadOnly = true;
            this.cod_Especialidad222.Width = 125;
            // 
            // cod_Medico222
            // 
            this.cod_Medico222.DataPropertyName = "cod_Medico";
            this.cod_Medico222.HeaderText = "Codigo de Medico";
            this.cod_Medico222.MinimumWidth = 6;
            this.cod_Medico222.Name = "cod_Medico222";
            this.cod_Medico222.Width = 125;
            // 
            // especialidad222
            // 
            this.especialidad222.DataPropertyName = "especialidad";
            this.especialidad222.HeaderText = "Especialidad";
            this.especialidad222.MinimumWidth = 6;
            this.especialidad222.Name = "especialidad222";
            this.especialidad222.Width = 125;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(1171, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(402, 908);
            this.label3.TabIndex = 60;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(23, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 23);
            this.label4.TabIndex = 61;
            this.label4.Text = "Detalles personales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(32, 587);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 23);
            this.label2.TabIndex = 62;
            this.label2.Text = "Detalles de disponibilidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(593, 587);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 23);
            this.label5.TabIndex = 63;
            this.label5.Text = "Detalles de especialidad";
            // 
            // AddMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgEsp);
            this.Controls.Add(this.dgDispo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgMed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnActualizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddMed";
            this.Text = "AddMed";
            this.Load += new System.EventHandler(this.AddMed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMedicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDispo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disponibilidadMedicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disponibilidadDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEsp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSEspe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadMedicosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn num_Dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_Medico3;
        private System.Windows.Forms.DataGridViewTextBoxColumn disponibilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_Especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_Medico4;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_Medico;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido1;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_Medico2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgMed;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private DSMedicos dSMedicos;
        private System.Windows.Forms.BindingSource medicosBindingSource;
        private DSMedicosTableAdapters.MedicosTableAdapter medicosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_Medico1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre1;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido11;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido21;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_Medico12;
        private System.Windows.Forms.DataGridView dgDispo;
        private DisponibilidadDS disponibilidadDS;
        private System.Windows.Forms.BindingSource disponibilidadMedicosBindingSource;
        private DisponibilidadDSTableAdapters.Disponibilidad_MedicosTableAdapter disponibilidad_MedicosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_Dia111;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_Medico111;
        private System.Windows.Forms.DataGridView dgEsp;
        private DSEspe dSEspe;
        private System.Windows.Forms.BindingSource especialidadMedicosBindingSource;
        private DSEspeTableAdapters.Especialidad_MedicosTableAdapter especialidad_MedicosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_Especialidad222;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_Medico222;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidad222;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}