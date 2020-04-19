using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//libreria DB
using System.Data;
//libreria DB con SQL Server
using System.Data.SqlClient;

namespace Primo_y_Fibonacci
{
    class ConexionClass
    {
        SqlConnection miConexion = new SqlConnection();
        SqlCommand comandosSQL = new SqlCommand();
        SqlDataAdapter miAdaptadorDatos = new SqlDataAdapter();

        DataSet ds = new DataSet();

        public ConexionClass()
        {
            String cadena = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Control.mdf;Integrated Security=True";
            miConexion.ConnectionString = cadena;
            miConexion.Open();
        }
        public DataSet obtener_datos()
        {

            ds.Clear();
            comandosSQL.Connection = miConexion;

            comandosSQL.CommandText = "select * from Cliente";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "Cliente");

            comandosSQL.CommandText = "select * from Empleado";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "Empleado");

            comandosSQL.CommandText = "select * from Productos";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "Productos");

            comandosSQL.CommandText = "select * from Proveedor";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "Proveedor");

            comandosSQL.CommandText = "select * from Categorias";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "Categorias");

            comandosSQL.CommandText = "select * from Detalle_Venta";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "Detalle_Venta");


            return ds;
        }


        public void mantenimiento_datos_Cliente(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo"){

                sql = "INSERT INTO Cliente (codigo, nombre, dui, nit, telefono, direccion) VALUES(" +
                    
                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'," +
                    "'" + datos[4] + "'," +
                    "'" + datos[5] + "'," +
                    "'" + datos[6] + "'" +
                    ")";

            }

            else if (accion == "modificar")  {

                sql = "UPDATE Cliente SET " +
                " codigo              = '" + datos[1] + "'," +
                " nombre              = '" + datos[2] + "'," +
                " dui                 = '" + datos[3] + "'," +
                " nit                 = '" + datos[4] + "'," +
                " telefono            = '" + datos[5] + "'," +
                " direccion           = '" + datos[6] + "'" +
                " WHERE IdCliente     = '" + datos[0] + "'";


            } else if (accion == "eliminar") {
                sql = "DELETE Cliente FROM Cliente WHERE IdCliente='" + datos[0] + "'";

            }
            procesoSQL(sql);
        }


        public void mantenimiento_datos_Empleado(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {

                sql = "INSERT INTO Empleado (codigo, nombre, dui, nit, direccion, telefono) VALUES(" +
                    
                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'," +
                    "'" + datos[4] + "'," +
                    "'" + datos[5] + "'," +
                    "'" + datos[6] + "'" +
                     ")";

            }

            else if (accion == "modificar")
            {

                sql = "UPDATE Empleado SET " +

                "codigo              = '" + datos[1] + "'," +
                "nombre              = '" + datos[2] + "'," +
                "dui                 = '" + datos[3] + "'," +
                "nit                 = '" + datos[4] + "'," +
                "direccion           = '" + datos[5] + "'," +
                "telefono            = '" + datos[6] + "'" +
               "WHERE IdEmpleado      = '" + datos[0] + "'";

            }
            else if (accion == "eliminar")
            {
            
            sql = "DELETE Empleado FROM Empleado WHERE IdEmpleado='" + datos[0] + "'";

            }
            procesoSQL(sql);
        }


        public void mantenimiento_datos_Proveedor(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {

                sql = "INSERT INTO Proveedor (codigo, nombre, dui, direccion, telefono) VALUES(" +

                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'," +
                    "'" + datos[4] + "'," +
                    "'" + datos[5] + "'" +
                     ")";

            }

            else if (accion == "modificar")
            {

                sql = "UPDATE Proveedor SET " +

                "codigo              = '" + datos[1] + "'," +
                "nombre              = '" + datos[2] + "'," +
                "dui                 = '" + datos[3] + "'," +
                "direccion           = '" + datos[4] + "'," +
                "telefono            = '" + datos[5] + "'" +
               "WHERE IdProveedor      = '" + datos[0] + "'";

            }
            else if (accion == "eliminar")
            {

                sql = "DELETE Proveedor FROM Proveedor WHERE IdProveedor='" + datos[0] + "'";

            }
            procesoSQL(sql);
        }


        //Productos
        public void mantenimiento_datos_Productos(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {

                sql = "INSERT INTO Productos (IdCategoria, codigo, nombre, marca, modelo, capacidad, medida) VALUES(" +
                     "'" + datos[1] + "'," +
                     "'" + datos[2] + "'," +
                     "'" + datos[3] + "'," +
                     "'" + datos[4] + "'," +
                     "'" + datos[5] + "'," +
                     "'" + datos[6] + "'," +
                     "'" + datos[7] + "'" +
                     ")";

            }

            else if (accion == "modificar")
            {

                sql = "UPDATE Productos SET " +

               "IdCategoria         = '" + datos[1] + "'," +
               "codigo              = '" + datos[2] + "'," +
               "nombre              = '" + datos[3] + "'," +
               "marca               = '" + datos[4] + "'," +
               "modelo              = '" + datos[5] + "'," +
               "capacidad           = '" + datos[6] + "'," +
               "medida              = '" + datos[7] + "'" +
               "WHERE IdProductos   = '" + datos[0] + "'";

            }
            else if (accion == "eliminar")
            {

                sql = "DELETE Productos FROM Productos WHERE IdProductos='" + datos[0] + "'";

            }
            procesoSQL(sql);
        }
       

        public void mantenimiento_datos_dventas(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {

                sql = "INSERT INTO Detalle_Venta (unidades, cantidad_venta, cant_producto_vendido, precio_total) VALUES(" +
                     "'" + datos[1] + "'," +
                     "'" + datos[2] + "'," +
                     "'" + datos[3] + "'," +
                     "'" + datos[4] + "'" +
                     ")";

            }

            else if (accion == "modificar")
            {

                sql = "UPDATE Detalle_Venta SET " +

               "unidades                   = '" + datos[1] + "'," +
               "cantidad_venta             = '" + datos[2] + "'," +
               "cant_producto_vendido      = '" + datos[3] + "'," +
               "precio_total               = '" + datos[4] + "'" +
               "WHERE IdDetalle_Venta      = '" + datos[0] + "'";

            }
            else if (accion == "eliminar")
            {

                sql = "DELETE Detalle_Venta FROM Detalle_Venta WHERE IdDetalle_Venta='" + datos[0] + "'";

            }
            procesoSQL(sql);
        }

        void procesoSQL(String sql)
        {
            comandosSQL.Connection = miConexion;
            comandosSQL.CommandText = sql;
            comandosSQL.ExecuteNonQuery();
        }

    }
}
