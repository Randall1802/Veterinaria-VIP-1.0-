namespace Veterinaria__VIP_1._0_
{
    partial class ForoVIP
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
			lblForo = new Label();
			txtConsulta = new TextBox();
			lblNU = new Label();
			rtInfo = new RichTextBox();
			btnRC = new Button();
			btnEC = new Button();
			menuStrip1 = new MenuStrip();
			irToolStripMenuItem = new ToolStripMenuItem();
			tiendaToolStripMenuItem = new ToolStripMenuItem();
			inicioToolStripMenuItem = new ToolStripMenuItem();
			serviciosToolStripMenuItem = new ToolStripMenuItem();
			medicoToolStripMenuItem = new ToolStripMenuItem();
			esteticoToolStripMenuItem = new ToolStripMenuItem();
			configuracionToolStripMenuItem = new ToolStripMenuItem();
			miPerfilToolStripMenuItem = new ToolStripMenuItem();
			perfilDeMiMascotaToolStripMenuItem = new ToolStripMenuItem();
			cerrarSesionToolStripMenuItem = new ToolStripMenuItem();
			ImageVIP = new PictureBox();
			panel1 = new Panel();
			menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)ImageVIP).BeginInit();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// lblForo
			// 
			lblForo.AutoSize = true;
			lblForo.BorderStyle = BorderStyle.FixedSingle;
			lblForo.Font = new Font("Bahnschrift Condensed", 30F, FontStyle.Bold, GraphicsUnit.Point);
			lblForo.ForeColor = Color.Black;
			lblForo.Location = new Point(0, 0);
			lblForo.Name = "lblForo";
			lblForo.Size = new Size(80, 50);
			lblForo.TabIndex = 107;
			lblForo.Text = "Foro";
			// 
			// txtConsulta
			// 
			txtConsulta.Location = new Point(510, 572);
			txtConsulta.Name = "txtConsulta";
			txtConsulta.Size = new Size(407, 23);
			txtConsulta.TabIndex = 108;
			// 
			// lblNU
			// 
			lblNU.AutoSize = true;
			lblNU.Font = new Font("Bahnschrift Condensed", 18.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblNU.ForeColor = Color.Black;
			lblNU.Location = new Point(344, 565);
			lblNU.Name = "lblNU";
			lblNU.Size = new Size(160, 30);
			lblNU.TabIndex = 139;
			lblNU.Text = "¿Cuál es su duda?";
			// 
			// rtInfo
			// 
			rtInfo.Location = new Point(49, 53);
			rtInfo.Name = "rtInfo";
			rtInfo.Size = new Size(1044, 500);
			rtInfo.TabIndex = 140;
			rtInfo.Text = "";
			// 
			// btnRC
			// 
			btnRC.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnRC.Location = new Point(344, 638);
			btnRC.Name = "btnRC";
			btnRC.Size = new Size(160, 37);
			btnRC.TabIndex = 215;
			btnRC.Text = "Realizar Consulta";
			btnRC.UseVisualStyleBackColor = true;
			btnRC.Click += btnRC_Click;
			// 
			// btnEC
			// 
			btnEC.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnEC.Location = new Point(757, 638);
			btnEC.Name = "btnEC";
			btnEC.Size = new Size(160, 37);
			btnEC.TabIndex = 216;
			btnEC.Text = "Enviar Consulta";
			btnEC.UseVisualStyleBackColor = true;
			btnEC.Click += btnEC_Click;
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { irToolStripMenuItem, serviciosToolStripMenuItem, configuracionToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(1370, 24);
			menuStrip1.TabIndex = 217;
			menuStrip1.Text = "menuStrip1";
			// 
			// irToolStripMenuItem
			// 
			irToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tiendaToolStripMenuItem, inicioToolStripMenuItem });
			irToolStripMenuItem.Name = "irToolStripMenuItem";
			irToolStripMenuItem.Size = new Size(26, 20);
			irToolStripMenuItem.Text = "Ir";
			// 
			// tiendaToolStripMenuItem
			// 
			tiendaToolStripMenuItem.Name = "tiendaToolStripMenuItem";
			tiendaToolStripMenuItem.Size = new Size(180, 22);
			tiendaToolStripMenuItem.Text = "Tienda";
			tiendaToolStripMenuItem.Click += tiendaToolStripMenuItem_Click;
			// 
			// inicioToolStripMenuItem
			// 
			inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
			inicioToolStripMenuItem.Size = new Size(180, 22);
			inicioToolStripMenuItem.Text = "Inicio";
			inicioToolStripMenuItem.Click += inicioToolStripMenuItem_Click;
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
			medicoToolStripMenuItem.Size = new Size(180, 22);
			medicoToolStripMenuItem.Text = "Medico";
			medicoToolStripMenuItem.Click += medicoToolStripMenuItem_Click;
			// 
			// esteticoToolStripMenuItem
			// 
			esteticoToolStripMenuItem.Name = "esteticoToolStripMenuItem";
			esteticoToolStripMenuItem.Size = new Size(180, 22);
			esteticoToolStripMenuItem.Text = "Estetico";
			esteticoToolStripMenuItem.Click += esteticoToolStripMenuItem_Click;
			// 
			// configuracionToolStripMenuItem
			// 
			configuracionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { miPerfilToolStripMenuItem, perfilDeMiMascotaToolStripMenuItem, cerrarSesionToolStripMenuItem });
			configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
			configuracionToolStripMenuItem.Size = new Size(95, 20);
			configuracionToolStripMenuItem.Text = "Configuracion";
			// 
			// miPerfilToolStripMenuItem
			// 
			miPerfilToolStripMenuItem.Enabled = false;
			miPerfilToolStripMenuItem.Name = "miPerfilToolStripMenuItem";
			miPerfilToolStripMenuItem.Size = new Size(182, 22);
			miPerfilToolStripMenuItem.Text = "Mi perfil";
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
			// ImageVIP
			// 
			ImageVIP.BackColor = Color.Transparent;
			ImageVIP.Image = Properties.Resources.VeteVip_Logo;
			ImageVIP.Location = new Point(0, 27);
			ImageVIP.Name = "ImageVIP";
			ImageVIP.Size = new Size(259, 252);
			ImageVIP.SizeMode = PictureBoxSizeMode.StretchImage;
			ImageVIP.TabIndex = 218;
			ImageVIP.TabStop = false;
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(228, 216, 220);
			panel1.Controls.Add(rtInfo);
			panel1.Controls.Add(lblForo);
			panel1.Controls.Add(btnEC);
			panel1.Controls.Add(txtConsulta);
			panel1.Controls.Add(btnRC);
			panel1.Controls.Add(lblNU);
			panel1.Location = new Point(265, 27);
			panel1.Name = "panel1";
			panel1.Size = new Size(1188, 692);
			panel1.TabIndex = 219;
			// 
			// ForoVIP
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSizeMode = AutoSizeMode.GrowAndShrink;
			BackColor = Color.White;
			ClientSize = new Size(1370, 731);
			Controls.Add(ImageVIP);
			Controls.Add(menuStrip1);
			Controls.Add(panel1);
			MaximizeBox = false;
			Name = "ForoVIP";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "ForoVIP";
			FormClosing += ForoVIP_FormClosing;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)ImageVIP).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label lblForo;
        private TextBox txtConsulta;
        private Label lblNU;
        private RichTextBox rtInfo;
        private Button btnRC;
        private Button btnEC;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem irToolStripMenuItem;
        private ToolStripMenuItem tiendaToolStripMenuItem;
        private ToolStripMenuItem serviciosToolStripMenuItem;
        private ToolStripMenuItem medicoToolStripMenuItem;
        private ToolStripMenuItem esteticoToolStripMenuItem;
        private ToolStripMenuItem configuracionToolStripMenuItem;
        private ToolStripMenuItem miPerfilToolStripMenuItem;
        private ToolStripMenuItem perfilDeMiMascotaToolStripMenuItem;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private PictureBox ImageVIP;
        private Panel panel1;
        private ToolStripMenuItem inicioToolStripMenuItem;
    }
}