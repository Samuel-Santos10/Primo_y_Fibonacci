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
    public partial class Busqueda_Empleado : Form
    {
        ConexionClass objConexion = new ConexionClass();
        public int _IdEmpleado;

        public Busqueda_Empleado()
        {
            InitializeComponent();
        }


        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if (GrdBusquedaClientes.RowCount > 0)
            {
                _IdEmpleado = int.Parse(GrdBusquedaClientes.CurrentRow.Cells[0].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda de Clientes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void Busqueda_Empleado_Load(object sender, EventArgs e)
        {
            GrdBusquedaClientes.DataSource = objConexion.obtener_datos().Tables["Empleado"].DefaultView;
        }

        void filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = GrdBusquedaClientes.DataSource;
            bs.Filter = "NombreCliente like '%" + valor + "%'";
            GrdBusquedaClientes.DataSource = bs;

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
