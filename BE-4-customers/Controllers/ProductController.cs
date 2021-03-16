using BE_4_customers.Data;
using BE_4_customers.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BE_4_customers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly Context _context;

        public ProductController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            return await _context.Product.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProducts_ById(int id)
        {
            return _context.Product.ToList().Find(x => x.id == id);
        }

        [HttpPost]
        public async Task<ActionResult<Product>> Add_Orders(Product products)
        {
            await _context.Product.AddAsync(products);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProducts", new { id = products.id }, products);
        }
    }
}
