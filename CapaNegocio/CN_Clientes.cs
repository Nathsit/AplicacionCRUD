using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Clientes
    {
        private CD_Clientes ObjetoCD = new CD_Clientes();
        
        public DataTable MostrarClientes()
        {
            DataTable tabla = new DataTable();
            tabla = ObjetoCD.Mostrar();
            return tabla;
        }



        public void InsertarClientes(String Nombre, String Direccion, String Tipo, String Otros)
        {
            ObjetoCD.Insertar(Nombre,Direccion, Tipo, Otros);
        }

        public void EditarCliente(String Nombre, String Direccion, String Tipo, String Otros, String ClienteID)
        {
            ObjetoCD.Editar(Nombre, Direccion, Tipo, Otros, Convert.ToInt32(ClienteID));
        }

        public void EliminarCliente(String ClienteID)
        {
            ObjetoCD.Eliminar(Convert.ToInt32(ClienteID));
        }
    }
}
