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
    public partial class Busqueda_Tipo_Usuario : Form
    {
        ConexionClass objConexion = new ConexionClass();
        public int _IdTipoUsuario;
        public Busqueda_Tipo_Usuario()
        {
            InitializeComponent();
        }

        private void Busqueda_Tipo_Usuario_Load(object sender, EventArgs e)
        {
            GrdBusquedaTipoUsuario.DataSource = objConexion.obtener_datos().Tables["Tipo_Usuario"].DefaultView;
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if (GrdBusquedaTipoUsuario.RowCount > 0)
            {
                _IdTipoUsuario = int.Parse(GrdBusquedaTipoUsuario.CurrentRow.Cells[0].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda de Tipo Usuario",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = GrdBusquedaTipoUsuario.DataSource;
            bs.Filter = "nombre like '%" + valor + "%'";
            GrdBusquedaTipoUsuario.DataSource = bs;

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
