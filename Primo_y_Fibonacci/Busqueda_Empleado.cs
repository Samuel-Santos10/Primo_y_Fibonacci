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

            if (GrdBusquedaEmpleado.RowCount > 0)
            {
                _IdEmpleado = int.Parse(GrdBusquedaEmpleado.CurrentRow.Cells["IdEmpleado"].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda de Empleado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void Busqueda_Empleado_Load(object sender, EventArgs e)
        {
            GrdBusquedaEmpleado.DataSource = objConexion.obtener_datos().Tables["Empleado_Tipo_Usuario"].DefaultView;
        }

        void filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = GrdBusquedaEmpleado.DataSource;
            bs.Filter = "nombre like '%" + valor + "%' or nombre1 like '%" + valor + "%' or direccion like '%" + valor + "%' or dui like '%" + valor + "%' or nit like '%" + valor + "%' or codigo like '%" + valor + "%'";
            GrdBusquedaEmpleado.DataSource = bs;

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
