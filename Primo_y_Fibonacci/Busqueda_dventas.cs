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
    public partial class Busqueda_dventas : Form
    {

        ConexionClass objConexion = new ConexionClass();
        public int _IdDetalleVenta;

        public Busqueda_dventas()
        {
            InitializeComponent();
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if (GrdBusquedaDventa.RowCount > 0)
            {
                _IdDetalleVenta = int.Parse(GrdBusquedaDventa.CurrentRow.Cells[0].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda de Detalle Ventas",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Busqueda_dventas_Load(object sender, EventArgs e)
        {
            GrdBusquedaDventa.DataSource = objConexion.obtener_datos().Tables["Detalle_Venta"].DefaultView;
        }

        void filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = GrdBusquedaDventa.DataSource;
            bs.Filter = "(unidades + cantidad_venta) like '%" + valor + "%'";
            GrdBusquedaDventa.DataSource = bs;

        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            filtrar_datos(TxtBuscar.Text);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
