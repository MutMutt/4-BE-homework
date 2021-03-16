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
    public class OrderController : ControllerBase
    {
        private readonly Context _context;
        public OrderController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrders()
        {
            return await _context.Order.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrders_ById(int id)
        {
            return _context.Order.ToList().Find(x => x.id == id);
        }

        [HttpPost]
        public async Task<ActionResult<Order>> Add_Orders(Order order)
        {
            await _context.Order.AddAsync(order);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrders", new { Id = order.id }, order);
        }

    }
}
