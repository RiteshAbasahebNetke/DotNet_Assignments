using CurdAPIJan21.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CurdAPIJan21.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        Context c;
        public HomeController(Context c)
        {
            this.c = c;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var res = this.c.Products.ToList();
            if(res==null)
                return NotFound();
            return Ok();
        }
        [HttpPost]
        public IActionResult Create(Product rec)
        {
            if(rec==null)
                return BadRequest();

            this.c.Products.Add(rec);
            this.c.SaveChanges();
            return Ok("Record Saved");
        }
        [HttpPut("id")]
        public IActionResult Update(Product rec)
        {
            if(rec==null)
                return BadRequest();
            this.c.Entry(rec).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            this.c.SaveChanges();
            return Ok("Record Updated");
        }
        [HttpDelete("id")]
        public IActionResult Delete(int id)
        {
            if(id==0)
                return BadRequest();

            var rec = this.c.Products.Find(id);
            this.c.Products.Remove(rec);
            this.c.SaveChanges();
            return Ok("Record Deleted");
        }
    }
}
