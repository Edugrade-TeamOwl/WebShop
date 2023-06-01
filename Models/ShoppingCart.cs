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
    public Product GetCartItem(string id)
    {
        return cartItems.FirstOrDefault(x => x.ProductId.ToString() == id);
    }


    //Total price calc
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

    public void EmptyCart()
    {
        cartItems.Clear();
    }

    public void RemoveCartItem(int i)
    {
        cartItems.RemoveAt(i);
    }
}