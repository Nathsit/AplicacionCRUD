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
    public class CN_Productos
    {
        private CD_Productos ObjetoCD = new CD_Productos();

        public DataTable MostrarProductos()
        {
            DataTable tabla = new DataTable();
            tabla = ObjetoCD.Mostrar();
            return tabla;
        }

        public void InsertarProducto(String Nombre, String Precio, String Tipo)
        {
            ObjetoCD.Insertar(Nombre, Convert.ToInt32(Precio), Tipo);
        }

        public void EditarProducto(String Nombre, String Precio, String Tipo, String ProductoID)
        {
            ObjetoCD.Editar(Nombre, Convert.ToInt32(Precio), Tipo,  Convert.ToInt32(ProductoID));
        }

        public void EliminarProducto(String ProductoID)
        {
            ObjetoCD.Eliminar(Convert.ToInt32(ProductoID));
        }
    }
}
