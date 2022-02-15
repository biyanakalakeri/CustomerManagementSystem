using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerManagementSystem.Moodels
{
    [Route("api/[controller]")]
    [EnableCors("AllowOrigin")]
    [ApiController]
    public class CustomerAPIController : ControllerBase
    {
        // GET: api/<CustomerAPIController>
        [HttpGet]
        public string Get()
        {
            DBhandle db = new DBhandle();
            return db.viewcustomer();
        }
        // POST api/<CustomerAPIController>
        [HttpPost]
        [Route("register")]
        public void Post(Customer c)
        {
            DBhandle db = new DBhandle();
            db.addcustomer(c);
            return;
        }
        // PUT api/<CustomerAPIController>/5
        [HttpPut]
        public void Put(Customer c)
        {
            DBhandle db = new DBhandle();
            db.updatecustomer(c);
            return;
        }
        // DELETE api/<CustomerAPIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            DBhandle db = new DBhandle();
            db.DeleteCus(id);
            return;
        }
        [Route("getrecord")]
        public Customer Get(int CustomerId)
        {
            DBhandle db = new DBhandle();
            Customer cus = db.getcusonID(CustomerId);
            return cus;
        }
    }
}