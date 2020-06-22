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
    public partial class Impresion_Cliente : Form
    {
        private int _IdCliente = 0;
        public Impresion_Cliente(int IdCliente)
        {
            InitializeComponent();
            _IdCliente = IdCliente;
        }

        private void Impresion_Cliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ControlDataSet.ReportCliente' Puede moverla o quitarla según sea necesario.
            this.ReportClienteTableAdapter.FillReportCliente(this.ControlDataSet.ReportCliente, _IdCliente);
            this.reportViewer1.RefreshReport();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
