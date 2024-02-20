

using Core.Entity;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController(IProductRepository repository) : ControllerBase
    {
        private readonly IProductRepository _repository = repository;

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            return Ok(await _repository.GetProductsAsync());
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id){
            return await _repository.GetProductByIdAsync(id);
        }

        [HttpGet("brands")]
        public async Task<ActionResult<IReadOnlyList<ProductBrand>>> GetProductBrands(){
            return Ok(await _repository.GetProductBrandAsync());
        }

        [HttpGet("types")]
        public async Task<ActionResult<IReadOnlyList<ProductType>>> GetProductTypes(){
            return Ok(await _repository.GetProductTypesAsync());
        }
    }
}