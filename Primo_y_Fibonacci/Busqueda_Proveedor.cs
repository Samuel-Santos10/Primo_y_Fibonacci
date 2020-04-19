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
    public partial class Busqueda_Proveedor : Form
    {

        ConexionClass objConexion = new ConexionClass();
        public int _IdProveedor;

        public Busqueda_Proveedor()
        {
            InitializeComponent();
        }

        private void Busqueda_Proveedor_Load(object sender, EventArgs e)
        {
            GrdBusquedaProveedor.DataSource = objConexion.obtener_datos().Tables["Proveedor"].DefaultView;
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if (GrdBusquedaProveedor.RowCount > 0)
            {
                _IdProveedor = int.Parse(GrdBusquedaProveedor.CurrentRow.Cells[0].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda de Proveedor",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = GrdBusquedaProveedor.DataSource;
            bs.Filter = "(nombre + codigo + direccion + telefono) like '%" + valor + "%'";
            GrdBusquedaProveedor.DataSource = bs;

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
