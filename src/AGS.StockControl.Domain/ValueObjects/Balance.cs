using AGS.StockControl.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AGS.StockControl.Domain.ValueObjects
{
    public class Balance : ValueObject
    {
        public Balance(decimal storeBalance)
        {
            StoreBalance = storeBalance;
        }

        public decimal StoreBalance { get; private set; }
    }
}
