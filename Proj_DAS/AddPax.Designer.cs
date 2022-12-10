
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
            this.dgCorreo = new System.Windows.Forms.DataGridView();
            this.num_Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Paciente2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoPacientesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.citasMedicasDataSet2 = new Proj_DAS.CitasMedicasDataSet2();
            this.dgDomicilio = new System.Windows.Forms.DataGridView();
            this.num_Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Paciente3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canton = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otrasSenhas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilioPacientesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.citasMedicasDataSet1 = new Proj_DAS.CitasMedicasDataSet1();
            this.dgPax = new System.Windows.Forms.DataGridView();
            this.id_Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.citasMedicasDataSet = new Proj_DAS.CitasMedicasDataSet();
            this.pacientesTableAdapter = new Proj_DAS.CitasMedicasDataSetTableAdapters.PacientesTableAdapter();
            this.domicilio_PacientesTableAdapter = new Proj_DAS.CitasMedicasDataSet1TableAdapters.Domicilio_PacientesTableAdapter();
            this.correo_PacientesTableAdapter = new Proj_DAS.CitasMedicasDataSet2TableAdapters.Correo_PacientesTableAdapter();
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.correoPacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.domicilioPacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.correoPacientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.correoPacientesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.domicilioPacientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCorreo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.correoPacientesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasMedicasDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDomicilio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domicilioPacientesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasMedicasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasMedicasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.correoPacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domicilioPacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.correoPacientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.correoPacientesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domicilioPacientesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCorreo
            // 
            this.dgCorreo.AutoGenerateColumns = false;
            this.dgCorreo.BackgroundColor = System.Drawing.Color.Thistle;
            this.dgCorreo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCorreo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num_Correo,
            this.id_Paciente2,
            this.correo});
            this.dgCorreo.DataSource = this.correoPacientesBindingSource3;
            this.dgCorreo.Location = new System.Drawing.Point(28, 305);
            this.dgCorreo.Name = "dgCorreo";
            this.dgCorreo.RowHeadersWidth = 51;
            this.dgCorreo.RowTemplate.Height = 24;
            this.dgCorreo.Size = new System.Drawing.Size(1398, 226);
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
            // id_Paciente2
            // 
            this.id_Paciente2.DataPropertyName = "id_Paciente";
            this.id_Paciente2.HeaderText = "id_Paciente";
            this.id_Paciente2.MinimumWidth = 6;
            this.id_Paciente2.Name = "id_Paciente2";
            this.id_Paciente2.Width = 125;
            // 
            // correo
            // 
            this.correo.DataPropertyName = "correo";
            this.correo.HeaderText = "correo";
            this.correo.MinimumWidth = 6;
            this.correo.Name = "correo";
            this.correo.Width = 125;
            // 
            // correoPacientesBindingSource3
            // 
            this.correoPacientesBindingSource3.DataMember = "Correo_Pacientes";
            this.correoPacientesBindingSource3.DataSource = this.citasMedicasDataSet2;
            // 
            // citasMedicasDataSet2
            // 
            this.citasMedicasDataSet2.DataSetName = "CitasMedicasDataSet2";
            this.citasMedicasDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgDomicilio
            // 
            this.dgDomicilio.AutoGenerateColumns = false;
            this.dgDomicilio.BackgroundColor = System.Drawing.Color.Thistle;
            this.dgDomicilio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDomicilio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num_Provincia,
            this.num_Domicilio,
            this.id_Paciente3,
            this.canton,
            this.Distrito,
            this.otrasSenhas});
            this.dgDomicilio.DataSource = this.domicilioPacientesBindingSource2;
            this.dgDomicilio.Location = new System.Drawing.Point(28, 537);
            this.dgDomicilio.Name = "dgDomicilio";
            this.dgDomicilio.RowHeadersWidth = 51;
            this.dgDomicilio.RowTemplate.Height = 24;
            this.dgDomicilio.Size = new System.Drawing.Size(1398, 259);
            this.dgDomicilio.TabIndex = 44;
            this.dgDomicilio.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgDomicilio_RowValidating);
            this.dgDomicilio.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgDomicilio_UserDeletingRow);
            // 
            // num_Provincia
            // 
            this.num_Provincia.DataPropertyName = "num_Provincia";
            this.num_Provincia.HeaderText = "num_Provincia";
            this.num_Provincia.MinimumWidth = 6;
            this.num_Provincia.Name = "num_Provincia";
            this.num_Provincia.Width = 125;
            // 
            // num_Domicilio
            // 
            this.num_Domicilio.DataPropertyName = "num_Domicilio";
            this.num_Domicilio.HeaderText = "num_Domicilio";
            this.num_Domicilio.MinimumWidth = 6;
            this.num_Domicilio.Name = "num_Domicilio";
            this.num_Domicilio.Width = 125;
            // 
            // id_Paciente3
            // 
            this.id_Paciente3.DataPropertyName = "id_Paciente";
            this.id_Paciente3.HeaderText = "id_Paciente";
            this.id_Paciente3.MinimumWidth = 6;
            this.id_Paciente3.Name = "id_Paciente3";
            this.id_Paciente3.Width = 125;
            // 
            // canton
            // 
            this.canton.DataPropertyName = "canton";
            this.canton.HeaderText = "canton";
            this.canton.MinimumWidth = 6;
            this.canton.Name = "canton";
            this.canton.Width = 125;
            // 
            // Distrito
            // 
            this.Distrito.DataPropertyName = "Distrito";
            this.Distrito.HeaderText = "Distrito";
            this.Distrito.MinimumWidth = 6;
            this.Distrito.Name = "Distrito";
            this.Distrito.Width = 125;
            // 
            // otrasSenhas
            // 
            this.otrasSenhas.DataPropertyName = "otrasSenhas";
            this.otrasSenhas.HeaderText = "otrasSenhas";
            this.otrasSenhas.MinimumWidth = 6;
            this.otrasSenhas.Name = "otrasSenhas";
            this.otrasSenhas.Width = 125;
            // 
            // domicilioPacientesBindingSource2
            // 
            this.domicilioPacientesBindingSource2.DataMember = "Domicilio_Pacientes";
            this.domicilioPacientesBindingSource2.DataSource = this.citasMedicasDataSet1;
            // 
            // citasMedicasDataSet1
            // 
            this.citasMedicasDataSet1.DataSetName = "CitasMedicasDataSet1";
            this.citasMedicasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgPax
            // 
            this.dgPax.AutoGenerateColumns = false;
            this.dgPax.BackgroundColor = System.Drawing.Color.Thistle;
            this.dgPax.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPax.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Paciente,
            this.nombre,
            this.apellido1,
            this.apellido2,
            this.edad,
            this.tel});
            this.dgPax.DataSource = this.pacientesBindingSource1;
            this.dgPax.Location = new System.Drawing.Point(28, 34);
            this.dgPax.Name = "dgPax";
            this.dgPax.RowHeadersWidth = 51;
            this.dgPax.RowTemplate.Height = 24;
            this.dgPax.Size = new System.Drawing.Size(1398, 265);
            this.dgPax.TabIndex = 43;
            this.dgPax.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgPax_RowValidating);
            this.dgPax.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgPax_UserDeletingRow);
            // 
            // id_Paciente
            // 
            this.id_Paciente.DataPropertyName = "id_Paciente";
            this.id_Paciente.HeaderText = "id_Paciente";
            this.id_Paciente.MinimumWidth = 6;
            this.id_Paciente.Name = "id_Paciente";
            this.id_Paciente.Width = 125;
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
            this.apellido1.HeaderText = "Primer Apellido";
            this.apellido1.MinimumWidth = 6;
            this.apellido1.Name = "apellido1";
            this.apellido1.Width = 125;
            // 
            // apellido2
            // 
            this.apellido2.DataPropertyName = "apellido2";
            this.apellido2.HeaderText = "Segundo Apellido";
            this.apellido2.MinimumWidth = 6;
            this.apellido2.Name = "apellido2";
            this.apellido2.Width = 125;
            // 
            // edad
            // 
            this.edad.DataPropertyName = "edad";
            this.edad.HeaderText = "Edad";
            this.edad.MinimumWidth = 6;
            this.edad.Name = "edad";
            this.edad.Width = 125;
            // 
            // tel
            // 
            this.tel.DataPropertyName = "tel";
            this.tel.HeaderText = "Telefono";
            this.tel.MinimumWidth = 6;
            this.tel.Name = "tel";
            this.tel.Width = 125;
            // 
            // pacientesBindingSource1
            // 
            this.pacientesBindingSource1.DataMember = "Pacientes";
            this.pacientesBindingSource1.DataSource = this.citasMedicasDataSet;
            // 
            // citasMedicasDataSet
            // 
            this.citasMedicasDataSet.DataSetName = "CitasMedicasDataSet";
            this.citasMedicasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacientesTableAdapter
            // 
            this.pacientesTableAdapter.ClearBeforeFill = true;
            // 
            // domicilio_PacientesTableAdapter
            // 
            this.domicilio_PacientesTableAdapter.ClearBeforeFill = true;
            // 
            // correo_PacientesTableAdapter
            // 
            this.correo_PacientesTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(52, 840);
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
            this.btnActualizar.Location = new System.Drawing.Point(56, 840);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(224, 39);
            this.btnActualizar.TabIndex = 48;
            this.btnActualizar.Text = "Actualizar tablas";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // AddPax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(2125, 990);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgCorreo);
            this.Controls.Add(this.dgDomicilio);
            this.Controls.Add(this.dgPax);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPax";
            this.Text = "AddPax";
            this.Load += new System.EventHandler(this.AddPax_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCorreo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.correoPacientesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasMedicasDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDomicilio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domicilioPacientesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasMedicasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasMedicasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.correoPacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domicilioPacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.correoPacientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.correoPacientesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domicilioPacientesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource correoPacientesBindingSource;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private System.Windows.Forms.BindingSource domicilioPacientesBindingSource;
        private System.Windows.Forms.BindingSource correoPacientesBindingSource1;
        private System.Windows.Forms.BindingSource correoPacientesBindingSource2;
        private System.Windows.Forms.BindingSource domicilioPacientesBindingSource1;
        private System.Windows.Forms.DataGridView dgCorreo;
        private System.Windows.Forms.DataGridView dgDomicilio;
        private System.Windows.Forms.DataGridView dgPax;
        private CitasMedicasDataSet citasMedicasDataSet;
        private System.Windows.Forms.BindingSource pacientesBindingSource1;
        private CitasMedicasDataSetTableAdapters.PacientesTableAdapter pacientesTableAdapter;
        private CitasMedicasDataSet1 citasMedicasDataSet1;
        private System.Windows.Forms.BindingSource domicilioPacientesBindingSource2;
        private CitasMedicasDataSet1TableAdapters.Domicilio_PacientesTableAdapter domicilio_PacientesTableAdapter;
        private CitasMedicasDataSet2 citasMedicasDataSet2;
        private System.Windows.Forms.BindingSource correoPacientesBindingSource3;
        private CitasMedicasDataSet2TableAdapters.Correo_PacientesTableAdapter correo_PacientesTableAdapter;
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
    }
}