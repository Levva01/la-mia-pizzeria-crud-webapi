using la_mia_pizzeria_crud_mvc.Models;

namespace la_mia_pizzeria_crud_webapi.Models
{
    public class PizzaRepository
    {
        public List<Pizza> GetList();
        public List<Pizza> GetListByFilter(string search);
        public Pizza GetById(int id);
        public void Create(Pizza pizza);
        public void Update(Pizza pizza);
        public void Delete(Pizza pizza);
    }
}
