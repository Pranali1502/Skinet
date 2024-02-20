

using Core.Entity;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController(StoreContext context) : ControllerBase
    {
        private readonly StoreContext _storeContext = context;

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts(){
            var products = await _storeContext.Products.ToListAsync();

            return products;
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Product>> GetProduct(int id){
            return await _storeContext.Products.FindAsync(id);
        }
    }
}