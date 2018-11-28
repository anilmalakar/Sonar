using SFApi.Controllers;
using System;
using Xunit;

namespace SFApiTestProject
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();
        [Fact]
        public void Test1()
        {
            var result  = controller.Get(100);
            Assert.Equal("value", result);
        }
    }
}
