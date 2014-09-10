using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Avantgarde.Moq.Examples.Tests
{
    [TestClass]
    public class LogTests
    {
        [TestMethod]
        public void WriteToLogTest()
        {
            Assert.Fail();
        }

        //Now we can use Moq in our unit test to create a mock of an object implementing ILog:
        public void FooLogsCorrectly()
        {
            // Arrange
            var logMock = new Mock<ILog>();
            var logGenerator = new LogGenerator(logMock.Object);

            // Act
            logGenerator.Foo();

            // Assert
            logMock.Verify(m => m.WriteToLog("my log message"));
        }
    }
}