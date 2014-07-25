using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SampleWebApp.Models;

namespace SampleWebApp.Controllers
{
    public class CustomerController : ApiController
    {
        Customer[] customers = new Customer[]
        {
            new Customer { Id = 1, Name ="Company 1", SectorId = 1 },
            new Customer { Id = 2, Name ="Company 2", SectorId = 121 },
            new Customer { Id = 3, Name ="Company 3", SectorId = 1 },
            new Customer { Id = 4, Name ="Company 4", SectorId = 142 }
        };

        // GET api/customer
        public IEnumerable<Customer> GetAllCustomers()
        {
            return customers;
        }

        // GET api/customer/5
        public IHttpActionResult GetCustomer(int id)
        {
            var customer = customers.FirstOrDefault((p) => p.Id == id);
            if (null == customer)
            {
                return NotFound();
            }

            return Ok(customer);
        }

        // POST api/customer
        public void Post([FromBody]string value)
        {
        }

        // PUT api/customer/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/customer/5
        public void Delete(int id)
        {
        }
    }
}
