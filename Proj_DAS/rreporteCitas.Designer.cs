
namespace Proj_DAS
{
    partial class rreporteCitas
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
            this.dgCita = new System.Windows.Forms.DataGridView();
            
            this.citasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codCitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaCitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consultorioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codMedicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnArchivo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCita
            // 
            this.dgCita.AllowUserToAddRows = false;
            this.dgCita.AllowUserToDeleteRows = false;
            this.dgCita.AutoGenerateColumns = false;
            this.dgCita.BackgroundColor = System.Drawing.Color.Thistle;
            this.dgCita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCita.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codCitaDataGridViewTextBoxColumn,
            this.fechaCitaDataGridViewTextBoxColumn,
            this.horaCitaDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.consultorioDataGridViewTextBoxColumn,
            this.codMedicoDataGridViewTextBoxColumn,
            this.idPacienteDataGridViewTextBoxColumn,
            this.idEmpleadoDataGridViewTextBoxColumn});
            this.dgCita.DataSource = this.citasBindingSource;
            this.dgCita.Location = new System.Drawing.Point(12, 58);
            this.dgCita.Name = "dgCita";
            this.dgCita.ReadOnly = true;
            this.dgCita.RowHeadersWidth = 51;
            this.dgCita.RowTemplate.Height = 24;
            this.dgCita.Size = new System.Drawing.Size(1466, 265);
            this.dgCita.TabIndex = 45;
            
            // 
            // codCitaDataGridViewTextBoxColumn
            // 
            this.codCitaDataGridViewTextBoxColumn.DataPropertyName = "cod_Cita";
            this.codCitaDataGridViewTextBoxColumn.HeaderText = "cod_Cita";
            this.codCitaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codCitaDataGridViewTextBoxColumn.Name = "codCitaDataGridViewTextBoxColumn";
            this.codCitaDataGridViewTextBoxColumn.ReadOnly = true;
            this.codCitaDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaCitaDataGridViewTextBoxColumn
            // 
            this.fechaCitaDataGridViewTextBoxColumn.DataPropertyName = "fechaCita";
            this.fechaCitaDataGridViewTextBoxColumn.HeaderText = "fechaCita";
            this.fechaCitaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaCitaDataGridViewTextBoxColumn.Name = "fechaCitaDataGridViewTextBoxColumn";
            this.fechaCitaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaCitaDataGridViewTextBoxColumn.Width = 125;
            // 
            // horaCitaDataGridViewTextBoxColumn
            // 
            this.horaCitaDataGridViewTextBoxColumn.DataPropertyName = "horaCita";
            this.horaCitaDataGridViewTextBoxColumn.HeaderText = "horaCita";
            this.horaCitaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.horaCitaDataGridViewTextBoxColumn.Name = "horaCitaDataGridViewTextBoxColumn";
            this.horaCitaDataGridViewTextBoxColumn.ReadOnly = true;
            this.horaCitaDataGridViewTextBoxColumn.Width = 125;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "precio";
            this.precioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioDataGridViewTextBoxColumn.Width = 125;
            // 
            // consultorioDataGridViewTextBoxColumn
            // 
            this.consultorioDataGridViewTextBoxColumn.DataPropertyName = "consultorio";
            this.consultorioDataGridViewTextBoxColumn.HeaderText = "consultorio";
            this.consultorioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.consultorioDataGridViewTextBoxColumn.Name = "consultorioDataGridViewTextBoxColumn";
            this.consultorioDataGridViewTextBoxColumn.ReadOnly = true;
            this.consultorioDataGridViewTextBoxColumn.Width = 125;
            // 
            // codMedicoDataGridViewTextBoxColumn
            // 
            this.codMedicoDataGridViewTextBoxColumn.DataPropertyName = "cod_Medico";
            this.codMedicoDataGridViewTextBoxColumn.HeaderText = "cod_Medico";
            this.codMedicoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codMedicoDataGridViewTextBoxColumn.Name = "codMedicoDataGridViewTextBoxColumn";
            this.codMedicoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codMedicoDataGridViewTextBoxColumn.Width = 125;
            // 
            // idPacienteDataGridViewTextBoxColumn
            // 
            this.idPacienteDataGridViewTextBoxColumn.DataPropertyName = "id_Paciente";
            this.idPacienteDataGridViewTextBoxColumn.HeaderText = "id_Paciente";
            this.idPacienteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idPacienteDataGridViewTextBoxColumn.Name = "idPacienteDataGridViewTextBoxColumn";
            this.idPacienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPacienteDataGridViewTextBoxColumn.Width = 125;
            // 
            // idEmpleadoDataGridViewTextBoxColumn
            // 
            this.idEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "id_Empleado";
            this.idEmpleadoDataGridViewTextBoxColumn.HeaderText = "id_Empleado";
            this.idEmpleadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idEmpleadoDataGridViewTextBoxColumn.Name = "idEmpleadoDataGridViewTextBoxColumn";
            this.idEmpleadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idEmpleadoDataGridViewTextBoxColumn.Width = 125;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel9.Location = new System.Drawing.Point(27, 350);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(7, 39);
            this.panel9.TabIndex = 48;
            // 
            // btnArchivo
            // 
            this.btnArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnArchivo.FlatAppearance.BorderSize = 0;
            this.btnArchivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArchivo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchivo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnArchivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArchivo.Location = new System.Drawing.Point(27, 350);
            this.btnArchivo.Margin = new System.Windows.Forms.Padding(4);
            this.btnArchivo.Name = "btnArchivo";
            this.btnArchivo.Size = new System.Drawing.Size(224, 39);
            this.btnArchivo.TabIndex = 47;
            this.btnArchivo.Text = "Exportar CSV";
            this.btnArchivo.UseVisualStyleBackColor = false;
            this.btnArchivo.Click += new System.EventHandler(this.btnArchivo_Click);
            // 
            // rreporteCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(1542, 711);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.btnArchivo);
            this.Controls.Add(this.dgCita);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rreporteCitas";
            this.Text = "rreporteCitas";
            this.Load += new System.EventHandler(this.rreporteCitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCita;
        private System.Windows.Forms.BindingSource citasBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn codCitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaCitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consultorioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codMedicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnArchivo;
    }
}