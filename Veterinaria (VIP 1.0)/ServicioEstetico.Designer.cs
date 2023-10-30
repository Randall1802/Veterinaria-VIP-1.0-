namespace Veterinaria__VIP_1._0_
{
    partial class ServicioEstetico
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
            lblServicioMedico = new Label();
            lblNM = new Label();
            txtNM = new TextBox();
            label1 = new Label();
            txtSS = new TextBox();
            label2 = new Label();
            txtFC = new TextBox();
            label3 = new Label();
            txtHC = new TextBox();
            label4 = new Label();
            txtTP = new TextBox();
            btnCS = new Button();
            btnED = new Button();
            dataGridView1 = new DataGridView();
            btnVerCi = new Button();
            ImageVIP = new PictureBox();
            menuStrip1 = new MenuStrip();
            irToolStripMenuItem = new ToolStripMenuItem();
            foroToolStripMenuItem = new ToolStripMenuItem();
            tiendaToolStripMenuItem = new ToolStripMenuItem();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            serviciosToolStripMenuItem = new ToolStripMenuItem();
            medicoToolStripMenuItem = new ToolStripMenuItem();
            configuracionToolStripMenuItem = new ToolStripMenuItem();
            miPerfilToolStripMenuItem = new ToolStripMenuItem();
            perfilDeMiMascotaToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesionToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImageVIP).BeginInit();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblServicioMedico
            // 
            lblServicioMedico.AutoSize = true;
            lblServicioMedico.BorderStyle = BorderStyle.FixedSingle;
            lblServicioMedico.Font = new Font("Bahnschrift Condensed", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblServicioMedico.ForeColor = Color.Black;
            lblServicioMedico.Location = new Point(48, 288);
            lblServicioMedico.Name = "lblServicioMedico";
            lblServicioMedico.Size = new Size(177, 37);
            lblServicioMedico.TabIndex = 180;
            lblServicioMedico.Text = "Servicio Estético";
            // 
            // lblNM
            // 
            lblNM.AutoSize = true;
            lblNM.Font = new Font("Bahnschrift Condensed", 18.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNM.ForeColor = Color.Black;
            lblNM.Location = new Point(410, 122);
            lblNM.Name = "lblNM";
            lblNM.Size = new Size(196, 30);
            lblNM.TabIndex = 185;
            lblNM.Text = "Nombre de la Mascota";
            // 
            // txtNM
            // 
            txtNM.Location = new Point(407, 155);
            txtNM.Name = "txtNM";
            txtNM.Size = new Size(364, 23);
            txtNM.TabIndex = 184;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 18.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(410, 181);
            label1.Name = "label1";
            label1.Size = new Size(166, 30);
            label1.TabIndex = 187;
            label1.Text = "Servicio Solicitado";
            // 
            // txtSS
            // 
            txtSS.Location = new Point(407, 214);
            txtSS.Name = "txtSS";
            txtSS.Size = new Size(364, 23);
            txtSS.TabIndex = 186;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Condensed", 18.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(410, 244);
            label2.Name = "label2";
            label2.Size = new Size(144, 30);
            label2.TabIndex = 189;
            label2.Text = "Fecha de la Cita";
            // 
            // txtFC
            // 
            txtFC.Location = new Point(407, 277);
            txtFC.Name = "txtFC";
            txtFC.Size = new Size(364, 23);
            txtFC.TabIndex = 188;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Condensed", 18.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(410, 310);
            label3.Name = "label3";
            label3.Size = new Size(134, 30);
            label3.TabIndex = 191;
            label3.Text = "Hora de la Cita";
            // 
            // txtHC
            // 
            txtHC.Location = new Point(407, 343);
            txtHC.Name = "txtHC";
            txtHC.Size = new Size(364, 23);
            txtHC.TabIndex = 190;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift Condensed", 18.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(410, 378);
            label4.Name = "label4";
            label4.Size = new Size(115, 30);
            label4.TabIndex = 193;
            label4.Text = "Tipo de Pago";
            // 
            // txtTP
            // 
            txtTP.Location = new Point(407, 411);
            txtTP.Name = "txtTP";
            txtTP.Size = new Size(364, 23);
            txtTP.TabIndex = 192;
            // 
            // btnCS
            // 
            btnCS.BackColor = Color.White;
            btnCS.FlatStyle = FlatStyle.Popup;
            btnCS.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCS.Location = new Point(468, 458);
            btnCS.Name = "btnCS";
            btnCS.Size = new Size(242, 40);
            btnCS.TabIndex = 194;
            btnCS.Text = "Confirmar Servicio";
            btnCS.UseVisualStyleBackColor = false;
            btnCS.Click += btnCS_Click_1;
            // 
            // btnED
            // 
            btnED.BackColor = Color.White;
            btnED.FlatStyle = FlatStyle.Popup;
            btnED.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnED.Location = new Point(790, 635);
            btnED.Name = "btnED";
            btnED.Size = new Size(242, 41);
            btnED.TabIndex = 195;
            btnED.Text = "Eliminar Datos";
            btnED.UseVisualStyleBackColor = false;
            btnED.Click += btnED_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 328);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(247, 245);
            dataGridView1.TabIndex = 215;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // btnVerCi
            // 
            btnVerCi.FlatStyle = FlatStyle.Popup;
            btnVerCi.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerCi.Location = new Point(48, 579);
            btnVerCi.Name = "btnVerCi";
            btnVerCi.Size = new Size(177, 37);
            btnVerCi.TabIndex = 216;
            btnVerCi.Text = "Ver Citas";
            btnVerCi.UseVisualStyleBackColor = true;
            btnVerCi.Click += btnVerCi_Click;
            // 
            // ImageVIP
            // 
            ImageVIP.BackColor = Color.Transparent;
            ImageVIP.Image = Properties.Resources.VeteVip_Logo;
            ImageVIP.Location = new Point(0, 27);
            ImageVIP.Name = "ImageVIP";
            ImageVIP.Size = new Size(259, 252);
            ImageVIP.SizeMode = PictureBoxSizeMode.StretchImage;
            ImageVIP.TabIndex = 217;
            ImageVIP.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { irToolStripMenuItem, serviciosToolStripMenuItem, configuracionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1370, 24);
            menuStrip1.TabIndex = 218;
            menuStrip1.Text = "menuStrip1";
            // 
            // irToolStripMenuItem
            // 
            irToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { foroToolStripMenuItem, tiendaToolStripMenuItem, inicioToolStripMenuItem });
            irToolStripMenuItem.Name = "irToolStripMenuItem";
            irToolStripMenuItem.Size = new Size(26, 20);
            irToolStripMenuItem.Text = "Ir";
            // 
            // foroToolStripMenuItem
            // 
            foroToolStripMenuItem.Name = "foroToolStripMenuItem";
            foroToolStripMenuItem.Size = new Size(109, 22);
            foroToolStripMenuItem.Text = "Foro";
            // 
            // tiendaToolStripMenuItem
            // 
            tiendaToolStripMenuItem.Name = "tiendaToolStripMenuItem";
            tiendaToolStripMenuItem.Size = new Size(109, 22);
            tiendaToolStripMenuItem.Text = "Tienda";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(109, 22);
            inicioToolStripMenuItem.Text = "Inicio";
            inicioToolStripMenuItem.Click += inicioToolStripMenuItem_Click;
            // 
            // serviciosToolStripMenuItem
            // 
            serviciosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { medicoToolStripMenuItem });
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
            // 
            // cerrarSesionToolStripMenuItem
            // 
            cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            cerrarSesionToolStripMenuItem.Size = new Size(182, 22);
            cerrarSesionToolStripMenuItem.Text = "Cerrar sesion";
            cerrarSesionToolStripMenuItem.Click += cerrarSesionToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(228, 216, 220);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtTP);
            panel1.Controls.Add(btnCS);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnED);
            panel1.Controls.Add(txtHC);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtFC);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtSS);
            panel1.Controls.Add(lblNM);
            panel1.Controls.Add(txtNM);
            panel1.Location = new Point(264, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(1189, 695);
            panel1.TabIndex = 219;
            // 
            // ServicioEstetico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(1370, 731);
            Controls.Add(btnVerCi);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            Controls.Add(ImageVIP);
            Controls.Add(lblServicioMedico);
            MaximizeBox = false;
            Name = "ServicioEstetico";
            Text = "Servicio Estético";
            FormClosing += ServicioEstetico_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImageVIP).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblServicioMedico;
        private Label lblNM;
        private TextBox txtNM;
        private Label label1;
        private TextBox txtSS;
        private Label label2;
        private TextBox txtFC;
        private Label label3;
        private TextBox txtHC;
        private Label label4;
        private TextBox txtTP;
        private Button btnCS;
        private Button btnED;
        private DataGridView dataGridView1;
        private Button btnVerCi;
        private PictureBox ImageVIP;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem irToolStripMenuItem;
        private ToolStripMenuItem foroToolStripMenuItem;
        private ToolStripMenuItem tiendaToolStripMenuItem;
        private ToolStripMenuItem serviciosToolStripMenuItem;
        private ToolStripMenuItem medicoToolStripMenuItem;
        private ToolStripMenuItem configuracionToolStripMenuItem;
        private ToolStripMenuItem miPerfilToolStripMenuItem;
        private ToolStripMenuItem perfilDeMiMascotaToolStripMenuItem;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private Panel panel1;
        private ToolStripMenuItem inicioToolStripMenuItem;
    }
}