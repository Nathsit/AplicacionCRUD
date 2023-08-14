using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmProductos : Form
    {

        CN_Productos ObjetoCN = new CN_Productos();
        private bool Editar = false;
        private String IDProducto = null;
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void MostrarProductos()
        {
            CN_Productos Objeto = new CN_Productos();
            DataTablaProductos.DataSource = Objeto.MostrarProductos();

        }

        private void DataTablaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Deseas Salir de la Aplicacion?", "", MessageBoxButtons.YesNo);
            if (r == DialogResult.No)
            {

            }
            else
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMenu frm = new FrmMenu();
            frm.Show();
            this.Hide();
        }

        private void FrmProductos_Load_1(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = CapaPresentacion.Properties.Resources.agregar_producto;

            if (Editar == false)
            {
                try
                {
                    ObjetoCN.InsertarProducto(TextNombre.Text, TextPrecio.Text, BoxTipoProveedores.Text);
                    MessageBox.Show("Se Agrego Cliente Correctamente");
                    MostrarProductos();
                    Limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Upss!! No se insertaron los datos");

                }
            }
            if (Editar == true)
            {
                try
                {
                    ObjetoCN.EditarProducto(TextNombre.Text, TextPrecio.Text, BoxTipoProveedores.Text, IDProducto);
                    MessageBox.Show("Se Actualizó el Cliente Correctamente");
                    MostrarProductos();
                    Limpiar();
                    Editar = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Upss!! No se editaron los datos");

                }
            }
        }

        private void Limpiar()
        {
            TextNombre.Clear();
            TextDireccion.Clear();
            TextPrecio.Clear();
            BoxTipoProveedores.ResetText();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DataTablaProductos.SelectedRows.Count > 0)
            {
                pictureBox1.Image = CapaPresentacion.Properties.Resources.editar;
                Editar = true;
                TextNombre.Text = DataTablaProductos.CurrentRow.Cells[1].Value.ToString();
                IDProducto = DataTablaProductos.CurrentRow.Cells[0].Value.ToString();
                TextPrecio.Text = DataTablaProductos.CurrentRow.Cells[2].Value.ToString();
                BoxTipoProveedores.Text = DataTablaProductos.CurrentRow.Cells[3].Value.ToString();
                TextDireccion.Text = DataTablaProductos.CurrentRow.Cells[4].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una Fila para editar");
            }
        }

        private void BtmEliminar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Estas seguro de eliminar el producto?", "", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                if (DataTablaProductos.SelectedRows.Count > 0)
                {
                    IDProducto = DataTablaProductos.CurrentRow.Cells[0].Value.ToString();
                    ObjetoCN.EliminarProducto(IDProducto);
                    MessageBox.Show("Se Elimino el producto Correctamente");
                    MostrarProductos();
                }
                else
                {
                    MessageBox.Show("Seleccione una Fila para Eliminar");
                }
            }
            else
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = CapaPresentacion.Properties.Resources.agregar_producto;
            Limpiar();
            Editar = false;
        }

        private void TextDireccion_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
