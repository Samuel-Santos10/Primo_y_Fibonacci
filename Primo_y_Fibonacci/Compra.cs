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
    public partial class Compra : Form
    {
        private int _ID_Compra = 0;

        public Compra()
        {
            InitializeComponent();
        }

        private void compra_OrdenesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.compra_OrdenesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.controlDataSet);

        }

        private void actualizarDs()
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'controlDataSet.Tipo_documento' Puede moverla o quitarla según sea necesario.
                this.tipo_documentoTableAdapter.Fill(this.controlDataSet.Tipo_documento);
            // TODO: esta línea de código carga datos en la tabla 'controlDataSet.condiciones_pagos' Puede moverla o quitarla según sea necesario.
            this.condiciones_pagosTableAdapter.Fill(this.controlDataSet.condiciones_pagos);
            // TODO: esta línea de código carga datos en la tabla 'controlDataSet.Proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(this.controlDataSet.Proveedor);
            // TODO: esta línea de código carga datos en la tabla 'controlDataSet.DetalleCompra' Puede moverla o quitarla según sea necesario.
            this.detalleCompraTableAdapter.FillDetalleCompra(this.controlDataSet.DetalleCompra);
            // TODO: esta línea de código carga datos en la tabla 'controlDataSet.Compra_Ordenes' Puede moverla o quitarla según sea necesario.
            this.compra_OrdenesTableAdapter.Fill(this.controlDataSet.Compra_Ordenes);
            // TODO: esta línea de código carga datos en la tabla 'controlDataSet.detalle_Compra' Puede moverla o quitarla según sea necesario.
            this.detalleCompraTableAdapter.FillDetalleCompra(this.controlDataSet.DetalleCompra);
            // TODO: esta línea de código carga datos en la tabla 'controlDataSet.Compra_Ordenes' Puede moverla o quitarla según sea necesario.
            this.compra_OrdenesTableAdapter.Fill(this.controlDataSet.Compra_Ordenes);

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            totalizar();
        }

        private void Compra_Load(object sender, EventArgs e)
        {
            actualizarDs();
        }

        private void totalizar()
        {
            int desc = 0, nfilas = 0;
            double cantidad = 0, precio = 0, suma = 0, iva = 0, total = 0;
            nfilas = detalleCompraDataGridView.RowCount;
            DataGridViewRow fila = new DataGridViewRow();
            for (int i = 0; i < nfilas; i++)
            {
                fila = detalleCompraDataGridView.Rows[i];
                cantidad = double.Parse(fila.Cells["cantid_compra"].Value.ToString());
                desc = int.Parse(fila.Cells["descuento"].Value.ToString());
                precio = double.Parse(fila.Cells["precio"].Value.ToString());

                suma += cantidad * precio * (1 - desc / 100);
            }
            iva = int.Parse(tipodocumentoComboBox.SelectedValue.ToString()) == 2 ? suma * 13 / 100 : 0; total = suma + iva;
            lblSumaCompra.Text = "$" + Math.Round(suma, 2);
            lblIvaCompra.Text = "$" + Math.Round(iva, 2);
            lblTotalCompra.Text = "$" + Math.Round(total, 2);

            lblregistroxden.Text = compra_OrdenesBindingSource.Position + 1 + " de " + compra_OrdenesBindingSource.Count;
        }


        private void compra_OrdenesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.compra_OrdenesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.controlDataSet);

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            compra_OrdenesBindingSource.MoveFirst();
            totalizar();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            compra_OrdenesBindingSource.MoveNext();
            totalizar();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            compra_OrdenesBindingSource.MoveLast();
            totalizar();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            compra_OrdenesBindingSource.MovePrevious();
            totalizar();
        }

        private void habdes_controles(Boolean estado)
        {
            id_ProveedorComboBox.Enabled = !estado;
            fechaacompraDateTimePicker.Enabled = !estado;
            iDPagoComboBox.Enabled = !estado;
            tipodocumentoComboBox.Enabled = !estado;

            nfacturaTextBox.ReadOnly = estado;
            detalleCompraDataGridView.ReadOnly = estado;
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
                compra_OrdenesBindingSource.AddNew();//agregamos un registro nuevo...
            }
            else
            {//guardar
                _ID_Compra = int.Parse(idCompraTextBox.Text);
                this.Validate();
                this.compra_OrdenesBindingSource.EndEdit();

                /**
                 * Abrimos la conexion a la BD
                 */
                compra_OrdenesTableAdapter.Connection.Open();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = compra_OrdenesTableAdapter.Connection;

                if (_ID_Compra > 0)
                {//modificando...
                    sqlCmd.CommandText = "delete from detalle_Compra where ID_Compra=" + _ID_Compra;
                    sqlCmd.ExecuteNonQuery();
                }
                else
                {//nuevo....
                    sqlCmd.CommandText = "select ident_current('Compra_Ordenes') + 1 AS IdCompra";
                    _ID_Compra = int.Parse(sqlCmd.ExecuteScalar().ToString());
                }
                int nfilas = detalleCompraDataGridView.RowCount;
                string[,] detalle_Compra = new string[nfilas, 5];
                DataGridViewRow fila = new DataGridViewRow();
                for (int i = 0; i < nfilas; i++)
                {
                    fila = detalleCompraDataGridView.Rows[i];

                    detalle_Compra[i, 0] = fila.Cells["ID_producto"].Value.ToString();
                    detalle_Compra[i, 1] = fila.Cells["cantid_compra"].Value.ToString();
                    detalle_Compra[i, 2] = fila.Cells["precio"].Value.ToString();
                    detalle_Compra[i, 3] = fila.Cells["descuento"].Value.ToString();
                    detalle_Compra[i, 4] = fila.Cells["unidades"].Value.ToString();
                }

                this.tableAdapterManager.UpdateAll(this.controlDataSet);

                for (int i = 0; i < nfilas; i++)
                {
                    detalle_CompraTableAdapter1.Insert(
                        _ID_Compra,
                        int.Parse(detalle_Compra[i, 0]),
                        int.Parse(detalle_Compra[i, 1]),
                        decimal.Parse(detalle_Compra[i, 2]),
                        int.Parse(detalle_Compra[i, 3]),
                        int.Parse(detalle_Compra[i, 4])
                    );
                }
                compra_OrdenesTableAdapter.Connection.Close();
                actualizarDs();
                compra_OrdenesBindingSource.MoveLast();

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
                compra_OrdenesBindingSource.CancelEdit();
                detalleCompraBindingSource.CancelEdit();

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
                detalleCompraBindingSource.AddNew();

                detalleCompraDataGridView.CurrentRow.Cells["ID_Producto"].Value = buscarProductos._IdProductos;
                detalleCompraDataGridView.CurrentRow.Cells["codigo"].Value = buscarProductos._codigoProducto;
                detalleCompraDataGridView.CurrentRow.Cells["nombre"].Value = buscarProductos._nombreProducto;
                detalleCompraDataGridView.CurrentRow.Cells["cantid_compra"].Value = 1;
            }
        }

        private void btnQuitarProductosGrid_Click(object sender, EventArgs e)
        {
            if (detalleCompraDataGridView.RowCount > 0)
            {
                detalleCompraDataGridView.Rows.Remove(detalleCompraDataGridView.CurrentRow);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmImpresionCompra imprimir = new FrmImpresionCompra(int.Parse(idCompraTextBox.Text));
            imprimir.ShowDialog();
        }
    }
}
