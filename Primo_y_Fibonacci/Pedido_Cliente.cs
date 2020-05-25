using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primo_y_Fibonacci
{
    public partial class Pedido_Cliente : Form
    {
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
            // TODO: esta línea de código carga datos en la tabla 'controlDataSet.Tipo_documento' Puede moverla o quitarla según sea necesario.
            this.tipo_documentoTableAdapter.Fill(this.controlDataSet.Tipo_documento);
            // TODO: esta línea de código carga datos en la tabla 'controlDataSet.condiciones_pagos' Puede moverla o quitarla según sea necesario.
            this.condiciones_pagosTableAdapter.Fill(this.controlDataSet.condiciones_pagos);
            // TODO: esta línea de código carga datos en la tabla 'controlDataSet.Empleado' Puede moverla o quitarla según sea necesario.
            this.empleadoTableAdapter.Fill(this.controlDataSet.Empleado);
            // TODO: esta línea de código carga datos en la tabla 'controlDataSet.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.controlDataSet.Cliente);
            // TODO: esta línea de código carga datos en la tabla 'controlDataSet.DetallePedido' Puede moverla o quitarla según sea necesario.
            this.detallePedidoTableAdapter.FillDetallePedidoCliente(this.controlDataSet.DetallePedido);

            try
            {
                // TODO: esta línea de código carga datos en la tabla 'controlDataSet.Pedido_Cliente' Puede moverla o quitarla según sea necesario.
                this.pedido_ClienteTableAdapter.Fill(this.controlDataSet.Pedido_Cliente);
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
            iva = int.Parse(tipodocumentoComboBox.SelectedValue.ToString()) == 2 ? suma * 13 / 100 : 0;
            total = suma + iva;
            lblSumaVenta.Text = "$" + Math.Round(suma, 2);
            lblIvaVenta.Text = "$" + Math.Round(iva, 2);
            lblTotalVenta.Text = "$" + Math.Round(total, 2);

            lblregistroxden.Text = pedido_ClienteBindingSource.Position + 1 + " de " + pedido_ClienteBindingSource.Count;
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

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
