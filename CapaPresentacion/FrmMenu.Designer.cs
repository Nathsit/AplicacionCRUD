namespace CapaPresentacion
{
    partial class FrmMenu
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
            panel1 = new Panel();
            panel5 = new Panel();
            label1 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel4 = new Panel();
            panel3 = new Panel();
            pictureBox6 = new PictureBox();
            label2 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(components);
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 700);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(label1);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(pictureBox5);
            panel5.Controls.Add(pictureBox4);
            panel5.Controls.Add(pictureBox3);
            panel5.Location = new Point(236, 86);
            panel5.Name = "panel5";
            panel5.Size = new Size(961, 483);
            panel5.TabIndex = 3;
            panel5.Paint += panel5_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(192, 44);
            label1.Name = "label1";
            label1.Size = new Size(614, 55);
            label1.TabIndex = 8;
            label1.Text = "Seleccione el portal a ingresar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(678, 365);
            label5.Name = "label5";
            label5.Size = new Size(260, 65);
            label5.TabIndex = 7;
            label5.Text = "Empleados";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(350, 365);
            label4.Name = "label4";
            label4.Size = new Size(247, 65);
            label4.TabIndex = 6;
            label4.Text = "Productos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(51, 365);
            label3.Name = "label3";
            label3.Size = new Size(205, 65);
            label3.TabIndex = 5;
            label3.Text = "Clientes";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.empleo;
            pictureBox5.Location = new Point(713, 141);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(182, 201);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Producto;
            pictureBox4.Location = new Point(385, 141);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(182, 201);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Clientes;
            pictureBox3.Location = new Point(65, 141);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(182, 201);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(51, 65, 69);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(230, 575);
            panel4.Name = "panel4";
            panel4.Size = new Size(970, 125);
            panel4.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(214, 61, 92);
            panel3.Controls.Add(pictureBox6);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(230, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(970, 80);
            panel3.TabIndex = 1;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.tarjeta_de_credito;
            pictureBox6.Location = new Point(19, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(67, 65);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 8;
            pictureBox6.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(92, 13);
            label2.Name = "label2";
            label2.Size = new Size(200, 55);
            label2.TabIndex = 1;
            label2.Text = "CrediFIA";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(29, 34, 39);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(230, 700);
            panel2.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.Window;
            label8.Location = new Point(40, 413);
            label8.Name = "label8";
            label8.Size = new Size(130, 48);
            label8.TabIndex = 4;
            label8.Text = "Tienda";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(49, 319);
            label7.Name = "label7";
            label7.Size = new Size(112, 48);
            label7.TabIndex = 3;
            label7.Text = "Cargo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(40, 227);
            label6.Name = "label6";
            label6.Size = new Size(147, 48);
            label6.TabIndex = 2;
            label6.Text = "Nombre";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.cerrar_sesion;
            pictureBox2.Location = new Point(58, 575);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(89, 96);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.hombre;
            pictureBox1.Location = new Point(21, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 183);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 15;
            bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            bunifuDragControl1.Fixed = true;
            bunifuDragControl1.Horizontal = true;
            bunifuDragControl1.TargetControl = panel3;
            bunifuDragControl1.Vertical = true;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 700);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1200, 700);
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMenu";
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox6;
        private Label label1;
        private Label label8;
        private Label label7;
        private Label label6;
    }
}