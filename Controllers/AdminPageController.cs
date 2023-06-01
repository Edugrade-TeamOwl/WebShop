using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebShop.Areas.Identity.Data;
using WebShop.Models;
using WebShop.ViewModels.DTO;

namespace WebShop.Controllers
{
    public class AdminPageController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly AppDbContext _Context;

        public AdminPageController(UserManager<ApplicationUser> userManager, AppDbContext Context)
        {
            _userManager = userManager;
            _Context = Context;
        }
        public async Task<IActionResult> Dashboard()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user != null && user.IsAdmin)
            {
                return View();
            }
            else
            {
                return RedirectToAction("AccessDenied", "AdminPage");
            }
        }

        public IActionResult AccessDenied()
        {
            return View();
        }

        public async Task<IActionResult> OrderLog() 
        {
            var user = await _userManager.GetUserAsync(User);
            if (user != null && user.IsAdmin)
            {
                return View(await _Context.Orders.ToListAsync());
            }
            else
            {
                return RedirectToAction("AccessDenied", "AdminPage");
            }
        }
        public async Task<IActionResult> OrderDetails(int id)
        {
            var order = await _Context.Orders.Where(t => t.OrderId == id).Include(o => o.orderDetails).ThenInclude(o=>o.Product).FirstOrDefaultAsync();
            
            if (order == null)
            {
                return NotFound();
            }


            return View(order);
        }



    }
}
