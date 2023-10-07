using GraphOfOrders.Lib.DTOs;
using System.Collections.Generic;

namespace GraphOfOrders.Lib.DI
{
    public interface IBrandService
    {
        IEnumerable<BrandDTO> GetBrandsByProduct(int productId);
    }
}