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
    public partial class Factura_Compra : Form
    {

        private int _IdFacturaC = 0;

        public Factura_Compra()
        {
            InitializeComponent();
        }

        private void factura_compraBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.factura_compraBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.controlDataSet);

        }

        private void Factura_Compra_Load(object sender, EventArgs e)
        {
            actualziarDs();
        }

        private void actualziarDs()
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'controlDataSet.condiciones_pagos' Puede moverla o quitarla según sea necesario.
                this.condiciones_pagosTableAdapter.Fill(this.controlDataSet.condiciones_pagos);
            // TODO: esta línea de código carga datos en la tabla 'controlDataSet.Tipo_documento' Puede moverla o quitarla según sea necesario.
            this.tipo_documentoTableAdapter.Fill(this.controlDataSet.Tipo_documento);
            // TODO: esta línea de código carga datos en la tabla 'controlDataSet.Proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(this.controlDataSet.Proveedor);
            // TODO: esta línea de código carga datos en la tabla 'controlDataSet.DFacturaCompra' Puede moverla o quitarla según sea necesario.
            this.dFacturaCompraTableAdapter.FillDFacturaCompra(this.controlDataSet.DFacturaCompra);
            // TODO: esta línea de código carga datos en la tabla 'controlDataSet.factura_compra' Puede moverla o quitarla según sea necesario.
            this.factura_compraTableAdapter.Fill(this.controlDataSet.factura_compra);

              totalizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void totalizar()
        {
            try
            {
                int desc = 0, nfilas = 0;
                double cantidad = 0, precio = 0, suma = 0, iva = 0, total = 0;
                nfilas = dFacturaCompraDataGridView.RowCount;
                DataGridViewRow fila = new DataGridViewRow();
                for (int i = 0; i < nfilas; i++)
                {
                    fila = dFacturaCompraDataGridView.Rows[i];
                    cantidad = double.Parse(fila.Cells["cantidad"].Value.ToString());
                    desc = int.Parse(fila.Cells["descuento"].Value.ToString());
                    precio = double.Parse(fila.Cells["precio"].Value.ToString());

                    suma += cantidad * precio * (1 - desc / 100);
                }
                iva = int.Parse(tipoventaComboBox.SelectedValue.ToString()) == 2 ? suma * 13 / 100 : 0;
                total = suma + iva;
                lblSumaCompra.Text = "$" + Math.Round(suma, 2);
                lblIvaCompra.Text = "$" + Math.Round(iva, 2);
                lblTotalCompra.Text = "$" + Math.Round(total, 2);

                lblregistroxden.Text = factura_compraBindingSource.Position + 1 + " de " + factura_compraBindingSource.Count;
            }
            catch (Exception e)
            {
                //eroor
            }
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            factura_compraBindingSource.MoveFirst();
            totalizar();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            factura_compraBindingSource.MovePrevious();
            totalizar();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            factura_compraBindingSource.MoveNext();
            totalizar();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            factura_compraBindingSource.MoveLast();
            totalizar();
        }

        private void habdes_controles(Boolean estado)
        {
            idProveedorComboBox.Enabled = !estado;
            fechafacturaDateTimePicker.Enabled = !estado;
            fechaODCDateTimePicker.Enabled = !estado;
            tipoventaComboBox.Enabled = !estado;
            tipoventaComboBox.Enabled = !estado;

            nfacturaTextBox.ReadOnly = estado;
            dFacturaCompraDataGridView.ReadOnly = estado;
            pnlProductosGrid.Visible = !estado;

            pnlNavegacion.Visible = estado;
            btnEliminar.Enabled = estado;
            btnBuscar.Enabled = estado;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (btnAgregar.Text == "Nuevo")
            {//nuevo
                btnAgregar.Text = "Guardar";
                btnModificar.Text = "Cancelar";

                habdes_controles(false);//habilitar los controles...
                factura_compraBindingSource.AddNew();//agregamos un registro nuevo...
            }
            else
            {//guardar
                _IdFacturaC = int.Parse(idFacturaCTextBox.Text);
                this.Validate();
                this.factura_compraBindingSource.EndEdit();

                /**
                 * Abrimos la conexion a la BD
                 */
                factura_compraTableAdapter.Connection.Open();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = factura_compraTableAdapter.Connection;

                if (_IdFacturaC > 0)
                {//modificando...
                    sqlCmd.CommandText = "delete from Dfactura_C where IdFacturaC=" + _IdFacturaC;
                    sqlCmd.ExecuteNonQuery();
                }
                else
                {//nuevo....
                    sqlCmd.CommandText = "select ident_current('factura_compra') + 1 AS IdFacturaC";
                    _IdFacturaC = int.Parse(sqlCmd.ExecuteScalar().ToString());
                }
                int nfilas = dFacturaCompraDataGridView.RowCount;
                string[,] Dfactura_C = new string[nfilas, 4];
                DataGridViewRow fila = new DataGridViewRow();
                for (int i = 0; i < nfilas; i++)
                {
                    fila = dFacturaCompraDataGridView.Rows[i];

                    Dfactura_C[i, 0] = fila.Cells["IdProducto"].Value.ToString();
                    Dfactura_C[i, 1] = fila.Cells["cantidad"].Value.ToString();
                    Dfactura_C[i, 2] = fila.Cells["precio"].Value.ToString();
                    Dfactura_C[i, 3] = fila.Cells["descuento"].Value.ToString();
                }
                this.tableAdapterManager.UpdateAll(this.controlDataSet);

                for (int i = 0; i < nfilas; i++)
                {
                    dfactura_CTableAdapter1.Insert(
                        _IdFacturaC,
                        int.Parse(Dfactura_C[i, 0]),
                        int.Parse(Dfactura_C[i, 1]),
                        decimal.Parse(Dfactura_C[i, 2]),
                        int.Parse(Dfactura_C[i, 3])
                    );
                }
                factura_compraTableAdapter.Connection.Close();
                actualziarDs();
                factura_compraBindingSource.MoveLast();

                habdes_controles(true);
                btnAgregar.Text = "Nuevo";
                btnModificar.Text = "Modificar";
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (btnModificar.Text == "Modificar")
            {//modificar
                btnAgregar.Text = "Guardar";
                btnModificar.Text = "Cancelar";

                habdes_controles(false);//habilitar los controles...

            }
            else
            {//cancelar
                factura_compraBindingSource.CancelEdit();
                dFacturaCompraBindingSource.CancelEdit();

                habdes_controles(true);//deshabilitar los controles...
                btnAgregar.Text = "Nuevo";
                btnModificar.Text = "Modificar";
            }
        }

        private void btnAgregarProductosGrid_Click(object sender, EventArgs e)
        {
            Busqueda_Productos buscarProductos = new Busqueda_Productos();
            buscarProductos.ShowDialog();
            if (buscarProductos._IdProductos > 0)
            {
                dFacturaCompraBindingSource.AddNew();

                dFacturaCompraDataGridView.CurrentRow.Cells["IdProducto"].Value = buscarProductos._IdProductos;
                dFacturaCompraDataGridView.CurrentRow.Cells["codigo"].Value = buscarProductos._codigoProducto;
                dFacturaCompraDataGridView.CurrentRow.Cells["nombre"].Value = buscarProductos._nombreProducto;
                dFacturaCompraDataGridView.CurrentRow.Cells["cantidad"].Value = 1;
            }
        }

        private void btnQuitarProductosGrid_Click(object sender, EventArgs e)
        {
            if (dFacturaCompraDataGridView.RowCount > 0)
            {
                dFacturaCompraDataGridView.Rows.Remove(dFacturaCompraDataGridView.CurrentRow);
            }
        }
    }
}
