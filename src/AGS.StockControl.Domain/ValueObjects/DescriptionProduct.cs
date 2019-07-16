using AGS.StockControl.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AGS.StockControl.Domain.ValueObjects
{
    public class DescriptionProduct : ValueObject
    {
        public DescriptionProduct(string description, string descrTecnical)
        {
            Description = description;
            DescrTecnical = descrTecnical;
        }

        public string Description { get; private set; }
        public string DescrTecnical { get; private set; }
    }
}
