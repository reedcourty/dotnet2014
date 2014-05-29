using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace pomodoroUnitTest
{
    [TestClass]
    public class ConfigManagerUnitTest
    {
        [TestMethod]
        public void TestMethodExportToMSSQL_set_true()
        {
            // arrange
            bool exportToMSSQL = true;
            pomodoro.Tracer tracer = new pomodoro.Tracer();
            pomodoro.ConfigManager cm = new pomodoro.ConfigManager(tracer);
            
            // act
            cm.Configuration.ExportToMSSQL = exportToMSSQL;

            // assert
            bool actual = cm.Configuration.ExportToMSSQL;
            Assert.AreEqual(exportToMSSQL, actual);

            // Tear down:
            tracer.Close();
        }

        [TestMethod]
        public void TestMethodExportToXLSX_set_true()
        {
            // arrange
            bool exportToXLSX = true;
            pomodoro.Tracer tracer = new pomodoro.Tracer();
            pomodoro.ConfigManager cm = new pomodoro.ConfigManager(tracer);

            // act
            cm.Configuration.ExportToXLSX = exportToXLSX;

            // assert
            bool actual = cm.Configuration.ExportToXLSX;
            Assert.AreEqual(exportToXLSX, actual);

            // Tear down:
            tracer.Close();
        }
    }
}
