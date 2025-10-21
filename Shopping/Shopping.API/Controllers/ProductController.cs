using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shopping.API.Data;
using Shopping.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace Shopping.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController
    {
        private readonly ProductContext _context;
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger, ProductContext context)
        {
            _logger = logger;   
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> GetAsync()
        {
            return await _context.Products
                                 .Find(p => true)
                                 .ToListAsync();
        }
    }
}
