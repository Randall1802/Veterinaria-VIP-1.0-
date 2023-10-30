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
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;

namespace Veterinaria__VIP_1._0_
{
    public partial class ForoVIP : Form
    {
        private string user;

        public ForoVIP()
        {
            InitializeComponent();
        }

        public ForoVIP(string user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            PaginaPrincipal formularioNuevo = new PaginaPrincipal(user);
            this.Hide();
            formularioNuevo.Show();
            formularioNuevo.FormClosed += (s, args) => this.Close();
        }

        private void btnMascota_Click(object sender, EventArgs e)
        {
            PaginaMascota formularioNuevo = new PaginaMascota(user);
            this.Hide();
            formularioNuevo.Show();
            formularioNuevo.FormClosed += (s, args) => this.Close();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            PaginaUsuario formularioNuevo = new PaginaUsuario(user);
            this.Hide();
            formularioNuevo.Show();
            formularioNuevo.FormClosed += (s, args) => this.Close();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            PaginaVentas formularioNuevo = new PaginaVentas(user);
            this.Hide();
            formularioNuevo.Show();
            formularioNuevo.FormClosed += (s, args) => this.Close();
        }

        private void btnRC_Click(object sender, EventArgs e)
        {
            string consulta = txtConsulta.Text;

            rtInfo.Clear(); // Limpiar el contenido anterior en rtInfo <--------------------------------------

            // Realizar la consulta en la base de datos
            string connectionString = "server= localhost; database=VeteVIP; " + "integrated security=true";
            if (!(txtConsulta.Text == ""))
            {
                // Realizar la consulta en la base de datos
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Consultar si alguna palabra de la consulta coincide con alguna pregunta en la base de datos
                    string[] palabrasConsulta = consulta.Split(' '); // Dividir la consulta en palabras

                    string query = "SELECT Pregunta, Respuesta FROM Consultas WHERE ";
                    List<string> condiciones = new List<string>();

                    // Construir las condiciones de búsqueda para cada palabra
                    foreach (string palabra in palabrasConsulta)
                    {
                        condiciones.Add("Pregunta LIKE '%' + @consulta + '%'");
                    }

                    query += string.Join(" OR ", condiciones);

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@consulta", consulta);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            bool algunaCoincidencia = false;

                            while (reader.Read())
                            {
                                string pregunta = reader.GetString(0);
                                string respuesta = reader.GetString(1);

                                rtInfo.AppendText($"Pregunta: {pregunta}\n");
                                rtInfo.AppendText($"Respuesta: {respuesta}\n\n");

                                algunaCoincidencia = true;
                            }

                            if (!algunaCoincidencia)
                            {
                                MessageBox.Show("Lo sentimos, ninguna respuesta coincide con la consulta. Te invitamos a subir la consulta.");
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("El Campo se encuentra Vacio, por favor ingrese su consulta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEC_Click(object sender, EventArgs e)
        {
            string pregunta = txtConsulta.Text;

            // Realizar la inserción de la pregunta en la base de datos
            string connectionString = "server= localhost; database=VeteVIP; " + "integrated security=true";

            if (!(txtConsulta.Text == ""))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Solicitar la respuesta al usuario (por ejemplo, mediante un cuadro de diálogo)
                    string respuesta = Interaction.InputBox("Ingrese la respuesta:", "Respuesta");

                    string insertQuery = "INSERT INTO Consultas (Pregunta, Respuesta) VALUES (@pregunta, @respuesta)";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@pregunta", pregunta);
                        command.Parameters.AddWithValue("@respuesta", respuesta);
                        command.ExecuteNonQuery();
                    }

                    // Limpiar el contenido anterior en rtInfo
                    rtInfo.Clear();

                    // Mostrar la nueva pregunta y respuesta en rtInfo
                    rtInfo.AppendText($"Pregunta: {pregunta}\n");
                    rtInfo.AppendText($"Respuesta: {respuesta}\n\n");

                    // Limpiar el campo de texto txtConsulta
                    txtConsulta.Text = "";

                    MessageBox.Show("La pregunta y respuesta han sido anexadas correctamente.");
                }
            }
            else
            {
                MessageBox.Show("El Campo se encuentra Vacio, por favor ingrese su consulta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ForoVIP_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user = "";
            this.Close();
            InicioDeSesion inicioDeSesion = new InicioDeSesion();
            inicioDeSesion.Show();
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
