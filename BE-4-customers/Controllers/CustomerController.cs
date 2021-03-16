using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BE_4_customers.Data;
using BE_4_customers.DTO;
using BE_4_customers.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BE_4_customers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly Context _context;

        public CustomerController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomer()
        {
            return await _context.Customer.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerDTO>> GetCustomers_ById(int id)
        {
            var orders = _context.Order.ToList().Where(x => x.customer_id == id);
            var customer_by_id = _context.Customer.ToList().Find(x => x.id == id);
            if (customer_by_id == null || orders == null)
                return NotFound();
            var customerDTO = new CustomerDTO
            {
                Id = id,
                Name = customer_by_id.name,
                Orders = orders.ToList()
            };
            return customerDTO;
        }

        [HttpPost]
        public async Task<ActionResult<CustomerDTO>> Add_Customer(Customer customerDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var customer = new Customer()
            {
                id = customerDTO.id,
                name = customerDTO.name

            };
            await _context.Customer.AddAsync(customer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCustomer", new { Id = customer.id }, customerDTO);
        }
    }
}
