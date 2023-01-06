using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjectWebapplicaties.Areas.Identity.Data;
using ProjectWebapplicaties.Data.UnitOfWork;
using ProjectWebapplicaties.Models;
using ProjectWebapplicaties.ViewModels;
using System.Linq;
using System.Threading.Tasks;


namespace ProjectWebapplicaties.Controllers
{
    public class AdminController : Controller
    {
        private readonly UserManager<CustomUser> _userManager;
        private readonly IUnitOfWork _uow;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AdminController(UserManager<CustomUser> userManager, RoleManager<IdentityRole> roleManager, IUnitOfWork uow) 
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _uow = uow;
        }
        [HttpGet]
        public IActionResult GrantPermissions()
        {
            GrantPermissionsViewModel vm = new GrantPermissionsViewModel()
            {
                Gebruikers = new SelectList(_userManager.Users.ToList(),"Id","UserName"),
                Rollen = new SelectList(_roleManager.Roles.ToList(),"Id","Name")
            };
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> GrantPermissions(GrantPermissionsViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                CustomUser user = await _userManager.FindByIdAsync(viewModel.GebruikerId);
                IdentityRole role = await _roleManager.FindByIdAsync(viewModel.RolId);
                if (user != null && role != null)
                {
                    IdentityResult result = await _userManager.AddToRoleAsync(user, role.Name);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Gebruikers");
                    }
                    else
                    {
                        foreach (IdentityError error in result.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }

                    }
                }
                else
                {
                    ModelState.AddModelError("", "User or role Not Found");
                }

            }
            return View(viewModel);
        }

        public async Task<IActionResult> PizzaBeheer()
        {
            PizzaListViewModel vm = new PizzaListViewModel();
            vm.Pizzas = _uow.PizzaRepository.GetAll().ToList();
            vm.Groottes = _uow.PizzaGrootteRepository.GetAll().ToList();
            return View(vm);
        }

        [HttpGet]
        public async Task<ActionResult<Pizza>> DeletePizza(int id)
        {
            Pizza merk = await _uow.PizzaRepository.GetById(id);
            if (merk == null) return NotFound();
            _uow.PizzaRepository.Delete(merk);
            await _uow.Save();

            return RedirectToAction(nameof(PizzaBeheer));
        }



        [HttpGet]
        public async Task<ActionResult<Pizza>> PizzaBewerken(int id)
        {
            ViewBag.Groottes = getPizzaGroottes();
            var model = await _uow.PizzaRepository.GetById(id);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> PizzaBewerken(int id, Pizza pizza)
        {
            if (id != pizza.Id)
            {
                return BadRequest();
            }
            _uow.PizzaRepository.Update(pizza);
            await _uow.Save();
            return RedirectToAction(nameof(PizzaBeheer));
        }


        public async Task<IActionResult> Delete(string id)
        {
            CustomUser user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                IdentityResult result = await _userManager.DeleteAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("Gebruikers");
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            else
            {
                ModelState.AddModelError("", "User not found");
            }
            return View("Gebruikers", _userManager.Users.ToList());

        }

        public IActionResult Index()
        {
            GebruikerListViewModel viewModel = new GebruikerListViewModel()
            {
                Gebruikers = _userManager.Users.ToList()
            };

            return View(viewModel);
        }
        public IActionResult Gebruikers()
        {
            GebruikerListViewModel vm = new GebruikerListViewModel()
            {
                Gebruikers = _userManager.Users.ToList()
            };

            return View(vm);
        }

        private SelectList getPizzaGroottes()
        {
            var pizzaGrootte = _uow.PizzaGrootteRepository.GetAll().ToDictionary(p => p.Id,p=>p.Naam);
            pizzaGrootte.Add(-1, "Gelieve een Grootte te selecteren");
            var list = new SelectList(pizzaGrootte.OrderBy(x => x.Key), "Key", "Value");
            return list;
        }

    }
}
