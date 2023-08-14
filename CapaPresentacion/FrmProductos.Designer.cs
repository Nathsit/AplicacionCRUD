namespace CapaPresentacion
{
    partial class FrmProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            TextNombre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            BoxTipoProveedores = new ComboBox();
            TextPrecio = new TextBox();
            label4 = new Label();
            TextDireccion = new TextBox();
            BtnAgregar = new Button();
            label1 = new Label();
            panel2 = new Panel();
            BtnEditar = new Button();
            button2 = new Button();
            button1 = new Button();
            BtmEliminar = new Button();
            label5 = new Label();
            DataTablaProductos = new DataGridView();
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataTablaProductos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(214, 61, 92);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(TextNombre);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(BoxTipoProveedores);
            panel1.Controls.Add(TextPrecio);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(TextDireccion);
            panel1.Controls.Add(BtnAgregar);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(987, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(325, 660);
            panel1.TabIndex = 16;
            // 
            // button3
            // 
            button3.BackColor = Color.LightPink;
            button3.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(82, 574);
            button3.Name = "button3";
            button3.Size = new Size(204, 57);
            button3.TabIndex = 16;
            button3.Text = "Limpiar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.agregar_producto;
            pictureBox1.Location = new Point(82, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // TextNombre
            // 
            TextNombre.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextNombre.Location = new Point(31, 219);
            TextNombre.Name = "TextNombre";
            TextNombre.Size = new Size(272, 31);
            TextNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(214, 61, 92);
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(31, 264);
            label2.Name = "label2";
            label2.Size = new Size(72, 29);
            label2.TabIndex = 4;
            label2.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(214, 61, 92);
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(31, 339);
            label3.Name = "label3";
            label3.Size = new Size(195, 29);
            label3.TabIndex = 6;
            label3.Text = "Nombre Proveedor";
            // 
            // BoxTipoProveedores
            // 
            BoxTipoProveedores.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            BoxTipoProveedores.FormattingEnabled = true;
            BoxTipoProveedores.Items.AddRange(new object[] { "Proveedor A", "Nico Creditos" });
            BoxTipoProveedores.Location = new Point(31, 371);
            BoxTipoProveedores.Name = "BoxTipoProveedores";
            BoxTipoProveedores.Size = new Size(272, 33);
            BoxTipoProveedores.TabIndex = 13;
            BoxTipoProveedores.Text = "Proveedores";
            // 
            // TextPrecio
            // 
            TextPrecio.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextPrecio.Location = new Point(31, 296);
            TextPrecio.Name = "TextPrecio";
            TextPrecio.Size = new Size(272, 31);
            TextPrecio.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(214, 61, 92);
            label4.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(32, 421);
            label4.Name = "label4";
            label4.Size = new Size(207, 29);
            label4.TabIndex = 8;
            label4.Text = "Direccion Proveedor";
            // 
            // TextDireccion
            // 
            TextDireccion.Enabled = false;
            TextDireccion.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextDireccion.Location = new Point(32, 453);
            TextDireccion.Name = "TextDireccion";
            TextDireccion.Size = new Size(272, 31);
            TextDireccion.TabIndex = 7;
            TextDireccion.TextChanged += TextDireccion_TextChanged;
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackColor = Color.SpringGreen;
            BtnAgregar.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAgregar.Location = new Point(82, 502);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(204, 57);
            BtnAgregar.TabIndex = 9;
            BtnAgregar.Text = "Guardar";
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(214, 61, 92);
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(31, 187);
            label1.Name = "label1";
            label1.Size = new Size(221, 29);
            label1.TabIndex = 2;
            label1.Text = "Nombre Del Producto";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(51, 65, 69);
            panel2.Controls.Add(BtnEditar);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(BtmEliminar);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 535);
            panel2.Name = "panel2";
            panel2.Size = new Size(987, 125);
            panel2.TabIndex = 17;
            // 
            // BtnEditar
            // 
            BtnEditar.BackColor = Color.DeepSkyBlue;
            BtnEditar.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnEditar.Location = new Point(28, 32);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(188, 66);
            BtnEditar.TabIndex = 16;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = false;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Menu;
            button2.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(479, 32);
            button2.Name = "button2";
            button2.Size = new Size(188, 66);
            button2.TabIndex = 15;
            button2.Text = "Volver";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 255);
            button1.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(715, 32);
            button1.Name = "button1";
            button1.Size = new Size(188, 66);
            button1.TabIndex = 14;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // BtmEliminar
            // 
            BtmEliminar.BackColor = Color.OrangeRed;
            BtmEliminar.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtmEliminar.Location = new Point(252, 32);
            BtmEliminar.Name = "BtmEliminar";
            BtmEliminar.Size = new Size(188, 66);
            BtmEliminar.TabIndex = 11;
            BtmEliminar.Text = "Eliminar";
            BtmEliminar.UseVisualStyleBackColor = false;
            BtmEliminar.Click += BtmEliminar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(234, 9);
            label5.Name = "label5";
            label5.Size = new Size(552, 55);
            label5.TabIndex = 18;
            label5.Text = "LISTADO DE PRODUCTOS";
            // 
            // DataTablaProductos
            // 
            DataTablaProductos.AllowUserToAddRows = false;
            DataTablaProductos.AllowUserToDeleteRows = false;
            DataTablaProductos.AllowUserToResizeColumns = false;
            DataTablaProductos.AllowUserToResizeRows = false;
            DataTablaProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataTablaProductos.BackgroundColor = Color.White;
            DataTablaProductos.BorderStyle = BorderStyle.None;
            DataTablaProductos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataTablaProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataTablaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DataTablaProductos.ColumnHeadersHeight = 29;
            DataTablaProductos.EnableHeadersVisualStyles = false;
            DataTablaProductos.GridColor = SystemColors.MenuHighlight;
            DataTablaProductos.Location = new Point(28, 93);
            DataTablaProductos.Name = "DataTablaProductos";
            DataTablaProductos.ReadOnly = true;
            DataTablaProductos.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            DataTablaProductos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            DataTablaProductos.RowTemplate.Height = 29;
            DataTablaProductos.Size = new Size(917, 422);
            DataTablaProductos.TabIndex = 19;
            DataTablaProductos.CellContentClick += DataTablaProductos_CellContentClick;
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 5;
            bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            bunifuDragControl1.Fixed = true;
            bunifuDragControl1.Horizontal = true;
            bunifuDragControl1.TargetControl = null;
            bunifuDragControl1.Vertical = true;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1312, 660);
            Controls.Add(DataTablaProductos);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmProductos";
            Load += FrmProductos_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataTablaProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void BoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox TextNombre;
        private Label label2;
        private Label label3;
        private TextBox TextPrecio;
        private Label label4;
        private TextBox TextDireccion;
        private Button BtnAgregar;
        private Label label1;
        private Panel panel2;
        private Button button2;
        private Button button1;
        private Button BtmEliminar;
        private Button BtnEditar;
        private Label label5;
        private DataGridView DataTablaProductos;
        private ComboBox BoxTipoProveedores;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Button button3;
    }
}