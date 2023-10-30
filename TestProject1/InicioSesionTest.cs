using Negocio;

namespace TestProject1
{
    public class EliminarTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void InicioSesionExitoso()
        {
            //arrange o planteamiento
            string usuario = "Randy";
            string contrasena = "1234";
            int esperado = 1; //valor que nos dice si existe el usuario; 1 es que s� existe

            //act o prueba
            ConexionSQLN con = new ConexionSQLN();
            var actual = con.conSQL(usuario, contrasena); //si el usuario existe, regresa 1 como valor

            //assert o afirmaci�n
            Assert.AreEqual(esperado, actual);
        }
    }
}