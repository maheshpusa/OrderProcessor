using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderProcessor.Helper;
using System;

namespace OrderProcessor.HelperTests
{
    [TestClass]
    public class ProcesspackageTest
    {
        [TestMethod]
        public void TestForBook()
        {
            ProcessPackage pkg = new ProcessPackage();
            pkg.processpackage("BookRule");

        }
    }
}
