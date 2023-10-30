using System.Reflection;
using System.Windows.Forms;
using NUnit.Framework;
using Veterinaria__VIP_1._0_;


namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BtnUsuarioClickTest()
        {
            // Arrange
            PaginaPrincipal form = new PaginaPrincipal();
            EventArgs eventArgs = new EventArgs();
            object sender = new object();

            // Act  (hacer público el botón)
            //form.btnUsuario_Click_1(sender, eventArgs);

            // Assert
            PaginaUsuario interfazUsuarioForm = (PaginaUsuario)Application.OpenForms["PaginaUsuario"];
            Assert.IsNotNull(interfazUsuarioForm);
            Assert.IsTrue(!interfazUsuarioForm.Visible);

        }

        /*[Test]
        public void BtnMascotaClickTest()
        {
            // Arrange
            PaginaMascota form = new PaginaMascota();
            EventArgs eventArgs = new EventArgs();

            // Act
            form.btnMascota_Click(null, eventArgs);

            // Assert
            PaginaMascota interfazMascotaForm = new PaginaMascota();
            Assert.IsTrue(interfazMascotaForm.Visible);
        }*/

        /*[Test]
        public void BtnVentasClickTest()
        {
            // Arrange
            PaginaVentas form = new PaginaVentas();
            EventArgs eventArgs = new EventArgs();

            // Act
            form.btnVentas_Click(null, eventArgs);

            // Assert
            PaginaVentas interfazVentasForm = new PaginaVentas();
            Assert.IsTrue(interfazVentasForm.Visible);
        }*/
    }
}