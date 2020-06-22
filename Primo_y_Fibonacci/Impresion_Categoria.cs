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
    public partial class Impresion_Categoria : Form
    {
        private int _IdCategoria = 0;

        public Impresion_Categoria(int IdCatego)
        {
            InitializeComponent();
            _IdCategoria = IdCatego;
        }

        private void Impresion_Categoria_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ControlDataSet.ReportCatego' Puede moverla o quitarla según sea necesario.
            this.ReportCategoTableAdapter.FillReportCatego(this.ControlDataSet.ReportCatego, _IdCategoria);
            this.reportViewer1.RefreshReport();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
