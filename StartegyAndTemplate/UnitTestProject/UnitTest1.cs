using System;
using System.Threading;
using ConsoleApplication1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DirectoryReporter_getFooter_ReturnsFixedStringWithDatetime()
        {
            DirectoryReporter reporter = new DirectoryReporter();

            var a = reporter.getFooter();

            Assert.IsNotNull(a);
            Assert.IsTrue(a.StartsWith(Resources.ReporterFooterString));
            Assert.IsInstanceOfType(reporter, typeof(Reporter));
        }

        [TestMethod]
        public void DirectoryReporter_Multiple_getFooter_yieldFixedStringWithDifferentDateTime()
        {
            DirectoryReporter reporter = new DirectoryReporter();

            var a = reporter.getFooter();
            Thread.Sleep(100);
            var b = reporter.getFooter();

            Assert.IsNotNull(a, "reporter A = null");
            Assert.IsNotNull(b, "reporter B is null");
            Assert.IsTrue(a.StartsWith("This report was generated on "), "getFooter did not return expected message");
            Assert.IsInstanceOfType(reporter, typeof(Reporter), "reporter is not derived from Reporter");
            Assert.IsTrue(a != b);
        }
    }
}
