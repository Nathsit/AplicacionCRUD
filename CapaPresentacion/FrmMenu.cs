using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)


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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmProductos frm = new FrmProductos();
            frm.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FrmEmpleados frm = new FrmEmpleados();
            frm.Show();
            this.Hide();
        }
    }
}
