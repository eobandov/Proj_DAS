
namespace Proj_DAS
{
    partial class reporteFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reporteFacturas));
            this.dgFactura = new System.Windows.Forms.DataGridView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnArchivo = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExcel = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dSfacturas2_0 = new Proj_DAS.DSfacturas2_0();
            this.facturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturasTableAdapter = new Proj_DAS.DSfacturas2_0TableAdapters.FacturasTableAdapter();
            this.idfacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codEspecialidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleConsultaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ivaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalIvaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSfacturas2_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgFactura
            // 
            this.dgFactura.AllowUserToAddRows = false;
            this.dgFactura.AllowUserToDeleteRows = false;
            this.dgFactura.AllowUserToOrderColumns = true;
            this.dgFactura.AutoGenerateColumns = false;
            this.dgFactura.BackgroundColor = System.Drawing.Color.Thistle;
            this.dgFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idfacturaDataGridViewTextBoxColumn,
            this.fechaPagoDataGridViewTextBoxColumn,
            this.codEspecialidadDataGridViewTextBoxColumn,
            this.especialidadDataGridViewTextBoxColumn,
            this.detalleConsultaDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.ivaDataGridViewTextBoxColumn,
            this.totalIvaDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn});
            this.dgFactura.DataSource = this.facturasBindingSource;
            this.dgFactura.Location = new System.Drawing.Point(12, 58);
            this.dgFactura.Name = "dgFactura";
            this.dgFactura.ReadOnly = true;
            this.dgFactura.RowHeadersWidth = 51;
            this.dgFactura.RowTemplate.Height = 24;
            this.dgFactura.Size = new System.Drawing.Size(1341, 459);
            this.dgFactura.TabIndex = 46;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel9.Location = new System.Drawing.Point(13, 620);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(7, 39);
            this.panel9.TabIndex = 50;
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
            this.btnArchivo.Location = new System.Drawing.Point(13, 620);
            this.btnArchivo.Margin = new System.Windows.Forms.Padding(4);
            this.btnArchivo.Name = "btnArchivo";
            this.btnArchivo.Size = new System.Drawing.Size(224, 39);
            this.btnArchivo.TabIndex = 49;
            this.btnArchivo.Text = "Exportar CSV";
            this.btnArchivo.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(7, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(674, 30);
            this.label8.TabIndex = 53;
            this.label8.Text = "Reporte Facturas - Visualización y exportación de datos\r\n";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(258, 620);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(7, 39);
            this.panel1.TabIndex = 55;
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Location = new System.Drawing.Point(258, 620);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(224, 39);
            this.btnExcel.TabIndex = 54;
            this.btnExcel.Text = "Exportar Excel";
            this.btnExcel.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(1359, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(256, 472);
            this.label9.TabIndex = 56;
            this.label9.Text = resources.GetString("label9.Text");
            // 
            // dSfacturas2_0
            // 
            this.dSfacturas2_0.DataSetName = "DSfacturas2_0";
            this.dSfacturas2_0.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facturasBindingSource
            // 
            this.facturasBindingSource.DataMember = "Facturas";
            this.facturasBindingSource.DataSource = this.dSfacturas2_0;
            // 
            // facturasTableAdapter
            // 
            this.facturasTableAdapter.ClearBeforeFill = true;
            // 
            // idfacturaDataGridViewTextBoxColumn
            // 
            this.idfacturaDataGridViewTextBoxColumn.DataPropertyName = "id_factura";
            this.idfacturaDataGridViewTextBoxColumn.HeaderText = "id_factura";
            this.idfacturaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idfacturaDataGridViewTextBoxColumn.Name = "idfacturaDataGridViewTextBoxColumn";
            this.idfacturaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idfacturaDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaPagoDataGridViewTextBoxColumn
            // 
            this.fechaPagoDataGridViewTextBoxColumn.DataPropertyName = "fechaPago";
            this.fechaPagoDataGridViewTextBoxColumn.HeaderText = "fechaPago";
            this.fechaPagoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaPagoDataGridViewTextBoxColumn.Name = "fechaPagoDataGridViewTextBoxColumn";
            this.fechaPagoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaPagoDataGridViewTextBoxColumn.Width = 125;
            // 
            // codEspecialidadDataGridViewTextBoxColumn
            // 
            this.codEspecialidadDataGridViewTextBoxColumn.DataPropertyName = "cod_Especialidad";
            this.codEspecialidadDataGridViewTextBoxColumn.HeaderText = "cod_Especialidad";
            this.codEspecialidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codEspecialidadDataGridViewTextBoxColumn.Name = "codEspecialidadDataGridViewTextBoxColumn";
            this.codEspecialidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.codEspecialidadDataGridViewTextBoxColumn.Width = 125;
            // 
            // especialidadDataGridViewTextBoxColumn
            // 
            this.especialidadDataGridViewTextBoxColumn.DataPropertyName = "especialidad";
            this.especialidadDataGridViewTextBoxColumn.HeaderText = "especialidad";
            this.especialidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.especialidadDataGridViewTextBoxColumn.Name = "especialidadDataGridViewTextBoxColumn";
            this.especialidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.especialidadDataGridViewTextBoxColumn.Width = 125;
            // 
            // detalleConsultaDataGridViewTextBoxColumn
            // 
            this.detalleConsultaDataGridViewTextBoxColumn.DataPropertyName = "detalle_Consulta";
            this.detalleConsultaDataGridViewTextBoxColumn.HeaderText = "detalle_Consulta";
            this.detalleConsultaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.detalleConsultaDataGridViewTextBoxColumn.Name = "detalleConsultaDataGridViewTextBoxColumn";
            this.detalleConsultaDataGridViewTextBoxColumn.ReadOnly = true;
            this.detalleConsultaDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Width = 125;
            // 
            // ivaDataGridViewTextBoxColumn
            // 
            this.ivaDataGridViewTextBoxColumn.DataPropertyName = "iva";
            this.ivaDataGridViewTextBoxColumn.HeaderText = "iva";
            this.ivaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ivaDataGridViewTextBoxColumn.Name = "ivaDataGridViewTextBoxColumn";
            this.ivaDataGridViewTextBoxColumn.ReadOnly = true;
            this.ivaDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalIvaDataGridViewTextBoxColumn
            // 
            this.totalIvaDataGridViewTextBoxColumn.DataPropertyName = "total_Iva";
            this.totalIvaDataGridViewTextBoxColumn.HeaderText = "total_Iva";
            this.totalIvaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalIvaDataGridViewTextBoxColumn.Name = "totalIvaDataGridViewTextBoxColumn";
            this.totalIvaDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalIvaDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "tipo";
            this.tipoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoDataGridViewTextBoxColumn.Width = 125;
            // 
            // reporteFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(1661, 790);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.btnArchivo);
            this.Controls.Add(this.dgFactura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "reporteFacturas";
            this.Text = "reporteFacturas";
            this.Load += new System.EventHandler(this.reporteFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSfacturas2_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgFactura;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnArchivo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Label label9;
        private DSfacturas2_0 dSfacturas2_0;
        private System.Windows.Forms.BindingSource facturasBindingSource;
        private DSfacturas2_0TableAdapters.FacturasTableAdapter facturasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEspecialidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleConsultaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ivaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalIvaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
    }
}