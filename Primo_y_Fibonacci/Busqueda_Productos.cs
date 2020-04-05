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

        public Busqueda_Productos()
        {
            InitializeComponent();
        }

        private void Busqueda_Productos_Load(object sender, EventArgs e)
        {
            GrdBusquedaProducto.DataSource = objConexion.obtener_datos().Tables["Productos"].DefaultView;
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if (GrdBusquedaProducto.RowCount > 0)
            {
                _IdProductos = int.Parse(GrdBusquedaProducto.CurrentRow.Cells[0].Value.ToString());
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
            bs.Filter = "Descripción like '%" + valor + "%'";
            GrdBusquedaProducto.DataSource = bs;

        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            filtrar_datos(TxtBuscar.Text);
            
        }
    }
}
