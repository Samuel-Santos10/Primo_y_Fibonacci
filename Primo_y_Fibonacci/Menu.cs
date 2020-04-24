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

    
        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleados frmEmpleado = new Empleados();
            frmEmpleado.MdiParent = this;
            frmEmpleado.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categoria frmCategoria = new Categoria();
            frmCategoria.MdiParent = this;
            frmCategoria.Show();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventario frminven = new Inventario();
            frminven.MdiParent = this;
            frminven.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario frmUsuarios = new Usuario();
            frmUsuarios.MdiParent = this;
            frmUsuarios.Show();
        }

        private void tipoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoUsuario frmTipo = new TipoUsuario();
            frmTipo.MdiParent = this;
            frmTipo.Show();
        }

        
    }
}
