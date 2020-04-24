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
    public partial class Busqueda_Inventario : Form
    {

        ConexionClass objConexion = new ConexionClass();
        public int _IdInventario;

        public Busqueda_Inventario()
        {
            InitializeComponent();
        }

        private void Busqueda_Inventario_Load(object sender, EventArgs e)
        {
            GrdBusquedaInventario.DataSource = objConexion.obtener_datos().Tables["Inventario_Productos"].DefaultView;
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if (GrdBusquedaInventario.RowCount > 0)
            {
                _IdInventario = int.Parse(GrdBusquedaInventario.CurrentRow.Cells["IdInventario"].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda de Inventario",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = GrdBusquedaInventario.DataSource;
            bs.Filter = "nombre like '%" + valor + "%' or existenci_producto like '%" + valor + "%' or unidades like '%" + valor + "%'";
            GrdBusquedaInventario.DataSource = bs;

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
