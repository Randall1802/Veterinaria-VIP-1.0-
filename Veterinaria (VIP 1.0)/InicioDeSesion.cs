using Negocio;

namespace Veterinaria__VIP_1._0_
{
    public partial class InicioDeSesion : Form
    {
        ConexionSQLN cn = new ConexionSQLN();
        public InicioDeSesion()
        {
            InitializeComponent();
        }

        private void lLRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistroDeUsuario formularioNuevo = new RegistroDeUsuario();
            this.Hide();
            formularioNuevo.Show();
            formularioNuevo.FormClosed += (s, args) => this.Close();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" | txtPassword.Text == "")
            {
                MessageBox.Show("Uno o más campos están vacíos. Intente de nuevo.");
            }
            else
            {
                if (txtPassword.Text.Contains(" ") | txtUsuario.Text.Contains(" "))
                {
                    MessageBox.Show("No se permiten espacios en ningún campo");
                }
                else if (cn.conSQL(txtUsuario.Text, txtPassword.Text) == 1)
                {
                    MessageBox.Show("Bienvenido " + txtUsuario.Text + "!");
                    string user = txtUsuario.Text;
                    PaginaPrincipal formularioNuevo = new PaginaPrincipal(user);
                    this.Hide();
                    formularioNuevo.Show();
                    formularioNuevo.FormClosed += (s, args) => this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                }
            }

            /*
             * PaginaPrincipal formularioNuevo = new PaginaPrincipal();
            this.Hide();
            formularioNuevo.Show();
            formularioNuevo.FormClosed += (s, args) => this.Close();
            */
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InicioDeSesion_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lnlInicioDeS_Click(object sender, EventArgs e)
        {

        }

        private void labInf_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}