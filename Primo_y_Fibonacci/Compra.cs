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
    public partial class Compra : Form
    {
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

        private void Compra_Load(object sender, EventArgs e)
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
           
            try
            {

            
            // TODO: esta línea de código carga datos en la tabla 'controlDataSet.Compra_Ordenes' Puede moverla o quitarla según sea necesario.
            this.compra_OrdenesTableAdapter.Fill(this.controlDataSet.Compra_Ordenes);

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            totalizar();
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
                cantidad = double.Parse(fila.Cells["cantidad"].Value.ToString());
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

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            compra_OrdenesBindingSource.MoveFirst();
            totalizar();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            compra_OrdenesBindingSource.MovePrevious();
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

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
