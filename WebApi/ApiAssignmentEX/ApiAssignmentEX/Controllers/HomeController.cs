using ApiAssignmentEX.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiAssignmentEX.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        CompanyContext cc;
        public HomeController(CompanyContext cc)
        {
            this.cc = cc;
        }
        [HttpGet]
        public IActionResult GetEmp()
        {
            var rec = this.cc.Emps.ToList();
            if (rec == null)
                return NotFound();
            return Ok(rec);
        }
    }
}
