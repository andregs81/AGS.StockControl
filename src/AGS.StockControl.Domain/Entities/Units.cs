using AGS.StockControl.Shared.Entities;
using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace AGS.StockControl.Domain.Entities
{
    public class Units : Entity
    {
        public string Code { get; private set; }
        public string Description { get; private set; }
    }
}
