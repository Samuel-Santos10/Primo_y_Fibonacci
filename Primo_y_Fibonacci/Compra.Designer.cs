namespace Primo_y_Fibonacci
{
    partial class Compra
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
            System.Windows.Forms.Label idCompraLabel;
            System.Windows.Forms.Label id_ProveedorLabel;
            System.Windows.Forms.Label fechaaLabel;
            System.Windows.Forms.Label nfacturaLabel;
            System.Windows.Forms.Label iD_PagoLabel;
            System.Windows.Forms.Label iD_TipoLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compra));
            this.proveedorTableAdapter = new Primo_y_Fibonacci.ControlDataSetTableAdapters.ProveedorTableAdapter();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalleCompraBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.controlDataSet = new Primo_y_Fibonacci.ControlDataSet();
            this.compra_OrdenesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compra_OrdenesTableAdapter = new Primo_y_Fibonacci.ControlDataSetTableAdapters.Compra_OrdenesTableAdapter();
            this.tableAdapterManager = new Primo_y_Fibonacci.ControlDataSetTableAdapters.TableAdapterManager();
            this.detalleCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalleCompraTableAdapter = new Primo_y_Fibonacci.ControlDataSetTableAdapters.DetalleCompraTableAdapter();
            this.detalleCompraDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCompraTextBox = new System.Windows.Forms.TextBox();
            this.id_ProveedorComboBox = new System.Windows.Forms.ComboBox();
            this.proveedorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fechaaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nfacturaTextBox = new System.Windows.Forms.TextBox();
            this.iD_PagoComboBox = new System.Windows.Forms.ComboBox();
            this.condicionespagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipodocumentoComboBox = new System.Windows.Forms.ComboBox();
            this.tipodocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblregistroxden = new System.Windows.Forms.Label();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.productosTableAdapter1 = new Primo_y_Fibonacci.ControlDataSetTableAdapters.ProductosTableAdapter();
            this.condiciones_pagosTableAdapter = new Primo_y_Fibonacci.ControlDataSetTableAdapters.condiciones_pagosTableAdapter();
            this.tipo_documentoTableAdapter = new Primo_y_Fibonacci.ControlDataSetTableAdapters.Tipo_documentoTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalCompra = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIvaCompra = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSumaCompra = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            idCompraLabel = new System.Windows.Forms.Label();
            id_ProveedorLabel = new System.Windows.Forms.Label();
            fechaaLabel = new System.Windows.Forms.Label();
            nfacturaLabel = new System.Windows.Forms.Label();
            iD_PagoLabel = new System.Windows.Forms.Label();
            iD_TipoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleCompraBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compra_OrdenesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleCompraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleCompraDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.condicionespagosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipodocumentoBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idCompraLabel
            // 
            idCompraLabel.AutoSize = true;
            idCompraLabel.Location = new System.Drawing.Point(321, 104);
            idCompraLabel.Name = "idCompraLabel";
            idCompraLabel.Size = new System.Drawing.Size(21, 13);
            idCompraLabel.TabIndex = 12;
            idCompraLabel.Text = "ID:";
            // 
            // id_ProveedorLabel
            // 
            id_ProveedorLabel.AutoSize = true;
            id_ProveedorLabel.Location = new System.Drawing.Point(4, 104);
            id_ProveedorLabel.Name = "id_ProveedorLabel";
            id_ProveedorLabel.Size = new System.Drawing.Size(78, 13);
            id_ProveedorLabel.TabIndex = 14;
            id_ProveedorLabel.Text = "PROVEEDOR:";
            // 
            // fechaaLabel
            // 
            fechaaLabel.AutoSize = true;
            fechaaLabel.Location = new System.Drawing.Point(1, 164);
            fechaaLabel.Name = "fechaaLabel";
            fechaaLabel.Size = new System.Drawing.Size(94, 13);
            fechaaLabel.TabIndex = 16;
            fechaaLabel.Text = "FECHA COMPRA:";
            // 
            // nfacturaLabel
            // 
            nfacturaLabel.AutoSize = true;
            nfacturaLabel.Location = new System.Drawing.Point(473, 103);
            nfacturaLabel.Name = "nfacturaLabel";
            nfacturaLabel.Size = new System.Drawing.Size(77, 13);
            nfacturaLabel.TabIndex = 18;
            nfacturaLabel.Text = "FACTURA No:";
            // 
            // iD_PagoLabel
            // 
            iD_PagoLabel.AutoSize = true;
            iD_PagoLabel.Location = new System.Drawing.Point(321, 164);
            iD_PagoLabel.Name = "iD_PagoLabel";
            iD_PagoLabel.Size = new System.Drawing.Size(40, 13);
            iD_PagoLabel.TabIndex = 20;
            iD_PagoLabel.Text = "PAGO:";
            // 
            // iD_TipoLabel
            // 
            iD_TipoLabel.AutoSize = true;
            iD_TipoLabel.Location = new System.Drawing.Point(465, 164);
            iD_TipoLabel.Name = "iD_TipoLabel";
            iD_TipoLabel.Size = new System.Drawing.Size(80, 13);
            iD_TipoLabel.TabIndex = 22;
            iD_TipoLabel.Text = "DOCUMENTO:";
            // 
            // proveedorTableAdapter
            // 
            this.proveedorTableAdapter.ClearBeforeFill = true;
            // 
            // controlDataSet
            // 
            this.controlDataSet.DataSetName = "ControlDataSet";
            this.controlDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // compra_OrdenesBindingSource
            // 
            this.compra_OrdenesBindingSource.DataMember = "Compra_Ordenes";
            this.compra_OrdenesBindingSource.DataSource = this.controlDataSet;
            // 
            // compra_OrdenesTableAdapter
            // 
            this.compra_OrdenesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriasTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.Compra_OrdenesTableAdapter = this.compra_OrdenesTableAdapter;
            this.tableAdapterManager.condiciones_pagosTableAdapter = null;
            this.tableAdapterManager.detalle_CompraTableAdapter = null;
            this.tableAdapterManager.Detalle_VentaTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.InventarioTableAdapter = null;
            this.tableAdapterManager.ProductosTableAdapter = null;
            this.tableAdapterManager.ProveedorTableAdapter = this.proveedorTableAdapter;
            this.tableAdapterManager.Tipo_documentoTableAdapter = null;
            this.tableAdapterManager.Tipo_UsuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Primo_y_Fibonacci.ControlDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            this.tableAdapterManager.VentasTableAdapter = null;
            // 
            // detalleCompraBindingSource
            // 
            this.detalleCompraBindingSource.DataMember = "Compra_Ordenes_DetalleCompra";
            this.detalleCompraBindingSource.DataSource = this.compra_OrdenesBindingSource;
            // 
            // detalleCompraTableAdapter
            // 
            this.detalleCompraTableAdapter.ClearBeforeFill = true;
            // 
            // detalleCompraDataGridView
            // 
            this.detalleCompraDataGridView.AllowUserToAddRows = false;
            this.detalleCompraDataGridView.AllowUserToDeleteRows = false;
            this.detalleCompraDataGridView.AutoGenerateColumns = false;
            this.detalleCompraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detalleCompraDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn2,
            this.CODIGO,
            this.NOMBRE,
            this.cantidad,
            this.PRECIO,
            this.descuento,
            this.subtotal});
            this.detalleCompraDataGridView.DataSource = this.detalleCompraBindingSource;
            this.detalleCompraDataGridView.Location = new System.Drawing.Point(7, 224);
            this.detalleCompraDataGridView.Name = "detalleCompraDataGridView";
            this.detalleCompraDataGridView.ReadOnly = true;
            this.detalleCompraDataGridView.Size = new System.Drawing.Size(633, 220);
            this.detalleCompraDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdDCompra";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdDCompra";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ID_Compra";
            this.dataGridViewTextBoxColumn4.HeaderText = "ID_Compra";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_producto";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_producto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // CODIGO
            // 
            this.CODIGO.DataPropertyName = "codigo";
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            // 
            // NOMBRE
            // 
            this.NOMBRE.DataPropertyName = "nombre";
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            this.NOMBRE.Width = 200;
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "cantid_compra";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.cantidad.DefaultCellStyle = dataGridViewCellStyle1;
            this.cantidad.HeaderText = "CANT";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 60;
            // 
            // PRECIO
            // 
            this.PRECIO.DataPropertyName = "precio";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.PRECIO.DefaultCellStyle = dataGridViewCellStyle2;
            this.PRECIO.HeaderText = "PRECIO";
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.ReadOnly = true;
            this.PRECIO.Width = 80;
            // 
            // descuento
            // 
            this.descuento.DataPropertyName = "descuento";
            this.descuento.HeaderText = "DESC";
            this.descuento.Name = "descuento";
            this.descuento.ReadOnly = true;
            this.descuento.Width = 50;
            // 
            // subtotal
            // 
            this.subtotal.DataPropertyName = "subtotal";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.subtotal.DefaultCellStyle = dataGridViewCellStyle3;
            this.subtotal.HeaderText = "SUB TOTAL";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // idCompraTextBox
            // 
            this.idCompraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compra_OrdenesBindingSource, "IdCompra", true));
            this.idCompraTextBox.Location = new System.Drawing.Point(360, 101);
            this.idCompraTextBox.Name = "idCompraTextBox";
            this.idCompraTextBox.ReadOnly = true;
            this.idCompraTextBox.Size = new System.Drawing.Size(84, 20);
            this.idCompraTextBox.TabIndex = 13;
            // 
            // id_ProveedorComboBox
            // 
            this.id_ProveedorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.compra_OrdenesBindingSource, "Id_Proveedor", true));
            this.id_ProveedorComboBox.DataSource = this.proveedorBindingSource1;
            this.id_ProveedorComboBox.DisplayMember = "nombre";
            this.id_ProveedorComboBox.Enabled = false;
            this.id_ProveedorComboBox.FormattingEnabled = true;
            this.id_ProveedorComboBox.Location = new System.Drawing.Point(103, 100);
            this.id_ProveedorComboBox.Name = "id_ProveedorComboBox";
            this.id_ProveedorComboBox.Size = new System.Drawing.Size(200, 21);
            this.id_ProveedorComboBox.TabIndex = 15;
            this.id_ProveedorComboBox.ValueMember = "IdProveedor";
            // 
            // proveedorBindingSource1
            // 
            this.proveedorBindingSource1.DataMember = "Proveedor";
            this.proveedorBindingSource1.DataSource = this.controlDataSet;
            // 
            // fechaaDateTimePicker
            // 
            this.fechaaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.compra_OrdenesBindingSource, "fechaa", true));
            this.fechaaDateTimePicker.Enabled = false;
            this.fechaaDateTimePicker.Location = new System.Drawing.Point(104, 161);
            this.fechaaDateTimePicker.Name = "fechaaDateTimePicker";
            this.fechaaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaaDateTimePicker.TabIndex = 17;
            // 
            // nfacturaTextBox
            // 
            this.nfacturaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compra_OrdenesBindingSource, "nfactura", true));
            this.nfacturaTextBox.Location = new System.Drawing.Point(556, 101);
            this.nfacturaTextBox.Name = "nfacturaTextBox";
            this.nfacturaTextBox.ReadOnly = true;
            this.nfacturaTextBox.Size = new System.Drawing.Size(88, 20);
            this.nfacturaTextBox.TabIndex = 19;
            // 
            // iD_PagoComboBox
            // 
            this.iD_PagoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.compra_OrdenesBindingSource, "ID_Pago", true));
            this.iD_PagoComboBox.DataSource = this.condicionespagosBindingSource;
            this.iD_PagoComboBox.DisplayMember = "tipo";
            this.iD_PagoComboBox.Enabled = false;
            this.iD_PagoComboBox.FormattingEnabled = true;
            this.iD_PagoComboBox.Location = new System.Drawing.Point(367, 159);
            this.iD_PagoComboBox.Name = "iD_PagoComboBox";
            this.iD_PagoComboBox.Size = new System.Drawing.Size(82, 21);
            this.iD_PagoComboBox.TabIndex = 21;
            this.iD_PagoComboBox.ValueMember = "IdPago";
            // 
            // condicionespagosBindingSource
            // 
            this.condicionespagosBindingSource.DataMember = "condiciones_pagos";
            this.condicionespagosBindingSource.DataSource = this.controlDataSet;
            // 
            // tipodocumentoComboBox
            // 
            this.tipodocumentoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.compra_OrdenesBindingSource, "ID_Tipo", true));
            this.tipodocumentoComboBox.DataSource = this.tipodocumentoBindingSource;
            this.tipodocumentoComboBox.DisplayMember = "tipo";
            this.tipodocumentoComboBox.Enabled = false;
            this.tipodocumentoComboBox.FormattingEnabled = true;
            this.tipodocumentoComboBox.Location = new System.Drawing.Point(551, 160);
            this.tipodocumentoComboBox.Name = "tipodocumentoComboBox";
            this.tipodocumentoComboBox.Size = new System.Drawing.Size(78, 21);
            this.tipodocumentoComboBox.TabIndex = 23;
            this.tipodocumentoComboBox.ValueMember = "IdTipo";
            // 
            // tipodocumentoBindingSource
            // 
            this.tipodocumentoBindingSource.DataMember = "Tipo_documento";
            this.tipodocumentoBindingSource.DataSource = this.controlDataSet;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblregistroxden);
            this.panel2.Controls.Add(this.btnUltimo);
            this.panel2.Controls.Add(this.btnSiguiente);
            this.panel2.Controls.Add(this.btnAnterior);
            this.panel2.Controls.Add(this.btnPrimero);
            this.panel2.Location = new System.Drawing.Point(43, 477);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 49);
            this.panel2.TabIndex = 24;
            // 
            // lblregistroxden
            // 
            this.lblregistroxden.AutoSize = true;
            this.lblregistroxden.Location = new System.Drawing.Point(87, 16);
            this.lblregistroxden.Name = "lblregistroxden";
            this.lblregistroxden.Size = new System.Drawing.Size(36, 13);
            this.lblregistroxden.TabIndex = 6;
            this.lblregistroxden.Text = "x de n";
            // 
            // btnUltimo
            // 
            this.btnUltimo.Location = new System.Drawing.Point(160, 3);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(32, 38);
            this.btnUltimo.TabIndex = 3;
            this.btnUltimo.Text = ">|";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(129, 3);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(32, 38);
            this.btnSiguiente.TabIndex = 2;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(38, 3);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(32, 38);
            this.btnAnterior.TabIndex = 1;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnPrimero
            // 
            this.btnPrimero.Location = new System.Drawing.Point(7, 3);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(32, 38);
            this.btnPrimero.TabIndex = 0;
            this.btnPrimero.Text = "|<";
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // productosTableAdapter1
            // 
            this.productosTableAdapter1.ClearBeforeFill = true;
            // 
            // condiciones_pagosTableAdapter
            // 
            this.condiciones_pagosTableAdapter.ClearBeforeFill = true;
            // 
            // tipo_documentoTableAdapter
            // 
            this.tipo_documentoTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotalCompra);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblIvaCompra);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblSumaCompra);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(436, 466);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 92);
            this.panel1.TabIndex = 25;
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
            this.label4.Location = new System.Drawing.Point(11, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "TOTAL:";
            // 
            // lblIvaCompra
            // 
            this.lblIvaCompra.AutoSize = true;
            this.lblIvaCompra.Location = new System.Drawing.Point(154, 36);
            this.lblIvaCompra.Name = "lblIvaCompra";
            this.lblIvaCompra.Size = new System.Drawing.Size(34, 13);
            this.lblIvaCompra.TabIndex = 3;
            this.lblIvaCompra.Text = "00.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
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
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SUMA:";
            // 
            // btnsalir
            // 
            this.btnsalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsalir.BackgroundImage")));
            this.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsalir.Location = new System.Drawing.Point(609, 12);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(31, 29);
            this.btnsalir.TabIndex = 27;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 591);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(idCompraLabel);
            this.Controls.Add(this.idCompraTextBox);
            this.Controls.Add(id_ProveedorLabel);
            this.Controls.Add(this.id_ProveedorComboBox);
            this.Controls.Add(fechaaLabel);
            this.Controls.Add(this.fechaaDateTimePicker);
            this.Controls.Add(nfacturaLabel);
            this.Controls.Add(this.nfacturaTextBox);
            this.Controls.Add(iD_PagoLabel);
            this.Controls.Add(this.iD_PagoComboBox);
            this.Controls.Add(iD_TipoLabel);
            this.Controls.Add(this.tipodocumentoComboBox);
            this.Controls.Add(this.detalleCompraDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Compra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.Compra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleCompraBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compra_OrdenesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleCompraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleCompraDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.condicionespagosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipodocumentoBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource detalleCompraBindingSource1;
        private ControlDataSetTableAdapters.ProveedorTableAdapter proveedorTableAdapter;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private ControlDataSet controlDataSet;
        private System.Windows.Forms.BindingSource compra_OrdenesBindingSource;
        private ControlDataSetTableAdapters.Compra_OrdenesTableAdapter compra_OrdenesTableAdapter;
        private ControlDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource detalleCompraBindingSource;
        private ControlDataSetTableAdapters.DetalleCompraTableAdapter detalleCompraTableAdapter;
        private System.Windows.Forms.DataGridView detalleCompraDataGridView;
        private System.Windows.Forms.TextBox idCompraTextBox;
        private System.Windows.Forms.ComboBox id_ProveedorComboBox;
        private System.Windows.Forms.DateTimePicker fechaaDateTimePicker;
        private System.Windows.Forms.TextBox nfacturaTextBox;
        private System.Windows.Forms.ComboBox iD_PagoComboBox;
        private System.Windows.Forms.ComboBox tipodocumentoComboBox;
        private System.Windows.Forms.BindingSource proveedorBindingSource1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblregistroxden;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPrimero;
        private ControlDataSetTableAdapters.ProductosTableAdapter productosTableAdapter1;
        private System.Windows.Forms.BindingSource condicionespagosBindingSource;
        private ControlDataSetTableAdapters.condiciones_pagosTableAdapter condiciones_pagosTableAdapter;
        private System.Windows.Forms.BindingSource tipodocumentoBindingSource;
        private ControlDataSetTableAdapters.Tipo_documentoTableAdapter tipo_documentoTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalCompra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblIvaCompra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSumaCompra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.Button btnsalir;
    }
}