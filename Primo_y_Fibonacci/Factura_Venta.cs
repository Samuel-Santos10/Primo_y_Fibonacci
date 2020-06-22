using Primo_y_Fibonacci.ControlDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primo_y_Fibonacci
{
    public partial class Factura_Venta : Form
    {

        private int _IdFacturaV = 0;

        public Factura_Venta()
        {
            InitializeComponent();
        }

        private void factura_ventaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.factura_ventaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.controlDataSet);

        }

        private void actualziarDs()
        {
            try
            {

        // TODO: esta línea de código carga datos en la tabla 'controlDataSet.condiciones_pagos' Puede moverla o quitarla según sea necesario.
        this.condiciones_pagosTableAdapter.Fill(this.controlDataSet.condiciones_pagos);
        // TODO: esta línea de código carga datos en la tabla 'controlDataSet.Tipo_documento' Puede moverla o quitarla según sea necesario.
        this.tipo_documentoTableAdapter.Fill(this.controlDataSet.Tipo_documento);
        // TODO: esta línea de código carga datos en la tabla 'controlDataSet.Empleado' Puede moverla o quitarla según sea necesario.
        this.empleadoTableAdapter.Fill(this.controlDataSet.Empleado);
        // TODO: esta línea de código carga datos en la tabla 'controlDataSet.Cliente' Puede moverla o quitarla según sea necesario.
        this.clienteTableAdapter.Fill(this.controlDataSet.Cliente);
        // TODO: esta línea de código carga datos en la tabla 'controlDataSet.DFacturaVenta' Puede moverla o quitarla según sea necesario.
        this.dFacturaVentaTableAdapter.FillDFacturaVenta(this.controlDataSet.DFacturaVenta);
        // TODO: esta línea de código carga datos en la tabla 'controlDataSet.factura_venta' Puede moverla o quitarla según sea necesario.
        this.factura_ventaTableAdapter.Fill(this.controlDataSet.factura_venta);

                totalizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Factura_Venta_Load(object sender, EventArgs e)
        {
            factura_ventaTableAdapter1.Connection.Close();
            actualziarDs();
        }

        private void totalizar()
        {
            try
            {
                int desc = 0, nfilas = 0;
                double cantidad = 0, precio = 0, suma = 0, iva = 0, total = 0;
                nfilas = dFacturaVentaDataGridView.RowCount;
                DataGridViewRow fila = new DataGridViewRow();
                for (int i = 0; i < nfilas; i++)
                {
                    fila = dFacturaVentaDataGridView.Rows[i];
                    cantidad = double.Parse(fila.Cells["cantidad"].Value.ToString());
                    desc = int.Parse(fila.Cells["descuento"].Value.ToString());
                    precio = double.Parse(fila.Cells["precio"].Value.ToString());

                    suma += cantidad * precio * (1 - desc / 100);
                }
                iva = int.Parse(tipodocumentoComboBox.SelectedValue.ToString()) == 2 ? suma * 13 / 100 : 0;
                total = suma + iva;
                lblSumaVenta.Text = "$" + Math.Round(suma, 2);
                lblIvaVenta.Text = "$" + Math.Round(iva, 2);
                lblTotalVenta.Text = "$" + Math.Round(total, 2);

                lblregistroxden.Text = factura_ventaBindingSource.Position+ 1 + " de " + factura_ventaBindingSource.Count;
            }
            catch (Exception e)
            {
                //erroor
            }
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            factura_ventaBindingSource.MoveFirst();
            totalizar();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            factura_ventaBindingSource.MovePrevious();
            totalizar();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            factura_ventaBindingSource.MoveNext();
            totalizar();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            factura_ventaBindingSource.MoveLast();
            totalizar();
        }

        private void habdes_controles(Boolean estado)
        {
            idClienteComboBox.Enabled = !estado;
            idEmpleadoComboBox.Enabled = !estado;
            fecha_facturaDateTimePicker.Enabled = !estado;
            tipoventaComboBox.Enabled = !estado;
            tipodocumentoComboBox.Enabled = !estado;

            nfacturaTextBox.ReadOnly = estado;
            dFacturaVentaDataGridView.ReadOnly = estado;
            pnlProductosGrid.Visible = !estado;

            pnlNavegacion.Visible = estado;
            btnEliminar.Enabled = estado;
            btnBuscar.Enabled = estado;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (lblop.Text == "Nuevo")
            {//nuevo
                lblop.Text = "Guardar";
                lblop2.Text = "Cancelar";

                habdes_controles(false);//habilitar los controles...
                factura_ventaBindingSource.AddNew();//agregamos un registro nuevo...
            }
            else
            {//guardar
                _IdFacturaV = int.Parse(IdFacturaVTextBox.Text);
                this.Validate();
                this.factura_ventaBindingSource.EndEdit();

                /**
                 * Abrimos la conexion a la BD
                 */
                factura_ventaTableAdapter.Connection.Open();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = factura_ventaTableAdapter.Connection;

                if (_IdFacturaV > 0)
                {//modificando...
                    sqlCmd.CommandText = "delete from DFactura_V where IdFacturaV=" + _IdFacturaV;
                    sqlCmd.ExecuteNonQuery();
                }
                else
                {//nuevo....
                    sqlCmd.CommandText = "select ident_current('factura_venta') + 1 AS IdFacturaV";
                    _IdFacturaV = int.Parse(sqlCmd.ExecuteScalar().ToString());
                }
                int nfilas = dFacturaVentaDataGridView.RowCount;
                string[,] DFactura_V = new string[nfilas, 5];
                DataGridViewRow fila = new DataGridViewRow();
                for (int i = 0; i < nfilas; i++)
                {
                    fila = dFacturaVentaDataGridView.Rows[i];

                    DFactura_V[i, 0] = fila.Cells["Idproducto"].Value.ToString();
                    DFactura_V[i, 1] = fila.Cells["cantidad"].Value.ToString();
                    DFactura_V[i, 2] = fila.Cells["precio"].Value.ToString();
                    DFactura_V[i, 3] = fila.Cells["descuento"].Value.ToString();
                    DFactura_V[i, 4] = fila.Cells["unidades"].Value.ToString();
                }
                this.tableAdapterManager.UpdateAll(this.controlDataSet);

                for (int i = 0; i < nfilas; i++)
                {
                        dFactura_VTableAdapter1.Insert(
                        _IdFacturaV,
                        int.Parse(DFactura_V[i, 0]),
                        int.Parse(DFactura_V[i, 1]),
                        decimal.Parse(DFactura_V[i, 2]),
                        int.Parse(DFactura_V[i, 3]),
                        int.Parse(DFactura_V[i, 4]),
                        int.Parse(DFactura_V[i, 5])
                    );
                }
                factura_ventaTableAdapter1.Connection.Close();
                actualziarDs();
                factura_ventaBindingSource.MoveLast();
                habdes_controles(true);
                lblop.Text = "Nuevo";
                lblop2.Text = "Modificar";
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (lblop2.Text == "Modificar")
            {//modificar
                lblop.Text = "Guardar";
                lblop2.Text = "Cancelar";

                habdes_controles(false);//habilitar los controles...

            }
            else
            {//cancelar
                factura_ventaBindingSource.CancelEdit();
                dFacturaVentaBindingSource.CancelEdit();

                habdes_controles(true);//deshabilitar los controles...
                lblop.Text = "Nuevo";
                lblop2.Text = "Modificar";
            }
        }

        private void btnAgregarProductosGrid_Click(object sender, EventArgs e)
        {
            Busqueda_Productos buscarProductos = new Busqueda_Productos();
            buscarProductos.ShowDialog();
            if (buscarProductos._IdProductos > 0)
            {
                dFacturaVentaBindingSource.AddNew();

                dFacturaVentaDataGridView.CurrentRow.Cells["IdProducto"].Value = buscarProductos._IdProductos;
                dFacturaVentaDataGridView.CurrentRow.Cells["codigo"].Value = buscarProductos._codigoProducto;
                dFacturaVentaDataGridView.CurrentRow.Cells["nombre"].Value = buscarProductos._nombreProducto;
                dFacturaVentaDataGridView.CurrentRow.Cells["cantidad"].Value = 1;
            }
        }

        private void btnQuitarProductosGrid_Click(object sender, EventArgs e)
        {
            if (dFacturaVentaDataGridView.RowCount > 0)
            {
                dFacturaVentaDataGridView.Rows.Remove(dFacturaVentaDataGridView.CurrentRow);
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
