namespace Veterinaria__VIP_1._0_
{
    partial class PaginaPrincipal
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
            LLsEstetico = new LinkLabel();
            LLsMedico = new LinkLabel();
            ImageVIP = new PictureBox();
            lblEMERGENCIA = new LinkLabel();
            panel1 = new Panel();
            picturegif = new PictureBox();
            menuStrip1 = new MenuStrip();
            irToolStripMenuItem = new ToolStripMenuItem();
            foroToolStripMenuItem = new ToolStripMenuItem();
            ventasToolStripMenuItem = new ToolStripMenuItem();
            serviciosToolStripMenuItem = new ToolStripMenuItem();
            medicoToolStripMenuItem = new ToolStripMenuItem();
            esteticoToolStripMenuItem = new ToolStripMenuItem();
            OpcionesToolStripMenuItem = new ToolStripMenuItem();
            MiPerfilToolStripMenuItem = new ToolStripMenuItem();
            perfilDeMiMascotaToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesionToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            Ventastxt = new LinkLabel();
            Forotxt = new LinkLabel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)ImageVIP).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picturegif).BeginInit();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // LLsEstetico
            // 
            LLsEstetico.AutoSize = true;
            LLsEstetico.BackColor = Color.Transparent;
            LLsEstetico.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LLsEstetico.LinkColor = Color.Black;
            LLsEstetico.Location = new Point(85, 509);
            LLsEstetico.Name = "LLsEstetico";
            LLsEstetico.Size = new Size(128, 25);
            LLsEstetico.TabIndex = 87;
            LLsEstetico.TabStop = true;
            LLsEstetico.Text = "Servicio Estético";
            LLsEstetico.LinkClicked += LLsEstetico_LinkClicked_1;
            // 
            // LLsMedico
            // 
            LLsMedico.AutoSize = true;
            LLsMedico.BackColor = Color.Transparent;
            LLsMedico.Font = new Font("Bahnschrift Condensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LLsMedico.LinkColor = Color.Black;
            LLsMedico.Location = new Point(85, 441);
            LLsMedico.Name = "LLsMedico";
            LLsMedico.Size = new Size(124, 27);
            LLsMedico.TabIndex = 86;
            LLsMedico.TabStop = true;
            LLsMedico.Text = "Servicio Médico";
            LLsMedico.UseMnemonic = false;
            LLsMedico.LinkClicked += LLsMedico_LinkClicked_1;
            // 
            // ImageVIP
            // 
            ImageVIP.BackColor = Color.Transparent;
            ImageVIP.Image = Properties.Resources.VeteVip_Logo;
            ImageVIP.Location = new Point(-4, 27);
            ImageVIP.Name = "ImageVIP";
            ImageVIP.Size = new Size(259, 252);
            ImageVIP.SizeMode = PictureBoxSizeMode.StretchImage;
            ImageVIP.TabIndex = 73;
            ImageVIP.TabStop = false;
            // 
            // lblEMERGENCIA
            // 
            lblEMERGENCIA.ActiveLinkColor = Color.Red;
            lblEMERGENCIA.AutoSize = true;
            lblEMERGENCIA.BackColor = Color.White;
            lblEMERGENCIA.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblEMERGENCIA.LinkColor = Color.Black;
            lblEMERGENCIA.Location = new Point(20, 12);
            lblEMERGENCIA.Name = "lblEMERGENCIA";
            lblEMERGENCIA.Size = new Size(239, 24);
            lblEMERGENCIA.TabIndex = 209;
            lblEMERGENCIA.TabStop = true;
            lblEMERGENCIA.Text = "Haz clic aqui si es una emergencia";
            lblEMERGENCIA.LinkClicked += lblEMERGENCIA_LinkClicked;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblEMERGENCIA);
            panel1.Controls.Add(picturegif);
            panel1.Location = new Point(0, 583);
            panel1.Name = "panel1";
            panel1.Size = new Size(259, 167);
            panel1.TabIndex = 214;
            // 
            // picturegif
            // 
            picturegif.Image = Properties.Resources.Animation___1695503735344;
            picturegif.Location = new Point(70, 9);
            picturegif.Name = "picturegif";
            picturegif.Size = new Size(143, 143);
            picturegif.SizeMode = PictureBoxSizeMode.Zoom;
            picturegif.TabIndex = 210;
            picturegif.TabStop = false;
            picturegif.Click += picturegif_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { irToolStripMenuItem, serviciosToolStripMenuItem, OpcionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1465, 24);
            menuStrip1.TabIndex = 215;
            menuStrip1.Text = "menuStrip1";
            // 
            // irToolStripMenuItem
            // 
            irToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { foroToolStripMenuItem, ventasToolStripMenuItem });
            irToolStripMenuItem.Name = "irToolStripMenuItem";
            irToolStripMenuItem.Size = new Size(26, 20);
            irToolStripMenuItem.Text = "Ir";
            // 
            // foroToolStripMenuItem
            // 
            foroToolStripMenuItem.Name = "foroToolStripMenuItem";
            foroToolStripMenuItem.Size = new Size(109, 22);
            foroToolStripMenuItem.Text = "Foro";
            foroToolStripMenuItem.Click += foroToolStripMenuItem_Click;
            // 
            // ventasToolStripMenuItem
            // 
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new Size(109, 22);
            ventasToolStripMenuItem.Text = "Tienda";
            ventasToolStripMenuItem.Click += ventasToolStripMenuItem_Click;
            // 
            // serviciosToolStripMenuItem
            // 
            serviciosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { medicoToolStripMenuItem, esteticoToolStripMenuItem });
            serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            serviciosToolStripMenuItem.Size = new Size(65, 20);
            serviciosToolStripMenuItem.Text = "Servicios";
            // 
            // medicoToolStripMenuItem
            // 
            medicoToolStripMenuItem.Name = "medicoToolStripMenuItem";
            medicoToolStripMenuItem.Size = new Size(115, 22);
            medicoToolStripMenuItem.Text = "Medico";
            medicoToolStripMenuItem.Click += medicoToolStripMenuItem_Click;
            // 
            // esteticoToolStripMenuItem
            // 
            esteticoToolStripMenuItem.Name = "esteticoToolStripMenuItem";
            esteticoToolStripMenuItem.Size = new Size(115, 22);
            esteticoToolStripMenuItem.Text = "Estetico";
            esteticoToolStripMenuItem.Click += esteticoToolStripMenuItem_Click;
            // 
            // OpcionesToolStripMenuItem
            // 
            OpcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MiPerfilToolStripMenuItem, perfilDeMiMascotaToolStripMenuItem, cerrarSesionToolStripMenuItem });
            OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem";
            OpcionesToolStripMenuItem.Size = new Size(95, 20);
            OpcionesToolStripMenuItem.Text = "Configuracion";
            // 
            // MiPerfilToolStripMenuItem
            // 
            MiPerfilToolStripMenuItem.Name = "MiPerfilToolStripMenuItem";
            MiPerfilToolStripMenuItem.Size = new Size(182, 22);
            MiPerfilToolStripMenuItem.Text = "Mi perfil";
            MiPerfilToolStripMenuItem.Click += MiPerfilToolStripMenuItem_Click;
            // 
            // perfilDeMiMascotaToolStripMenuItem
            // 
            perfilDeMiMascotaToolStripMenuItem.Name = "perfilDeMiMascotaToolStripMenuItem";
            perfilDeMiMascotaToolStripMenuItem.Size = new Size(182, 22);
            perfilDeMiMascotaToolStripMenuItem.Text = "Perfil de mi mascota";
            perfilDeMiMascotaToolStripMenuItem.Click += perfilDeMiMascotaToolStripMenuItem_Click;
            // 
            // cerrarSesionToolStripMenuItem
            // 
            cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            cerrarSesionToolStripMenuItem.Size = new Size(182, 22);
            cerrarSesionToolStripMenuItem.Text = "Cerrar sesion";
            cerrarSesionToolStripMenuItem.Click += cerrarSesionToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(Ventastxt);
            panel2.Controls.Add(Forotxt);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(LLsMedico);
            panel2.Controls.Add(LLsEstetico);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(ImageVIP);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox4);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(259, 737);
            panel2.TabIndex = 216;
            // 
            // Ventastxt
            // 
            Ventastxt.AutoSize = true;
            Ventastxt.BackColor = Color.Transparent;
            Ventastxt.Font = new Font("Bahnschrift Condensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Ventastxt.LinkColor = Color.Black;
            Ventastxt.Location = new Point(85, 360);
            Ventastxt.Name = "Ventastxt";
            Ventastxt.Size = new Size(60, 27);
            Ventastxt.TabIndex = 216;
            Ventastxt.TabStop = true;
            Ventastxt.Text = "Tienda";
            Ventastxt.UseMnemonic = false;
            Ventastxt.LinkClicked += Ventastxt_LinkClicked;
            // 
            // Forotxt
            // 
            Forotxt.AutoSize = true;
            Forotxt.BackColor = Color.Transparent;
            Forotxt.Font = new Font("Bahnschrift Condensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Forotxt.LinkColor = Color.Black;
            Forotxt.Location = new Point(85, 300);
            Forotxt.Name = "Forotxt";
            Forotxt.Size = new Size(43, 27);
            Forotxt.TabIndex = 215;
            Forotxt.TabStop = true;
            Forotxt.Text = "Foro";
            Forotxt.UseMnemonic = false;
            Forotxt.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Bf2IuMlCLl;
            pictureBox1.Location = new Point(43, 416);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 88;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.g3ZUUC3XJH;
            pictureBox2.Location = new Point(43, 493);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(49, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 89;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._3DQEtFHm0m;
            pictureBox3.Location = new Point(43, 345);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(49, 42);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 217;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.t5QD2BH6QH;
            pictureBox4.Location = new Point(43, 285);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(49, 42);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 218;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Noticia;
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(552, 500);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 217;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Noticia2;
            pictureBox6.Location = new Point(558, 0);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(457, 307);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 218;
            pictureBox6.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(228, 216, 220);
            panel3.Controls.Add(pictureBox6);
            panel3.Controls.Add(pictureBox5);
            panel3.Location = new Point(261, 27);
            panel3.Name = "panel3";
            panel3.Size = new Size(1192, 692);
            panel3.TabIndex = 219;
            // 
            // PaginaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(1465, 731);
            Controls.Add(menuStrip1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "PaginaPrincipal";
            FormClosing += PaginaPrincipal_FormClosing;
            Load += PaginaPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)ImageVIP).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picturegif).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private LinkLabel LLsEstetico;
        private LinkLabel LLsMedico;
        private PictureBox ImageVIP;
        private LinkLabel lblEMERGENCIA;
        private Button btnSalir;
        private Panel panel1;
        private PictureBox picturegif;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem OpcionesToolStripMenuItem;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private ToolStripMenuItem MiPerfilToolStripMenuItem;
        private ToolStripMenuItem irToolStripMenuItem;
        private ToolStripMenuItem foroToolStripMenuItem;
        private ToolStripMenuItem ventasToolStripMenuItem;
        private ToolStripMenuItem serviciosToolStripMenuItem;
        private ToolStripMenuItem medicoToolStripMenuItem;
        private ToolStripMenuItem esteticoToolStripMenuItem;
        private ToolStripMenuItem perfilDeMiMascotaToolStripMenuItem;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private LinkLabel Forotxt;
        private LinkLabel Ventastxt;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Panel panel3;
    }
}