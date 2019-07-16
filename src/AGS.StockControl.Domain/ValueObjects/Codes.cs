using AGS.StockControl.Shared.ValueObjects;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace AGS.StockControl.Domain.ValueObjects
{
    public class Codes : ValueObject
    {
        public Codes(string internalCode, string barCode)
        {
            InternalCode = internalCode;
            BarCode = barCode;

            AddNotifications(new Contract()
                    .Requires()
                    .HasMinLen(InternalCode, 10, "Codes.InternalCode", "Código interno deve ter no mínimo 10 caracteres")
                    .HasMinLen(BarCode, 10, "Codes.BarCode", "Código de barras deve ter no mínimo 10 caracteres")
            );
        }
        
        public string InternalCode { get; private set; }
        public string BarCode { get; private set; }

    }
}
