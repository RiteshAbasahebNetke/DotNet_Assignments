using ApiCurdEx.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCurdEx.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerAPIController : ControllerBase
    {
        Context c;
        public CustomerAPIController(Context c)
        {
            this.c = c;
        }

        [HttpGet]
        public IActionResult GetCustomers()
        {
            var res = this.c.Customers.ToList();
            if(res==null)
                return NotFound();
            return Ok(res);
        }

        [HttpPost]
        public IActionResult Create(Customer rec)
        {
            if (rec == null)
                return BadRequest();

            this.c.Customers.Add(rec);
            this.c.SaveChanges();
            return Ok("Record Saved");
        }

        [HttpGet("id")]
        public IActionResult GetByID(Int64 id)
        {
            if (id == 0)
                return BadRequest();
            var rec = this.c.Customers.Find(id);
            if (rec == null)
                return NotFound();
            return Ok(rec);
        }

        [HttpPut("id")]
        public IActionResult Update(Customer rec)
        {
            if(rec==null)
                return BadRequest();
            this.c.Entry(rec).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            this.c.SaveChanges();
            return Ok("Record Updated");
        }

        [HttpDelete("id")]
        public IActionResult Delete(Int64 id)
        {
            if (id == 0)
                return BadRequest();

            var rec = this.c.Customers.Find(id);
            this.c.Customers.Remove(rec);
            this.c.SaveChanges();
            return Ok("Record Deleted");
        }
    }
}
