using System.Linq;
using System.Net.Http;
using NUnit.Framework;
using Waterman.Controllers;
using Waterman.DataAccess;

namespace Waterman.Test
{
    [TestFixture]
    public class TodoTest
    {
        private WatermanContext Context;

        public TodoTest()
        {
            this.Context = new WatermanContext(new Microsoft.EntityFrameworkCore.DbContextOptions<WatermanContext>());
        }

        public TodoTest(WatermanContext context)
        {
            this.Context = context;
        }

        [Test]
        public void TestGetAll()
        {
            // Arrange
            var ctrl = this.Context.TodoItems;

            // Act
            var actual = ctrl.Count();
            var expected = 5;
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
