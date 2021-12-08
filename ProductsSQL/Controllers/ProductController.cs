using AutoMapper;
using Core.DTO;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Products2.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ProductController: ControllerBase
    {
        private readonly IProductService productService;
        private readonly IMapper mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            this.productService = productService;
            this.mapper = mapper;
        }

        [HttpGet("/{productId}")]
        public IActionResult GetProudct(int productId)
        {
            var product = this.productService.GetProduct(productId);
            return Ok(product);
        }

        [HttpPost()]
        public async Task<IActionResult> AddProudct([FromBody] ProductDto productDto)
        {
            var product = mapper.Map<Product>(productDto);
            
            await this.productService.AddProduct(product);
            return Ok();
        }

        [HttpPut()]
        public async Task<IActionResult> UpdateProudct([FromBody] UpdateProductDto productDto)
        {
            var product = mapper.Map<Product>(productDto);

            await this.productService.UpdateProduct(product);

            return Ok();
        }

        [HttpDelete("/{productId}")]
        public async Task<IActionResult> DeleteProduct(int productId)
        {
            await this.productService.DeleteProduct(productId);

            return Ok();
        }
        
    }
}
