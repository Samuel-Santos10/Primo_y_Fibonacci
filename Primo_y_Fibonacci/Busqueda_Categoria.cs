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
    public partial class Busqueda_Categoria : Form
    {

        ConexionClass objConexion = new ConexionClass();
        public int _IdCategoria;

        public Busqueda_Categoria()
        {
            InitializeComponent();
        }

        private void Busqueda_Categoria_Load(object sender, EventArgs e)
        {
            GrdBusquedaCategoria.DataSource = objConexion.obtener_datos().Tables["Categorias"].DefaultView;
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if (GrdBusquedaCategoria.RowCount > 0)
            {
                _IdCategoria = int.Parse(GrdBusquedaCategoria.CurrentRow.Cells[0].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda de Categorias",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = GrdBusquedaCategoria.DataSource;
            bs.Filter = "categoriaa like '%" + valor + "%'";
            GrdBusquedaCategoria.DataSource = bs;

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
