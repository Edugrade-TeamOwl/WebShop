using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using WebShop.Models;

public class ShoppingCart
{
    [Key]
    public int ShoppingCartId { get; set; }
    private List<Product> cartItems;

    public ShoppingCart()
    {
        cartItems = new List<Product>();
    }

    public void AddToCart(Product item)
    {
        cartItems.Add(item);
    }

    public List<Product> GetCartItems()
    {
        return cartItems;
    }


    //Shopping cart item calculator
    public decimal CalculateTotal()
    {
        List<Product> cartItems = GetCartItems();
        decimal total = 0;

        foreach (var item in cartItems)
        {
            total += item.ProductPrice; 
        }

        return total;
    }
}
