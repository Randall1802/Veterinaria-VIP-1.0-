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
    public partial class PaginaMascota : Form
    {
        ConexionSQLN cn = new ConexionSQLN();
        private string user;
        private string nombreM, raza, sexo, especie, fechaNac, edad;

        public PaginaMascota()
        {
            InitializeComponent();
        }

        public PaginaMascota(string user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void btnUsuario_Click_1(object sender, EventArgs e)
        {
            PaginaUsuario formularioNuevo = new PaginaUsuario(user);
            this.Hide();
            formularioNuevo.Show();
            formularioNuevo.FormClosed += (s, args) => this.Close();
        }

        private void btnInicio_Click_1(object sender, EventArgs e)
        {
            PaginaPrincipal formularioNuevo = new PaginaPrincipal(user);
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

        private void btnForo_Click(object sender, EventArgs e)
        {
            ForoVIP formularioNuevo = new ForoVIP(user);
            this.Hide();
            formularioNuevo.Show();
            formularioNuevo.FormClosed += (s, args) => this.Close();
        }

        private void btnDAM_Click_1(object sender, EventArgs e)
        {
            if (txtNM.Text == "" | txtRM.Text == "" | txtSM.Text == "" | txtEM.Text == "" | txtFNM.Text == "" | txtEDM.Text == "")
            {
                MessageBox.Show("Uno o más campos están vacíos. Intente de nuevo.");
            }
            else
            {
                int resultado = cn.regMas(user, txtNM.Text, txtRM.Text, txtSM.Text, txtEM.Text, DateTime.Parse(txtFNM.Text), txtEDM.Text);
                if (resultado == 1)
                {
                    MessageBox.Show("Registro exitoso.");
                    dataGridView1.DataSource = cn.conMas(user);
                    dataGridView1.Update();
                }
                else
                {
                    MessageBox.Show("La mascota ya existe");
                }
            }
        }

        private void btnDBM_Click_1(object sender, EventArgs e)
        {
            if (txtNM.Text == "")
            {
                MessageBox.Show("No ha seleccionado ninguna mascota.");
            }
            else
            {
                int resultado = cn.delMasc(user, nombreM);
                if (resultado == 0)
                {
                    MessageBox.Show("Mascota eliminada.");
                    dataGridView1.DataSource = cn.conMas(user);
                    dataGridView1.Update();
                }
                else
                {
                    MessageBox.Show("Mascota no existe.");
                }

            }
        }

        private void btnMIU_Click_1(object sender, EventArgs e)
        {
            if (txtNM.Text == "" | txtRM.Text == "" | txtSM.Text == "" | txtEM.Text == "" | txtFNM.Text == "" | txtEDM.Text == "")
            {
                MessageBox.Show("Uno o más campos están vacíos. Intente de nuevo.");
            }
            else if (txtNM.Text != nombreM | txtRM.Text != raza | txtSM.Text != sexo | txtEM.Text != especie | txtFNM.Text != fechaNac | txtEDM.Text != edad)
            {
                cn.ediDatMasc(user, nombreM, txtNM.Text, txtRM.Text, txtSM.Text, txtEM.Text, txtFNM.Text, txtEDM.Text);
                dataGridView1.DataSource = cn.conMas(user);
                dataGridView1.Update();
                MessageBox.Show("Datos modificados con éxito.");
            }
            else
            {
                MessageBox.Show("No hay nada que modificar");
            }
        }

        private void btnVerMas_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cn.conMas(user);
        }

        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            var row = dataGridView1.CurrentRow;
            txtNM.Text = row.Cells[0].Value.ToString();
            txtRM.Text = row.Cells[1].Value.ToString();
            txtSM.Text = row.Cells[2].Value.ToString();
            txtEM.Text = row.Cells[3].Value.ToString();
            txtFNM.Text = row.Cells[4].Value.ToString();
            txtEDM.Text = row.Cells[5].Value.ToString();
            nombreM = txtNM.Text;
            raza = txtRM.Text;
            sexo = txtSM.Text;
            especie = txtEM.Text;
            fechaNac = txtFNM.Text;
            edad = txtEDM.Text;
        }

        private void btnLimCam_Click(object sender, EventArgs e)
        {
            txtNM.Text = "";
            txtRM.Text = "";
            txtSM.Text = "";
            txtEM.Text = "";
            txtFNM.Text = "";
            txtEDM.Text = "";
        }

        private void PaginaMascota_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lblMR_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void MiPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaginaUsuario formularioNuevo = new PaginaUsuario(user);
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

            }
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

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaginaPrincipal paginaPrincipal = new PaginaPrincipal(user);
            this.Hide();
            paginaPrincipal.Show();
            paginaPrincipal.FormClosed += (s, args) => this.Close();
        }
    }
}
