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
    public partial class Impresion_Proveedor : Form
    {
        private int _IdProveedor = 0;
        public Impresion_Proveedor(int IdProvee)
        {
            InitializeComponent();
            _IdProveedor = IdProvee;
        }

        private void Impresion_Proveedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ControlDataSet.ReportProveedor' Puede moverla o quitarla según sea necesario.
            this.ReportProveedorTableAdapter.FillReportProveedor(this.ControlDataSet.ReportProveedor, _IdProveedor);

            this.reportViewer1.RefreshReport();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
