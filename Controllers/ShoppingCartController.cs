using Microsoft.AspNetCore.Mvc;
using WebShop.Models;

namespace WebShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ShoppingCart shoppingCart;

        public ShoppingCartController(ShoppingCart shoppingCart)
        {
            this.shoppingCart = shoppingCart;
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

    }
}
