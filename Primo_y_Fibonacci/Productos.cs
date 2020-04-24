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
    public partial class Productos : Form
    {
        ConexionClass objConexion = new ConexionClass();
        int posicion = 0;
        string accion = "nuevo";
        DataTable tbl = new DataTable();

        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            actualizarDs();
            mostrarDatos();

            cboCategoriaProductos.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboCategoriaProductos.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        void actualizarDs()
        {
            tbl = objConexion.obtener_datos().Tables["Productos"];
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["IdProductos"] };

            cboCategoriaProductos.DataSource = objConexion.obtener_datos().Tables["Categorias"];
            cboCategoriaProductos.DisplayMember = "categoriaa";
            cboCategoriaProductos.ValueMember = "Categorias.IdCategoria";
        }

        void mostrarDatos()
        {
            try
            {
                
                cboCategoriaProductos.SelectedValue = tbl.Rows[posicion].ItemArray[1].ToString();

                lblidProducto.Text = tbl.Rows[posicion].ItemArray[0].ToString();
                txtcodigoprod.Text = tbl.Rows[posicion].ItemArray[2].ToString();
                txtproducto.Text = tbl.Rows[posicion].ItemArray[3].ToString();
                txtmarca.Text = tbl.Rows[posicion].ItemArray[4].ToString();
                txtmodelo.Text = tbl.Rows[posicion].ItemArray[5].ToString();
                txtcapacidad.Text = tbl.Rows[posicion].ItemArray[6].ToString();
                txtmedida.Text = tbl.Rows[posicion].ItemArray[7].ToString();


                lblnregistros.Text = (posicion + 1) + " de " + tbl.Rows.Count;
            } catch (Exception ex)
            {
                MessageBox.Show("No hay Datos que mostrar", "Registros de Productos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar_cajas();
        }
        }

        private void BtnPrimero_Click(object sender, EventArgs e)
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
                MessageBox.Show("Primer Registro...", "Registros De Productos",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            if (posicion < tbl.Rows.Count - 1)
            {
                posicion++;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Ultimo Registro...", "Registros de Productos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            posicion = tbl.Rows.Count - 1;
            mostrarDatos();
        }

        void limpiar_cajas()
        {
      
            txtcodigoprod.Text = "";
            txtproducto.Text = "";
            txtmarca.Text = "";
            txtmodelo.Text = "";
            txtcapacidad.Text = "";
            txtmedida.Text = "";
        }

        void controles(Boolean valor)
        {
            GrbNavegacion.Enabled = valor;
            BtnDelete.Enabled = valor;
            BtnBuscar.Enabled = valor;
            GrbDatosProducto.Enabled = !valor;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {

            if (lblop.Text == "Nuevo")
            {//boton de nuevo
                lblop.Text = "Guardar";
                lblop2.Text = "Cancelar";
                accion = "nuevo";

                limpiar_cajas();
                controles(false);
            }

            else

            { //boton de guardar
                String[] valores = {
              lblidProducto.Text,
              cboCategoriaProductos.SelectedValue.ToString(),
              txtcodigoprod.Text,
              txtproducto.Text,
              txtmarca.Text,
              txtmodelo.Text,
              txtcapacidad.Text,
              txtmedida.Text

                };

                objConexion.mantenimiento_datos_Productos(valores, accion);
                actualizarDs();
                posicion = tbl.Rows.Count - 1;
                mostrarDatos();

                controles(true);

                lblop.Text = "Nuevo";
                lblop2.Text = "Editar";
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
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

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar a " + txtproducto.Text, "Registro de Productos",
               MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                String[] valores = { lblidProducto.Text };
                objConexion.mantenimiento_datos_Productos(valores, "eliminar");

                actualizarDs();
                posicion = posicion > 0 ? posicion - 1 : 0;
                mostrarDatos();
            }
        }

        

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {

            Busqueda_Productos buscarProducto = new Busqueda_Productos();
            buscarProducto.ShowDialog();

            if (buscarProducto._IdProductos > 0)
            {
                posicion = tbl.Rows.IndexOf(tbl.Rows.Find(buscarProducto._IdProductos));
                mostrarDatos();
            }
        }

        private void BtnBuscarCategoriaProducto_Click(object sender, EventArgs e)
        {
            Busqueda_Categoria buscarCategoria = new Busqueda_Categoria();
            buscarCategoria.ShowDialog();

            if (buscarCategoria._IdCategoria > 0)
            {
                cboCategoriaProductos.SelectedValue = buscarCategoria._IdCategoria;
            }
        }
    }
}
