using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace OnlineBabyshop.Controllers
{
    public class AdministrationController : Controller
    {
        public readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<IdentityUser> userManager;

        private IPasswordHasher<IdentityUser> passwordHasher;

        public AdministrationController(UserManager<IdentityUser> userManager, IPasswordHasher<IdentityUser> passwordHash)
        {
            //this.roleManager = roleManager;
            this.userManager = userManager;
            passwordHasher = passwordHash;
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Index()
        {

            return View(await userManager.Users.ToListAsync());
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            return Redirect("https://localhost:44344/Identity/Account/Register");
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Admin()
        {
            return View();
        }

     

        // GET: User/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            var user = await userManager
                .FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            else
            {
                var result = await userManager.DeleteAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }

                return View("Index");


            }
        }
        // GET: User/Edit/5
        public async Task<IActionResult> Update(string id)
        {
            IdentityUser user = await userManager.FindByIdAsync(id);
            if (user != null)
                return View(user);
            else
                return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> Update(string id, string email, string phonenumber/*,string password*/)
        {
            IdentityUser user = await userManager.FindByIdAsync(id);
            if (user != null)
            {
                if (!string.IsNullOrEmpty(email))
                    user.Email = email;
                else
                    ModelState.AddModelError("", "Email cannot be empty");

                if (!string.IsNullOrEmpty(phonenumber))
                    user.PhoneNumber = phonenumber;
                else
                    ModelState.AddModelError("", "Phonenumber cannot be empty");

                //if (!string.IsNullOrEmpty(password))
                //    user.PasswordHash = passwordHasher.HashPassword(user, password);
                //else
                //    ModelState.AddModelError("", "Password cannot be empty");

                if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(phonenumber) /*&& !string.IsNullOrEmpty(password)*/)
                {
                    IdentityResult result = await userManager.UpdateAsync(user);
                    if (result.Succeeded)
                        return RedirectToAction("Index");

                }
            }
            else
                ModelState.AddModelError("", "User Not Found");
            return View(user);
        }

    }
}