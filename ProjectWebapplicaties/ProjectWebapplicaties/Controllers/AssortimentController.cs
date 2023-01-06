using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectWebapplicaties.Data.UnitOfWork;
using ProjectWebapplicaties.ViewModels;
using System.Linq;

namespace ProjectWebapplicaties.Controllers
{
    public class AssortimentController : Controller
    {
        private readonly IUnitOfWork _uow;

        public AssortimentController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public IActionResult Index()
        {
            PizzaListViewModel vm = new PizzaListViewModel();
            vm.Pizzas = _uow.PizzaRepository.GetAll().Include(x=> x.PizzaGrootte).ToList();
            vm.Groottes = _uow.PizzaGrootteRepository.GetAll().ToList();

            return View(vm);
        }
    }
}
