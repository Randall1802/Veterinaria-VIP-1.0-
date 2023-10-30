using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class ConexionSQL
    {
        static string conexionString = "server= localhost; database=VeteVIP; " +
            "integrated security=true";

        SqlConnection con = new SqlConnection(conexionString);

        public int consultaLogin(string usuario)
        {
            int count;
            if (con.State==ConnectionState.Closed)
            {
                con.Open();
            }
            string query = "select count(*) from Cliente where usuario='" + usuario + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return count;
        }

        public int consultaLogin(string usuario,string contrasena)
        {
            int count;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string query = "select count(*) from Cliente where usuario='" + usuario + "' and contrasena='"+contrasena+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return count;
        }

        public void registrarUsuario(string usuario, string nombre, string correo, string telefono, string contrasena)
        {
            con.Open();
            string query = "insert into Cliente (usuario,nombre,email,telefono,contrasena) values ('" + usuario + "',"
                   + "'" + nombre + "','" + correo + "','" + telefono + "','" + contrasena + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public int registrarMascota(string user, string nombre, string raza, string sexo, string especie, DateTime fechaNac, string edad)
        {
            int count;
            if (con.State==ConnectionState.Closed)
            {
                con.Open();
            }
            string que = "select idCliente from Cliente where usuario='" + user + "'";
            SqlCommand cmd0 = new SqlCommand(que, con);
            int id = Convert.ToInt32(cmd0.ExecuteScalar());

            string que1 = "select idMascota from Mascota where nombre='"+nombre+"'";
            SqlCommand cmd1= new SqlCommand(que1, con);
            int idM= Convert.ToInt32(cmd1.ExecuteScalar());
            if (idM==0)
            {
                string query = "insert into Mascota (idCliente, nombre,raza,sexo,especie,fechaNacimiento,edad) " +
                "values ('" + id + "','" + nombre + "','" + raza + "','" + sexo + "','" + especie + "','" + fechaNac + "','" + edad + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                count = 1;
            }
            else {
                count = 0;
                con.Close();
            }
            return count;            
        }

        public string[] cargarDatosUsuario(string user, string nombre, string correo, string telefono)
        {
            con.Open();
            string query = "SELECT usuario, nombre, email, telefono FROM Cliente WHERE usuario = '" + user + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                user = reader.GetString(0);       // Columna "usuario"
                nombre = reader.GetString(1);      // Columna "nombre"
                correo = reader.GetString(2);       // Columna "email"
                telefono = reader.GetString(3);       // Columna "telefono"
            }
            string[] array = new string[4];
            array[0] = user;
            array[1] = nombre;
            array[2] = correo;
            array[3] = telefono;
            con.Close();
            return array;
        }

        public void editarDatosUsuario(string userOld, string user, string nombre, string correo, string telefono)
        {
            con.Open();
            string query = "update Cliente set nombre='" + nombre + "', email='" + correo + "', " +
                " telefono='" + telefono + "' where usuario='" + userOld + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        
        public void editarUsuario(string userOld, string user)
        {
            con.Open();
            string query = "update Cliente set usuario='" + user + "' where usuario='" + userOld + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable consultaMascotas(string user)
        {
            con.Open();
            string query1 = "select idCliente from Cliente where usuario='"+user+"'";
            SqlCommand cmd0 = new SqlCommand(query1, con);
            cmd0.ExecuteNonQuery();
            int id = Convert.ToInt32(cmd0.ExecuteScalar());
            string query2 = "select Mascota.nombre, raza,sexo,especie,fechaNacimiento,edad" +
                " from Mascota inner join Cliente on Mascota.idCliente=Cliente.idCliente" +
                " and Cliente.idCliente='"+id+"'";
            SqlCommand cmd1 = new SqlCommand(query2, con);
            SqlDataAdapter data = new SqlDataAdapter(cmd1);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            con.Close();
            return tabla;
        }
        
        public DataTable consultaMedica(string user)
        {
            con.Open();
            string query1 = "select idCliente from Cliente where usuario='" + user + "'";
            SqlCommand cmd0 = new SqlCommand(query1, con);
            cmd0.ExecuteNonQuery();
            int id = Convert.ToInt32(cmd0.ExecuteScalar());
            string query2 = "select nombreMascota,tipoAtencion,fecha,hora,tipoPago" +
                " from Cliente inner join Mascota on Cliente.idCliente=Mascota.idCliente" +
                " and Cliente.idCliente='" + id + "' inner join ServicioMedico on Mascota.idMascota=" +
                "ServicioMedico.idMascota";
            SqlCommand cmd1 = new SqlCommand(query2, con);
            SqlDataAdapter data = new SqlDataAdapter(cmd1);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            con.Close();
            return tabla;
        }

        public DataTable consultaEstetica(string user)
        {
            con.Open();
            string query1 = "select idCliente from Cliente where usuario='" + user + "'";
            SqlCommand cmd0 = new SqlCommand(query1, con);
            cmd0.ExecuteNonQuery();
            int id = Convert.ToInt32(cmd0.ExecuteScalar());
            string query2 = "select nombreMascota,servicio,fecha,hora,tipoPago" +
                " from Cliente inner join Mascota on Cliente.idCliente=Mascota.idCliente" +
                " and Cliente.idCliente='" + id + "' inner join ServicioEstetico on Mascota.idMascota=" +
                "ServicioEstetico.idMascota";
            SqlCommand cmd1 = new SqlCommand(query2, con);
            SqlDataAdapter data = new SqlDataAdapter(cmd1);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            con.Close();
            return tabla;
        }

        public void editarDatosMascota(string user,string nombreA,string nombreN,string raza,string sexo, string especie,string fechaNac,string edad)
        {
            con.Open();
            string query1 = "select idCliente from Cliente where usuario='" + user + "'";
            SqlCommand cmd0 = new SqlCommand(query1, con);
            cmd0.ExecuteNonQuery();
            int id = Convert.ToInt32(cmd0.ExecuteScalar());

            string query2 = "select idMascota from Mascota where nombre='" + nombreA + "'";
            SqlCommand cmd1 = new SqlCommand(query2, con);
            cmd1.ExecuteNonQuery();
            int idM = Convert.ToInt32(cmd1.ExecuteScalar());

            string query = "update Mascota set nombre='"+nombreN+"', raza='"+raza+"', sexo='"+sexo+"', " +
                "especie='"+especie+"', fechaNacimiento='"+DateTime.Parse(fechaNac)+"', edad='"+edad+"' " +
                "where idCliente='"+id+"' and idMascota='"+idM+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public int deleteMascota(string user, string nombreMascota)
        {
            int count;
            con.Open();
            string query1 = "select idCliente from Cliente where usuario='" + user + "'";
            SqlCommand cmd0 = new SqlCommand(query1, con);
            cmd0.ExecuteNonQuery();
            int id = Convert.ToInt32(cmd0.ExecuteScalar());
            string query2 = "select idMascota from Mascota where nombre='" + nombreMascota + "'";
            SqlCommand cmd1 = new SqlCommand(query2, con);
            cmd1.ExecuteNonQuery();
            int idM = Convert.ToInt32(cmd1.ExecuteScalar());
            string query3 = "select count(*) " +
                " from Mascota inner join Cliente on Mascota.idCliente=Cliente.idCliente" +
                " and Cliente.idCliente='" + id + "' and Mascota.nombre='" + nombreMascota + "'";
            SqlCommand cmd2 = new SqlCommand(query3, con);
            count = Convert.ToInt32(cmd2.ExecuteScalar());

            if (count == 0)
            {
                count = 0;
            }
            else
            {
                string query4 = "delete from Mascota where nombre='" + nombreMascota + "' and idCliente='" + id + "' " +
                    "and idMascota='" + idM + "'";
                SqlCommand cmd3 = new SqlCommand(query4, con);
                count = Convert.ToInt32(cmd3.ExecuteScalar());
            }
            con.Close();
            return count;
        }

        public int confirmaCitaEstetica(string user,string nombreMascota, string servSol, string fecha,string hora,string tiPa)
        {
            int count;
            con.Open();
            string query1 = "select idCliente from Cliente where usuario='" + user + "'";
            SqlCommand cmd0 = new SqlCommand(query1, con);
            cmd0.ExecuteNonQuery();
            int id = Convert.ToInt32(cmd0.ExecuteScalar());
            string query2 = "select idMascota from Mascota where nombre='" + nombreMascota + "'";
            SqlCommand cmd1 = new SqlCommand(query2, con);
            cmd1.ExecuteNonQuery();
            int idM = Convert.ToInt32(cmd1.ExecuteScalar());
            string query3 = "select count(*) " +
                " from Mascota inner join Cliente on Mascota.idCliente=Cliente.idCliente" +
                " and Cliente.idCliente='" + id + "' and Mascota.nombre='"+nombreMascota+"' and " +
                "Mascota.idMascota='"+idM+"'";
            SqlCommand cmd2 = new SqlCommand(query3, con);
            count = Convert.ToInt32(cmd2.ExecuteScalar());

            if (count == 0)
            {
                con.Close();
            }
            else
            {
                string query4 = "insert into ServicioEstetico values ('"+idM+"', '"+nombreMascota+"','"+servSol+"'," +
                    "'"+DateTime.Parse(fecha)+"', '"+hora+"', '"+tiPa+"')";
                SqlCommand cmd3 = new SqlCommand(query4, con);
                cmd3.ExecuteNonQuery();
                count = 1;
                con.Close();
            }            
            return count;
        }

        public int confirmaCitaMedica(string user, string nombreMascota, string tipoAtencion, string fecha, string hora, string tiPa)
        {
            int count;
            con.Open();
            string query1 = "select idCliente from Cliente where usuario='" + user + "'";
            SqlCommand cmd0 = new SqlCommand(query1, con);
            cmd0.ExecuteNonQuery();
            int id = Convert.ToInt32(cmd0.ExecuteScalar());
            string query2 = "select idMascota from Mascota where nombre='" + nombreMascota + "'";
            SqlCommand cmd1 = new SqlCommand(query2, con);
            cmd1.ExecuteNonQuery();
            int idM = Convert.ToInt32(cmd1.ExecuteScalar());
            string query3 = "select count(*) " +
                " from Mascota inner join Cliente on Mascota.idCliente=Cliente.idCliente" +
                " and Cliente.idCliente='" + id + "' and Mascota.nombre='" + nombreMascota + "' and " +
                "Mascota.idMascota='" + idM + "'";
            SqlCommand cmd2 = new SqlCommand(query3, con);
            count = Convert.ToInt32(cmd2.ExecuteScalar());

            if (count == 0)
            {
                con.Close();
            }
            else
            {
                string query4 = "insert into ServicioMedico values ('" + idM + "', '" + nombreMascota + "','" + tipoAtencion + "'," +
                    "'" + DateTime.Parse(fecha) + "', '" + hora + "', '" + tiPa + "')";
                SqlCommand cmd3 = new SqlCommand(query4, con);
                cmd3.ExecuteNonQuery();
                count = 1;
                con.Close();
            }
            return count;
        }

        public int citaEmergencia(string user, string nombreMascota)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            int count;
            string query1 = "select idCliente from Cliente where usuario='" + user + "'";
            SqlCommand cmd0 = new SqlCommand(query1, con);
            cmd0.ExecuteNonQuery();
            int id = Convert.ToInt32(cmd0.ExecuteScalar());
            string query2 = "select idMascota from Mascota where nombre='" + nombreMascota + "'";
            SqlCommand cmd1 = new SqlCommand(query2, con);
            cmd1.ExecuteNonQuery();
            int idM = Convert.ToInt32(cmd1.ExecuteScalar());
            string query3 = "select count(*) " +
                " from Mascota inner join Cliente on Mascota.idCliente=Cliente.idCliente" +
                " and Cliente.idCliente='" + id + "' and Mascota.nombre='" + nombreMascota + "' and " +
                "Mascota.idMascota='" + idM + "'";
            SqlCommand cmd2 = new SqlCommand(query3, con);
            count = Convert.ToInt32(cmd2.ExecuteScalar());

            if (count==0)
            {
                con.Close();
            }
            else
            {
                DateTime fechaActual = DateTime.Now.Date;
                TimeSpan horaActual = DateTime.Now.TimeOfDay;

                DateTime fechaDisponible;
                string query = "SELECT MIN(Fecha) FROM ServicioMedico WHERE Fecha > @FechaActual";
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@FechaActual", fechaActual);
                    object result = command.ExecuteScalar();
                    fechaDisponible = result != DBNull.Value ? (DateTime)result : fechaActual;
                }

                string idMascota;
                string selectQuery = "SELECT idMascota FROM Mascota WHERE nombre = @NombreMascota";
                using (SqlCommand selectCommand = new SqlCommand(selectQuery, con))
                {
                    selectCommand.Parameters.AddWithValue("@NombreMascota", nombreMascota);
                    object result = selectCommand.ExecuteScalar();
                    idMascota = result != null ? result.ToString() : string.Empty;
                }

                string insertQuery = "INSERT INTO ServicioMedico (idMascota, nombreMascota, tipoAtencion, fecha, hora, tipoPago) VALUES (@IdMascota, @NombreMascota, @TipoAtencion, @Fecha, @Hora, @TipoPago)";
                using (SqlCommand insertCommand = new SqlCommand(insertQuery, con))
                {
                    insertCommand.Parameters.AddWithValue("@IdMascota", idMascota);
                    insertCommand.Parameters.AddWithValue("@NombreMascota", nombreMascota);
                    insertCommand.Parameters.AddWithValue("@TipoAtencion", "Cita de Emergencia");
                    insertCommand.Parameters.AddWithValue("@Fecha", fechaDisponible);
                    insertCommand.Parameters.AddWithValue("@Hora", horaActual);
                    insertCommand.Parameters.AddWithValue("@TipoPago", "Pendiente");
                    insertCommand.ExecuteNonQuery();
                }
                count = 1;
                con.Close();
            }
            return count;
        }

        public int deleteUsuario(string usuario, string contrasena)
        {
            int count;
            con.Open();
            string query = "select count(*) from Cliente where usuario='" + usuario + "'" +
                " and contrasena= '" + contrasena + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count == 1)
            {
                string query2 = "delete from Cliente where usuario='" + usuario + "'";
                SqlCommand cmd2 = new SqlCommand(query2, con);
                cmd2.ExecuteNonQuery();
            }
            else
            {
                count = 0;
            }
            con.Close();
            return count;
        }
    }
}
