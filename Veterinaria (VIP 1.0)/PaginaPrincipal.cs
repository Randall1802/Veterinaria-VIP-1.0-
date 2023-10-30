using Negocio;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Veterinaria__VIP_1._0_
{
    public partial class PaginaPrincipal : Form
    {
        ConexionSQLN cn = new ConexionSQLN();

        private string user;
        //Rutas de las Imagenes
        private string rutaImagen1 = @"D:\ESCUELA 2023\VeteVIP\VeteVIP\Noticia.png";
        private string rutaImagen2 = @"D:\ESCUELA 2023\VeteVIP\VeteVIP\Noticia2.jpg";
        private string rutaImagen3 = @"D:\ESCUELA 2023\VeteVIP\VeteVIP\Noticia3.jpg";

        public PaginaPrincipal()
        {
            InitializeComponent();

        }

        public PaginaPrincipal(string user)
        {
            this.user = user;
            InitializeComponent();


        }

        //Movimiento de la Seccion de Noticias
        private List<Image> imagenes = new List<Image>();
        private int posicionActual = 0;



        private void lblEMERGENCIA_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Muestra un cuadro de diálogo para obtener el nombre de la mascota
            string nombreMascota;
            nombreMascota = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre de la mascota:", "Nombre de la mascota", "");

            // Verifica si se ingresó un nombre de mascota válido
            if (!string.IsNullOrEmpty(nombreMascota))
            {
                int resultado = cn.citaEmerg(user, nombreMascota);
                if (resultado == 1)
                {
                    MessageBox.Show("La Cita de Emergencia ha sido anexada");
                    DateTime horaActual = DateTime.Now;

                    // Suma 20 minutos a la hora actual
                    DateTime horaNueva = horaActual.AddMinutes(20);
                    MessageBox.Show("Fecha: "+horaNueva);
                }
                else
                {
                    MessageBox.Show("No se encontró una mascota con el nombre ingresado.", "Nombre de la mascota", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No se encontró una mascota con el nombre ingresado.", "Nombre de la mascota", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnForo_Click(object sender, EventArgs e)
        {
            ForoVIP formularioNuevo = new ForoVIP(user);
            this.Hide();
            formularioNuevo.Show();
            formularioNuevo.FormClosed += (s, args) => this.Close();
        }

        private void btnMascota_Click_1(object sender, EventArgs e)
        {
            PaginaMascota formularioNuevo = new PaginaMascota(user);
            this.Hide();
            formularioNuevo.Show();
            formularioNuevo.FormClosed += (s, args) => this.Close();
        }
        private void btnUsuario_Click_1(object sender, EventArgs e)
        {
            PaginaUsuario formularioNuevo = new PaginaUsuario(user);
            this.Hide();
            formularioNuevo.Show();
            formularioNuevo.FormClosed += (s, args) => this.Close();
        }

        private void btnVentas_Click_1(object sender, EventArgs e)
        {
            PaginaVentas formularioNuevo = new PaginaVentas(user);
            this.Hide();
            formularioNuevo.Show();
            formularioNuevo.FormClosed += (s, args) => this.Close();
        }

        private void LLsMedico_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ServicioVeterinario formularioNuevo = new ServicioVeterinario(user);
            this.Hide();
            formularioNuevo.Show();
            formularioNuevo.FormClosed += (s, args) => this.Close();
        }

        private void LLsEstetico_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ServicioEstetico formularioNuevo = new ServicioEstetico(user);
            this.Hide();
            formularioNuevo.Show();
            formularioNuevo.FormClosed += (s, args) => this.Close();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            DialogResult boton = MessageBox.Show("Realmente desea salir?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (boton == DialogResult.OK)
            {
                user = "";
                InicioDeSesion inicio = new InicioDeSesion();
                this.Hide();
                inicio.Show();
                inicio.FormClosed += (s, args) => this.Close();
            }
            else if (boton == DialogResult.Cancel)
            {
                btnSalir.Focus();
            }
        }

        private void PaginaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {


        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void pBMedicina_Click(object sender, EventArgs e)
        {

        }

        private void lblNoticias_Click(object sender, EventArgs e)
        {

        }

        private void picturegif_Click(object sender, EventArgs e)
        {
            // Muestra un cuadro de diálogo para obtener el nombre de la mascota
            string nombreMascota;
            nombreMascota = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre de la mascota:", "Nombre de la mascota", "");

            // Verifica si se ingresó un nombre de mascota válido
            if (!string.IsNullOrEmpty(nombreMascota))
            {
                int resultado = cn.citaEmerg(user, nombreMascota);
                if (resultado == 1)
                {
                    MessageBox.Show("La Cita de Emergencia ha sido anexada");
                }
                else
                {
                    MessageBox.Show("No se encontró una mascota con el nombre ingresado.", "Nombre de la mascota", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No se encontró una mascota con el nombre ingresado.", "Nombre de la mascota", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult boton = MessageBox.Show("Realmente desea salir?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (boton == DialogResult.OK)
            {
                user = "";
                InicioDeSesion inicio = new InicioDeSesion();
                this.Hide();
                inicio.Show();
                inicio.FormClosed += (s, args) => this.Close();
            }
            else if (boton == DialogResult.Cancel)
            {
                btnSalir.Focus();
            }
        }

        private void MiPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaginaUsuario formularioNuevo = new PaginaUsuario(user);
            this.Hide();
            formularioNuevo.Show();
            formularioNuevo.FormClosed += (s, args) => this.Close();
        }

        private void medicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServicioVeterinario formularioNuevo = new ServicioVeterinario(user);
            this.Hide();
            formularioNuevo.Show();
            formularioNuevo.FormClosed += (s, args) => this.Close();
        }

        private void esteticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServicioEstetico formularioNuevo = new ServicioEstetico(user);
            this.Hide();
            formularioNuevo.Show();
            formularioNuevo.FormClosed += (s, args) => this.Close();
        }

        private void perfilDeMiMascotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaginaMascota formularioNuevo = new PaginaMascota(user);
            this.Hide();
            formularioNuevo.Show();
            formularioNuevo.FormClosed += (s, args) => this.Close();
        }

        private void foroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ForoVIP formularioNuevo = new ForoVIP(user);
            this.Hide();
            formularioNuevo.Show();
            formularioNuevo.FormClosed += (s, args) => this.Close();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaginaVentas formularioNuevo = new PaginaVentas(user);
            this.Hide();
            formularioNuevo.Show();
            formularioNuevo.FormClosed += (s, args) => this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForoVIP formularioNuevo = new ForoVIP(user);
            this.Hide();
            formularioNuevo.Show();
            formularioNuevo.FormClosed += (s, args) => this.Close();
        }

        private void Ventastxt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PaginaVentas formularioNuevo = new PaginaVentas(user);
            this.Hide();
            formularioNuevo.Show();
            formularioNuevo.FormClosed += (s, args) => this.Close();
        }
    }
}
