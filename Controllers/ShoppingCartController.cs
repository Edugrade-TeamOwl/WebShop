using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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

        [HttpPost]
        public async Task <IActionResult> Checkout(List <Product> product)
        {
            var user = await _userManager.GetUserAsync(User);
            var order = new Order
            {
                Adress="",
                City="",
                ZipCode="",
                OrderedAt=DateTime.Now,
                UserId=user.Id
            };
            _appDbContext.Add(order);
            var orderid = await _appDbContext.SaveChangesAsync();
            List <OrderDetail> orderdetail = new List<OrderDetail>();

            foreach (var item in product)
            {
                var detail = new OrderDetail { ProductId = item.ProductId, ProductQuantity = 1, OrderId = orderid };
                orderdetail.Add(detail);
            }
            _appDbContext.AddRange(orderdetail);
            await _appDbContext.SaveChangesAsync();

            return RedirectToAction("CheckoutComplete");
        }
        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage = "Tack för din beställning";
            return View();
        }
    }
}
