using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using DepemdencyInjection;

namespace UnitTestDI
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var mockobj = new Mock<IDataAccess>();
            mockobj.Setup(x => x.GetData(1)).Returns("Hello1");

            var mockobj1 = new BuisnessLogic(mockobj.Object);
            var data = mockobj1.GetData(1);
            Assert.AreEqual(data, "Hello1");


        }
    }
}
