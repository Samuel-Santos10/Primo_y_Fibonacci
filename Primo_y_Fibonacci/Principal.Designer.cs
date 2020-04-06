namespace Primo_y_Fibonacci
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.GrbDatosCliente = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtDirección = new System.Windows.Forms.TextBox();
            this.LblIDCliente = new System.Windows.Forms.Label();
            this.TxtIdCliente = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.GrbCliente = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblop2 = new System.Windows.Forms.Label();
            this.lblop = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnUltimo = new System.Windows.Forms.Button();
            this.BtnSiguiente = new System.Windows.Forms.Button();
            this.GrbNavegacion = new System.Windows.Forms.GroupBox();
            this.lblnregistros = new System.Windows.Forms.Label();
            this.BtnAnterior = new System.Windows.Forms.Button();
            this.BtnPrimero = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formularioEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularioProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.GrbDatosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GrbCliente.SuspendLayout();
            this.GrbNavegacion.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrbDatosCliente
            // 
            this.GrbDatosCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GrbDatosCliente.Controls.Add(this.label6);
            this.GrbDatosCliente.Controls.Add(this.txtcodigo);
            this.GrbDatosCliente.Controls.Add(this.pictureBox1);
            this.GrbDatosCliente.Controls.Add(this.TxtDirección);
            this.GrbDatosCliente.Controls.Add(this.LblIDCliente);
            this.GrbDatosCliente.Controls.Add(this.TxtIdCliente);
            this.GrbDatosCliente.Controls.Add(this.LblNombre);
            this.GrbDatosCliente.Controls.Add(this.LblDireccion);
            this.GrbDatosCliente.Controls.Add(this.TxtNombre);
            this.GrbDatosCliente.Controls.Add(this.TxtEmail);
            this.GrbDatosCliente.Controls.Add(this.LblEmail);
            this.GrbDatosCliente.Enabled = false;
            this.GrbDatosCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbDatosCliente.Location = new System.Drawing.Point(0, 30);
            this.GrbDatosCliente.Name = "GrbDatosCliente";
            this.GrbDatosCliente.Size = new System.Drawing.Size(525, 228);
            this.GrbDatosCliente.TabIndex = 14;
            this.GrbDatosCliente.TabStop = false;
            this.GrbDatosCliente.Text = "DATOS DE CLIENTE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // TxtDirección
            // 
            this.TxtDirección.Location = new System.Drawing.Point(234, 178);
            this.TxtDirección.Multiline = true;
            this.TxtDirección.Name = "TxtDirección";
            this.TxtDirección.Size = new System.Drawing.Size(282, 39);
            this.TxtDirección.TabIndex = 8;
            // 
            // LblIDCliente
            // 
            this.LblIDCliente.AutoSize = true;
            this.LblIDCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIDCliente.Location = new System.Drawing.Point(137, 38);
            this.LblIDCliente.Name = "LblIDCliente";
            this.LblIDCliente.Size = new System.Drawing.Size(80, 13);
            this.LblIDCliente.TabIndex = 1;
            this.LblIDCliente.Text = "ID CLIENTE:";
            // 
            // TxtIdCliente
            // 
            this.TxtIdCliente.Location = new System.Drawing.Point(234, 31);
            this.TxtIdCliente.Name = "TxtIdCliente";
            this.TxtIdCliente.Size = new System.Drawing.Size(100, 20);
            this.TxtIdCliente.TabIndex = 2;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(152, 106);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(64, 13);
            this.LblNombre.TabIndex = 3;
            this.LblNombre.Text = "NOMBRE:";
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDireccion.Location = new System.Drawing.Point(137, 185);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(79, 13);
            this.LblDireccion.TabIndex = 7;
            this.LblDireccion.Text = "DIRECCION:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(234, 99);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(193, 20);
            this.TxtNombre.TabIndex = 4;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(234, 136);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(193, 20);
            this.TxtEmail.TabIndex = 6;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(164, 143);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(52, 13);
            this.LblEmail.TabIndex = 5;
            this.LblEmail.Text = "E-MAIL:";
            // 
            // GrbCliente
            // 
            this.GrbCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GrbCliente.Controls.Add(this.label5);
            this.GrbCliente.Controls.Add(this.btnsalir);
            this.GrbCliente.Controls.Add(this.label3);
            this.GrbCliente.Controls.Add(this.label2);
            this.GrbCliente.Controls.Add(this.lblop2);
            this.GrbCliente.Controls.Add(this.lblop);
            this.GrbCliente.Controls.Add(this.BtnBuscar);
            this.GrbCliente.Controls.Add(this.BtnDelete);
            this.GrbCliente.Controls.Add(this.BtnModificar);
            this.GrbCliente.Controls.Add(this.BtnNuevo);
            this.GrbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbCliente.Location = new System.Drawing.Point(0, 391);
            this.GrbCliente.Name = "GrbCliente";
            this.GrbCliente.Size = new System.Drawing.Size(525, 96);
            this.GrbCliente.TabIndex = 13;
            this.GrbCliente.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(442, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Salir";
            // 
            // btnsalir
            // 
            this.btnsalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsalir.BackgroundImage")));
            this.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsalir.Location = new System.Drawing.Point(424, 13);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(66, 57);
            this.btnsalir.TabIndex = 20;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(330, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Buscar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Eliminar";
            // 
            // lblop2
            // 
            this.lblop2.AutoSize = true;
            this.lblop2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblop2.Location = new System.Drawing.Point(237, 73);
            this.lblop2.Name = "lblop2";
            this.lblop2.Size = new System.Drawing.Size(40, 13);
            this.lblop2.TabIndex = 17;
            this.lblop2.Text = "Editar";
            // 
            // lblop
            // 
            this.lblop.AutoSize = true;
            this.lblop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblop.Location = new System.Drawing.Point(32, 73);
            this.lblop.Name = "lblop";
            this.lblop.Size = new System.Drawing.Size(44, 13);
            this.lblop.TabIndex = 16;
            this.lblop.Text = "Nuevo";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.BackgroundImage")));
            this.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBuscar.Location = new System.Drawing.Point(319, 13);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(66, 57);
            this.BtnBuscar.TabIndex = 5;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click_1);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Transparent;
            this.BtnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDelete.BackgroundImage")));
            this.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDelete.Location = new System.Drawing.Point(123, 13);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(66, 57);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click_1);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.Transparent;
            this.BtnModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnModificar.BackgroundImage")));
            this.BtnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnModificar.Location = new System.Drawing.Point(225, 13);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(66, 57);
            this.BtnModificar.TabIndex = 5;
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click_1);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.BtnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnNuevo.BackgroundImage")));
            this.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.ForeColor = System.Drawing.Color.Transparent;
            this.BtnNuevo.Location = new System.Drawing.Point(22, 13);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(67, 57);
            this.BtnNuevo.TabIndex = 4;
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click_1);
            // 
            // BtnUltimo
            // 
            this.BtnUltimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnUltimo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnUltimo.BackgroundImage")));
            this.BtnUltimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnUltimo.Location = new System.Drawing.Point(434, 10);
            this.BtnUltimo.Name = "BtnUltimo";
            this.BtnUltimo.Size = new System.Drawing.Size(56, 46);
            this.BtnUltimo.TabIndex = 3;
            this.BtnUltimo.UseVisualStyleBackColor = false;
            this.BtnUltimo.Click += new System.EventHandler(this.BtnUltimo_Click_1);
            // 
            // BtnSiguiente
            // 
            this.BtnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnSiguiente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSiguiente.BackgroundImage")));
            this.BtnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSiguiente.Location = new System.Drawing.Point(345, 10);
            this.BtnSiguiente.Name = "BtnSiguiente";
            this.BtnSiguiente.Size = new System.Drawing.Size(56, 46);
            this.BtnSiguiente.TabIndex = 2;
            this.BtnSiguiente.UseVisualStyleBackColor = false;
            this.BtnSiguiente.Click += new System.EventHandler(this.BtnSiguiente_Click_1);
            // 
            // GrbNavegacion
            // 
            this.GrbNavegacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GrbNavegacion.Controls.Add(this.lblnregistros);
            this.GrbNavegacion.Controls.Add(this.BtnAnterior);
            this.GrbNavegacion.Controls.Add(this.BtnPrimero);
            this.GrbNavegacion.Controls.Add(this.BtnSiguiente);
            this.GrbNavegacion.Controls.Add(this.BtnUltimo);
            this.GrbNavegacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbNavegacion.Location = new System.Drawing.Point(0, 290);
            this.GrbNavegacion.Name = "GrbNavegacion";
            this.GrbNavegacion.Size = new System.Drawing.Size(525, 62);
            this.GrbNavegacion.TabIndex = 12;
            this.GrbNavegacion.TabStop = false;
            // 
            // lblnregistros
            // 
            this.lblnregistros.AutoSize = true;
            this.lblnregistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnregistros.Location = new System.Drawing.Point(262, 27);
            this.lblnregistros.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblnregistros.Name = "lblnregistros";
            this.lblnregistros.Size = new System.Drawing.Size(0, 13);
            this.lblnregistros.TabIndex = 20;
            // 
            // BtnAnterior
            // 
            this.BtnAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnAnterior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAnterior.BackgroundImage")));
            this.BtnAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAnterior.Location = new System.Drawing.Point(133, 10);
            this.BtnAnterior.Name = "BtnAnterior";
            this.BtnAnterior.Size = new System.Drawing.Size(56, 46);
            this.BtnAnterior.TabIndex = 1;
            this.BtnAnterior.UseVisualStyleBackColor = false;
            this.BtnAnterior.Click += new System.EventHandler(this.BtnAnterior_Click);
            // 
            // BtnPrimero
            // 
            this.BtnPrimero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnPrimero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPrimero.BackgroundImage")));
            this.BtnPrimero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPrimero.Location = new System.Drawing.Point(46, 10);
            this.BtnPrimero.Name = "BtnPrimero";
            this.BtnPrimero.Size = new System.Drawing.Size(56, 46);
            this.BtnPrimero.TabIndex = 0;
            this.BtnPrimero.UseVisualStyleBackColor = false;
            this.BtnPrimero.Click += new System.EventHandler(this.BtnPrimero_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "NAVEGACIÓN";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formularioEmpleadoToolStripMenuItem,
            this.formularioProductosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(525, 28);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formularioEmpleadoToolStripMenuItem
            // 
            this.formularioEmpleadoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.formularioEmpleadoToolStripMenuItem.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formularioEmpleadoToolStripMenuItem.Name = "formularioEmpleadoToolStripMenuItem";
            this.formularioEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.formularioEmpleadoToolStripMenuItem.Text = "Formulario Empleado";
            this.formularioEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.formularioEmpleadoToolStripMenuItem_Click);
            // 
            // formularioProductosToolStripMenuItem
            // 
            this.formularioProductosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.formularioProductosToolStripMenuItem.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formularioProductosToolStripMenuItem.Name = "formularioProductosToolStripMenuItem";
            this.formularioProductosToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.formularioProductosToolStripMenuItem.Text = "Formulario Productos";
            this.formularioProductosToolStripMenuItem.Click += new System.EventHandler(this.formularioProductosToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(222, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "OPCIONES";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(136, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "ID CLIENTE:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(234, 69);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 20);
            this.txtcodigo.TabIndex = 12;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(525, 499);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GrbDatosCliente);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GrbNavegacion);
            this.Controls.Add(this.GrbCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.GrbDatosCliente.ResumeLayout(false);
            this.GrbDatosCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GrbCliente.ResumeLayout(false);
            this.GrbCliente.PerformLayout();
            this.GrbNavegacion.ResumeLayout(false);
            this.GrbNavegacion.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbDatosCliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtDirección;
        private System.Windows.Forms.Label LblIDCliente;
        private System.Windows.Forms.TextBox TxtIdCliente;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.GroupBox GrbCliente;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnUltimo;
        private System.Windows.Forms.Button BtnSiguiente;
        private System.Windows.Forms.GroupBox GrbNavegacion;
        private System.Windows.Forms.Button BtnAnterior;
        private System.Windows.Forms.Button BtnPrimero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblop;
        private System.Windows.Forms.Label lblop2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formularioEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formularioProductosToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label lblnregistros;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcodigo;
    }
}