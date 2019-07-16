using AGS.StockControl.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AGS.StockControl.Domain.Entities
{
    public class Category : Entity
    {
        public Category(string categoryCode, string categoryName)
        {
            CategoryCode = categoryCode;
            CategoryName = categoryName;
        }

        public string CategoryCode { get; private set; }
        public string CategoryName { get; private set; }
    }
}
