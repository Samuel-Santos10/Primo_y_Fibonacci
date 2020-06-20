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
    public partial class Busqueda_Usuarios : Form
    {
        ConexionClass objConexion = new ConexionClass();
        public int _IdUsuario;
        public Busqueda_Usuarios()
        {
            InitializeComponent();
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if (GrdBusquedaUsuarios.RowCount > 0)
            {
                _IdUsuario = int.Parse(GrdBusquedaUsuarios.CurrentRow.Cells[0].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda de Detalle Usuarios",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Busqueda_Usuarios_Load(object sender, EventArgs e)
        {
            GrdBusquedaUsuarios.DataSource = objConexion.obtener_datos().Tables["Usuarios"].DefaultView;
        }
        void filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = GrdBusquedaUsuarios.DataSource;
            bs.Filter = "(nombre + password) like '%" + valor + "%'";
            GrdBusquedaUsuarios.DataSource = bs;

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
