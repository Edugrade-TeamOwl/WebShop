using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebShop.Areas.Identity.Data;
using WebShop.Models;
using WebShop.ViewModels.DTO;

namespace WebShop.Controllers
{
    public class OrderController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart shoppingCart;

        public OrderController(AppDbContext appDbContext, UserManager<ApplicationUser> userManager, ShoppingCart shoppingCart)
        {
            _userManager = userManager;
            _appDbContext = appDbContext;
            this.shoppingCart = shoppingCart;
        }


        [HttpPost]
        public async Task<IActionResult> CreateOrder(OrderDTO orderDTO)
        {
            List<Product> cartItems = shoppingCart.GetCartItems();
            decimal totalOrderAmount = shoppingCart.CalculateTotal();


            var user = await _userManager.GetUserAsync(User);
            var order = new Order
            {
                FirstName = orderDTO.FirstName,
                LastName = orderDTO.LastName,
                Adress = orderDTO.Adress,
                City = orderDTO.City,
                ZipCode = orderDTO.ZipCode,
                OrderedAt = DateTime.Now,
                UserId = user.Id,
                TotalOrderAmount = totalOrderAmount,

            };
            _appDbContext.Add(order);
            await _appDbContext.SaveChangesAsync();
            List<OrderDetail> orderdetail = new List<OrderDetail>();

            foreach (var item in cartItems)
            {
                var detail = new OrderDetail { ProductId = item.ProductId, ProductQuantity = 1, OrderId = order.OrderId };
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