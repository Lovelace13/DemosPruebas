using Xunit;
using DemoProject;
;

namespace DemosPruebasUnitarias
{
    public class CalculadoraTest
    {
        [Fact]
        public void Suma()
        {
            //Arrange
            Calculadora cal = new Calculadora();
            int result = 0;

            //Act
            result = cal.Suma(3, 4);

            //Assert
            Assert.Equal(7, result);
        }

        [Fact]
        public void Resta()
        {
            //Arrange
            Calculadora cal = new Calculadora();
            int result = 0;

            //Act
            result = cal.Resta(4, 3);

            //Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Multiplicacion()
        {
            //Arrange
            Calculadora cal = new Calculadora();
            int result = 0;

            //Act
            result = cal.Multiplicacion(4, 3);

            //Assert
            Assert.Equal(12, result);
        }


        [Fact]
        public void Division()
        {
            //Arrange
            Calculadora cal = new Calculadora();
            int result = 0;

            //Act
            result = cal.Division(12, 3);

            //Assert
            Assert.Equal(4, result);
        }
    }
}
