using AGS.StockControl.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AGS.StockControl.Tests.ValueObjects
{
    [TestClass]
    public class CodesTests
    {
        [TestMethod]
        public void ShouldReturnErrorWhenCodeInvalid()
        {
            var code = new Codes("123456789", "1234567890");
            Assert.IsTrue(code.Invalid);
        }

        [TestMethod]
        public void ShouldReturnSuccessWhenCodeValid()
        {
            var code = new Codes("12345678900", "1234567890");
            Assert.IsTrue(code.Valid);
        }
    }
}
