namespace Primo_y_Fibonacci
{
    partial class Pedido_Cliente
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
            System.Windows.Forms.Label idPedidoClientLabel;
            System.Windows.Forms.Label id_ClienteLabel;
            System.Windows.Forms.Label id_EmpleadoLabel;
            System.Windows.Forms.Label fecha_ordenLabel;
            System.Windows.Forms.Label fecha_requeridaLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedido_Cliente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.controlDataSet = new Primo_y_Fibonacci.ControlDataSet();
            this.pedido_ClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedido_ClienteTableAdapter = new Primo_y_Fibonacci.ControlDataSetTableAdapters.Pedido_ClienteTableAdapter();
            this.tableAdapterManager = new Primo_y_Fibonacci.ControlDataSetTableAdapters.TableAdapterManager();
            this.clienteTableAdapter = new Primo_y_Fibonacci.ControlDataSetTableAdapters.ClienteTableAdapter();
            this.empleadoTableAdapter = new Primo_y_Fibonacci.ControlDataSetTableAdapters.EmpleadoTableAdapter();
            this.idPedidoClientTextBox = new System.Windows.Forms.TextBox();
            this.id_ClienteComboBox = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id_EmpleadoComboBox = new System.Windows.Forms.ComboBox();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fecha_ordenDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fecha_requeridaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.detallePedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detallePedidoTableAdapter = new Primo_y_Fibonacci.ControlDataSetTableAdapters.DetallePedidoTableAdapter();
            this.pnlNavegacion = new System.Windows.Forms.Panel();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.lblregistroxden = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.detallePedidoDataGridView = new System.Windows.Forms.DataGridView();
            this.btnsalir = new System.Windows.Forms.Button();
            this.pnlEdicion = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pnlProductosGrid = new System.Windows.Forms.Panel();
            this.btnQuitarProductosGrid = new System.Windows.Forms.Button();
            this.btnAgregarProductosGrid = new System.Windows.Forms.Button();
            this.detalle_Pedido_ClientTableAdapter1 = new Primo_y_Fibonacci.ControlDataSetTableAdapters.Detalle_Pedido_ClientTableAdapter();
            this.IdDOrdenC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPedidoC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idPedidoClientLabel = new System.Windows.Forms.Label();
            id_ClienteLabel = new System.Windows.Forms.Label();
            id_EmpleadoLabel = new System.Windows.Forms.Label();
            fecha_ordenLabel = new System.Windows.Forms.Label();
            fecha_requeridaLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.controlDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedido_ClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallePedidoBindingSource)).BeginInit();
            this.pnlNavegacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallePedidoDataGridView)).BeginInit();
            this.pnlEdicion.SuspendLayout();
            this.pnlProductosGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // idPedidoClientLabel
            // 
            idPedidoClientLabel.AutoSize = true;
            idPedidoClientLabel.Location = new System.Drawing.Point(19, 142);
            idPedidoClientLabel.Name = "idPedidoClientLabel";
            idPedidoClientLabel.Size = new System.Drawing.Size(62, 13);
            idPedidoClientLabel.TabIndex = 1;
            idPedidoClientLabel.Text = "ID PEDIDO";
            // 
            // id_ClienteLabel
            // 
            id_ClienteLabel.AutoSize = true;
            id_ClienteLabel.Location = new System.Drawing.Point(229, 142);
            id_ClienteLabel.Name = "id_ClienteLabel";
            id_ClienteLabel.Size = new System.Drawing.Size(52, 13);
            id_ClienteLabel.TabIndex = 3;
            id_ClienteLabel.Text = "CLIENTE";
            // 
            // id_EmpleadoLabel
            // 
            id_EmpleadoLabel.AutoSize = true;
            id_EmpleadoLabel.Location = new System.Drawing.Point(292, 187);
            id_EmpleadoLabel.Name = "id_EmpleadoLabel";
            id_EmpleadoLabel.Size = new System.Drawing.Size(66, 13);
            id_EmpleadoLabel.TabIndex = 5;
            id_EmpleadoLabel.Text = "EMPLEADO";
            // 
            // fecha_ordenLabel
            // 
            fecha_ordenLabel.AutoSize = true;
            fecha_ordenLabel.Location = new System.Drawing.Point(12, 246);
            fecha_ordenLabel.Name = "fecha_ordenLabel";
            fecha_ordenLabel.Size = new System.Drawing.Size(86, 13);
            fecha_ordenLabel.TabIndex = 11;
            fecha_ordenLabel.Text = "FECHA PEDIDO";
            // 
            // fecha_requeridaLabel
            // 
            fecha_requeridaLabel.AutoSize = true;
            fecha_requeridaLabel.Location = new System.Drawing.Point(311, 248);
            fecha_requeridaLabel.Name = "fecha_requeridaLabel";
            fecha_requeridaLabel.Size = new System.Drawing.Size(109, 13);
            fecha_requeridaLabel.TabIndex = 13;
            fecha_requeridaLabel.Text = "FECHA REQUERIDA";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(12, 188);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(66, 13);
            direccionLabel.TabIndex = 15;
            direccionLabel.Text = "DIRECCION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Forte", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(197, 40);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(338, 38);
            label2.TabIndex = 36;
            label2.Text = "PEDIDOS CLIENTES";
            // 
            // controlDataSet
            // 
            this.controlDataSet.DataSetName = "ControlDataSet";
            this.controlDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pedido_ClienteBindingSource
            // 
            this.pedido_ClienteBindingSource.DataMember = "Pedido_Cliente";
            this.pedido_ClienteBindingSource.DataSource = this.controlDataSet;
            // 
            // pedido_ClienteTableAdapter
            // 
            this.pedido_ClienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriasTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.Compra_OrdenesTableAdapter = null;
            this.tableAdapterManager.condiciones_pagosTableAdapter = null;
            this.tableAdapterManager.detalle_CompraTableAdapter = null;
            this.tableAdapterManager.Detalle_Pedido_ClientTableAdapter = null;
            this.tableAdapterManager.Detalle_VentaTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = this.empleadoTableAdapter;
            this.tableAdapterManager.InventarioTableAdapter = null;
            this.tableAdapterManager.Pedido_ClienteTableAdapter = this.pedido_ClienteTableAdapter;
            this.tableAdapterManager.ProductosTableAdapter = null;
            this.tableAdapterManager.ProveedorTableAdapter = null;
            this.tableAdapterManager.Tipo_documentoTableAdapter = null;
            this.tableAdapterManager.Tipo_UsuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Primo_y_Fibonacci.ControlDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            this.tableAdapterManager.VentasTableAdapter = null;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // idPedidoClientTextBox
            // 
            this.idPedidoClientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedido_ClienteBindingSource, "IdPedidoClient", true));
            this.idPedidoClientTextBox.Location = new System.Drawing.Point(90, 139);
            this.idPedidoClientTextBox.Name = "idPedidoClientTextBox";
            this.idPedidoClientTextBox.ReadOnly = true;
            this.idPedidoClientTextBox.Size = new System.Drawing.Size(81, 20);
            this.idPedidoClientTextBox.TabIndex = 2;
            // 
            // id_ClienteComboBox
            // 
            this.id_ClienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pedido_ClienteBindingSource, "Id_Cliente", true));
            this.id_ClienteComboBox.DataSource = this.clienteBindingSource;
            this.id_ClienteComboBox.DisplayMember = "nombre";
            this.id_ClienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_ClienteComboBox.Enabled = false;
            this.id_ClienteComboBox.FormattingEnabled = true;
            this.id_ClienteComboBox.Location = new System.Drawing.Point(304, 139);
            this.id_ClienteComboBox.Name = "id_ClienteComboBox";
            this.id_ClienteComboBox.Size = new System.Drawing.Size(200, 21);
            this.id_ClienteComboBox.TabIndex = 4;
            this.id_ClienteComboBox.ValueMember = "IdCliente";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.controlDataSet;
            // 
            // id_EmpleadoComboBox
            // 
            this.id_EmpleadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pedido_ClienteBindingSource, "Id_Empleado", true));
            this.id_EmpleadoComboBox.DataSource = this.empleadoBindingSource;
            this.id_EmpleadoComboBox.DisplayMember = "nombre";
            this.id_EmpleadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_EmpleadoComboBox.Enabled = false;
            this.id_EmpleadoComboBox.FormattingEnabled = true;
            this.id_EmpleadoComboBox.Location = new System.Drawing.Point(361, 182);
            this.id_EmpleadoComboBox.Name = "id_EmpleadoComboBox";
            this.id_EmpleadoComboBox.Size = new System.Drawing.Size(200, 21);
            this.id_EmpleadoComboBox.TabIndex = 6;
            this.id_EmpleadoComboBox.ValueMember = "IdEmpleado";
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataMember = "Empleado";
            this.empleadoBindingSource.DataSource = this.controlDataSet;
            // 
            // fecha_ordenDateTimePicker
            // 
            this.fecha_ordenDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pedido_ClienteBindingSource, "fecha_orden", true));
            this.fecha_ordenDateTimePicker.Enabled = false;
            this.fecha_ordenDateTimePicker.Location = new System.Drawing.Point(101, 243);
            this.fecha_ordenDateTimePicker.Name = "fecha_ordenDateTimePicker";
            this.fecha_ordenDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_ordenDateTimePicker.TabIndex = 12;
            // 
            // fecha_requeridaDateTimePicker
            // 
            this.fecha_requeridaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pedido_ClienteBindingSource, "fecha_requerida", true));
            this.fecha_requeridaDateTimePicker.Enabled = false;
            this.fecha_requeridaDateTimePicker.Location = new System.Drawing.Point(424, 244);
            this.fecha_requeridaDateTimePicker.Name = "fecha_requeridaDateTimePicker";
            this.fecha_requeridaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_requeridaDateTimePicker.TabIndex = 14;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedido_ClienteBindingSource, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(81, 184);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.ReadOnly = true;
            this.direccionTextBox.Size = new System.Drawing.Size(200, 20);
            this.direccionTextBox.TabIndex = 16;
            // 
            // detallePedidoBindingSource
            // 
            this.detallePedidoBindingSource.DataMember = "Pedido_Cliente_DetallePedido";
            this.detallePedidoBindingSource.DataSource = this.pedido_ClienteBindingSource;
            // 
            // detallePedidoTableAdapter
            // 
            this.detallePedidoTableAdapter.ClearBeforeFill = true;
            // 
            // pnlNavegacion
            // 
            this.pnlNavegacion.BackColor = System.Drawing.Color.Silver;
            this.pnlNavegacion.Controls.Add(this.btnUltimo);
            this.pnlNavegacion.Controls.Add(this.btnSiguiente);
            this.pnlNavegacion.Controls.Add(this.btnPrimero);
            this.pnlNavegacion.Controls.Add(this.btnAnterior);
            this.pnlNavegacion.Controls.Add(this.lblregistroxden);
            this.pnlNavegacion.Location = new System.Drawing.Point(9, 567);
            this.pnlNavegacion.Name = "pnlNavegacion";
            this.pnlNavegacion.Size = new System.Drawing.Size(385, 63);
            this.pnlNavegacion.TabIndex = 34;
            // 
            // btnUltimo
            // 
            this.btnUltimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUltimo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUltimo.BackgroundImage")));
            this.btnUltimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUltimo.Location = new System.Drawing.Point(310, 8);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(56, 46);
            this.btnUltimo.TabIndex = 29;
            this.btnUltimo.UseVisualStyleBackColor = false;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSiguiente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.BackgroundImage")));
            this.btnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSiguiente.Location = new System.Drawing.Point(231, 8);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(56, 46);
            this.btnSiguiente.TabIndex = 28;
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnPrimero
            // 
            this.btnPrimero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPrimero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrimero.BackgroundImage")));
            this.btnPrimero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrimero.Location = new System.Drawing.Point(7, 8);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(56, 46);
            this.btnPrimero.TabIndex = 28;
            this.btnPrimero.UseVisualStyleBackColor = false;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAnterior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnterior.BackgroundImage")));
            this.btnAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnterior.Location = new System.Drawing.Point(85, 8);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(56, 46);
            this.btnAnterior.TabIndex = 28;
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // lblregistroxden
            // 
            this.lblregistroxden.AutoSize = true;
            this.lblregistroxden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregistroxden.Location = new System.Drawing.Point(163, 23);
            this.lblregistroxden.Name = "lblregistroxden";
            this.lblregistroxden.Size = new System.Drawing.Size(49, 16);
            this.lblregistroxden.TabIndex = 6;
            this.lblregistroxden.Text = "x de n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(25, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 113);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // detallePedidoDataGridView
            // 
            this.detallePedidoDataGridView.AllowUserToAddRows = false;
            this.detallePedidoDataGridView.AllowUserToDeleteRows = false;
            this.detallePedidoDataGridView.AutoGenerateColumns = false;
            this.detallePedidoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detallePedidoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDOrdenC,
            this.IDPedidoC,
            this.IdProducto,
            this.codigo,
            this.nombre,
            this.cantidad,
            this.precio,
            this.precio_orden,
            this.descuento,
            this.subtotal});
            this.detallePedidoDataGridView.DataSource = this.detallePedidoBindingSource;
            this.detallePedidoDataGridView.Location = new System.Drawing.Point(6, 330);
            this.detallePedidoDataGridView.Name = "detallePedidoDataGridView";
            this.detallePedidoDataGridView.ReadOnly = true;
            this.detallePedidoDataGridView.Size = new System.Drawing.Size(614, 166);
            this.detallePedidoDataGridView.TabIndex = 17;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Transparent;
            this.btnsalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsalir.BackgroundImage")));
            this.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsalir.Location = new System.Drawing.Point(582, 3);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(37, 37);
            this.btnsalir.TabIndex = 37;
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // pnlEdicion
            // 
            this.pnlEdicion.Controls.Add(this.btnBuscar);
            this.pnlEdicion.Controls.Add(this.btnEliminar);
            this.pnlEdicion.Controls.Add(this.btnModificar);
            this.pnlEdicion.Controls.Add(this.btnAgregar);
            this.pnlEdicion.Location = new System.Drawing.Point(400, 572);
            this.pnlEdicion.Name = "pnlEdicion";
            this.pnlEdicion.Size = new System.Drawing.Size(260, 49);
            this.pnlEdicion.TabIndex = 38;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(200, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(53, 38);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(146, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(53, 38);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(73, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(72, 38);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(5, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(67, 38);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Nuevo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pnlProductosGrid
            // 
            this.pnlProductosGrid.Controls.Add(this.btnQuitarProductosGrid);
            this.pnlProductosGrid.Controls.Add(this.btnAgregarProductosGrid);
            this.pnlProductosGrid.Location = new System.Drawing.Point(15, 502);
            this.pnlProductosGrid.Name = "pnlProductosGrid";
            this.pnlProductosGrid.Size = new System.Drawing.Size(94, 49);
            this.pnlProductosGrid.TabIndex = 39;
            this.pnlProductosGrid.Visible = false;
            // 
            // btnQuitarProductosGrid
            // 
            this.btnQuitarProductosGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarProductosGrid.Location = new System.Drawing.Point(52, 4);
            this.btnQuitarProductosGrid.Name = "btnQuitarProductosGrid";
            this.btnQuitarProductosGrid.Size = new System.Drawing.Size(31, 38);
            this.btnQuitarProductosGrid.TabIndex = 1;
            this.btnQuitarProductosGrid.Text = "-";
            this.btnQuitarProductosGrid.UseVisualStyleBackColor = true;
            this.btnQuitarProductosGrid.Click += new System.EventHandler(this.btnQuitarProductosGrid_Click);
            // 
            // btnAgregarProductosGrid
            // 
            this.btnAgregarProductosGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProductosGrid.Location = new System.Drawing.Point(5, 4);
            this.btnAgregarProductosGrid.Name = "btnAgregarProductosGrid";
            this.btnAgregarProductosGrid.Size = new System.Drawing.Size(47, 38);
            this.btnAgregarProductosGrid.TabIndex = 0;
            this.btnAgregarProductosGrid.Text = "+";
            this.btnAgregarProductosGrid.UseVisualStyleBackColor = true;
            this.btnAgregarProductosGrid.Click += new System.EventHandler(this.btnAgregarProductosGrid_Click);
            // 
            // detalle_Pedido_ClientTableAdapter1
            // 
            this.detalle_Pedido_ClientTableAdapter1.ClearBeforeFill = true;
            // 
            // IdDOrdenC
            // 
            this.IdDOrdenC.DataPropertyName = "IdDOrdenC";
            this.IdDOrdenC.HeaderText = "IdDOrdenC";
            this.IdDOrdenC.Name = "IdDOrdenC";
            this.IdDOrdenC.ReadOnly = true;
            this.IdDOrdenC.Visible = false;
            // 
            // IDPedidoC
            // 
            this.IDPedidoC.DataPropertyName = "IDPedidoC";
            this.IDPedidoC.HeaderText = "IDPedidoC";
            this.IDPedidoC.Name = "IDPedidoC";
            this.IDPedidoC.ReadOnly = true;
            this.IDPedidoC.Visible = false;
            // 
            // IdProducto
            // 
            this.IdProducto.DataPropertyName = "IDProducto";
            this.IdProducto.HeaderText = "IDProducto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Visible = false;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "CODIGO";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 80;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 140;
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "cantidad";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.cantidad.DefaultCellStyle = dataGridViewCellStyle1;
            this.cantidad.HeaderText = "CANT";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 60;
            // 
            // precio
            // 
            this.precio.DataPropertyName = "precio";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.precio.DefaultCellStyle = dataGridViewCellStyle2;
            this.precio.HeaderText = "PRECIO";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 80;
            // 
            // precio_orden
            // 
            this.precio_orden.DataPropertyName = "precio_orden";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.precio_orden.DefaultCellStyle = dataGridViewCellStyle3;
            this.precio_orden.HeaderText = "P/E";
            this.precio_orden.Name = "precio_orden";
            this.precio_orden.ReadOnly = true;
            this.precio_orden.Width = 60;
            // 
            // descuento
            // 
            this.descuento.DataPropertyName = "descuento";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.descuento.DefaultCellStyle = dataGridViewCellStyle4;
            this.descuento.HeaderText = "DESC";
            this.descuento.Name = "descuento";
            this.descuento.ReadOnly = true;
            this.descuento.Width = 50;
            // 
            // subtotal
            // 
            this.subtotal.DataPropertyName = "subtotal";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.subtotal.DefaultCellStyle = dataGridViewCellStyle5;
            this.subtotal.HeaderText = "SUB TOTAL";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // Pedido_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(676, 672);
            this.Controls.Add(this.pnlProductosGrid);
            this.Controls.Add(this.pnlEdicion);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlNavegacion);
            this.Controls.Add(this.detallePedidoDataGridView);
            this.Controls.Add(idPedidoClientLabel);
            this.Controls.Add(this.idPedidoClientTextBox);
            this.Controls.Add(id_ClienteLabel);
            this.Controls.Add(this.id_ClienteComboBox);
            this.Controls.Add(id_EmpleadoLabel);
            this.Controls.Add(this.id_EmpleadoComboBox);
            this.Controls.Add(fecha_ordenLabel);
            this.Controls.Add(this.fecha_ordenDateTimePicker);
            this.Controls.Add(fecha_requeridaLabel);
            this.Controls.Add(this.fecha_requeridaDateTimePicker);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pedido_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Pedido_Cliente";
            this.Load += new System.EventHandler(this.Pedido_Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.controlDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedido_ClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallePedidoBindingSource)).EndInit();
            this.pnlNavegacion.ResumeLayout(false);
            this.pnlNavegacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallePedidoDataGridView)).EndInit();
            this.pnlEdicion.ResumeLayout(false);
            this.pnlProductosGrid.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlDataSet controlDataSet;
        private System.Windows.Forms.BindingSource pedido_ClienteBindingSource;
        private ControlDataSetTableAdapters.Pedido_ClienteTableAdapter pedido_ClienteTableAdapter;
        private ControlDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idPedidoClientTextBox;
        private System.Windows.Forms.ComboBox id_ClienteComboBox;
        private System.Windows.Forms.ComboBox id_EmpleadoComboBox;
        private System.Windows.Forms.DateTimePicker fecha_ordenDateTimePicker;
        private System.Windows.Forms.DateTimePicker fecha_requeridaDateTimePicker;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.BindingSource detallePedidoBindingSource;
        private ControlDataSetTableAdapters.DetallePedidoTableAdapter detallePedidoTableAdapter;
        private System.Windows.Forms.Panel pnlNavegacion;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Label lblregistroxden;
        private ControlDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private ControlDataSetTableAdapters.EmpleadoTableAdapter empleadoTableAdapter;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView detallePedidoDataGridView;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Panel pnlEdicion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel pnlProductosGrid;
        private System.Windows.Forms.Button btnQuitarProductosGrid;
        private System.Windows.Forms.Button btnAgregarProductosGrid;
        private ControlDataSetTableAdapters.Detalle_Pedido_ClientTableAdapter detalle_Pedido_ClientTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDOrdenC;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPedidoC;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_orden;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
    }
}