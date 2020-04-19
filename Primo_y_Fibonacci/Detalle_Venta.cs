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
    public partial class Detalle_Venta : Form
    {

        ConexionClass objConexion = new ConexionClass();
        int posicion = 0;
        string accion = "nuevo";
        DataTable tbl = new DataTable();

        public Detalle_Venta()
        {
            InitializeComponent();
        }

        private void Detalle_Venta_Load(object sender, EventArgs e)
        {
            actualizarDs();
            mostrarDatos();
        }

        void actualizarDs()
        {
            tbl = objConexion.obtener_datos().Tables["Detalle_Venta"];
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["IdDetalle_Venta"] };
        }

        void mostrarDatos()
        {
            try

            {
                lblidDventas.Text = tbl.Rows[posicion].ItemArray[0].ToString();
                txtunidades.Text = tbl.Rows[posicion].ItemArray[1].ToString();
                txtcantventas.Text = tbl.Rows[posicion].ItemArray[2].ToString();
                txtprodvendidos.Text = tbl.Rows[posicion].ItemArray[3].ToString();
                txtpreciototal.Text = tbl.Rows[posicion].ItemArray[4].ToString();
                


                lblnregistros.Text = (posicion + 1) + " de " + tbl.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay Datos que mostrar", "Registros de Detalle Ventas",
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
                MessageBox.Show("Primer Registro...", "Registros De Detalle Ventas",
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
                MessageBox.Show("Ultimo Registro...", "Registros de Detalle Ventas",
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

            txtunidades.Text = "";
            txtcantventas.Text = "";
            txtprodvendidos.Text = "";
            txtpreciototal.Text = "";
            
        }

        void controles(Boolean valor)
        {
            GrbNavegacion.Enabled = valor;
            BtnDelete.Enabled = valor;
            BtnBuscar.Enabled = valor;
            GrbDatosdventas.Enabled = !valor;
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
              lblidDventas.Text,
              txtunidades.Text,
              txtcantventas.Text,
              txtprodvendidos.Text,
              txtpreciototal.Text
              
                };

                objConexion.mantenimiento_datos_dventas(valores, accion);
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
            if (MessageBox.Show("Esta seguro de eliminar el ID " + lblidDventas.Text, "Registro de Detalle Ventas",
              MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                String[] valores = { lblidDventas.Text };
                objConexion.mantenimiento_datos_dventas(valores, "eliminar");

                actualizarDs();
                posicion = posicion > 0 ? posicion - 1 : 0;
                mostrarDatos();
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Busqueda_dventas frmBusqueda = new Busqueda_dventas();
            frmBusqueda.ShowDialog();

            if (frmBusqueda._IdDetalleVenta > 0)
            {
                posicion = tbl.Rows.IndexOf(tbl.Rows.Find(frmBusqueda._IdDetalleVenta));
                mostrarDatos();
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
