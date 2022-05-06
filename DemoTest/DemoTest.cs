using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoProject;

namespace DemoTest
{
    [TestClass]
    public class DemoTest
    {
        [TestMethod]
        public void GetMessageTest()
        {
            //arrange
            Demo obj = new Demo();
            string result = "";

            //act
            result = obj.GetMessage();

            //assert
            Assert.IsNull(result);
            Assert.IsNotNull(result);
            Assert.AreEqual("Hola Mundo", result);

        }
    }
}
