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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.ID_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantid_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCompraTextBox = new System.Windows.Forms.TextBox();
            this.id_ProveedorComboBox = new System.Windows.Forms.ComboBox();
            this.proveedorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fechaacompraDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nfacturaTextBox = new System.Windows.Forms.TextBox();
            this.iDPagoComboBox = new System.Windows.Forms.ComboBox();
            this.condicionespagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipodocumentoComboBox = new System.Windows.Forms.ComboBox();
            this.tipodocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlNavegacion = new System.Windows.Forms.Panel();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.lblregistroxden = new System.Windows.Forms.Label();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlEdicion = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pnlProductosGrid = new System.Windows.Forms.Panel();
            this.btnQuitarProductosGrid = new System.Windows.Forms.Button();
            this.btnAgregarProductosGrid = new System.Windows.Forms.Button();
            this.detalle_CompraTableAdapter1 = new Primo_y_Fibonacci.ControlDataSetTableAdapters.detalle_CompraTableAdapter();
            idCompraLabel = new System.Windows.Forms.Label();
            id_ProveedorLabel = new System.Windows.Forms.Label();
            fechaaLabel = new System.Windows.Forms.Label();
            nfacturaLabel = new System.Windows.Forms.Label();
            iD_PagoLabel = new System.Windows.Forms.Label();
            iD_TipoLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleCompraBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compra_OrdenesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleCompraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleCompraDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.condicionespagosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipodocumentoBindingSource)).BeginInit();
            this.pnlNavegacion.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlEdicion.SuspendLayout();
            this.pnlProductosGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // idCompraLabel
            // 
            idCompraLabel.AutoSize = true;
            idCompraLabel.BackColor = System.Drawing.Color.White;
            idCompraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idCompraLabel.Location = new System.Drawing.Point(331, 118);
            idCompraLabel.Name = "idCompraLabel";
            idCompraLabel.Size = new System.Drawing.Size(22, 15);
            idCompraLabel.TabIndex = 12;
            idCompraLabel.Text = "ID:";
            // 
            // id_ProveedorLabel
            // 
            id_ProveedorLabel.AutoSize = true;
            id_ProveedorLabel.BackColor = System.Drawing.Color.White;
            id_ProveedorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_ProveedorLabel.Location = new System.Drawing.Point(17, 119);
            id_ProveedorLabel.Name = "id_ProveedorLabel";
            id_ProveedorLabel.Size = new System.Drawing.Size(86, 15);
            id_ProveedorLabel.TabIndex = 14;
            id_ProveedorLabel.Text = "PROVEEDOR:";
            // 
            // fechaaLabel
            // 
            fechaaLabel.AutoSize = true;
            fechaaLabel.BackColor = System.Drawing.Color.White;
            fechaaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaaLabel.Location = new System.Drawing.Point(1, 178);
            fechaaLabel.Name = "fechaaLabel";
            fechaaLabel.Size = new System.Drawing.Size(104, 15);
            fechaaLabel.TabIndex = 16;
            fechaaLabel.Text = "FECHA COMPRA:";
            // 
            // nfacturaLabel
            // 
            nfacturaLabel.AutoSize = true;
            nfacturaLabel.BackColor = System.Drawing.Color.White;
            nfacturaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nfacturaLabel.Location = new System.Drawing.Point(467, 118);
            nfacturaLabel.Name = "nfacturaLabel";
            nfacturaLabel.Size = new System.Drawing.Size(83, 15);
            nfacturaLabel.TabIndex = 18;
            nfacturaLabel.Text = "FACTURA No:";
            // 
            // iD_PagoLabel
            // 
            iD_PagoLabel.AutoSize = true;
            iD_PagoLabel.BackColor = System.Drawing.Color.White;
            iD_PagoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_PagoLabel.Location = new System.Drawing.Point(321, 178);
            iD_PagoLabel.Name = "iD_PagoLabel";
            iD_PagoLabel.Size = new System.Drawing.Size(43, 15);
            iD_PagoLabel.TabIndex = 20;
            iD_PagoLabel.Text = "PAGO:";
            // 
            // iD_TipoLabel
            // 
            iD_TipoLabel.AutoSize = true;
            iD_TipoLabel.BackColor = System.Drawing.Color.White;
            iD_TipoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_TipoLabel.Location = new System.Drawing.Point(466, 178);
            iD_TipoLabel.Name = "iD_TipoLabel";
            iD_TipoLabel.Size = new System.Drawing.Size(89, 15);
            iD_TipoLabel.TabIndex = 22;
            iD_TipoLabel.Text = "DOCUMENTO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(189, 38);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(156, 37);
            label2.TabIndex = 29;
            label2.Text = "COMPRA";
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
            this.tableAdapterManager.Detalle_Pedido_ClientTableAdapter = null;
            this.tableAdapterManager.Detalle_VentaTableAdapter = null;
            this.tableAdapterManager.Dfactura_CTableAdapter = null;
            this.tableAdapterManager.DFactura_VTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.factura_compraTableAdapter = null;
            this.tableAdapterManager.factura_ventaTableAdapter = null;
            this.tableAdapterManager.InventarioTableAdapter = null;
            this.tableAdapterManager.Pedido_ClienteTableAdapter = null;
            this.tableAdapterManager.ProductosTableAdapter = null;
            this.tableAdapterManager.ProveedorTableAdapter = this.proveedorTableAdapter;
            this.tableAdapterManager.ReportProveedorTableAdapter = null;
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
            this.ID_producto,
            this.codigo,
            this.nombre,
            this.cantid_compra,
            this.precio,
            this.descuento,
            this.unidades,
            this.subtotal});
            this.detalleCompraDataGridView.DataSource = this.detalleCompraBindingSource;
            this.detalleCompraDataGridView.Location = new System.Drawing.Point(7, 300);
            this.detalleCompraDataGridView.Name = "detalleCompraDataGridView";
            this.detalleCompraDataGridView.ReadOnly = true;
            this.detalleCompraDataGridView.Size = new System.Drawing.Size(633, 159);
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
            // ID_producto
            // 
            this.ID_producto.DataPropertyName = "ID_producto";
            this.ID_producto.HeaderText = "ID_producto";
            this.ID_producto.Name = "ID_producto";
            this.ID_producto.ReadOnly = true;
            this.ID_producto.Visible = false;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "CODIGO";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 130;
            // 
            // cantid_compra
            // 
            this.cantid_compra.DataPropertyName = "cantid_compra";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.cantid_compra.DefaultCellStyle = dataGridViewCellStyle1;
            this.cantid_compra.HeaderText = "CANT";
            this.cantid_compra.Name = "cantid_compra";
            this.cantid_compra.ReadOnly = true;
            this.cantid_compra.Width = 60;
            // 
            // precio
            // 
            this.precio.DataPropertyName = "precio";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.precio.DefaultCellStyle = dataGridViewCellStyle2;
            this.precio.HeaderText = "PRECIO";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 80;
            // 
            // descuento
            // 
            this.descuento.DataPropertyName = "descuento";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.descuento.DefaultCellStyle = dataGridViewCellStyle3;
            this.descuento.HeaderText = "DESC";
            this.descuento.Name = "descuento";
            this.descuento.ReadOnly = true;
            this.descuento.Width = 50;
            // 
            // unidades
            // 
            this.unidades.DataPropertyName = "unidades";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.unidades.DefaultCellStyle = dataGridViewCellStyle4;
            this.unidades.HeaderText = "UNID";
            this.unidades.Name = "unidades";
            this.unidades.ReadOnly = true;
            this.unidades.Width = 80;
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
            // idCompraTextBox
            // 
            this.idCompraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compra_OrdenesBindingSource, "IdCompra", true));
            this.idCompraTextBox.Location = new System.Drawing.Point(360, 115);
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
            this.id_ProveedorComboBox.Location = new System.Drawing.Point(103, 114);
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
            // fechaacompraDateTimePicker
            // 
            this.fechaacompraDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.compra_OrdenesBindingSource, "fechaa", true));
            this.fechaacompraDateTimePicker.Enabled = false;
            this.fechaacompraDateTimePicker.Location = new System.Drawing.Point(107, 175);
            this.fechaacompraDateTimePicker.Name = "fechaacompraDateTimePicker";
            this.fechaacompraDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaacompraDateTimePicker.TabIndex = 17;
            // 
            // nfacturaTextBox
            // 
            this.nfacturaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compra_OrdenesBindingSource, "nfactura", true));
            this.nfacturaTextBox.Location = new System.Drawing.Point(556, 115);
            this.nfacturaTextBox.Name = "nfacturaTextBox";
            this.nfacturaTextBox.ReadOnly = true;
            this.nfacturaTextBox.Size = new System.Drawing.Size(88, 20);
            this.nfacturaTextBox.TabIndex = 19;
            // 
            // iDPagoComboBox
            // 
            this.iDPagoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.compra_OrdenesBindingSource, "ID_Pago", true));
            this.iDPagoComboBox.DataSource = this.condicionespagosBindingSource;
            this.iDPagoComboBox.DisplayMember = "tipo";
            this.iDPagoComboBox.Enabled = false;
            this.iDPagoComboBox.FormattingEnabled = true;
            this.iDPagoComboBox.Location = new System.Drawing.Point(367, 173);
            this.iDPagoComboBox.Name = "iDPagoComboBox";
            this.iDPagoComboBox.Size = new System.Drawing.Size(82, 21);
            this.iDPagoComboBox.TabIndex = 21;
            this.iDPagoComboBox.ValueMember = "IdPago";
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
            this.tipodocumentoComboBox.Location = new System.Drawing.Point(558, 174);
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
            // pnlNavegacion
            // 
            this.pnlNavegacion.BackColor = System.Drawing.Color.Silver;
            this.pnlNavegacion.Controls.Add(this.btnUltimo);
            this.pnlNavegacion.Controls.Add(this.btnSiguiente);
            this.pnlNavegacion.Controls.Add(this.btnPrimero);
            this.pnlNavegacion.Controls.Add(this.btnAnterior);
            this.pnlNavegacion.Controls.Add(this.lblregistroxden);
            this.pnlNavegacion.Location = new System.Drawing.Point(12, 544);
            this.pnlNavegacion.Name = "pnlNavegacion";
            this.pnlNavegacion.Size = new System.Drawing.Size(385, 63);
            this.pnlNavegacion.TabIndex = 24;
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
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.lblTotalCompra);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblIvaCompra);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblSumaCompra);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(436, 533);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 86);
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
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Transparent;
            this.btnsalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsalir.BackgroundImage")));
            this.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsalir.Location = new System.Drawing.Point(604, 5);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(40, 36);
            this.btnsalir.TabIndex = 27;
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 98);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // pnlEdicion
            // 
            this.pnlEdicion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlEdicion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEdicion.Controls.Add(this.button1);
            this.pnlEdicion.Controls.Add(this.btnBuscar);
            this.pnlEdicion.Controls.Add(this.btnAgregar);
            this.pnlEdicion.Controls.Add(this.btnModificar);
            this.pnlEdicion.Controls.Add(this.btnEliminar);
            this.pnlEdicion.Location = new System.Drawing.Point(-3, 235);
            this.pnlEdicion.Name = "pnlEdicion";
            this.pnlEdicion.Size = new System.Drawing.Size(654, 33);
            this.pnlEdicion.TabIndex = 42;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(579, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "IMPRIMIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(452, -1);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(67, 33);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(21, -1);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(67, 33);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Nuevo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(170, -1);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(67, 33);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(313, -1);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(67, 33);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // pnlProductosGrid
            // 
            this.pnlProductosGrid.Controls.Add(this.btnQuitarProductosGrid);
            this.pnlProductosGrid.Controls.Add(this.btnAgregarProductosGrid);
            this.pnlProductosGrid.Location = new System.Drawing.Point(7, 474);
            this.pnlProductosGrid.Name = "pnlProductosGrid";
            this.pnlProductosGrid.Size = new System.Drawing.Size(94, 49);
            this.pnlProductosGrid.TabIndex = 43;
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
            // detalle_CompraTableAdapter1
            // 
            this.detalle_CompraTableAdapter1.ClearBeforeFill = true;
            // 
            // Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(647, 631);
            this.Controls.Add(this.pnlProductosGrid);
            this.Controls.Add(this.pnlEdicion);
            this.Controls.Add(label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlNavegacion);
            this.Controls.Add(idCompraLabel);
            this.Controls.Add(this.idCompraTextBox);
            this.Controls.Add(id_ProveedorLabel);
            this.Controls.Add(this.id_ProveedorComboBox);
            this.Controls.Add(fechaaLabel);
            this.Controls.Add(this.fechaacompraDateTimePicker);
            this.Controls.Add(nfacturaLabel);
            this.Controls.Add(this.nfacturaTextBox);
            this.Controls.Add(iD_PagoLabel);
            this.Controls.Add(this.iDPagoComboBox);
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
            this.pnlNavegacion.ResumeLayout(false);
            this.pnlNavegacion.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlEdicion.ResumeLayout(false);
            this.pnlProductosGrid.ResumeLayout(false);
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
        private System.Windows.Forms.DateTimePicker fechaacompraDateTimePicker;
        private System.Windows.Forms.TextBox nfacturaTextBox;
        private System.Windows.Forms.ComboBox iDPagoComboBox;
        private System.Windows.Forms.ComboBox tipodocumentoComboBox;
        private System.Windows.Forms.BindingSource proveedorBindingSource1;
        private System.Windows.Forms.Panel pnlNavegacion;
        private System.Windows.Forms.Label lblregistroxden;
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
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlEdicion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel pnlProductosGrid;
        private System.Windows.Forms.Button btnQuitarProductosGrid;
        private System.Windows.Forms.Button btnAgregarProductosGrid;
        private ControlDataSetTableAdapters.detalle_CompraTableAdapter detalle_CompraTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantid_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.Button button1;
    }
}