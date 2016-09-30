using HelloWorld.Api.Controllers;
using HelloWorld.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace HelloWorld.Tests
{
    [TestClass]
    public class HelloWorldTests
    {
        private readonly string testReturnValue = "Hey World";
        private Mock<IDataRepository> data;
        HelloWorldController ctlr;

        [TestInitialize]
        public void Init()
        {
            data = new Mock<IDataRepository>();
            data.Setup(db => db.GetValue()).Returns(testReturnValue);
            ctlr = new HelloWorldController(data.Object);
        }

        [TestMethod]
        public void Test_Get_Returns_Expected_Service_Value()
        {
            //Arrange - Done in Initialize
            //Act
            string result = ctlr.Get();
            //Assert
            Assert.IsNotNull(result);   
            Assert.AreEqual(testReturnValue, result);
            Assert.AreNotEqual("Hello World", result);
        }
    }
}
