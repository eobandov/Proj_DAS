
namespace Proj_DAS
{
    partial class AddPax
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPax));
            this.dgDomicilio = new System.Windows.Forms.DataGridView();
            this.num_Provincia1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_Domicilio1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Paciente22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canton1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distrito1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otrasSenhas1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilioPacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.domicilioDS = new Proj_DAS.DomicilioDS();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dgPax = new System.Windows.Forms.DataGridView();
            this.id_Paciente1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edad1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacientesDS = new Proj_DAS.PacientesDS();
            this.label1 = new System.Windows.Forms.Label();
            this.pacientesTableAdapter = new Proj_DAS.PacientesDSTableAdapters.PacientesTableAdapter();
            this.domicilio_PacientesTableAdapter = new Proj_DAS.DomicilioDSTableAdapters.Domicilio_PacientesTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgDomicilio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domicilioPacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domicilioDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesDS)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDomicilio
            // 
            this.dgDomicilio.AutoGenerateColumns = false;
            this.dgDomicilio.BackgroundColor = System.Drawing.Color.Thistle;
            this.dgDomicilio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDomicilio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num_Provincia1,
            this.num_Domicilio1,
            this.id_Paciente22,
            this.canton1,
            this.Distrito1,
            this.otrasSenhas1});
            this.dgDomicilio.DataSource = this.domicilioPacientesBindingSource;
            this.dgDomicilio.Location = new System.Drawing.Point(28, 599);
            this.dgDomicilio.Name = "dgDomicilio";
            this.dgDomicilio.RowHeadersWidth = 51;
            this.dgDomicilio.RowTemplate.Height = 24;
            this.dgDomicilio.Size = new System.Drawing.Size(1244, 317);
            this.dgDomicilio.TabIndex = 44;
            this.dgDomicilio.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgDomicilio_RowValidating);
            this.dgDomicilio.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgDomicilio_UserDeletingRow);
            // 
            // num_Provincia1
            // 
            this.num_Provincia1.DataPropertyName = "num_Provincia";
            this.num_Provincia1.HeaderText = "num_Provincia";
            this.num_Provincia1.MinimumWidth = 6;
            this.num_Provincia1.Name = "num_Provincia1";
            this.num_Provincia1.Width = 125;
            // 
            // num_Domicilio1
            // 
            this.num_Domicilio1.DataPropertyName = "num_Domicilio";
            this.num_Domicilio1.HeaderText = "num_Domicilio";
            this.num_Domicilio1.MinimumWidth = 6;
            this.num_Domicilio1.Name = "num_Domicilio1";
            this.num_Domicilio1.ReadOnly = true;
            this.num_Domicilio1.Width = 125;
            // 
            // id_Paciente22
            // 
            this.id_Paciente22.DataPropertyName = "id_Paciente";
            this.id_Paciente22.HeaderText = "id_Paciente";
            this.id_Paciente22.MinimumWidth = 6;
            this.id_Paciente22.Name = "id_Paciente22";
            this.id_Paciente22.Width = 125;
            // 
            // canton1
            // 
            this.canton1.DataPropertyName = "canton";
            this.canton1.HeaderText = "canton";
            this.canton1.MinimumWidth = 6;
            this.canton1.Name = "canton1";
            this.canton1.Width = 125;
            // 
            // Distrito1
            // 
            this.Distrito1.DataPropertyName = "Distrito";
            this.Distrito1.HeaderText = "Distrito";
            this.Distrito1.MinimumWidth = 6;
            this.Distrito1.Name = "Distrito1";
            this.Distrito1.Width = 125;
            // 
            // otrasSenhas1
            // 
            this.otrasSenhas1.DataPropertyName = "otrasSenhas";
            this.otrasSenhas1.HeaderText = "otrasSenhas";
            this.otrasSenhas1.MinimumWidth = 6;
            this.otrasSenhas1.Name = "otrasSenhas1";
            this.otrasSenhas1.Width = 125;
            // 
            // domicilioPacientesBindingSource
            // 
            this.domicilioPacientesBindingSource.DataMember = "Domicilio_Pacientes";
            this.domicilioPacientesBindingSource.DataSource = this.domicilioDS;
            // 
            // domicilioDS
            // 
            this.domicilioDS.DataSetName = "DomicilioDS";
            this.domicilioDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(1065, 923);
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
            this.btnActualizar.Location = new System.Drawing.Point(1069, 923);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(224, 39);
            this.btnActualizar.TabIndex = 48;
            this.btnActualizar.Text = "Actualizar tablas";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // dgPax
            // 
            this.dgPax.AutoGenerateColumns = false;
            this.dgPax.BackgroundColor = System.Drawing.Color.Thistle;
            this.dgPax.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPax.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Paciente1,
            this.nombre1,
            this.apellido11,
            this.apellido21,
            this.edad1,
            this.tel1,
            this.correo1});
            this.dgPax.DataSource = this.pacientesBindingSource;
            this.dgPax.Location = new System.Drawing.Point(28, 163);
            this.dgPax.Name = "dgPax";
            this.dgPax.RowHeadersWidth = 51;
            this.dgPax.RowTemplate.Height = 24;
            this.dgPax.Size = new System.Drawing.Size(1244, 385);
            this.dgPax.TabIndex = 43;
            this.dgPax.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgPax_RowValidating);
            this.dgPax.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgPax_UserDeletingRow);
            // 
            // id_Paciente1
            // 
            this.id_Paciente1.DataPropertyName = "id_Paciente";
            this.id_Paciente1.HeaderText = "id_Paciente";
            this.id_Paciente1.MinimumWidth = 6;
            this.id_Paciente1.Name = "id_Paciente1";
            this.id_Paciente1.ReadOnly = true;
            this.id_Paciente1.Width = 125;
            // 
            // nombre1
            // 
            this.nombre1.DataPropertyName = "nombre";
            this.nombre1.HeaderText = "nombre";
            this.nombre1.MinimumWidth = 6;
            this.nombre1.Name = "nombre1";
            this.nombre1.Width = 125;
            // 
            // apellido11
            // 
            this.apellido11.DataPropertyName = "apellido1";
            this.apellido11.HeaderText = "apellido1";
            this.apellido11.MinimumWidth = 6;
            this.apellido11.Name = "apellido11";
            this.apellido11.Width = 125;
            // 
            // apellido21
            // 
            this.apellido21.DataPropertyName = "apellido2";
            this.apellido21.HeaderText = "apellido2";
            this.apellido21.MinimumWidth = 6;
            this.apellido21.Name = "apellido21";
            this.apellido21.Width = 125;
            // 
            // edad1
            // 
            this.edad1.DataPropertyName = "edad";
            this.edad1.HeaderText = "edad";
            this.edad1.MinimumWidth = 6;
            this.edad1.Name = "edad1";
            this.edad1.Width = 125;
            // 
            // tel1
            // 
            this.tel1.DataPropertyName = "tel";
            this.tel1.HeaderText = "tel";
            this.tel1.MinimumWidth = 6;
            this.tel1.Name = "tel1";
            this.tel1.Width = 125;
            // 
            // correo1
            // 
            this.correo1.DataPropertyName = "correo";
            this.correo1.HeaderText = "correo";
            this.correo1.MinimumWidth = 6;
            this.correo1.Name = "correo1";
            this.correo1.Width = 125;
            // 
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataMember = "Pacientes";
            this.pacientesBindingSource.DataSource = this.pacientesDS;
            // 
            // pacientesDS
            // 
            this.pacientesDS.DataSetName = "PacientesDS";
            this.pacientesDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(47, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(607, 30);
            this.label1.TabIndex = 50;
            this.label1.Text = "Pacientes - Creación, Modificación y eliminación";
            // 
            // pacientesTableAdapter
            // 
            this.pacientesTableAdapter.ClearBeforeFill = true;
            // 
            // domicilio_PacientesTableAdapter
            // 
            this.domicilio_PacientesTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(1288, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(366, 908);
            this.label3.TabIndex = 53;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(24, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 23);
            this.label4.TabIndex = 57;
            this.label4.Text = "Detalles personales";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(24, 573);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 23);
            this.label5.TabIndex = 58;
            this.label5.Text = "Detalles del domicilio";
            // 
            // AddPax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(1942, 990);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgDomicilio);
            this.Controls.Add(this.dgPax);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPax";
            this.Text = "AddPax";
            this.Load += new System.EventHandler(this.AddPax_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDomicilio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domicilioPacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domicilioDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgDomicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido1;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido2;
        private System.Windows.Forms.DataGridViewTextBoxColumn edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Paciente2;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_Provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_Domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Paciente3;
        private System.Windows.Forms.DataGridViewTextBoxColumn canton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn otrasSenhas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView dgPax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private PacientesDS pacientesDS;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private PacientesDSTableAdapters.PacientesTableAdapter pacientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Paciente1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre1;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido11;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido21;
        private System.Windows.Forms.DataGridViewTextBoxColumn edad1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo1;
        private DomicilioDS domicilioDS;
        private System.Windows.Forms.BindingSource domicilioPacientesBindingSource;
        private DomicilioDSTableAdapters.Domicilio_PacientesTableAdapter domicilio_PacientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_Provincia1;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_Domicilio1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Paciente22;
        private System.Windows.Forms.DataGridViewTextBoxColumn canton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distrito1;
        private System.Windows.Forms.DataGridViewTextBoxColumn otrasSenhas1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}