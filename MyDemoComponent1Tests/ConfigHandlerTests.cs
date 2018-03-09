using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestConfigurationHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConfigurationHandler.Tests
{
    [TestClass()]
    public class ConfigHandlerTests
    {
        [TestMethod()]
        public void ReadConfigValueTest()
        {

            var t = ConfigHandler.ReadConfigValue("Test");
            System.Diagnostics.Trace.WriteLine(t);
            Assert.IsTrue(!String.IsNullOrEmpty((string)t));
        }
    }
}