using CurdApiEx.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CurdApiEx.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        CustContext cc;
        public HomeController(CustContext cc)
        {
            this.cc = cc;
        }

        [HttpGet]
        public IActionResult GetCustomer()
        
        {
            var res=this.cc.Customers.ToList();
            if (res == null)
                return NotFound();

            return Ok(res);
        }
        [HttpPost]
        public IActionResult Create(Customer rec)
        {
            if (rec == null)
                return BadRequest();

            this.cc.Customers.Add(rec);
            this.cc.SaveChanges();

            return Ok("Record Saved");
        }
        [HttpGet("{id}")]
        public IActionResult GetByID(Int64 id)
        {
            if (id == 0)
                return BadRequest();
            var rec = this.cc.Customers.Find(id);
            if (rec == null)
                return NotFound();
            return Ok(rec);
        }
        [HttpPut]
        public IActionResult Update(Customer rec)
        {
            if (rec == null)
                return BadRequest();

            this.cc.Entry(rec).State=Microsoft.EntityFrameworkCore.EntityState.Modified;
            this.cc.SaveChanges();

            return Ok("Record Updated");
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Int64 id)
        {
            if(id==0)
                return BadRequest();

            var rec = this.cc.Customers.Find(id);
            this.cc.Customers.Remove(rec);
            this.cc.SaveChanges();

            return Ok("Record Deleted");
        }
    }
}
