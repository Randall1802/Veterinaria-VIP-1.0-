using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Negocio;

namespace Veterinaria__VIP_1._0_
{
    public partial class RegistroDeUsuario : Form
    {
        ConexionSQLN cn = new ConexionSQLN();

        public RegistroDeUsuario()
        {
            InitializeComponent();
        }

        public void btnRegistrarse_Click(object sender, EventArgs e)
        {
            if (cn.conSQL(txtNUsuario.Text) == 1)
            {
                MessageBox.Show("El usuario ya existe");
            }
            else
            {
                if (txtContraseña.Text != txtCContraseña.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }
                else
                {
                    cn.regUser(txtNUsuario.Text, txtNCompleto.Text, txtCElectronico.Text, txtNTelefonico.Text, txtContraseña.Text);
                    string user = txtNUsuario.Text;
                    MessageBox.Show("Registro exitoso.");
                    ResgistroDeMascota formularioNuevo = new ResgistroDeMascota(user);
                    this.Hide();
                    formularioNuevo.Show();
                    formularioNuevo.FormClosed += (s, args) => this.Close();
                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            InicioDeSesion ids = new InicioDeSesion();
            this.Hide();
            ids.Show();
            ids.FormClosed += (s, args) => this.Close();
        }

        private void RegistroDeUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
