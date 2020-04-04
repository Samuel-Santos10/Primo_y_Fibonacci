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
    public partial class Busqueda_Cliente : Form
    {
        ConexionClass objConexion = new ConexionClass();
        public int _IdCliente;

        public Busqueda_Cliente()
        {
            InitializeComponent();
        }

        private void BtnSeleccionar_Click_1(object sender, EventArgs e)
        {

            if (GrdBusquedaClientes.RowCount > 0)
            {
                _IdCliente = int.Parse(GrdBusquedaClientes.CurrentRow.Cells[0].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda de Clientes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       private void Busqueda_Cliente_Load(object sender, EventArgs e)
        {

         GrdBusquedaClientes.DataSource = objConexion.obtener_datos().Tables["Cliente"].DefaultView;
        }
      
        void filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = GrdBusquedaClientes.DataSource;
            bs.Filter = "NombreCliente like '%" + valor + "%'";
            GrdBusquedaClientes.DataSource = bs;

        }

        private void TxtBuscar_TextChanged_1(object sender, EventArgs e)
        {

         filtrar_datos(TxtBuscar.Text);
        }


        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {

            Close();
        }

        
    }
}

