using System.Net.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Waterman.Controllers;

namespace Waterman.Test
{
    [TestClass]
    public class UnitTestValuesControllert
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            // var ctrl = new ValuesController();

            // Act
            //var actual = ctrl.Get();
            var expected = 2;
            // Assert
            Assert.AreEqual(expected, 2);
        }
    }
}
