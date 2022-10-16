using la_mia_pizzeria_crud_mvc.Models;
using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Get()
        {
            List<Pizza> pizze = context.Pizze.ToList();

            return Ok(pizze);
        }
    }
}
