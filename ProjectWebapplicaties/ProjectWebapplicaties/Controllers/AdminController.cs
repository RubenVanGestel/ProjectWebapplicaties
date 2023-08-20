using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectWebapplicaties.Areas.Identity.Data;
using ProjectWebapplicaties.Data;
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
        private readonly ProjectWebapplicatiesContext _context;

        public AdminController(UserManager<CustomUser> userManager, RoleManager<IdentityRole> roleManager, IUnitOfWork uow,ProjectWebapplicatiesContext context) 
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _uow = uow;
            _context = context;
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
            vm.PizzaGroottes = _uow.PizzaGrootteRepository.GetAll().ToList();
            await _uow.Save();
            return View(vm);
        }

        [HttpGet]
        public async Task<ActionResult<Pizza>> DeletePizza(int id)
        {
            Pizza grootte = await _uow.PizzaRepository.GetById(id);
            if (grootte == null) return NotFound();
            _uow.PizzaRepository.Delete(grootte);
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
            var pizzaGrootte = _uow.PizzaGrootteRepository.GetAll().ToDictionary(p => p.Id, p=>p.Naam);
            pizzaGrootte.Add(-1, "Grootte Selecteren");
            var list = new SelectList(pizzaGrootte.OrderBy(x => x.Key), "Key", "Value");
            return list;
        }

        public IActionResult PizzaToevoegen()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PizzaToevoegen(PizzaAanmakenViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(new Pizza()
                {
                    Naam = viewModel.Naam,
                    PizzaGrootteId = viewModel.PizzaGrootteId,
                    Prijs = viewModel.Prijs,

                });
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(PizzaBeheer));
            }
            return View(viewModel);
        }



    }
}
