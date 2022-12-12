
namespace Proj_DAS
{
    partial class AddCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCita));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtCita = new System.Windows.Forms.ComboBox();
            this.txtMed = new System.Windows.Forms.ComboBox();
            this.txtPax = new System.Windows.Forms.ComboBox();
            this.txtConsul = new System.Windows.Forms.ComboBox();
            this.txtEmp = new System.Windows.Forms.ComboBox();
            this.pruebaCitasDSDS = new Proj_DAS.pruebaCitasDSDS();
            this.citasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citasTableAdapter = new Proj_DAS.pruebaCitasDSDSTableAdapters.CitasTableAdapter();
            this.pruebaMedicosDSDS = new Proj_DAS.pruebaMedicosDSDS();
            this.medicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicosTableAdapter = new Proj_DAS.pruebaMedicosDSDSTableAdapters.MedicosTableAdapter();
            this.pruebPaxDSDS = new Proj_DAS.pruebPaxDSDS();
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacientesTableAdapter = new Proj_DAS.pruebPaxDSDSTableAdapters.PacientesTableAdapter();
            this.pruebaEmpDSDS = new Proj_DAS.pruebaEmpDSDS();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadosTableAdapter = new Proj_DAS.pruebaEmpDSDSTableAdapters.EmpleadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pruebaCitasDSDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebaMedicosDSDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebPaxDSDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebaEmpDSDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(161, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Codigo de Cita";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(128, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "Codigo de Medico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(114, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "Codigo de Paciente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(250, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 23);
            this.label4.TabIndex = 29;
            this.label4.Text = "Fecha";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(350, 278);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(4);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(223, 22);
            this.txtFecha.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(265, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 23);
            this.label5.TabIndex = 31;
            this.label5.Text = "Hora";
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(350, 320);
            this.txtHora.Margin = new System.Windows.Forms.Padding(4);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(223, 22);
            this.txtHora.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(204, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 23);
            this.label6.TabIndex = 33;
            this.label6.Text = "Consultorio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(98, 404);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 23);
            this.label7.TabIndex = 35;
            this.label7.Text = "Codigo de Empleado";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(94, 498);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(7, 39);
            this.panel2.TabIndex = 37;
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
            this.btnAgregar.Location = new System.Drawing.Point(98, 498);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(224, 39);
            this.btnAgregar.TabIndex = 36;
            this.btnAgregar.Text = "Añadir Cita";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(397, 30);
            this.label8.TabIndex = 51;
            this.label8.Text = "Citas - Creación y Actualización";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(698, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(516, 472);
            this.label9.TabIndex = 54;
            this.label9.Text = resources.GetString("label9.Text");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(364, 498);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(7, 39);
            this.panel1.TabIndex = 56;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(368, 498);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(224, 39);
            this.btnUpdate.TabIndex = 55;
            this.btnUpdate.Text = "Actualizar Cita";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtCita
            // 
            this.txtCita.DataSource = this.citasBindingSource;
            this.txtCita.DisplayMember = "cod_Cita";
            this.txtCita.FormattingEnabled = true;
            this.txtCita.Location = new System.Drawing.Point(350, 127);
            this.txtCita.Name = "txtCita";
            this.txtCita.Size = new System.Drawing.Size(223, 24);
            this.txtCita.TabIndex = 57;
            this.txtCita.ValueMember = "cod_Cita";
            // 
            // txtMed
            // 
            this.txtMed.DataSource = this.medicosBindingSource;
            this.txtMed.DisplayMember = "cod_Medico";
            this.txtMed.FormattingEnabled = true;
            this.txtMed.Location = new System.Drawing.Point(350, 179);
            this.txtMed.Name = "txtMed";
            this.txtMed.Size = new System.Drawing.Size(223, 24);
            this.txtMed.TabIndex = 58;
            this.txtMed.ValueMember = "cod_Medico";
            // 
            // txtPax
            // 
            this.txtPax.DataSource = this.pacientesBindingSource;
            this.txtPax.DisplayMember = "id_Paciente";
            this.txtPax.FormattingEnabled = true;
            this.txtPax.Location = new System.Drawing.Point(350, 231);
            this.txtPax.Name = "txtPax";
            this.txtPax.Size = new System.Drawing.Size(223, 24);
            this.txtPax.TabIndex = 59;
            this.txtPax.ValueMember = "id_Paciente";
            // 
            // txtConsul
            // 
            this.txtConsul.FormattingEnabled = true;
            this.txtConsul.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.txtConsul.Location = new System.Drawing.Point(350, 365);
            this.txtConsul.Name = "txtConsul";
            this.txtConsul.Size = new System.Drawing.Size(223, 24);
            this.txtConsul.TabIndex = 60;
            // 
            // txtEmp
            // 
            this.txtEmp.DataSource = this.empleadosBindingSource;
            this.txtEmp.DisplayMember = "id_Empleado";
            this.txtEmp.FormattingEnabled = true;
            this.txtEmp.Location = new System.Drawing.Point(350, 407);
            this.txtEmp.Name = "txtEmp";
            this.txtEmp.Size = new System.Drawing.Size(223, 24);
            this.txtEmp.TabIndex = 61;
            this.txtEmp.ValueMember = "id_Empleado";
            // 
            // pruebaCitasDSDS
            // 
            this.pruebaCitasDSDS.DataSetName = "pruebaCitasDSDS";
            this.pruebaCitasDSDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // citasBindingSource
            // 
            this.citasBindingSource.DataMember = "Citas";
            this.citasBindingSource.DataSource = this.pruebaCitasDSDS;
            // 
            // citasTableAdapter
            // 
            this.citasTableAdapter.ClearBeforeFill = true;
            // 
            // pruebaMedicosDSDS
            // 
            this.pruebaMedicosDSDS.DataSetName = "pruebaMedicosDSDS";
            this.pruebaMedicosDSDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicosBindingSource
            // 
            this.medicosBindingSource.DataMember = "Medicos";
            this.medicosBindingSource.DataSource = this.pruebaMedicosDSDS;
            // 
            // medicosTableAdapter
            // 
            this.medicosTableAdapter.ClearBeforeFill = true;
            // 
            // pruebPaxDSDS
            // 
            this.pruebPaxDSDS.DataSetName = "pruebPaxDSDS";
            this.pruebPaxDSDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataMember = "Pacientes";
            this.pacientesBindingSource.DataSource = this.pruebPaxDSDS;
            // 
            // pacientesTableAdapter
            // 
            this.pacientesTableAdapter.ClearBeforeFill = true;
            // 
            // pruebaEmpDSDS
            // 
            this.pruebaEmpDSDS.DataSetName = "pruebaEmpDSDS";
            this.pruebaEmpDSDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "Empleados";
            this.empleadosBindingSource.DataSource = this.pruebaEmpDSDS;
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // AddCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(1256, 621);
            this.Controls.Add(this.txtEmp);
            this.Controls.Add(this.txtConsul);
            this.Controls.Add(this.txtPax);
            this.Controls.Add(this.txtMed);
            this.Controls.Add(this.txtCita);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCita";
            this.Text = "AddCita";
            this.Load += new System.EventHandler(this.AddCita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pruebaCitasDSDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebaMedicosDSDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebPaxDSDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebaEmpDSDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox txtCita;
        private System.Windows.Forms.ComboBox txtMed;
        private System.Windows.Forms.ComboBox txtPax;
        private System.Windows.Forms.ComboBox txtConsul;
        private System.Windows.Forms.ComboBox txtEmp;
        private pruebaCitasDSDS pruebaCitasDSDS;
        private System.Windows.Forms.BindingSource citasBindingSource;
        private pruebaCitasDSDSTableAdapters.CitasTableAdapter citasTableAdapter;
        private pruebaMedicosDSDS pruebaMedicosDSDS;
        private System.Windows.Forms.BindingSource medicosBindingSource;
        private pruebaMedicosDSDSTableAdapters.MedicosTableAdapter medicosTableAdapter;
        private pruebPaxDSDS pruebPaxDSDS;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private pruebPaxDSDSTableAdapters.PacientesTableAdapter pacientesTableAdapter;
        private pruebaEmpDSDS pruebaEmpDSDS;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private pruebaEmpDSDSTableAdapters.EmpleadosTableAdapter empleadosTableAdapter;
    }
}