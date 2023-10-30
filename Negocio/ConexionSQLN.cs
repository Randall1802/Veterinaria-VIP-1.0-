using System;
using System.Data;
using Datos;

namespace Negocio
{
    public class ConexionSQLN
    {
        ConexionSQL cn = new ConexionSQL();

        public int conSQL(string user)
        {
            return cn.consultaLogin(user);
        }

        public int conSQL(string user, string contrasena)
        {
            return cn.consultaLogin(user,contrasena);
        }

        public void regUser(string usuario, string nombre, string correo, string telefono, string contrasena)
        {
            cn.registrarUsuario(usuario,nombre,correo,telefono,contrasena);
        }

        public int regMas(string user, string nombre, string raza, string sexo, string especie, DateTime fechaNac, string edad)
        {
            return cn.registrarMascota(user, nombre,raza,sexo,especie,fechaNac,edad);
        }

        public string[] carDaUs(string user, string nombre, string correo, string telefono)
        {
            return cn.cargarDatosUsuario(user,nombre,correo,telefono);
        }

        public void ediDaUs(string oldUser, string user, string nombre, string correo, string telefono)
        {
            cn.editarDatosUsuario(oldUser, user,nombre,correo,telefono);
        }

        public void ediUs(string userOld, string user)
        {
            cn.editarUsuario(userOld,user);
        }

        public DataTable conMas(string user)
        {
            return cn.consultaMascotas(user);
        }

        public DataTable conCitaMed(string user)
        {
            return cn.consultaMedica(user);
        }

        public DataTable conCitaEst(string user)
        {
            return cn.consultaEstetica(user);
        }

        public void ediDatMasc(string user, string nombreA, string nombreN, string raza, string sexo, string especie, string fechaNac, string edad)
        {
            cn.editarDatosMascota(user,nombreA,nombreN,raza,sexo,especie,fechaNac,edad);
        }

        public int delMasc(string user, string nombreMascota)
        {
            return cn.deleteMascota(user, nombreMascota);
        }

        public int confCitaEs(string user, string nombreMascota, string servSol, string fecha, string hora, string tiPa)
        {
            return cn.confirmaCitaEstetica(user,nombreMascota,servSol,fecha,hora,tiPa);
        }

        public int confCitaVet(string user, string nombreMascota, string servSol, string fecha, string hora, string tiPa)
        {
            return cn.confirmaCitaMedica(user, nombreMascota, servSol, fecha, hora, tiPa);
        }

        public int citaEmerg(string user, string nombreMascota)
        {
            return cn.citaEmergencia(user, nombreMascota);
        }

        public int delSQL(string user, string pass)
        {
            return cn.deleteUsuario(user, pass);
        }
    }
}
