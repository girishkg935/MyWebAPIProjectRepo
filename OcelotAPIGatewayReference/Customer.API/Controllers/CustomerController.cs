using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerService.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerDbContext context;

        public CustomerController(CustomerDbContext context)
        {
            this.context = context;
        }

        // GET: api/<UserController>
        [HttpGet]
       public IEnumerable<Models.Customer> Get()
        {
            return context.Customers.ToList();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public Models.Customer Get(int id)
        {
            return context.Customers.Find(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public IActionResult Post([FromBody] Models.Customer customer)
        {
            try
            {
                context.Customers.Add(customer);
                context.SaveChanges();

                return StatusCode(200, customer);
            }
            catch(Exception ex)
            {
                return StatusCode(500,ex);
            }
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
