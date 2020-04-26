namespace Primo_y_Fibonacci
{
    partial class Inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
            this.GrbDatosInventario = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.BtnBuscarInventarioProducto = new System.Windows.Forms.Button();
            this.lblidventas = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblidinventario = new System.Windows.Forms.Label();
            this.cbotInventProducto = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblID = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.txtunidades = new System.Windows.Forms.TextBox();
            this.txtcantExistente = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GrbCliente = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblop2 = new System.Windows.Forms.Label();
            this.lblop = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.GrbNavegacion = new System.Windows.Forms.GroupBox();
            this.lblnregistros = new System.Windows.Forms.Label();
            this.BtnAnterior = new System.Windows.Forms.Button();
            this.BtnPrimero = new System.Windows.Forms.Button();
            this.BtnSiguiente = new System.Windows.Forms.Button();
            this.BtnUltimo = new System.Windows.Forms.Button();
            this.GrbDatosInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GrbCliente.SuspendLayout();
            this.GrbNavegacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrbDatosInventario
            // 
            this.GrbDatosInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.GrbDatosInventario.Controls.Add(this.label13);
            this.GrbDatosInventario.Controls.Add(this.BtnBuscarInventarioProducto);
            this.GrbDatosInventario.Controls.Add(this.lblidventas);
            this.GrbDatosInventario.Controls.Add(this.label7);
            this.GrbDatosInventario.Controls.Add(this.lblidinventario);
            this.GrbDatosInventario.Controls.Add(this.cbotInventProducto);
            this.GrbDatosInventario.Controls.Add(this.label9);
            this.GrbDatosInventario.Controls.Add(this.pictureBox1);
            this.GrbDatosInventario.Controls.Add(this.LblID);
            this.GrbDatosInventario.Controls.Add(this.LblNombre);
            this.GrbDatosInventario.Controls.Add(this.txtunidades);
            this.GrbDatosInventario.Controls.Add(this.txtcantExistente);
            this.GrbDatosInventario.Controls.Add(this.LblEmail);
            this.GrbDatosInventario.Enabled = false;
            this.GrbDatosInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbDatosInventario.Location = new System.Drawing.Point(2, 2);
            this.GrbDatosInventario.Name = "GrbDatosInventario";
            this.GrbDatosInventario.Size = new System.Drawing.Size(525, 276);
            this.GrbDatosInventario.TabIndex = 19;
            this.GrbDatosInventario.TabStop = false;
            this.GrbDatosInventario.Text = "DATOS DE INVENTARIO";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(471, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Buscar";
            // 
            // BtnBuscarInventarioProducto
            // 
            this.BtnBuscarInventarioProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnBuscarInventarioProducto.BackgroundImage")));
            this.BtnBuscarInventarioProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBuscarInventarioProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBuscarInventarioProducto.Location = new System.Drawing.Point(472, 37);
            this.BtnBuscarInventarioProducto.Name = "BtnBuscarInventarioProducto";
            this.BtnBuscarInventarioProducto.Size = new System.Drawing.Size(47, 21);
            this.BtnBuscarInventarioProducto.TabIndex = 32;
            this.BtnBuscarInventarioProducto.UseVisualStyleBackColor = true;
            this.BtnBuscarInventarioProducto.Click += new System.EventHandler(this.BtnBuscarCategoriaProducto_Click);
            // 
            // lblidventas
            // 
            this.lblidventas.AutoSize = true;
            this.lblidventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidventas.Location = new System.Drawing.Point(324, 120);
            this.lblidventas.Name = "lblidventas";
            this.lblidventas.Size = new System.Drawing.Size(0, 13);
            this.lblidventas.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(211, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "ID VENTAS:";
            // 
            // lblidinventario
            // 
            this.lblidinventario.AutoSize = true;
            this.lblidinventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidinventario.Location = new System.Drawing.Point(324, 80);
            this.lblidinventario.Name = "lblidinventario";
            this.lblidinventario.Size = new System.Drawing.Size(0, 13);
            this.lblidinventario.TabIndex = 29;
            // 
            // cbotInventProducto
            // 
            this.cbotInventProducto.FormattingEnabled = true;
            this.cbotInventProducto.Location = new System.Drawing.Point(310, 37);
            this.cbotInventProducto.Margin = new System.Windows.Forms.Padding(1);
            this.cbotInventProducto.Name = "cbotInventProducto";
            this.cbotInventProducto.Size = new System.Drawing.Size(154, 21);
            this.cbotInventProducto.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(208, 40);
            this.label9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "PRODUCTO:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblID.Location = new System.Drawing.Point(264, 80);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(24, 13);
            this.LblID.TabIndex = 1;
            this.LblID.Text = "ID:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(213, 163);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(75, 13);
            this.LblNombre.TabIndex = 3;
            this.LblNombre.Text = "UNIDADES:";
            // 
            // txtunidades
            // 
            this.txtunidades.Location = new System.Drawing.Point(310, 160);
            this.txtunidades.Name = "txtunidades";
            this.txtunidades.Size = new System.Drawing.Size(100, 20);
            this.txtunidades.TabIndex = 4;
            // 
            // txtcantExistente
            // 
            this.txtcantExistente.Location = new System.Drawing.Point(310, 204);
            this.txtcantExistente.Name = "txtcantExistente";
            this.txtcantExistente.Size = new System.Drawing.Size(100, 20);
            this.txtcantExistente.TabIndex = 6;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(141, 207);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(147, 13);
            this.LblEmail.TabIndex = 5;
            this.LblEmail.Text = "CANTIDAD EXISTENTE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "OPCIONES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "NAVEGACIÓN";
            // 
            // GrbCliente
            // 
            this.GrbCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GrbCliente.Controls.Add(this.label5);
            this.GrbCliente.Controls.Add(this.btnsalir);
            this.GrbCliente.Controls.Add(this.label3);
            this.GrbCliente.Controls.Add(this.label6);
            this.GrbCliente.Controls.Add(this.lblop2);
            this.GrbCliente.Controls.Add(this.lblop);
            this.GrbCliente.Controls.Add(this.BtnBuscar);
            this.GrbCliente.Controls.Add(this.BtnDelete);
            this.GrbCliente.Controls.Add(this.BtnModificar);
            this.GrbCliente.Controls.Add(this.BtnNuevo);
            this.GrbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbCliente.Location = new System.Drawing.Point(0, 449);
            this.GrbCliente.Name = "GrbCliente";
            this.GrbCliente.Size = new System.Drawing.Size(525, 96);
            this.GrbCliente.TabIndex = 25;
            this.GrbCliente.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(448, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Salir";
            // 
            // btnsalir
            // 
            this.btnsalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsalir.BackgroundImage")));
            this.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsalir.Location = new System.Drawing.Point(430, 19);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(66, 57);
            this.btnsalir.TabIndex = 22;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(344, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Buscar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(138, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Eliminar";
            // 
            // lblop2
            // 
            this.lblop2.AutoSize = true;
            this.lblop2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblop2.Location = new System.Drawing.Point(243, 78);
            this.lblop2.Name = "lblop2";
            this.lblop2.Size = new System.Drawing.Size(40, 13);
            this.lblop2.TabIndex = 17;
            this.lblop2.Text = "Editar";
            // 
            // lblop
            // 
            this.lblop.AutoSize = true;
            this.lblop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblop.Location = new System.Drawing.Point(32, 78);
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
            this.BtnBuscar.Location = new System.Drawing.Point(333, 18);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(66, 57);
            this.BtnBuscar.TabIndex = 5;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Transparent;
            this.BtnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDelete.BackgroundImage")));
            this.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDelete.Location = new System.Drawing.Point(129, 18);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(66, 57);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.Transparent;
            this.BtnModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnModificar.BackgroundImage")));
            this.BtnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnModificar.Location = new System.Drawing.Point(231, 18);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(66, 57);
            this.BtnModificar.TabIndex = 5;
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.BtnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnNuevo.BackgroundImage")));
            this.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.ForeColor = System.Drawing.Color.Transparent;
            this.BtnNuevo.Location = new System.Drawing.Point(22, 19);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(67, 57);
            this.BtnNuevo.TabIndex = 4;
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // GrbNavegacion
            // 
            this.GrbNavegacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GrbNavegacion.Controls.Add(this.lblnregistros);
            this.GrbNavegacion.Controls.Add(this.BtnAnterior);
            this.GrbNavegacion.Controls.Add(this.BtnPrimero);
            this.GrbNavegacion.Controls.Add(this.BtnSiguiente);
            this.GrbNavegacion.Controls.Add(this.BtnUltimo);
            this.GrbNavegacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbNavegacion.Location = new System.Drawing.Point(0, 334);
            this.GrbNavegacion.Name = "GrbNavegacion";
            this.GrbNavegacion.Size = new System.Drawing.Size(525, 62);
            this.GrbNavegacion.TabIndex = 24;
            this.GrbNavegacion.TabStop = false;
            // 
            // lblnregistros
            // 
            this.lblnregistros.AutoSize = true;
            this.lblnregistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnregistros.Location = new System.Drawing.Point(234, 27);
            this.lblnregistros.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblnregistros.Name = "lblnregistros";
            this.lblnregistros.Size = new System.Drawing.Size(0, 13);
            this.lblnregistros.TabIndex = 5;
            // 
            // BtnAnterior
            // 
            this.BtnAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnAnterior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAnterior.BackgroundImage")));
            this.BtnAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAnterior.Location = new System.Drawing.Point(124, 10);
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
            this.BtnPrimero.Location = new System.Drawing.Point(28, 10);
            this.BtnPrimero.Name = "BtnPrimero";
            this.BtnPrimero.Size = new System.Drawing.Size(56, 46);
            this.BtnPrimero.TabIndex = 0;
            this.BtnPrimero.UseVisualStyleBackColor = false;
            this.BtnPrimero.Click += new System.EventHandler(this.BtnPrimero_Click);
            // 
            // BtnSiguiente
            // 
            this.BtnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnSiguiente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSiguiente.BackgroundImage")));
            this.BtnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSiguiente.Location = new System.Drawing.Point(333, 10);
            this.BtnSiguiente.Name = "BtnSiguiente";
            this.BtnSiguiente.Size = new System.Drawing.Size(56, 46);
            this.BtnSiguiente.TabIndex = 2;
            this.BtnSiguiente.UseVisualStyleBackColor = false;
            this.BtnSiguiente.Click += new System.EventHandler(this.BtnSiguiente_Click);
            // 
            // BtnUltimo
            // 
            this.BtnUltimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnUltimo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnUltimo.BackgroundImage")));
            this.BtnUltimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnUltimo.Location = new System.Drawing.Point(430, 10);
            this.BtnUltimo.Name = "BtnUltimo";
            this.BtnUltimo.Size = new System.Drawing.Size(56, 46);
            this.BtnUltimo.TabIndex = 3;
            this.BtnUltimo.UseVisualStyleBackColor = false;
            this.BtnUltimo.Click += new System.EventHandler(this.BtnUltimo_Click);
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GrbCliente);
            this.Controls.Add(this.GrbNavegacion);
            this.Controls.Add(this.GrbDatosInventario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            this.GrbDatosInventario.ResumeLayout(false);
            this.GrbDatosInventario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GrbCliente.ResumeLayout(false);
            this.GrbCliente.PerformLayout();
            this.GrbNavegacion.ResumeLayout(false);
            this.GrbNavegacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbDatosInventario;
        private System.Windows.Forms.Label lblidinventario;
        private System.Windows.Forms.ComboBox cbotInventProducto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox txtunidades;
        private System.Windows.Forms.TextBox txtcantExistente;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label lblidventas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GrbCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblop2;
        private System.Windows.Forms.Label lblop;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.GroupBox GrbNavegacion;
        private System.Windows.Forms.Label lblnregistros;
        private System.Windows.Forms.Button BtnAnterior;
        private System.Windows.Forms.Button BtnPrimero;
        private System.Windows.Forms.Button BtnSiguiente;
        private System.Windows.Forms.Button BtnUltimo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button BtnBuscarInventarioProducto;
    }
}