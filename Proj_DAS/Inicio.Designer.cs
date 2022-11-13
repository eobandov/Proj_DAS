
namespace Proj_DAS
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnPago = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCita = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.gbPaciente = new System.Windows.Forms.GroupBox();
            this.gbUsuario = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEM = new System.Windows.Forms.RadioButton();
            this.btnEA = new System.Windows.Forms.RadioButton();
            this.btnPax = new System.Windows.Forms.RadioButton();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelContenedor.SuspendLayout();
            this.gbUsuario.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BarraTitulo.Controls.Add(this.btnRestaurar);
            this.BarraTitulo.Controls.Add(this.btnMinimizar);
            this.BarraTitulo.Controls.Add(this.btnMaximizar);
            this.BarraTitulo.Controls.Add(this.btnCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1300, 38);
            this.BarraTitulo.TabIndex = 0;
            this.BarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.BarraTitulo_Paint);
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1236, 9);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(25, 25);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1205, 7);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1236, 7);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(25, 25);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1267, 7);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MenuVertical.Controls.Add(this.panel5);
            this.MenuVertical.Controls.Add(this.btnAdmin);
            this.MenuVertical.Controls.Add(this.panel4);
            this.MenuVertical.Controls.Add(this.btnPago);
            this.MenuVertical.Controls.Add(this.panel3);
            this.MenuVertical.Controls.Add(this.btnCita);
            this.MenuVertical.Controls.Add(this.panel2);
            this.MenuVertical.Controls.Add(this.btnPaciente);
            this.MenuVertical.Controls.Add(this.panel1);
            this.MenuVertical.Controls.Add(this.btnUsuario);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 38);
            this.MenuVertical.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(224, 612);
            this.MenuVertical.TabIndex = 1;
            this.MenuVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuVertical_Paint);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel5.Location = new System.Drawing.Point(0, 569);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(7, 39);
            this.panel5.TabIndex = 10;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmin.Image")));
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Location = new System.Drawing.Point(0, 569);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(224, 39);
            this.btnAdmin.TabIndex = 9;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel4.Location = new System.Drawing.Point(0, 209);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(7, 39);
            this.panel4.TabIndex = 8;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // btnPago
            // 
            this.btnPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnPago.FlatAppearance.BorderSize = 0;
            this.btnPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPago.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPago.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPago.Image = ((System.Drawing.Image)(resources.GetObject("btnPago.Image")));
            this.btnPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPago.Location = new System.Drawing.Point(0, 209);
            this.btnPago.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(224, 39);
            this.btnPago.TabIndex = 7;
            this.btnPago.Text = "Pagos";
            this.btnPago.UseVisualStyleBackColor = false;
            this.btnPago.Click += new System.EventHandler(this.btnPago_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel3.Location = new System.Drawing.Point(0, 162);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(7, 39);
            this.panel3.TabIndex = 6;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnCita
            // 
            this.btnCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCita.FlatAppearance.BorderSize = 0;
            this.btnCita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCita.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCita.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCita.Image = ((System.Drawing.Image)(resources.GetObject("btnCita.Image")));
            this.btnCita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCita.Location = new System.Drawing.Point(0, 162);
            this.btnCita.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCita.Name = "btnCita";
            this.btnCita.Size = new System.Drawing.Size(224, 39);
            this.btnCita.TabIndex = 5;
            this.btnCita.Text = "Cita";
            this.btnCita.UseVisualStyleBackColor = false;
            this.btnCita.Click += new System.EventHandler(this.btnCita_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(0, 116);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(7, 39);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnPaciente
            // 
            this.btnPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnPaciente.FlatAppearance.BorderSize = 0;
            this.btnPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaciente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaciente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPaciente.Image = ((System.Drawing.Image)(resources.GetObject("btnPaciente.Image")));
            this.btnPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaciente.Location = new System.Drawing.Point(0, 116);
            this.btnPaciente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(224, 39);
            this.btnPaciente.TabIndex = 3;
            this.btnPaciente.Text = "Paciente";
            this.btnPaciente.UseVisualStyleBackColor = false;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(0, 69);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(7, 39);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuario.Image")));
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.Location = new System.Drawing.Point(0, 69);
            this.btnUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(224, 39);
            this.btnUsuario.TabIndex = 1;
            this.btnUsuario.Text = "Usuario";
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.MediumPurple;
            this.panelContenedor.Controls.Add(this.gbUsuario);
            this.panelContenedor.Controls.Add(this.gbPaciente);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(224, 38);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1076, 612);
            this.panelContenedor.TabIndex = 2;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // gbPaciente
            // 
            this.gbPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPaciente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbPaciente.Location = new System.Drawing.Point(32, 27);
            this.gbPaciente.Name = "gbPaciente";
            this.gbPaciente.Size = new System.Drawing.Size(1036, 581);
            this.gbPaciente.TabIndex = 0;
            this.gbPaciente.TabStop = false;
            this.gbPaciente.Text = "Menú Pacientes";
            this.gbPaciente.Visible = false;
            // 
            // gbUsuario
            // 
            this.gbUsuario.Controls.Add(this.groupBox1);
            this.gbUsuario.Enabled = false;
            this.gbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbUsuario.Location = new System.Drawing.Point(69, 69);
            this.gbUsuario.Name = "gbUsuario";
            this.gbUsuario.Size = new System.Drawing.Size(973, 507);
            this.gbUsuario.TabIndex = 2;
            this.gbUsuario.TabStop = false;
            this.gbUsuario.Text = "Menú Usuarios";
            this.gbUsuario.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEM);
            this.groupBox1.Controls.Add(this.btnEA);
            this.groupBox1.Controls.Add(this.btnPax);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(3, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(967, 144);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Usuarios";
            // 
            // btnEM
            // 
            this.btnEM.AutoSize = true;
            this.btnEM.Location = new System.Drawing.Point(329, 43);
            this.btnEM.Name = "btnEM";
            this.btnEM.Size = new System.Drawing.Size(163, 24);
            this.btnEM.TabIndex = 2;
            this.btnEM.TabStop = true;
            this.btnEM.Text = "Empleado médico";
            this.btnEM.UseVisualStyleBackColor = true;
            // 
            // btnEA
            // 
            this.btnEA.AutoSize = true;
            this.btnEA.Location = new System.Drawing.Point(108, 43);
            this.btnEA.Name = "btnEA";
            this.btnEA.Size = new System.Drawing.Size(215, 24);
            this.btnEA.TabIndex = 1;
            this.btnEA.TabStop = true;
            this.btnEA.Text = "Empleado Administrativo";
            this.btnEA.UseVisualStyleBackColor = true;
            // 
            // btnPax
            // 
            this.btnPax.AutoSize = true;
            this.btnPax.Location = new System.Drawing.Point(7, 43);
            this.btnPax.Name = "btnPax";
            this.btnPax.Size = new System.Drawing.Size(95, 24);
            this.btnPax.TabIndex = 0;
            this.btnPax.TabStop = true;
            this.btnPax.Text = "Paciente";
            this.btnPax.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.gbUsuario.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnPago;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCita;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.GroupBox gbPaciente;
        private System.Windows.Forms.GroupBox gbUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btnEM;
        private System.Windows.Forms.RadioButton btnEA;
        private System.Windows.Forms.RadioButton btnPax;
    }
}

