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

        private void btnmenu_Click(object sender, EventArgs e)
        {
            if (panelboton1.Visible == true)
            {
                panelboton1.Visible = false;
            }

            else

            {
                panelboton1.Visible = true;
            }

            btnmenu.Location = new Point(2, 158);
            panelboton1.Location = new Point(2, 193);

            if (panelboton1.Visible == false)
            {
                btnmenu.Location = new Point(2, 158);
                btnsubmenu1.Location = new Point(8, 18);
                btnsubmenu2.Location = new Point(8, 383);
                btnsubmenu3.Location = new Point(8, 617);
            }
        }

        private void btnsubmenu1_Click(object sender, EventArgs e)
        {
            if (panelitem1.Visible == true)
            {
                panelitem1.Visible = false;
            }

            else

            {
                panelitem1.Visible = true;
            }

            btnsubmenu1.Location = new Point(8, 18);
            panelitem1.Location = new Point(8, 53);

            if (panelitem1.Visible == false)
            {

                btnsubmenu1.Location = new Point(8, 18);
                btnsubmenu2.Location = new Point(8, 383);
            }
        }

        private void btnsubmenu2_Click(object sender, EventArgs e)
        {
            if (panelitem2.Visible == true)
            {
                panelitem2.Visible = false;
            }

            else

            {
                panelitem2.Visible = true;
            }

            btnsubmenu2.Location = new Point(8, 383);
            panelitem2.Location = new Point(8, 417);

            if (panelitem2.Visible == false)
            {

                btnsubmenu1.Location = new Point(8, 18);
                btnsubmenu2.Location = new Point(8, 383);
            }
        }

        private void btnsubmenu3_Click(object sender, EventArgs e)
        {

            if (panelitem3.Visible == true)
            {
                panelitem3.Visible = false;
            }

            else

            {
                panelitem3.Visible = true;
            }

            btnsubmenu3.Location = new Point(8, 617);
            panelitem3.Location = new Point(8, 651);

            if (panelitem3.Visible == false)
            {

                btnsubmenu1.Location = new Point(8, 18);
                btnsubmenu2.Location = new Point(8, 383);
                btnsubmenu3.Location = new Point(8, 617);
            }
        }

      

        private void Menu_Load(object sender, EventArgs e)
        {
            btnmenu.Location = new Point(2, 158);
            btnsubmenu1.Location = new Point(8, 18);
            btnsubmenu2.Location = new Point(8, 380);
            btnsubmenu3.Location = new Point(8, 617);
            panelboton1.Hide();
            panelitem1.Hide();
            panelitem2.Hide();
            panelitem3.Hide();
        }

        private void btnprincipalcliente_Click(object sender, EventArgs e)
        {
            Principal frmCliente = new Principal();
            frmCliente.MdiParent = this;
            frmCliente.Show();
        }

        private void btnclientemenu_Click(object sender, EventArgs e)
        {
            Principal frmCliente = new Principal();
            frmCliente.MdiParent = this;
            frmCliente.Show();
        }

        private void btnproveedormenu_Click(object sender, EventArgs e)
        {
            Proveedor frmProveedor = new Proveedor();
            frmProveedor.MdiParent = this;
            frmProveedor.Show();
        }

        private void btncategmenu_Click(object sender, EventArgs e)
        {
            Categoria frmCategoria = new Categoria();
            frmCategoria.MdiParent = this;
            frmCategoria.Show();
        }

        private void btnusuamenu_Click(object sender, EventArgs e)
        {
            Usuario frmUsuario = new Usuario();
            frmUsuario.MdiParent = this;
            frmUsuario.Show();
        }

        private void btntipomenu_Click(object sender, EventArgs e)
        {
            TipoUsuario frmTipoUsuario = new TipoUsuario();
            frmTipoUsuario.MdiParent = this;
            frmTipoUsuario.Show();
        }

        private void btnprodumenu_Click(object sender, EventArgs e)
        {
            Productos frmTipoUsuario = new Productos();
            frmTipoUsuario.MdiParent = this;
            frmTipoUsuario.Show();
        }

        private void btnemplemenu_Click(object sender, EventArgs e)
        {
            Empleados frmEmpleados = new Empleados();
            frmEmpleados.MdiParent = this;
            frmEmpleados.Show();
        }

        private void btninvenmenu_Click(object sender, EventArgs e)
        {
            Inventario frmInventario = new Inventario();
            frmInventario.MdiParent = this;
            frmInventario.Show();
        }

        private void btnventamenu_Click(object sender, EventArgs e)
        {
             Ventas frmVentas = new Ventas();
            frmVentas.MdiParent = this;
            frmVentas.Show();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btncompramenu_Click(object sender, EventArgs e)
        {
            Compra frmCompra = new Compra();
            frmCompra.MdiParent = this;
            frmCompra.Show();
        }

        private void btncatego_Click(object sender, EventArgs e)
        {
            Categoria frmCategoria = new Categoria();
            frmCategoria.MdiParent = this;
            frmCategoria.Show();
        }

        private void btnusuario_Click(object sender, EventArgs e)
        {
            Usuario frmUsuario = new Usuario();
            frmUsuario.MdiParent = this;
            frmUsuario.Show();
        }

        private void btnprovee_Click(object sender, EventArgs e)
        {
            Proveedor frmProveedor = new Proveedor();
            frmProveedor.MdiParent = this;
            frmProveedor.Show();
        }

        private void btntipousu_Click(object sender, EventArgs e)
        {
            TipoUsuario frmTipoUsuario = new TipoUsuario();
            frmTipoUsuario.MdiParent = this;
            frmTipoUsuario.Show();
        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            Productos frmTipoUsuario = new Productos();
            frmTipoUsuario.MdiParent = this;
            frmTipoUsuario.Show();
        }

        private void btnemple_Click(object sender, EventArgs e)
        {
            Empleados frmEmpleados = new Empleados();
            frmEmpleados.MdiParent = this;
            frmEmpleados.Show();
        }

        private void btninventa_Click(object sender, EventArgs e)
        {
            Inventario frmInventario = new Inventario();
            frmInventario.MdiParent = this;
            frmInventario.Show();
        }

        private void btncompras_Click(object sender, EventArgs e)
        {
            Compra frmCompra = new Compra();
            frmCompra.MdiParent = this;
            frmCompra.Show();
        }

        private void btnventas_Click(object sender, EventArgs e)
        {
            Ventas frmVentas = new Ventas();
            frmVentas.MdiParent = this;
            frmVentas.Show();
        }

        private void btnpedidoCliente_Click(object sender, EventArgs e)
        {
            Pedido_Cliente frmPedidoC = new Pedido_Cliente();
            frmPedidoC.MdiParent = this;
            frmPedidoC.Show();
        }

        private void btnpedidomenu_Click(object sender, EventArgs e)
        {
            Pedido_Cliente frmPedidoC = new Pedido_Cliente();
            frmPedidoC.MdiParent = this;
            frmPedidoC.Show();
        }

        private void cOMPRAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compra frmCompra = new Compra();
            frmCompra.MdiParent = this;
            frmCompra.Show();
        }

        private void cLIENTEToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Principal frmCliente = new Principal();
            frmCliente.MdiParent = this;
            frmCliente.Show();
        }

        private void cATEGORIAToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Categoria frmCategoria = new Categoria();
            frmCategoria.MdiParent = this;
            frmCategoria.Show();
        }

        private void pROVEEDORToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Proveedor frmProveedor = new Proveedor();
            frmProveedor.MdiParent = this;
            frmProveedor.Show();
        }

        private void vENTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventas frmVentas = new Ventas();
            frmVentas.MdiParent = this;
            frmVentas.Show();
        }

        private void pEDIDOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedido_Cliente frmPedidoC = new Pedido_Cliente();
            frmPedidoC.MdiParent = this;
            frmPedidoC.Show();
        }

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Principal frmCliente = new Principal();
            frmCliente.MdiParent = this;
            frmCliente.Show();
        }

        private void pROVEEDORToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Proveedor frmProveedor = new Proveedor();
            frmProveedor.MdiParent = this;
            frmProveedor.Show();
        }

        private void cATEGORIAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Categoria frmCategoria = new Categoria();
            frmCategoria.MdiParent = this;
            frmCategoria.Show();
        }

        private void uSUARIOSToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Usuario frmUsuario = new Usuario();
            frmUsuario.MdiParent = this;
            frmUsuario.Show();
        }

        private void tIPOUSUARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoUsuario frmTipoUsuario = new TipoUsuario();
            frmTipoUsuario.MdiParent = this;
            frmTipoUsuario.Show();
        }

        private void pRODUCTOSToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Productos frmTipoUsuario = new Productos();
            frmTipoUsuario.MdiParent = this;
            frmTipoUsuario.Show();
        }

        private void eMPLEADOSToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Empleados frmEmpleados = new Empleados();
            frmEmpleados.MdiParent = this;
            frmEmpleados.Show();
        }

        private void iNVENTARIOToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Inventario frmInventario = new Inventario();
            frmInventario.MdiParent = this;
            frmInventario.Show();
        }

        private void vENTASToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ventas frmVentas = new Ventas();
            frmVentas.MdiParent = this;
            frmVentas.Show();
        }

        private void cOMPRASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compra frmCompra = new Compra();
            frmCompra.MdiParent = this;
            frmCompra.Show();
        }

        private void pEDIDOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Pedido_Cliente frmPedidoC = new Pedido_Cliente();
            frmPedidoC.MdiParent = this;
            frmPedidoC.Show();
        }

        private void fACTURAVENTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Factura_Venta frmFACTURAV = new Factura_Venta();
            frmFACTURAV.MdiParent = this;
            frmFACTURAV.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Factura_Venta frmFACTURAV = new Factura_Venta();
            frmFACTURAV.MdiParent = this;
            frmFACTURAV.Show();
        }

        private void sALIRToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void asercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            acerca_de creadores = new acerca_de();
            creadores.MdiParent = this;
            creadores.Show();
        }
    }
}
