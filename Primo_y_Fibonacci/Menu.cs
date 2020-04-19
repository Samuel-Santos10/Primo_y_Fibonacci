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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleados frmEmpleado = new Empleados();
            frmEmpleado.MdiParent = this;
            frmEmpleado.Show();

           
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedor frmProveedor = new Proveedor();
            frmProveedor.MdiParent = this;
            frmProveedor.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Principal frmCliente = new Principal();
            frmCliente.MdiParent = this;
            frmCliente.Show();

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos frmProductos = new Productos();
            frmProductos.MdiParent = this;
            frmProductos.Show();
        }

        private void detalleVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Detalle_Venta frmdventas = new Detalle_Venta();
            frmdventas.MdiParent = this;
            frmdventas.Show();

        }
        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

      
    }
}
