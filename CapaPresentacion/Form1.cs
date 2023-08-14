using CapaNegocio;
namespace CapaPresentacion
{
    public partial class Form1 : Form
    {

        CN_Clientes ObjetoCN = new CN_Clientes();
        private String IDCliente = null;
        private bool Editar = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarClientes();
        }

        private void MostrarClientes()
        {
            CN_Clientes Objeto = new CN_Clientes();
            DataTabla.DataSource = Objeto.MostrarClientes();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)


        {
            pictureBox1.Image = CapaPresentacion.Properties.Resources.usuario;

            if (Editar == false)
            {
                try
                {
                    ObjetoCN.InsertarClientes(TextNombre.Text, TextDireccion.Text, BoxTipo.Text, TextOtros.Text);
                    MessageBox.Show("Se Agrego Cliente Correctamente");
                    MostrarClientes();
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
                    ObjetoCN.EditarCliente(TextNombre.Text, TextDireccion.Text, BoxTipo.Text, TextOtros.Text, IDCliente);
                    MessageBox.Show("Se Actualizó el Cliente Correctamente");
                    MostrarClientes();
                    Limpiar();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Upss!! No se editaron los datos");

                }
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DataTabla.SelectedRows.Count > 0)
            {
                pictureBox1.Image = CapaPresentacion.Properties.Resources.editar;

                Editar = true;
                TextNombre.Text = DataTabla.CurrentRow.Cells[1].Value.ToString();
                IDCliente = DataTabla.CurrentRow.Cells[0].Value.ToString();
                TextDireccion.Text = DataTabla.CurrentRow.Cells[2].Value.ToString();
                BoxTipo.Text = DataTabla.CurrentRow.Cells[3].Value.ToString();
                TextOtros.Text = DataTabla.CurrentRow.Cells[4].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una Fila para editar");
            }
        }

        private void Limpiar()
        {
            TextNombre.Clear();
            TextDireccion.Clear();
            TextOtros.Clear();
            BoxTipo.ResetText();
        }

        private void BtmEliminar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Estas seguro de eliminar al cliente?", "", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                if (DataTabla.SelectedRows.Count > 0)
                {
                    IDCliente = DataTabla.CurrentRow.Cells[0].Value.ToString();
                    ObjetoCN.EliminarCliente(IDCliente);
                    MessageBox.Show("Se Elimino el Cliente Correctamente");
                    MostrarClientes();
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


        private void BoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private void DataTabla_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.DataTabla.Columns[e.ColumnIndex].Name == "TipoCliente")
            {
                if (Convert.ToString(e.Value) == "Persona Natural")
                {
                    
                    e.CellStyle.BackColor = Color.Yellow;
                }
                else
                {
                    e.CellStyle.BackColor = Color.SpringGreen;

                }
            }
        }
    }
}