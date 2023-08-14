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
    public class CN_Empleados
    {
        private CD_Empleados ObjetoCD = new CD_Empleados();

        public DataTable MostrarEmpleados()
        {
            DataTable tabla = new DataTable();
            tabla = ObjetoCD.Mostrar();
            return tabla;
        }

        public void InsertarEmpleado(String Nombre)
        {
            ObjetoCD.Insertar(Nombre);
        }
        public void InsertarEmpleadoSeccion(String Seccion)
        {
            ObjetoCD.InsertarEmpleadoSeccion(Seccion);
        }


        public void EditarEmpleado(String Nombre, String ClienteID)
        {
            ObjetoCD.Editar(Nombre, Convert.ToInt32(ClienteID));
        }

        public void EditarEmpleadoSeccion(String ClienteID, String SeccionID)
        {
            ObjetoCD.EditarEmpleadoSeccion(Convert.ToInt32(ClienteID), SeccionID);
        }
        public void EliminarEmpleadoSeccion(String ClienteID, String SeccionID)
        {
            ObjetoCD.Eliminar(Convert.ToInt32(ClienteID), Convert.ToInt32(SeccionID));
        }
    }
}
