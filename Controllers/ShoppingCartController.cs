using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebShop.Areas.Identity.Data;
using WebShop.Models;
using WebShop.ViewModels.DTO;

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
            decimal totalOrderAmount = shoppingCart.CalculateTotal();

            ViewBag.TotalOrderAmount = totalOrderAmount;

            return View(cartItems);
        }


        [HttpPost]
        public IActionResult AddToCart(Product product)
        {
            // Retrieve the product details from your data source using the product ID            
            if (product != null)
            {
                // Create a new cart item and add it to the shopping cart
                var exist = shoppingCart.GetCartItem(product.ProductId.ToString());
                if (exist != null) 
                {
                    exist.Quantity = exist.Quantity + 1;
                }
                else
                {
                    shoppingCart.AddToCart(product);
                }
                
            }

            // Redirect to a different view or perform any other actions
            return RedirectToAction("ListCart");
        }
        public async Task<IActionResult> Checkout()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user != null)
            {
                return View();
            }
            else
            {
                return View("_LoginPartial");
            }
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
        public IActionResult AddQuantity(Guid i)
        {
            var item = shoppingCart.GetCartItem(i.ToString());
            if (item != null)
            {
                item.Quantity = item.Quantity + 1;
            }
            return RedirectToAction("ListCart");
        }
        public IActionResult RemoveQuantity(Guid i) 
        {
            var item = shoppingCart.GetCartItem(i.ToString());
            if (item != null && item.Quantity > 0)
            {
                item.Quantity = item.Quantity - 1;
            }
            return RedirectToAction("ListCart");
        }


    }
}