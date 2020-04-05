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
    public partial class Principal : Form
    {
        ConexionClass objConexion = new ConexionClass();
        int posicion = 0;
        string accion = "nuevo";
        DataTable tbl = new DataTable();

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

            actualizarDs();
            mostrarDatos();
        }
        void actualizarDs()
        {
            tbl = objConexion.obtener_datos().Tables["Cliente"];
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["IdCliente"] };
        }
        void mostrarDatos()
        {
            try
            {
            TxtIdCliente.Text = tbl.Rows[posicion].ItemArray[0].ToString();
            TxtNombre.Text = tbl.Rows[posicion].ItemArray[1].ToString();
            TxtEmail.Text = tbl.Rows[posicion].ItemArray[2].ToString();
            TxtDirección.Text = tbl.Rows[posicion].ItemArray[3].ToString();

                lblnregistros.Text = (posicion + 1) + " de " + tbl.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay Datos que mostrar", "Registros de Cliente",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar_cajas();
            }
        }


        private void BtnPrimero_Click_1(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatos();
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Primer Registro...", "Registros De Cliente",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       private void BtnSiguiente_Click_1(object sender, EventArgs e)
        {
            if (posicion < tbl.Rows.Count - 1)
            {
                posicion++;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Ultimo Registro...", "Registros de Cliente",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnUltimo_Click_1(object sender, EventArgs e)
        {
            posicion = tbl.Rows.Count - 1;
            mostrarDatos();
        }


        void limpiar_cajas()
        {
            
            TxtNombre.Text = "";
            TxtEmail.Text = "";
            TxtDirección.Text = "";
        }

        void controles(Boolean valor)
        {
            GrbNavegacion.Enabled = valor;
            BtnDelete.Enabled = valor;
            BtnBuscar.Enabled = valor;
            GrbDatosCliente.Enabled = !valor;
        }

        private void BtnNuevo_Click_1(object sender, EventArgs e)
        {
  
            if (lblop.Text == "Nuevo"){//boton de nuevo
                lblop.Text = "Guardar";
                lblop2.Text = "Cancelar";
                accion = "nuevo";

                limpiar_cajas();
                controles(false);
            }
            else
            { //boton de guardar
                String[] valores = {
              TxtIdCliente.Text,
              TxtNombre.Text,
              TxtEmail.Text,
              TxtDirección.Text
                };
                objConexion.mantenimiento_datos(valores, accion);
                actualizarDs();
                posicion = tbl.Rows.Count - 1;
                mostrarDatos();

                controles(true);

                lblop.Text = "Nuevo";
                lblop2.Text = "Editar";
            }
        }

        private void BtnModificar_Click_1(object sender, EventArgs e)
        {

            if (lblop2.Text == "Editar")
            {//boton de modificar
                lblop.Text = "Guardar";
                lblop2.Text = "Cancelar";
                accion = "modificar";

                controles(false);

                lblop.Text = "Guardar";
               lblop2.Text = "Cancelar";

            }
            else
            { //boton de cancelar
                controles(true);
                mostrarDatos();

                lblop.Text = "Nuevo";
                lblop2.Text = "Editar";
            }
        }


        private void BtnDelete_Click_1(object sender, EventArgs e)
        {

            if (MessageBox.Show("Esta seguro de eliminar a " + TxtNombre.Text, "Registro de Clientes",
                MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                String[] valores = { TxtIdCliente.Text };
                objConexion.mantenimiento_datos(valores, "eliminar");

                actualizarDs();
                posicion = posicion > 0 ? posicion - 1 : 0;
                mostrarDatos();
            }
        }


        private void BtnBuscar_Click_1(object sender, EventArgs e)
        {

            Busqueda_Cliente frmBusqueda = new Busqueda_Cliente();
            frmBusqueda.ShowDialog();

            if (frmBusqueda._IdCliente > 0)
            {
                posicion = tbl.Rows.IndexOf(tbl.Rows.Find(frmBusqueda._IdCliente));
                mostrarDatos();
            }
        }

 

        private void formularioEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleados Empleado = new Empleados();

            Empleado.Show();
        }

        private void formularioProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos Productos = new Productos();

            Productos.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
