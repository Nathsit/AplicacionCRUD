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
    public partial class FrmEmpleados : Form
    {
        CN_Empleados ObjetoCN = new CN_Empleados();
        private bool Editar = false;
        private String IDEmpleado = null;
        private String IDSeccion = null;

        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void MostrarEmpleados()
        {
            CN_Empleados Objeto = new CN_Empleados();
            DataTablaEmpleados.DataSource = Objeto.MostrarEmpleados();

        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            MostrarEmpleados();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMenu frm = new FrmMenu();
            frm.Show();
            this.Hide();
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

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = CapaPresentacion.Properties.Resources.agregar_producto;

            if (Editar == false)
            {
                try
                {
                    ObjetoCN.InsertarEmpleado(TextNombre.Text);
                    ObjetoCN.InsertarEmpleadoSeccion(BoxTipoSecciones.Text);
                    MessageBox.Show("Se Agrego Cliente Correctamente");
                    MostrarEmpleados();
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
                    ObjetoCN.EditarEmpleado(TextNombre.Text, IDEmpleado);
                    //ObjetoCN.EditarEmpleadoSeccion(IDEmpleado, BoxTipoSecciones.Text);
                    
                    MessageBox.Show("Se Actualizó el Cliente Correctamente");
                    MostrarEmpleados();
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
            BoxTipoSecciones.ResetText();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            BoxTipoSecciones.Enabled = false;
            if (DataTablaEmpleados.SelectedRows.Count > 0)
            {
                pictureBox1.Image = CapaPresentacion.Properties.Resources.editar;
                Editar = true;
                TextNombre.Text = DataTablaEmpleados.CurrentRow.Cells[1].Value.ToString();
                IDEmpleado = DataTablaEmpleados.CurrentRow.Cells[0].Value.ToString();
                IDSeccion = DataTablaEmpleados.CurrentRow.Cells[2].Value.ToString();
                BoxTipoSecciones.Text = DataTablaEmpleados.CurrentRow.Cells[3].Value.ToString();

            }
            else
            {
                MessageBox.Show("Seleccione una Fila para editar");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = CapaPresentacion.Properties.Resources.agregar_producto;
            Limpiar();
            Editar = false;
        }

        private void BtmEliminar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Estas seguro de eliminar el producto?", "", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                if (DataTablaEmpleados.SelectedRows.Count > 0)
                {
                    IDEmpleado = DataTablaEmpleados.CurrentRow.Cells[0].Value.ToString();
                    IDSeccion = DataTablaEmpleados.CurrentRow.Cells[2].Value.ToString();
                    ObjetoCN.EliminarEmpleadoSeccion(IDEmpleado,IDSeccion);
                    MessageBox.Show("Se Elimino el producto Correctamente");
                    MostrarEmpleados();
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
    }
}
