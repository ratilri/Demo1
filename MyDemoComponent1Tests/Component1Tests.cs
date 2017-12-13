using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyDemoComponent1.Tests
{
    [TestClass()]
    public class Component1Tests
    {
        [TestMethod()]
        public void TestMethodTest()
        {
            Parameters params1 = new Parameters();
            params1.prop1 = "Jee this is the unit test!";
            var result = Component1.TestMethod(params1);
            Assert.AreSame("Jee this is the unit test!", result);
        }
    }
}