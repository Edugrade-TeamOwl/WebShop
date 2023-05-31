using Microsoft.AspNetCore.Mvc;
﻿using Microsoft.AspNetCore.Identity;
using WebShop.Areas.Identity.Data;
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
        public IActionResult OverView()
        {
            // Retrieve the list of orders from the database
            IEnumerable<OrderDTO> orders = _appDbContext.Orders.Select(o => new OrderDTO
            {
                FirstName = o.FirstName,
                LastName = o.LastName,
                City = o.City,
                ZipCode = o.ZipCode,
                Adress = o.Adress
            }).ToList();

            return View(orders);
        }
    }
}