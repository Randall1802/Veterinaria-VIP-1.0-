namespace Veterinaria__VIP_1._0_
{
    partial class InicioDeSesion
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
            btnIniciar = new Button();
            lnlInicioDeS = new Label();
            lLRegistrarse = new LinkLabel();
            label2 = new Label();
            txtPassword = new TextBox();
            lblNombreUsuario = new Label();
            labInf = new Label();
            txtUsuario = new TextBox();
            panel1 = new Panel();
            label3 = new Label();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnIniciar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnIniciar.BackColor = Color.FromArgb(147, 181, 198);
            btnIniciar.FlatAppearance.BorderColor = Color.FromArgb(201, 204, 213);
            btnIniciar.FlatAppearance.BorderSize = 0;
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnIniciar.Location = new Point(137, 407);
            btnIniciar.Margin = new Padding(3, 2, 3, 2);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(262, 39);
            btnIniciar.TabIndex = 31;
            btnIniciar.Text = "Iniciar sesion";
            btnIniciar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // lnlInicioDeS
            // 
            lnlInicioDeS.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lnlInicioDeS.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lnlInicioDeS.ForeColor = Color.Black;
            lnlInicioDeS.Location = new Point(12, 612);
            lnlInicioDeS.Name = "lnlInicioDeS";
            lnlInicioDeS.Size = new Size(262, 25);
            lnlInicioDeS.TabIndex = 29;
            lnlInicioDeS.Text = "¿Aún no cuentas con un usuario?";
            lnlInicioDeS.TextAlign = ContentAlignment.MiddleCenter;
            lnlInicioDeS.Click += lnlInicioDeS_Click;
            // 
            // lLRegistrarse
            // 
            lLRegistrarse.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lLRegistrarse.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lLRegistrarse.LinkColor = Color.Blue;
            lLRegistrarse.Location = new Point(269, 615);
            lLRegistrarse.Name = "lLRegistrarse";
            lLRegistrarse.Size = new Size(130, 22);
            lLRegistrarse.TabIndex = 27;
            lLRegistrarse.TabStop = true;
            lLRegistrarse.Text = "Regístrarme ahora";
            lLRegistrarse.TextAlign = ContentAlignment.MiddleCenter;
            lLRegistrarse.LinkClicked += lLRegistrarse_LinkClicked;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Bahnschrift Condensed", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 315);
            label2.Name = "label2";
            label2.Size = new Size(509, 37);
            label2.TabIndex = 25;
            label2.Text = "Contraseña";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Location = new Point(137, 355);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(262, 23);
            txtPassword.TabIndex = 24;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblNombreUsuario.Font = new Font("Bahnschrift Condensed", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreUsuario.ForeColor = Color.Black;
            lblNombreUsuario.Location = new Point(12, 254);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(509, 34);
            lblNombreUsuario.TabIndex = 23;
            lblNombreUsuario.Text = "Usuario";
            lblNombreUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labInf
            // 
            labInf.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labInf.Font = new Font("Russo One", 30F, FontStyle.Bold, GraphicsUnit.Point);
            labInf.ForeColor = Color.Black;
            labInf.Location = new Point(12, 196);
            labInf.Name = "labInf";
            labInf.RightToLeft = RightToLeft.No;
            labInf.Size = new Size(509, 58);
            labInf.TabIndex = 22;
            labInf.Text = "Bienvenido ";
            labInf.TextAlign = ContentAlignment.MiddleCenter;
            labInf.Click += labInf_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUsuario.Location = new Point(137, 290);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(262, 23);
            txtUsuario.TabIndex = 21;
            txtUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(228, 216, 220);
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnIniciar);
            panel1.Controls.Add(lLRegistrarse);
            panel1.Controls.Add(labInf);
            panel1.Controls.Add(lnlInicioDeS);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(lblNombreUsuario);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(pictureBox3);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(533, 664);
            panel1.TabIndex = 32;
            panel1.Paint += panel1_Paint;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.Font = new Font("ReservoirGrunge", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(3, 31);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(362, 42);
            label3.TabIndex = 34;
            label3.Text = "VETERINARIA";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("ReservoirGrunge", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(-9, 73);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(363, 42);
            label1.TabIndex = 32;
            label1.Text = " VIP";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.XszTKKiybN;
            pictureBox3.Location = new Point(176, -37);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(505, 208);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 33;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ImageInicio;
            pictureBox1.Location = new Point(527, 407);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(886, 257);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.VeteVip_Logo;
            pictureBox2.Location = new Point(580, -48);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(492, 471);
            pictureBox2.TabIndex = 34;
            pictureBox2.TabStop = false;
            // 
            // InicioDeSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1084, 661);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "InicioDeSesion";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VeteVip";
            FormClosing += InicioDeSesion_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnIniciar;
        private Label lnlInicioDeS;
        private LinkLabel lLRegistrarse;
        private Label label2;
        private TextBox txtPassword;
        private Label lblNombreUsuario;
        private Label labInf;
        private TextBox txtUsuario;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label3;
    }
}