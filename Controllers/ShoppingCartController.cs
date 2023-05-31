using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebShop.Areas.Identity.Data;
using WebShop.Models;

namespace WebShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ShoppingCart shoppingCart;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly AppDbContext _appDbContext;

        public ShoppingCartController(AppDbContext appDbContext, UserManager<ApplicationUser> userManager, ShoppingCart shoppingCart)
        {
            this.shoppingCart = shoppingCart;
            _userManager = userManager;
            _appDbContext = appDbContext;
        }
        public IActionResult ListCart()
        {
            List<Product> cartItems = shoppingCart.GetCartItems();
            
            return View(cartItems);
        }

        [HttpPost]
        public IActionResult AddToCart(Product product)
        {
            // Retrieve the product details from your data source using the product ID            
            if (product != null)
            {
                // Create a new cart item and add it to the shopping cart

                shoppingCart.AddToCart(product);
            }
            
            // Redirect to a different view or perform any other actions
            return RedirectToAction("ListCart");
        }
        public IActionResult Checkout()
        {            
            return View();
        }

        public IActionResult EmptyCart()
        {
            shoppingCart.EmptyCart();
            return RedirectToAction("ListCart");
        }

        public IActionResult RemoveCartItem(int i)
        {
            shoppingCart.RemoveCartItem(i);
            return RedirectToAction("ListCart");
        }
    }
}
