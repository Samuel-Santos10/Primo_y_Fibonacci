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
    public partial class Factura_Venta : Form
    {
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
    }
}
