using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using static System.Collections.Specialized.BitVector32;
using Microsoft.VisualBasic;

namespace CapaDatos
{
    public class CD_Empleados
    {
        private BD_Conexion Conexion = new BD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand cmd = new SqlCommand();

        public DataTable Mostrar()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexion.AbrirConexion();
            cmd.CommandText = "Select es.EmpleadoID,e.Nombre, es.SeccionID, s.Nombre from EmpleadosSecciones es join Empleados e with(nolock) on e.EmpleadoID = es.EmpleadoID join Secciones s with(nolock) on s.SeccionID = es.SeccionID";
            leer = cmd.ExecuteReader();
            tabla.Load(leer);
            Conexion.CerrarConexion();
            return tabla;
        }


        public void Insertar(String Nombre)

        {
                        
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexion.AbrirConexion();
            cmd.CommandText = "InsertarEmpleados";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre", Nombre);            
            cmd.ExecuteNonQuery();
        }

        public void InsertarEmpleadoSeccion(String Seccion)

        {
            String TipoProveedor = Seccion;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexion.AbrirConexion();
            cmd.CommandText = "InsertarEmpleadosSeccion";
            cmd.CommandType = CommandType.StoredProcedure;
            if (TipoProveedor == "Informatica")
            {
                cmd.Parameters.AddWithValue("@IDSeccion", 1);
            }
            else if (TipoProveedor == "Aseo")
            {
                cmd.Parameters.AddWithValue("@IDSeccion", 2);
            }
            else if (TipoProveedor == "Gestion Humana")
            {
                cmd.Parameters.AddWithValue("@IDSeccion", 3);
            }
            else if (TipoProveedor == "Comercial")
            {
                cmd.Parameters.AddWithValue("@IDSeccion", 4);
            }
            else if (TipoProveedor == "Gerencia")
            {
                cmd.Parameters.AddWithValue("@IDSeccion", 5);
            }
            else if (TipoProveedor == "Seguridad")
            {
                cmd.Parameters.AddWithValue("@IDSeccion", 6);
            }
            else if (TipoProveedor == "Marketing")
            {
                cmd.Parameters.AddWithValue("@IDSeccion", 7);
            }
            else if (TipoProveedor == "Contabilidad")
            {
                cmd.Parameters.AddWithValue("@IDSeccion", 8);
            }
            cmd.Parameters.AddWithValue("@IDEmpleado", 0);
            cmd.ExecuteNonQuery();
        }

        public void Editar(String Nombre, int ClienteID)

        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexion.AbrirConexion();
            cmd.CommandText = "ActualizarEmpleado";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre", Nombre);          
            cmd.Parameters.AddWithValue("@EmpleadoID", ClienteID);
            cmd.ExecuteNonQuery();

        }

        public void EditarEmpleadoSeccion(int ClienteID, String SeccionID)
        {
            String TipoProveedor = SeccionID;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexion.AbrirConexion();
            cmd.CommandText = "ActualizarEmpleadoSeccion";
            cmd.CommandType = CommandType.StoredProcedure;
            if (TipoProveedor == "Informatica")
            {
                cmd.Parameters.AddWithValue("@IDSeccion", 1);
            }
            if (TipoProveedor == "Aseo")
            {
                cmd.Parameters.AddWithValue("@IDSeccion", 2);
            }
            cmd.Parameters.AddWithValue("@EmpleadoID", ClienteID);
            cmd.Parameters.AddWithValue("@IDSeccionActual", 0);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();

        }

        public void Eliminar(int ClienteID, int SeccionID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conexion.AbrirConexion();
            cmd.CommandText = "EliminarEmpleados";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SeccionID", SeccionID);
            cmd.Parameters.AddWithValue("@ClienteID", ClienteID);
            cmd.ExecuteNonQuery();

        }
    }
}
  
