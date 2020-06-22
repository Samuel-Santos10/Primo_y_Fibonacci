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

            //inicializar los parametros que se van en las consultas
            parametrizacion();
        }
        private void parametrizacion()
        {
            comandosSQL.Parameters.Add("@Id", SqlDbType.Int).Value = 0;
            comandosSQL.Parameters.Add("@IdC", SqlDbType.Int).Value = 0;

            //FK empleado con tipousuario
            comandosSQL.Parameters.Add("@IDT", SqlDbType.Int).Value = 0;
            //FK inventario
            comandosSQL.Parameters.Add("@IDP", SqlDbType.Int).Value = 0;
            comandosSQL.Parameters.Add("@IDV", SqlDbType.Int).Value = 0;
            //FK dventa
            comandosSQL.Parameters.Add("@ID_P", SqlDbType.Int).Value = 0;
            comandosSQL.Parameters.Add("@ID_V", SqlDbType.Int).Value = 0;

            comandosSQL.Parameters.Add("@exi", SqlDbType.Int).Value = 0;
            comandosSQL.Parameters.Add("@und", SqlDbType.Int).Value = 0;
            comandosSQL.Parameters.Add("@cod", SqlDbType.Char).Value = "";
            comandosSQL.Parameters.Add("@nom", SqlDbType.Char).Value = "";
            comandosSQL.Parameters.Add("@dui", SqlDbType.Char).Value = "";
            comandosSQL.Parameters.Add("@nit", SqlDbType.Char).Value = "";
            comandosSQL.Parameters.Add("@dir", SqlDbType.Char).Value = "";
            comandosSQL.Parameters.Add("@tel", SqlDbType.Char).Value = "";
            comandosSQL.Parameters.Add("@mar", SqlDbType.Char).Value = "";
            comandosSQL.Parameters.Add("@mod", SqlDbType.Char).Value = "";
            comandosSQL.Parameters.Add("@cap", SqlDbType.Char).Value = "";
            comandosSQL.Parameters.Add("@med", SqlDbType.Char).Value = "";
            comandosSQL.Parameters.Add("@cat", SqlDbType.Char).Value = "";
            //dventa
            comandosSQL.Parameters.Add("@cav", SqlDbType.Char).Value = "";
            comandosSQL.Parameters.Add("@cpv", SqlDbType.Char).Value = "";
            comandosSQL.Parameters.Add("@prt", SqlDbType.Char).Value = "";

            comandosSQL.Parameters.Add("@pas", SqlDbType.Char).Value = "";
            //FK usuario con tipousuario
            comandosSQL.Parameters.Add("@Tip", SqlDbType.Int).Value = 0;

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

            comandosSQL.CommandText = "select * from Tipo_Usuario";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "Tipo_Usuario");

            comandosSQL.CommandText = "select Tipo_Usuario.nombre, Empleado.IdEmpleado, Empleado.codigo, Empleado.nombre, Empleado.dui, Empleado.nit, Empleado.direccion, Empleado.telefono, Empleado.ID_Usuario from Empleado inner join Tipo_Usuario on(Tipo_Usuario.IdTipoUsuario=Empleado.IDTipoUsuario)";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "Empleado_Tipo_Usuario");

            comandosSQL.CommandText = "select * from Productos";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "Productos");

            comandosSQL.CommandText = "select * from Proveedor";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "Proveedor");

            comandosSQL.CommandText = "select * from Detalle_Venta";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "Detalle_Venta");

            comandosSQL.CommandText = "select Categorias.categoriaa, Productos.IdProductos, Productos.codigo, Productos.nombre, Productos.marca, Productos.modelo, Productos.capacidad, Productos.medida from Productos inner join Categorias on(Categorias.IdCategoria=Productos.IdCategoria)";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "Productos_Categorias");

            comandosSQL.CommandText = "select Productos.nombre, Inventario.IdInventario, Inventario.existenci_producto, Inventario.unidades  from Inventario inner join Productos on(Productos.IdProductos=Inventario.ID_Producto)";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "Inventario_Productos");


            comandosSQL.CommandText = "select * from Categorias";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "Categorias");

            comandosSQL.CommandText = "select * from Inventario";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "Inventario");

            comandosSQL.CommandText = "select * from Usuarios";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "Usuarios");


            return ds;
        }


        public void mantenimiento_datos_Cliente(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO Cliente (codigo,nombre,dui,nit,direccion,telefono) VALUES (@cod,@nom,@dui,@nit,@dir,@tel)";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE Cliente SET " +
                " codigo              = @cod," +
                " nombre              = @nom," +
                " dui                 = @dui," +
                " nit                 = @nit," +
                " direccion           = @dir," +
                " telefono            = @tel" +
                " WHERE IdCliente     = @Id";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE Cliente FROM Cliente WHERE IdCliente=@Id";
            }


                comandosSQL.Parameters["@Id"].Value = datos[0];
                if (accion != "eliminar")
                {
                    comandosSQL.Parameters["@cod"].Value = datos[1];
                    comandosSQL.Parameters["@nom"].Value = datos[2];
                    comandosSQL.Parameters["@dui"].Value = datos[3];
                    comandosSQL.Parameters["@nit"].Value = datos[4];
                    comandosSQL.Parameters["@dir"].Value = datos[5];
                    comandosSQL.Parameters["@tel"].Value = datos[6];
                
            }
            procesoSQL(sql);
        }

        //Empleado
        public void mantenimiento_datos_Empleado(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {

                sql = "INSERT INTO Empleado (IDTipoUsuario,codigo,nombre,dui,nit,direccion,telefono) VALUES (@IDT,@cod,@nom,@dui,@nit,@dir,@tel)";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE Empleado SET " +
                " IDTipoUsuario       = @IDT," +
                " codigo              = @cod," +
                " nombre              = @nom," +
                " dui                 = @dui," +
                " nit                 = @nit," +
                " direccion           = @dir," +
                " telefono            = @tel" +
                " WHERE IdEmpleado     = @Id";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE Empleado FROM Empleado WHERE IdEmpleado=@Id";
            }

                comandosSQL.Parameters["@Id"].Value = datos[0];
                if (accion != "eliminar")
                {
                    comandosSQL.Parameters["@IDT"].Value = datos[1];
                    comandosSQL.Parameters["@cod"].Value = datos[2];
                    comandosSQL.Parameters["@nom"].Value = datos[3];
                    comandosSQL.Parameters["@dui"].Value = datos[4];
                    comandosSQL.Parameters["@nit"].Value = datos[5];
                    comandosSQL.Parameters["@dir"].Value = datos[6];
                    comandosSQL.Parameters["@tel"].Value = datos[7];
            }
            procesoSQL(sql);
        }

        // proveedor
        public void mantenimiento_datos_Proveedor(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {

                sql = "INSERT INTO Proveedor (codigo,nombre,dui,direccion,telefono) VALUES (@cod,@nom,@dui,@dir,@tel)";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE Proveedor SET " +
                " codigo              = @cod," +
                " nombre              = @nom," +
                " dui                 = @dui," +
                " direccion           = @dir," +
                " telefono            = @tel" +
                " WHERE IdProveedor   = @Id";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE Proveedor FROM Proveedor WHERE IdProveedor=@Id";
            }

            
                comandosSQL.Parameters["@Id"].Value = datos[0];
                if (accion != "eliminar")
                {
                    comandosSQL.Parameters["@cod"].Value = datos[1];
                    comandosSQL.Parameters["@nom"].Value = datos[2];
                    comandosSQL.Parameters["@dui"].Value = datos[3];
                    comandosSQL.Parameters["@dir"].Value = datos[4];
                    comandosSQL.Parameters["@tel"].Value = datos[5];
            }
            procesoSQL(sql);
        }


        //Productos
        public void mantenimiento_datos_Productos(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO Productos (IdCategoria,codigo,nombre,marca,modelo,capacidad,medida) VALUES(@IdC,@cod,@nom,@mar,@mod,@cap,@med)";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE Productos SET " +
                    "IdCategoria       = @idC," +
                    "codigo            = @cod," +
                    "nombre            = @nom," +
                    "marca             = @mar," +
                    "modelo            = @mod," +
                    "capacidad         = @cap," +
                    "medida            = @med " +
                    "WHERE IdProductos = @Id";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE Productos FROM Productos WHERE IdProductos=@Id";
            }

            comandosSQL.Parameters["@Id"].Value = datos[0];
            if (accion != "eliminar")
            {
                comandosSQL.Parameters["@IdC"].Value = datos[1];
                comandosSQL.Parameters["@cod"].Value = datos[2];
                comandosSQL.Parameters["@nom"].Value = datos[3];
                comandosSQL.Parameters["@mar"].Value = datos[4];
                comandosSQL.Parameters["@mod"].Value = datos[5];
                comandosSQL.Parameters["@cap"].Value = datos[6];
                comandosSQL.Parameters["@med"].Value = datos[7];
            }
            procesoSQL(sql);
        }

        
        // Categoria
        public void mantenimiento_datos_Categoria(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {

                sql = "INSERT INTO Categorias (categoriaa) VALUES (@cat)";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE Categorias SET " +
                " categoriaa        = @cat" +
                " WHERE IdCategoria = @Id";
            }

            else if (accion == "eliminar")
            {
                sql = "DELETE Categorias FROM Categorias WHERE IdCategoria=@Id";
            }

            comandosSQL.Parameters["@Id"].Value = datos[0];
            if (accion != "eliminar")
               {
               comandosSQL.Parameters["@cat"].Value = datos[1];
            }
            procesoSQL(sql);
        }

        // Inventario
        public void mantenimiento_datos_Inventario(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {

                sql = "INSERT INTO Inventario (ID_Producto, ID_Ventas, existenci_producto, unidades) VALUES(@IDP,@IDV,@exi,@und)";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE Inventario SET " +
                "ID_Producto              = @IDP," +
                "ID_Ventas                = @IDV," +
                "existenci_producto       = @exi," +
                "unidades                 = @und " +
                "WHERE IdInventario       = @Id";
            }

            else if (accion == "eliminar")
            {
                sql = "DELETE Inventario FROM Inventario WHERE IdInventario=@Id";
            }

                comandosSQL.Parameters["@Id"].Value = datos[0];
                if (accion!="eliminar")
                {
                    comandosSQL.Parameters["@IDP"].Value = datos[1];
                    comandosSQL.Parameters["@IDV"].Value = datos[2];
                    comandosSQL.Parameters["@exi"].Value = datos[3];
                    comandosSQL.Parameters["@und"].Value = datos[4];
            }
            procesoSQL(sql);
        }


        // Tabla Usuarios
        public void mantenimiento_datos_Usuarios(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {

                sql = "INSERT INTO Usuarios (nombre,password,TipoUsuario) VALUES (@nom,@pas,@Tip)";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE Usuarios SET " +
                " nombre                = @nom," +
                " password              = @pas," +
                " TipoUsuario           = @Tip" +
                " WHERE IdUsuario = @Id";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE Usuarios FROM Usuarios WHERE IdUsuario=@Id";
            }
            comandosSQL.Parameters["@id"].Value = datos[0];
            if (accion != "eliminar")
            {
                comandosSQL.Parameters["@nom"].Value = datos[1];
                comandosSQL.Parameters["@pas"].Value = datos[2];
                comandosSQL.Parameters["@Tip"].Value = datos[3];
            }
            procesoSQL(sql);
        }


        // Tabla Tipo Usuario
        public void mantenimiento_datos_Tipo(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {

                sql = "INSERT INTO Tipo_Usuario (nombre) VALUES (@nom)";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE Tipo_Usuario SET " +
                " nombre              = @nom" +
                " WHERE IdTipoUsuario = @Id";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE Tipo_Usuario FROM Tipo_Usuario WHERE IdTipoUsuario=@Id";
            }

          
                comandosSQL.Parameters["@Id"].Value = datos[0];
                if (accion != "eliminar")
                {
                    comandosSQL.Parameters["@nom"].Value = datos[1];
            }
            procesoSQL(sql);
        }

        //detalle venta
        public void mantenimiento_datos_dventas(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {

                sql = "INSERT INTO Detalle_Venta (unidades,cantidad_venta,cant_producto_vendido,precio_total,ID_Ventas,ID_Productos) VALUES (@und,@cav,@cpv,@prt,@IDV,@IDP)";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE Detalle_Venta SET " +
                " unidades              = @und," +
                " cantidad_venta        = @cav," +
                " cant_producto_vendido = @cpv," +
                " precio_total          = @prt," +
                " ID_Ventas             = @IDV," +
                " ID_Productos          = @IDP" +    
                " WHERE IdDetalle_Venta = @Id";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE Detalle_Venta FROM Detalle_Venta WHERE IdDetalle_Venta=@Id";
            }

            comandosSQL.Parameters["@Id"].Value = datos[0];
            if (accion != "eliminar")
            {
                comandosSQL.Parameters["@und"].Value = datos[1];
                comandosSQL.Parameters["@cav"].Value = datos[2];
                comandosSQL.Parameters["@cpv"].Value = datos[3];
                comandosSQL.Parameters["@prt"].Value = datos[4];
                comandosSQL.Parameters["@IDV"].Value = datos[5];
                comandosSQL.Parameters["@IDP"].Value = datos[6];
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


