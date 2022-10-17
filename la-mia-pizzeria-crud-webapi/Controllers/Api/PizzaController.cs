using la_mia_pizzeria_crud_mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Microsoft.Graph;
using System.Security.Cryptography.X509Certificates;

namespace la_mia_pizzeria_crud_mvc.Controllers.Api
{
    [Route("api/[controller]/[action]")]
    [ApiController]

    public class PizzaController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();

        public PizzaController()
        {

        }

        [HttpGet]
        public IActionResult Get(string? title)
        {
            IQueryable<Pizza> pizze;

            if (title != null)
            {
                pizze = context.Pizze.Where(post => post.Nome.ToLower().Contains(title.ToLower()));
            }
            else
            {
                pizze = context.Pizze;
            }

            return Ok(pizze.ToList<Pizza>());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Pizza pizza = context.Pizze.Where(p => p.Id == id).FirstOrDefault();

            return Ok(pizza);
        }
    }
}
