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
    public partial class Busqueda_Productos : Form
    {

        ConexionClass objConexion = new ConexionClass();
        public int _IdProductos;
        public String _nombreProducto, _codigoProducto;

        public Busqueda_Productos()
        {
            InitializeComponent();
        }

        private void Busqueda_Productos_Load(object sender, EventArgs e)
        {
            GrdBusquedaProducto.DataSource = objConexion.obtener_datos().Tables["Productos_Categorias"].DefaultView;
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if (GrdBusquedaProducto.RowCount > 0)
            {
                _IdProductos = int.Parse(GrdBusquedaProducto.CurrentRow.Cells["IdProductos"].Value.ToString());
                _nombreProducto = GrdBusquedaProducto.CurrentRow.Cells["nombre"].Value.ToString();
                _codigoProducto = GrdBusquedaProducto.CurrentRow.Cells["codigo"].Value.ToString();
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda de Productos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = GrdBusquedaProducto.DataSource;
            bs.Filter = "categoriaa like '%" + valor + "%' or codigo like '%" + valor + "%' or nombre like '%" + valor + "%'";
            GrdBusquedaProducto.DataSource = bs;

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
