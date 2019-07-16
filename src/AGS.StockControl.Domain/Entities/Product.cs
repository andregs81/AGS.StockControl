using AGS.StockControl.Domain.ValueObjects;
using AGS.StockControl.Shared.Entities;
using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGS.StockControl.Domain.Entities
{
    public class Product : Entity
    {
        private readonly IList<Units> units;
        public Product(Category category, Codes productCodes, DescriptionProduct descriptionProduct)
        {
            Category = category;
            ProductCodes = productCodes;
            DescriptionProduct = descriptionProduct;
        }

        public Category Category { get; private set; }
        public Codes ProductCodes { get; set; }
        public DescriptionProduct DescriptionProduct { get; set; }

        public virtual IReadOnlyCollection<Units> Units { get { return units.ToArray(); } }

        public void AddUnit(Units unit)
        {
            if (unit.Valid)
                units.Add(unit);
        }

    }
}
