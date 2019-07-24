using AGS.StockControl.Domain.Commands;
using AGS.StockControl.Domain.Entities;
using AGS.StockControl.Domain.Handlers;
using AGS.StockControl.Domain.ValueObjects;
using AGS.StockControl.Tests.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AGS.StockControl.Tests.Handlers
{
    [TestClass]
    public class ProductHandlerTest
    {
        [TestMethod]
        public void ShouldReturnErrorWhenProductExists()
        {
            var handler = new ProductHandler(new FakeProductRepository(), new FakeEmailService());
            var command = new CreateProductCommand();
            command.Category = new Category("BZ", "Bazar");
            command.ProductCodes = new Codes("123456", "XXXXXX");
            command.DescriptionProduct = new DescriptionProduct("Caneta Bic Azul", "Caneta esferográfica");

            handler.Handle(command);
            Assert.AreEqual(false, handler.Valid);
        }

    }
}
