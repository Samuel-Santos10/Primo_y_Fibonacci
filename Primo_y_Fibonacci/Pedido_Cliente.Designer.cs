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
            System.Windows.Forms.Label id_PagoLabel;
            System.Windows.Forms.Label id_TipoLabel;
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
            this.condiciones_pagosTableAdapter = new Primo_y_Fibonacci.ControlDataSetTableAdapters.condiciones_pagosTableAdapter();
            this.empleadoTableAdapter = new Primo_y_Fibonacci.ControlDataSetTableAdapters.EmpleadoTableAdapter();
            this.tipo_documentoTableAdapter = new Primo_y_Fibonacci.ControlDataSetTableAdapters.Tipo_documentoTableAdapter();
            this.idPedidoClientTextBox = new System.Windows.Forms.TextBox();
            this.id_ClienteComboBox = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id_EmpleadoComboBox = new System.Windows.Forms.ComboBox();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id_PagoComboBox = new System.Windows.Forms.ComboBox();
            this.condicionespagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipodocumentoComboBox = new System.Windows.Forms.ComboBox();
            this.tipodocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fecha_ordenDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fecha_requeridaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.detallePedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detallePedidoTableAdapter = new Primo_y_Fibonacci.ControlDataSetTableAdapters.DetallePedidoTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.lblregistroxden = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalVenta = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIvaVenta = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSumaVenta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.detallePedidoDataGridView = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnsalir = new System.Windows.Forms.Button();
            idPedidoClientLabel = new System.Windows.Forms.Label();
            id_ClienteLabel = new System.Windows.Forms.Label();
            id_EmpleadoLabel = new System.Windows.Forms.Label();
            id_PagoLabel = new System.Windows.Forms.Label();
            id_TipoLabel = new System.Windows.Forms.Label();
            fecha_ordenLabel = new System.Windows.Forms.Label();
            fecha_requeridaLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.controlDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedido_ClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.condicionespagosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipodocumentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallePedidoBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallePedidoDataGridView)).BeginInit();
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
            // id_PagoLabel
            // 
            id_PagoLabel.AutoSize = true;
            id_PagoLabel.Location = new System.Drawing.Point(92, 272);
            id_PagoLabel.Name = "id_PagoLabel";
            id_PagoLabel.Size = new System.Drawing.Size(37, 13);
            id_PagoLabel.TabIndex = 7;
            id_PagoLabel.Text = "PAGO";
            // 
            // id_TipoLabel
            // 
            id_TipoLabel.AutoSize = true;
            id_TipoLabel.Location = new System.Drawing.Point(263, 273);
            id_TipoLabel.Name = "id_TipoLabel";
            id_TipoLabel.Size = new System.Drawing.Size(77, 13);
            id_TipoLabel.TabIndex = 9;
            id_TipoLabel.Text = "DOCUMENTO";
            // 
            // fecha_ordenLabel
            // 
            fecha_ordenLabel.AutoSize = true;
            fecha_ordenLabel.Location = new System.Drawing.Point(12, 230);
            fecha_ordenLabel.Name = "fecha_ordenLabel";
            fecha_ordenLabel.Size = new System.Drawing.Size(86, 13);
            fecha_ordenLabel.TabIndex = 11;
            fecha_ordenLabel.Text = "FECHA PEDIDO";
            // 
            // fecha_requeridaLabel
            // 
            fecha_requeridaLabel.AutoSize = true;
            fecha_requeridaLabel.Location = new System.Drawing.Point(311, 232);
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
            this.tableAdapterManager.condiciones_pagosTableAdapter = this.condiciones_pagosTableAdapter;
            this.tableAdapterManager.detalle_CompraTableAdapter = null;
            this.tableAdapterManager.Detalle_Pedido_ClientTableAdapter = null;
            this.tableAdapterManager.Detalle_VentaTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = this.empleadoTableAdapter;
            this.tableAdapterManager.InventarioTableAdapter = null;
            this.tableAdapterManager.Pedido_ClienteTableAdapter = this.pedido_ClienteTableAdapter;
            this.tableAdapterManager.ProductosTableAdapter = null;
            this.tableAdapterManager.ProveedorTableAdapter = null;
            this.tableAdapterManager.Tipo_documentoTableAdapter = this.tipo_documentoTableAdapter;
            this.tableAdapterManager.Tipo_UsuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Primo_y_Fibonacci.ControlDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            this.tableAdapterManager.VentasTableAdapter = null;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // condiciones_pagosTableAdapter
            // 
            this.condiciones_pagosTableAdapter.ClearBeforeFill = true;
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // tipo_documentoTableAdapter
            // 
            this.tipo_documentoTableAdapter.ClearBeforeFill = true;
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
            // id_PagoComboBox
            // 
            this.id_PagoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pedido_ClienteBindingSource, "Id_Pago", true));
            this.id_PagoComboBox.DataSource = this.condicionespagosBindingSource;
            this.id_PagoComboBox.DisplayMember = "tipo";
            this.id_PagoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_PagoComboBox.Enabled = false;
            this.id_PagoComboBox.FormattingEnabled = true;
            this.id_PagoComboBox.Location = new System.Drawing.Point(143, 268);
            this.id_PagoComboBox.Name = "id_PagoComboBox";
            this.id_PagoComboBox.Size = new System.Drawing.Size(75, 21);
            this.id_PagoComboBox.TabIndex = 8;
            this.id_PagoComboBox.ValueMember = "IdPago";
            // 
            // condicionespagosBindingSource
            // 
            this.condicionespagosBindingSource.DataMember = "condiciones_pagos";
            this.condicionespagosBindingSource.DataSource = this.controlDataSet;
            // 
            // tipodocumentoComboBox
            // 
            this.tipodocumentoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pedido_ClienteBindingSource, "Id_Tipo", true));
            this.tipodocumentoComboBox.DataSource = this.tipodocumentoBindingSource;
            this.tipodocumentoComboBox.DisplayMember = "tipo";
            this.tipodocumentoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipodocumentoComboBox.Enabled = false;
            this.tipodocumentoComboBox.FormattingEnabled = true;
            this.tipodocumentoComboBox.Location = new System.Drawing.Point(346, 268);
            this.tipodocumentoComboBox.Name = "tipodocumentoComboBox";
            this.tipodocumentoComboBox.Size = new System.Drawing.Size(75, 21);
            this.tipodocumentoComboBox.TabIndex = 10;
            this.tipodocumentoComboBox.ValueMember = "IdTipo";
            // 
            // tipodocumentoBindingSource
            // 
            this.tipodocumentoBindingSource.DataMember = "Tipo_documento";
            this.tipodocumentoBindingSource.DataSource = this.controlDataSet;
            // 
            // fecha_ordenDateTimePicker
            // 
            this.fecha_ordenDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pedido_ClienteBindingSource, "fecha_orden", true));
            this.fecha_ordenDateTimePicker.Enabled = false;
            this.fecha_ordenDateTimePicker.Location = new System.Drawing.Point(101, 227);
            this.fecha_ordenDateTimePicker.Name = "fecha_ordenDateTimePicker";
            this.fecha_ordenDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_ordenDateTimePicker.TabIndex = 12;
            // 
            // fecha_requeridaDateTimePicker
            // 
            this.fecha_requeridaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pedido_ClienteBindingSource, "fecha_requerida", true));
            this.fecha_requeridaDateTimePicker.Enabled = false;
            this.fecha_requeridaDateTimePicker.Location = new System.Drawing.Point(424, 228);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.btnUltimo);
            this.panel3.Controls.Add(this.btnSiguiente);
            this.panel3.Controls.Add(this.btnPrimero);
            this.panel3.Controls.Add(this.btnAnterior);
            this.panel3.Controls.Add(this.lblregistroxden);
            this.panel3.Location = new System.Drawing.Point(9, 540);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(385, 63);
            this.panel3.TabIndex = 34;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.lblTotalVenta);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblIvaVenta);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblSumaVenta);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(408, 529);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 92);
            this.panel1.TabIndex = 33;
            // 
            // lblTotalVenta
            // 
            this.lblTotalVenta.AutoSize = true;
            this.lblTotalVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVenta.Location = new System.Drawing.Point(133, 61);
            this.lblTotalVenta.Name = "lblTotalVenta";
            this.lblTotalVenta.Size = new System.Drawing.Size(59, 15);
            this.lblTotalVenta.TabIndex = 5;
            this.lblTotalVenta.Text = "0000.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "TOTAL:";
            // 
            // lblIvaVenta
            // 
            this.lblIvaVenta.AutoSize = true;
            this.lblIvaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIvaVenta.Location = new System.Drawing.Point(133, 36);
            this.lblIvaVenta.Name = "lblIvaVenta";
            this.lblIvaVenta.Size = new System.Drawing.Size(43, 15);
            this.lblIvaVenta.TabIndex = 3;
            this.lblIvaVenta.Text = "00.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "IVA:";
            // 
            // lblSumaVenta
            // 
            this.lblSumaVenta.AutoSize = true;
            this.lblSumaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumaVenta.Location = new System.Drawing.Point(133, 12);
            this.lblSumaVenta.Name = "lblSumaVenta";
            this.lblSumaVenta.Size = new System.Drawing.Size(59, 15);
            this.lblSumaVenta.TabIndex = 1;
            this.lblSumaVenta.Text = "0000.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "SUMA:";
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
            this.codigo,
            this.nombre,
            this.precioOrden,
            this.cantidad,
            this.precio,
            this.descuento,
            this.subtotal,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.detallePedidoDataGridView.DataSource = this.detallePedidoBindingSource;
            this.detallePedidoDataGridView.Location = new System.Drawing.Point(6, 330);
            this.detallePedidoDataGridView.Name = "detallePedidoDataGridView";
            this.detallePedidoDataGridView.ReadOnly = true;
            this.detallePedidoDataGridView.Size = new System.Drawing.Size(614, 166);
            this.detallePedidoDataGridView.TabIndex = 17;
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
            // precioOrden
            // 
            this.precioOrden.DataPropertyName = "precio_orden";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.precioOrden.DefaultCellStyle = dataGridViewCellStyle1;
            this.precioOrden.HeaderText = "P/E";
            this.precioOrden.Name = "precioOrden";
            this.precioOrden.ReadOnly = true;
            this.precioOrden.Width = 60;
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "cantidad";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.cantidad.DefaultCellStyle = dataGridViewCellStyle2;
            this.cantidad.HeaderText = "CANT";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 60;
            // 
            // precio
            // 
            this.precio.DataPropertyName = "precio";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.precio.DefaultCellStyle = dataGridViewCellStyle3;
            this.precio.HeaderText = "PRECIO";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 80;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdDOrdenC";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdDOrdenC";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IDPedidoC";
            this.dataGridViewTextBoxColumn2.HeaderText = "IDPedidoC";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IDDVenta";
            this.dataGridViewTextBoxColumn3.HeaderText = "IDDVenta";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IDVenta";
            this.dataGridViewTextBoxColumn4.HeaderText = "IDVenta";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "IDProducto";
            this.dataGridViewTextBoxColumn5.HeaderText = "IDProducto";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
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
            // Pedido_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(625, 636);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.detallePedidoDataGridView);
            this.Controls.Add(idPedidoClientLabel);
            this.Controls.Add(this.idPedidoClientTextBox);
            this.Controls.Add(id_ClienteLabel);
            this.Controls.Add(this.id_ClienteComboBox);
            this.Controls.Add(id_EmpleadoLabel);
            this.Controls.Add(this.id_EmpleadoComboBox);
            this.Controls.Add(id_PagoLabel);
            this.Controls.Add(this.id_PagoComboBox);
            this.Controls.Add(id_TipoLabel);
            this.Controls.Add(this.tipodocumentoComboBox);
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
            ((System.ComponentModel.ISupportInitialize)(this.condicionespagosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipodocumentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallePedidoBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallePedidoDataGridView)).EndInit();
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
        private System.Windows.Forms.ComboBox id_PagoComboBox;
        private System.Windows.Forms.ComboBox tipodocumentoComboBox;
        private System.Windows.Forms.DateTimePicker fecha_ordenDateTimePicker;
        private System.Windows.Forms.DateTimePicker fecha_requeridaDateTimePicker;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.BindingSource detallePedidoBindingSource;
        private ControlDataSetTableAdapters.DetallePedidoTableAdapter detallePedidoTableAdapter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Label lblregistroxden;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalVenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblIvaVenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSumaVenta;
        private System.Windows.Forms.Label label1;
        private ControlDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private ControlDataSetTableAdapters.EmpleadoTableAdapter empleadoTableAdapter;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private ControlDataSetTableAdapters.condiciones_pagosTableAdapter condiciones_pagosTableAdapter;
        private System.Windows.Forms.BindingSource condicionespagosBindingSource;
        private ControlDataSetTableAdapters.Tipo_documentoTableAdapter tipo_documentoTableAdapter;
        private System.Windows.Forms.BindingSource tipodocumentoBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView detallePedidoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnsalir;
    }
}