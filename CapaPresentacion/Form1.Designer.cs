namespace CapaPresentacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataTabla = new DataGridView();
            TextNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TextDireccion = new TextBox();
            label4 = new Label();
            TextOtros = new TextBox();
            BtnAgregar = new Button();
            BtnEditar = new Button();
            BtmEliminar = new Button();
            label5 = new Label();
            BoxTipo = new ComboBox();
            button1 = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            button2 = new Button();
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(components);
            ((System.ComponentModel.ISupportInitialize)DataTabla).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // DataTabla
            // 
            DataTabla.AllowUserToAddRows = false;
            DataTabla.AllowUserToDeleteRows = false;
            DataTabla.AllowUserToResizeColumns = false;
            DataTabla.AllowUserToResizeRows = false;
            DataTabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataTabla.BackgroundColor = Color.White;
            DataTabla.BorderStyle = BorderStyle.None;
            DataTabla.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataTabla.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataTabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DataTabla.ColumnHeadersHeight = 29;
            DataTabla.EnableHeadersVisualStyles = false;
            DataTabla.GridColor = SystemColors.MenuHighlight;
            DataTabla.Location = new Point(32, 93);
            DataTabla.Name = "DataTabla";
            DataTabla.ReadOnly = true;
            DataTabla.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            DataTabla.RowsDefaultCellStyle = dataGridViewCellStyle2;
            DataTabla.RowTemplate.Height = 29;
            DataTabla.Size = new Size(884, 388);
            DataTabla.TabIndex = 0;
            DataTabla.CellFormatting += DataTabla_CellFormatting;
            // 
            // TextNombre
            // 
            TextNombre.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextNombre.Location = new Point(31, 238);
            TextNombre.Name = "TextNombre";
            TextNombre.Size = new Size(272, 31);
            TextNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(214, 61, 92);
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(31, 206);
            label1.Name = "label1";
            label1.Size = new Size(184, 29);
            label1.TabIndex = 2;
            label1.Text = "Nombre Completo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(214, 61, 92);
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(31, 283);
            label2.Name = "label2";
            label2.Size = new Size(160, 29);
            label2.TabIndex = 4;
            label2.Text = "Tipo de Cliente";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(214, 61, 92);
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(31, 364);
            label3.Name = "label3";
            label3.Size = new Size(101, 29);
            label3.TabIndex = 6;
            label3.Text = "Direccion";
            // 
            // TextDireccion
            // 
            TextDireccion.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextDireccion.Location = new Point(31, 396);
            TextDireccion.Name = "TextDireccion";
            TextDireccion.Size = new Size(272, 31);
            TextDireccion.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(214, 61, 92);
            label4.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(31, 452);
            label4.Name = "label4";
            label4.Size = new Size(69, 29);
            label4.TabIndex = 8;
            label4.Text = "Otros";
            // 
            // TextOtros
            // 
            TextOtros.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextOtros.Location = new Point(31, 484);
            TextOtros.Name = "TextOtros";
            TextOtros.Size = new Size(272, 31);
            TextOtros.TabIndex = 7;
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackColor = Color.SpringGreen;
            BtnAgregar.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAgregar.Location = new Point(82, 548);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(204, 57);
            BtnAgregar.TabIndex = 9;
            BtnAgregar.Text = "Guardar";
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.BackColor = Color.DeepSkyBlue;
            BtnEditar.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnEditar.Location = new Point(32, 548);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(188, 66);
            BtnEditar.TabIndex = 10;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = false;
            BtnEditar.Click += BtnEditar_Click;
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
            label5.Location = new Point(224, 22);
            label5.Name = "label5";
            label5.Size = new Size(510, 55);
            label5.TabIndex = 12;
            label5.Text = "LISTADO DE CLIENTES";
            // 
            // BoxTipo
            // 
            BoxTipo.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            BoxTipo.FormattingEnabled = true;
            BoxTipo.Items.AddRange(new object[] { "Persona Natural", "Persona Jurídica" });
            BoxTipo.Location = new Point(31, 315);
            BoxTipo.Name = "BoxTipo";
            BoxTipo.Size = new Size(272, 33);
            BoxTipo.TabIndex = 13;
            BoxTipo.Text = "Tipo de Clientes";
            BoxTipo.SelectedIndexChanged += BoxTipo_SelectedIndexChanged;
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(214, 61, 92);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(TextNombre);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(BoxTipo);
            panel1.Controls.Add(TextDireccion);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(TextOtros);
            panel1.Controls.Add(BtnAgregar);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(939, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(325, 641);
            panel1.TabIndex = 15;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.usuario;
            pictureBox1.Location = new Point(82, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(51, 65, 69);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(BtmEliminar);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 516);
            panel2.Name = "panel2";
            panel2.Size = new Size(939, 125);
            panel2.TabIndex = 16;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1264, 641);
            Controls.Add(BtnEditar);
            Controls.Add(panel2);
            Controls.Add(label5);
            Controls.Add(DataTabla);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DataTabla).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DataGridView DataTabla;
        private TextBox TextNombre;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TextDireccion;
        private Label label4;
        private TextBox TextOtros;
        private Button BtnAgregar;
        private Button BtnEditar;
        private Button BtmEliminar;
        private Label label5;
        private ComboBox BoxTipo;
        private Button button1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button button2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}