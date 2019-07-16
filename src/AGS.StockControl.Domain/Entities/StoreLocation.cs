using AGS.StockControl.Domain.ValueObjects;
using AGS.StockControl.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AGS.StockControl.Domain.Entities
{
    public class StoreLocation : Entity
    {
        public Codes StorageCodes { get; private set; }
        public Balance Balance { get; private set; }
    }
}
