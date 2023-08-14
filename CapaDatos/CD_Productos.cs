using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Productos
    {
        private BD_Conexion Conexion = new BD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand cmd = new SqlCommand();

        public DataTable Mostrar()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexion.AbrirConexion();
            cmd.CommandText = "select P.ProductoID,p.Nombre, p.Precio, pr.Nombre[Nombre Proveedor], pr.Direccion [Direccion Proveedor] From Productos p join Proveedores pr with(nolock) on pr.ProveedorID = p.ProveedorID";
            leer = cmd.ExecuteReader();
            tabla.Load(leer);
            Conexion.CerrarConexion();
            return tabla;
        }


        public void Insertar(String Nombre, int Precio, String Tipo)

        {
            String TipoProveedor = Tipo;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexion.AbrirConexion();
            cmd.CommandText = "InsertarProductos";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Precio", Precio);
            if (TipoProveedor == "Proveedor A")
            {
                cmd.Parameters.AddWithValue("@IDProveedor", 1);
            }
            else
            {
                cmd.Parameters.AddWithValue("@IDProveedor", 2);          
            }
            
            cmd.ExecuteNonQuery();

        }

        public void Editar(String Nombre, int Precio, String Tipo, int ProductoID)

        {
            String TipoProveedor = Tipo;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexion.AbrirConexion();
            cmd.CommandText = "ActualizarProductos";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Precio", Precio);
            if (TipoProveedor == "Proveedor A")
            {
                cmd.Parameters.AddWithValue("@IDProveedor", 1);
            }
            else
            {
                cmd.Parameters.AddWithValue("@IDProveedor", 2);
            }
            cmd.Parameters.AddWithValue("@ProductoID", ProductoID);
            cmd.ExecuteNonQuery();

        }

        public void Eliminar(int ProductoID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexion.AbrirConexion();
            cmd.CommandText = "EliminarProductos";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ProductoID", ProductoID);
            cmd.ExecuteNonQuery();

        }
    }
}
  
