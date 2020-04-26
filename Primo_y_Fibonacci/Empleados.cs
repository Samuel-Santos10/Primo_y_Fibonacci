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
    public partial class Empleados : Form
    {
        ConexionClass objConexion = new ConexionClass();
        int posicion = 0;
        string accion = "nuevo";
        DataTable tbl = new DataTable();

        public Empleados()
        {
            InitializeComponent();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            actualizarDs();
            mostrarDatos();

            cbotipoEmple.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbotipoEmple.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        void actualizarDs()
        {
            tbl = objConexion.obtener_datos().Tables["Empleado"];
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["IdEmpleado"]};

            cbotipoEmple.DataSource = objConexion.obtener_datos().Tables["Tipo_Usuario"];
            cbotipoEmple.DisplayMember = "nombre";
            cbotipoEmple.ValueMember = "Tipo_Usuario.IdTipoUsuario";
        }

        void mostrarDatos()
        {
            try

            {          
            cbotipoEmple.SelectedValue = tbl.Rows[posicion].ItemArray[1].ToString();

            lblidemple.Text = tbl.Rows[posicion].ItemArray[0].ToString();
            txtcodigoEmp.Text = tbl.Rows[posicion].ItemArray[2].ToString();
            txtnomEmpl.Text = tbl.Rows[posicion].ItemArray[3].ToString();
            txtdui.Text = tbl.Rows[posicion].ItemArray[4].ToString();
            txtnit.Text = tbl.Rows[posicion].ItemArray[5].ToString();
            txtdireccionEmp.Text = tbl.Rows[posicion].ItemArray[6].ToString();
            txttelefono.Text = tbl.Rows[posicion].ItemArray[7].ToString();

                lblnregistros.Text = (posicion + 1) + " de " + tbl.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay Datos que mostrar", "Registros de Empleados",
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
                MessageBox.Show("Primer Registro...", "Registros De Empleado",
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
                MessageBox.Show("Ultimo Registro...", "Registros de Empleado",
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

            txtcodigoEmp.Text = "";
            txtnomEmpl.Text = "";
            txtdireccionEmp.Text = "";
            txtdui.Text = "";
            txtnit.Text = "";
            txttelefono.Text = "";
        }

        void controles(Boolean valor)
        {
            GrbNavegacion.Enabled = valor;
            BtnDelete.Enabled = valor;
            BtnBuscar.Enabled = valor;
            GrbDatosEmpleado.Enabled = !valor;
        }

    
        private void BtnNuevo_Click(object sender, EventArgs e)
        {

            if (lblop.Text == "Nuevo") {//boton de nuevo
                lblop.Text = "Guardar";
                lblop2.Text = "Cancelar";
                accion = "nuevo";

                limpiar_cajas();
                controles(false);
            }

            else

            { //boton de guardar
                String[] valores = {
              lblidemple.Text,
              cbotipoEmple.SelectedValue.ToString(),
              txtcodigoEmp.Text,
              txtnomEmpl.Text,
              txtdui.Text,
              txtnit.Text,
              txtdireccionEmp.Text,
              txttelefono.Text

                };

                objConexion.mantenimiento_datos_Empleado(valores, accion);
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

            if (MessageBox.Show("Esta seguro de eliminar a " + txtnomEmpl.Text, "Registro de Empleado",
                MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                String[] valores = { lblidemple.Text };
                objConexion.mantenimiento_datos_Empleado(valores, "eliminar");

                actualizarDs();
                posicion = posicion > 0 ? posicion - 1 : 0;
                mostrarDatos();
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Busqueda_Empleado BuscarTipoUsuario = new Busqueda_Empleado();
            BuscarTipoUsuario.ShowDialog();

            if (BuscarTipoUsuario._IdEmpleado > 0)
            {
                posicion = tbl.Rows.IndexOf(tbl.Rows.Find(BuscarTipoUsuario._IdEmpleado));
                mostrarDatos();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnBuscarTipoEmpleado_Click(object sender, EventArgs e)
        {
            Busqueda_Tipo_Usuario buscartipo = new Busqueda_Tipo_Usuario();
            buscartipo.ShowDialog();

            if (buscartipo._IdTipoUsuario > 0)
            {
                cbotipoEmple.SelectedValue = buscartipo._IdTipoUsuario;
            }
        }
    }
}
