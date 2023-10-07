using GraphOfOrders.Lib.DTOs;
using GraphOfOrders.Lib.DI;
using Microsoft.AspNetCore.Mvc;

namespace GraphOfOrders.Api
{
    [ApiController]
    [Route("[controller]")]
    public class BrandController : ControllerBase
    {
        private readonly IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpGet("brands-by-product")]
        public IEnumerable<BrandDTO> GetBrandsByProduct(int productId)
        {
            return _brandService.GetBrandsByProduct(productId);
        }
    }
}