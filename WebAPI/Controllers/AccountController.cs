using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IActionResult> Get()
        {
            //We can return
            List<string> items = new List<string>()
            {
            };
            return Ok(items);
        }
    }
}
