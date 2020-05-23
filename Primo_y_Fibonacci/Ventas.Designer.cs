namespace Primo_y_Fibonacci
{
    partial class Ventas
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
            System.Windows.Forms.Label idVentasLabel;
            System.Windows.Forms.Label iD_ClientesLabel;
            System.Windows.Forms.Label iD_EmpleadoLabel;
            System.Windows.Forms.Label nFacturaLabel;
            System.Windows.Forms.Label fecha_ventLabel;
            System.Windows.Forms.Label iDPagoLabel;
            System.Windows.Forms.Label iDTipoLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controlDataSet = new Primo_y_Fibonacci.ControlDataSet();
            this.detalleVentaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.detalleVentaDataGridView = new System.Windows.Forms.DataGridView();
            this.ventasTableAdapter = new Primo_y_Fibonacci.ControlDataSetTableAdapters.VentasTableAdapter();
            this.tableAdapterManager = new Primo_y_Fibonacci.ControlDataSetTableAdapters.TableAdapterManager();
            this.detalleVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalleVentaTableAdapter = new Primo_y_Fibonacci.ControlDataSetTableAdapters.DetalleVentaTableAdapter();
            this.controlDataSet1 = new Primo_y_Fibonacci.ControlDataSet();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new Primo_y_Fibonacci.ControlDataSetTableAdapters.ClienteTableAdapter();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoTableAdapter = new Primo_y_Fibonacci.ControlDataSetTableAdapters.EmpleadoTableAdapter();
            this.idVentasTextBox = new System.Windows.Forms.TextBox();
            this.iD_ClientesComboBox = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iD_EmpleadoComboBox = new System.Windows.Forms.ComboBox();
            this.empleadoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nFacturaTextBox = new System.Windows.Forms.TextBox();
            this.fecha_ventDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.iDPagoComboBox = new System.Windows.Forms.ComboBox();
            this.condicionespagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipodocumentoComboBox = new System.Windows.Forms.ComboBox();
            this.tipodocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.condiciones_pagosTableAdapter = new Primo_y_Fibonacci.ControlDataSetTableAdapters.condiciones_pagosTableAdapter();
            this.tipo_documentoTableAdapter = new Primo_y_Fibonacci.ControlDataSetTableAdapters.Tipo_documentoTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalVenta = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIvaVenta = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSumaVenta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblregistroxden = new System.Windows.Forms.Label();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idVentasLabel = new System.Windows.Forms.Label();
            iD_ClientesLabel = new System.Windows.Forms.Label();
            iD_EmpleadoLabel = new System.Windows.Forms.Label();
            nFacturaLabel = new System.Windows.Forms.Label();
            fecha_ventLabel = new System.Windows.Forms.Label();
            iDPagoLabel = new System.Windows.Forms.Label();
            iDTipoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.condicionespagosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipodocumentoBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // idVentasLabel
            // 
            idVentasLabel.AutoSize = true;
            idVentasLabel.Location = new System.Drawing.Point(289, 129);
            idVentasLabel.Name = "idVentasLabel";
            idVentasLabel.Size = new System.Drawing.Size(21, 13);
            idVentasLabel.TabIndex = 15;
            idVentasLabel.Text = "ID:";
            // 
            // iD_ClientesLabel
            // 
            iD_ClientesLabel.AutoSize = true;
            iD_ClientesLabel.Location = new System.Drawing.Point(10, 130);
            iD_ClientesLabel.Name = "iD_ClientesLabel";
            iD_ClientesLabel.Size = new System.Drawing.Size(55, 13);
            iD_ClientesLabel.TabIndex = 17;
            iD_ClientesLabel.Text = "CLIENTE:";
            // 
            // iD_EmpleadoLabel
            // 
            iD_EmpleadoLabel.AutoSize = true;
            iD_EmpleadoLabel.Location = new System.Drawing.Point(289, 177);
            iD_EmpleadoLabel.Name = "iD_EmpleadoLabel";
            iD_EmpleadoLabel.Size = new System.Drawing.Size(69, 13);
            iD_EmpleadoLabel.TabIndex = 19;
            iD_EmpleadoLabel.Text = "EMPLEADO:";
            // 
            // nFacturaLabel
            // 
            nFacturaLabel.AutoSize = true;
            nFacturaLabel.Location = new System.Drawing.Point(381, 130);
            nFacturaLabel.Name = "nFacturaLabel";
            nFacturaLabel.Size = new System.Drawing.Size(77, 13);
            nFacturaLabel.TabIndex = 21;
            nFacturaLabel.Text = "FACTURA No:";
            // 
            // fecha_ventLabel
            // 
            fecha_ventLabel.AutoSize = true;
            fecha_ventLabel.Location = new System.Drawing.Point(4, 177);
            fecha_ventLabel.Name = "fecha_ventLabel";
            fecha_ventLabel.Size = new System.Drawing.Size(64, 13);
            fecha_ventLabel.TabIndex = 23;
            fecha_ventLabel.Text = "FECHA Vta:";
            // 
            // iDPagoLabel
            // 
            iDPagoLabel.AutoSize = true;
            iDPagoLabel.Location = new System.Drawing.Point(43, 220);
            iDPagoLabel.Name = "iDPagoLabel";
            iDPagoLabel.Size = new System.Drawing.Size(40, 13);
            iDPagoLabel.TabIndex = 25;
            iDPagoLabel.Text = "PAGO:";
            // 
            // iDTipoLabel
            // 
            iDTipoLabel.AutoSize = true;
            iDTipoLabel.Location = new System.Drawing.Point(284, 224);
            iDTipoLabel.Name = "iDTipoLabel";
            iDTipoLabel.Size = new System.Drawing.Size(80, 13);
            iDTipoLabel.TabIndex = 27;
            iDTipoLabel.Text = "DOCUMENTO:";
            // 
            // ventasBindingSource
            // 
            this.ventasBindingSource.DataMember = "Ventas";
            this.ventasBindingSource.DataSource = this.controlDataSet;
            // 
            // controlDataSet
            // 
            this.controlDataSet.DataSetName = "ControlDataSet";
            this.controlDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detalleVentaBindingSource1
            // 
            this.detalleVentaBindingSource1.DataMember = "FK_Detalle_Venta_Ventas1";
            this.detalleVentaBindingSource1.DataSource = this.ventasBindingSource;
            // 
            // detalleVentaDataGridView
            // 
            this.detalleVentaDataGridView.AllowUserToAddRows = false;
            this.detalleVentaDataGridView.AllowUserToDeleteRows = false;
            this.detalleVentaDataGridView.AutoGenerateColumns = false;
            this.detalleVentaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detalleVentaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.NOMBRE,
            this.unidades,
            this.cantidad,
            this.precio,
            this.descuento,
            this.subtotal,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn6});
            this.detalleVentaDataGridView.DataSource = this.detalleVentaBindingSource1;
            this.detalleVentaDataGridView.Location = new System.Drawing.Point(4, 279);
            this.detalleVentaDataGridView.Name = "detalleVentaDataGridView";
            this.detalleVentaDataGridView.ReadOnly = true;
            this.detalleVentaDataGridView.Size = new System.Drawing.Size(670, 166);
            this.detalleVentaDataGridView.TabIndex = 15;
            // 
            // ventasTableAdapter
            // 
            this.ventasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriasTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.Compra_OrdenesTableAdapter = null;
            this.tableAdapterManager.condiciones_pagosTableAdapter = null;
            this.tableAdapterManager.detalle_CompraTableAdapter = null;
            this.tableAdapterManager.Detalle_VentaTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.InventarioTableAdapter = null;
            this.tableAdapterManager.ProductosTableAdapter = null;
            this.tableAdapterManager.ProveedorTableAdapter = null;
            this.tableAdapterManager.Tipo_documentoTableAdapter = null;
            this.tableAdapterManager.Tipo_UsuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Primo_y_Fibonacci.ControlDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            this.tableAdapterManager.VentasTableAdapter = this.ventasTableAdapter;
            // 
            // detalleVentaBindingSource
            // 
            this.detalleVentaBindingSource.DataMember = "DetalleVenta";
            this.detalleVentaBindingSource.DataSource = this.controlDataSet;
            // 
            // detalleVentaTableAdapter
            // 
            this.detalleVentaTableAdapter.ClearBeforeFill = true;
            // 
            // controlDataSet1
            // 
            this.controlDataSet1.DataSetName = "ControlDataSet";
            this.controlDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.controlDataSet1;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataMember = "Empleado";
            this.empleadoBindingSource.DataSource = this.controlDataSet1;
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // idVentasTextBox
            // 
            this.idVentasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "IdVentas", true));
            this.idVentasTextBox.Location = new System.Drawing.Point(314, 126);
            this.idVentasTextBox.Name = "idVentasTextBox";
            this.idVentasTextBox.ReadOnly = true;
            this.idVentasTextBox.Size = new System.Drawing.Size(54, 20);
            this.idVentasTextBox.TabIndex = 16;
            // 
            // iD_ClientesComboBox
            // 
            this.iD_ClientesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ventasBindingSource, "ID_Clientes", true));
            this.iD_ClientesComboBox.DataSource = this.clienteBindingSource1;
            this.iD_ClientesComboBox.DisplayMember = "nombre";
            this.iD_ClientesComboBox.Enabled = false;
            this.iD_ClientesComboBox.FormattingEnabled = true;
            this.iD_ClientesComboBox.Location = new System.Drawing.Point(71, 125);
            this.iD_ClientesComboBox.Name = "iD_ClientesComboBox";
            this.iD_ClientesComboBox.Size = new System.Drawing.Size(200, 21);
            this.iD_ClientesComboBox.TabIndex = 18;
            this.iD_ClientesComboBox.ValueMember = "IdCliente";
            // 
            // clienteBindingSource1
            // 
            this.clienteBindingSource1.DataMember = "Cliente";
            this.clienteBindingSource1.DataSource = this.controlDataSet1;
            // 
            // iD_EmpleadoComboBox
            // 
            this.iD_EmpleadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ventasBindingSource, "ID_Empleado", true));
            this.iD_EmpleadoComboBox.DataSource = this.empleadoBindingSource1;
            this.iD_EmpleadoComboBox.DisplayMember = "nombre";
            this.iD_EmpleadoComboBox.Enabled = false;
            this.iD_EmpleadoComboBox.FormattingEnabled = true;
            this.iD_EmpleadoComboBox.Location = new System.Drawing.Point(362, 174);
            this.iD_EmpleadoComboBox.Name = "iD_EmpleadoComboBox";
            this.iD_EmpleadoComboBox.Size = new System.Drawing.Size(204, 21);
            this.iD_EmpleadoComboBox.TabIndex = 20;
            this.iD_EmpleadoComboBox.ValueMember = "IdEmpleado";
            // 
            // empleadoBindingSource1
            // 
            this.empleadoBindingSource1.DataMember = "Empleado";
            this.empleadoBindingSource1.DataSource = this.controlDataSet1;
            // 
            // nFacturaTextBox
            // 
            this.nFacturaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "NFactura", true));
            this.nFacturaTextBox.Location = new System.Drawing.Point(461, 127);
            this.nFacturaTextBox.Name = "nFacturaTextBox";
            this.nFacturaTextBox.ReadOnly = true;
            this.nFacturaTextBox.Size = new System.Drawing.Size(59, 20);
            this.nFacturaTextBox.TabIndex = 22;
            // 
            // fecha_ventDateTimePicker
            // 
            this.fecha_ventDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ventasBindingSource, "fecha_vent", true));
            this.fecha_ventDateTimePicker.Enabled = false;
            this.fecha_ventDateTimePicker.Location = new System.Drawing.Point(70, 173);
            this.fecha_ventDateTimePicker.Name = "fecha_ventDateTimePicker";
            this.fecha_ventDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_ventDateTimePicker.TabIndex = 24;
            // 
            // iDPagoComboBox
            // 
            this.iDPagoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ventasBindingSource, "IDPago", true));
            this.iDPagoComboBox.DataSource = this.condicionespagosBindingSource;
            this.iDPagoComboBox.DisplayMember = "tipo";
            this.iDPagoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iDPagoComboBox.Enabled = false;
            this.iDPagoComboBox.FormattingEnabled = true;
            this.iDPagoComboBox.Location = new System.Drawing.Point(86, 217);
            this.iDPagoComboBox.Name = "iDPagoComboBox";
            this.iDPagoComboBox.Size = new System.Drawing.Size(89, 21);
            this.iDPagoComboBox.TabIndex = 26;
            this.iDPagoComboBox.ValueMember = "IdPago";
            // 
            // condicionespagosBindingSource
            // 
            this.condicionespagosBindingSource.DataMember = "condiciones_pagos";
            this.condicionespagosBindingSource.DataSource = this.controlDataSet1;
            // 
            // tipodocumentoComboBox
            // 
            this.tipodocumentoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ventasBindingSource, "IDTipo", true));
            this.tipodocumentoComboBox.DataSource = this.tipodocumentoBindingSource;
            this.tipodocumentoComboBox.DisplayMember = "tipo";
            this.tipodocumentoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipodocumentoComboBox.Enabled = false;
            this.tipodocumentoComboBox.FormattingEnabled = true;
            this.tipodocumentoComboBox.Location = new System.Drawing.Point(374, 220);
            this.tipodocumentoComboBox.Name = "tipodocumentoComboBox";
            this.tipodocumentoComboBox.Size = new System.Drawing.Size(72, 21);
            this.tipodocumentoComboBox.TabIndex = 28;
            this.tipodocumentoComboBox.ValueMember = "IdTipo";
            // 
            // tipodocumentoBindingSource
            // 
            this.tipodocumentoBindingSource.DataMember = "Tipo_documento";
            this.tipodocumentoBindingSource.DataSource = this.controlDataSet1;
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
            this.panel1.Controls.Add(this.lblTotalVenta);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblIvaVenta);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblSumaVenta);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(467, 471);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 92);
            this.panel1.TabIndex = 29;
            // 
            // lblTotalVenta
            // 
            this.lblTotalVenta.AutoSize = true;
            this.lblTotalVenta.Location = new System.Drawing.Point(142, 61);
            this.lblTotalVenta.Name = "lblTotalVenta";
            this.lblTotalVenta.Size = new System.Drawing.Size(46, 13);
            this.lblTotalVenta.TabIndex = 5;
            this.lblTotalVenta.Text = "0000.00";
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
            // lblIvaVenta
            // 
            this.lblIvaVenta.AutoSize = true;
            this.lblIvaVenta.Location = new System.Drawing.Point(142, 36);
            this.lblIvaVenta.Name = "lblIvaVenta";
            this.lblIvaVenta.Size = new System.Drawing.Size(34, 13);
            this.lblIvaVenta.TabIndex = 3;
            this.lblIvaVenta.Text = "00.00";
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
            // lblSumaVenta
            // 
            this.lblSumaVenta.AutoSize = true;
            this.lblSumaVenta.Location = new System.Drawing.Point(142, 12);
            this.lblSumaVenta.Name = "lblSumaVenta";
            this.lblSumaVenta.Size = new System.Drawing.Size(46, 13);
            this.lblSumaVenta.TabIndex = 1;
            this.lblSumaVenta.Text = "0000.00";
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
            // panel2
            // 
            this.panel2.Controls.Add(this.lblregistroxden);
            this.panel2.Controls.Add(this.btnUltimo);
            this.panel2.Controls.Add(this.btnSiguiente);
            this.panel2.Controls.Add(this.btnAnterior);
            this.panel2.Controls.Add(this.btnPrimero);
            this.panel2.Location = new System.Drawing.Point(45, 496);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 49);
            this.panel2.TabIndex = 30;
            // 
            // lblregistroxden
            // 
            this.lblregistroxden.AutoSize = true;
            this.lblregistroxden.Location = new System.Drawing.Point(82, 16);
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
            // CODIGO
            // 
            this.CODIGO.DataPropertyName = "codigo";
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            this.CODIGO.Width = 80;
            // 
            // NOMBRE
            // 
            this.NOMBRE.DataPropertyName = "nombre";
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            this.NOMBRE.Width = 200;
            // 
            // unidades
            // 
            this.unidades.DataPropertyName = "unidades";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.unidades.DefaultCellStyle = dataGridViewCellStyle11;
            this.unidades.HeaderText = "UNID";
            this.unidades.Name = "unidades";
            this.unidades.ReadOnly = true;
            this.unidades.Width = 60;
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "cantidad";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.cantidad.DefaultCellStyle = dataGridViewCellStyle12;
            this.cantidad.HeaderText = "CANT";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 60;
            // 
            // precio
            // 
            this.precio.DataPropertyName = "precio";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.precio.DefaultCellStyle = dataGridViewCellStyle13;
            this.precio.HeaderText = "PRECIO";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 80;
            // 
            // descuento
            // 
            this.descuento.DataPropertyName = "descuento";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.descuento.DefaultCellStyle = dataGridViewCellStyle14;
            this.descuento.HeaderText = "DESC";
            this.descuento.Name = "descuento";
            this.descuento.ReadOnly = true;
            this.descuento.Width = 50;
            // 
            // subtotal
            // 
            this.subtotal.DataPropertyName = "subtotal";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.subtotal.DefaultCellStyle = dataGridViewCellStyle15;
            this.subtotal.HeaderText = "SUB TOTAL";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ID_Ventas";
            this.dataGridViewTextBoxColumn5.HeaderText = "ID_Ventas";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdDetalle_Venta";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdDetalle_Venta";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ID_Productos";
            this.dataGridViewTextBoxColumn6.HeaderText = "ID_Productos";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 586);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(idVentasLabel);
            this.Controls.Add(this.idVentasTextBox);
            this.Controls.Add(iD_ClientesLabel);
            this.Controls.Add(this.iD_ClientesComboBox);
            this.Controls.Add(iD_EmpleadoLabel);
            this.Controls.Add(this.iD_EmpleadoComboBox);
            this.Controls.Add(nFacturaLabel);
            this.Controls.Add(this.nFacturaTextBox);
            this.Controls.Add(fecha_ventLabel);
            this.Controls.Add(this.fecha_ventDateTimePicker);
            this.Controls.Add(iDPagoLabel);
            this.Controls.Add(this.iDPagoComboBox);
            this.Controls.Add(iDTipoLabel);
            this.Controls.Add(this.tipodocumentoComboBox);
            this.Controls.Add(this.detalleVentaDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.condicionespagosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipodocumentoBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlDataSet controlDataSet;
        private System.Windows.Forms.BindingSource ventasBindingSource;
        private ControlDataSetTableAdapters.VentasTableAdapter ventasTableAdapter;
        private ControlDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource detalleVentaBindingSource;
        private ControlDataSetTableAdapters.DetalleVentaTableAdapter detalleVentaTableAdapter;
        private System.Windows.Forms.BindingSource detalleVentaBindingSource1;
        private System.Windows.Forms.DataGridView detalleVentaDataGridView;
        private ControlDataSet controlDataSet1;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private ControlDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private ControlDataSetTableAdapters.EmpleadoTableAdapter empleadoTableAdapter;
        private System.Windows.Forms.TextBox idVentasTextBox;
        private System.Windows.Forms.ComboBox iD_ClientesComboBox;
        private System.Windows.Forms.ComboBox iD_EmpleadoComboBox;
        private System.Windows.Forms.TextBox nFacturaTextBox;
        private System.Windows.Forms.DateTimePicker fecha_ventDateTimePicker;
        private System.Windows.Forms.ComboBox iDPagoComboBox;
        private System.Windows.Forms.ComboBox tipodocumentoComboBox;
        private System.Windows.Forms.BindingSource clienteBindingSource1;
        private System.Windows.Forms.BindingSource empleadoBindingSource1;
        private System.Windows.Forms.BindingSource condicionespagosBindingSource;
        private ControlDataSetTableAdapters.condiciones_pagosTableAdapter condiciones_pagosTableAdapter;
        private System.Windows.Forms.BindingSource tipodocumentoBindingSource;
        private ControlDataSetTableAdapters.Tipo_documentoTableAdapter tipo_documentoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalVenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblIvaVenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSumaVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblregistroxden;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}