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
  
    public partial class FrmImpresionCompra : Form
    {
        private int _idCompra = 0;
        public FrmImpresionCompra(int idcomp)
        {
            InitializeComponent();
            _idCompra = idcomp;
        }

        private void FrmImpresionCompra_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ControlDataSet.ReportCompra' Puede moverla o quitarla según sea necesario.
            this.ReportCompraTableAdapter.FillRptCompra(this.ControlDataSet.ReportCompra,_idCompra );

            this.reportViewer1.RefreshReport();
        }
    }
}
