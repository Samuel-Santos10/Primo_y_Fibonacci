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
    public partial class Impresion_Pedidos : Form
    {
        private int _IdPedidoClient = 0;
        public Impresion_Pedidos(int IdPedido)
        {
            InitializeComponent();
            _IdPedidoClient = IdPedido;
        }

        private void Impresion_Pedidos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ControlDataSet.ReportPedido' Puede moverla o quitarla según sea necesario.
            this.ReportPedidoTableAdapter.FillReportPedido(this.ControlDataSet.ReportPedido, _IdPedidoClient);

            this.reportViewer1.RefreshReport();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
