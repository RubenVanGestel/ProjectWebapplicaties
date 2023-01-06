using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjectWebapplicaties.Areas.Identity.Data;
using ProjectWebapplicaties.ViewModels;
using System.Linq;
using System.Threading.Tasks;


namespace ProjectWebapplicaties.Controllers
{
    public class AdminController : Controller
    {
        private UserManager<CustomUser> _userManager;
        private RoleManager<IdentityRole> _roleManager;

        public AdminController(UserManager<CustomUser> userManager, RoleManager<IdentityRole> roleManager) 
        {
            _userManager = userManager;
            _roleManager = roleManager;
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

    }
}
