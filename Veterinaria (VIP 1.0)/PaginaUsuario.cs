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

namespace Veterinaria__VIP_1._0_
{
    public partial class PaginaUsuario : Form
    {
        ConexionSQLN cn = new ConexionSQLN();
        private string user;
        private string usuario, nombre, correo, telefono;

        public PaginaUsuario()
        {
            InitializeComponent();
        }

        public PaginaUsuario(string user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void btnInicio_Click_1(object sender, EventArgs e)
        {
            PaginaPrincipal formularioNuevo = new PaginaPrincipal(user);
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

        private void btnForo_Click(object sender, EventArgs e)
        {
            ForoVIP formularioNuevo = new ForoVIP(user);
            this.Hide();
            formularioNuevo.Show();
            formularioNuevo.FormClosed += (s, args) => this.Close();
        }

        private void btnAIU_Click_1(object sender, EventArgs e)
        {
            if (txtNU.Text == "" | txtNCU.Text == "" | txtCE.Text == "" | txtNT.Text == "")
            {
                MessageBox.Show("Uno o más campos están vacíos. Intente de nuevo");
            }
            else if (txtNU.Text != usuario | txtNCU.Text != nombre | txtCE.Text != correo | txtNT.Text != telefono)
            {
                if (txtNU.Text != usuario | txtNU.Text == usuario)
                {
                    if (txtNU.Text.Contains(" "))
                    {
                        MessageBox.Show("No se permiten espacios en el nombre de usuario");
                        txtNU.Text = user;
                        txtNCU.Text = usuario;
                        txtCE.Text = correo;
                        txtNT.Text = telefono;
                    }
                    else if (cn.conSQL(txtNU.Text) == 1 && (txtNCU.Text != nombre | txtCE.Text != correo | txtNT.Text != telefono))
                    {
                        cn.ediDaUs(usuario, txtNU.Text, txtNCU.Text, txtCE.Text, txtNT.Text);
                        user = txtNU.Text;
                        MessageBox.Show("Datos modificados");
                    }
                    else if (cn.conSQL(txtNU.Text) == 1)
                    {
                        MessageBox.Show("Nombre de usuario ya existe.");
                        txtNU.Text = user;
                        txtNCU.Text = usuario;
                        txtCE.Text = correo;
                        txtNT.Text = telefono;
                    }
                    else
                    {
                        cn.ediDaUs(usuario, txtNU.Text, txtNCU.Text, txtCE.Text, txtNT.Text);
                        cn.ediUs(usuario, txtNU.Text);
                        user = txtNU.Text;
                        MessageBox.Show("Datos modificados");
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay nada que modificar");
            }
        }

        private void btnMIU_Click_1(object sender, EventArgs e)
        {
            txtNU.Text = cn.carDaUs(user, txtNCU.Text, txtCE.Text, txtNT.Text)[0];
            txtNCU.Text = cn.carDaUs(user, txtNCU.Text, txtCE.Text, txtNT.Text)[1];
            txtCE.Text = cn.carDaUs(user, txtNCU.Text, txtCE.Text, txtNT.Text)[2];
            txtNT.Text = cn.carDaUs(user, txtNCU.Text, txtCE.Text, txtNT.Text)[3];
            usuario = txtNU.Text;
            nombre = txtNCU.Text;
            correo = txtCE.Text;
            telefono = txtNT.Text;
            user = usuario;
        }

        private void btnVentas_Click_1(object sender, EventArgs e)
        {
            PaginaVentas formularioNuevo = new PaginaVentas(user);
            this.Hide();
            formularioNuevo.Show();
            formularioNuevo.FormClosed += (s, args) => this.Close();
        }

        private void PaginaUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void foroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ForoVIP formularioNuevo = new ForoVIP(user);
            this.Hide();
            formularioNuevo.Show();
            formularioNuevo.FormClosed += (s, args) => this.Close();
        }

        private void tiendaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            PaginaVentas formularioNuevo = new PaginaVentas(user);
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
                //btnSalir.Focus();
            }
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaginaPrincipal paginaPrincipal = new PaginaPrincipal(user);
            this.Hide();
            paginaPrincipal.Show();
            paginaPrincipal.FormClosed += (s, args) => this.Close();
        }
    }
}

