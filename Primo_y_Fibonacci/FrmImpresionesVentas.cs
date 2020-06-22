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
    public partial class FrmImpresionesVentas : Form
    {
        private int _idVentas = 0;
        public FrmImpresionesVentas(int idVen)
        {
            InitializeComponent();
            _idVentas = idVen;
        }

        private void FrmImpresionesVentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ControlDataSet.ReportVentas' Puede moverla o quitarla según sea necesario.
            this.ReportVentasTableAdapter.FillRptVentas(this.ControlDataSet.ReportVentas,_idVentas );

            this.reportViewer1.RefreshReport();
        }
    }
}
