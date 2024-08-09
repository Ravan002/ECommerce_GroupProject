using Business.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entites.Concrete;
using Entites.Concrete.DTO;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController(IProductService productService) : ControllerBase
    {
        private readonly IProductService _productService = productService;
        

        [HttpGet("GetProductSubCategories")]
        public IActionResult GetProductSubCategories(int id)
        {
            ECommerceContext context = new ECommerceContext();
            var data = context.ProductSubCategories.Where(pc => pc.ProductId == id).ToList();
            var result = new List<string>();
            foreach (var item in data)
            {
                result.Add(context.SubCategories.SingleOrDefault(sc => sc.Id == item.SubCategoryId).Name);
            };
            return Ok(result);
        }


        [HttpPost("AddProduct")]
        public IActionResult CreateProduct([FromBody] ProductDto productDto)
        {
            Product product = new Product()
            {
                Name = productDto.Name,
                Description = productDto.Description
            };
            _productService.Add(product);
            return Ok(product);
        }
    }
}
