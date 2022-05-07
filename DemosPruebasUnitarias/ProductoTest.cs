using System;
using Xunit;
using DemoProject;
using AutoFixture;

namespace DemosPruebasUnitarias
{
    public class ProductoTest
    {
        [Fact]
        public void ProductoEntityTest()
        {
            Fixture fix = new Fixture();
            Producto producto = fix.Create<Producto>(); //new Producto();

            //Producto producto = fix.Build<Producto>().
            //With(p => p.Nombre, "Nevera").                      //Establece un valor fijo
            //WithOut(p => p.Descripcion).                        //Crea el objeto sin este valor
            //Create();

            //Autofixture crea ramdon estos datos
            //producto.nombre = "Nevera";
            //producto.descripcion = "Congelador para carnes";
            //producto.precio = 325;

            decimal impuesto = producto.precio * Convert.ToDecimal(0.19);
            string descripcionCompleta = producto.nombre + " - " + producto.descripcion;

            Assert.Equal(impuesto, producto.Impuesto);
            Assert.Equal(descripcionCompleta, producto.fullDescripcion);
        }
    }
}
