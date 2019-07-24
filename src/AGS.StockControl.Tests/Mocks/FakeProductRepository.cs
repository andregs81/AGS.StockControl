using AGS.StockControl.Domain.Entities;
using AGS.StockControl.Domain.Repositories;

namespace AGS.StockControl.Tests.Mocks
{
    public class FakeProductRepository : IProductRepository
    {
        public void CreateProdutct(Product product)
        {
        }

        public bool ProductCodExists(string productCode)
        {
            if (productCode == "123456")
                return true;

            return false;
        }

        public bool ProductNameExists(string productName)
        {
            if (productName.ToLower() == "Caneta Bic azul".ToLower())
                return true;

            return false;
        }
    }
}
