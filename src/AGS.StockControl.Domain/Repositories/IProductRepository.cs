using AGS.StockControl.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AGS.StockControl.Domain.Repositories
{
    public interface IProductRepository
    {
        bool ProductCodExists(string productCode);
        bool ProductNameExists(string productName);
        void CreateProdutct(Product product);
    }
}
