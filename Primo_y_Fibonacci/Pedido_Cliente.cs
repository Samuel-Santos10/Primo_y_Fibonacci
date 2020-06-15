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
    public partial class Pedido_Cliente : Form
    {
        private int _IdPedidoClient = 0;

        public Pedido_Cliente()
        {
            InitializeComponent();
        }

        private void pedido_ClienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pedido_ClienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.controlDataSet);

        }

        private void pedido_ClienteBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.pedido_ClienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.controlDataSet);

        }

        private void Pedido_Cliente_Load(object sender, EventArgs e)
        {
            actualziarDs();
        }

        private void actualziarDs()
        {
         try
                   {
                     // TODO: esta línea de código carga datos en la tabla 'controlDataSet.Empleado' Puede moverla o quitarla según sea necesario.
                     this.empleadoTableAdapter.Fill(this.controlDataSet.Empleado);
                    // TODO: esta línea de código carga datos en la tabla 'controlDataSet.Cliente' Puede moverla o quitarla según sea necesario.
                    this.clienteTableAdapter.Fill(this.controlDataSet.Cliente);
                    // TODO: esta línea de código carga datos en la tabla 'controlDataSet.DetallePedido' Puede moverla o quitarla según sea necesario.
                    this.detallePedidoTableAdapter.FillDetallePedidoCliente(this.controlDataSet.DetallePedido);
           
                        // TODO: esta línea de código carga datos en la tabla 'controlDataSet.Pedido_Cliente' Puede moverla o quitarla según sea necesario.
                        this.pedido_ClienteTableAdapter.Fill(this.controlDataSet.Pedido_Cliente);

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
            double cantidad = 0, precio = 0, suma = 0, total = 0;
            nfilas = detallePedidoDataGridView.RowCount;
            DataGridViewRow fila = new DataGridViewRow();
            for (int i = 0; i < nfilas; i++)
            {
                fila = detallePedidoDataGridView.Rows[i];
               cantidad = double.Parse(fila.Cells["cantidad"].Value.ToString());
                desc = int.Parse(fila.Cells["descuento"].Value.ToString());
                precio = double.Parse(fila.Cells["precio"].Value.ToString());

                suma += cantidad * precio * (1 - desc / 100);
            }
            /*iva = int.Parse(tipodocumentoComboBox.SelectedValue.ToString()) == 2 ? suma * 13 / 100 : 0;
            total = suma + iva;
            lblSumaVenta.Text = "$" + Math.Round(suma, 2);
            lblIvaVenta.Text = "$" + Math.Round(iva, 2);
            lblTotalVenta.Text = "$" + Math.Round(total, 2);*/

            lblregistroxden.Text = pedido_ClienteBindingSource.Position + 1 + " de " + pedido_ClienteBindingSource.Count;
            }
            catch (Exception e)
            {
                //erroor
            }
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            pedido_ClienteBindingSource.MoveFirst();
            totalizar();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            pedido_ClienteBindingSource.MovePrevious();
            totalizar();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            pedido_ClienteBindingSource.MoveNext();
            totalizar();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            pedido_ClienteBindingSource.MoveLast();
            totalizar();
        }

        private void habdes_controles(Boolean estado)
        {
            id_ClienteComboBox.Enabled = !estado;
            id_EmpleadoComboBox.Enabled = !estado;
            fecha_ordenDateTimePicker.Enabled = !estado;
            fecha_requeridaDateTimePicker.Enabled = !estado;

            direccionTextBox.ReadOnly = estado;
            detallePedidoDataGridView.ReadOnly = estado;
            pnlProductosGrid.Visible = !estado;

            pnlNavegacion.Visible = estado;
            btnEliminar.Enabled = estado;
            btnBuscar.Enabled = estado;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (btnAgregar.Text == "Nuevo")
            {//nuevo
                btnAgregar.Text = "Guardar";
                btnModificar.Text = "Cancelar";

                habdes_controles(false);//habilitar los controles...
                pedido_ClienteBindingSource.AddNew();//agregamos un registro nuevo...
            }
            else
            {//guardar
                _IdPedidoClient = int.Parse(idPedidoClientTextBox.Text);
                this.Validate();
                this.pedido_ClienteBindingSource.EndEdit();

                /**
                 * Abrimos la conexion a la BD
                 */
                pedido_ClienteTableAdapter.Connection.Open();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = pedido_ClienteTableAdapter.Connection;

                if (_IdPedidoClient > 0)
                {//modificando...
                    sqlCmd.CommandText = "delete from Detalle_Pedido_Client where IDPedidoC=" + _IdPedidoClient;
                    sqlCmd.ExecuteNonQuery();
                }
                else
                {//nuevo....
                    sqlCmd.CommandText = "select ident_current('Pedido_Cliente') + 1 AS IdPedidoClient";
                    _IdPedidoClient = int.Parse(sqlCmd.ExecuteScalar().ToString());
                }
                int nfilas = detallePedidoDataGridView.RowCount;
                string[,] Detalle_Pedido_Client = new string[nfilas, 5];
                DataGridViewRow fila = new DataGridViewRow();
                for (int i = 0; i < nfilas; i++)
                {
                    fila = detallePedidoDataGridView.Rows[i];

                    Detalle_Pedido_Client[i, 0] = fila.Cells["IdProducto"].Value.ToString();
                    Detalle_Pedido_Client[i, 1] = fila.Cells["cantidad"].Value.ToString();
                    Detalle_Pedido_Client[i, 2] = fila.Cells["precio"].Value.ToString();
                    Detalle_Pedido_Client[i, 3] = fila.Cells["descuento"].Value.ToString();
                    Detalle_Pedido_Client[i, 4] = fila.Cells["precio_orden"].Value.ToString();
                }
                this.tableAdapterManager.UpdateAll(this.controlDataSet);

                for (int i = 0; i < nfilas; i++)
                {
                    detalle_Pedido_ClientTableAdapter1.Insert(
                        _IdPedidoClient,
                        int.Parse(Detalle_Pedido_Client[i, 0]),
                        int.Parse(Detalle_Pedido_Client[i, 1]),
                        decimal.Parse(Detalle_Pedido_Client[i, 2]),
                        int.Parse(Detalle_Pedido_Client[i, 3]),
                        decimal.Parse(Detalle_Pedido_Client[i, 4])
                    );
                }
                pedido_ClienteTableAdapter.Connection.Close();
                actualziarDs();
                pedido_ClienteBindingSource.MoveLast();

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
                pedido_ClienteBindingSource.CancelEdit();
                detallePedidoBindingSource.CancelEdit();

                habdes_controles(true);//deshabilitar los controles...
                btnAgregar.Text = "Nuevo";
                btnModificar.Text = "Modificar";
            }
        }

        private void btnAgregarProductosGrid_Click(object sender, EventArgs e)
        {
            Busqueda_Productos buscarProductos = new Busqueda_Productos();
            buscarProductos.ShowDialog();
            if (buscarProductos._IdProductos > 0){
                detallePedidoBindingSource.AddNew();

                detallePedidoDataGridView.CurrentRow.Cells["IdProducto"].Value = buscarProductos._IdProductos;
                detallePedidoDataGridView.CurrentRow.Cells["codigo"].Value = buscarProductos._codigoProducto;
                detallePedidoDataGridView.CurrentRow.Cells["nombre"].Value = buscarProductos._nombreProducto;
                detallePedidoDataGridView.CurrentRow.Cells["cantidad"].Value = 1;
            }
        }

        private void btnQuitarProductosGrid_Click(object sender, EventArgs e)
        {
            if (detallePedidoDataGridView.RowCount > 0)
            {
                detallePedidoDataGridView.Rows.Remove(detallePedidoDataGridView.CurrentRow);
            }
        }
    }
}
