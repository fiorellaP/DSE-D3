using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using DSE_D3.Controllers;
using DSE_D3.Models;

namespace DSE_D3.Tests.Controllers
{
    [TestClass]
    public class ProductoControllerTest
    {//Escenario 1
        [TestMethod]
        public void AgregarProductoNoRepetido()
        {
            // Arrange
            productoesController controller = new productoesController();
            var productoa = new producto()
            {
                nombre_producto = "dolofin fuerte",
                presentacion = "1 tableta",
                dosis = "500mg",
                cantidad = 10,
                precio = 1,
            };
            // Act
            var result = controller.Agregar(productoa);
            // Assert
            Assert.AreEqual(0, result);
        }

        //Escenario 2
        [TestMethod]
        public void NoAgregarProductoRepetido()
        {
            // Arrange
            productoesController controller = new productoesController();
            var productoa = new producto()
            {
                nombre_producto = "acetaminofen",
                presentacion = "1 tableta",
                dosis = "500mg",
                cantidad = 10,
                precio = 1,
            };
            // Act
            var result = controller.Agregar(productoa);
            // Assert
            Assert.AreEqual(1, result);
        }

        //Escenario 3
        [TestMethod]
        public void NoAgregarProductoConNombreVacio()
        {
            // Arrange
            productoesController controller = new productoesController();
            var productoa = new producto()
            {
                nombre_producto = "",
                presentacion = "1 tableta",
                dosis = "500mg",
                cantidad = 10,
                precio = 1,
            };
            // Act
            var result = controller.Agregar(productoa);
            // Assert
            Assert.AreEqual(2, result);
        }


        //Escenario 4
        [TestMethod]
        public void NoAgregarProductoConPresentacionVacio()
        {
            // Arrange
            productoesController controller = new productoesController();
            var productoa = new producto()
            {
                nombre_producto = "acetaminofen kids",
                presentacion = "",
                dosis = "500mg",
                cantidad = 10,
                precio = 1,
            };
            // Act
            var result = controller.Agregar(productoa);
            // Assert
            Assert.AreEqual(3, result);
        }


        //Escenario 5
        [TestMethod]
        public void NoAgregarCantidadMenor()
        {
            // Arrange
            productoesController controller = new productoesController();
            var productoa = new producto()
            {
                nombre_producto = "acetaminofen kids",
                presentacion = "1 tableta",
                dosis = "500mg",
                cantidad = 0,
                precio = 1,
            };
            // Act
            var result = controller.Agregar(productoa);
            // Assert
            Assert.AreEqual(4, result);
        }
    }
}
