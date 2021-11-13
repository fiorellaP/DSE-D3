using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DSE_D3.Controllers;
using DSE_D3.Models;

namespace DSE_D3.Tests.Controllers
{
    [TestClass]
    public class ClienteControllerTest
    {
        //Escenario 1
        [TestMethod]
        public void AgregarClienteNoRepetido()
        {
            // Arrange
            clientesController controller = new clientesController();
            var clientea = new cliente()
            {
                nombres = "juanita",
                apellidos = "perez",
                telefono = "21548745",
                correo = "juanita@gmail.com"
            };
            // Act
            var result = controller.Agregar(clientea);
            // Assert
            Assert.AreEqual(0, result);
        }

        //Escenario 2
        [TestMethod]
        public void NoAgregarClienteRepetido()
        {
            // Arrange
            clientesController controller = new clientesController();
            var clientea = new cliente()
            {
                nombres = "Enrique",
                apellidos = "Maldivar",
                telefono = "21548745",
                correo = "juanito@gmail.com"
            };
            // Act
            var result = controller.Agregar(clientea);
            // Assert
            Assert.AreEqual(1, result);
        }

        //Escenario 3
        [TestMethod]
        public void NoAgregarClienteConNombreVacio()
        {
            // Arrange
            clientesController controller = new clientesController();
            var clientea = new cliente()
            {
                nombres = "",
                apellidos= "Gonzalez",
                telefono = "21548745",
                correo = "juanito@gmail.com"
            };
            // Act
            var result = controller.Agregar(clientea);
            // Assert
            Assert.AreEqual(2, result);
        }


        //Escenario 4
        [TestMethod]
        public void NoAgregarClienteConTelefonoVacio()
        {
            // Arrange
            clientesController controller = new clientesController();
            var clientea = new cliente()
            {
                nombres = "Flor",
                apellidos = "Gonzalez",
                telefono = "",
                correo = "florcita@gmail.com"
            };
            // Act
            var result = controller.Agregar(clientea);
            // Assert
            Assert.AreEqual(3, result);
        }


        //Escenario 5
        [TestMethod]
        public void NoAgregarClienteConCorreoVacio()
        {
            // Arrange
            clientesController controller = new clientesController();
            var clientea = new cliente()
            {
                nombres = "Flor",
                apellidos = "Gonzalez",
                telefono = "78451202",
                correo = "florcitagmail.com"
            };
            // Act
            var result = controller.Agregar(clientea);
            // Assert
            Assert.AreEqual(4, result);
        }
    }
}
