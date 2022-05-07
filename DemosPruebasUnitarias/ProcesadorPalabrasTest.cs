using Xunit;
using DemoProject;
using Moq;

namespace DemosPruebasUnitarias
{
    public class ProcesadorPalabrasTest
    {
        [Fact]
        public void ContarPalabras()
        {
            var mock = new Mock<ILectorArchivo>(); //Instancia de ILectorArchivo lector = new LectorArchivo();
            mock.Setup(mock => mock.LeerArchivo(It.IsAny<string>())).Returns("HOLA MUNDO");

            ProcesadorPalabras procesador = new ProcesadorPalabras(mock.Object);
            int result = procesador.ContarPalabras();

            Assert.Equal(2, result);
        }

        [Fact]
        public void ContarCaracter()
        {
            var mock = new Mock<ILectorArchivo>(); //Instancia de ILectorArchivo lector = new LectorArchivo();
            mock.Setup(mock => mock.LeerArchivo(It.IsAny<string>())).Returns("HOLA MUNDO");

            ProcesadorPalabras procesador = new ProcesadorPalabras(mock.Object);
            int result = procesador.ContarCaracter();

            Assert.NotEqual(0, result); // Assert.Equal(10, result);
        }
    }
}
