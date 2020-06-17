namespace Primo_y_Fibonacci
{
    partial class Factura_Compra
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
            System.Windows.Forms.Label idFacturaCLabel;
            System.Windows.Forms.Label idProveedorLabel;
            System.Windows.Forms.Label idTipoLabel;
            System.Windows.Forms.Label idPagoLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label fechaODCLabel;
            System.Windows.Forms.Label nfacturaLabel;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura_Compra));
            this.controlDataSet = new Primo_y_Fibonacci.ControlDataSet();
            this.factura_compraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.factura_compraTableAdapter = new Primo_y_Fibonacci.ControlDataSetTableAdapters.factura_compraTableAdapter();
            this.tableAdapterManager = new Primo_y_Fibonacci.ControlDataSetTableAdapters.TableAdapterManager();
            this.idFacturaCTextBox = new System.Windows.Forms.TextBox();
            this.idProveedorComboBox = new System.Windows.Forms.ComboBox();
            this.tipoventaComboBox = new System.Windows.Forms.ComboBox();
            this.idPagoComboBox = new System.Windows.Forms.ComboBox();
            this.fechafacturaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaODCDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nfacturaTextBox = new System.Windows.Forms.TextBox();
            this.dFacturaCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dFacturaCompraTableAdapter = new Primo_y_Fibonacci.ControlDataSetTableAdapters.DFacturaCompraTableAdapter();
            this.dFacturaCompraDataGridView = new System.Windows.Forms.DataGridView();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedorTableAdapter = new Primo_y_Fibonacci.ControlDataSetTableAdapters.ProveedorTableAdapter();
            this.tipodocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipo_documentoTableAdapter = new Primo_y_Fibonacci.ControlDataSetTableAdapters.Tipo_documentoTableAdapter();
            this.condicionespagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.condiciones_pagosTableAdapter = new Primo_y_Fibonacci.ControlDataSetTableAdapters.condiciones_pagosTableAdapter();
            this.btnsalir = new System.Windows.Forms.Button();
            this.pnlProductosGrid = new System.Windows.Forms.Panel();
            this.btnQuitarProductosGrid = new System.Windows.Forms.Button();
            this.btnAgregarProductosGrid = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalCompra = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIvaCompra = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSumaCompra = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlNavegacion = new System.Windows.Forms.Panel();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.lblregistroxden = new System.Windows.Forms.Label();
            this.pnlEdicion = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dfactura_CTableAdapter1 = new Primo_y_Fibonacci.ControlDataSetTableAdapters.Dfactura_CTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdFacturaC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_envio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idFacturaCLabel = new System.Windows.Forms.Label();
            idProveedorLabel = new System.Windows.Forms.Label();
            idTipoLabel = new System.Windows.Forms.Label();
            idPagoLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            fechaODCLabel = new System.Windows.Forms.Label();
            nfacturaLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.controlDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factura_compraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dFacturaCompraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dFacturaCompraDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipodocumentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.condicionespagosBindingSource)).BeginInit();
            this.pnlProductosGrid.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlNavegacion.SuspendLayout();
            this.pnlEdicion.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlDataSet
            // 
            this.controlDataSet.DataSetName = "ControlDataSet";
            this.controlDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // factura_compraBindingSource
            // 
            this.factura_compraBindingSource.DataMember = "factura_compra";
            this.factura_compraBindingSource.DataSource = this.controlDataSet;
            // 
            // factura_compraTableAdapter
            // 
            this.factura_compraTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriasTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.Compra_OrdenesTableAdapter = null;
            this.tableAdapterManager.condiciones_pagosTableAdapter = this.condiciones_pagosTableAdapter;
            this.tableAdapterManager.detalle_CompraTableAdapter = null;
            this.tableAdapterManager.Detalle_Pedido_ClientTableAdapter = null;
            this.tableAdapterManager.Detalle_VentaTableAdapter = null;
            this.tableAdapterManager.Dfactura_CTableAdapter = this.dfactura_CTableAdapter1;
            this.tableAdapterManager.DFactura_VTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.factura_compraTableAdapter = this.factura_compraTableAdapter;
            this.tableAdapterManager.factura_ventaTableAdapter = null;
            this.tableAdapterManager.InventarioTableAdapter = null;
            this.tableAdapterManager.Pedido_ClienteTableAdapter = null;
            this.tableAdapterManager.ProductosTableAdapter = null;
            this.tableAdapterManager.ProveedorTableAdapter = this.proveedorTableAdapter;
            this.tableAdapterManager.Tipo_documentoTableAdapter = this.tipo_documentoTableAdapter;
            this.tableAdapterManager.Tipo_UsuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Primo_y_Fibonacci.ControlDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            this.tableAdapterManager.VentasTableAdapter = null;
            // 
            // idFacturaCLabel
            // 
            idFacturaCLabel.AutoSize = true;
            idFacturaCLabel.Location = new System.Drawing.Point(273, 172);
            idFacturaCLabel.Name = "idFacturaCLabel";
            idFacturaCLabel.Size = new System.Drawing.Size(68, 13);
            idFacturaCLabel.TabIndex = 1;
            idFacturaCLabel.Text = "Id Factura C:";
            // 
            // idFacturaCTextBox
            // 
            this.idFacturaCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factura_compraBindingSource, "IdFacturaC", true));
            this.idFacturaCTextBox.Location = new System.Drawing.Point(346, 169);
            this.idFacturaCTextBox.Name = "idFacturaCTextBox";
            this.idFacturaCTextBox.ReadOnly = true;
            this.idFacturaCTextBox.Size = new System.Drawing.Size(61, 20);
            this.idFacturaCTextBox.TabIndex = 2;
            // 
            // idProveedorLabel
            // 
            idProveedorLabel.AutoSize = true;
            idProveedorLabel.Location = new System.Drawing.Point(20, 172);
            idProveedorLabel.Name = "idProveedorLabel";
            idProveedorLabel.Size = new System.Drawing.Size(71, 13);
            idProveedorLabel.TabIndex = 3;
            idProveedorLabel.Text = "Id Proveedor:";
            // 
            // idProveedorComboBox
            // 
            this.idProveedorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.factura_compraBindingSource, "IdProveedor", true));
            this.idProveedorComboBox.DataSource = this.proveedorBindingSource;
            this.idProveedorComboBox.DisplayMember = "nombre";
            this.idProveedorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idProveedorComboBox.Enabled = false;
            this.idProveedorComboBox.FormattingEnabled = true;
            this.idProveedorComboBox.Location = new System.Drawing.Point(97, 169);
            this.idProveedorComboBox.Name = "idProveedorComboBox";
            this.idProveedorComboBox.Size = new System.Drawing.Size(157, 21);
            this.idProveedorComboBox.TabIndex = 4;
            this.idProveedorComboBox.ValueMember = "IdProveedor";
            // 
            // idTipoLabel
            // 
            idTipoLabel.AutoSize = true;
            idTipoLabel.Location = new System.Drawing.Point(333, 230);
            idTipoLabel.Name = "idTipoLabel";
            idTipoLabel.Size = new System.Drawing.Size(43, 13);
            idTipoLabel.TabIndex = 5;
            idTipoLabel.Text = "Id Tipo:";
            // 
            // tipoventaComboBox
            // 
            this.tipoventaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.factura_compraBindingSource, "IdTipo", true));
            this.tipoventaComboBox.DataSource = this.tipodocumentoBindingSource;
            this.tipoventaComboBox.DisplayMember = "tipo";
            this.tipoventaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoventaComboBox.Enabled = false;
            this.tipoventaComboBox.FormattingEnabled = true;
            this.tipoventaComboBox.Location = new System.Drawing.Point(390, 227);
            this.tipoventaComboBox.Name = "tipoventaComboBox";
            this.tipoventaComboBox.Size = new System.Drawing.Size(71, 21);
            this.tipoventaComboBox.TabIndex = 6;
            this.tipoventaComboBox.ValueMember = "IdTipo";
            // 
            // idPagoLabel
            // 
            idPagoLabel.AutoSize = true;
            idPagoLabel.Location = new System.Drawing.Point(518, 230);
            idPagoLabel.Name = "idPagoLabel";
            idPagoLabel.Size = new System.Drawing.Size(47, 13);
            idPagoLabel.TabIndex = 7;
            idPagoLabel.Text = "Id Pago:";
            // 
            // idPagoComboBox
            // 
            this.idPagoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.factura_compraBindingSource, "IdPago", true));
            this.idPagoComboBox.DataSource = this.condicionespagosBindingSource;
            this.idPagoComboBox.DisplayMember = "tipo";
            this.idPagoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idPagoComboBox.Enabled = false;
            this.idPagoComboBox.FormattingEnabled = true;
            this.idPagoComboBox.Location = new System.Drawing.Point(575, 227);
            this.idPagoComboBox.Name = "idPagoComboBox";
            this.idPagoComboBox.Size = new System.Drawing.Size(71, 21);
            this.idPagoComboBox.TabIndex = 8;
            this.idPagoComboBox.ValueMember = "IdPago";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(424, 175);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(37, 13);
            fechaLabel.TabIndex = 9;
            fechaLabel.Text = "fecha:";
            // 
            // fechafacturaDateTimePicker
            // 
            this.fechafacturaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.factura_compraBindingSource, "fecha", true));
            this.fechafacturaDateTimePicker.Enabled = false;
            this.fechafacturaDateTimePicker.Location = new System.Drawing.Point(467, 169);
            this.fechafacturaDateTimePicker.Name = "fechafacturaDateTimePicker";
            this.fechafacturaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechafacturaDateTimePicker.TabIndex = 10;
            // 
            // fechaODCLabel
            // 
            fechaODCLabel.AutoSize = true;
            fechaODCLabel.Location = new System.Drawing.Point(20, 232);
            fechaODCLabel.Name = "fechaODCLabel";
            fechaODCLabel.Size = new System.Drawing.Size(63, 13);
            fechaODCLabel.TabIndex = 11;
            fechaODCLabel.Text = "fecha ODC:";
            // 
            // fechaODCDateTimePicker
            // 
            this.fechaODCDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.factura_compraBindingSource, "fechaODC", true));
            this.fechaODCDateTimePicker.Enabled = false;
            this.fechaODCDateTimePicker.Location = new System.Drawing.Point(97, 226);
            this.fechaODCDateTimePicker.Name = "fechaODCDateTimePicker";
            this.fechaODCDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaODCDateTimePicker.TabIndex = 12;
            // 
            // nfacturaLabel
            // 
            nfacturaLabel.AutoSize = true;
            nfacturaLabel.Location = new System.Drawing.Point(468, 121);
            nfacturaLabel.Name = "nfacturaLabel";
            nfacturaLabel.Size = new System.Drawing.Size(49, 13);
            nfacturaLabel.TabIndex = 13;
            nfacturaLabel.Text = "nfactura:";
            // 
            // nfacturaTextBox
            // 
            this.nfacturaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factura_compraBindingSource, "nfactura", true));
            this.nfacturaTextBox.Location = new System.Drawing.Point(531, 118);
            this.nfacturaTextBox.Name = "nfacturaTextBox";
            this.nfacturaTextBox.ReadOnly = true;
            this.nfacturaTextBox.Size = new System.Drawing.Size(57, 20);
            this.nfacturaTextBox.TabIndex = 14;
            // 
            // dFacturaCompraBindingSource
            // 
            this.dFacturaCompraBindingSource.DataMember = "FK_Dfactura_C_factura_compra1";
            this.dFacturaCompraBindingSource.DataSource = this.factura_compraBindingSource;
            // 
            // dFacturaCompraTableAdapter
            // 
            this.dFacturaCompraTableAdapter.ClearBeforeFill = true;
            // 
            // dFacturaCompraDataGridView
            // 
            this.dFacturaCompraDataGridView.AllowUserToAddRows = false;
            this.dFacturaCompraDataGridView.AllowUserToDeleteRows = false;
            this.dFacturaCompraDataGridView.AutoGenerateColumns = false;
            this.dFacturaCompraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dFacturaCompraDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.IdFacturaC,
            this.IdProducto,
            this.codigo,
            this.nombre,
            this.cantidad,
            this.precio,
            this.descuento,
            this.precio_envio,
            this.subtotal});
            this.dFacturaCompraDataGridView.DataSource = this.dFacturaCompraBindingSource;
            this.dFacturaCompraDataGridView.Location = new System.Drawing.Point(-1, 327);
            this.dFacturaCompraDataGridView.Name = "dFacturaCompraDataGridView";
            this.dFacturaCompraDataGridView.ReadOnly = true;
            this.dFacturaCompraDataGridView.Size = new System.Drawing.Size(689, 164);
            this.dFacturaCompraDataGridView.TabIndex = 15;
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataMember = "Proveedor";
            this.proveedorBindingSource.DataSource = this.controlDataSet;
            // 
            // proveedorTableAdapter
            // 
            this.proveedorTableAdapter.ClearBeforeFill = true;
            // 
            // tipodocumentoBindingSource
            // 
            this.tipodocumentoBindingSource.DataMember = "Tipo_documento";
            this.tipodocumentoBindingSource.DataSource = this.controlDataSet;
            // 
            // tipo_documentoTableAdapter
            // 
            this.tipo_documentoTableAdapter.ClearBeforeFill = true;
            // 
            // condicionespagosBindingSource
            // 
            this.condicionespagosBindingSource.DataMember = "condiciones_pagos";
            this.condicionespagosBindingSource.DataSource = this.controlDataSet;
            // 
            // condiciones_pagosTableAdapter
            // 
            this.condiciones_pagosTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Forte", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(132, 52);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(329, 38);
            label2.TabIndex = 36;
            label2.Text = "FACTURA COMPRA";
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Transparent;
            this.btnsalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsalir.BackgroundImage")));
            this.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsalir.Location = new System.Drawing.Point(653, 3);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(37, 37);
            this.btnsalir.TabIndex = 35;
            this.btnsalir.UseVisualStyleBackColor = false;
            // 
            // pnlProductosGrid
            // 
            this.pnlProductosGrid.Controls.Add(this.btnQuitarProductosGrid);
            this.pnlProductosGrid.Controls.Add(this.btnAgregarProductosGrid);
            this.pnlProductosGrid.Location = new System.Drawing.Point(17, 506);
            this.pnlProductosGrid.Name = "pnlProductosGrid";
            this.pnlProductosGrid.Size = new System.Drawing.Size(94, 49);
            this.pnlProductosGrid.TabIndex = 46;
            this.pnlProductosGrid.Visible = false;
            // 
            // btnQuitarProductosGrid
            // 
            this.btnQuitarProductosGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarProductosGrid.Location = new System.Drawing.Point(58, 4);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.lblTotalCompra);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblIvaCompra);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblSumaCompra);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(463, 555);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 86);
            this.panel1.TabIndex = 45;
            // 
            // lblTotalCompra
            // 
            this.lblTotalCompra.AutoSize = true;
            this.lblTotalCompra.Location = new System.Drawing.Point(142, 61);
            this.lblTotalCompra.Name = "lblTotalCompra";
            this.lblTotalCompra.Size = new System.Drawing.Size(46, 13);
            this.lblTotalCompra.TabIndex = 5;
            this.lblTotalCompra.Text = "0000.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "TOTAL:";
            // 
            // lblIvaCompra
            // 
            this.lblIvaCompra.AutoSize = true;
            this.lblIvaCompra.Location = new System.Drawing.Point(142, 36);
            this.lblIvaCompra.Name = "lblIvaCompra";
            this.lblIvaCompra.Size = new System.Drawing.Size(34, 13);
            this.lblIvaCompra.TabIndex = 3;
            this.lblIvaCompra.Text = "00.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "IVA:";
            // 
            // lblSumaCompra
            // 
            this.lblSumaCompra.AutoSize = true;
            this.lblSumaCompra.Location = new System.Drawing.Point(142, 12);
            this.lblSumaCompra.Name = "lblSumaCompra";
            this.lblSumaCompra.Size = new System.Drawing.Size(46, 13);
            this.lblSumaCompra.TabIndex = 1;
            this.lblSumaCompra.Text = "0000.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "SUMA:";
            // 
            // pnlNavegacion
            // 
            this.pnlNavegacion.BackColor = System.Drawing.Color.Silver;
            this.pnlNavegacion.Controls.Add(this.btnUltimo);
            this.pnlNavegacion.Controls.Add(this.btnSiguiente);
            this.pnlNavegacion.Controls.Add(this.btnPrimero);
            this.pnlNavegacion.Controls.Add(this.btnAnterior);
            this.pnlNavegacion.Controls.Add(this.lblregistroxden);
            this.pnlNavegacion.Location = new System.Drawing.Point(17, 578);
            this.pnlNavegacion.Name = "pnlNavegacion";
            this.pnlNavegacion.Size = new System.Drawing.Size(385, 63);
            this.pnlNavegacion.TabIndex = 44;
            // 
            // btnUltimo
            // 
            this.btnUltimo.BackColor = System.Drawing.Color.Blue;
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
            this.btnSiguiente.BackColor = System.Drawing.Color.Blue;
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
            this.btnPrimero.BackColor = System.Drawing.Color.Blue;
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
            this.btnAnterior.BackColor = System.Drawing.Color.Blue;
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
            // pnlEdicion
            // 
            this.pnlEdicion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlEdicion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEdicion.Controls.Add(this.btnBuscar);
            this.pnlEdicion.Controls.Add(this.btnAgregar);
            this.pnlEdicion.Controls.Add(this.btnModificar);
            this.pnlEdicion.Controls.Add(this.btnEliminar);
            this.pnlEdicion.Location = new System.Drawing.Point(23, 275);
            this.pnlEdicion.Name = "pnlEdicion";
            this.pnlEdicion.Size = new System.Drawing.Size(654, 33);
            this.pnlEdicion.TabIndex = 47;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(478, 0);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(67, 33);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(53, 0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(67, 33);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Nuevo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(202, 0);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(67, 33);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(338, 0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(67, 33);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dfactura_CTableAdapter1
            // 
            this.dfactura_CTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdDFacturaC";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdDFacturaC";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // IdFacturaC
            // 
            this.IdFacturaC.DataPropertyName = "IdFacturaC";
            this.IdFacturaC.HeaderText = "IdFacturaC";
            this.IdFacturaC.Name = "IdFacturaC";
            this.IdFacturaC.ReadOnly = true;
            this.IdFacturaC.Visible = false;
            // 
            // IdProducto
            // 
            this.IdProducto.DataPropertyName = "IdProducto";
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Visible = false;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "cantidad";
            this.cantidad.HeaderText = "cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.DataPropertyName = "precio";
            this.precio.HeaderText = "precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // descuento
            // 
            this.descuento.DataPropertyName = "descuento";
            this.descuento.HeaderText = "descuento";
            this.descuento.Name = "descuento";
            this.descuento.ReadOnly = true;
            // 
            // precio_envio
            // 
            this.precio_envio.DataPropertyName = "precio_envio";
            this.precio_envio.HeaderText = "precio_envio";
            this.precio_envio.Name = "precio_envio";
            this.precio_envio.ReadOnly = true;
            // 
            // subtotal
            // 
            this.subtotal.DataPropertyName = "subtotal";
            this.subtotal.HeaderText = "subtotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // Factura_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 699);
            this.Controls.Add(this.pnlEdicion);
            this.Controls.Add(this.pnlProductosGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlNavegacion);
            this.Controls.Add(label2);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.dFacturaCompraDataGridView);
            this.Controls.Add(idFacturaCLabel);
            this.Controls.Add(this.idFacturaCTextBox);
            this.Controls.Add(idProveedorLabel);
            this.Controls.Add(this.idProveedorComboBox);
            this.Controls.Add(idTipoLabel);
            this.Controls.Add(this.tipoventaComboBox);
            this.Controls.Add(idPagoLabel);
            this.Controls.Add(this.idPagoComboBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechafacturaDateTimePicker);
            this.Controls.Add(fechaODCLabel);
            this.Controls.Add(this.fechaODCDateTimePicker);
            this.Controls.Add(nfacturaLabel);
            this.Controls.Add(this.nfacturaTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Factura_Compra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura_Compra";
            this.Load += new System.EventHandler(this.Factura_Compra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.controlDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factura_compraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dFacturaCompraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dFacturaCompraDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipodocumentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.condicionespagosBindingSource)).EndInit();
            this.pnlProductosGrid.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlNavegacion.ResumeLayout(false);
            this.pnlNavegacion.PerformLayout();
            this.pnlEdicion.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlDataSet controlDataSet;
        private System.Windows.Forms.BindingSource factura_compraBindingSource;
        private ControlDataSetTableAdapters.factura_compraTableAdapter factura_compraTableAdapter;
        private ControlDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idFacturaCTextBox;
        private System.Windows.Forms.ComboBox idProveedorComboBox;
        private System.Windows.Forms.ComboBox tipoventaComboBox;
        private System.Windows.Forms.ComboBox idPagoComboBox;
        private System.Windows.Forms.DateTimePicker fechafacturaDateTimePicker;
        private System.Windows.Forms.DateTimePicker fechaODCDateTimePicker;
        private System.Windows.Forms.TextBox nfacturaTextBox;
        private System.Windows.Forms.BindingSource dFacturaCompraBindingSource;
        private ControlDataSetTableAdapters.DFacturaCompraTableAdapter dFacturaCompraTableAdapter;
        private System.Windows.Forms.DataGridView dFacturaCompraDataGridView;
        private ControlDataSetTableAdapters.ProveedorTableAdapter proveedorTableAdapter;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private ControlDataSetTableAdapters.Tipo_documentoTableAdapter tipo_documentoTableAdapter;
        private System.Windows.Forms.BindingSource tipodocumentoBindingSource;
        private ControlDataSetTableAdapters.condiciones_pagosTableAdapter condiciones_pagosTableAdapter;
        private System.Windows.Forms.BindingSource condicionespagosBindingSource;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Panel pnlProductosGrid;
        private System.Windows.Forms.Button btnQuitarProductosGrid;
        private System.Windows.Forms.Button btnAgregarProductosGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalCompra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblIvaCompra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSumaCompra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlNavegacion;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Label lblregistroxden;
        private System.Windows.Forms.Panel pnlEdicion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private ControlDataSetTableAdapters.Dfactura_CTableAdapter dfactura_CTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFacturaC;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_envio;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
    }
}