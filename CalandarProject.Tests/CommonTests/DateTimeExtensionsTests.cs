using System;
using System.Linq;
using Common.Extentions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalandarProject.Tests.CommonTests
{
    [TestClass]
    public class DateTimeExtensionsTests
    {
        [TestMethod]
        public void GetMonthTest()
        {
            var months = DateTimeExtextions.GetFullMonthNames();

            Assert.IsNotNull(months);
            Assert.IsTrue(months.Any());
            Assert.IsTrue(months.Count == 12);
        }

        [TestMethod]
        public void GetFirstOfMonthTest()
        {
            var testDate = DateTime.Now.StartOfMonth();

            Assert.IsTrue(testDate.Day == 1);
        }

        [TestMethod]
        public void GetEndOfMonthTest()
        {
            var testDate = DateTime.Now.EndOfMonth();

            Assert.IsTrue(testDate.Day == DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
        }
    }
}
