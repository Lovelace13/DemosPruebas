using NUnit.Framework;
using DemoProject;

namespace DemoTestN
{
    public class DemoTestN
    {
        private Demo obj;
        private string result;

        [SetUp]
        public void Setup()
        {
            // ARRANGE
            obj = new Demo();
            result = "";
        }

        [Test]
        public void GetMessageTest()
        {
            //act
            result = obj.GetMessage();

            //assert
            Assert.IsNotEmpty(result);
            Assert.NotNull(result);
            Assert.AreEqual("Hola Mundo", result);
        }
    }
}