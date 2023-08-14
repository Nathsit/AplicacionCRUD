using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace CapaDatos
{
    public class CD_Clientes
    {
        private  BD_Conexion Conexion = new BD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand cmd = new SqlCommand();

        public DataTable Mostrar()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexion.AbrirConexion();
            cmd.CommandText = "select c.ClienteID,c.Nombre[Nombre Completo], c.Direccion,tc.Tipo[TipoCliente],c.OtrosCampos[Descripcion] from Clientes c " +
             "join TipoCliente tc WITH(nolock) on tc.TipoClienteID = c.TipoClienteID";
            leer = cmd.ExecuteReader();
            tabla.Load(leer);
            Conexion.CerrarConexion();
            return tabla;
        }

        public void Insertar(String Nombre, String Direccion, String Tipo, String Otros)

        {
            String TipoPersona = Tipo;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexion.AbrirConexion();
            cmd.CommandText = "InsertarClientes";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Direccion", Direccion);
            if (TipoPersona == "Persona Natural")
            {
                cmd.Parameters.AddWithValue("@Tipo", 1);
            }
            else
            {
                cmd.Parameters.AddWithValue("@Tipo", 2);
            }
            cmd.Parameters.AddWithValue("@Otros", Otros);
            cmd.ExecuteNonQuery();

        }

        public void Editar (String Nombre, String Direccion, String Tipo, String Otros, int ClienteID)
        {
            String TipoPersona = Tipo;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexion.AbrirConexion();
            cmd.CommandText = "ActualizarClientes";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre",Nombre);
            cmd.Parameters.AddWithValue("@Direccion", Direccion);
            if (TipoPersona == "Persona Natural")
            {
                cmd.Parameters.AddWithValue("@Tipo", 1);
            }
            else
            {
                cmd.Parameters.AddWithValue("@Tipo", 2);
            }
            cmd.Parameters.AddWithValue("@Otros", Otros);
            cmd.Parameters.AddWithValue("@ClienteID", ClienteID);
            cmd.ExecuteNonQuery();
        }

        public void Eliminar(int ClienteID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexion.AbrirConexion();
            cmd.CommandText = "EliminarClientes";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ClienteID", ClienteID);
            cmd.ExecuteNonQuery();

        }
    }
}
