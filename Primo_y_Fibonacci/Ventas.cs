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
    public partial class Ventas : Form
    {
        private int _ID_Ventas = 0;
        public Ventas()
        {
            InitializeComponent();
        }

        private void ventasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ventasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.controlDataSet);

        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            actualizarDs();
        }

        private void actualizarDs()
        {

            try
            {
                // TODO: esta línea de código carga datos en la tabla 'controlDataSet1.Tipo_documento' Puede moverla o quitarla según sea necesario.
                this.tipo_documentoTableAdapter.Fill(this.controlDataSet1.Tipo_documento);
            // TODO: esta línea de código carga datos en la tabla 'controlDataSet1.condiciones_pagos' Puede moverla o quitarla según sea necesario.
            this.condiciones_pagosTableAdapter.Fill(this.controlDataSet1.condiciones_pagos);
            // TODO: esta línea de código carga datos en la tabla 'controlDataSet1.Empleado' Puede moverla o quitarla según sea necesario.
            this.empleadoTableAdapter.Fill(this.controlDataSet1.Empleado);
            // TODO: esta línea de código carga datos en la tabla 'controlDataSet1.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.controlDataSet1.Cliente);
            // TODO: esta línea de código carga datos en la tabla 'controlDataSet.DetalleVenta' Puede moverla o quitarla según sea necesario.
            this.detalleVentaTableAdapter.FillDetalleVenta(this.controlDataSet.DetalleVenta);
                // TODO: esta línea de código carga datos en la tabla 'controlDataSet.Ventas' Puede moverla o quitarla según sea necesario.

                this.ventasTableAdapter.Fill(this.controlDataSet.Ventas);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            totalizar();
        }


        private void totalizar()
        {
            int desc = 0, nfilas = 0;
            double cantidad = 0, precio = 0, suma = 0, iva = 0, total = 0;
            nfilas = detalleVentaDataGridView.RowCount;
            DataGridViewRow fila = new DataGridViewRow();
            for (int i = 0; i < nfilas; i++)
            {
                fila = detalleVentaDataGridView.Rows[i];
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

            lblregistroxden.Text = ventasBindingSource.Position + 1 + " de " + ventasBindingSource.Count;
        }


        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            ventasBindingSource.MovePrevious();
            totalizar();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            ventasBindingSource.MoveNext();
            totalizar();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            ventasBindingSource.MoveLast();
            totalizar();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            ventasBindingSource.MoveFirst();
            totalizar();
        }

        private void habdes_controles(Boolean estado)
        {
            iD_ClientesComboBox.Enabled = !estado;
            iD_EmpleadoComboBox.Enabled = !estado;
            fecha_ventDateTimePicker.Enabled = !estado;
            iDPagoComboBox.Enabled = !estado;
            tipodocumentoComboBox.Enabled = !estado;

            nFacturaTextBox.ReadOnly = estado;
            detalleVentaDataGridView.ReadOnly = estado;
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
                ventasBindingSource.AddNew();//agregamos un registro nuevo...
            }
            else
            {//guardar
                _ID_Ventas = int.Parse(idVentasTextBox.Text);
                this.Validate();
                this.ventasBindingSource.EndEdit();

                /**
                 * Abrimos la conexion a la BD
                 */
                ventasTableAdapter.Connection.Open();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = ventasTableAdapter.Connection;

                if (_ID_Ventas > 0)
                {//modificando...
                    sqlCmd.CommandText = "delete from Detalle_Venta where ID_Ventas=" + _ID_Ventas;
                    sqlCmd.ExecuteNonQuery();
                }
                else
                {//nuevo....
                    sqlCmd.CommandText = "select ident_current('Ventas') + 1 AS IdVentas";
                    _ID_Ventas = int.Parse(sqlCmd.ExecuteScalar().ToString());
                }
                int nfilas = detalleVentaDataGridView.RowCount;
                string[,] Detalle_Venta = new string[nfilas, 5];
                DataGridViewRow fila = new DataGridViewRow();
                for (int i = 0; i < nfilas; i++)
                {
                    fila = detalleVentaDataGridView.Rows[i];

                    Detalle_Venta[i, 0] = fila.Cells["ID_Productos"].Value.ToString();
                    Detalle_Venta[i, 1] = fila.Cells["cantidad"].Value.ToString();
                    Detalle_Venta[i, 2] = fila.Cells["precio"].Value.ToString();
                    Detalle_Venta[i, 3] = fila.Cells["descuento"].Value.ToString();
                    Detalle_Venta[i, 4] = fila.Cells["unidades"].Value.ToString();


                }
                this.tableAdapterManager.UpdateAll(this.controlDataSet);

                for (int i = 0; i < nfilas; i++)
                {
                    detalle_VentaTableAdapter1.Insert(
                        _ID_Ventas,
                        int.Parse(Detalle_Venta[i, 0]),
                        int.Parse(Detalle_Venta[i, 1]),
                        decimal.Parse(Detalle_Venta[i, 2]),
                        int.Parse(Detalle_Venta[i, 3]),
                        int.Parse(Detalle_Venta[i, 4])
                    );
                }
                ventasTableAdapter.Connection.Close();
                actualizarDs();
                ventasBindingSource.MoveLast();

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
                ventasBindingSource.CancelEdit();
                detalleVentaBindingSource.CancelEdit();

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
                detalleVentaBindingSource1.AddNew();

                detalleVentaDataGridView.CurrentRow.Cells["ID_Productos"].Value = buscarProductos._IdProductos;
                detalleVentaDataGridView.CurrentRow.Cells["codigo"].Value = buscarProductos._codigoProducto;
                detalleVentaDataGridView.CurrentRow.Cells["nombre"].Value = buscarProductos._nombreProducto;
                detalleVentaDataGridView.CurrentRow.Cells["cantidad"].Value = 1;
            }
        }

        private void btnQuitarProductosGrid_Click(object sender, EventArgs e)
        {
            if (detalleVentaDataGridView.RowCount > 0)
            {
                detalleVentaDataGridView.Rows.Remove(detalleVentaDataGridView.CurrentRow);
            }
        }
    }
}
