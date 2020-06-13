namespace Primo_y_Fibonacci
{
    partial class Factura_Venta
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
            System.Windows.Forms.Label idFacturaVLabel;
            System.Windows.Forms.Label idClienteLabel;
            System.Windows.Forms.Label idEmpleadoLabel;
            System.Windows.Forms.Label idTipoLabel;
            System.Windows.Forms.Label idPagoLabel;
            System.Windows.Forms.Label nfacturaLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura_Venta));
            this.idFacturaVTextBox = new System.Windows.Forms.TextBox();
            this.factura_ventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controlDataSet = new Primo_y_Fibonacci.ControlDataSet();
            this.idClienteComboBox = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idEmpleadoComboBox = new System.Windows.Forms.ComboBox();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipodocumentoComboBox = new System.Windows.Forms.ComboBox();
            this.tipodocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idPagoComboBox = new System.Windows.Forms.ComboBox();
            this.condicionespagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nfacturaTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dFacturaVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dFacturaVentaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factura_ventaTableAdapter = new Primo_y_Fibonacci.ControlDataSetTableAdapters.factura_ventaTableAdapter();
            this.tableAdapterManager = new Primo_y_Fibonacci.ControlDataSetTableAdapters.TableAdapterManager();
            this.dFacturaVentaTableAdapter = new Primo_y_Fibonacci.ControlDataSetTableAdapters.DFacturaVentaTableAdapter();
            this.clienteTableAdapter = new Primo_y_Fibonacci.ControlDataSetTableAdapters.ClienteTableAdapter();
            this.empleadoTableAdapter = new Primo_y_Fibonacci.ControlDataSetTableAdapters.EmpleadoTableAdapter();
            this.tipo_documentoTableAdapter = new Primo_y_Fibonacci.ControlDataSetTableAdapters.Tipo_documentoTableAdapter();
            this.condiciones_pagosTableAdapter = new Primo_y_Fibonacci.ControlDataSetTableAdapters.condiciones_pagosTableAdapter();
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
            idFacturaVLabel = new System.Windows.Forms.Label();
            idClienteLabel = new System.Windows.Forms.Label();
            idEmpleadoLabel = new System.Windows.Forms.Label();
            idTipoLabel = new System.Windows.Forms.Label();
            idPagoLabel = new System.Windows.Forms.Label();
            nfacturaLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.factura_ventaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipodocumentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.condicionespagosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dFacturaVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dFacturaVentaDataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idFacturaVLabel
            // 
            idFacturaVLabel.AutoSize = true;
            idFacturaVLabel.Location = new System.Drawing.Point(4, 102);
            idFacturaVLabel.Name = "idFacturaVLabel";
            idFacturaVLabel.Size = new System.Drawing.Size(18, 13);
            idFacturaVLabel.TabIndex = 1;
            idFacturaVLabel.Text = "ID";
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.Location = new System.Drawing.Point(111, 102);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(52, 13);
            idClienteLabel.TabIndex = 3;
            idClienteLabel.Text = "CLIENTE";
            // 
            // idEmpleadoLabel
            // 
            idEmpleadoLabel.AutoSize = true;
            idEmpleadoLabel.Location = new System.Drawing.Point(4, 159);
            idEmpleadoLabel.Name = "idEmpleadoLabel";
            idEmpleadoLabel.Size = new System.Drawing.Size(66, 13);
            idEmpleadoLabel.TabIndex = 5;
            idEmpleadoLabel.Text = "EMPLEADO";
            // 
            // idTipoLabel
            // 
            idTipoLabel.AutoSize = true;
            idTipoLabel.Location = new System.Drawing.Point(224, 156);
            idTipoLabel.Name = "idTipoLabel";
            idTipoLabel.Size = new System.Drawing.Size(77, 13);
            idTipoLabel.TabIndex = 7;
            idTipoLabel.Text = "DOCUMENTO";
            // 
            // idPagoLabel
            // 
            idPagoLabel.AutoSize = true;
            idPagoLabel.Location = new System.Drawing.Point(394, 158);
            idPagoLabel.Name = "idPagoLabel";
            idPagoLabel.Size = new System.Drawing.Size(37, 13);
            idPagoLabel.TabIndex = 9;
            idPagoLabel.Text = "PAGO";
            // 
            // nfacturaLabel
            // 
            nfacturaLabel.AutoSize = true;
            nfacturaLabel.Location = new System.Drawing.Point(540, 63);
            nfacturaLabel.Name = "nfacturaLabel";
            nfacturaLabel.Size = new System.Drawing.Size(19, 13);
            nfacturaLabel.TabIndex = 11;
            nfacturaLabel.Text = "N°";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(343, 104);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(74, 13);
            fechaLabel.TabIndex = 13;
            fechaLabel.Text = "FECHA VENT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Forte", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(162, 27);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(307, 38);
            label2.TabIndex = 37;
            label2.Text = "FACTURA VENTAS";
            // 
            // idFacturaVTextBox
            // 
            this.idFacturaVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factura_ventaBindingSource, "IdFacturaV", true));
            this.idFacturaVTextBox.Location = new System.Drawing.Point(28, 98);
            this.idFacturaVTextBox.Name = "idFacturaVTextBox";
            this.idFacturaVTextBox.Size = new System.Drawing.Size(56, 20);
            this.idFacturaVTextBox.TabIndex = 2;
            // 
            // factura_ventaBindingSource
            // 
            this.factura_ventaBindingSource.DataMember = "factura_venta";
            this.factura_ventaBindingSource.DataSource = this.controlDataSet;
            // 
            // controlDataSet
            // 
            this.controlDataSet.DataSetName = "ControlDataSet";
            this.controlDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idClienteComboBox
            // 
            this.idClienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.factura_ventaBindingSource, "IdCliente", true));
            this.idClienteComboBox.DataSource = this.clienteBindingSource;
            this.idClienteComboBox.DisplayMember = "nombre";
            this.idClienteComboBox.FormattingEnabled = true;
            this.idClienteComboBox.Location = new System.Drawing.Point(169, 98);
            this.idClienteComboBox.Name = "idClienteComboBox";
            this.idClienteComboBox.Size = new System.Drawing.Size(151, 21);
            this.idClienteComboBox.TabIndex = 4;
            this.idClienteComboBox.ValueMember = "IdCliente";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.controlDataSet;
            // 
            // idEmpleadoComboBox
            // 
            this.idEmpleadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.factura_ventaBindingSource, "IdEmpleado", true));
            this.idEmpleadoComboBox.DataSource = this.empleadoBindingSource;
            this.idEmpleadoComboBox.DisplayMember = "nombre";
            this.idEmpleadoComboBox.FormattingEnabled = true;
            this.idEmpleadoComboBox.Location = new System.Drawing.Point(76, 153);
            this.idEmpleadoComboBox.Name = "idEmpleadoComboBox";
            this.idEmpleadoComboBox.Size = new System.Drawing.Size(142, 21);
            this.idEmpleadoComboBox.TabIndex = 6;
            this.idEmpleadoComboBox.ValueMember = "IdEmpleado";
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataMember = "Empleado";
            this.empleadoBindingSource.DataSource = this.controlDataSet;
            // 
            // tipodocumentoComboBox
            // 
            this.tipodocumentoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.factura_ventaBindingSource, "IdTipo", true));
            this.tipodocumentoComboBox.DataSource = this.tipodocumentoBindingSource;
            this.tipodocumentoComboBox.DisplayMember = "tipo";
            this.tipodocumentoComboBox.FormattingEnabled = true;
            this.tipodocumentoComboBox.Location = new System.Drawing.Point(307, 153);
            this.tipodocumentoComboBox.Name = "tipodocumentoComboBox";
            this.tipodocumentoComboBox.Size = new System.Drawing.Size(74, 21);
            this.tipodocumentoComboBox.TabIndex = 8;
            this.tipodocumentoComboBox.ValueMember = "IdTipo";
            // 
            // tipodocumentoBindingSource
            // 
            this.tipodocumentoBindingSource.DataMember = "Tipo_documento";
            this.tipodocumentoBindingSource.DataSource = this.controlDataSet;
            // 
            // idPagoComboBox
            // 
            this.idPagoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.factura_ventaBindingSource, "IdPago", true));
            this.idPagoComboBox.DataSource = this.condicionespagosBindingSource;
            this.idPagoComboBox.DisplayMember = "tipo";
            this.idPagoComboBox.FormattingEnabled = true;
            this.idPagoComboBox.Location = new System.Drawing.Point(437, 153);
            this.idPagoComboBox.Name = "idPagoComboBox";
            this.idPagoComboBox.Size = new System.Drawing.Size(74, 21);
            this.idPagoComboBox.TabIndex = 10;
            this.idPagoComboBox.ValueMember = "IdPago";
            // 
            // condicionespagosBindingSource
            // 
            this.condicionespagosBindingSource.DataMember = "condiciones_pagos";
            this.condicionespagosBindingSource.DataSource = this.controlDataSet;
            // 
            // nfacturaTextBox
            // 
            this.nfacturaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factura_ventaBindingSource, "nfactura", true));
            this.nfacturaTextBox.Location = new System.Drawing.Point(565, 60);
            this.nfacturaTextBox.Name = "nfacturaTextBox";
            this.nfacturaTextBox.Size = new System.Drawing.Size(47, 20);
            this.nfacturaTextBox.TabIndex = 12;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.factura_ventaBindingSource, "fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(423, 100);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(199, 20);
            this.fechaDateTimePicker.TabIndex = 14;
            // 
            // dFacturaVentaBindingSource
            // 
            this.dFacturaVentaBindingSource.DataMember = "factura_venta_DFacturaVenta";
            this.dFacturaVentaBindingSource.DataSource = this.factura_ventaBindingSource;
            // 
            // dFacturaVentaDataGridView
            // 
            this.dFacturaVentaDataGridView.AllowUserToAddRows = false;
            this.dFacturaVentaDataGridView.AllowUserToDeleteRows = false;
            this.dFacturaVentaDataGridView.AutoGenerateColumns = false;
            this.dFacturaVentaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dFacturaVentaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.codigo,
            this.nombre,
            this.unidades,
            this.cantidad,
            this.precio,
            this.descuento,
            this.subtotal});
            this.dFacturaVentaDataGridView.DataSource = this.dFacturaVentaBindingSource;
            this.dFacturaVentaDataGridView.Location = new System.Drawing.Point(7, 243);
            this.dFacturaVentaDataGridView.Name = "dFacturaVentaDataGridView";
            this.dFacturaVentaDataGridView.ReadOnly = true;
            this.dFacturaVentaDataGridView.Size = new System.Drawing.Size(635, 195);
            this.dFacturaVentaDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdDFacturaV";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdDFacturaV";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdFacturaV";
            this.dataGridViewTextBoxColumn2.HeaderText = "IdFacturaV";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdVenta";
            this.dataGridViewTextBoxColumn3.HeaderText = "IdVenta";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Idproducto";
            this.dataGridViewTextBoxColumn4.HeaderText = "Idproducto";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "CODIGO";
            this.codigo.Name = "codigo";
            this.codigo.Width = 80;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            this.nombre.Width = 140;
            // 
            // unidades
            // 
            this.unidades.DataPropertyName = "unidades";
            this.unidades.HeaderText = "UNID";
            this.unidades.Name = "unidades";
            this.unidades.Width = 80;
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "cantidad";
            this.cantidad.HeaderText = "CANT";
            this.cantidad.Name = "cantidad";
            this.cantidad.Width = 60;
            // 
            // precio
            // 
            this.precio.DataPropertyName = "precio";
            this.precio.HeaderText = "PRECIO";
            this.precio.Name = "precio";
            this.precio.Width = 80;
            // 
            // descuento
            // 
            this.descuento.DataPropertyName = "descuento";
            this.descuento.HeaderText = "DESC";
            this.descuento.Name = "descuento";
            this.descuento.Width = 50;
            // 
            // subtotal
            // 
            this.subtotal.DataPropertyName = "subtotal";
            this.subtotal.HeaderText = "SUB TOTAL";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // factura_ventaTableAdapter
            // 
            this.factura_ventaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriasTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.Compra_OrdenesTableAdapter = null;
            this.tableAdapterManager.condiciones_pagosTableAdapter = null;
            this.tableAdapterManager.detalle_CompraTableAdapter = null;
            this.tableAdapterManager.Detalle_Pedido_ClientTableAdapter = null;
            this.tableAdapterManager.Detalle_VentaTableAdapter = null;
            this.tableAdapterManager.DFactura_VTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.factura_ventaTableAdapter = this.factura_ventaTableAdapter;
            this.tableAdapterManager.InventarioTableAdapter = null;
            this.tableAdapterManager.Pedido_ClienteTableAdapter = null;
            this.tableAdapterManager.ProductosTableAdapter = null;
            this.tableAdapterManager.ProveedorTableAdapter = null;
            this.tableAdapterManager.Tipo_documentoTableAdapter = null;
            this.tableAdapterManager.Tipo_UsuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Primo_y_Fibonacci.ControlDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            this.tableAdapterManager.VentasTableAdapter = null;
            // 
            // dFacturaVentaTableAdapter
            // 
            this.dFacturaVentaTableAdapter.ClearBeforeFill = true;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // tipo_documentoTableAdapter
            // 
            this.tipo_documentoTableAdapter.ClearBeforeFill = true;
            // 
            // condiciones_pagosTableAdapter
            // 
            this.condiciones_pagosTableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.btnUltimo);
            this.panel3.Controls.Add(this.btnSiguiente);
            this.panel3.Controls.Add(this.btnPrimero);
            this.panel3.Controls.Add(this.btnAnterior);
            this.panel3.Controls.Add(this.lblregistroxden);
            this.panel3.Location = new System.Drawing.Point(28, 511);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(385, 63);
            this.panel3.TabIndex = 39;
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
            this.panel1.Location = new System.Drawing.Point(427, 500);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 92);
            this.panel1.TabIndex = 38;
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
            // Factura_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(676, 672);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(label2);
            this.Controls.Add(this.dFacturaVentaDataGridView);
            this.Controls.Add(idFacturaVLabel);
            this.Controls.Add(this.idFacturaVTextBox);
            this.Controls.Add(idClienteLabel);
            this.Controls.Add(this.idClienteComboBox);
            this.Controls.Add(idEmpleadoLabel);
            this.Controls.Add(this.idEmpleadoComboBox);
            this.Controls.Add(idTipoLabel);
            this.Controls.Add(this.tipodocumentoComboBox);
            this.Controls.Add(idPagoLabel);
            this.Controls.Add(this.idPagoComboBox);
            this.Controls.Add(nfacturaLabel);
            this.Controls.Add(this.nfacturaTextBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Factura_Venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura_Venta";
            this.Load += new System.EventHandler(this.Factura_Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.factura_ventaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipodocumentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.condicionespagosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dFacturaVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dFacturaVentaDataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlDataSet controlDataSet;
        private System.Windows.Forms.BindingSource factura_ventaBindingSource;
        private ControlDataSetTableAdapters.factura_ventaTableAdapter factura_ventaTableAdapter;
        private ControlDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idFacturaVTextBox;
        private System.Windows.Forms.ComboBox idClienteComboBox;
        private System.Windows.Forms.ComboBox idEmpleadoComboBox;
        private System.Windows.Forms.ComboBox tipodocumentoComboBox;
        private System.Windows.Forms.ComboBox idPagoComboBox;
        private System.Windows.Forms.TextBox nfacturaTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.BindingSource dFacturaVentaBindingSource;
        private ControlDataSetTableAdapters.DFacturaVentaTableAdapter dFacturaVentaTableAdapter;
        private System.Windows.Forms.DataGridView dFacturaVentaDataGridView;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private ControlDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private ControlDataSetTableAdapters.EmpleadoTableAdapter empleadoTableAdapter;
        private System.Windows.Forms.BindingSource tipodocumentoBindingSource;
        private ControlDataSetTableAdapters.Tipo_documentoTableAdapter tipo_documentoTableAdapter;
        private System.Windows.Forms.BindingSource condicionespagosBindingSource;
        private ControlDataSetTableAdapters.condiciones_pagosTableAdapter condiciones_pagosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
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
    }
}