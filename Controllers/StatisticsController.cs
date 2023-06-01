using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebShop.Areas.Identity.Data;
using WebShop.Models;
using WebShop.ViewModels.DTO;

namespace WebShop.Controllers
{
    public class StatisticsController : Controller
    {
        private readonly ShoppingCart shoppingCart;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly AppDbContext _appDbContext;
        public StatisticsController(AppDbContext appDbContext, UserManager<ApplicationUser> userManager, ShoppingCart shoppingCart)
        {
            _userManager = userManager;
            _appDbContext = appDbContext;
            this.shoppingCart = shoppingCart;

        }
        public IActionResult OverView(string search)
        {
            // Retrieve the list of orders from the database
            IQueryable<OrderDTO> query = _appDbContext.Orders.Select(o => new OrderDTO
            {
                FirstName = o.FirstName,
                LastName = o.LastName,
                City = o.City,
                ZipCode = o.ZipCode,
                Adress = o.Adress,
                TotalOrderAmount = o.TotalOrderAmount


            });

            if (!string.IsNullOrEmpty(search))
            {
                // Filter the orders based on the search query
                query = query.Where(o =>
                    o.FirstName.Contains(search) ||
                    o.LastName.Contains(search) ||
                    o.City.Contains(search) ||
                    o.ZipCode.Contains(search) ||
                    o.Adress.Contains(search) ||
                    o.TotalOrderAmount.ToString().Contains(search)
                );
            }

            IEnumerable<OrderDTO> orders = query.ToList();

            return View("OverView", orders);
        }






    }
}