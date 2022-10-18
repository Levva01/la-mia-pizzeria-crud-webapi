using la_mia_pizzeria_crud_webapi.Models;
using Microsoft.AspNetCore.Mvc;

namespace NetCore_01.Controllers.Api
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        [HttpPost]
        public IActionResult Send([FromBody] Message message)
        {

            ApplicationDbContext ctx = new ApplicationDbContext();

            ctx.Messages.Add(message);
            ctx.SaveChanges();

            return Ok();
        }
    }
}
