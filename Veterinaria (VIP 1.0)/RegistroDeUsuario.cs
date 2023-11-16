using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
			comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
		}

		string patronCorreo = @"[^\w]";
		string patronNoNumeros = @"[^\d]";

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
                    if (txtNUsuario.Text == "" || txtNCompleto.Text == "" || txtCContraseña.Text == "" || txtContraseña.Text == ""
                        || txtCElectronico.Text == "" || txtNTelefonico.Text == "" || txtNUsuario.Text == null || comboBox1.Text=="")
                    {
						MessageBox.Show("Uno o más campos están vacíos. Por favor intente de nuevo");
					}
					else
                    {
                        if (Regex.IsMatch(txtCElectronico.Text,patronCorreo))
                        {
							MessageBox.Show("El correo no puede tener espacios ni caracteres especiales");
						}
                        else
                        {
                            if (txtNTelefonico.Text.Length !=10 || Regex.IsMatch(txtNTelefonico.Text, patronNoNumeros))
                            {
								MessageBox.Show("El número télefónico está mal escrito");
							}
                            else
                            {
								string correo = txtCElectronico.Text + comboBox1.Text;
								cn.regUser(txtNUsuario.Text, txtNCompleto.Text, correo, txtNTelefonico.Text, txtContraseña.Text);
								string user = txtNUsuario.Text;
								MessageBox.Show("Registro exitoso.");
								ResgistroDeMascota formularioNuevo = new ResgistroDeMascota(user);
								this.Hide();
								formularioNuevo.Show();
								formularioNuevo.FormClosed += (s, args) => this.Close();
							}
						}
					}                    
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
