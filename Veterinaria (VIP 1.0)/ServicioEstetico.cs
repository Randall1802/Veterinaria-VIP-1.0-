using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria__VIP_1._0_
{
    public partial class ServicioEstetico : Form
    {
        ConexionSQLN cn = new ConexionSQLN();
        private string user;

        public ServicioEstetico()
        {
            InitializeComponent();
        }

        public ServicioEstetico(string user)
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

        private void btnUsuario_Click_1(object sender, EventArgs e)
        {
            PaginaUsuario formularioNuevo = new PaginaUsuario(user);
            this.Hide();
            formularioNuevo.Show();
            formularioNuevo.FormClosed += (s, args) => this.Close();
        }

        private void btnCS_Click_1(object sender, EventArgs e)
        {
            if (txtNM.Text == "" | txtSS.Text == "" | txtFC.Text == "" | txtHC.Text == "" | txtTP.Text == "")
            {
                MessageBox.Show("Uno o más campos están incompletos.");
            }
            else
            {
                if (cn.confCitaEs(user, txtNM.Text, txtSS.Text, txtFC.Text, txtHC.Text, txtTP.Text) == 1)
                {
                    MessageBox.Show("Registro de cita exitoso");
                    dataGridView1.DataSource = cn.conCitaEst(user);
                    dataGridView1.Update();
                }
                else
                {
                    MessageBox.Show("Registro incorrecto, no tienes esa mascota");
                }
            }
        }

        private void btnED_Click_1(object sender, EventArgs e)
        {
            txtNM.Text = "";
            txtSS.Text = "";
            txtFC.Text = "";
            txtHC.Text = "";
            txtTP.Text = "";
        }

        private void btnVentas_Click_1(object sender, EventArgs e)
        {
            PaginaVentas formularioNuevo = new PaginaVentas(user);
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

        private void btnVerCi_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cn.conCitaEst(user);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            var row = dataGridView1.CurrentRow;
            txtNM.Text = row.Cells[0].Value.ToString();
            txtSS.Text = row.Cells[1].Value.ToString();
            txtFC.Text = row.Cells[2].Value.ToString();
            txtHC.Text = row.Cells[3].Value.ToString();
            txtTP.Text = row.Cells[4].Value.ToString();
        }

        private void ServicioEstetico_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaginaPrincipal paginaPrincipal = new PaginaPrincipal(user);
            this.Hide();
            paginaPrincipal.Show();
            paginaPrincipal.FormClosed += (s, args) => this.Close();
        }

        private void medicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServicioVeterinario formularioNuevo = new ServicioVeterinario(user);
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
    }
}
