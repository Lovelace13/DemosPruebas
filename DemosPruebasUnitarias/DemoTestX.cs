using System;
using Xunit;
using DemoProject;

namespace DemosPruebasUnitarias
{
    public class DemoTestX
    {
        readonly Demo obj;

        public DemoTestX()
        {
            obj = new Demo();
        }

        [Fact]
        public void GetMessage()
        {
            //arrange
            string result = "";

            //act
            result = obj.GetMessage();

            //assert Hola Mundo
            Assert.NotNull(result);
            Assert.NotEmpty(result);  
            Assert.Equal("Hola Mundo!", result); //Assert.Contains
            Assert.EndsWith("ndo!", result);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(8)]
        [InlineData(22)]
        [InlineData(50)]
        public void ParesArray(int numPar)
        {
            int[] result = obj.getPares();

            Assert.DoesNotContain(3, result);
            Assert.Contains(numPar, result);
        }

        [Theory]
        [ClassData(typeof(TestParesClassData))]
        public void ImparesArray(int numInpar)
        {
            int[] result = obj.getPares();

            Assert.DoesNotContain(numInpar, result);
        }

    }
}
