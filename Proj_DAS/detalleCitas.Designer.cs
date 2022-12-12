
namespace Proj_DAS
{
    partial class detalleCitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(detalleCitas));
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgPax = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPax = new System.Windows.Forms.ComboBox();
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacienteDSprueba = new Proj_DAS.pacienteDSprueba();
            this.pacientesTableAdapter = new Proj_DAS.pacienteDSpruebaTableAdapters.PacientesTableAdapter();
            this.historialDS = new Proj_DAS.historialDS();
            this.historialPacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historial_PacientesTableAdapter = new Proj_DAS.historialDSTableAdapters.Historial_PacientesTableAdapter();
            this.num_Historial1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Paciente1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historial1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRegistro1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgPax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteDSprueba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialPacientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(37, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 23);
            this.label3.TabIndex = 29;
            this.label3.Text = "Codigo de Paciente";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(697, 82);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(7, 39);
            this.panel2.TabIndex = 39;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(697, 82);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(224, 39);
            this.btnBuscar.TabIndex = 38;
            this.btnBuscar.Text = "Buscar historial";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgPax
            // 
            this.dgPax.AllowUserToDeleteRows = false;
            this.dgPax.AutoGenerateColumns = false;
            this.dgPax.BackgroundColor = System.Drawing.Color.Thistle;
            this.dgPax.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPax.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num_Historial1,
            this.id_Paciente1,
            this.historial1,
            this.fechaRegistro1});
            this.dgPax.DataSource = this.historialPacientesBindingSource;
            this.dgPax.Location = new System.Drawing.Point(41, 128);
            this.dgPax.Name = "dgPax";
            this.dgPax.RowHeadersWidth = 51;
            this.dgPax.RowTemplate.Height = 24;
            this.dgPax.Size = new System.Drawing.Size(1139, 316);
            this.dgPax.TabIndex = 44;
            this.dgPax.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgPax_RowValidating);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(947, 82);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(7, 39);
            this.panel1.TabIndex = 46;
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
            this.btnActualizar.Location = new System.Drawing.Point(951, 82);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(224, 39);
            this.btnActualizar.TabIndex = 45;
            this.btnActualizar.Text = "Actualizar tabla";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(582, 30);
            this.label1.TabIndex = 51;
            this.label1.Text = "Historial de Pacientes - Creación, Modificación ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(1186, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 908);
            this.label2.TabIndex = 54;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // txtPax
            // 
            this.txtPax.DataSource = this.pacientesBindingSource;
            this.txtPax.DisplayMember = "id_Paciente";
            this.txtPax.FormattingEnabled = true;
            this.txtPax.Location = new System.Drawing.Point(251, 101);
            this.txtPax.Name = "txtPax";
            this.txtPax.Size = new System.Drawing.Size(219, 24);
            this.txtPax.TabIndex = 55;
            this.txtPax.ValueMember = "id_Paciente";
            // 
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataMember = "Pacientes";
            this.pacientesBindingSource.DataSource = this.pacienteDSprueba;
            // 
            // pacienteDSprueba
            // 
            this.pacienteDSprueba.DataSetName = "pacienteDSprueba";
            this.pacienteDSprueba.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacientesTableAdapter
            // 
            this.pacientesTableAdapter.ClearBeforeFill = true;
            // 
            // historialDS
            // 
            this.historialDS.DataSetName = "historialDS";
            this.historialDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // historialPacientesBindingSource
            // 
            this.historialPacientesBindingSource.DataMember = "Historial_Pacientes";
            this.historialPacientesBindingSource.DataSource = this.historialDS;
            // 
            // historial_PacientesTableAdapter
            // 
            this.historial_PacientesTableAdapter.ClearBeforeFill = true;
            // 
            // num_Historial1
            // 
            this.num_Historial1.DataPropertyName = "num_Historial";
            this.num_Historial1.HeaderText = "num_Historial";
            this.num_Historial1.MinimumWidth = 6;
            this.num_Historial1.Name = "num_Historial1";
            this.num_Historial1.ReadOnly = true;
            this.num_Historial1.Width = 125;
            // 
            // id_Paciente1
            // 
            this.id_Paciente1.DataPropertyName = "id_Paciente";
            this.id_Paciente1.HeaderText = "id_Paciente";
            this.id_Paciente1.MinimumWidth = 6;
            this.id_Paciente1.Name = "id_Paciente1";
            this.id_Paciente1.Width = 125;
            // 
            // historial1
            // 
            this.historial1.DataPropertyName = "historial";
            this.historial1.HeaderText = "historial";
            this.historial1.MinimumWidth = 6;
            this.historial1.Name = "historial1";
            this.historial1.Width = 125;
            // 
            // fechaRegistro1
            // 
            this.fechaRegistro1.DataPropertyName = "fechaRegistro";
            this.fechaRegistro1.HeaderText = "fechaRegistro";
            this.fechaRegistro1.MinimumWidth = 6;
            this.fechaRegistro1.Name = "fechaRegistro1";
            this.fechaRegistro1.Width = 125;
            // 
            // detalleCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(1697, 841);
            this.Controls.Add(this.txtPax);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgPax);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "detalleCitas";
            this.Text = "detalleCitas";
            this.Load += new System.EventHandler(this.detalleCitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteDSprueba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialPacientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgPax;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtPax;
        private pacienteDSprueba pacienteDSprueba;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private pacienteDSpruebaTableAdapters.PacientesTableAdapter pacientesTableAdapter;
        private historialDS historialDS;
        private System.Windows.Forms.BindingSource historialPacientesBindingSource;
        private historialDSTableAdapters.Historial_PacientesTableAdapter historial_PacientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_Historial1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Paciente1;
        private System.Windows.Forms.DataGridViewTextBoxColumn historial1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistro1;
    }
}